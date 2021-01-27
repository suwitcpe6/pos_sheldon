Imports Control_us
Imports Newtonsoft.Json
Imports System.Threading.Thread
Imports System.Globalization
Imports MD

Public Class F_Setting
    Public No_con As Boolean = False
    Private Sub F_Seting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = F_Main.Icon
        TabControl_US1.TabPages.Remove(TB_systemconfig)
        TabControl_US1.TabPages.Remove(TB_structure)
        'TabControl_US1.TabPages.Remove(TB_wallet)


        'btn_save_config.Enabled = False
        Dim f As New F_pass
        'Timer1.Enabled = False
        If f.ShowDialog() = DialogResult.OK Then
            'System.Threading.Thread.CurrentThread.CurrentUICulture = New CultureInfo("US")
            txt_api.Text = ""
            set_default()
            load_config()




            If Me.No_con = True Then
                Load_config_base()

            End If

        Else
            Messages.Texts("NO Config", "รหัสผ่านไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            Me.Dispose()
        End If


    End Sub


    Private Sub load_config()
        Me.txt_api.Text = Center.Data_Config.API_SRV

    End Sub
    Private Sub set_default()

        'RadioButton_off.Tag = Center.ProgramMode.OFF
        'RadioButton_pos.Tag = Center.ProgramMode.POS

        ''txt_api.SetPlaceholder("ODBC for Touchpos")
        ''Textbox_UC2.SetPlaceholder("192.168.102.163")
        ''Textbox_UC3.SetPlaceholder("000.000.000.000")
        ''Textbox_UC4.SetPlaceholder("SA")
        ''Textbox_UC5.SetPlaceholder("1234")
        ''Textbox_UC6.SetPlaceholder("FOOD")

        'Prop_Form.prop_pupup_nosize(Me)
        ''txt_api.SetPlaceholder(" Set API ")




    End Sub

    Private Function Load_config_base() As Boolean
        Try
            Dim ret As New Data_Config_Model.value
            Dim json = New API(Center.Data_Config.API_SRV,).GETSON(String.Format(Center.Get_API.Select_Config, ""))
            If IsNothing(json) Then Return False
            ret = (JsonConvert.DeserializeObject(Of Data_Config_Model.value)(json))
            If ret.Respon.Result Then
                Me.Txt_paht_srv.Text = ret.Data.SysVersion.path

                Me.cbo_CUSGROUP.SelectedValue = ret.Data.SysConfig.CUSGROUP
                Me.cbo_WALLET_TYPE.SelectedValue = ret.Data.SysConfig.WALLET_TYPE
                Me.cbo_CONN_LINK.SelectedValue = ret.Data.SysConfig.CONN_LINK
                Me.cbo_vender.SelectedValue = ret.Data.SysConfig.VENDOR_GETWAY

                'If ret.Data.SysConfig.USESTOCK = True Then
                chk_usestock.Checked = ret.Data.SysConfig.USESTOCK
                'Else
                'End If

                If ret.Data.SysConfig.POSTYPE = RB_prepaid.Tag Then
                    RB_prepaid.Checked = CheckState.Checked
                ElseIf ret.Data.SysConfig.POSTYPE = RB_postpaid.Tag Then
                    RB_postpaid.Checked = CheckState.Checked
                Else
                    RB_prepaid.Checked = CheckState.Unchecked
                    RB_postpaid.Checked = CheckState.Unchecked
                End If




                Return True
            Else
                If ret.Respon.ErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.ErrorMessage)
                Else
                    Throw New Exception(ret.Respon.SystemErrorMessage)
                End If

            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return False
        End Try
    End Function


    Private Sub Button_US1_Click(sender As Object, e As EventArgs) Handles btn_test_conn.Click
        test_conn()
    End Sub

    Private Function test_conn() As Boolean
        'Dim F_Loding As New loadding
        Try
            Center.Data_Config.API_SRV = Me.txt_api.Text.Trim




            If Me.txt_api.Text.Trim = "" Then
                Messages.Texts("NO Config", " คุณยังไม่ได้ตั้งลิงค์ API ไม่สามารถโหลดร้านค้าได้ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                Return False
            End If
            Dim dt_shop As New DataTable
            Dim ret As New ResponseMessage
            Dim json = New API(Center.Data_Config.API_SRV,).GETSON(Center.Get_API.Test_Connect & "Test_connect", Me.txt_api.Text.Trim)
            If IsNothing(json) Then
                Messages.Texts("API False", " เชื่อมต่อ API ไม่สำเร็จ หรือ Link API ไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                Return False
            End If
            ret = (JsonConvert.DeserializeObject(Of ResponseMessage)(json))

            If ret.Respon.Result Then

                btn_test_conn.Image = My.Resources.pass50x50
                'Messages.Texts("Test connect", "เชื่อมต่อ API สำเร็จ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)

                Load_config_base()
                Messages.Texts("ทดสอบ", "ผลการทดสอบสมบูรณ์", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                btn_save_config.Enabled = True

                Return True
            Else
                btn_test_conn.Image = My.Resources.Notpass50x50
                Throw New Exception("Error : " & vbNewLine & ret.Respon.ErrorMessage)
            End If

        Catch ex As Exception
            If ex.Message = "Invalid URI: Invalid port specified." Then
                Messages.Texts("Error", "Error เชื่อมต่อ API ไม่สำเร็จ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            Else
                Msg_err.Show_Err(ex, Me.Text)
            End If
            Return False
        Finally
            'F_Loding.loadding_close()
        End Try
    End Function

    Private Sub Button_US3_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Application.Exit()
    End Sub

    Private Sub btn_save_config_Click(sender As Object, e As EventArgs) Handles btn_save_config.Click
        Try

            Dim saveconfig As New CL_config
            Dim value As New data_config


            If txt_api.Text = "" Then
                Messages.Texts("Save Config", "กรุณาใส่ Server API", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Sub
            End If
            value.API_SRV = txt_api.Text


            If Saveconfig_base() Then
                If saveconfig.SaveConfigXML_MSSQL(value) Then
                    Messages.Texts("Save Config", "บันทึกการตั้งค่าสำเร็จ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Dispose()
                Else
                    Messages.Texts("Save Config", "บันทึกการตั้งค่าไม่สำเร็จ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                End If

            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Public Function Saveconfig_base() As Boolean

        Try


            'If Me.cbo_CUSGROUP.SelectedValue = "" Then
            '    Messages.Texts("Save Config", "กรุณาเลือก กลุ่มลูกค้า", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            '    TabControl_US1.SelectedTab = TB_systemconfig
            '    Return False
            'End If
            'If Me.cbo_WALLET_TYPE.SelectedValue = "" Then
            '    Messages.Texts("Save Config", "กรุณาเลือก ประเภท Gatway", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            '    TabControl_US1.SelectedTab = TB_systemconfig
            '    Return False
            'End If


            'If Me.cbo_WALLET_TYPE.SelectedValue = "EDC" Then

            '    If Me.cbo_CONN_LINK.SelectedValue = "" Then
            '        Messages.Texts("Save Config", "กรุณาเลือก การเชื่อมต่อ  :", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            '        TabControl_US1.SelectedTab = TB_systemconfig
            '        Return False
            '    End If


            '    If Me.cbo_vender.SelectedValue = "" Then
            '        Messages.Texts("Save Config", "กรุณาเลือก Vendor  ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            '        TabControl_US1.SelectedTab = TB_systemconfig
            '        Return False
            '    End If




            'End If


            Dim data As Data_Config_Model.Data_Config = New Data_Config_Model.Data_Config


            data.SysVersion.sysNo = "1"
            data.SysVersion.sysName = "POS"
            data.SysVersion.path = Txt_paht_srv.Text

            data.SysConfig.ITEMSNO = "1"
            data.SysConfig.CUSGROUP = "" 'cbo_CUSGROUP.SelectedValue
            data.SysConfig.VENDOR_GETWAY = "" 'cbo_vender.SelectedValue
            data.SysConfig.CONN_LINK = "" 'cbo_CONN_LINK.SelectedValue
            data.SysConfig.WALLET_TYPE = "" 'cbo_WALLET_TYPE.SelectedValue

            data.SysConfig.USESTOCK = True 'chk_usestock.Checked


            If RB_prepaid.Checked Then
                data.SysConfig.POSTYPE = "" 'RB_prepaid.Tag
            Else
                data.SysConfig.POSTYPE = "" 'RB_postpaid.Tag
            End If



            Dim json As String = JsonConvert.SerializeObject(data)
            Dim siteUri As New Uri(Center.Data_Config.API_SRV + Center.Post_API.MAS_Save_Config)
            Dim ret = New API(Center.Data_Config.API_SRV,).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As Data_Config_Model.value = JsonConvert.DeserializeObject(Of Data_Config_Model.value)(ret)

            If retValue.Respon.Result Then
                Return True
            Else
                If retValue.Respon.SystemErrorMessage <> "" Then
                    'จากระบบ
                    Throw New Exception(retValue.Respon.SystemErrorMessage)
                Else
                    Messages.Texts("Save Config", retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
                Return False
            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, "Save config")
            Return False
        Finally

        End Try
    End Function

    Private Sub Button_US1_Click_1(sender As Object, e As EventArgs) Handles Button_US1.Click
        Update_structure()
    End Sub
    Private Sub Update_structure()
        Try
            Label_US23.ForeColor = Color.DimGray
            p_successfull.Visible = False
            P_notsuccess.Visible = False

            If Messages.Texts("การแจ้งเตือน", "คุณต้องการอัพเดทฐานข้อมูลใช่หรือไม่" & vbNewLine & " คำเตื่อน :: การอัพเดทฐานข้อมูลจะทำให้โครงสร้างทั้งหมดเปลี่ยนไปตามรูปแบบที่โปรแกรมกำหนด ควรปรึกษาทีมงานก่อนทำการอัพเดท ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Stopp) = DialogResult.No Then
                Exit Sub
            End If
            Label_US23.Text = "กำลังอัพเดทฐานข้อมูล"
            Dim ret As New ResponseMessage
            Dim json = New API(Center.Data_Config.API_SRV, 120).GETSON(Center.Get_API.UpdateStructure)
            If IsNothing(json) Then GoTo A
            ret = (JsonConvert.DeserializeObject(Of ResponseMessage)(json))
            If ret.Respon.Result Then
                Messages.Texts("การแจ้งเตือน", "อัพเดทฐานข้อมูลเสร็จเรียบร้อย", Messages.ButtonType.Sucess, Messages.MessageBoxIcon.Sucess)
                Label_US23.Text = "อัพเดทฐานข้อมูลเสร็จเรียบร้อย"
                Label_US23.ForeColor = Color.Green
                p_successfull.Visible = True
            Else
A:
                Label_US23.Text = "อัพเดทฐานข้อมูลไม่สำเร็จ"
                Label_US23.ForeColor = Color.Red
                P_notsuccess.Visible = True
                If ret.Respon.ErrorMessage <> "" Then
                    Messages.Texts("การแจ้งเตือน", ret.Respon.SystemErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    Exit Sub
                Else
                    Throw New Exception("Error : " & vbNewLine & ret.Respon.SystemErrorMessage)
                End If

            End If
        Catch ex As Exception
            Label_US23.Text = "อัพเดทฐานข้อมูลไม่สำเร็จ"
            Label_US23.ForeColor = Color.Red
            P_notsuccess.Visible = True
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Private Sub Button_US7_Click(sender As Object, e As EventArgs)
        Dim fl As New FolderBrowserDialog
        fl.ShowDialog()
        Me.Txt_paht_srv.Text = fl.SelectedPath


    End Sub

    Private Sub cbo_WALLET_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_WALLET_TYPE.SelectedIndexChanged, Combobox_US2.SelectedIndexChanged
        Try


            If IsNothing(cbo_WALLET_TYPE.SelectedValue) Then Exit Sub

            If cbo_WALLET_TYPE.SelectedValue = "EDC" Then
                cbo_CONN_LINK.Enabled = True
                cbo_vender.Enabled = True
            ElseIf cbo_WALLET_TYPE.SelectedValue = "API" Then
                cbo_CONN_LINK.Enabled = False
                cbo_vender.Enabled = False
            Else
                cbo_CONN_LINK.Enabled = False
                cbo_CONN_LINK.SelectedValue = ""
                cbo_vender.Enabled = False
                cbo_vender.SelectedValue = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbo_WALLET_TYPE_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_WALLET_TYPE.SelectionChangeCommitted, Combobox_US2.SelectionChangeCommitted

    End Sub

    Private Sub CheckBox1_US1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_US1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_US7_Click_1(sender As Object, e As EventArgs) Handles Button_US7.Click

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            Txt_paht_srv.Text = FolderBrowserDialog1.SelectedPath

        End If
    End Sub
End Class
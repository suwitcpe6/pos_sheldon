Imports Control_us
Imports Newtonsoft.Json
Imports System.Threading.Thread
Imports System.Globalization
Imports MD

Public Class F_Setting
    Public No_con As Boolean = False
    Private Sub F_Seting_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TabControl_US1.TabPages.Remove(TB_POSUPDATE)
        'TabControl_US1.TabPages.Remove(TB_wallet)


        'btn_save_config.Enabled = False
        Dim f As New F_pass
        'Timer1.Enabled = False
        If f.ShowDialog() = DialogResult.OK Then
            'System.Threading.Thread.CurrentThread.CurrentUICulture = New CultureInfo("US")
            txt_api.Text = ""
            set_default()
            load_config()

            Load_CUSGROUP()
            Load_WALLET_TYPE()
            Load_CONN_LINK()
            Load_vender()



            If Me.No_con = True Then
                Load_config_base()
                scanport()
                Load_shop()
            End If

        Else
            Messages.Texts("NO Config", "รหัสผ่านไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            Me.Dispose()
        End If


    End Sub
    Private Sub Load_CUSGROUP()

        Try

            Dim dt As New DataTable
            dt.Columns.Add("Code")
            dt.Columns.Add("Name")
            dt.Rows.Add("", "---------เลือก----------")
            dt.Rows.Add(CL_constan.CUSGROUP.CPN, "Central")
            dt.Rows.Add(CL_constan.CUSGROUP.HOMEPRO, "Home Pro")
            dt.Rows.Add(CL_constan.CUSGROUP.Top, "Top")
            dt.Rows.Add(CL_constan.CUSGROUP.ATR, "ASIATIQUE The Riverfront")
            dt.Rows.Add(CL_constan.CUSGROUP.OTHER, "Other")


            cbo_CUSGROUP.DataSource = dt
            cbo_CUSGROUP.DisplayMember = "Name"
            cbo_CUSGROUP.ValueMember = "Code"
            cbo_CUSGROUP.SelectedValue = ""



        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub Load_WALLET_TYPE()

        Try

            Dim dt As New DataTable
            dt.Columns.Add("Code")
            dt.Columns.Add("Name")
            dt.Rows.Add("", "---------เลือก----------")
            dt.Rows.Add("Nowallet", "ไม่ใช้งาน Wallet")
            dt.Rows.Add("EDC", "EDC")
            dt.Rows.Add("API", "API")
            dt.Rows.Add("APIHUBCPN", "API Payment Hub CPN")


            cbo_WALLET_TYPE.DataSource = dt
            cbo_WALLET_TYPE.DisplayMember = "Name"
            cbo_WALLET_TYPE.ValueMember = "Code"
            cbo_WALLET_TYPE.SelectedValue = ""



        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub Load_CONN_LINK()

        Try

            Dim dt As New DataTable
            dt.Columns.Add("Code")
            dt.Columns.Add("Name")
            dt.Rows.Add("", "---------เลือก----------")
            dt.Rows.Add("WIFI", "WIFI")
            dt.Rows.Add("BT", "BlueTooth")
            'dt.Rows.Add("USB", "USB(Comport)")

            cbo_CONN_LINK.DataSource = dt
            cbo_CONN_LINK.DisplayMember = "Name"
            cbo_CONN_LINK.ValueMember = "Code"
            cbo_CONN_LINK.SelectedValue = ""



        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub Load_vender()

        Try

            Dim dt As New DataTable
            dt.Columns.Add("Code")
            dt.Columns.Add("Name")
            dt.Rows.Add("", "---------เลือก----------")
            dt.Rows.Add("GHL", "GHL")


            cbo_vender.DataSource = dt
            cbo_vender.DisplayMember = "Name"
            cbo_vender.ValueMember = "Code"
            cbo_vender.SelectedValue = ""



        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub load_config()
        Me.txt_api.Text = Center.Data_Config.API

        If Center.Data_Config.CUSDISPLAY = Me.rd_Monitor.Tag Then
            Me.rd_Monitor.Checked = True
        ElseIf Center.Data_Config.CUSDISPLAY = Me.rd_comport.Tag Then
            Me.rd_comport.Checked = True
        Else
            Me.rd_None.Checked = True
        End If


        Me.cbo_comport.Text = Center.Data_Config.COMPORT
        If Center.Data_Config.SLIDESHOW = Me.rd_SLIDESHOW_E.Tag Then
            Me.rd_SLIDESHOW_E.Checked = True

        Else
            Me.rd_SLIDESHOW_D.Checked = True
        End If
        Me.txt_dafault_display.Text = Center.Data_Config.dafault_display
        If Center.Data_Config.SHOWNETSALE = Me.rd_shownet_s.Tag Then
            Me.rd_shownet_s.Checked = True
        Else
            Me.rd_shownet_not.Checked = True
        End If

        If Center.Data_Config.MultiCards = Me.rd_multicard_E.Tag Then
            Me.rd_multicard_E.Checked = True
        Else
            Me.rd_multicard_D.Checked = True
        End If
        Me.txt_GroupmenuQTY.Text = Center.Data_Config.GroupmenuQTY
        Me.txt_menuQTY.Text = Center.Data_Config.menuQTY

        Me.txt_refresh_screen.Text = Center.Data_Config.refresh_screen
        Me.txt_ip.Text = Center.Data_Config.IP






        'If Center.Data_Config.ProgramMode = CL_constan.ProgramMode.OFF Then
        '    RadioButton_off.Checked = True
        'Else
        RadioButton_pos.Checked = True
        'End If


    End Sub
    Private Sub set_default()

        RadioButton_off.Tag = CL_constan.ProgramMode.OFF
        RadioButton_pos.Tag = CL_constan.ProgramMode.POS

        'txt_api.SetPlaceholder("ODBC for Touchpos")
        'Textbox_UC2.SetPlaceholder("192.168.102.163")
        'Textbox_UC3.SetPlaceholder("000.000.000.000")
        'Textbox_UC4.SetPlaceholder("SA")
        'Textbox_UC5.SetPlaceholder("1234")
        'Textbox_UC6.SetPlaceholder("FOOD")

        Prop_Form.prop_pupup_nosize(Me)
        'txt_api.SetPlaceholder(" Set API ")




    End Sub

    Private Function Load_config_base() As Boolean
        Try
            Dim ret As New Data_Config_Model.value
            Dim json = New API(Center.Data_Config.API,).GETSON(String.Format(Center.Link_API.Get_API.Select_Config, ""))
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




    Private Function Load_shop() As Boolean
        Try
            If Me.txt_api.Text.Trim = "" Then
                Messages.Texts("NO Config", " คุณยังไม่ได้ตั้งลิงค์ API ไม่สามารถโหลดร้านค้าได้ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                Return False
            End If

            Dim dt_shop As New DataTable
            Dim ret As New SHOP_ModelS.value
            Dim json = New API(Center.Data_Config.API,).GETSON(Center.Link_API.Get_API.shop_loaddata & "0", Me.txt_api.Text.Trim)
            If IsNothing(json) Then Return False
            ret = (JsonConvert.DeserializeObject(Of SHOP_ModelS.value)(json))
            If ret.Respon.Result Then

                dt_shop = New API(Center.Data_Config.API,).ToDataTable(Of SHOP_ModelS.Model)(ret.Data)
                If ret.Data.Count > 0 Then
                    Dim dt_pos1 As DataTable = dt_shop.Copy
                    cbo_pos1.DataSource = dt_pos1
                    cbo_pos1.DisplayMember = "SHOPNAME"
                    cbo_pos1.ValueMember = "SHOPID"
                    cbo_pos1.SelectedValue = -1


                    Dim dt_pos2 As DataTable = dt_shop.Copy
                    cbo_pos2.DataSource = dt_pos2
                    cbo_pos2.DisplayMember = "SHOPNAME"
                    cbo_pos2.ValueMember = "SHOPID"
                    cbo_pos1.SelectedValue = -1


                    Dim dt_pos3 As DataTable = dt_shop.Copy
                    cbo_pos3.DataSource = dt_pos3
                    cbo_pos3.DisplayMember = "SHOPNAME"
                    cbo_pos3.ValueMember = "SHOPID"
                    cbo_pos3.SelectedIndex = -1


                    Dim dt_pos4 As DataTable = dt_shop.Copy
                    cbo_pos4.DataSource = dt_pos4
                    cbo_pos4.DisplayMember = "SHOPNAME"
                    cbo_pos4.ValueMember = "SHOPID"
                    cbo_pos4.SelectedIndex = -1

                    Me.txt_ip.Text = Center.Data_Config.IP
                    If Center.Data_Config.SHOP_list(0).SHOP_ID <> 0 Then
                        Me.cbo_pos1.SelectedValue = Center.Data_Config.SHOP_list(0).SHOP_ID
                    Else
                        cbo_pos1.Text = "เลือก"
                    End If
                    If Center.Data_Config.SHOP_list(1).SHOP_ID <> 0 Then
                        Me.cbo_pos2.SelectedValue = Center.Data_Config.SHOP_list(1).SHOP_ID
                    Else
                        cbo_pos2.Text = "เลือก"
                    End If
                    If Center.Data_Config.SHOP_list(2).SHOP_ID <> 0 Then
                        Me.cbo_pos3.SelectedValue = Center.Data_Config.SHOP_list(2).SHOP_ID
                    Else
                        cbo_pos3.Text = "เลือก"
                    End If
                    If Center.Data_Config.SHOP_list(3).SHOP_ID <> 0 Then
                        Me.cbo_pos4.SelectedValue = Center.Data_Config.SHOP_list(3).SHOP_ID
                    Else
                        cbo_pos4.Text = "เลือก"
                    End If

                Else
                    cbo_pos1.DataSource = Nothing
                    cbo_pos1.Text = ""
                    cbo_pos2.DataSource = Nothing
                    cbo_pos2.Text = ""
                    cbo_pos3.DataSource = Nothing
                    cbo_pos3.Text = ""
                    cbo_pos4.DataSource = Nothing
                    cbo_pos4.Text = ""

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
    Function scanport()
        Try


            Dim dt_port As New DataTable
            dt_port.Columns.Add("Pcode")
            dt_port.Columns.Add("Pshow")
            Dim drow As DataRow
            drow = dt_port.NewRow

            For Each sp As String In My.Computer.Ports.SerialPortNames
                drow = dt_port.NewRow
                drow("Pcode") = sp
                drow("Pshow") = sp
                dt_port.Rows.Add(drow)
            Next
            cbo_comport.DataSource = dt_port
            cbo_comport.DisplayMember = "Pcode"
            cbo_comport.ValueMember = "Pcode"
            cbo_comport.SelectedIndex = 0

        Catch ex As Exception

        End Try
        Return True
    End Function


    Private Sub Button_US1_Click(sender As Object, e As EventArgs) Handles btn_test_conn.Click
        test_conn()
    End Sub

    Private Function test_conn() As Boolean
        'Dim F_Loding As New loadding
        Try
            Center.Data_Config.API = Me.txt_api.Text.Trim
            'F_Loding.load()
            Dim lcd As New COMPORT
            If rd_comport.Checked = True And Me.cbo_comport.Text.Trim <> "" Then
                If lcd.Set_SP_Value(Me.SerialPort1, Me.cbo_comport.Text.Trim) Then
                    If Center.Data_Config.COMPORT <> "" Then
                        lcd.Print(txt_dafault_display.Text, txt_dafault_display.Text, Me.SerialPort1, Center.Data_Config.COMPORT)
                    Else
                        GoTo a
                    End If
                Else
a:
                    Messages.Texts("NO Config", " ตั้งค่า COMPORT Customer Display ไม่ถูกต้อง ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Return False
                End If
            End If

            If Me.txt_api.Text.Trim = "" Then
                Messages.Texts("NO Config", " คุณยังไม่ได้ตั้งลิงค์ API ไม่สามารถโหลดร้านค้าได้ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                Return False
            End If
            Dim dt_shop As New DataTable
            Dim ret As New ResponseMessage
            Dim json = New API(Center.Data_Config.API,).GETSON(Center.Link_API.Get_API.Test_Connect & "Test_connect", Me.txt_api.Text.Trim)
            If IsNothing(json) Then
                Messages.Texts("API False", " เชื่อมต่อ API ไม่สำเร็จ หรือ Link API ไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                Return False
            End If
            ret = (JsonConvert.DeserializeObject(Of ResponseMessage)(json))

            If ret.Respon.Result Then

                btn_test_conn.Image = My.Resources.pass50x50
                'Messages.Texts("Test connect", "เชื่อมต่อ API สำเร็จ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                If Not Load_shop() Then
                    Throw New Exception("เชื่อมต่อ API ไม่สำเร็จ" & "Error : " & vbNewLine & ret.Respon.ErrorMessage)
                End If
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

            value.API = Me.txt_api.Text
            If rd_Monitor.Checked Then
                value.CUSDISPLAY = rd_Monitor.Tag
            ElseIf rd_comport.Checked Then
                value.CUSDISPLAY = rd_comport.Tag
            ElseIf rd_None.Checked Then
                value.CUSDISPLAY = rd_None.Tag
            Else
                value.CUSDISPLAY = ""
            End If
            value.COMPORT = cbo_comport.Text
            If rd_SLIDESHOW_E.Checked Then
                value.SLIDESHOW = rd_SLIDESHOW_E.Tag
            Else
                value.SLIDESHOW = rd_SLIDESHOW_D.Tag
            End If
            value.dafault_display = Me.txt_dafault_display.Text
            If rd_shownet_s.Checked Then
                value.SHOWNETSALE = rd_shownet_s.Tag
            Else
                value.SHOWNETSALE = rd_shownet_not.Tag
            End If

            If rd_multicard_E.Checked Then
                value.MultiCards = rd_multicard_E.Tag
            Else
                value.MultiCards = rd_multicard_D.Tag
            End If
            value.IP = Me.txt_ip.Text
            For i As Integer = 0 To value.SHOP_list.Count - 1
                value.SHOP_list(i) = New Shop_list
                value.SHOP_list(i).SHOP_ID = 0
                value.SHOP_list(i).SHOP_Name = ""
            Next
            Dim select_shop As Boolean = False
            If Me.cbo_pos1.SelectedValue <> 0 And cbo_pos1.Text.Trim <> "เลือก" And cbo_pos1.Text.Trim <> "" Then
                value.SHOP_list(0).SHOP_ID = cbo_pos1.SelectedValue
                value.SHOP_list(0).SHOP_Name = cbo_pos1.Text
                select_shop = True
            End If
            If Me.cbo_pos2.SelectedValue <> 0 And cbo_pos2.Text.Trim <> "เลือก" And cbo_pos2.Text.Trim <> "" Then
                value.SHOP_list(1).SHOP_ID = cbo_pos2.SelectedValue
                value.SHOP_list(1).SHOP_Name = cbo_pos2.Text
                select_shop = True
            End If
            If Me.cbo_pos3.SelectedValue <> 0 And cbo_pos3.Text.Trim <> "เลือก" And cbo_pos3.Text.Trim <> "" Then
                value.SHOP_list(2).SHOP_ID = cbo_pos3.SelectedValue
                value.SHOP_list(2).SHOP_Name = cbo_pos3.Text
                select_shop = True
            End If
            If Me.cbo_pos4.SelectedValue <> 0 And cbo_pos4.Text.Trim <> "เลือก" And cbo_pos4.Text.Trim <> "" Then
                value.SHOP_list(3).SHOP_ID = cbo_pos4.SelectedValue
                value.SHOP_list(3).SHOP_Name = cbo_pos4.Text
                select_shop = True
            End If
            If txt_api.Text = "" Then
                Messages.Texts("Save Config", "กรุณาใส่ Server API", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Sub
            End If
            If select_shop = False Then
                Messages.Texts("Save Config", "กรุณาเลือกร้านค้า", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Sub
            End If
            If txt_GroupmenuQTY.Text = 0 Then
                Messages.Texts("Save Config", "กรุณาใส่ โชว์กลุ่มเมนู", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Sub
            End If
            If txt_menuQTY.Text = 0 Then
                Messages.Texts("Save Config", "กรุณาใส่ โชว์เมนู", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Sub
            End If
            If txt_refresh_screen.Text = 0 Then
                Messages.Texts("Save Config", "กรุณาใส่เวลาล้างหน้าจอ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Sub
            End If

            value.GroupmenuQTY = txt_GroupmenuQTY.Text
            value.menuQTY = txt_menuQTY.Text
            value.refresh_screen = txt_refresh_screen.Text


            'If RadioButton_off.Checked = True Then
            '    value.ProgramMode = RadioButton_off.Tag
            'Else
            value.ProgramMode = RadioButton_pos.Tag
            'End If


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


            If Me.cbo_CUSGROUP.SelectedValue = "" Then
                Messages.Texts("Save Config", "กรุณาเลือก กลุ่มลูกค้า", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                TabControl_US1.SelectedTab = TB_systemconfig
                Return False
            End If
            If Me.cbo_WALLET_TYPE.SelectedValue = "" Then
                Messages.Texts("Save Config", "กรุณาเลือก ประเภท Gatway", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                TabControl_US1.SelectedTab = TB_systemconfig
                Return False
            End If


            If Me.cbo_WALLET_TYPE.SelectedValue = "EDC" Then

                If Me.cbo_CONN_LINK.SelectedValue = "" Then
                    Messages.Texts("Save Config", "กรุณาเลือก การเชื่อมต่อ  :", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    TabControl_US1.SelectedTab = TB_systemconfig
                    Return False
                End If


                If Me.cbo_vender.SelectedValue = "" Then
                    Messages.Texts("Save Config", "กรุณาเลือก Vendor  ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    TabControl_US1.SelectedTab = TB_systemconfig
                    Return False
                End If




            End If


            Dim data As Data_Config_Model.Data_Config = New Data_Config_Model.Data_Config


            data.SysVersion.sysNo = "1"
            data.SysVersion.sysName = "POS"
            data.SysVersion.path = Txt_paht_srv.Text

            data.SysConfig.ITEMSNO = "1"
            data.SysConfig.CUSGROUP = cbo_CUSGROUP.SelectedValue
            data.SysConfig.VENDOR_GETWAY = cbo_vender.SelectedValue
            data.SysConfig.CONN_LINK = cbo_CONN_LINK.SelectedValue
            data.SysConfig.WALLET_TYPE = cbo_WALLET_TYPE.SelectedValue

            data.SysConfig.USESTOCK = chk_usestock.Checked


            If RB_prepaid.Checked Then
                data.SysConfig.POSTYPE = RB_prepaid.Tag
            Else
                data.SysConfig.POSTYPE = RB_postpaid.Tag
            End If



            Dim json As String = JsonConvert.SerializeObject(data)
            Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.Save_Config)
            Dim ret = New API(Center.Data_Config.API,).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As SALE_Models.value = JsonConvert.DeserializeObject(Of SALE_Models.value)(ret)

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


    'Private Sub rd_EpsonCode_Click(sender As Object, e As EventArgs) Handles rd_EpsonCode.Click
    '    cbo_comport.Enabled = False
    'End Sub


    Private Sub txt_refresh_screen_Leave(sender As Object, e As EventArgs) Handles txt_refresh_screen.Leave
        If CInt(txt_refresh_screen.Text) < 10 Then
            Messages.Texts("ตั้งค่าไม่ถูกต้อง", "กรุณาใส่ข้อมูลไม่ต่ำกว่า 10 วินาที", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            txt_refresh_screen.Text = 10
        End If
    End Sub

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
            Dim json = New API(Center.Data_Config.API, 120).GETSON(Center.Link_API.Get_API.UpdateStructure)
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

    Private Sub Button_US2_Click(sender As Object, e As EventArgs) Handles Button_US2.Click
        Try
            cbo_pos1.SelectedIndex = -1
            cbo_pos1.Text = "เลือก"
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button_US3_Click_1(sender As Object, e As EventArgs) Handles Button_US3.Click
        cbo_pos2.SelectedIndex = -1
        cbo_pos2.Text = "เลือก"

    End Sub

    Private Sub Button_US4_Click(sender As Object, e As EventArgs) Handles Button_US4.Click
        cbo_pos3.SelectedIndex = -1
        cbo_pos3.Text = "เลือก"

    End Sub

    Private Sub Button_US5_Click(sender As Object, e As EventArgs) Handles Button_US5.Click
        cbo_pos4.SelectedIndex = -1
        cbo_pos4.Text = "เลือก"

    End Sub

    Private Sub Button_US6_Click(sender As Object, e As EventArgs) Handles Button_US6.Click
        txt_ip.Text = ""
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_usestock.CheckedChanged
        If chk_usestock.Checked Then
            RadioButton_off.Checked = True
        Else

        End If
    End Sub

    Private Sub rd_comport_CheckedChanged(sender As Object, e As EventArgs) Handles rd_comport.CheckedChanged
        If rd_comport.Checked Then
            cbo_comport.Enabled = True
            txt_dafault_display.US_Enable = True
        Else
            cbo_comport.Enabled = False
            txt_dafault_display.US_Enable = False
        End If
    End Sub

    Private Sub Button_US7_Click_1(sender As Object, e As EventArgs) Handles Button_US7.Click

    End Sub


    'Private Sub Rd_NONE_CheckedChanged(sender As Object, e As EventArgs) Handles rd_NONE.CheckedChanged

    'End Sub

    'Private Sub rd_NONE_Click(sender As Object, e As EventArgs) Handles rd_NONE.Click
    '    cbo_comport.Enabled = True
    'End Sub
End Class
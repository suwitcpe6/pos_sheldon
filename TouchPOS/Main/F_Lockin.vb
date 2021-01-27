
Imports Control_us
Imports MD
Imports Newtonsoft.Json
Imports Blackoffice
Public Class F_Lockin
    Dim AUTO_UPDATE As New AUTO_UPDATE

    Private Sub Button_US1_Click(sender As Object, e As EventArgs) Handles Button_US1.Click
        Application.Exit()
    End Sub

    Private Sub F_Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Version



        Label2.Text = "Version " & AUTO_UPDATE.version
        lbl_pos_lastupdate.Text = Replace(AUTO_UPDATE.version_InRoom, "_", " ")


        AUTO_UPDATE.SaveConfigSYSVersion()

        'txt_user.SetPlaceholder("User")
        'txt_password.SetPlaceholder("Passowrd")

        Dim val = New CL_config().LoadConfigXML_MSSQL
        If val Then
            Dim val2 = New CL_config().test_conn("")
            If val2 Then
                Update_exe()

                'If Center.Data_Config.ProgramMode = CL_constan.ProgramMode.POS Then
                Timer1.Enabled = True
                    Panel4.Visible = False
                    'Else
                    '    Panel4.Visible = True
                    '    txt_user.Focus()
                    'End If

                Else
                'Messages.Texts("NO Config", " คุณยังไม่ได้ตั้งลิงค์ API ไม่สามารถโหลดร้านค้าได้ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                'config(True)

                If Center.Data_Config.API.Trim = "" Then
                    Messages.Texts("NO Config", " คุณยังไม่ได้ตั้งลิงค์ API ไม่สามารถโหลดร้านค้าได้ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    config(True)
                    'Else
                    '    Messages.Texts("ขาดการเชื่อมต่อ", " เชื่อมต่อเซิร์ฟเวอร์ไม่สำเร็จ " & vbNewLine & " กรุณาตรวจสอบการการตั้งค่า หรือระบบเครือข่าย ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)

                End If

            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        show_sale()

    End Sub
    Private Sub show_sale()
        Try
            Timer1.Enabled = False

            'Dim dt As DataTable
            Dim ret2 As New WORKINGDATE_Models.value
            Dim json2 = New API(Center.Data_Config.API,).GETSON(Center.Link_API.Get_API.WORKINGDATE & "")
            ret2 = (JsonConvert.DeserializeObject(Of WORKINGDATE_Models.value)(json2))

            If ret2.Respon.Result Then
                'dt = New API(Center.Data_Config.API,).ToDataTable(Of WORKINGDATE_Models.Model)(ret2.Data)
                If ret2.Data.Count <= 0 Then
                    Timer1.Enabled = False
                    Messages.Texts("Working Date", "ไม่ได้กำหนดวันทำงาน Working Date กรุณาแจ้งผู้ดูแลระบบ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Application.Exit()
                    Exit Sub
                End If
            Else
                If ret2.Respon.ErrorMessage <> "" Then
                    Throw New Exception(ret2.Respon.ErrorMessage)
                Else
                    Throw New Exception(ret2.Respon.SystemErrorMessage)
                End If

            End If
            Load_config()


            F_Main_Sale.Show()
            F_Main_Sale.txtdatetime.Text = "วันที่ " & ret2.Data(0).DATEWORKING.Date
            Center.DATEWORKING = ret2.Data(0).DATEWORKING.Date
            Me.Hide()

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub Load_config()
        Try

            Dim ret2 As New SysConfig.value
            Dim json2 = New API(Center.Data_Config.API,).GETSON(Center.Link_API.Get_API.Config_Load & "")
            ret2 = (JsonConvert.DeserializeObject(Of SysConfig.value)(json2))
            If ret2.Respon.Result Then
                If ret2.Data.Count > 0 Then

                    Center.SYS_Config.ITEMSNO = ret2.Data(0).ITEMSNO
                    Center.SYS_Config.CUSGROUP = ret2.Data(0).CUSGROUP
                    Center.SYS_Config.VENDOR_GETWAY = ret2.Data(0).VENDOR_GETWAY
                    Center.SYS_Config.CONN_LINK = ret2.Data(0).CONN_LINK
                    Center.SYS_Config.WALLET_TYPE = ret2.Data(0).WALLET_TYPE

                    Center.SYS_Config.USESTOCK = ret2.Data(0).USESTOCK
                    Center.SYS_Config.POSTYPE = ret2.Data(0).POSTYPE
                Else
                    Messages.Texts("Load data config", "ไม่พบการตั้งค่าระบบ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Application.Exit()
                    Exit Sub
                End If
            Else
                If ret2.Respon.ErrorMessage <> "" Then
                    Throw New Exception(ret2.Respon.ErrorMessage)
                Else
                    Throw New Exception(ret2.Respon.SystemErrorMessage)
                End If

            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Function Update_exe() As Boolean
        Try
            If InStr(Application.StartupPath, "bin", CompareMethod.Text) > 0 Then
                'ส่วนของ code
                'AUTO_UPDATE.UpdateStucture()
            Else
                'ส่วนของ EXE
                If AUTO_UPDATE.version_CheckMRP("") Then Return False
            End If

            Label2.Text = "Version " & AUTO_UPDATE.version
            lbl_pos_lastupdate.Text = Replace(AUTO_UPDATE.version_InRoom, "_", " ")

            Dim ret_ver As New API_VersionModels.value
            Dim json2_ver = New API(Center.Data_Config.API,).GETSON(Center.Link_API.Get_API.API_Version)
            Module1.API_version = json2_ver
            lbl_api_lastupdate.Text = Replace(Replace(Module1.API_version, "_", " "), """", "")

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return False
        End Try
    End Function

    Private Sub btn_config_Click(sender As Object, e As EventArgs) Handles btn_config.Click

        Dim val = New CL_config().LoadConfigXML_MSSQL
        If val Then
            Dim val2 = New CL_config().test_conn("")
            'If val2 Then
            '    config(False)
            'Else
            'If Center.Data_Config.API = "" Then
            'Messages.Texts("NO Config", " คุณยังไม่ได้ตั้งลิงค์ API ไม่สามารถโหลดร้านค้าได้ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            config(val2)
            'Else
            '    Messages.Texts("ขาดการเชื่อมต่อ", " เชื่อมต่อ API ไม่สำเร็จ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)

            'End If

            'End If
        End If

    End Sub
    Public Sub config(val As Boolean)
        Timer1.Enabled = False
        Dim f As New F_Setting
        f.No_con = val
        If f.ShowDialog() = DialogResult.OK Then
            Dim val2 = New CL_config().LoadConfigXML_MSSQL



            If Center.Data_Config.ProgramMode = CL_constan.ProgramMode.OFF Then
                Panel4.Visible = True

            Else

                show_sale()
            End If




        End If
    End Sub
    Private Sub Button_US2_Click(sender As Object, e As EventArgs) Handles Button_US2.Click

        Try
            'If Center.Data_Config.ProgramMode = CL_constan.ProgramMode.POS Then
            show_sale()
            'ElseIf Center.Data_Config.ProgramMode = CL_constan.ProgramMode.OFF Then



            '    'Blackoffice.Center.Data_Config.API_SRV = Center.Data_Config.API
            '    'Blackoffice.Center.data_profile.user_id = txt_user.Text  ' Center.data_profile.user_id
            '    'F_Main.Show()
            '    'Me.Hide()
            '    login()
            'End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try


    End Sub
    Private Sub login()
        Try

            If Me.txt_user.Text.Trim = "" Then
                Messages.Texts(Me.Text, "กรุณาใส่ User ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Sub
            End If
            If Me.txt_password.Text.Trim = "" Then
                Messages.Texts(Me.Text, "กรุณาใส่ รหัสผ่าน ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Sub
            End If



            Dim conn_api As New API(Center.Data_Config.API)
            Dim Link As String
            Dim json_Response As String
            Link = String.Format(Center.Link_API.Get_API.USERPROFILE_Select, Me.txt_user.Text.Trim)

            json_Response = conn_api.GETSON(Link)
            Dim ret As New USERPROFILE_Mmodels.value
            ret = (JsonConvert.DeserializeObject(Of USERPROFILE_Mmodels.value)(json_Response))
            If ret.Respon.Result Then

                If ret.Data.Count > 0 Then
                    If ret.Data(0).UID = Me.txt_user.Text.Trim Then '
                        If ret.Data(0).UPASSWORD = Me.txt_password.Text.Trim Then '


                            Dim lib_lad As Object = CL_LibLoading.LoadAssembly("Blackoffice", "F_Main")
                            If lib_lad Is Nothing Then Throw New Exception("Black Office Not found !!!")

                            lib_lad.Data_Config.API_SRV = Center.Data_Config.API
                            lib_lad.data_profile.user_id = txt_user.Text

                            lib_lad.data_profile.BRNID = "" 'Center.data_profile.BRNID
                            lib_lad.data_profile.BRNCODE = "" 'center.data_profile.BRNCODE


                            Me.Hide()
                            'F_Main.Data_Config.API_SRV = Center.Data_Config.API
                            'F_Main.data_profile.user_id = txt_user.Text

                            'F_Main.data_profile.BRNID = "" 'Center.data_profile.BRNID
                            'F_Main.data_profile.BRNCODE = "" 'center.data_profile.BRNCODE
                            'Me.F_Main.Show()

                            lib_lad.Show()
                            lib_lad.BringToFront()


                        Else
                            Messages.Texts(Me.Text, "ไม่พบรหัสผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                        End If
                    Else
                        Messages.Texts(Me.Text, "ไม่พบรหัสผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    End If
                Else
                    Messages.Texts(Me.Text, "ไม่พบรหัสผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                End If


            Else

                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage.ToString)
                Else
                    If ret.Respon.SystemErrorMessage <> "" Then
                        Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Else
                        Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    End If
                End If
            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Private Sub Button_US23_Click(sender As Object, e As EventArgs) Handles Button_US23.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub txt_user_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_user.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_password.Focus()
        End If
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class

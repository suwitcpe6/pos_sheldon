
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





        'txt_user.SetPlaceholder("User")
        'txt_password.SetPlaceholder("Passowrd")

        Dim val = New CL_config().LoadConfigXML_MSSQL
        If val Then
            Dim val2 = New CL_config().test_conn("")
            If val2 Then
                Update_exe()


                Panel4.Visible = True
                    txt_user.Focus()

            Else
                'Messages.Texts("NO Config", " คุณยังไม่ได้ตั้งลิงค์ API ไม่สามารถโหลดร้านค้าได้ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                'config(True)

                If Center.Data_Config.API_SRV.Trim = "" Then
                    Messages.Texts("NO Config", " คุณยังไม่ได้ตั้งลิงค์ API ไม่สามารถโหลดร้านค้าได้ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    config(True)
                    'Else
                    '    Messages.Texts("ขาดการเชื่อมต่อ", " เชื่อมต่อเซิร์ฟเวอร์ไม่สำเร็จ " & vbNewLine & " กรุณาตรวจสอบการการตั้งค่า หรือระบบเครือข่าย ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)

                End If

            End If
        End If
    End Sub


    Private Function Update_exe() As Boolean
        Try

            'If AUTO_UPDATE.version_Check("") Then Return False

            If InStr(Application.StartupPath, "bin", CompareMethod.Text) > 0 Then
                'ส่วนของ code
                'AUTO_UPDATE.UpdateStucture()
            Else
                'ส่วนของ EXE
                If AUTO_UPDATE.version_Check("") Then Return False
            End If

            Label2.Text = "Version " & AUTO_UPDATE.version
            lbl_pos_lastupdate.Text = Replace(AUTO_UPDATE.version_InRoom, "_", " ")

            Dim ret_ver As New API_VersionModels.value
            Dim json2_ver = New API(Center.Data_Config.API_SRV,).GETSON(Center.Get_API.API_Version)
            Module1.API_version = json2_ver
            lbl_api_lastupdate.Text = Replace(Replace(Module1.API_version, "_", " "), """", "")
            'If lbl_api_lastupdate.Text <> lbl_pos_lastupdate.Text Then
            '    Messages.Texts("เวอร์ชั่นไม่ตรงกัน", " Version Program กับ API ไม่ตรงกัน  ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            '    Application.Exit()
            'End If
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




            Panel4.Visible = True


            End If
    End Sub
    Private Sub Button_US2_Click(sender As Object, e As EventArgs) Handles Button_US2.Click

        Try

            login()

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



            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String
            Link = String.Format(Center.Get_API.USERPROFILE_Select, Me.txt_user.Text.Trim)

            json_Response = conn_api.GETSON(Link)
            Dim ret As New USERPROFILE_Mmodels.value
            ret = (JsonConvert.DeserializeObject(Of USERPROFILE_Mmodels.value)(json_Response))
            If ret.Respon.Result Then

                If ret.Data.Count > 0 Then
                    If ret.Data(0).UID = Me.txt_user.Text.Trim Then '
                        If ret.Data(0).UPASSWORD = Me.txt_password.Text.Trim Then '



                            Center.date_now = ret.Data(0).date_now
                            Center.Data_Config.API_SRV = Center.Data_Config.API_SRV
                            Center.data_profile.user_id = txt_user.Text
                            If LoadMenu_permission(Center.data_profile.user_id) Then
                                F_Main.genmenu()
                                F_Main.Show()
                                Me.Hide()
                                Me.txt_password.Text = ""
                            End If

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
    Private Function LoadMenu_permission(uid As String) As Boolean
        Try

            Dim ret As New MenuModel.value
            Dim json = New API(Center.Data_Config.API_SRV).GETSON(String.Format(Center.Get_API.Load_Menus_permis, uid))
            ret = (JsonConvert.DeserializeObject(Of MenuModel.value)(json))
            If ret.Respon.Result Then
                Center.dt_menu = New API(Center.Data_Config.API_SRV).ToDataTable(Of MenuModel.Model)(ret.Data)
                Return True
            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage.ToString)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                End If
            End If
            Return False
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return False
        End Try
    End Function
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

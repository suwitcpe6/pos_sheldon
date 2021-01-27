Imports Control_us
Imports Newtonsoft.Json
Imports MD
Public Class CL_config

    Public Function Gentable() As DataTable
        Dim dtWrite As New DataTable
        Dim dsWrite = New DataSet
        Try
            dsWrite.Tables.Add(dtWrite)
            dtWrite.Columns.Add("API")
            dtWrite.Columns.Add("CUSDISPLAY")
            dtWrite.Columns.Add("COMPORT")
            dtWrite.Columns.Add("dafault_display")
            dtWrite.Columns.Add("SLIDESHOW")
            dtWrite.Columns.Add("SHOWNETSALE")
            dtWrite.Columns.Add("MULTICARDS")
            dtWrite.Columns.Add("IP")
            dtWrite.Columns.Add("SHOPID1")
            dtWrite.Columns.Add("SHOPNAME1")
            dtWrite.Columns.Add("SHOPID2")
            dtWrite.Columns.Add("SHOPNAME2")
            dtWrite.Columns.Add("SHOPID3")
            dtWrite.Columns.Add("SHOPNAME3")
            dtWrite.Columns.Add("SHOPID4")
            dtWrite.Columns.Add("SHOPNAME4")
            dtWrite.Columns.Add("GroupmenuQTY")
            dtWrite.Columns.Add("menuQTY")
            dtWrite.Columns.Add("refresh_screen")
            'dtWrite.Columns.Add("ProgramMode")



            Return dtWrite
        Catch ex As Exception
        Finally
            dtWrite = Nothing
            dsWrite = Nothing
        End Try
    End Function
    Public Function SaveConfigXML_MSSQL(Data_Config As data_config) As Boolean
        Try
            Dim dtWrite As DataTable
            dtWrite = Gentable()
            Dim drow As DataRow

            drow = dtWrite.NewRow

            drow("API") = Data_Config.API
            drow("CUSDISPLAY") = Data_Config.CUSDISPLAY
            drow("COMPORT") = Data_Config.COMPORT
            drow("dafault_display") = Data_Config.dafault_display
            drow("SLIDESHOW") = Data_Config.SLIDESHOW
            drow("SHOWNETSALE") = Data_Config.SHOWNETSALE
            drow("MULTICARDS") = Data_Config.MultiCards

            drow("IP") = Data_Config.IP
            drow("SHOPID1") = Data_Config.SHOP_list(0).SHOP_ID
            drow("SHOPNAME1") = Data_Config.SHOP_list(0).SHOP_Name

            drow("SHOPID2") = Data_Config.SHOP_list(1).SHOP_ID
            drow("SHOPNAME2") = Data_Config.SHOP_list(1).SHOP_Name

            drow("SHOPID3") = Data_Config.SHOP_list(2).SHOP_ID
            drow("SHOPNAME3") = Data_Config.SHOP_list(2).SHOP_Name

            drow("SHOPID4") = Data_Config.SHOP_list(3).SHOP_ID
            drow("SHOPNAME4") = Data_Config.SHOP_list(3).SHOP_Name

            drow("GroupmenuQTY") = If(Data_Config.GroupmenuQTY <= 0, 6, Data_Config.GroupmenuQTY)
            drow("menuQTY") = If(Data_Config.menuQTY <= 0, 8, Data_Config.menuQTY)
            drow("refresh_screen") = If(Data_Config.refresh_screen <= 0, 10, Data_Config.refresh_screen)
            'drow("ProgramMode") = Data_Config.ProgramMode


            dtWrite.Rows.Add(drow)
            dtWrite.WriteXml(My.Application.Info.DirectoryPath & "\APPConfig.XML")

            Return True
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.GetType().Name)
            Return False
        End Try
    End Function
    Public Function LoadConfigXML_MSSQL() As Boolean
        Try
            Dim dtWrite As DataTable
            dtWrite = Gentable()
            dtWrite.ReadXml(My.Application.Info.DirectoryPath & "\APPConfig.XML")

            For i As Integer = 0 To Center.Data_Config.SHOP_list.Count - 1
                Center.Data_Config.SHOP_list(i) = New Shop_list
                Center.Data_Config.SHOP_list(i).SHOP_ID = 0
                Center.Data_Config.SHOP_list(i).SHOP_Name = ""
            Next

            With Center.Data_Config
                .API = dtWrite.Rows(0)("API")
                .CUSDISPLAY = dtWrite.Rows(0)("CUSDISPLAY")
                .COMPORT = dtWrite.Rows(0)("COMPORT")
                .dafault_display = dtWrite.Rows(0)("dafault_display")
                .SLIDESHOW = dtWrite.Rows(0)("SLIDESHOW")
                .SHOWNETSALE = dtWrite.Rows(0)("SHOWNETSALE")
                .MultiCards = dtWrite.Rows(0)("MULTICARDS")
                .Auto_update = True
                .IP = If(IsDBNull(dtWrite.Rows(0)("IP")), "", dtWrite.Rows(0)("IP"))
                If dtWrite.Rows(0)("SHOPID1") <> "" Then
                    Center.Data_Config.SHOP_list(0).SHOP_ID = dtWrite.Rows(0)("SHOPID1")
                    Center.Data_Config.SHOP_list(0).SHOP_Name = dtWrite.Rows(0)("SHOPNAME1")
                End If
                If dtWrite.Rows(0)("SHOPID2") <> "" Then
                    Center.Data_Config.SHOP_list(1).SHOP_ID = dtWrite.Rows(0)("SHOPID2")
                    Center.Data_Config.SHOP_list(1).SHOP_Name = dtWrite.Rows(0)("SHOPNAME2")
                End If
                If dtWrite.Rows(0)("SHOPID3") <> "" Then
                    Center.Data_Config.SHOP_list(2).SHOP_ID = dtWrite.Rows(0)("SHOPID3")
                    Center.Data_Config.SHOP_list(2).SHOP_Name = dtWrite.Rows(0)("SHOPNAME3")
                End If
                If dtWrite.Rows(0)("SHOPID4") <> "" Then
                    Center.Data_Config.SHOP_list(3).SHOP_ID = dtWrite.Rows(0)("SHOPID4")
                    Center.Data_Config.SHOP_list(3).SHOP_Name = dtWrite.Rows(0)("SHOPNAME4")
                End If
                Try
                    .GroupmenuQTY = dtWrite.Rows(0)("GroupmenuQTY")
                    .menuQTY = dtWrite.Rows(0)("menuQTY")
                Catch ex As Exception
                    .GroupmenuQTY = 6
                    .menuQTY = 8
                End Try
                Try
                    .refresh_screen = dtWrite.Rows(0)("refresh_screen")
                Catch ex As Exception
                    .refresh_screen = 30
                End Try
                .ProgramMode = "" 'dtWrite.Rows(0)("ProgramMode")
            End With

            Return True
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.GetType().Name)
        End Try
    End Function

    Public Function test_conn(api As String) As Boolean
        Try
            'If api = "" Then
            '    Messages.Texts("NO Config", " คุณยังไม่ได้ตั้งลิงค์ API ไม่สามารถโหลดร้านค้าได้ ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            '    Return False
            'End If
            Dim dt_shop As New DataTable
            Dim ret As New ResponseMessage
            Dim json = New API(Center.Data_Config.API,).GETSON(Center.Link_API.Get_API.Test_Connect & "Test_connect", api)
            If IsNothing(json) Then Return False
            ret = (JsonConvert.DeserializeObject(Of ResponseMessage)(json))
            If ret.Respon.Result Then
                Return True
            Else
                Throw New Exception("Error : " & vbNewLine & ret.Respon.ErrorMessage)
                'Return False
            End If

        Catch ex As Exception
            If ex.Message = "Invalid URI: Invalid port specified." Then
                Messages.Texts("Error", "Error เชื่อมต่อ API ไม่สำเร็จ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            Else
                Msg_err.Show_Err(ex, "test_conn")
            End If
        End Try
    End Function




End Class

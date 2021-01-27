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

            drow("API") = Data_Config.API_SRV

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
                .API_SRV = dtWrite.Rows(0)("API")


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
            Dim json = New API(Center.Data_Config.API_SRV,).GETSON(Center.Get_API.Test_Connect & "Test_connect", api)
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

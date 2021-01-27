Imports Newtonsoft.Json
Imports MD
Public Class CL_getdate
    Public Function Getdate_Realtime() As DateTime
        'Try
        Dim ret2 As New SHOP_Buttons_Model.value
        Dim json2 = New API(Center.Data_Config.API, 2).GETSON(Center.Link_API.Get_API.Getdate)
        Dim Valdate As WORKINGDATE_Models.Date_now_Models = (JsonConvert.DeserializeObject(Of WORKINGDATE_Models.Date_now_Models)(json2))
        'If IsNothing(Valdate) Then
        '    Return Nothing
        'End If
        Return Valdate.Date_now
        'Catch ex As Exception

        'End Try
    End Function
    Public Function Getdate() As DateTime
        Try
            Dim ret2 As New SHOP_Buttons_Model.value
            Dim json2 = New API(Center.Data_Config.API, 2).GETSON(Center.Link_API.Get_API.Getdate)
            Dim Valdate As WORKINGDATE_Models.Date_now_Models = (JsonConvert.DeserializeObject(Of WORKINGDATE_Models.Date_now_Models)(json2))
            If IsNothing(Valdate) Then
                Return Nothing
            End If
            Return Valdate.Date_now
        Catch ex As Exception
            Throw New Exception("ดึงเวลาจาก Server ไม่สำเร็จ กรุณาตรวจสอบการเชื่อมต่อ")
        End Try
    End Function


End Class

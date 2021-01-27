Imports Newtonsoft.Json
Imports Control_us
Imports MD

Public Class Sale_Promotion

#Region "Promotion"
    ''' <summary>
    ''' call fixed pro 19 
    ''' </summary>
    ''' <param name="barcode"></param>
    ''' <returns></returns>
    Public Function Chk_promotion(barcode As String, data As DataTable) As Boolean
        Try

            Dim CHKcard_Pro As New CHKcard_MultiModels
            Dim ret As New Card_pro.value

            CHKcard_Pro.BARCODE = barcode
            CHKcard_Pro.Nettotel = 0

            Dim json As String = JsonConvert.SerializeObject(CHKcard_Pro)
            Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.CardsCL_card_pro)
            Dim retValue = New API(Center.Data_Config.API,).POSTResponse(siteUri, json, "POST", "")
            ret = (JsonConvert.DeserializeObject(Of Card_pro.value)(retValue))
            If ret.Respon.Result Then
                If ret.Data.Count > 0 Then
                    If data.Rows.Count > 1 Then
                        Messages.Texts("Promotion", "บัตร โปร 19 ทรูพอยท์ ฟรีน้ำคริสตัล 1 ขวด  " & vbNewLine & " สามารถทำรายการขายได้ 1 รายการเท่านั้น ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                        Return False
                    End If
                    If data.Rows(0)("MRTAMOUNT") = "7" Then
                        Return True
                    Else
                        Messages.Texts("Promotion", "บัตร โปร 19 ทรูพอยท์ ฟรีน้ำคริสตัล 1 ขวด  " & vbNewLine & " สามารถทำรายการขายได้ กับสินค้าราคา 7 บาท เท่านั้น ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                        Return False
                    End If
                Else
                    Return True
                    'Throw New Exception("ไม่พบโปรโมชั่น  โปร 19 ทรูพอยท์ ฟรีน้ำคริสตัล 1 ขวด   " & vbNewLine & " บัตร " & barcode)
                End If
            Else

                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage)
                Else
                    Messages.Texts("Promotion", ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                End If

            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, "Promotion")
            Return False
        End Try
    End Function



#End Region

End Class

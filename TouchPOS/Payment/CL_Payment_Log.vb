Imports MD
Imports Newtonsoft.Json
Public Class CL_Payment_Log

    Public Const Request As String = "Request"
    Public Const Query As String = "Query"
    Public Const Cancel As String = "Cancel"

    Public Class MD_data
        Public TENDERCODE As String
        Public DOCNO As String
        Public TENDERDOCNO As String
        Public MERCHAND_ID As String
        Public LOG_TYPE As String
        Public DATA_TYPE As String
        Public DATA1 As String
        Public DATA2 As String
        Public STATUS As String = "1"
        Public REMARK1 As String = ""
        Public REMARK3 As String = ""

        Public [CDATE] As DateTime = Date.Now 'เริ่ม
        Public MODATE As DateTime = Date.Now 'สิ้นสุด
    End Class
    Public Function Payment_Log(data As MD_data) As Boolean
        Try
            Dim model As New Tender_LogModel


            model.TID = "0"
            model.TENDERCODE = data.TENDERCODE
            model.DOCNO = data.DOCNO
            model.TENDERDOCNO = data.TENDERDOCNO
            model.TERMINALID = Center.data_profile.TERMINAL_TID
            model.POSID = Center.data_profile.POSID
            model.MERCHAND_ID = data.MERCHAND_ID
            model.LOG_TYPE = data.LOG_TYPE
            model.DATA_TYPE = data.DATA_TYPE
            model.DATA1 = data.DATA1
            model.DATA2 = data.DATA2
            model.REMARK1 = data.REMARK1
            model.REMARK2 = ""
            model.REMARK3 = data.REMARK3
            model.STATUS = data.STATUS
            model.CBY = Center.data_profile.Emp_code
            model.CDATE = data.[CDATE]
            model.MBY = Center.data_profile.Emp_code
            model.MODATE = data.MODATE


            Dim json As String = JsonConvert.SerializeObject(model)
            Dim siteUri As New Uri(Center.Data_Config.API + Center.Link_API.Post_API.Tender_Log_SAVE_Tender_Log)
            Dim ret = New API(Center.Data_Config.API).POSTResponse(siteUri, json, "POST", "")
            Dim retValue As SALE_Models.value = JsonConvert.DeserializeObject(Of SALE_Models.value)(ret)

            Return True
            'If retValue.Respon.Result Then
            '    Return True
            'Else
            '    If retValue.Respon.SystemErrorMessage <> "" Then
            '        'จากระบบ
            '        Throw New Exception(retValue.Respon.SystemErrorMessage)
            '    Else
            '        Messages.Texts(Me.Text, retValue.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            '        Return False
            '    End If
            'End If

        Catch ex As Exception
            'Msg_err.Show_Err(ex, Me.Text)
            Return True
        End Try
    End Function
End Class

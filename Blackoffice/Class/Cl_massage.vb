Imports Control_us

Public Class Cl_massage


    'Public Class error_massage
    Public Const err As String = "พบข้อผิดพลาด"

    Public Const err_Gendoc_number As String = "ไม่พบเลขที่เอกสาร"
    Public Const err_Gendoc_number_st As String = "ไม่พบเลขที่เอกสารคุมสต๊อก"
    Public Const err_Gendoc_number_mas As String = "ไม่พบรหัส"

    Public Const err_save_H As String = "ไม่พบเลขที่เอกสาร"
    Public Const err_save_D As String = "ไม่พบเลขที่เอกสาร"
    'End Class
    'Public Class Alert_Header

    Public Const Alert_Headere01 As String = "ข้อความแจ้งเตือน"
    Public Const Alert_Headere02 As String = "ผิดพลาด"
    'End Class
    'Public Class Alert
    Public Const Alert_Nofile As String = "ไม่พบไฟล์แนบ"
    Public Const Alert_chk01 As String = "ข้อมูลต่อมไปนี้มีอยู่แล้ว"
    'End Class
    'Public Class AlertInput
    Public Const AlertInputData01 As String = "กรุณาระบุข้อมูล "
    'End Class
    'Public Class Alert_check
    Public Const Alert_Pass_01 As String = "ไม่พบข้อมูลผู้ใช้ระบบหรือรหัสผ่านไม่ถูกต้อง"
    'End Class

    'Public Class Confirm
    Public Const ConfirmSave01 As String = "ต้องการบันทึกข้อมูลใช่หรือไม่ ?"
    Public Const ConfirmSave_success As String = "บันทึกข้อมูลเรียบร้อย"
    Public Const ConfirmSave_not_success As String = "บันทึกข้อมูลไม่สำเร็จ"
    Public Const ConfirmSave_Cancelsave As String = "คุณต้องการออกจากหน้านี้ใช่หรือไม่"
    Public Const ConfirmSave_Cancel As String = "คุณต้องการยกเลิกเอกสารใช่หรือไม่"
    Public Const Confirmcancel_success As String = "ยกเลิกเรียบร้อย"

    Public Const ConfirmSave_Delete As String = "คุณต้องการลบเอกสารใช่หรือไม่"
    Public Const Confirmcancel_Delete As String = "ลบเรียบร้อย"
    Public Const Selectdata_Delete As String = "กรุณาเลือกรายการที่ต้องการลบ"

    Public Const Edit_Not_found_data As String = "กรุณาเลือกข้อมูล"

    'End Class
    'Public Class Search
    Public Const SCR01 As String = "ไม่พบข้อมูลที่ค้นหา ?"
    'End Class



    Public Const EDC_msg_wallet_Notconfig As String = "ไม่พบการตั้งค่า ประเภท Wallet"



End Class
Public Class Msg_err

    Public Shared Sub Show_Err(ByRef ex1 As Exception, f_name As String)
        Dim a = New Msg_err().ERR_Point(ex1)

        'MessageBox.Show(ex1.Message & vbNewLine _
        '          & vbNewLine & " Description --> " & f_name & vbNewLine & a _
        '   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'MessageBox.Show(ex1.Message & vbNewLine _
        '          & vbNewLine & " Description --> " & f_name & vbNewLine & a _
        '          , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)




        Messages.Texts("Error", ex1.Message & vbNewLine _
                  & vbNewLine & " Description --> " & f_name & vbNewLine & a _
                  , Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)

        'Messages.Texts("Error", ex1.Message _
        '         , Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
    End Sub
    Public Shared Function Return_Err(ex1 As Exception, f_name As String) As String
        Dim msg As String = ""
        Dim a = New Msg_err().ERR_Point(ex1)
        msg = ex1.Message & vbNewLine &
        vbNewLine & " Description --> " & f_name & vbNewLine & a
        Return msg
    End Function

    Public Function ERR_Point(ByRef ex1 As Exception) As String
        Try
            Dim st As New StackTrace(True)
            st = New StackTrace(ex1, True)
            Dim Method As String = ""

            For Each frame As StackFrame In st.GetFrames
                Method &= " Method : " & frame.GetMethod().ToString
                Method &= " Err : " & frame.GetFileLineNumber() & vbNewLine
            Next

            Return Method
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class


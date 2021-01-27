Public Class Error_
    Public Function ERR_Point(ByRef ex1 As Exception) As String
        Try


            Dim st As New StackTrace(True)
            st = New StackTrace(ex1, True)
            'Dim line As String = st.GetFrame(0).GetFileLineNumber().ToString
            'Dim Method As String = st.GetFrame(0).GetMethod().ToString
            'Dim Method2 As String = st.GetFrame(1).GetMethod.ToString
            Dim Method As String = ""
            'Dim line As String = ""


            For Each frame As StackFrame In st.GetFrames
                Method &= " Method : " & frame.GetMethod().ToString
                Method &= " Err : " & frame.GetFileLineNumber() & vbNewLine
            Next


            'MessageBox.Show(ex.Message & vbNewLine _
            '               & f_name & " Method : " & Method & " Err " & line _
            '    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'MessageBox.Show(ex.Message & vbNewLine _
            '              & f_name & vbNewLine & Method _
            '   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Method
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class

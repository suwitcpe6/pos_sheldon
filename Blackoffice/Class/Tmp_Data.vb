Public Class Tmp_Data
    Public Shared Function selecttop() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("value")
        dt.Columns.Add("name")
        dt.Rows.Add("50", "50")
        dt.Rows.Add("100", "100")
        dt.Rows.Add("500", "500")
        dt.Rows.Add("1000", "1000")
        dt.Rows.Add("ALL", "ALL")
        Return dt
    End Function

    Public Shared Function MOV_IDC() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("value", System.Type.GetType("System.Int32"))
        dt.Columns.Add("name", System.Type.GetType("System.String"))

        dt.Rows.Add("0", "เลือก")
        dt.Rows.Add("1", "จำนวนเพิ่ม")
        dt.Rows.Add("-1", "จำนวนลด")

        Return dt
    End Function

End Class

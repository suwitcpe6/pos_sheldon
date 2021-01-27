Public Class Date_time
    Public Function Condate(ByVal val As Date, format_ As String, ByVal Optional dateType As String = "ENG") As String
        'Dim dd As Integer = Format(CDate(val), "dd")
        'Dim MM As Integer = Format(CDate(val), "MM")
        Dim yyyy As Integer = Format(CDate(val), "yyyy")

        Dim date_ As String = val
        If dateType = "ENG" Then
            If yyyy > 2500 Then
                date_ = DateAdd(DateInterval.Year, -543, val)
            End If
        Else
            If yyyy < 2500 Then
                date_ = DateAdd(DateInterval.Year, 543, val)
            End If
        End If
        date_ = CDate(date_).ToString(format_)
        Return date_
    End Function
End Class

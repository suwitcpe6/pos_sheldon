Public Class Barcode
    Public Function BarcodeChkDigit(ByVal myBarcode As String, ByVal barlen As Integer) As String

        Dim iCount, i, j, iSum, iModAns As Integer
        Dim sLastDigit, sChkDigit, sChr, sVal As String
        Dim aChrVal(42, 2) As String

        Dim n, m As Integer
        For n = 0 To 9
            For m = 1 To 2
                aChrVal(n, m) = CStr(n)
            Next m
        Next n
        For n = 10 To 35
            For m = 1 To 2
                aChrVal(n, m) = IIf(m = 1, Chr(n + 55), n)
            Next m
        Next n


        aChrVal(36, 1) = "-"
        aChrVal(36, 2) = "36"    'ลบ

        aChrVal(37, 1) = "."
        aChrVal(37, 2) = "37"    'จุด

        aChrVal(38, 1) = " "
        aChrVal(38, 2) = "38"    'space

        aChrVal(39, 1) = "$"
        aChrVal(39, 2) = "39"

        aChrVal(40, 1) = "/"
        aChrVal(40, 2) = "40"

        aChrVal(41, 1) = "+"
        aChrVal(41, 2) = "41"

        aChrVal(42, 1) = "%"
        aChrVal(42, 2) = "42"

        sLastDigit = Right$(myBarcode, 1)
        '    The sum of the characters Barcode
        iSum = 0
        For iCount = 1 To Len(Left$(myBarcode, barlen))
            sChr = Mid(myBarcode, iCount, 1)
            For i = 0 To 42
                If sChr = aChrVal(i, 1) Then
                    iSum = iSum + Val(aChrVal(i, 2))
                    Exit For    'i
                Else
                End If
            Next i
        Next iCount

        '           Check the character mod43
        iModAns = iSum Mod 43
        For i = 0 To 42
            For j = 1 To 2
                If iModAns = aChrVal(i, 2) Then
                    BarcodeChkDigit = aChrVal(i, 1)
                    Exit For    'j
                Else
                End If
            Next j
        Next i
        Erase aChrVal

    End Function
End Class

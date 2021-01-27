Public Class Gensclip
    Public Shared Function Gensclip_int(ByVal t As String, ByVal c As IList(Of data)) As String
        'EX  'EX  'EX  'EX  'EX
        'Dim a As New List(Of Gensclip.data)
        'a.Add(New Gensclip.data With {.column = "pcode", .value = Textbox_New1.Text})
        'a.Add(New Gensclip.data With {.column = "pname", .value = Textbox_New2.Text})
        'a.Add(New Gensclip.data With {.column = "brand", .value = Textbox_New3.Text})
        'a.Add(New Gensclip.data With {.column = "unit", .value = Textbox_New4.Text})
        'Textbox_New5.Text = Gensclip.Genscljip_int("product", a)
        'EX  'EX  'EX  'EX  'EX

        Dim column As String = ""
        Dim value As String = ""
        For Each val As data In c
            If column = "" Then
                column = val.column
            Else
                column &= "," & val.column
            End If
            If value = "" Then
                If val.is_command Then
                    value = val.value
                Else
                    value = "'" & val.value & "'"
                End If
            Else
                If val.is_command Then
                    value &= "," & val.value
                Else
                    value &= ",'" & val.value & "'"
                End If
            End If
        Next

        Dim H As String
        Dim V As String
        H = " insert into  " & t & " ( " & column & ")"
        V = " values ( " & value & ")"
        H &= vbNewLine & V
        Return H

    End Function
    Public Shared Function Gensclip_UPD(ByVal t As String, ByVal c As IList(Of data)) As String
        'EX  'EX  'EX  'EX  'EX
        'Dim a As New List(Of Gensclip.data)
        'a.Add(New Gensclip.data With {.column = "pcode", .value = Textbox_New1.Text})
        'a.Add(New Gensclip.data With {.column = "pname", .value = Textbox_New2.Text})
        'a.Add(New Gensclip.data With {.column = "brand", .value = Textbox_New3.Text})
        'a.Add(New Gensclip.data With {.column = "unit", .value = Textbox_New4.Text})
        'Textbox_New5.Text = Gensclip.Genscljip_int("product", a)
        'EX  'EX  'EX  'EX  'EX

        Dim column As String = ""

        For Each val As data In c
            If column = "" Then
                column = val.column
                If val.is_command Then
                    column &= " = " & val.value
                Else
                    column &= " = '" & val.value & "'"
                End If
            Else
                column &= "," & val.column
                If val.is_command Then
                    column &= " = " & val.value
                Else
                    column &= " = '" & val.value & "'"
                End If
            End If
        Next
        'เงือนไขไปต่อเองข้างนอก
        Return " Update  " & t & " set  " & column

    End Function
    Public Class data
        Public column As String
        Public value As String
        Public is_command As Boolean
    End Class
End Class

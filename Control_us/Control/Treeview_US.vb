Public Class Treeview_US
    Inherits TreeView
    Dim f_sim As New F_simple
    Sub New()
        US_Default()
    End Sub
    Private Sub US_Default()
        Me.Font = Center.Us_font

    End Sub
    Private Sub US_Reconfig()
        'Me.Font = New System.Drawing.Font(""Leelawadee UI"", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        'Me.BackColor = Color.Green ' Color.Orange
        'Me.ForeColor = Color.White
        'Me.Width = 120
        'Me.Height = 40
        'Me.FlatStyle = FlatStyle.Flat
        'Me.FlatAppearance.BorderColor = Color.White
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Try
            MyBase.WndProc(m)

            'MsgBox(m.Msg)

            Dim a = Me.Tag
            Select Case m.Msg

                Case 129
                    US_Reconfig()
                Case &H7, &H8, &H200, &H2A3
                    'US_Reconfig()
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Methord"
    Public Function Searchnode(ByVal value As String)
        Me.SelectedNode = Nothing
        Me.Focus()
        Dim text As String = String.Empty
        text = value
        Dim a As Boolean = True
        If text <> String.Empty Then
            Try
                Dim node As Int16 = Me.Nodes.Count
                For i As Integer = 0 To node
                    Dim arr As TreeNode() = Me.Nodes(i).Nodes.Find(text, a)
                    If arr.Length > 0 Then
                        Me.CollapseAll()
                        'e.Node.Expand()
                        Me.SelectedNode = arr(0)
                        Me.Focus()
                    Else
                        Me.SelectedNode = Nothing
                    End If
                Next

            Catch ex As Exception

            End Try
        End If
        Return True
    End Function
    Public Function Addiconnode(ByVal img As Image)
        '  Create a new ImageList
        Dim MyImages As New ImageList()
        '  Set size property
        MyImages.ImageSize = New Size(16, 16)
        ' Add some system icons to the ImageList
        'MyImages.Images.Add(New Icon(Application.StartupPath & "\image\folder.ico", New Size(16, 16)))
        'MyImages.Images.Add(New Icon(System.Drawing.SystemIcons.Information, New Size(16, 16)))
        'MyImages.Images.Add(New Icon(System.Drawing.SystemIcons.Exclamation, New Size(16, 16)))
        'MyImages.Images.Add(New Icon(System.Drawing.SystemIcons.Question, New Size(16, 16)))

        MyImages.Images.Add(img)
        MyImages.Images.Add(img)

        '  assign the ImageList to the Treeview
        Me.ImageList = MyImages
        Return True
    End Function
#End Region

End Class

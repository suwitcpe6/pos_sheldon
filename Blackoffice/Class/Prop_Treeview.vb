Public Class Prop_Treeview
    Public Shared Function Add_icon(ByRef tree As TreeView)
        ''  Create a new ImageList
        'Dim MyImages As New ImageList()
        ''  Set size property
        'MyImages.ImageSize = New Size(16, 16)
        '' Add some system icons to the ImageList
        ''MyImages.Images.Add(New Icon(Application.StartupPath & "\image\folder.ico", New Size(16, 16)))
        ''MyImages.Images.Add(New Icon(System.Drawing.SystemIcons.Information, New Size(16, 16)))
        ''MyImages.Images.Add(New Icon(System.Drawing.SystemIcons.Exclamation, New Size(16, 16)))
        ''MyImages.Images.Add(New Icon(System.Drawing.SystemIcons.Question, New Size(16, 16)))

        'MyImages.Images.Add(My.Resources.menuRight_Next)
        'MyImages.Images.Add(My.Resources.menuRight3)

        ''  assign the ImageList to the Treeview
        'tree.ImageList = MyImages
        Return True
    End Function

    Public Shared Function search_Treenode(ByVal value As String, ByVal tree As TreeView)
        tree.SelectedNode = Nothing
        tree.Focus()
        Dim text As String = String.Empty
        text = value
        Dim a As Boolean = True
        If text <> String.Empty Then
            Try
                Dim node As Int16 = tree.Nodes.Count
                For i As Integer = 0 To node
                    Dim arr As TreeNode() = tree.Nodes(i).Nodes.Find(text, a)
                    If arr.Length > 0 Then
                        tree.CollapseAll()
                        'e.Node.Expand()
                        tree.SelectedNode = arr(0)
                        tree.Focus()
                    Else
                        tree.SelectedNode = Nothing
                    End If
                Next

            Catch ex As Exception

            End Try
        End If
        Return True
    End Function

End Class

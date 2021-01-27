Public Class Loadassm
    'Private Sub LoadSelectedAssembly(ByVal nodeInfo As Object)
    '    UILoading(Me, True, StepType.Begin)

    '    Dim NodeValue As clMenus.ASMStruct = nodeInfo
    '    Dim Asm As Object = clLibLoading.LoadAssembly(NodeValue)
    '    Try
    '        If Asm Is Nothing Then Throw New Exception("")
    '        If (SPContain.Panel2.Controls.Count <> 0) Then
    '            For Each obj In SPContain.Panel2.Controls
    '                If obj.ToString = Asm.ToString Then
    '                    lblCurFunc.Text = NodeValue.TitleName
    '                    obj.InfoValues.DocumentValue = New IDL.Interface.DocumentInfo() With
    '                                          {.DocumentID = obj.Tag}
    '                    obj.BringToFront()
    '                    Exit Sub
    '                End If
    '            Next
    '        End If

    '        UILoading(Me, True, StepType.Loading)


    '        If Asm IsNot Nothing Then
    '            SPContain.Panel2.Hide()
    '            lblCurFunc.Text = NodeValue.TitleName
    '            Asm.name = NodeValue.AssemblyName
    '            Asm.text = NodeValue.TitleName
    '            Asm.InfoValues = InfoValue
    '            Asm.InfoValues.DocumentValue = New IDL.Interface.DocumentInfo() With
    '                                          {.DocumentID = NodeValue.DefaultDocumentType}
    '            Asm.Dock = DockStyle.Fill
    '            Asm.tag = NodeValue.DefaultDocumentType
    '            Dim t As New TreeView



    '            'Set Titelbar Color
    '            ' Asm.lblTitle.backcolor = Color.DeepSkyBlue

    '            ' Asm.visible = False
    '            UILoading(Me, True, StepType.Prepare)
    '            SPContain.Panel2.Controls.Add(Asm)
    '            CurrentMenu = Asm.ToString
    '            'Asm.visible = True
    '            Asm.BringToFront()
    '            UILoading(Me, True, StepType.Finish)
    '            SPContain.Panel2.Show()

    '        End If

    '    Catch ex As Exception
    '        IDL.Module.Messages.Texts(Me, "Library page incorrect : " & NodeValue.AssemblyName & " !" & vbCrLf &
    '                                  ex.Message.ToString, 115, IDL.Module.Messages.ButtonType.OkOnly, MessageBoxIcon.Error)
    '    Finally
    '        UILoading(Me, False, IDL.Module.App.StepType.Done)
    '    End Try
    'End Sub
    'Public Sub UILoading(ByVal own As System.Windows.Forms.Form, ByVal isLoad As Boolean, ByVal Steps As StepType)
    '    Try
    '        If IsNothing(own) Then
    '            Exit Sub
    '        End If
    '        Select Case isLoad
    '            Case True
    '                own.UseWaitCursor = True
    '                own.Enabled = False
    '                ' For Each obj As Object In own.Controls
    '                ' If TypeOf (obj) Is ProgressBar Then
    '                Dim obj As ProgressBar = CType(own.Controls("PGMain"), ProgressBar)
    '                obj.Maximum = 4
    '                obj.Minimum = 0
    '                obj.Style = ProgressBarStyle.Continuous
    '                obj.Value = Steps
    '                ' Exit For
    '                ' End If
    '                ' Application.DoEvents()
    '                ' Next
    '            Case Else
    '                own.UseWaitCursor = False
    '                own.Enabled = True
    '                ' For Each obj As Object In own.Controls
    '                ' If TypeOf (obj) Is ProgressBar Then
    '                Dim obj As ProgressBar = CType(own.Controls("PGMain"), ProgressBar)
    '                obj.Maximum = 4
    '                obj.Minimum = 0
    '                obj.Style = ProgressBarStyle.Continuous
    '                obj.Value = Steps
    '                ' Exit For
    '                ' End If
    '                ' Application.DoEvents()
    '                ' Next
    '        End Select
    '    Catch ex As Exception
    '    Finally
    '        ' DelayTime(0.2)
    '    End Try

    'End Sub
End Class

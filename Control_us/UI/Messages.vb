Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Windows.Forms

Public Class Messages
    Private buttons As ButtonType
    Private Sub Messages_show(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.close_loding = True
        Timer1.Enabled = True
        Label_US1.Text = Me.Text

    End Sub
    Public Shared Function Texts(caption As String, message As String, buttons As Messages.ButtonType, icons As MessageBoxIcon) As DialogResult
        'NewLateBinding.LateSet(OwnForm, Nothing, "Enabled", New Object()() {False}, Nothing, Nothing)
        Dim messageForm As Messages = New Messages()
        Dim result As DialogResult

        Try


            Select Case icons
                Case MessageBoxIcon.Sucess
                    messageForm.lbl_messtype.Text = "Successful"
                    messageForm.lbl_messtype.ForeColor = Color.Green
                    messageForm.message.ForeColor = Color.Green
                    messageForm.picon.Image = My.Resources.success
                Case MessageBoxIcon.Errorr
                    messageForm.lbl_messtype.Text = "Error"
                    messageForm.lbl_messtype.ForeColor = Color.Red
                    messageForm.message.ForeColor = Color.Red
                    messageForm.picon.Image = My.Resources._Error
                Case MessageBoxIcon.Information
                    messageForm.lbl_messtype.Text = "Information"
                    messageForm.lbl_messtype.ForeColor = Color.Blue
                    messageForm.message.ForeColor = Color.Blue
                    messageForm.picon.Image = My.Resources.Information
                Case MessageBoxIcon.Warning
                    messageForm.lbl_messtype.Text = "Warning"
                    messageForm.lbl_messtype.ForeColor = Color.DarkOrange
                    messageForm.message.ForeColor = Color.DarkOrange
                    messageForm.picon.Image = My.Resources.Warning
                Case MessageBoxIcon.Question
                    messageForm.lbl_messtype.Text = "Question"
                    messageForm.lbl_messtype.ForeColor = Color.Black
                    messageForm.picon.Image = My.Resources.Question
                Case MessageBoxIcon.Stopp
                    messageForm.lbl_messtype.Text = "Stop"
                    messageForm.lbl_messtype.ForeColor = Color.Red
                    messageForm.message.ForeColor = Color.Red
                    messageForm.picon.Image = My.Resources._stop
            End Select

            messageForm.Text = caption
            messageForm.message.Text = message
            messageForm.Text = caption
            messageForm.Text = caption
            Select Case buttons
                Case ButtonType.Sucess
                    messageForm.btn_ok.Visible = True : messageForm.btn_ok.Focus() : messageForm.btn_ok.FlatAppearance.BorderColor = Color.Blue
                    messageForm.btn_cancel.Visible = False
                    messageForm.btnYes.Visible = False
                    messageForm.btnNo.Visible = False
                Case ButtonType.OkOnly
                    messageForm.btn_ok.Visible = True : messageForm.btn_ok.Focus() : messageForm.btn_ok.FlatAppearance.BorderColor = Color.Blue
                    messageForm.btn_cancel.Visible = False
                    messageForm.btnYes.Visible = False
                    messageForm.btnNo.Visible = False
                Case ButtonType.OKCancel
                    messageForm.btn_ok.Visible = True : messageForm.btn_ok.Focus() : messageForm.btn_ok.FlatAppearance.BorderColor = Color.Blue
                    messageForm.btn_cancel.Visible = True
                    messageForm.btnYes.Visible = False
                    messageForm.btnNo.Visible = False
                Case ButtonType.YesNo
                    messageForm.btn_ok.Visible = False
                    messageForm.btn_cancel.Visible = False
                    messageForm.btnYes.Visible = True
                    messageForm.btnNo.Visible = True : messageForm.btnNo.Focus() : messageForm.btnNo.FlatAppearance.BorderColor = Color.Blue
                Case ButtonType.YesNoCancel
                    messageForm.btn_ok.Visible = False
                    messageForm.btn_cancel.Visible = True
                    messageForm.btnYes.Visible = True
                    messageForm.btnNo.Visible = True : messageForm.btnNo.Focus() : messageForm.btnNo.FlatAppearance.BorderColor = Color.Blue

            End Select

            messageForm.ShowDialog()
            result = messageForm.DialogResult

        Catch expr_5F As Exception
            ProjectData.SetProjectError(expr_5F)
            Dim ex As Exception = expr_5F
            'MessageBox.Show(ex.Message, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(OwnForm, Nothing, "Text", New Object(0 - 1) {}, Nothing, Nothing, Nothing), " : 150")), MessageBoxButtons.OK, MessageBoxIcon.Hand)
            result = DialogResult.None
            ProjectData.ClearProjectError()
        Finally
            'NewLateBinding.LateSet(OwnForm, Nothing, "Enabled", New Object()() {True}, Nothing, Nothing)
        End Try
        Return result
    End Function

    Public Enum ButtonType
        Sucess
        OkOnly
        OKCancel
        YesNo
        YesNoCancel
    End Enum
    Public Enum MessageBoxIcon
        Errorr
        Sucess
        Information
        Warning
        Question
        Stopp
    End Enum



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        picon.Visible = Not picon.Visible

    End Sub

    Private Sub Btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.DialogResult = DialogResult.Yes
        Me.Dispose()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = DialogResult.No
        Me.Dispose()
    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Dispose()
    End Sub

End Class
Imports Control_us

Public Class Prop_Form
    Public Shared Function prop_pupup_nosize(ByRef f As Form)

        f.AutoScaleMode = AutoScaleMode.None
        f.BackColor = Color.White
        f.Icon = F_Lockin.Icon
        f.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        f.ForeColor = System.Drawing.Color.Blue
        f.WindowState = FormWindowState.Normal
        f.StartPosition = FormStartPosition.CenterScreen
        f.MinimizeBox = False

        Return f
    End Function
End Class

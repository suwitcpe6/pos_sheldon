Public Class UC_Product_Items
    Public Event Items_Click(sender As Object, e As System.EventArgs)
    Public Property value As New ItemData

    Private Sub UC_Product_Items_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lbl_Pname.Text = Me.value.ProductName
        Me.lbl_Price.Text = Me.value.ProductPrice & vbNewLine & "Bath"
        Me.lbl_Pname.ForeColor = value.Items_ForeColor
        Me.lbl_Price.ForeColor = value.Items_ForeColor
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_Pname.Click, lbl_Price.Click, Me.Click, PictureBox1.Click
        RaiseEvent Items_Click(Me, Nothing)
    End Sub

End Class
Public Class ItemData
    Property PCODE As String
    Property PNAME As String
    Property UNITCODE As String
    Property UNITNAME As String
    Property ProductID As String
    Property ProductName As String
    Property ProductPrice As Decimal
    'Property ProductPriceOnBill As Decimal
    Property ProductImage As Image()
    Property Items_ForeColor As Color
    Property GP As Double
    Property GPAMOUNT As Double
    Property GPRULE As String
End Class

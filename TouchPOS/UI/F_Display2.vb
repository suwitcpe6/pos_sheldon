
Public Class F_Display2

    Public dt_data As DataTable

    Private Sub F_Display2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gencolumn()

    End Sub

    Public Sub Gencolumn()

        Try

            Me.DGV_Product.AutoGenerateColumns = False
            Me.DGV_Product.Columns.Clear()
            Dim Col As New DataGridViewTextBoxColumn
            'Dim btn As New DataGridViewButtonColumn
            'Dim Chk As New DataGridViewCheckBoxColumn
            Dim read As Boolean = True

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับ"
            Col.Width = 200
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "SEQ"
            Col.Name = "SEQ"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อ"
            'Col.Width = 80
            Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "FOODID"
            Col.Name = "FOODID"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อ"
            Col.Width = 500
            Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "FOODNAME"
            Col.Name = "FOODNAME"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จำนวน"
            Col.Width = 80
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "Qty"
            Col.Name = "Qty"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ราคา"
            Col.Width = 200
            Col.Visible = True
            Col.ReadOnly = read
            Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Col.DataPropertyName = "MRTAMOUNT"
            Col.Name = "MRTAMOUNT"
            Me.DGV_Product.Columns.Add(Col)


            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "สถานะ"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "status"
            Col.Name = "status"
            Me.DGV_Product.Columns.Add(Col)


            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "GP"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "GP"
            Col.Name = "GP"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "GPAMOUNT"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "GPAMOUNT"
            Col.Name = "GPAMOUNT"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "PCODE"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "PCODE"
            Col.Name = "PCODE"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "PNAME"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "PNAME"
            Col.Name = "PNAME"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "UNITCODE"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "UNITCODE"
            Col.Name = "UNITCODE"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "UNITNAME"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "UNITNAME"
            Col.Name = "UNITNAME"
            Me.DGV_Product.Columns.Add(Col)


            DGV_Product.DataSource = Me.dt_data

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try

    End Sub
End Class
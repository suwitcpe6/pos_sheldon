<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Display2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_Total = New Control_us.Label_US()
        Me.Label_US2 = New Control_us.Label_US()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGV_Product = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_corpname = New Control_us.Label_US()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Controls.Add(Me.lbl_corpname)
        Me.Panel1.Controls.Add(Me.Lbl_Total)
        Me.Panel1.Controls.Add(Me.Label_US2)
        Me.Panel1.Controls.Add(Me.Label_US1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 126)
        Me.Panel1.TabIndex = 0
        '
        'Lbl_Total
        '
        Me.Lbl_Total.Font = New System.Drawing.Font("Leelawadee UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Total.ForeColor = System.Drawing.Color.White
        Me.Lbl_Total.Location = New System.Drawing.Point(571, 34)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(332, 86)
        Me.Lbl_Total.TabIndex = 4
        Me.Lbl_Total.Text = "0.00"
        Me.Lbl_Total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label_US2
        '
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.White
        Me.Label_US2.Location = New System.Drawing.Point(899, 34)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(159, 86)
        Me.Label_US2.TabIndex = 3
        Me.Label_US2.Text = "บาท"
        '
        'Label_US1
        '
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.White
        Me.Label_US1.Location = New System.Drawing.Point(25, 34)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(550, 86)
        Me.Label_US1.TabIndex = 0
        Me.Label_US1.Text = "ยอดขายรวม"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1061, 380)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGV_Product)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1061, 380)
        Me.Panel3.TabIndex = 0
        '
        'DGV_Product
        '
        Me.DGV_Product.AllowUserToAddRows = False
        Me.DGV_Product.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Product.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_Product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Product.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 18.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Product.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Product.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Product.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_Product.EnableHeadersVisualStyles = False
        Me.DGV_Product.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Product.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Product.Name = "DGV_Product"
        Me.DGV_Product.RowHeadersVisible = False
        Me.DGV_Product.RowHeadersWidth = 51
        Me.DGV_Product.RowTemplate.Height = 30
        Me.DGV_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Product.Size = New System.Drawing.Size(1061, 380)
        Me.DGV_Product.TabIndex = 37
        '
        'Column1
        '
        Me.Column1.HeaderText = "รายการที่"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 353
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อ"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 354
        '
        'Column3
        '
        Me.Column3.HeaderText = "สถานะ"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 353
        '
        'lbl_corpname
        '
        Me.lbl_corpname.Font = New System.Drawing.Font("Leelawadee UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_corpname.ForeColor = System.Drawing.Color.White
        Me.lbl_corpname.Location = New System.Drawing.Point(18, 0)
        Me.lbl_corpname.Name = "lbl_corpname"
        Me.lbl_corpname.Size = New System.Drawing.Size(1040, 44)
        Me.lbl_corpname.TabIndex = 5
        Me.lbl_corpname.Text = "corp"
        '
        'F_Display2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 506)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Display2"
        Me.Text = "F_Display2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents Lbl_Total As Control_us.Label_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DGV_Product As Control_us.DataGridView_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_corpname As Control_us.Label_US
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_SearchProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_SearchProduct))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_US3 = New Control_us.Label_US()
        Me.PTNAME = New Control_us.Textbox_UC()
        Me.Label_US2 = New Control_us.Label_US()
        Me.PGNAME = New Control_us.Textbox_UC()
        Me.Button_US2 = New Control_us.Button_US()
        Me.Button_US1 = New Control_us.Button_US()
        Me.Label_US1 = New Control_us.Label_US()
        Me.pname = New Control_us.Textbox_UC()
        Me.Label_US10 = New Control_us.Label_US()
        Me.pcode = New Control_us.Textbox_UC()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_scr = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_US3)
        Me.Panel1.Controls.Add(Me.PTNAME)
        Me.Panel1.Controls.Add(Me.Label_US2)
        Me.Panel1.Controls.Add(Me.PGNAME)
        Me.Panel1.Controls.Add(Me.Button_US2)
        Me.Panel1.Controls.Add(Me.Button_US1)
        Me.Panel1.Controls.Add(Me.Label_US1)
        Me.Panel1.Controls.Add(Me.pname)
        Me.Panel1.Controls.Add(Me.Label_US10)
        Me.Panel1.Controls.Add(Me.pcode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 141)
        Me.Panel1.TabIndex = 0
        '
        'Label_US3
        '
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.Black
        Me.Label_US3.Location = New System.Drawing.Point(45, 67)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(87, 19)
        Me.Label_US3.TabIndex = 27
        Me.Label_US3.Text = "ประเภทสินค้า"
        '
        'PTNAME
        '
        Me.PTNAME.BackColor = System.Drawing.Color.White
        Me.PTNAME.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PTNAME.ForeColor = System.Drawing.Color.DarkGreen
        Me.PTNAME.Location = New System.Drawing.Point(138, 64)
        Me.PTNAME.Name = "PTNAME"
        Me.PTNAME.Size = New System.Drawing.Size(350, 25)
        Me.PTNAME.TabIndex = 26
        Me.PTNAME.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.PTNAME.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.PTNAME.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.PTNAME.US_Color_Enable = System.Drawing.Color.White
        Me.PTNAME.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.PTNAME.Us_dataBindings_TOP = 10
        Me.PTNAME.US_Enable = True
        Me.PTNAME.US_foreColor_Didable = System.Drawing.Color.White
        Me.PTNAME.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.PTNAME.US_Number = False
        Me.PTNAME.US_Tag2 = ""
        Me.PTNAME.US_value = Nothing
        '
        'Label_US2
        '
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Black
        Me.Label_US2.Location = New System.Drawing.Point(45, 93)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(87, 19)
        Me.Label_US2.TabIndex = 25
        Me.Label_US2.Text = "กลุ่มสินค้า"
        '
        'PGNAME
        '
        Me.PGNAME.BackColor = System.Drawing.Color.White
        Me.PGNAME.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PGNAME.ForeColor = System.Drawing.Color.DarkGreen
        Me.PGNAME.Location = New System.Drawing.Point(138, 90)
        Me.PGNAME.Name = "PGNAME"
        Me.PGNAME.Size = New System.Drawing.Size(350, 25)
        Me.PGNAME.TabIndex = 24
        Me.PGNAME.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.PGNAME.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.PGNAME.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.PGNAME.US_Color_Enable = System.Drawing.Color.White
        Me.PGNAME.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.PGNAME.Us_dataBindings_TOP = 10
        Me.PGNAME.US_Enable = True
        Me.PGNAME.US_foreColor_Didable = System.Drawing.Color.White
        Me.PGNAME.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.PGNAME.US_Number = False
        Me.PGNAME.US_Tag2 = ""
        Me.PGNAME.US_value = Nothing
        '
        'Button_US2
        '
        Me.Button_US2.BackColor = System.Drawing.Color.White
        Me.Button_US2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US2.ForeColor = System.Drawing.Color.White
        Me.Button_US2.Image = CType(resources.GetObject("Button_US2.Image"), System.Drawing.Image)
        Me.Button_US2.Location = New System.Drawing.Point(608, 28)
        Me.Button_US2.Name = "Button_US2"
        Me.Button_US2.Size = New System.Drawing.Size(99, 53)
        Me.Button_US2.TabIndex = 23
        Me.Button_US2.UseVisualStyleBackColor = False
        '
        'Button_US1
        '
        Me.Button_US1.BackColor = System.Drawing.Color.White
        Me.Button_US1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US1.ForeColor = System.Drawing.Color.White
        Me.Button_US1.Image = CType(resources.GetObject("Button_US1.Image"), System.Drawing.Image)
        Me.Button_US1.Location = New System.Drawing.Point(503, 28)
        Me.Button_US1.Name = "Button_US1"
        Me.Button_US1.Size = New System.Drawing.Size(99, 53)
        Me.Button_US1.TabIndex = 22
        Me.Button_US1.UseVisualStyleBackColor = False
        '
        'Label_US1
        '
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.Black
        Me.Label_US1.Location = New System.Drawing.Point(45, 42)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(87, 19)
        Me.Label_US1.TabIndex = 21
        Me.Label_US1.Text = "ชื่อสินค้า"
        '
        'pname
        '
        Me.pname.BackColor = System.Drawing.Color.White
        Me.pname.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pname.ForeColor = System.Drawing.Color.DarkGreen
        Me.pname.Location = New System.Drawing.Point(138, 38)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(350, 25)
        Me.pname.TabIndex = 20
        Me.pname.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.pname.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.pname.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.pname.US_Color_Enable = System.Drawing.Color.White
        Me.pname.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.pname.Us_dataBindings_TOP = 10
        Me.pname.US_Enable = True
        Me.pname.US_foreColor_Didable = System.Drawing.Color.White
        Me.pname.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.pname.US_Number = False
        Me.pname.US_Tag2 = ""
        Me.pname.US_value = Nothing
        '
        'Label_US10
        '
        Me.Label_US10.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US10.ForeColor = System.Drawing.Color.Black
        Me.Label_US10.Location = New System.Drawing.Point(45, 15)
        Me.Label_US10.Name = "Label_US10"
        Me.Label_US10.Size = New System.Drawing.Size(87, 19)
        Me.Label_US10.TabIndex = 19
        Me.Label_US10.Text = "รหัสสินค้า"
        '
        'pcode
        '
        Me.pcode.BackColor = System.Drawing.Color.White
        Me.pcode.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pcode.ForeColor = System.Drawing.Color.DarkGreen
        Me.pcode.Location = New System.Drawing.Point(138, 12)
        Me.pcode.Name = "pcode"
        Me.pcode.Size = New System.Drawing.Size(350, 25)
        Me.pcode.TabIndex = 18
        Me.pcode.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.pcode.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.pcode.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.pcode.US_Color_Enable = System.Drawing.Color.White
        Me.pcode.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.pcode.Us_dataBindings_TOP = 10
        Me.pcode.US_Enable = True
        Me.pcode.US_foreColor_Didable = System.Drawing.Color.White
        Me.pcode.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.pcode.US_Number = False
        Me.pcode.US_Tag2 = ""
        Me.pcode.US_value = Nothing
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv_scr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 309)
        Me.Panel2.TabIndex = 1
        '
        'dgv_scr
        '
        Me.dgv_scr.AllowUserToAddRows = False
        Me.dgv_scr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_scr.BackgroundColor = System.Drawing.Color.White
        Me.dgv_scr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_scr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_scr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_scr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_scr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_scr.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_scr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_scr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_scr.EnableHeadersVisualStyles = False
        Me.dgv_scr.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_scr.Location = New System.Drawing.Point(0, 0)
        Me.dgv_scr.Name = "dgv_scr"
        Me.dgv_scr.ReadOnly = True
        Me.dgv_scr.RowHeadersVisible = False
        Me.dgv_scr.RowHeadersWidth = 51
        Me.dgv_scr.RowTemplate.Height = 30
        Me.dgv_scr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_scr.Size = New System.Drawing.Size(800, 309)
        Me.dgv_scr.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'F_SearchProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "F_SearchProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents pname As Control_us.Textbox_UC
    Friend WithEvents Label_US10 As Control_us.Label_US
    Friend WithEvents pcode As Control_us.Textbox_UC
    Friend WithEvents Button_US1 As Control_us.Button_US
    Friend WithEvents dgv_scr As Control_us.DataGridView_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Button_US2 As Control_us.Button_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents PGNAME As Control_us.Textbox_UC
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents PTNAME As Control_us.Textbox_UC
End Class

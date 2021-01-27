<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Void
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Void))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_ok = New Control_us.Button_US()
        Me.btn_close = New Control_us.Button_US()
        Me.txt_barcode = New Control_us.Textbox_UC()
        Me.Panel_US1 = New Control_us.Panel_US()
        Me.p_icon = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Label_US2 = New Control_us.Label_US()
        Me.txt_Amount = New Control_us.Textbox_UC()
        Me.Label_US3 = New Control_us.Label_US()
        Me.DGV_items = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel_US2 = New Control_us.Panel_US()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button_US1 = New Control_us.Button_US()
        Me.Panel_US4 = New Control_us.Panel_US()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel_US1.SuspendLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_US2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel_US4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.DimGray
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(417, 7)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(146, 58)
        Me.btn_ok.TabIndex = 35
        Me.btn_ok.Text = "บันทึก"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.DimGray
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(591, 6)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(146, 58)
        Me.btn_close.TabIndex = 34
        Me.btn_close.Text = "ปิด"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'txt_barcode
        '
        Me.txt_barcode.BackColor = System.Drawing.Color.White
        Me.txt_barcode.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_barcode.ForeColor = System.Drawing.Color.DimGray
        Me.txt_barcode.Location = New System.Drawing.Point(163, 14)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(435, 35)
        Me.txt_barcode.TabIndex = 7
        Me.txt_barcode.Text = "12345"
        Me.txt_barcode.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_barcode.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_barcode.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_barcode.US_Color_Enable = System.Drawing.Color.White
        Me.txt_barcode.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_barcode.Us_dataBindings_TOP = 10
        Me.txt_barcode.US_Enable = True
        Me.txt_barcode.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_barcode.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_barcode.US_Number = False
        Me.txt_barcode.US_Tag2 = ""
        Me.txt_barcode.US_value = Nothing
        '
        'Panel_US1
        '
        Me.Panel_US1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_US1.Controls.Add(Me.p_icon)
        Me.Panel_US1.Controls.Add(Me.Panel6)
        Me.Panel_US1.Controls.Add(Me.Label_US1)
        Me.Panel_US1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_US1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_US1.Name = "Panel_US1"
        Me.Panel_US1.Size = New System.Drawing.Size(742, 44)
        Me.Panel_US1.TabIndex = 2
        '
        'p_icon
        '
        Me.p_icon.Image = CType(resources.GetObject("p_icon.Image"), System.Drawing.Image)
        Me.p_icon.Location = New System.Drawing.Point(5, 3)
        Me.p_icon.Name = "p_icon"
        Me.p_icon.Size = New System.Drawing.Size(60, 30)
        Me.p_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_icon.TabIndex = 4
        Me.p_icon.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 40)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(742, 4)
        Me.Panel6.TabIndex = 3
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.White
        Me.Label_US1.Location = New System.Drawing.Point(71, 8)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(77, 25)
        Me.Label_US1.TabIndex = 1
        Me.Label_US1.Text = "Refund"
        '
        'Label_US2
        '
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US2.Location = New System.Drawing.Point(14, 18)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(129, 25)
        Me.Label_US2.TabIndex = 35
        Me.Label_US2.Text = "บาร์โค๊ด"
        '
        'txt_Amount
        '
        Me.txt_Amount.BackColor = System.Drawing.Color.DimGray
        Me.txt_Amount.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Amount.ForeColor = System.Drawing.Color.White
        Me.txt_Amount.Location = New System.Drawing.Point(163, 55)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.ReadOnly = True
        Me.txt_Amount.Size = New System.Drawing.Size(108, 29)
        Me.txt_Amount.TabIndex = 36
        Me.txt_Amount.Text = "0"
        Me.txt_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Amount.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_Amount.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_Amount.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_Amount.US_Color_Enable = System.Drawing.Color.White
        Me.txt_Amount.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_Amount.Us_dataBindings_TOP = 10
        Me.txt_Amount.US_Enable = False
        Me.txt_Amount.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_Amount.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_Amount.US_Number = True
        Me.txt_Amount.US_Tag2 = ""
        Me.txt_Amount.US_value = Nothing
        '
        'Label_US3
        '
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US3.Location = New System.Drawing.Point(14, 55)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(128, 25)
        Me.Label_US3.TabIndex = 37
        Me.Label_US3.Text = "ยอดสุทธิ"
        '
        'DGV_items
        '
        Me.DGV_items.AllowUserToAddRows = False
        Me.DGV_items.BackgroundColor = System.Drawing.Color.White
        Me.DGV_items.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_items.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_items.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_items.EnableHeadersVisualStyles = False
        Me.DGV_items.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_items.Location = New System.Drawing.Point(0, 118)
        Me.DGV_items.Name = "DGV_items"
        Me.DGV_items.RowHeadersVisible = False
        Me.DGV_items.RowHeadersWidth = 51
        Me.DGV_items.RowTemplate.Height = 30
        Me.DGV_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_items.Size = New System.Drawing.Size(742, 248)
        Me.DGV_items.TabIndex = 42
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 441
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 440
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 441
        '
        'Panel_US2
        '
        Me.Panel_US2.Controls.Add(Me.DGV_items)
        Me.Panel_US2.Controls.Add(Me.Panel8)
        Me.Panel_US2.Controls.Add(Me.Panel7)
        Me.Panel_US2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US2.Location = New System.Drawing.Point(0, 44)
        Me.Panel_US2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_US2.Name = "Panel_US2"
        Me.Panel_US2.Size = New System.Drawing.Size(742, 436)
        Me.Panel_US2.TabIndex = 45
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btn_close)
        Me.Panel8.Controls.Add(Me.btn_ok)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 366)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(742, 70)
        Me.Panel8.TabIndex = 46
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Button_US1)
        Me.Panel7.Controls.Add(Me.txt_barcode)
        Me.Panel7.Controls.Add(Me.Label_US2)
        Me.Panel7.Controls.Add(Me.Label_US3)
        Me.Panel7.Controls.Add(Me.txt_Amount)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(742, 118)
        Me.Panel7.TabIndex = 45
        '
        'Button_US1
        '
        Me.Button_US1.BackColor = System.Drawing.Color.Green
        Me.Button_US1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US1.ForeColor = System.Drawing.Color.White
        Me.Button_US1.Location = New System.Drawing.Point(614, 15)
        Me.Button_US1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_US1.Name = "Button_US1"
        Me.Button_US1.Size = New System.Drawing.Size(90, 32)
        Me.Button_US1.TabIndex = 38
        Me.Button_US1.Text = "Button_US1"
        Me.Button_US1.UseVisualStyleBackColor = False
        Me.Button_US1.Visible = False
        '
        'Panel_US4
        '
        Me.Panel_US4.Controls.Add(Me.Panel_US2)
        Me.Panel_US4.Controls.Add(Me.Panel_US1)
        Me.Panel_US4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US4.Location = New System.Drawing.Point(4, 4)
        Me.Panel_US4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_US4.Name = "Panel_US4"
        Me.Panel_US4.Size = New System.Drawing.Size(742, 480)
        Me.Panel_US4.TabIndex = 11
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(746, 4)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(4, 480)
        Me.Panel5.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(4, 480)
        Me.Panel4.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 484)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(750, 4)
        Me.Panel3.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 4)
        Me.Panel2.TabIndex = 7
        '
        'F_Void
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 488)
        Me.Controls.Add(Me.Panel_US4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Void"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Refund"
        Me.Panel_US1.ResumeLayout(False)
        Me.Panel_US1.PerformLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_US2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel_US4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ok As Control_us.Button_US
    Friend WithEvents btn_close As Control_us.Button_US
    Friend WithEvents txt_barcode As Control_us.Textbox_UC
    Friend WithEvents Panel_US1 As Control_us.Panel_US
    Friend WithEvents p_icon As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents txt_Amount As Control_us.Textbox_UC
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents DGV_items As Control_us.DataGridView_US
    Friend WithEvents Panel_US2 As Control_us.Panel_US
    Friend WithEvents Panel_US4 As Control_us.Panel_US
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Button_US1 As Control_us.Button_US
End Class

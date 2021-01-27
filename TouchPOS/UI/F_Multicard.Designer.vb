<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Multicard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Multicard))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_US4 = New Control_us.Panel_US()
        Me.Panel_US2 = New Control_us.Panel_US()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txt_barcode = New Control_us.Textbox_UC()
        Me.txt_amount_remain = New Control_us.Textbox_UC()
        Me.Label_US2 = New Control_us.Label_US()
        Me.Label_US5 = New Control_us.Label_US()
        Me.txt_Amount = New Control_us.Textbox_UC()
        Me.Label_US4 = New Control_us.Label_US()
        Me.Label_US3 = New Control_us.Label_US()
        Me.txt_card_Amount = New Control_us.Textbox_UC()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_Card = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel_US3 = New Control_us.Panel_US()
        Me.btn_delete = New Control_us.Button_US()
        Me.btn_ok = New Control_us.Button_US()
        Me.btn_cancell = New Control_us.Button_US()
        Me.Panel_US1 = New Control_us.Panel_US()
        Me.p_icon = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Panel_US4.SuspendLayout()
        Me.Panel_US2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_Card, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_US3.SuspendLayout()
        Me.Panel_US1.SuspendLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 4)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 496)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(650, 4)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(4, 492)
        Me.Panel4.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(646, 4)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(4, 492)
        Me.Panel5.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
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
        Me.Panel_US4.Size = New System.Drawing.Size(642, 492)
        Me.Panel_US4.TabIndex = 6
        '
        'Panel_US2
        '
        Me.Panel_US2.Controls.Add(Me.SplitContainer1)
        Me.Panel_US2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US2.Location = New System.Drawing.Point(0, 44)
        Me.Panel_US2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel_US2.Name = "Panel_US2"
        Me.Panel_US2.Size = New System.Drawing.Size(642, 448)
        Me.Panel_US2.TabIndex = 45
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_barcode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_amount_remain)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_US2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_US5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Amount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_US4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label_US3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_card_Amount)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel_US3)
        Me.SplitContainer1.Size = New System.Drawing.Size(642, 448)
        Me.SplitContainer1.SplitterDistance = 190
        Me.SplitContainer1.TabIndex = 44
        '
        'txt_barcode
        '
        Me.txt_barcode.BackColor = System.Drawing.Color.White
        Me.txt_barcode.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_barcode.ForeColor = System.Drawing.Color.DimGray
        Me.txt_barcode.Location = New System.Drawing.Point(170, 14)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(435, 39)
        Me.txt_barcode.TabIndex = 7
        Me.txt_barcode.Text = "N0601110953"
        Me.txt_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'txt_amount_remain
        '
        Me.txt_amount_remain.BackColor = System.Drawing.Color.Red
        Me.txt_amount_remain.Font = New System.Drawing.Font("Leelawadee UI", 30.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_amount_remain.ForeColor = System.Drawing.Color.Transparent
        Me.txt_amount_remain.Location = New System.Drawing.Point(170, 126)
        Me.txt_amount_remain.Name = "txt_amount_remain"
        Me.txt_amount_remain.ReadOnly = True
        Me.txt_amount_remain.Size = New System.Drawing.Size(435, 61)
        Me.txt_amount_remain.TabIndex = 43
        Me.txt_amount_remain.Text = "0"
        Me.txt_amount_remain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_amount_remain.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_amount_remain.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_amount_remain.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_amount_remain.US_Color_Enable = System.Drawing.Color.White
        Me.txt_amount_remain.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_amount_remain.Us_dataBindings_TOP = 10
        Me.txt_amount_remain.US_Enable = False
        Me.txt_amount_remain.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_amount_remain.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_amount_remain.US_Number = True
        Me.txt_amount_remain.US_Tag2 = ""
        Me.txt_amount_remain.US_value = Nothing
        '
        'Label_US2
        '
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US2.Location = New System.Drawing.Point(21, 18)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(129, 25)
        Me.Label_US2.TabIndex = 35
        Me.Label_US2.Text = "บัตรบาร์โค๊ด"
        '
        'Label_US5
        '
        Me.Label_US5.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US5.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US5.Location = New System.Drawing.Point(22, 130)
        Me.Label_US5.Name = "Label_US5"
        Me.Label_US5.Size = New System.Drawing.Size(128, 25)
        Me.Label_US5.TabIndex = 41
        Me.Label_US5.Text = "ยอดที่ต้องเพิ่ม"
        '
        'txt_Amount
        '
        Me.txt_Amount.BackColor = System.Drawing.Color.DimGray
        Me.txt_Amount.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Amount.ForeColor = System.Drawing.Color.White
        Me.txt_Amount.Location = New System.Drawing.Point(170, 59)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.ReadOnly = True
        Me.txt_Amount.Size = New System.Drawing.Size(435, 35)
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
        'Label_US4
        '
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US4.Location = New System.Drawing.Point(21, 93)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(129, 25)
        Me.Label_US4.TabIndex = 39
        Me.Label_US4.Text = "ยอดต่อบัตรแล้ว"
        '
        'Label_US3
        '
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US3.Location = New System.Drawing.Point(22, 61)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(128, 25)
        Me.Label_US3.TabIndex = 37
        Me.Label_US3.Text = "ยอดขาดสุทธิ"
        '
        'txt_card_Amount
        '
        Me.txt_card_Amount.BackColor = System.Drawing.Color.DimGray
        Me.txt_card_Amount.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_card_Amount.ForeColor = System.Drawing.Color.White
        Me.txt_card_Amount.Location = New System.Drawing.Point(170, 93)
        Me.txt_card_Amount.Name = "txt_card_Amount"
        Me.txt_card_Amount.ReadOnly = True
        Me.txt_card_Amount.Size = New System.Drawing.Size(435, 35)
        Me.txt_card_Amount.TabIndex = 38
        Me.txt_card_Amount.Text = "0"
        Me.txt_card_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_card_Amount.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_card_Amount.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_card_Amount.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_card_Amount.US_Color_Enable = System.Drawing.Color.White
        Me.txt_card_Amount.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_card_Amount.Us_dataBindings_TOP = 10
        Me.txt_card_Amount.US_Enable = False
        Me.txt_card_Amount.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_card_Amount.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_card_Amount.US_Number = True
        Me.txt_card_Amount.US_Tag2 = ""
        Me.txt_card_Amount.US_value = Nothing
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGV_Card)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 165)
        Me.Panel1.TabIndex = 44
        '
        'DGV_Card
        '
        Me.DGV_Card.AllowUserToAddRows = False
        Me.DGV_Card.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Card.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Card.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_Card.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Card.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Card.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Card.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Card.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Card.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_Card.EnableHeadersVisualStyles = False
        Me.DGV_Card.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Card.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Card.Name = "DGV_Card"
        Me.DGV_Card.RowHeadersVisible = False
        Me.DGV_Card.RowHeadersWidth = 51
        Me.DGV_Card.RowTemplate.Height = 30
        Me.DGV_Card.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_Card.Size = New System.Drawing.Size(642, 165)
        Me.DGV_Card.TabIndex = 42
        '
        'Column1
        '
        Me.Column1.HeaderText = "รายการที่"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 214
        '
        'Column2
        '
        Me.Column2.HeaderText = "บาร์โค๊ด"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 214
        '
        'Column3
        '
        Me.Column3.HeaderText = "รอบที่"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 214
        '
        'Column4
        '
        Me.Column4.HeaderText = "จำนวนเงิน"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 214
        '
        'Panel_US3
        '
        Me.Panel_US3.Controls.Add(Me.btn_delete)
        Me.Panel_US3.Controls.Add(Me.btn_ok)
        Me.Panel_US3.Controls.Add(Me.btn_cancell)
        Me.Panel_US3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US3.Location = New System.Drawing.Point(0, 165)
        Me.Panel_US3.Name = "Panel_US3"
        Me.Panel_US3.Size = New System.Drawing.Size(642, 89)
        Me.Panel_US3.TabIndex = 43
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.DimGray
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(224, 10)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(181, 69)
        Me.btn_delete.TabIndex = 36
        Me.btn_delete.Text = "ไม่ใช้บัตรนี้"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = False
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
        Me.btn_ok.Location = New System.Drawing.Point(10, 10)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(178, 69)
        Me.btn_ok.TabIndex = 35
        Me.btn_ok.Text = "ยืนยันต่อบัตร"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_cancell
        '
        Me.btn_cancell.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_cancell.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cancell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_cancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancell.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancell.ForeColor = System.Drawing.Color.DimGray
        Me.btn_cancell.Image = CType(resources.GetObject("btn_cancell.Image"), System.Drawing.Image)
        Me.btn_cancell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancell.Location = New System.Drawing.Point(420, 8)
        Me.btn_cancell.Name = "btn_cancell"
        Me.btn_cancell.Size = New System.Drawing.Size(218, 69)
        Me.btn_cancell.TabIndex = 34
        Me.btn_cancell.Text = "ยกเลิกการต่อบัตร"
        Me.btn_cancell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancell.UseVisualStyleBackColor = False
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
        Me.Panel_US1.Size = New System.Drawing.Size(642, 44)
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
        Me.Panel6.Size = New System.Drawing.Size(642, 4)
        Me.Panel6.TabIndex = 3
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.White
        Me.Label_US1.Location = New System.Drawing.Point(71, 8)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(229, 25)
        Me.Label_US1.TabIndex = 1
        Me.Label_US1.Text = "ชำระด้วยบัตรมากกว่า 1 ใบ"
        '
        'F_Multicard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(650, 500)
        Me.Controls.Add(Me.Panel_US4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Multicard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ชำระด้วยบัตรมากกว่า 1 ใบ"
        Me.Panel_US4.ResumeLayout(False)
        Me.Panel_US2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_Card, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_US3.ResumeLayout(False)
        Me.Panel_US1.ResumeLayout(False)
        Me.Panel_US1.PerformLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents Label_US5 As Control_us.Label_US
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents txt_card_Amount As Control_us.Textbox_UC
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents txt_Amount As Control_us.Textbox_UC
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents txt_barcode As Control_us.Textbox_UC
    Friend WithEvents DGV_Card As Control_us.DataGridView_US
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt_amount_remain As Control_us.Textbox_UC
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_US3 As Control_us.Panel_US
    Friend WithEvents btn_delete As Control_us.Button_US
    Friend WithEvents btn_ok As Control_us.Button_US
    Friend WithEvents btn_cancell As Control_us.Button_US
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel_US4 As Control_us.Panel_US
    Friend WithEvents Panel_US2 As Control_us.Panel_US
    Friend WithEvents Panel_US1 As Control_us.Panel_US
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents p_icon As PictureBox
End Class

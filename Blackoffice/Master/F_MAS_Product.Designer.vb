<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_MAS_Product
    Inherits WeifenLuo.WinFormsUI.DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_MAS_Product))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PCODE = New Control_us.Textbox_UC()
        Me.Label_US13 = New Control_us.Label_US()
        Me.Label_US12 = New Control_us.Label_US()
        Me.PRICE_STD = New Control_us.Textbox_UC()
        Me.Label_US11 = New Control_us.Label_US()
        Me.PTCODE = New Control_us.Combobox_US()
        Me.Label_US10 = New Control_us.Label_US()
        Me.COST_STD = New Control_us.Textbox_UC()
        Me.Label_US9 = New Control_us.Label_US()
        Me.IMGNAME1 = New System.Windows.Forms.PictureBox()
        Me.PGCODE = New Control_us.Combobox_US()
        Me.Label_US6 = New Control_us.Label_US()
        Me.ID = New Control_us.Textbox_UC()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Label_US5 = New Control_us.Label_US()
        Me.PNAME = New Control_us.Textbox_UC()
        Me.ACTIVEFLAG = New Control_us.Combobox_US()
        Me.Label_US2 = New Control_us.Label_US()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_addunit = New Control_us.Button_US()
        Me.unit_add = New Control_us.Combobox_US()
        Me.Label_US8 = New Control_us.Label_US()
        Me.dgv_unit = New Control_us.DataGridView_US()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITCODE = New Control_us.Combobox_US()
        Me.Label_US7 = New Control_us.Label_US()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DESCRIPTION = New Control_us.Textbox_UC()
        Me.Label_US3 = New Control_us.Label_US()
        Me.Label_US4 = New Control_us.Label_US()
        Me.REMARK = New Control_us.Textbox_UC()
        Me.ToolStrip_top = New System.Windows.Forms.ToolStrip()
        Me.btn_new = New System.Windows.Forms.ToolStripButton()
        Me.btn_edit = New System.Windows.Forms.ToolStripButton()
        Me.btn_save = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancel_save = New System.Windows.Forms.ToolStripButton()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_scr = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbo_search = New System.Windows.Forms.ToolStripComboBox()
        Me.txt_scr = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_scr = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Next = New System.Windows.Forms.ToolStripButton()
        Me.txt_curpage = New System.Windows.Forms.ToolStripTextBox()
        Me.Btn_last = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.IMGNAME1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_unit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.ToolStrip_top.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1026, 549)
        Me.SplitContainer1.SplitterDistance = 299
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.ToolStrip_top)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 299)
        Me.Panel2.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1026, 260)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PCODE)
        Me.TabPage1.Controls.Add(Me.Label_US13)
        Me.TabPage1.Controls.Add(Me.Label_US12)
        Me.TabPage1.Controls.Add(Me.PRICE_STD)
        Me.TabPage1.Controls.Add(Me.Label_US11)
        Me.TabPage1.Controls.Add(Me.PTCODE)
        Me.TabPage1.Controls.Add(Me.Label_US10)
        Me.TabPage1.Controls.Add(Me.COST_STD)
        Me.TabPage1.Controls.Add(Me.Label_US9)
        Me.TabPage1.Controls.Add(Me.IMGNAME1)
        Me.TabPage1.Controls.Add(Me.PGCODE)
        Me.TabPage1.Controls.Add(Me.Label_US6)
        Me.TabPage1.Controls.Add(Me.ID)
        Me.TabPage1.Controls.Add(Me.Label_US1)
        Me.TabPage1.Controls.Add(Me.Label_US5)
        Me.TabPage1.Controls.Add(Me.PNAME)
        Me.TabPage1.Controls.Add(Me.ACTIVEFLAG)
        Me.TabPage1.Controls.Add(Me.Label_US2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(1018, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "สินค้า"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PCODE
        '
        Me.PCODE.BackColor = System.Drawing.Color.Salmon
        Me.PCODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PCODE.ForeColor = System.Drawing.Color.Black
        Me.PCODE.Location = New System.Drawing.Point(110, 18)
        Me.PCODE.MaxLength = 20
        Me.PCODE.Name = "PCODE"
        Me.PCODE.Size = New System.Drawing.Size(377, 25)
        Me.PCODE.TabIndex = 41
        Me.PCODE.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.PCODE.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.PCODE.US_Color_Didable = System.Drawing.Color.Salmon
        Me.PCODE.US_Color_Enable = System.Drawing.Color.Salmon
        Me.PCODE.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.PCODE.Us_dataBindings_TOP = 10
        Me.PCODE.US_Enable = True
        Me.PCODE.US_foreColor_Didable = System.Drawing.Color.White
        Me.PCODE.US_foreColor_Enable = System.Drawing.Color.Black
        Me.PCODE.US_Number = False
        Me.PCODE.US_Tag2 = ""
        Me.PCODE.US_value = Nothing
        '
        'Label_US13
        '
        Me.Label_US13.AutoSize = True
        Me.Label_US13.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US13.ForeColor = System.Drawing.Color.Black
        Me.Label_US13.Location = New System.Drawing.Point(492, 173)
        Me.Label_US13.Name = "Label_US13"
        Me.Label_US13.Size = New System.Drawing.Size(31, 19)
        Me.Label_US13.TabIndex = 40
        Me.Label_US13.Text = "บาท"
        '
        'Label_US12
        '
        Me.Label_US12.AutoSize = True
        Me.Label_US12.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US12.ForeColor = System.Drawing.Color.Black
        Me.Label_US12.Location = New System.Drawing.Point(188, 176)
        Me.Label_US12.Name = "Label_US12"
        Me.Label_US12.Size = New System.Drawing.Size(31, 19)
        Me.Label_US12.TabIndex = 39
        Me.Label_US12.Text = "บาท"
        '
        'PRICE_STD
        '
        Me.PRICE_STD.BackColor = System.Drawing.Color.White
        Me.PRICE_STD.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PRICE_STD.ForeColor = System.Drawing.Color.DarkGreen
        Me.PRICE_STD.Location = New System.Drawing.Point(414, 171)
        Me.PRICE_STD.Name = "PRICE_STD"
        Me.PRICE_STD.Size = New System.Drawing.Size(73, 25)
        Me.PRICE_STD.TabIndex = 38
        Me.PRICE_STD.Text = "0"
        Me.PRICE_STD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PRICE_STD.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.PRICE_STD.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.PRICE_STD.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.PRICE_STD.US_Color_Enable = System.Drawing.Color.White
        Me.PRICE_STD.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.PRICE_STD.Us_dataBindings_TOP = 10
        Me.PRICE_STD.US_Enable = True
        Me.PRICE_STD.US_foreColor_Didable = System.Drawing.Color.White
        Me.PRICE_STD.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.PRICE_STD.US_Number = True
        Me.PRICE_STD.US_Tag2 = ""
        Me.PRICE_STD.US_value = Nothing
        '
        'Label_US11
        '
        Me.Label_US11.AutoSize = True
        Me.Label_US11.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US11.ForeColor = System.Drawing.Color.Black
        Me.Label_US11.Location = New System.Drawing.Point(376, 173)
        Me.Label_US11.Name = "Label_US11"
        Me.Label_US11.Size = New System.Drawing.Size(35, 19)
        Me.Label_US11.TabIndex = 37
        Me.Label_US11.Text = "ราคา"
        '
        'PTCODE
        '
        Me.PTCODE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PTCODE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PTCODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PTCODE.FormattingEnabled = True
        Me.PTCODE.Location = New System.Drawing.Point(110, 80)
        Me.PTCODE.Name = "PTCODE"
        Me.PTCODE.Size = New System.Drawing.Size(377, 25)
        Me.PTCODE.TabIndex = 36
        '
        'Label_US10
        '
        Me.Label_US10.AutoSize = True
        Me.Label_US10.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US10.ForeColor = System.Drawing.Color.Black
        Me.Label_US10.Location = New System.Drawing.Point(23, 84)
        Me.Label_US10.Name = "Label_US10"
        Me.Label_US10.Size = New System.Drawing.Size(78, 19)
        Me.Label_US10.TabIndex = 35
        Me.Label_US10.Text = "ประเภทสินค้า"
        '
        'COST_STD
        '
        Me.COST_STD.BackColor = System.Drawing.Color.White
        Me.COST_STD.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.COST_STD.ForeColor = System.Drawing.Color.DarkGreen
        Me.COST_STD.Location = New System.Drawing.Point(110, 173)
        Me.COST_STD.Name = "COST_STD"
        Me.COST_STD.Size = New System.Drawing.Size(73, 25)
        Me.COST_STD.TabIndex = 34
        Me.COST_STD.Text = "0"
        Me.COST_STD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.COST_STD.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.COST_STD.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.COST_STD.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.COST_STD.US_Color_Enable = System.Drawing.Color.White
        Me.COST_STD.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.COST_STD.Us_dataBindings_TOP = 10
        Me.COST_STD.US_Enable = True
        Me.COST_STD.US_foreColor_Didable = System.Drawing.Color.White
        Me.COST_STD.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.COST_STD.US_Number = True
        Me.COST_STD.US_Tag2 = ""
        Me.COST_STD.US_value = Nothing
        '
        'Label_US9
        '
        Me.Label_US9.AutoSize = True
        Me.Label_US9.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US9.ForeColor = System.Drawing.Color.Black
        Me.Label_US9.Location = New System.Drawing.Point(23, 176)
        Me.Label_US9.Name = "Label_US9"
        Me.Label_US9.Size = New System.Drawing.Size(90, 19)
        Me.Label_US9.TabIndex = 33
        Me.Label_US9.Text = "ต้นทุนมาตรฐาน"
        '
        'IMGNAME1
        '
        Me.IMGNAME1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMGNAME1.ErrorImage = Nothing
        Me.IMGNAME1.Image = CType(resources.GetObject("IMGNAME1.Image"), System.Drawing.Image)
        Me.IMGNAME1.Location = New System.Drawing.Point(927, 7)
        Me.IMGNAME1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IMGNAME1.Name = "IMGNAME1"
        Me.IMGNAME1.Size = New System.Drawing.Size(86, 181)
        Me.IMGNAME1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IMGNAME1.TabIndex = 32
        Me.IMGNAME1.TabStop = False
        Me.IMGNAME1.Visible = False
        '
        'PGCODE
        '
        Me.PGCODE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PGCODE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PGCODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PGCODE.FormattingEnabled = True
        Me.PGCODE.Location = New System.Drawing.Point(110, 110)
        Me.PGCODE.Name = "PGCODE"
        Me.PGCODE.Size = New System.Drawing.Size(377, 25)
        Me.PGCODE.TabIndex = 23
        '
        'Label_US6
        '
        Me.Label_US6.AutoSize = True
        Me.Label_US6.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US6.ForeColor = System.Drawing.Color.Black
        Me.Label_US6.Location = New System.Drawing.Point(23, 113)
        Me.Label_US6.Name = "Label_US6"
        Me.Label_US6.Size = New System.Drawing.Size(63, 19)
        Me.Label_US6.TabIndex = 22
        Me.Label_US6.Text = "กลุ่มสินค้า"
        '
        'ID
        '
        Me.ID.BackColor = System.Drawing.Color.Gainsboro
        Me.ID.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ID.ForeColor = System.Drawing.Color.DarkGreen
        Me.ID.Location = New System.Drawing.Point(493, 21)
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Size = New System.Drawing.Size(36, 25)
        Me.ID.TabIndex = 21
        Me.ID.Text = "0"
        Me.ID.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.ID.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.ID.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.ID.US_Color_Enable = System.Drawing.Color.White
        Me.ID.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.ID.Us_dataBindings_TOP = 10
        Me.ID.US_Enable = False
        Me.ID.US_foreColor_Didable = System.Drawing.Color.White
        Me.ID.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.ID.US_Number = True
        Me.ID.US_Tag2 = ""
        Me.ID.US_value = Nothing
        Me.ID.Visible = False
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.Black
        Me.Label_US1.Location = New System.Drawing.Point(23, 24)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(61, 19)
        Me.Label_US1.TabIndex = 0
        Me.Label_US1.Text = "รหัสสินค้า"
        '
        'Label_US5
        '
        Me.Label_US5.AutoSize = True
        Me.Label_US5.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US5.ForeColor = System.Drawing.Color.Black
        Me.Label_US5.Location = New System.Drawing.Point(23, 141)
        Me.Label_US5.Name = "Label_US5"
        Me.Label_US5.Size = New System.Drawing.Size(44, 19)
        Me.Label_US5.TabIndex = 9
        Me.Label_US5.Text = "สถานะ"
        '
        'PNAME
        '
        Me.PNAME.BackColor = System.Drawing.Color.White
        Me.PNAME.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PNAME.ForeColor = System.Drawing.Color.DarkGreen
        Me.PNAME.Location = New System.Drawing.Point(110, 52)
        Me.PNAME.Name = "PNAME"
        Me.PNAME.Size = New System.Drawing.Size(377, 25)
        Me.PNAME.TabIndex = 3
        Me.PNAME.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.PNAME.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.PNAME.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.PNAME.US_Color_Enable = System.Drawing.Color.White
        Me.PNAME.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.PNAME.Us_dataBindings_TOP = 10
        Me.PNAME.US_Enable = True
        Me.PNAME.US_foreColor_Didable = System.Drawing.Color.White
        Me.PNAME.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.PNAME.US_Number = False
        Me.PNAME.US_Tag2 = ""
        Me.PNAME.US_value = Nothing
        '
        'ACTIVEFLAG
        '
        Me.ACTIVEFLAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACTIVEFLAG.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ACTIVEFLAG.FormattingEnabled = True
        Me.ACTIVEFLAG.Location = New System.Drawing.Point(110, 141)
        Me.ACTIVEFLAG.Name = "ACTIVEFLAG"
        Me.ACTIVEFLAG.Size = New System.Drawing.Size(377, 25)
        Me.ACTIVEFLAG.TabIndex = 8
        '
        'Label_US2
        '
        Me.Label_US2.AutoSize = True
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Black
        Me.Label_US2.Location = New System.Drawing.Point(23, 55)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(54, 19)
        Me.Label_US2.TabIndex = 2
        Me.Label_US2.Text = "ชื่อสินค้า"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_addunit)
        Me.TabPage2.Controls.Add(Me.unit_add)
        Me.TabPage2.Controls.Add(Me.Label_US8)
        Me.TabPage2.Controls.Add(Me.dgv_unit)
        Me.TabPage2.Controls.Add(Me.UNITCODE)
        Me.TabPage2.Controls.Add(Me.Label_US7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(1018, 235)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "หน่วยนับ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_addunit
        '
        Me.btn_addunit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_addunit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_addunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addunit.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_addunit.ForeColor = System.Drawing.Color.White
        Me.btn_addunit.Image = CType(resources.GetObject("btn_addunit.Image"), System.Drawing.Image)
        Me.btn_addunit.Location = New System.Drawing.Point(491, 43)
        Me.btn_addunit.Name = "btn_addunit"
        Me.btn_addunit.Size = New System.Drawing.Size(101, 32)
        Me.btn_addunit.TabIndex = 29
        Me.btn_addunit.Text = "  เพิ่ม"
        Me.btn_addunit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_addunit.UseVisualStyleBackColor = False
        '
        'unit_add
        '
        Me.unit_add.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.unit_add.FormattingEnabled = True
        Me.unit_add.Location = New System.Drawing.Point(108, 48)
        Me.unit_add.Name = "unit_add"
        Me.unit_add.Size = New System.Drawing.Size(377, 25)
        Me.unit_add.TabIndex = 28
        '
        'Label_US8
        '
        Me.Label_US8.AutoSize = True
        Me.Label_US8.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US8.ForeColor = System.Drawing.Color.Black
        Me.Label_US8.Location = New System.Drawing.Point(17, 51)
        Me.Label_US8.Name = "Label_US8"
        Me.Label_US8.Size = New System.Drawing.Size(72, 19)
        Me.Label_US8.TabIndex = 27
        Me.Label_US8.Text = "หน่วยนับรอง"
        '
        'dgv_unit
        '
        Me.dgv_unit.AllowUserToAddRows = False
        Me.dgv_unit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_unit.BackgroundColor = System.Drawing.Color.White
        Me.dgv_unit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_unit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_unit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_unit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_unit.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_unit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_unit.EnableHeadersVisualStyles = False
        Me.dgv_unit.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_unit.Location = New System.Drawing.Point(8, 81)
        Me.dgv_unit.Name = "dgv_unit"
        Me.dgv_unit.RowHeadersVisible = False
        Me.dgv_unit.RowHeadersWidth = 51
        Me.dgv_unit.RowTemplate.Height = 30
        Me.dgv_unit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_unit.Size = New System.Drawing.Size(1002, 145)
        Me.dgv_unit.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 334
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 333
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Column3"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 334
        '
        'UNITCODE
        '
        Me.UNITCODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UNITCODE.FormattingEnabled = True
        Me.UNITCODE.Location = New System.Drawing.Point(108, 6)
        Me.UNITCODE.Name = "UNITCODE"
        Me.UNITCODE.Size = New System.Drawing.Size(377, 25)
        Me.UNITCODE.TabIndex = 25
        '
        'Label_US7
        '
        Me.Label_US7.AutoSize = True
        Me.Label_US7.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US7.ForeColor = System.Drawing.Color.Black
        Me.Label_US7.Location = New System.Drawing.Point(17, 9)
        Me.Label_US7.Name = "Label_US7"
        Me.Label_US7.Size = New System.Drawing.Size(78, 19)
        Me.Label_US7.TabIndex = 24
        Me.Label_US7.Text = "หน่วยนับหลัก"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DESCRIPTION)
        Me.TabPage3.Controls.Add(Me.Label_US3)
        Me.TabPage3.Controls.Add(Me.Label_US4)
        Me.TabPage3.Controls.Add(Me.REMARK)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1018, 235)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "หมายเหตุ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DESCRIPTION.BackColor = System.Drawing.Color.White
        Me.DESCRIPTION.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DESCRIPTION.ForeColor = System.Drawing.Color.DarkGreen
        Me.DESCRIPTION.Location = New System.Drawing.Point(99, 24)
        Me.DESCRIPTION.Multiline = True
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.Size = New System.Drawing.Size(911, 56)
        Me.DESCRIPTION.TabIndex = 13
        Me.DESCRIPTION.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.DESCRIPTION.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.DESCRIPTION.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.DESCRIPTION.US_Color_Enable = System.Drawing.Color.White
        Me.DESCRIPTION.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.DESCRIPTION.Us_dataBindings_TOP = 10
        Me.DESCRIPTION.US_Enable = True
        Me.DESCRIPTION.US_foreColor_Didable = System.Drawing.Color.White
        Me.DESCRIPTION.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.DESCRIPTION.US_Number = False
        Me.DESCRIPTION.US_Tag2 = ""
        Me.DESCRIPTION.US_value = Nothing
        '
        'Label_US3
        '
        Me.Label_US3.AutoSize = True
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.Black
        Me.Label_US3.Location = New System.Drawing.Point(12, 27)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(67, 19)
        Me.Label_US3.TabIndex = 12
        Me.Label_US3.Text = "รายละเอียด"
        '
        'Label_US4
        '
        Me.Label_US4.AutoSize = True
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.Black
        Me.Label_US4.Location = New System.Drawing.Point(12, 89)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(58, 19)
        Me.Label_US4.TabIndex = 14
        Me.Label_US4.Text = "หมายเหตุ"
        '
        'REMARK
        '
        Me.REMARK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.REMARK.BackColor = System.Drawing.Color.White
        Me.REMARK.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.REMARK.ForeColor = System.Drawing.Color.DarkGreen
        Me.REMARK.Location = New System.Drawing.Point(99, 86)
        Me.REMARK.Multiline = True
        Me.REMARK.Name = "REMARK"
        Me.REMARK.Size = New System.Drawing.Size(911, 52)
        Me.REMARK.TabIndex = 15
        Me.REMARK.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.REMARK.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.REMARK.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.REMARK.US_Color_Enable = System.Drawing.Color.White
        Me.REMARK.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.REMARK.Us_dataBindings_TOP = 10
        Me.REMARK.US_Enable = True
        Me.REMARK.US_foreColor_Didable = System.Drawing.Color.White
        Me.REMARK.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.REMARK.US_Number = False
        Me.REMARK.US_Tag2 = ""
        Me.REMARK.US_value = Nothing
        '
        'ToolStrip_top
        '
        Me.ToolStrip_top.AutoSize = False
        Me.ToolStrip_top.BackColor = System.Drawing.Color.White
        Me.ToolStrip_top.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip_top.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_new, Me.btn_edit, Me.btn_save, Me.btn_cancel_save, Me.btndelete, Me.btn_close})
        Me.ToolStrip_top.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_top.Name = "ToolStrip_top"
        Me.ToolStrip_top.Size = New System.Drawing.Size(1026, 39)
        Me.ToolStrip_top.TabIndex = 20
        Me.ToolStrip_top.Text = "ToolStrip1"
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Image = CType(resources.GetObject("btn_new.Image"), System.Drawing.Image)
        Me.btn_new.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(51, 36)
        Me.btn_new.Text = "เพิ่ม"
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(58, 36)
        Me.btn_edit.Text = "แก้ไข"
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(62, 36)
        Me.btn_save.Text = "บันทึก"
        '
        'btn_cancel_save
        '
        Me.btn_cancel_save.Image = CType(resources.GetObject("btn_cancel_save.Image"), System.Drawing.Image)
        Me.btn_cancel_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancel_save.Name = "btn_cancel_save"
        Me.btn_cancel_save.Size = New System.Drawing.Size(105, 36)
        Me.btn_cancel_save.Text = "ยกเลิกการบันทึก"
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(46, 36)
        Me.btndelete.Text = "ลบ"
        Me.btndelete.Visible = False
        '
        'btn_close
        '
        Me.btn_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_close.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(91, 36)
        Me.btn_close.Tag = "50"
        Me.btn_close.Text = "ออกจากเมนู"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_scr)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 246)
        Me.Panel1.TabIndex = 0
        '
        'dgv_scr
        '
        Me.dgv_scr.AllowUserToAddRows = False
        Me.dgv_scr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_scr.BackgroundColor = System.Drawing.Color.White
        Me.dgv_scr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_scr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_scr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_scr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_scr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_scr.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_scr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_scr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_scr.EnableHeadersVisualStyles = False
        Me.dgv_scr.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_scr.Location = New System.Drawing.Point(0, 29)
        Me.dgv_scr.Name = "dgv_scr"
        Me.dgv_scr.ReadOnly = True
        Me.dgv_scr.RowHeadersVisible = False
        Me.dgv_scr.RowHeadersWidth = 51
        Me.dgv_scr.RowTemplate.Height = 30
        Me.dgv_scr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_scr.Size = New System.Drawing.Size(1026, 217)
        Me.dgv_scr.TabIndex = 1
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cbo_search, Me.txt_scr, Me.btn_scr, Me.Btn_Next, Me.txt_curpage, Me.Btn_last})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1026, 29)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(57, 26)
        Me.ToolStripLabel1.Text = "ค้นหาด้วย"
        '
        'cbo_search
        '
        Me.cbo_search.AutoSize = False
        Me.cbo_search.BackColor = System.Drawing.Color.Beige
        Me.cbo_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_search.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(200, 25)
        '
        'txt_scr
        '
        Me.txt_scr.BackColor = System.Drawing.Color.Beige
        Me.txt_scr.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_scr.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_scr.Name = "txt_scr"
        Me.txt_scr.Size = New System.Drawing.Size(400, 29)
        '
        'btn_scr
        '
        Me.btn_scr.AutoSize = False
        Me.btn_scr.BackColor = System.Drawing.Color.White
        Me.btn_scr.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scr.Image = CType(resources.GetObject("btn_scr.Image"), System.Drawing.Image)
        Me.btn_scr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_scr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_scr.Name = "btn_scr"
        Me.btn_scr.Size = New System.Drawing.Size(100, 26)
        Me.btn_scr.Text = "  ค้นหา"
        '
        'Btn_Next
        '
        Me.Btn_Next.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_Next.AutoSize = False
        Me.Btn_Next.BackColor = System.Drawing.Color.White
        Me.Btn_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Next.Image = CType(resources.GetObject("Btn_Next.Image"), System.Drawing.Image)
        Me.Btn_Next.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(50, 22)
        Me.Btn_Next.Text = "หน้าถัดไป"
        Me.Btn_Next.Visible = False
        '
        'txt_curpage
        '
        Me.txt_curpage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_curpage.AutoSize = False
        Me.txt_curpage.Enabled = False
        Me.txt_curpage.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_curpage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_curpage.Name = "txt_curpage"
        Me.txt_curpage.Size = New System.Drawing.Size(39, 25)
        Me.txt_curpage.Text = "1"
        Me.txt_curpage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_curpage.Visible = False
        '
        'Btn_last
        '
        Me.Btn_last.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_last.AutoSize = False
        Me.Btn_last.BackColor = System.Drawing.Color.White
        Me.Btn_last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_last.Image = CType(resources.GetObject("Btn_last.Image"), System.Drawing.Image)
        Me.Btn_last.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_last.Name = "Btn_last"
        Me.Btn_last.Size = New System.Drawing.Size(50, 22)
        Me.Btn_last.Text = "ย้อนกลับ"
        Me.Btn_last.Visible = False
        '
        'F_MAS_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 549)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "F_MAS_Product"
        Me.TabText = "F_Product"
        Me.Text = "F_Product"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.IMGNAME1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_unit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ToolStrip_top.ResumeLayout(False)
        Me.ToolStrip_top.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents ID As Control_us.Textbox_UC
    Friend WithEvents ToolStrip_top As ToolStrip
    Friend WithEvents btn_new As ToolStripButton
    Friend WithEvents btn_edit As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btndelete As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents Label_US5 As Control_us.Label_US
    Friend WithEvents ACTIVEFLAG As Control_us.Combobox_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents PNAME As Control_us.Textbox_UC
    Friend WithEvents dgv_scr As Control_us.DataGridView_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cbo_search As ToolStripComboBox
    Friend WithEvents txt_scr As ToolStripTextBox
    Friend WithEvents btn_scr As ToolStripButton
    Friend WithEvents Btn_Next As ToolStripButton
    Friend WithEvents txt_curpage As ToolStripTextBox
    Friend WithEvents Btn_last As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PGCODE As Control_us.Combobox_US
    Friend WithEvents Label_US6 As Control_us.Label_US
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DESCRIPTION As Control_us.Textbox_UC
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents REMARK As Control_us.Textbox_UC
    Friend WithEvents UNITCODE As Control_us.Combobox_US
    Friend WithEvents Label_US7 As Control_us.Label_US
    Friend WithEvents dgv_unit As Control_us.DataGridView_US
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents unit_add As Control_us.Combobox_US
    Friend WithEvents Label_US8 As Control_us.Label_US
    Friend WithEvents btn_addunit As Control_us.Button_US
    Friend WithEvents IMGNAME1 As PictureBox
    Friend WithEvents btn_cancel_save As ToolStripButton
    Friend WithEvents COST_STD As Control_us.Textbox_UC
    Friend WithEvents Label_US9 As Control_us.Label_US
    Friend WithEvents PTCODE As Control_us.Combobox_US
    Friend WithEvents Label_US10 As Control_us.Label_US
    Friend WithEvents PRICE_STD As Control_us.Textbox_UC
    Friend WithEvents Label_US11 As Control_us.Label_US
    Friend WithEvents Label_US13 As Control_us.Label_US
    Friend WithEvents Label_US12 As Control_us.Label_US
    Friend WithEvents PCODE As Control_us.Textbox_UC
End Class

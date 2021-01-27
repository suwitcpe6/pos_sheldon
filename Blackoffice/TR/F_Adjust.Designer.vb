<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Adjust
    Inherits WeifenLuo.WinFormsUI.DockContent

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Adjust))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolMain = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btn_save = New System.Windows.Forms.ToolStripButton()
        Me.btn_Close = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.T_doc = New System.Windows.Forms.TabPage()
        Me.btn_scr_reason = New Control_us.Button_US()
        Me.REASON = New Control_us.Textbox_UC()
        Me.Label_US13 = New Control_us.Label_US()
        Me.STCODE = New Control_us.Combobox_US()
        Me.Label_US11 = New Control_us.Label_US()
        Me.Label_US10 = New Control_us.Label_US()
        Me.REF_DOCNO = New Control_us.Textbox_UC()
        Me.TR_ID = New Control_us.Textbox_UC()
        Me.PERCODE = New Control_us.Combobox_US()
        Me.Label_US2 = New Control_us.Label_US()
        Me.Label_US5 = New Control_us.Label_US()
        Me.DOCDATE = New Control_us.DateTimePicker_US()
        Me.DOCTYPE = New Control_us.Combobox_US()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Label_US4 = New Control_us.Label_US()
        Me.DOCNO = New Control_us.Textbox_UC()
        Me.DCSTAT = New Control_us.Combobox_US()
        Me.Label_US3 = New Control_us.Label_US()
        Me.T_remark = New System.Windows.Forms.TabPage()
        Me.Label_US6 = New Control_us.Label_US()
        Me.Label_US7 = New Control_us.Label_US()
        Me.REMARK1 = New Control_us.Textbox_UC()
        Me.DESCRIPTION = New Control_us.Textbox_UC()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvItems = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TOTALDOWN_QTY = New Control_us.Textbox_UC()
        Me.Label_US12 = New Control_us.Label_US()
        Me.TOTALUP_QTY = New Control_us.Textbox_UC()
        Me.Label_US8 = New Control_us.Label_US()
        Me.TOTAL_AMOUNT = New Control_us.Textbox_UC()
        Me.Label_US9 = New Control_us.Label_US()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_addItems = New System.Windows.Forms.ToolStripButton()
        Me.btn_clear = New System.Windows.Forms.ToolStripButton()
        Me.btn_clear_reason = New Control_us.Button_US()
        CType(Me.ToolMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.T_doc.SuspendLayout()
        Me.T_remark.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolMain
        '
        Me.ToolMain.AddNewItem = Nothing
        Me.ToolMain.AutoSize = False
        Me.ToolMain.BackColor = System.Drawing.Color.White
        Me.ToolMain.CountItem = Nothing
        Me.ToolMain.DeleteItem = Nothing
        Me.ToolMain.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_save, Me.btn_Close})
        Me.ToolMain.Location = New System.Drawing.Point(0, 0)
        Me.ToolMain.MoveFirstItem = Nothing
        Me.ToolMain.MoveLastItem = Nothing
        Me.ToolMain.MoveNextItem = Nothing
        Me.ToolMain.MovePreviousItem = Nothing
        Me.ToolMain.Name = "ToolMain"
        Me.ToolMain.PositionItem = Nothing
        Me.ToolMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolMain.Size = New System.Drawing.Size(925, 35)
        Me.ToolMain.TabIndex = 55
        Me.ToolMain.Text = "BindingNavigator1"
        '
        'btn_save
        '
        Me.btn_save.AutoSize = False
        Me.btn_save.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.btn_save.RightToLeftAutoMirrorImage = True
        Me.btn_save.Size = New System.Drawing.Size(70, 29)
        Me.btn_save.Text = "บันทึก"
        '
        'btn_Close
        '
        Me.btn_Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.btn_Close.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Close.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(46, 32)
        Me.btn_Close.Text = "ปิด"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 35)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(925, 463)
        Me.SplitContainer1.SplitterDistance = 194
        Me.SplitContainer1.TabIndex = 56
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.T_doc)
        Me.TabControl1.Controls.Add(Me.T_remark)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(925, 194)
        Me.TabControl1.TabIndex = 10
        '
        'T_doc
        '
        Me.T_doc.Controls.Add(Me.btn_clear_reason)
        Me.T_doc.Controls.Add(Me.btn_scr_reason)
        Me.T_doc.Controls.Add(Me.REASON)
        Me.T_doc.Controls.Add(Me.Label_US13)
        Me.T_doc.Controls.Add(Me.STCODE)
        Me.T_doc.Controls.Add(Me.Label_US11)
        Me.T_doc.Controls.Add(Me.Label_US10)
        Me.T_doc.Controls.Add(Me.REF_DOCNO)
        Me.T_doc.Controls.Add(Me.TR_ID)
        Me.T_doc.Controls.Add(Me.PERCODE)
        Me.T_doc.Controls.Add(Me.Label_US2)
        Me.T_doc.Controls.Add(Me.Label_US5)
        Me.T_doc.Controls.Add(Me.DOCDATE)
        Me.T_doc.Controls.Add(Me.DOCTYPE)
        Me.T_doc.Controls.Add(Me.Label_US1)
        Me.T_doc.Controls.Add(Me.Label_US4)
        Me.T_doc.Controls.Add(Me.DOCNO)
        Me.T_doc.Controls.Add(Me.DCSTAT)
        Me.T_doc.Controls.Add(Me.Label_US3)
        Me.T_doc.Location = New System.Drawing.Point(4, 22)
        Me.T_doc.Name = "T_doc"
        Me.T_doc.Padding = New System.Windows.Forms.Padding(3)
        Me.T_doc.Size = New System.Drawing.Size(917, 168)
        Me.T_doc.TabIndex = 0
        Me.T_doc.Text = "เอกสาร"
        Me.T_doc.UseVisualStyleBackColor = True
        '
        'btn_scr_reason
        '
        Me.btn_scr_reason.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_scr_reason.BackColor = System.Drawing.Color.White
        Me.btn_scr_reason.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_scr_reason.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_scr_reason.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_scr_reason.ForeColor = System.Drawing.Color.White
        Me.btn_scr_reason.Image = CType(resources.GetObject("btn_scr_reason.Image"), System.Drawing.Image)
        Me.btn_scr_reason.Location = New System.Drawing.Point(769, 131)
        Me.btn_scr_reason.Name = "btn_scr_reason"
        Me.btn_scr_reason.Size = New System.Drawing.Size(59, 31)
        Me.btn_scr_reason.TabIndex = 22
        Me.btn_scr_reason.UseVisualStyleBackColor = False
        '
        'REASON
        '
        Me.REASON.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.REASON.BackColor = System.Drawing.Color.Gainsboro
        Me.REASON.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.REASON.ForeColor = System.Drawing.Color.DarkGreen
        Me.REASON.Location = New System.Drawing.Point(113, 135)
        Me.REASON.Name = "REASON"
        Me.REASON.ReadOnly = True
        Me.REASON.Size = New System.Drawing.Size(650, 25)
        Me.REASON.TabIndex = 21
        Me.REASON.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.REASON.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.REASON.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.REASON.US_Color_Enable = System.Drawing.Color.White
        Me.REASON.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.REASON.Us_dataBindings_TOP = 10
        Me.REASON.US_Enable = False
        Me.REASON.US_foreColor_Didable = System.Drawing.Color.White
        Me.REASON.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.REASON.US_Number = False
        Me.REASON.US_Tag2 = ""
        Me.REASON.US_value = Nothing
        '
        'Label_US13
        '
        Me.Label_US13.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US13.ForeColor = System.Drawing.Color.Black
        Me.Label_US13.Location = New System.Drawing.Point(24, 134)
        Me.Label_US13.Name = "Label_US13"
        Me.Label_US13.Size = New System.Drawing.Size(68, 19)
        Me.Label_US13.TabIndex = 20
        Me.Label_US13.Text = "เหตุผล"
        '
        'STCODE
        '
        Me.STCODE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.STCODE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.STCODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.STCODE.FormattingEnabled = True
        Me.STCODE.Location = New System.Drawing.Point(113, 104)
        Me.STCODE.Name = "STCODE"
        Me.STCODE.Size = New System.Drawing.Size(200, 25)
        Me.STCODE.TabIndex = 19
        '
        'Label_US11
        '
        Me.Label_US11.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US11.ForeColor = System.Drawing.Color.Black
        Me.Label_US11.Location = New System.Drawing.Point(24, 107)
        Me.Label_US11.Name = "Label_US11"
        Me.Label_US11.Size = New System.Drawing.Size(68, 19)
        Me.Label_US11.TabIndex = 18
        Me.Label_US11.Text = "คลัง"
        '
        'Label_US10
        '
        Me.Label_US10.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US10.ForeColor = System.Drawing.Color.Black
        Me.Label_US10.Location = New System.Drawing.Point(420, 79)
        Me.Label_US10.Name = "Label_US10"
        Me.Label_US10.Size = New System.Drawing.Size(87, 19)
        Me.Label_US10.TabIndex = 17
        Me.Label_US10.Text = "เลขอ้างอิง"
        '
        'REF_DOCNO
        '
        Me.REF_DOCNO.BackColor = System.Drawing.Color.White
        Me.REF_DOCNO.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.REF_DOCNO.ForeColor = System.Drawing.Color.DarkGreen
        Me.REF_DOCNO.Location = New System.Drawing.Point(513, 76)
        Me.REF_DOCNO.Name = "REF_DOCNO"
        Me.REF_DOCNO.Size = New System.Drawing.Size(200, 25)
        Me.REF_DOCNO.TabIndex = 16
        Me.REF_DOCNO.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.REF_DOCNO.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.REF_DOCNO.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.REF_DOCNO.US_Color_Enable = System.Drawing.Color.White
        Me.REF_DOCNO.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.REF_DOCNO.Us_dataBindings_TOP = 10
        Me.REF_DOCNO.US_Enable = True
        Me.REF_DOCNO.US_foreColor_Didable = System.Drawing.Color.White
        Me.REF_DOCNO.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.REF_DOCNO.US_Number = False
        Me.REF_DOCNO.US_Tag2 = ""
        Me.REF_DOCNO.US_value = Nothing
        '
        'TR_ID
        '
        Me.TR_ID.BackColor = System.Drawing.Color.Gainsboro
        Me.TR_ID.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TR_ID.ForeColor = System.Drawing.Color.DarkGreen
        Me.TR_ID.Location = New System.Drawing.Point(319, 11)
        Me.TR_ID.Name = "TR_ID"
        Me.TR_ID.ReadOnly = True
        Me.TR_ID.Size = New System.Drawing.Size(31, 25)
        Me.TR_ID.TabIndex = 13
        Me.TR_ID.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.TR_ID.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.TR_ID.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.TR_ID.US_Color_Enable = System.Drawing.Color.White
        Me.TR_ID.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.TR_ID.Us_dataBindings_TOP = 10
        Me.TR_ID.US_Enable = False
        Me.TR_ID.US_foreColor_Didable = System.Drawing.Color.White
        Me.TR_ID.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.TR_ID.US_Number = False
        Me.TR_ID.US_Tag2 = ""
        Me.TR_ID.US_value = Nothing
        Me.TR_ID.Visible = False
        '
        'PERCODE
        '
        Me.PERCODE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PERCODE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PERCODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PERCODE.FormattingEnabled = True
        Me.PERCODE.Location = New System.Drawing.Point(113, 73)
        Me.PERCODE.Name = "PERCODE"
        Me.PERCODE.Size = New System.Drawing.Size(200, 25)
        Me.PERCODE.TabIndex = 12
        '
        'Label_US2
        '
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Black
        Me.Label_US2.Location = New System.Drawing.Point(20, 14)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(87, 19)
        Me.Label_US2.TabIndex = 3
        Me.Label_US2.Text = "เลขที่เอกสาร"
        '
        'Label_US5
        '
        Me.Label_US5.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US5.ForeColor = System.Drawing.Color.Black
        Me.Label_US5.Location = New System.Drawing.Point(20, 42)
        Me.Label_US5.Name = "Label_US5"
        Me.Label_US5.Size = New System.Drawing.Size(93, 19)
        Me.Label_US5.TabIndex = 9
        Me.Label_US5.Text = "ประเภทเอกสาร"
        '
        'DOCDATE
        '
        Me.DOCDATE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DOCDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOCDATE.Location = New System.Drawing.Point(513, 14)
        Me.DOCDATE.Name = "DOCDATE"
        Me.DOCDATE.Size = New System.Drawing.Size(200, 25)
        Me.DOCDATE.TabIndex = 0
        '
        'DOCTYPE
        '
        Me.DOCTYPE.Enabled = False
        Me.DOCTYPE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DOCTYPE.FormattingEnabled = True
        Me.DOCTYPE.Location = New System.Drawing.Point(113, 42)
        Me.DOCTYPE.Name = "DOCTYPE"
        Me.DOCTYPE.Size = New System.Drawing.Size(200, 25)
        Me.DOCTYPE.TabIndex = 8
        '
        'Label_US1
        '
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.Black
        Me.Label_US1.Location = New System.Drawing.Point(399, 16)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(108, 23)
        Me.Label_US1.TabIndex = 1
        Me.Label_US1.Text = "วันที่"
        '
        'Label_US4
        '
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.Black
        Me.Label_US4.Location = New System.Drawing.Point(20, 76)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(72, 19)
        Me.Label_US4.TabIndex = 7
        Me.Label_US4.Text = "ผู้ทำรายการ"
        '
        'DOCNO
        '
        Me.DOCNO.BackColor = System.Drawing.Color.Gainsboro
        Me.DOCNO.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DOCNO.ForeColor = System.Drawing.Color.DarkGreen
        Me.DOCNO.Location = New System.Drawing.Point(113, 11)
        Me.DOCNO.Name = "DOCNO"
        Me.DOCNO.ReadOnly = True
        Me.DOCNO.Size = New System.Drawing.Size(200, 25)
        Me.DOCNO.TabIndex = 2
        Me.DOCNO.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.DOCNO.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.DOCNO.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.DOCNO.US_Color_Enable = System.Drawing.Color.White
        Me.DOCNO.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.DOCNO.Us_dataBindings_TOP = 10
        Me.DOCNO.US_Enable = False
        Me.DOCNO.US_foreColor_Didable = System.Drawing.Color.White
        Me.DOCNO.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.DOCNO.US_Number = False
        Me.DOCNO.US_Tag2 = ""
        Me.DOCNO.US_value = Nothing
        '
        'DCSTAT
        '
        Me.DCSTAT.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DCSTAT.FormattingEnabled = True
        Me.DCSTAT.Location = New System.Drawing.Point(513, 45)
        Me.DCSTAT.Name = "DCSTAT"
        Me.DCSTAT.Size = New System.Drawing.Size(200, 25)
        Me.DCSTAT.TabIndex = 4
        '
        'Label_US3
        '
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.Black
        Me.Label_US3.Location = New System.Drawing.Point(395, 45)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(93, 19)
        Me.Label_US3.TabIndex = 5
        Me.Label_US3.Text = "สถานะเอกสาร"
        '
        'T_remark
        '
        Me.T_remark.Controls.Add(Me.Label_US6)
        Me.T_remark.Controls.Add(Me.Label_US7)
        Me.T_remark.Controls.Add(Me.REMARK1)
        Me.T_remark.Controls.Add(Me.DESCRIPTION)
        Me.T_remark.Location = New System.Drawing.Point(4, 22)
        Me.T_remark.Name = "T_remark"
        Me.T_remark.Padding = New System.Windows.Forms.Padding(3)
        Me.T_remark.Size = New System.Drawing.Size(917, 168)
        Me.T_remark.TabIndex = 1
        Me.T_remark.Text = "หมายเหตุ"
        Me.T_remark.UseVisualStyleBackColor = True
        '
        'Label_US6
        '
        Me.Label_US6.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US6.ForeColor = System.Drawing.Color.Black
        Me.Label_US6.Location = New System.Drawing.Point(8, 19)
        Me.Label_US6.Name = "Label_US6"
        Me.Label_US6.Size = New System.Drawing.Size(79, 19)
        Me.Label_US6.TabIndex = 9
        Me.Label_US6.Text = "หมายเหตุ"
        '
        'Label_US7
        '
        Me.Label_US7.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US7.ForeColor = System.Drawing.Color.Black
        Me.Label_US7.Location = New System.Drawing.Point(8, 84)
        Me.Label_US7.Name = "Label_US7"
        Me.Label_US7.Size = New System.Drawing.Size(79, 19)
        Me.Label_US7.TabIndex = 11
        Me.Label_US7.Text = "รายละเอียด"
        '
        'REMARK1
        '
        Me.REMARK1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.REMARK1.BackColor = System.Drawing.Color.White
        Me.REMARK1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.REMARK1.ForeColor = System.Drawing.Color.DarkGreen
        Me.REMARK1.Location = New System.Drawing.Point(93, 19)
        Me.REMARK1.Multiline = True
        Me.REMARK1.Name = "REMARK1"
        Me.REMARK1.Size = New System.Drawing.Size(787, 59)
        Me.REMARK1.TabIndex = 8
        Me.REMARK1.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.REMARK1.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.REMARK1.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.REMARK1.US_Color_Enable = System.Drawing.Color.White
        Me.REMARK1.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.REMARK1.Us_dataBindings_TOP = 10
        Me.REMARK1.US_Enable = True
        Me.REMARK1.US_foreColor_Didable = System.Drawing.Color.White
        Me.REMARK1.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.REMARK1.US_Number = False
        Me.REMARK1.US_Tag2 = ""
        Me.REMARK1.US_value = Nothing
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DESCRIPTION.BackColor = System.Drawing.Color.White
        Me.DESCRIPTION.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DESCRIPTION.ForeColor = System.Drawing.Color.DarkGreen
        Me.DESCRIPTION.Location = New System.Drawing.Point(93, 84)
        Me.DESCRIPTION.Multiline = True
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.Size = New System.Drawing.Size(787, 67)
        Me.DESCRIPTION.TabIndex = 10
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
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(925, 265)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(917, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "รายการรับเข้า"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvItems)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(911, 204)
        Me.Panel1.TabIndex = 2
        '
        'DgvItems
        '
        Me.DgvItems.AllowUserToAddRows = False
        Me.DgvItems.BackgroundColor = System.Drawing.Color.White
        Me.DgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvItems.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DgvItems.EnableHeadersVisualStyles = False
        Me.DgvItems.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DgvItems.Location = New System.Drawing.Point(0, 0)
        Me.DgvItems.Name = "DgvItems"
        Me.DgvItems.RowHeadersVisible = False
        Me.DgvItems.RowTemplate.Height = 30
        Me.DgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvItems.Size = New System.Drawing.Size(911, 156)
        Me.DgvItems.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TOTALDOWN_QTY)
        Me.Panel2.Controls.Add(Me.Label_US12)
        Me.Panel2.Controls.Add(Me.TOTALUP_QTY)
        Me.Panel2.Controls.Add(Me.Label_US8)
        Me.Panel2.Controls.Add(Me.TOTAL_AMOUNT)
        Me.Panel2.Controls.Add(Me.Label_US9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(911, 48)
        Me.Panel2.TabIndex = 1
        '
        'TOTALDOWN_QTY
        '
        Me.TOTALDOWN_QTY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TOTALDOWN_QTY.BackColor = System.Drawing.Color.Gainsboro
        Me.TOTALDOWN_QTY.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TOTALDOWN_QTY.ForeColor = System.Drawing.Color.DarkGreen
        Me.TOTALDOWN_QTY.Location = New System.Drawing.Point(791, 6)
        Me.TOTALDOWN_QTY.Name = "TOTALDOWN_QTY"
        Me.TOTALDOWN_QTY.ReadOnly = True
        Me.TOTALDOWN_QTY.Size = New System.Drawing.Size(106, 35)
        Me.TOTALDOWN_QTY.TabIndex = 16
        Me.TOTALDOWN_QTY.Text = "0"
        Me.TOTALDOWN_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TOTALDOWN_QTY.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.TOTALDOWN_QTY.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.TOTALDOWN_QTY.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.TOTALDOWN_QTY.US_Color_Enable = System.Drawing.Color.White
        Me.TOTALDOWN_QTY.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.TOTALDOWN_QTY.Us_dataBindings_TOP = 10
        Me.TOTALDOWN_QTY.US_Enable = False
        Me.TOTALDOWN_QTY.US_foreColor_Didable = System.Drawing.Color.White
        Me.TOTALDOWN_QTY.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.TOTALDOWN_QTY.US_Number = True
        Me.TOTALDOWN_QTY.US_Tag2 = ""
        Me.TOTALDOWN_QTY.US_value = Nothing
        '
        'Label_US12
        '
        Me.Label_US12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_US12.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US12.ForeColor = System.Drawing.Color.Black
        Me.Label_US12.Location = New System.Drawing.Point(582, 9)
        Me.Label_US12.Name = "Label_US12"
        Me.Label_US12.Size = New System.Drawing.Size(203, 32)
        Me.Label_US12.TabIndex = 17
        Me.Label_US12.Text = "จำนวนลดทั้งหมด"
        '
        'TOTALUP_QTY
        '
        Me.TOTALUP_QTY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TOTALUP_QTY.BackColor = System.Drawing.Color.Gainsboro
        Me.TOTALUP_QTY.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TOTALUP_QTY.ForeColor = System.Drawing.Color.DarkGreen
        Me.TOTALUP_QTY.Location = New System.Drawing.Point(470, 6)
        Me.TOTALUP_QTY.Name = "TOTALUP_QTY"
        Me.TOTALUP_QTY.ReadOnly = True
        Me.TOTALUP_QTY.Size = New System.Drawing.Size(106, 35)
        Me.TOTALUP_QTY.TabIndex = 10
        Me.TOTALUP_QTY.Text = "0"
        Me.TOTALUP_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TOTALUP_QTY.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.TOTALUP_QTY.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.TOTALUP_QTY.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.TOTALUP_QTY.US_Color_Enable = System.Drawing.Color.White
        Me.TOTALUP_QTY.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.TOTALUP_QTY.Us_dataBindings_TOP = 10
        Me.TOTALUP_QTY.US_Enable = False
        Me.TOTALUP_QTY.US_foreColor_Didable = System.Drawing.Color.White
        Me.TOTALUP_QTY.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.TOTALUP_QTY.US_Number = True
        Me.TOTALUP_QTY.US_Tag2 = ""
        Me.TOTALUP_QTY.US_value = Nothing
        '
        'Label_US8
        '
        Me.Label_US8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_US8.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US8.ForeColor = System.Drawing.Color.Black
        Me.Label_US8.Location = New System.Drawing.Point(261, 9)
        Me.Label_US8.Name = "Label_US8"
        Me.Label_US8.Size = New System.Drawing.Size(203, 32)
        Me.Label_US8.TabIndex = 11
        Me.Label_US8.Text = "จำนวนเพิ่มทั้งหมด"
        '
        'TOTAL_AMOUNT
        '
        Me.TOTAL_AMOUNT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TOTAL_AMOUNT.BackColor = System.Drawing.Color.Gainsboro
        Me.TOTAL_AMOUNT.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TOTAL_AMOUNT.ForeColor = System.Drawing.Color.DarkGreen
        Me.TOTAL_AMOUNT.Location = New System.Drawing.Point(110, 9)
        Me.TOTAL_AMOUNT.Name = "TOTAL_AMOUNT"
        Me.TOTAL_AMOUNT.ReadOnly = True
        Me.TOTAL_AMOUNT.Size = New System.Drawing.Size(95, 25)
        Me.TOTAL_AMOUNT.TabIndex = 14
        Me.TOTAL_AMOUNT.Text = "0"
        Me.TOTAL_AMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TOTAL_AMOUNT.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.TOTAL_AMOUNT.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.TOTAL_AMOUNT.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.TOTAL_AMOUNT.US_Color_Enable = System.Drawing.Color.White
        Me.TOTAL_AMOUNT.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.TOTAL_AMOUNT.Us_dataBindings_TOP = 10
        Me.TOTAL_AMOUNT.US_Enable = False
        Me.TOTAL_AMOUNT.US_foreColor_Didable = System.Drawing.Color.White
        Me.TOTAL_AMOUNT.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.TOTAL_AMOUNT.US_Number = True
        Me.TOTAL_AMOUNT.US_Tag2 = ""
        Me.TOTAL_AMOUNT.US_value = Nothing
        Me.TOTAL_AMOUNT.Visible = False
        '
        'Label_US9
        '
        Me.Label_US9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_US9.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US9.ForeColor = System.Drawing.Color.Black
        Me.Label_US9.Location = New System.Drawing.Point(8, 12)
        Me.Label_US9.Name = "Label_US9"
        Me.Label_US9.Size = New System.Drawing.Size(108, 19)
        Me.Label_US9.TabIndex = 15
        Me.Label_US9.Text = "มูลค่ารวมทั้งหมด"
        Me.Label_US9.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.btn_addItems, Me.btn_clear})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(911, 29)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 26)
        Me.ToolStripLabel1.Text = "Items Data"
        '
        'btn_addItems
        '
        Me.btn_addItems.AutoSize = False
        Me.btn_addItems.BackColor = System.Drawing.Color.Linen
        Me.btn_addItems.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addItems.Image = CType(resources.GetObject("btn_addItems.Image"), System.Drawing.Image)
        Me.btn_addItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_addItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addItems.Name = "btn_addItems"
        Me.btn_addItems.Size = New System.Drawing.Size(100, 26)
        Me.btn_addItems.Text = "  เพิ่ม"
        '
        'btn_clear
        '
        Me.btn_clear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_clear.AutoSize = False
        Me.btn_clear.BackColor = System.Drawing.Color.Linen
        Me.btn_clear.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(100, 26)
        Me.btn_clear.Text = "ลบทั้งหมด"
        '
        'btn_clear_reason
        '
        Me.btn_clear_reason.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear_reason.BackColor = System.Drawing.Color.White
        Me.btn_clear_reason.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_clear_reason.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear_reason.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_clear_reason.ForeColor = System.Drawing.Color.White
        Me.btn_clear_reason.Image = CType(resources.GetObject("btn_clear_reason.Image"), System.Drawing.Image)
        Me.btn_clear_reason.Location = New System.Drawing.Point(834, 131)
        Me.btn_clear_reason.Name = "btn_clear_reason"
        Me.btn_clear_reason.Size = New System.Drawing.Size(59, 31)
        Me.btn_clear_reason.TabIndex = 23
        Me.btn_clear_reason.UseVisualStyleBackColor = False
        '
        'F_Adjust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(925, 498)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolMain)
        Me.Name = "F_Adjust"
        CType(Me.ToolMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolMain.ResumeLayout(False)
        Me.ToolMain.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.T_doc.ResumeLayout(False)
        Me.T_doc.PerformLayout()
        Me.T_remark.ResumeLayout(False)
        Me.T_remark.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolMain As BindingNavigator
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btn_Close As ToolStripButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents DCSTAT As Control_us.Combobox_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents DOCNO As Control_us.Textbox_UC
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents DOCDATE As Control_us.DateTimePicker_US
    Friend WithEvents Label_US5 As Control_us.Label_US
    Friend WithEvents DOCTYPE As Control_us.Combobox_US
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents T_doc As TabPage
    Friend WithEvents T_remark As TabPage
    Friend WithEvents Label_US6 As Control_us.Label_US
    Friend WithEvents Label_US7 As Control_us.Label_US
    Friend WithEvents REMARK1 As Control_us.Textbox_UC
    Friend WithEvents DESCRIPTION As Control_us.Textbox_UC
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label_US8 As Control_us.Label_US
    Friend WithEvents TOTALUP_QTY As Control_us.Textbox_UC
    Friend WithEvents btn_clear As ToolStripButton
    Friend WithEvents btn_addItems As ToolStripButton
    Friend WithEvents PERCODE As Control_us.Combobox_US
    Friend WithEvents TR_ID As Control_us.Textbox_UC
    Friend WithEvents Label_US9 As Control_us.Label_US
    Friend WithEvents TOTAL_AMOUNT As Control_us.Textbox_UC
    Friend WithEvents Label_US10 As Control_us.Label_US
    Friend WithEvents REF_DOCNO As Control_us.Textbox_UC
    Friend WithEvents STCODE As Control_us.Combobox_US
    Friend WithEvents Label_US11 As Control_us.Label_US
    Friend WithEvents DgvItems As Control_us.DataGridView_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TOTALDOWN_QTY As Control_us.Textbox_UC
    Friend WithEvents Label_US12 As Control_us.Label_US
    Friend WithEvents Label_US13 As Control_us.Label_US
    Friend WithEvents REASON As Control_us.Textbox_UC
    Friend WithEvents btn_scr_reason As Control_us.Button_US
    Friend WithEvents btn_clear_reason As Control_us.Button_US
End Class

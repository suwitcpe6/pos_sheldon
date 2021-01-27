<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_MAS_REASON
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_MAS_REASON))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New Control_us.Textbox_UC()
        Me.ToolStrip_top = New System.Windows.Forms.ToolStrip()
        Me.btn_new = New System.Windows.Forms.ToolStripButton()
        Me.btn_edit = New System.Windows.Forms.ToolStripButton()
        Me.btn_save = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancel_save = New System.Windows.Forms.ToolStripButton()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbo_search = New System.Windows.Forms.ToolStripComboBox()
        Me.txt_scr = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_scr = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Next = New System.Windows.Forms.ToolStripButton()
        Me.txt_curpage = New System.Windows.Forms.ToolStripTextBox()
        Me.Btn_last = New System.Windows.Forms.ToolStripButton()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Label_US5 = New Control_us.Label_US()
        Me.RSCODE = New Control_us.Textbox_UC()
        Me.ACTIVEFLAG = New Control_us.Combobox_US()
        Me.Label_US2 = New Control_us.Label_US()
        Me.REMARK = New Control_us.Textbox_UC()
        Me.RSNAME = New Control_us.Textbox_UC()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_US4 = New Control_us.Label_US()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_scr = New Control_us.DataGridView_US()
        Me.Label_US3 = New Control_us.Label_US()
        Me.DESCRIPTION = New Control_us.Textbox_UC()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip_top.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'ID
        '
        Me.ID.BackColor = System.Drawing.Color.Gainsboro
        Me.ID.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ID.ForeColor = System.Drawing.Color.DarkGreen
        Me.ID.Location = New System.Drawing.Point(540, 50)
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
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.Black
        Me.Label_US1.Location = New System.Drawing.Point(70, 56)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(67, 19)
        Me.Label_US1.TabIndex = 0
        Me.Label_US1.Text = "รหัสเหตุผล"
        '
        'Label_US5
        '
        Me.Label_US5.AutoSize = True
        Me.Label_US5.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US5.ForeColor = System.Drawing.Color.Black
        Me.Label_US5.Location = New System.Drawing.Point(70, 183)
        Me.Label_US5.Name = "Label_US5"
        Me.Label_US5.Size = New System.Drawing.Size(44, 19)
        Me.Label_US5.TabIndex = 9
        Me.Label_US5.Text = "สถานะ"
        '
        'RSCODE
        '
        Me.RSCODE.BackColor = System.Drawing.Color.Gainsboro
        Me.RSCODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RSCODE.ForeColor = System.Drawing.Color.DarkGreen
        Me.RSCODE.Location = New System.Drawing.Point(157, 53)
        Me.RSCODE.MaxLength = 10
        Me.RSCODE.Name = "RSCODE"
        Me.RSCODE.ReadOnly = True
        Me.RSCODE.Size = New System.Drawing.Size(377, 25)
        Me.RSCODE.TabIndex = 1
        Me.RSCODE.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.RSCODE.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.RSCODE.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.RSCODE.US_Color_Enable = System.Drawing.Color.White
        Me.RSCODE.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.RSCODE.Us_dataBindings_TOP = 10
        Me.RSCODE.US_Enable = False
        Me.RSCODE.US_foreColor_Didable = System.Drawing.Color.White
        Me.RSCODE.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.RSCODE.US_Number = False
        Me.RSCODE.US_Tag2 = ""
        Me.RSCODE.US_value = Nothing
        '
        'ACTIVEFLAG
        '
        Me.ACTIVEFLAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACTIVEFLAG.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ACTIVEFLAG.FormattingEnabled = True
        Me.ACTIVEFLAG.Location = New System.Drawing.Point(157, 177)
        Me.ACTIVEFLAG.Name = "ACTIVEFLAG"
        Me.ACTIVEFLAG.Size = New System.Drawing.Size(377, 25)
        Me.ACTIVEFLAG.TabIndex = 8
        '
        'Label_US2
        '
        Me.Label_US2.AutoSize = True
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Black
        Me.Label_US2.Location = New System.Drawing.Point(70, 87)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(45, 19)
        Me.Label_US2.TabIndex = 2
        Me.Label_US2.Text = "เหตุผล"
        '
        'REMARK
        '
        Me.REMARK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.REMARK.BackColor = System.Drawing.Color.White
        Me.REMARK.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.REMARK.ForeColor = System.Drawing.Color.DarkGreen
        Me.REMARK.Location = New System.Drawing.Point(157, 146)
        Me.REMARK.Name = "REMARK"
        Me.REMARK.Size = New System.Drawing.Size(857, 25)
        Me.REMARK.TabIndex = 7
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
        'RSNAME
        '
        Me.RSNAME.BackColor = System.Drawing.Color.White
        Me.RSNAME.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RSNAME.ForeColor = System.Drawing.Color.DarkGreen
        Me.RSNAME.Location = New System.Drawing.Point(157, 84)
        Me.RSNAME.Name = "RSNAME"
        Me.RSNAME.Size = New System.Drawing.Size(377, 25)
        Me.RSNAME.TabIndex = 3
        Me.RSNAME.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.RSNAME.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.RSNAME.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.RSNAME.US_Color_Enable = System.Drawing.Color.White
        Me.RSNAME.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.RSNAME.Us_dataBindings_TOP = 10
        Me.RSNAME.US_Enable = True
        Me.RSNAME.US_foreColor_Didable = System.Drawing.Color.White
        Me.RSNAME.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.RSNAME.US_Number = False
        Me.RSNAME.US_Tag2 = ""
        Me.RSNAME.US_value = Nothing
        '
        'Timer1
        '
        '
        'Label_US4
        '
        Me.Label_US4.AutoSize = True
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.Black
        Me.Label_US4.Location = New System.Drawing.Point(70, 149)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(58, 19)
        Me.Label_US4.TabIndex = 6
        Me.Label_US4.Text = "หมายเหตุ"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_scr)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 313)
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
        Me.dgv_scr.Size = New System.Drawing.Size(1026, 284)
        Me.dgv_scr.TabIndex = 1
        '
        'Label_US3
        '
        Me.Label_US3.AutoSize = True
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.Black
        Me.Label_US3.Location = New System.Drawing.Point(70, 118)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(67, 19)
        Me.Label_US3.TabIndex = 4
        Me.Label_US3.Text = "รายละเอียด"
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DESCRIPTION.BackColor = System.Drawing.Color.White
        Me.DESCRIPTION.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DESCRIPTION.ForeColor = System.Drawing.Color.DarkGreen
        Me.DESCRIPTION.Location = New System.Drawing.Point(157, 115)
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.Size = New System.Drawing.Size(857, 25)
        Me.DESCRIPTION.TabIndex = 5
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
        Me.SplitContainer1.SplitterDistance = 232
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ID)
        Me.Panel2.Controls.Add(Me.ToolStrip_top)
        Me.Panel2.Controls.Add(Me.Label_US1)
        Me.Panel2.Controls.Add(Me.Label_US5)
        Me.Panel2.Controls.Add(Me.RSCODE)
        Me.Panel2.Controls.Add(Me.ACTIVEFLAG)
        Me.Panel2.Controls.Add(Me.Label_US2)
        Me.Panel2.Controls.Add(Me.REMARK)
        Me.Panel2.Controls.Add(Me.RSNAME)
        Me.Panel2.Controls.Add(Me.Label_US4)
        Me.Panel2.Controls.Add(Me.Label_US3)
        Me.Panel2.Controls.Add(Me.DESCRIPTION)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 232)
        Me.Panel2.TabIndex = 10
        '
        'F_MAS_REASON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 549)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "F_MAS_REASON"
        Me.TabText = "F_MAS_REASON"
        Me.Text = "F_MAS_REASON"
        Me.ToolStrip_top.ResumeLayout(False)
        Me.ToolStrip_top.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents ID As Control_us.Textbox_UC
    Friend WithEvents ToolStrip_top As ToolStrip
    Friend WithEvents btn_new As ToolStripButton
    Friend WithEvents btn_edit As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btndelete As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cbo_search As ToolStripComboBox
    Friend WithEvents txt_scr As ToolStripTextBox
    Friend WithEvents btn_scr As ToolStripButton
    Friend WithEvents Btn_Next As ToolStripButton
    Friend WithEvents txt_curpage As ToolStripTextBox
    Friend WithEvents Btn_last As ToolStripButton
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents Label_US5 As Control_us.Label_US
    Friend WithEvents RSCODE As Control_us.Textbox_UC
    Friend WithEvents ACTIVEFLAG As Control_us.Combobox_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents REMARK As Control_us.Textbox_UC
    Friend WithEvents RSNAME As Control_us.Textbox_UC
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_scr As Control_us.DataGridView_US
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents DESCRIPTION As Control_us.Textbox_UC
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_cancel_save As ToolStripButton
End Class

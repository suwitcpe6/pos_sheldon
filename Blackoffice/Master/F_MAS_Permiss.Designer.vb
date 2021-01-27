<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_MAS_Permiss
    'Inherits System.Windows.Forms.Form
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
        Dim TabPage_Main As System.Windows.Forms.TabPage
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_MAS_Permiss))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_US1 = New Control_us.Panel_US()
        Me.Label_US6 = New Control_us.Label_US()
        Me.Label_US1 = New Control_us.Label_US()
        Me.PERMIS_NAME = New Control_us.Textbox_UC()
        Me.DESCRIPTION = New Control_us.Textbox_UC()
        Me.btn_clear_uid = New Control_us.Button_US()
        Me.Label_US3 = New Control_us.Label_US()
        Me.btn_scr_uid = New Control_us.Button_US()
        Me.Label_US4 = New Control_us.Label_US()
        Me.UID = New Control_us.Textbox_UC()
        Me.REMARK = New Control_us.Textbox_UC()
        Me.TR_ID = New Control_us.Textbox_UC()
        Me.Label_US2 = New Control_us.Label_US()
        Me.ACTIVEFLAG = New Control_us.Combobox_US()
        Me.PERMIS_CODE = New Control_us.Textbox_UC()
        Me.Label_US5 = New Control_us.Label_US()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl_US1 = New Control_us.TabControl_US()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chk_selectall = New Control_us.CheckBox1_US()
        Me.dgv_permiss = New Control_us.DataGridView_US()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Copy = New System.Windows.Forms.ToolStripButton()
        TabPage_Main = New System.Windows.Forms.TabPage()
        TabPage_Main.SuspendLayout()
        Me.Panel_US1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl_US1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_permiss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip_top.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage_Main
        '
        TabPage_Main.Controls.Add(Me.Panel_US1)
        TabPage_Main.Location = New System.Drawing.Point(4, 26)
        TabPage_Main.Name = "TabPage_Main"
        TabPage_Main.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        TabPage_Main.Size = New System.Drawing.Size(1018, 295)
        TabPage_Main.TabIndex = 0
        TabPage_Main.Text = "ข้อมูลหลัก"
        TabPage_Main.UseVisualStyleBackColor = True
        '
        'Panel_US1
        '
        Me.Panel_US1.Controls.Add(Me.Label_US6)
        Me.Panel_US1.Controls.Add(Me.Label_US1)
        Me.Panel_US1.Controls.Add(Me.PERMIS_NAME)
        Me.Panel_US1.Controls.Add(Me.DESCRIPTION)
        Me.Panel_US1.Controls.Add(Me.btn_clear_uid)
        Me.Panel_US1.Controls.Add(Me.Label_US3)
        Me.Panel_US1.Controls.Add(Me.btn_scr_uid)
        Me.Panel_US1.Controls.Add(Me.Label_US4)
        Me.Panel_US1.Controls.Add(Me.UID)
        Me.Panel_US1.Controls.Add(Me.REMARK)
        Me.Panel_US1.Controls.Add(Me.TR_ID)
        Me.Panel_US1.Controls.Add(Me.Label_US2)
        Me.Panel_US1.Controls.Add(Me.ACTIVEFLAG)
        Me.Panel_US1.Controls.Add(Me.PERMIS_CODE)
        Me.Panel_US1.Controls.Add(Me.Label_US5)
        Me.Panel_US1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US1.Location = New System.Drawing.Point(3, 3)
        Me.Panel_US1.Name = "Panel_US1"
        Me.Panel_US1.Size = New System.Drawing.Size(1012, 289)
        Me.Panel_US1.TabIndex = 27
        '
        'Label_US6
        '
        Me.Label_US6.AutoSize = True
        Me.Label_US6.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US6.ForeColor = System.Drawing.Color.Red
        Me.Label_US6.Location = New System.Drawing.Point(109, 105)
        Me.Label_US6.Name = "Label_US6"
        Me.Label_US6.Size = New System.Drawing.Size(617, 19)
        Me.Label_US6.TabIndex = 27
        Me.Label_US6.Text = "หมายเหตุ  : Uaer ID ที่ผูกกับสิทธิ์แล้วจะไม่สามารถค้นหาได้ ให้ผู้ใช้งานกลับไปแก้ไ" &
    "ขสิทธิ์เดิม หรือ ลบออกแล้วสร้างใหม่"
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.Black
        Me.Label_US1.Location = New System.Drawing.Point(26, 66)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(54, 19)
        Me.Label_US1.TabIndex = 0
        Me.Label_US1.Text = "รหัสสิทธิ์"
        '
        'PERMIS_NAME
        '
        Me.PERMIS_NAME.BackColor = System.Drawing.Color.Gainsboro
        Me.PERMIS_NAME.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PERMIS_NAME.ForeColor = System.Drawing.Color.DarkGreen
        Me.PERMIS_NAME.Location = New System.Drawing.Point(270, 127)
        Me.PERMIS_NAME.MaxLength = 10
        Me.PERMIS_NAME.Name = "PERMIS_NAME"
        Me.PERMIS_NAME.ReadOnly = True
        Me.PERMIS_NAME.Size = New System.Drawing.Size(441, 25)
        Me.PERMIS_NAME.TabIndex = 26
        Me.PERMIS_NAME.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.PERMIS_NAME.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.PERMIS_NAME.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.PERMIS_NAME.US_Color_Enable = System.Drawing.Color.White
        Me.PERMIS_NAME.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.PERMIS_NAME.Us_dataBindings_TOP = 10
        Me.PERMIS_NAME.US_Enable = False
        Me.PERMIS_NAME.US_foreColor_Didable = System.Drawing.Color.White
        Me.PERMIS_NAME.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.PERMIS_NAME.US_Number = False
        Me.PERMIS_NAME.US_Tag2 = ""
        Me.PERMIS_NAME.US_value = Nothing
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DESCRIPTION.BackColor = System.Drawing.Color.White
        Me.DESCRIPTION.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DESCRIPTION.ForeColor = System.Drawing.Color.DarkGreen
        Me.DESCRIPTION.Location = New System.Drawing.Point(113, 160)
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.Size = New System.Drawing.Size(598, 25)
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
        'btn_clear_uid
        '
        Me.btn_clear_uid.BackColor = System.Drawing.Color.White
        Me.btn_clear_uid.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_clear_uid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear_uid.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_clear_uid.ForeColor = System.Drawing.Color.White
        Me.btn_clear_uid.Image = CType(resources.GetObject("btn_clear_uid.Image"), System.Drawing.Image)
        Me.btn_clear_uid.Location = New System.Drawing.Point(782, 123)
        Me.btn_clear_uid.Name = "btn_clear_uid"
        Me.btn_clear_uid.Size = New System.Drawing.Size(59, 31)
        Me.btn_clear_uid.TabIndex = 25
        Me.btn_clear_uid.UseVisualStyleBackColor = False
        '
        'Label_US3
        '
        Me.Label_US3.AutoSize = True
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.Black
        Me.Label_US3.Location = New System.Drawing.Point(26, 163)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(67, 19)
        Me.Label_US3.TabIndex = 4
        Me.Label_US3.Text = "รายละเอียด"
        '
        'btn_scr_uid
        '
        Me.btn_scr_uid.BackColor = System.Drawing.Color.White
        Me.btn_scr_uid.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_scr_uid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_scr_uid.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_scr_uid.ForeColor = System.Drawing.Color.White
        Me.btn_scr_uid.Image = CType(resources.GetObject("btn_scr_uid.Image"), System.Drawing.Image)
        Me.btn_scr_uid.Location = New System.Drawing.Point(717, 123)
        Me.btn_scr_uid.Name = "btn_scr_uid"
        Me.btn_scr_uid.Size = New System.Drawing.Size(59, 31)
        Me.btn_scr_uid.TabIndex = 24
        Me.btn_scr_uid.UseVisualStyleBackColor = False
        '
        'Label_US4
        '
        Me.Label_US4.AutoSize = True
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.Black
        Me.Label_US4.Location = New System.Drawing.Point(26, 194)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(58, 19)
        Me.Label_US4.TabIndex = 6
        Me.Label_US4.Text = "หมายเหตุ"
        '
        'UID
        '
        Me.UID.BackColor = System.Drawing.Color.Gainsboro
        Me.UID.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.UID.ForeColor = System.Drawing.Color.DarkGreen
        Me.UID.Location = New System.Drawing.Point(113, 127)
        Me.UID.MaxLength = 10
        Me.UID.Name = "UID"
        Me.UID.ReadOnly = True
        Me.UID.Size = New System.Drawing.Size(151, 25)
        Me.UID.TabIndex = 22
        Me.UID.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.UID.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.UID.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.UID.US_Color_Enable = System.Drawing.Color.White
        Me.UID.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.UID.Us_dataBindings_TOP = 10
        Me.UID.US_Enable = False
        Me.UID.US_foreColor_Didable = System.Drawing.Color.White
        Me.UID.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.UID.US_Number = False
        Me.UID.US_Tag2 = ""
        Me.UID.US_value = Nothing
        '
        'REMARK
        '
        Me.REMARK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.REMARK.BackColor = System.Drawing.Color.White
        Me.REMARK.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.REMARK.ForeColor = System.Drawing.Color.DarkGreen
        Me.REMARK.Location = New System.Drawing.Point(113, 191)
        Me.REMARK.Name = "REMARK"
        Me.REMARK.Size = New System.Drawing.Size(598, 25)
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
        'TR_ID
        '
        Me.TR_ID.BackColor = System.Drawing.Color.Gainsboro
        Me.TR_ID.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TR_ID.ForeColor = System.Drawing.Color.DarkGreen
        Me.TR_ID.Location = New System.Drawing.Point(496, 60)
        Me.TR_ID.Name = "TR_ID"
        Me.TR_ID.ReadOnly = True
        Me.TR_ID.Size = New System.Drawing.Size(36, 25)
        Me.TR_ID.TabIndex = 21
        Me.TR_ID.Text = "0"
        Me.TR_ID.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.TR_ID.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.TR_ID.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.TR_ID.US_Color_Enable = System.Drawing.Color.White
        Me.TR_ID.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.TR_ID.Us_dataBindings_TOP = 10
        Me.TR_ID.US_Enable = False
        Me.TR_ID.US_foreColor_Didable = System.Drawing.Color.White
        Me.TR_ID.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.TR_ID.US_Number = True
        Me.TR_ID.US_Tag2 = ""
        Me.TR_ID.US_value = Nothing
        Me.TR_ID.Visible = False
        '
        'Label_US2
        '
        Me.Label_US2.AutoSize = True
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Black
        Me.Label_US2.Location = New System.Drawing.Point(26, 130)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(84, 19)
        Me.Label_US2.TabIndex = 2
        Me.Label_US2.Text = "Uaer ID / ชื่อ"
        '
        'ACTIVEFLAG
        '
        Me.ACTIVEFLAG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACTIVEFLAG.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ACTIVEFLAG.FormattingEnabled = True
        Me.ACTIVEFLAG.Location = New System.Drawing.Point(113, 222)
        Me.ACTIVEFLAG.Name = "ACTIVEFLAG"
        Me.ACTIVEFLAG.Size = New System.Drawing.Size(377, 25)
        Me.ACTIVEFLAG.TabIndex = 8
        '
        'PERMIS_CODE
        '
        Me.PERMIS_CODE.BackColor = System.Drawing.Color.Gainsboro
        Me.PERMIS_CODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PERMIS_CODE.ForeColor = System.Drawing.Color.DarkGreen
        Me.PERMIS_CODE.Location = New System.Drawing.Point(113, 63)
        Me.PERMIS_CODE.MaxLength = 10
        Me.PERMIS_CODE.Name = "PERMIS_CODE"
        Me.PERMIS_CODE.ReadOnly = True
        Me.PERMIS_CODE.Size = New System.Drawing.Size(377, 25)
        Me.PERMIS_CODE.TabIndex = 1
        Me.PERMIS_CODE.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.PERMIS_CODE.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.PERMIS_CODE.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.PERMIS_CODE.US_Color_Enable = System.Drawing.Color.White
        Me.PERMIS_CODE.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.PERMIS_CODE.Us_dataBindings_TOP = 10
        Me.PERMIS_CODE.US_Enable = False
        Me.PERMIS_CODE.US_foreColor_Didable = System.Drawing.Color.White
        Me.PERMIS_CODE.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.PERMIS_CODE.US_Number = False
        Me.PERMIS_CODE.US_Tag2 = ""
        Me.PERMIS_CODE.US_value = Nothing
        '
        'Label_US5
        '
        Me.Label_US5.AutoSize = True
        Me.Label_US5.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US5.ForeColor = System.Drawing.Color.Black
        Me.Label_US5.Location = New System.Drawing.Point(26, 228)
        Me.Label_US5.Name = "Label_US5"
        Me.Label_US5.Size = New System.Drawing.Size(44, 19)
        Me.Label_US5.TabIndex = 9
        Me.Label_US5.Text = "สถานะ"
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
        Me.SplitContainer1.SplitterDistance = 364
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl_US1)
        Me.Panel2.Controls.Add(Me.ToolStrip_top)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 364)
        Me.Panel2.TabIndex = 10
        '
        'TabControl_US1
        '
        Me.TabControl_US1.Controls.Add(TabPage_Main)
        Me.TabControl_US1.Controls.Add(Me.TabPage2)
        Me.TabControl_US1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl_US1.Location = New System.Drawing.Point(0, 39)
        Me.TabControl_US1.Name = "TabControl_US1"
        Me.TabControl_US1.SelectedIndex = 0
        Me.TabControl_US1.Size = New System.Drawing.Size(1026, 325)
        Me.TabControl_US1.TabIndex = 28
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chk_selectall)
        Me.TabPage2.Controls.Add(Me.dgv_permiss)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(1018, 295)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "สิททธ์เมนู"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chk_selectall
        '
        Me.chk_selectall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_selectall.AutoSize = True
        Me.chk_selectall.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_selectall.Location = New System.Drawing.Point(923, 10)
        Me.chk_selectall.Name = "chk_selectall"
        Me.chk_selectall.Size = New System.Drawing.Size(92, 23)
        Me.chk_selectall.TabIndex = 3
        Me.chk_selectall.Text = "เลือกทั้งหมด"
        Me.chk_selectall.UseVisualStyleBackColor = True
        '
        'dgv_permiss
        '
        Me.dgv_permiss.AllowUserToAddRows = False
        Me.dgv_permiss.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_permiss.BackgroundColor = System.Drawing.Color.White
        Me.dgv_permiss.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_permiss.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_permiss.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_permiss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_permiss.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_permiss.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_permiss.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_permiss.EnableHeadersVisualStyles = False
        Me.dgv_permiss.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_permiss.Location = New System.Drawing.Point(3, 39)
        Me.dgv_permiss.Name = "dgv_permiss"
        Me.dgv_permiss.RowHeadersVisible = False
        Me.dgv_permiss.RowHeadersWidth = 51
        Me.dgv_permiss.RowTemplate.Height = 30
        Me.dgv_permiss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_permiss.Size = New System.Drawing.Size(1012, 252)
        Me.dgv_permiss.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 337
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 337
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Column3"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 337
        '
        'ToolStrip_top
        '
        Me.ToolStrip_top.AutoSize = False
        Me.ToolStrip_top.BackColor = System.Drawing.Color.White
        Me.ToolStrip_top.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip_top.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_new, Me.btn_Copy, Me.btn_edit, Me.btn_save, Me.btn_cancel_save, Me.btndelete, Me.btn_close})
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
        Me.Panel1.Size = New System.Drawing.Size(1026, 181)
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
        Me.dgv_scr.Size = New System.Drawing.Size(1026, 152)
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
        'Timer1
        '
        '
        'btn_Copy
        '
        Me.btn_Copy.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Copy.Image = CType(resources.GetObject("btn_Copy.Image"), System.Drawing.Image)
        Me.btn_Copy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Copy.Name = "btn_Copy"
        Me.btn_Copy.Size = New System.Drawing.Size(67, 36)
        Me.btn_Copy.Text = "คัดลอก"
        '
        'F_MAS_Permiss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 549)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "F_MAS_Permiss"
        Me.TabText = "หน่วยนับ"
        Me.Text = "หน่วยนับ"
        TabPage_Main.ResumeLayout(False)
        Me.Panel_US1.ResumeLayout(False)
        Me.Panel_US1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl_US1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_permiss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip_top.ResumeLayout(False)
        Me.ToolStrip_top.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents PERMIS_CODE As Control_us.Textbox_UC
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents REMARK As Control_us.Textbox_UC
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents DESCRIPTION As Control_us.Textbox_UC
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents Label_US5 As Control_us.Label_US
    Friend WithEvents ACTIVEFLAG As Control_us.Combobox_US
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_scr As ToolStripTextBox
    Friend WithEvents btn_scr As ToolStripButton
    Friend WithEvents dgv_scr As Control_us.DataGridView_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip_top As ToolStrip
    Friend WithEvents btn_new As ToolStripButton
    Friend WithEvents btn_edit As ToolStripButton
    Friend WithEvents btn_save As ToolStripButton
    Friend WithEvents btndelete As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Btn_Next As ToolStripButton
    Friend WithEvents txt_curpage As ToolStripTextBox
    Friend WithEvents Btn_last As ToolStripButton
    Friend WithEvents cbo_search As ToolStripComboBox
    Friend WithEvents TR_ID As Control_us.Textbox_UC
    Friend WithEvents btn_cancel_save As ToolStripButton
    Friend WithEvents UID As Control_us.Textbox_UC
    Friend WithEvents btn_clear_uid As Control_us.Button_US
    Friend WithEvents btn_scr_uid As Control_us.Button_US
    Friend WithEvents PERMIS_NAME As Control_us.Textbox_UC
    Friend WithEvents TabControl_US1 As Control_us.TabControl_US
    Friend WithEvents Panel_US1 As Control_us.Panel_US
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_permiss As Control_us.DataGridView_US
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents chk_selectall As Control_us.CheckBox1_US
    Friend WithEvents Label_US6 As Control_us.Label_US
    Friend WithEvents btn_Copy As ToolStripButton
End Class

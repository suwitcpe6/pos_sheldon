<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Setting
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Setting))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TabControl_US1 = New Control_us.TabControl_US()
        Me.TB_POSConfig = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_US1 = New Control_us.Label_US()
        Me.txt_api = New Control_us.Textbox_UC()
        Me.Button_US7 = New Control_us.Button_US()
        Me.Label_US28 = New Control_us.Label_US()
        Me.Label_US27 = New Control_us.Label_US()
        Me.Txt_paht_srv = New Control_us.Textbox_UC()
        Me.TB_structure = New System.Windows.Forms.TabPage()
        Me.Panel_US6 = New Control_us.Panel_US()
        Me.P_notsuccess = New Control_us.PictureBox_US()
        Me.p_successfull = New Control_us.PictureBox_US()
        Me.Label_US26 = New Control_us.Label_US()
        Me.Label_US25 = New Control_us.Label_US()
        Me.Label_US23 = New Control_us.Label_US()
        Me.Button_US1 = New Control_us.Button_US()
        Me.TB_systemconfig = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RB_prepaid = New Control_us.RadioButton_US()
        Me.RB_postpaid = New Control_us.RadioButton_US()
        Me.chk_usestock = New System.Windows.Forms.CheckBox()
        Me.Label_US29 = New Control_us.Label_US()
        Me.Label_US33 = New Control_us.Label_US()
        Me.GroupBox_US2 = New Control_us.GroupBox_US()
        Me.Label_US36 = New Control_us.Label_US()
        Me.Label_US32 = New Control_us.Label_US()
        Me.cbo_WALLET_TYPE = New Control_us.Combobox_US()
        Me.Label_US35 = New Control_us.Label_US()
        Me.Label_US30 = New Control_us.Label_US()
        Me.cbo_vender = New Control_us.Combobox_US()
        Me.Combobox_US2 = New Control_us.Combobox_US()
        Me.cbo_CONN_LINK = New Control_us.Combobox_US()
        Me.Label_US31 = New Control_us.Label_US()
        Me.Label_US34 = New Control_us.Label_US()
        Me.cbo_CUSGROUP = New Control_us.Combobox_US()
        Me.Panel_US8 = New Control_us.Panel_US()
        Me.btn_cancel = New Control_us.Button_US()
        Me.btn_test_conn = New Control_us.Button_US()
        Me.btn_save_config = New Control_us.Button_US()
        Me.Panel_US9 = New Control_us.Panel_US()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl_US1.SuspendLayout()
        Me.TB_POSConfig.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TB_structure.SuspendLayout()
        Me.Panel_US6.SuspendLayout()
        CType(Me.P_notsuccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_successfull, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB_systemconfig.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox_US2.SuspendLayout()
        Me.Panel_US8.SuspendLayout()
        Me.Panel_US9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_US1
        '
        Me.TabControl_US1.Controls.Add(Me.TB_POSConfig)
        Me.TabControl_US1.Controls.Add(Me.TB_structure)
        Me.TabControl_US1.Controls.Add(Me.TB_systemconfig)
        Me.TabControl_US1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl_US1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_US1.Name = "TabControl_US1"
        Me.TabControl_US1.SelectedIndex = 0
        Me.TabControl_US1.Size = New System.Drawing.Size(870, 434)
        Me.TabControl_US1.TabIndex = 35
        '
        'TB_POSConfig
        '
        Me.TB_POSConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_POSConfig.Controls.Add(Me.Panel1)
        Me.TB_POSConfig.Location = New System.Drawing.Point(4, 32)
        Me.TB_POSConfig.Name = "TB_POSConfig"
        Me.TB_POSConfig.Padding = New System.Windows.Forms.Padding(3)
        Me.TB_POSConfig.Size = New System.Drawing.Size(862, 398)
        Me.TB_POSConfig.TabIndex = 0
        Me.TB_POSConfig.Text = "ตั้งค่า Client"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_US1)
        Me.Panel1.Controls.Add(Me.txt_api)
        Me.Panel1.Controls.Add(Me.Button_US7)
        Me.Panel1.Controls.Add(Me.Label_US28)
        Me.Panel1.Controls.Add(Me.Label_US27)
        Me.Panel1.Controls.Add(Me.Txt_paht_srv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 392)
        Me.Panel1.TabIndex = 36
        '
        'Label_US1
        '
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US1.Location = New System.Drawing.Point(38, 28)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(91, 23)
        Me.Label_US1.TabIndex = 51
        Me.Label_US1.Text = "Server API :"
        '
        'txt_api
        '
        Me.txt_api.BackColor = System.Drawing.Color.White
        Me.txt_api.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_api.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_api.Location = New System.Drawing.Point(43, 66)
        Me.txt_api.Name = "txt_api"
        Me.txt_api.Size = New System.Drawing.Size(674, 34)
        Me.txt_api.TabIndex = 50
        Me.txt_api.Text = "https://localhost:44389/"
        Me.txt_api.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_api.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_api.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.txt_api.US_Color_Enable = System.Drawing.Color.White
        Me.txt_api.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_api.Us_dataBindings_TOP = 10
        Me.txt_api.US_Enable = True
        Me.txt_api.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_api.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_api.US_Number = False
        Me.txt_api.US_Tag2 = ""
        Me.txt_api.US_value = Nothing
        '
        'Button_US7
        '
        Me.Button_US7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_US7.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_US7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US7.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US7.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US7.Image = CType(resources.GetObject("Button_US7.Image"), System.Drawing.Image)
        Me.Button_US7.Location = New System.Drawing.Point(723, 136)
        Me.Button_US7.Name = "Button_US7"
        Me.Button_US7.Size = New System.Drawing.Size(123, 72)
        Me.Button_US7.TabIndex = 49
        Me.Button_US7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button_US7.UseVisualStyleBackColor = False
        Me.Button_US7.Visible = False
        '
        'Label_US28
        '
        Me.Label_US28.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US28.ForeColor = System.Drawing.Color.Red
        Me.Label_US28.Location = New System.Drawing.Point(38, 217)
        Me.Label_US28.Name = "Label_US28"
        Me.Label_US28.Size = New System.Drawing.Size(566, 158)
        Me.Label_US28.TabIndex = 48
        Me.Label_US28.Text = resources.GetString("Label_US28.Text")
        Me.Label_US28.Visible = False
        '
        'Label_US27
        '
        Me.Label_US27.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_US27.Location = New System.Drawing.Point(108, 98)
        Me.Label_US27.Name = "Label_US27"
        Me.Label_US27.Size = New System.Drawing.Size(116, 35)
        Me.Label_US27.TabIndex = 47
        Me.Label_US27.Text = "Source File :"
        Me.Label_US27.Visible = False
        '
        'Txt_paht_srv
        '
        Me.Txt_paht_srv.BackColor = System.Drawing.Color.White
        Me.Txt_paht_srv.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_paht_srv.ForeColor = System.Drawing.Color.DarkGreen
        Me.Txt_paht_srv.Location = New System.Drawing.Point(43, 136)
        Me.Txt_paht_srv.Multiline = True
        Me.Txt_paht_srv.Name = "Txt_paht_srv"
        Me.Txt_paht_srv.Size = New System.Drawing.Size(674, 78)
        Me.Txt_paht_srv.TabIndex = 46
        Me.Txt_paht_srv.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.Txt_paht_srv.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.Txt_paht_srv.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.Txt_paht_srv.US_Color_Enable = System.Drawing.Color.White
        Me.Txt_paht_srv.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.Txt_paht_srv.Us_dataBindings_TOP = 10
        Me.Txt_paht_srv.US_Enable = True
        Me.Txt_paht_srv.US_foreColor_Didable = System.Drawing.Color.White
        Me.Txt_paht_srv.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.Txt_paht_srv.US_Number = False
        Me.Txt_paht_srv.US_Tag2 = ""
        Me.Txt_paht_srv.US_value = Nothing
        Me.Txt_paht_srv.Visible = False
        '
        'TB_structure
        '
        Me.TB_structure.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_structure.Controls.Add(Me.Panel_US6)
        Me.TB_structure.Location = New System.Drawing.Point(4, 32)
        Me.TB_structure.Name = "TB_structure"
        Me.TB_structure.Padding = New System.Windows.Forms.Padding(3)
        Me.TB_structure.Size = New System.Drawing.Size(862, 398)
        Me.TB_structure.TabIndex = 1
        Me.TB_structure.Text = "อัพทเดทฐานข้อมูล"
        '
        'Panel_US6
        '
        Me.Panel_US6.Controls.Add(Me.P_notsuccess)
        Me.Panel_US6.Controls.Add(Me.p_successfull)
        Me.Panel_US6.Controls.Add(Me.Label_US26)
        Me.Panel_US6.Controls.Add(Me.Label_US25)
        Me.Panel_US6.Controls.Add(Me.Label_US23)
        Me.Panel_US6.Controls.Add(Me.Button_US1)
        Me.Panel_US6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US6.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US6.Location = New System.Drawing.Point(3, 3)
        Me.Panel_US6.Name = "Panel_US6"
        Me.Panel_US6.Size = New System.Drawing.Size(856, 392)
        Me.Panel_US6.TabIndex = 0
        '
        'P_notsuccess
        '
        Me.P_notsuccess.BackColor = System.Drawing.Color.White
        Me.P_notsuccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.P_notsuccess.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.P_notsuccess.Image = CType(resources.GetObject("P_notsuccess.Image"), System.Drawing.Image)
        Me.P_notsuccess.Location = New System.Drawing.Point(286, 243)
        Me.P_notsuccess.Name = "P_notsuccess"
        Me.P_notsuccess.Size = New System.Drawing.Size(78, 64)
        Me.P_notsuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P_notsuccess.TabIndex = 36
        Me.P_notsuccess.TabStop = False
        Me.P_notsuccess.Visible = False
        '
        'p_successfull
        '
        Me.p_successfull.BackColor = System.Drawing.Color.White
        Me.p_successfull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.p_successfull.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.p_successfull.Image = CType(resources.GetObject("p_successfull.Image"), System.Drawing.Image)
        Me.p_successfull.Location = New System.Drawing.Point(286, 243)
        Me.p_successfull.Name = "p_successfull"
        Me.p_successfull.Size = New System.Drawing.Size(78, 64)
        Me.p_successfull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_successfull.TabIndex = 35
        Me.p_successfull.TabStop = False
        Me.p_successfull.Visible = False
        '
        'Label_US26
        '
        Me.Label_US26.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US26.ForeColor = System.Drawing.Color.Blue
        Me.Label_US26.Location = New System.Drawing.Point(26, 18)
        Me.Label_US26.Name = "Label_US26"
        Me.Label_US26.Size = New System.Drawing.Size(657, 103)
        Me.Label_US26.TabIndex = 34
        Me.Label_US26.Text = resources.GetString("Label_US26.Text")
        '
        'Label_US25
        '
        Me.Label_US25.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US25.ForeColor = System.Drawing.Color.Red
        Me.Label_US25.Location = New System.Drawing.Point(5, 310)
        Me.Label_US25.Name = "Label_US25"
        Me.Label_US25.Size = New System.Drawing.Size(846, 79)
        Me.Label_US25.TabIndex = 33
        Me.Label_US25.Text = "คำเตื่อน :: การอัพเดทฐานข้อมูลจะทำให้โครงสร้างทั้งหมดเปลี่ยนไปตามรูปแบบที่โปรแกรม" &
    "กำหนด ควรปรึกษาทีมงานก่อนทำการอัพเดท " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              ถ้าไม่มั่นใจควร Backup ฐานข" &
    "้อมูลไว้ก่อน"
        '
        'Label_US23
        '
        Me.Label_US23.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US23.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US23.Location = New System.Drawing.Point(131, 208)
        Me.Label_US23.Name = "Label_US23"
        Me.Label_US23.Size = New System.Drawing.Size(388, 23)
        Me.Label_US23.TabIndex = 32
        Me.Label_US23.Text = "..."
        Me.Label_US23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_US1
        '
        Me.Button_US1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_US1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_US1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US1.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US1.Image = CType(resources.GetObject("Button_US1.Image"), System.Drawing.Image)
        Me.Button_US1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_US1.Location = New System.Drawing.Point(126, 124)
        Me.Button_US1.Name = "Button_US1"
        Me.Button_US1.Size = New System.Drawing.Size(410, 81)
        Me.Button_US1.TabIndex = 31
        Me.Button_US1.Text = "Update Database"
        Me.Button_US1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_US1.UseVisualStyleBackColor = False
        '
        'TB_systemconfig
        '
        Me.TB_systemconfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_systemconfig.Controls.Add(Me.GroupBox1)
        Me.TB_systemconfig.Controls.Add(Me.chk_usestock)
        Me.TB_systemconfig.Controls.Add(Me.Label_US29)
        Me.TB_systemconfig.Controls.Add(Me.Label_US33)
        Me.TB_systemconfig.Controls.Add(Me.GroupBox_US2)
        Me.TB_systemconfig.Controls.Add(Me.cbo_CUSGROUP)
        Me.TB_systemconfig.Location = New System.Drawing.Point(4, 32)
        Me.TB_systemconfig.Name = "TB_systemconfig"
        Me.TB_systemconfig.Padding = New System.Windows.Forms.Padding(3)
        Me.TB_systemconfig.Size = New System.Drawing.Size(862, 398)
        Me.TB_systemconfig.TabIndex = 3
        Me.TB_systemconfig.Text = "ตั้งค่าทั้งระบบ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_prepaid)
        Me.GroupBox1.Controls.Add(Me.RB_postpaid)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(6, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(839, 98)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทระบบ"
        '
        'RB_prepaid
        '
        Me.RB_prepaid.AutoSize = True
        Me.RB_prepaid.Checked = True
        Me.RB_prepaid.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RB_prepaid.ForeColor = System.Drawing.Color.Red
        Me.RB_prepaid.Location = New System.Drawing.Point(39, 24)
        Me.RB_prepaid.Name = "RB_prepaid"
        Me.RB_prepaid.Size = New System.Drawing.Size(150, 27)
        Me.RB_prepaid.TabIndex = 29
        Me.RB_prepaid.TabStop = True
        Me.RB_prepaid.Tag = "prepaid"
        Me.RB_prepaid.Text = "prepaid (ขายสด)"
        Me.RB_prepaid.UseVisualStyleBackColor = True
        '
        'RB_postpaid
        '
        Me.RB_postpaid.AutoSize = True
        Me.RB_postpaid.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RB_postpaid.ForeColor = System.Drawing.Color.Red
        Me.RB_postpaid.Location = New System.Drawing.Point(39, 54)
        Me.RB_postpaid.Name = "RB_postpaid"
        Me.RB_postpaid.Size = New System.Drawing.Size(186, 27)
        Me.RB_postpaid.TabIndex = 30
        Me.RB_postpaid.Tag = "postpaid"
        Me.RB_postpaid.Text = "postpaid  (ขายเครดิต)"
        Me.RB_postpaid.UseVisualStyleBackColor = True
        '
        'chk_usestock
        '
        Me.chk_usestock.AutoSize = True
        Me.chk_usestock.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.chk_usestock.Location = New System.Drawing.Point(623, 48)
        Me.chk_usestock.Name = "chk_usestock"
        Me.chk_usestock.Size = New System.Drawing.Size(145, 27)
        Me.chk_usestock.TabIndex = 29
        Me.chk_usestock.Text = "ใช้งานระบบสต๊อก"
        Me.chk_usestock.UseVisualStyleBackColor = True
        '
        'Label_US29
        '
        Me.Label_US29.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US29.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label_US29.Location = New System.Drawing.Point(34, 3)
        Me.Label_US29.Name = "Label_US29"
        Me.Label_US29.Size = New System.Drawing.Size(832, 29)
        Me.Label_US29.TabIndex = 30
        Me.Label_US29.Text = "หมายเหตุ  :  การตั้งค่านี้จะเปลี่ยนแปลงทั้งระบบ"
        '
        'Label_US33
        '
        Me.Label_US33.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US33.ForeColor = System.Drawing.Color.Green
        Me.Label_US33.Location = New System.Drawing.Point(27, 47)
        Me.Label_US33.Name = "Label_US33"
        Me.Label_US33.Size = New System.Drawing.Size(124, 29)
        Me.Label_US33.TabIndex = 17
        Me.Label_US33.Text = "กลุ่มลูกค้า  :"
        '
        'GroupBox_US2
        '
        Me.GroupBox_US2.Controls.Add(Me.Label_US36)
        Me.GroupBox_US2.Controls.Add(Me.Label_US32)
        Me.GroupBox_US2.Controls.Add(Me.cbo_WALLET_TYPE)
        Me.GroupBox_US2.Controls.Add(Me.Label_US35)
        Me.GroupBox_US2.Controls.Add(Me.Label_US30)
        Me.GroupBox_US2.Controls.Add(Me.cbo_vender)
        Me.GroupBox_US2.Controls.Add(Me.Combobox_US2)
        Me.GroupBox_US2.Controls.Add(Me.cbo_CONN_LINK)
        Me.GroupBox_US2.Controls.Add(Me.Label_US31)
        Me.GroupBox_US2.Controls.Add(Me.Label_US34)
        Me.GroupBox_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox_US2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox_US2.Location = New System.Drawing.Point(6, 82)
        Me.GroupBox_US2.Name = "GroupBox_US2"
        Me.GroupBox_US2.Size = New System.Drawing.Size(843, 132)
        Me.GroupBox_US2.TabIndex = 26
        Me.GroupBox_US2.TabStop = False
        Me.GroupBox_US2.Text = "Wallet Config"
        '
        'Label_US36
        '
        Me.Label_US36.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US36.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label_US36.Location = New System.Drawing.Point(28, 97)
        Me.Label_US36.Name = "Label_US36"
        Me.Label_US36.Size = New System.Drawing.Size(124, 29)
        Me.Label_US36.TabIndex = 23
        Me.Label_US36.Text = "Vendor  :"
        '
        'Label_US32
        '
        Me.Label_US32.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US32.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US32.Location = New System.Drawing.Point(28, 97)
        Me.Label_US32.Name = "Label_US32"
        Me.Label_US32.Size = New System.Drawing.Size(124, 29)
        Me.Label_US32.TabIndex = 23
        Me.Label_US32.Text = "Vendor  :"
        '
        'cbo_WALLET_TYPE
        '
        Me.cbo_WALLET_TYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.cbo_WALLET_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_WALLET_TYPE.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_WALLET_TYPE.FormattingEnabled = True
        Me.cbo_WALLET_TYPE.Items.AddRange(New Object() {"EDC", "API"})
        Me.cbo_WALLET_TYPE.Location = New System.Drawing.Point(172, 24)
        Me.cbo_WALLET_TYPE.Name = "cbo_WALLET_TYPE"
        Me.cbo_WALLET_TYPE.Size = New System.Drawing.Size(425, 29)
        Me.cbo_WALLET_TYPE.TabIndex = 20
        '
        'Label_US35
        '
        Me.Label_US35.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US35.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label_US35.Location = New System.Drawing.Point(28, 62)
        Me.Label_US35.Name = "Label_US35"
        Me.Label_US35.Size = New System.Drawing.Size(124, 29)
        Me.Label_US35.TabIndex = 21
        Me.Label_US35.Text = "การเชื่อมต่อ  :"
        '
        'Label_US30
        '
        Me.Label_US30.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US30.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label_US30.Location = New System.Drawing.Point(28, 27)
        Me.Label_US30.Name = "Label_US30"
        Me.Label_US30.Size = New System.Drawing.Size(124, 29)
        Me.Label_US30.TabIndex = 19
        Me.Label_US30.Text = "ประเภท Gatway  :"
        '
        'cbo_vender
        '
        Me.cbo_vender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.cbo_vender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_vender.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_vender.FormattingEnabled = True
        Me.cbo_vender.Items.AddRange(New Object() {"GHL"})
        Me.cbo_vender.Location = New System.Drawing.Point(172, 94)
        Me.cbo_vender.Name = "cbo_vender"
        Me.cbo_vender.Size = New System.Drawing.Size(425, 29)
        Me.cbo_vender.TabIndex = 24
        '
        'Combobox_US2
        '
        Me.Combobox_US2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Combobox_US2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Combobox_US2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Combobox_US2.FormattingEnabled = True
        Me.Combobox_US2.Items.AddRange(New Object() {"EDC", "API"})
        Me.Combobox_US2.Location = New System.Drawing.Point(172, 24)
        Me.Combobox_US2.Name = "Combobox_US2"
        Me.Combobox_US2.Size = New System.Drawing.Size(425, 36)
        Me.Combobox_US2.TabIndex = 20
        Me.Combobox_US2.Text = "เลือก"
        '
        'cbo_CONN_LINK
        '
        Me.cbo_CONN_LINK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.cbo_CONN_LINK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_CONN_LINK.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_CONN_LINK.FormattingEnabled = True
        Me.cbo_CONN_LINK.Items.AddRange(New Object() {"WIFI", "BLUETOOTH"})
        Me.cbo_CONN_LINK.Location = New System.Drawing.Point(172, 59)
        Me.cbo_CONN_LINK.Name = "cbo_CONN_LINK"
        Me.cbo_CONN_LINK.Size = New System.Drawing.Size(425, 29)
        Me.cbo_CONN_LINK.TabIndex = 22
        '
        'Label_US31
        '
        Me.Label_US31.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US31.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US31.Location = New System.Drawing.Point(28, 62)
        Me.Label_US31.Name = "Label_US31"
        Me.Label_US31.Size = New System.Drawing.Size(124, 29)
        Me.Label_US31.TabIndex = 21
        Me.Label_US31.Text = "การเชื่อมต่อ  :"
        '
        'Label_US34
        '
        Me.Label_US34.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US34.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US34.Location = New System.Drawing.Point(28, 27)
        Me.Label_US34.Name = "Label_US34"
        Me.Label_US34.Size = New System.Drawing.Size(124, 29)
        Me.Label_US34.TabIndex = 19
        Me.Label_US34.Text = "ประเภท Gatway  :"
        '
        'cbo_CUSGROUP
        '
        Me.cbo_CUSGROUP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.cbo_CUSGROUP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_CUSGROUP.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_CUSGROUP.FormattingEnabled = True
        Me.cbo_CUSGROUP.Items.AddRange(New Object() {"CPN", "HOMEPRO", "TOP", "OTHER"})
        Me.cbo_CUSGROUP.Location = New System.Drawing.Point(178, 47)
        Me.cbo_CUSGROUP.Name = "cbo_CUSGROUP"
        Me.cbo_CUSGROUP.Size = New System.Drawing.Size(425, 29)
        Me.cbo_CUSGROUP.TabIndex = 18
        '
        'Panel_US8
        '
        Me.Panel_US8.Controls.Add(Me.btn_cancel)
        Me.Panel_US8.Controls.Add(Me.btn_test_conn)
        Me.Panel_US8.Controls.Add(Me.btn_save_config)
        Me.Panel_US8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_US8.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US8.Location = New System.Drawing.Point(0, 434)
        Me.Panel_US8.Name = "Panel_US8"
        Me.Panel_US8.Size = New System.Drawing.Size(870, 88)
        Me.Panel_US8.TabIndex = 35
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.DimGray
        Me.btn_cancel.Image = Global.Blackoffice.My.Resources.Resources.out50x50
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancel.Location = New System.Drawing.Point(742, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(111, 81)
        Me.btn_cancel.TabIndex = 31
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_test_conn
        '
        Me.btn_test_conn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_test_conn.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_test_conn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_test_conn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_test_conn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_test_conn.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_test_conn.ForeColor = System.Drawing.Color.DimGray
        Me.btn_test_conn.Image = Global.Blackoffice.My.Resources.Resources.Test50x50
        Me.btn_test_conn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_test_conn.Location = New System.Drawing.Point(418, 2)
        Me.btn_test_conn.Name = "btn_test_conn"
        Me.btn_test_conn.Size = New System.Drawing.Size(141, 81)
        Me.btn_test_conn.TabIndex = 29
        Me.btn_test_conn.Text = "Test Config"
        Me.btn_test_conn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_test_conn.UseVisualStyleBackColor = False
        '
        'btn_save_config
        '
        Me.btn_save_config.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save_config.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save_config.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_save_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_save_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save_config.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save_config.ForeColor = System.Drawing.Color.DimGray
        Me.btn_save_config.Image = Global.Blackoffice.My.Resources.Resources.Save_Settings50x50
        Me.btn_save_config.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_save_config.Location = New System.Drawing.Point(575, 4)
        Me.btn_save_config.Name = "btn_save_config"
        Me.btn_save_config.Size = New System.Drawing.Size(141, 81)
        Me.btn_save_config.TabIndex = 30
        Me.btn_save_config.Text = "Save Config"
        Me.btn_save_config.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_save_config.UseVisualStyleBackColor = False
        '
        'Panel_US9
        '
        Me.Panel_US9.Controls.Add(Me.TabControl_US1)
        Me.Panel_US9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US9.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US9.Location = New System.Drawing.Point(0, 0)
        Me.Panel_US9.Name = "Panel_US9"
        Me.Panel_US9.Size = New System.Drawing.Size(870, 434)
        Me.Panel_US9.TabIndex = 35
        '
        'F_Setting
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 522)
        Me.Controls.Add(Me.Panel_US9)
        Me.Controls.Add(Me.Panel_US8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Setting"
        Me.TabControl_US1.ResumeLayout(False)
        Me.TB_POSConfig.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TB_structure.ResumeLayout(False)
        Me.Panel_US6.ResumeLayout(False)
        CType(Me.P_notsuccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_successfull, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TB_systemconfig.ResumeLayout(False)
        Me.TB_systemconfig.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox_US2.ResumeLayout(False)
        Me.Panel_US8.ResumeLayout(False)
        Me.Panel_US9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_test_conn As Control_us.Button_US
    Friend WithEvents btn_save_config As Control_us.Button_US
    Friend WithEvents btn_cancel As Control_us.Button_US
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TabControl_US1 As Control_us.TabControl_US
    Friend WithEvents TB_POSConfig As TabPage
    Friend WithEvents TB_structure As TabPage
    Friend WithEvents Panel_US6 As Control_us.Panel_US
    Friend WithEvents Button_US1 As Control_us.Button_US
    Friend WithEvents Label_US23 As Control_us.Label_US
    Friend WithEvents Label_US25 As Control_us.Label_US
    Friend WithEvents Label_US26 As Control_us.Label_US
    Friend WithEvents p_successfull As Control_us.PictureBox_US
    Friend WithEvents P_notsuccess As Control_us.PictureBox_US
    Friend WithEvents Panel_US8 As Control_us.Panel_US
    Friend WithEvents Panel_US9 As Control_us.Panel_US
    Friend WithEvents TB_systemconfig As TabPage
    Friend WithEvents cbo_CUSGROUP As Control_us.Combobox_US
    Friend WithEvents Label_US32 As Control_us.Label_US
    Friend WithEvents Label_US31 As Control_us.Label_US
    Friend WithEvents Label_US30 As Control_us.Label_US
    Friend WithEvents cbo_WALLET_TYPE As Control_us.Combobox_US
    Friend WithEvents GroupBox_US2 As Control_us.GroupBox_US
    Friend WithEvents Label_US33 As Control_us.Label_US
    Friend WithEvents Label_US36 As Control_us.Label_US
    Friend WithEvents Label_US35 As Control_us.Label_US
    Friend WithEvents Combobox_US2 As Control_us.Combobox_US
    Friend WithEvents Label_US34 As Control_us.Label_US
    Friend WithEvents cbo_vender As Control_us.Combobox_US
    Friend WithEvents cbo_CONN_LINK As Control_us.Combobox_US
    Friend WithEvents chk_usestock As CheckBox
    Friend WithEvents Label_US29 As Control_us.Label_US
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RB_prepaid As Control_us.RadioButton_US
    Friend WithEvents RB_postpaid As Control_us.RadioButton_US
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents txt_api As Control_us.Textbox_UC
    Friend WithEvents Button_US7 As Control_us.Button_US
    Friend WithEvents Label_US28 As Control_us.Label_US
    Friend WithEvents Label_US27 As Control_us.Label_US
    Friend WithEvents Txt_paht_srv As Control_us.Textbox_UC
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class

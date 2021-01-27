<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_payment
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_payment))
        Me.tab_payment = New Control_us.TabControl_US()
        Me.TNormal = New System.Windows.Forms.TabPage()
        Me.txt_amount_remain = New Control_us.Textbox_UC()
        Me.Label_US5 = New Control_us.Label_US()
        Me.txt_Amount = New Control_us.Textbox_UC()
        Me.Label_US4 = New Control_us.Label_US()
        Me.Label_US3 = New Control_us.Label_US()
        Me.txt_pay_Amount = New Control_us.Textbox_UC()
        Me.DGV_Card_Normal = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.C_TO_B = New System.Windows.Forms.TabPage()
        Me.txt_C_TO_B_payment_code = New Control_us.Textbox_UC()
        Me.Label_US8 = New Control_us.Label_US()
        Me.txt_QrthaiAmount = New Control_us.Textbox_UC()
        Me.Label_US6 = New Control_us.Label_US()
        Me.btn_REQUEST_QR_CODE = New Control_us.Button_US()
        Me.pbox_qtcode = New Control_us.PictureBox_US()
        Me.B_TO_C = New System.Windows.Forms.TabPage()
        Me.RT_display = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_US9 = New Control_us.Label_US()
        Me.Label_US7 = New Control_us.Label_US()
        Me.txt_B_TO_C_payment_code = New Control_us.Textbox_UC()
        Me.cur_docno = New Control_us.Textbox_UC()
        Me.lbl_confirm = New System.Windows.Forms.Label()
        Me.txt_PAYTYPE = New Control_us.Textbox_UC()
        Me.Label_US13 = New Control_us.Label_US()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_Inquiry = New Control_us.Button_US()
        Me.btn_Verify_slip = New Control_us.Button_US()
        Me.btn_cancel = New Control_us.Button_US()
        Me.Label_US10 = New Control_us.Label_US()
        Me.txt_TrueAmount = New Control_us.Textbox_UC()
        Me.Label_US2 = New Control_us.Label_US()
        Me.T_Waitpament = New System.Windows.Forms.TabPage()
        Me.Label_US12 = New Control_us.Label_US()
        Me.PictureBox_US1 = New Control_us.PictureBox_US()
        Me.txt_barcode_Normal = New Control_us.Textbox_UC()
        Me.Panel_US1 = New Control_us.Panel_US()
        Me.Panel_US2 = New Control_us.Panel_US()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.fl_cardtype_api = New Control_us.FlowLayoutPanel_US()
        Me.btn_narmal = New Control_us.Button_US()
        Me.btn_TMW = New Control_us.Button_US()
        Me.btn_TMW_EDC = New Control_us.Button_US()
        Me.btn_QYthai = New Control_us.Button_US()
        Me.btn_Alipay = New Control_us.Button_US()
        Me.btn_Wechat = New Control_us.Button_US()
        Me.btn_Dolfin = New Control_us.Button_US()
        Me.btn_rabbit = New Control_us.Button_US()
        Me.btn_LINEPAY = New Control_us.Button_US()
        Me.Btn_QRCS = New Control_us.Button_US()
        Me.fl_paymenthub_cpn = New Control_us.FlowLayoutPanel_US()
        Me.Button_US1 = New Control_us.Button_US()
        Me.Label_US11 = New Control_us.Label_US()
        Me.Panel_US3 = New Control_us.Panel_US()
        Me.btn_del = New Control_us.Button_US()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn_close = New Control_us.Button_US()
        Me.btn_ok = New Control_us.Button_US()
        Me.btn_cancell = New Control_us.Button_US()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.p_icon = New System.Windows.Forms.PictureBox()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tm_request = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Timer_blink = New System.Windows.Forms.Timer(Me.components)
        Me.tab_payment.SuspendLayout()
        Me.TNormal.SuspendLayout()
        CType(Me.DGV_Card_Normal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C_TO_B.SuspendLayout()
        CType(Me.pbox_qtcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.B_TO_C.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.T_Waitpament.SuspendLayout()
        CType(Me.PictureBox_US1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_US1.SuspendLayout()
        Me.Panel_US2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.fl_cardtype_api.SuspendLayout()
        Me.fl_paymenthub_cpn.SuspendLayout()
        Me.Panel_US3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_payment
        '
        Me.tab_payment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_payment.Controls.Add(Me.TNormal)
        Me.tab_payment.Controls.Add(Me.C_TO_B)
        Me.tab_payment.Controls.Add(Me.B_TO_C)
        Me.tab_payment.Controls.Add(Me.T_Waitpament)
        Me.tab_payment.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tab_payment.Location = New System.Drawing.Point(3, 191)
        Me.tab_payment.Name = "tab_payment"
        Me.tab_payment.SelectedIndex = 0
        Me.tab_payment.Size = New System.Drawing.Size(987, 395)
        Me.tab_payment.TabIndex = 0
        '
        'TNormal
        '
        Me.TNormal.BackColor = System.Drawing.Color.AliceBlue
        Me.TNormal.Controls.Add(Me.txt_amount_remain)
        Me.TNormal.Controls.Add(Me.Label_US5)
        Me.TNormal.Controls.Add(Me.txt_Amount)
        Me.TNormal.Controls.Add(Me.Label_US4)
        Me.TNormal.Controls.Add(Me.Label_US3)
        Me.TNormal.Controls.Add(Me.txt_pay_Amount)
        Me.TNormal.Controls.Add(Me.DGV_Card_Normal)
        Me.TNormal.Location = New System.Drawing.Point(4, 34)
        Me.TNormal.Name = "TNormal"
        Me.TNormal.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TNormal.Size = New System.Drawing.Size(979, 357)
        Me.TNormal.TabIndex = 0
        Me.TNormal.Text = "Normal"
        '
        'txt_amount_remain
        '
        Me.txt_amount_remain.BackColor = System.Drawing.Color.DimGray
        Me.txt_amount_remain.Font = New System.Drawing.Font("Leelawadee UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_amount_remain.ForeColor = System.Drawing.Color.Transparent
        Me.txt_amount_remain.Location = New System.Drawing.Point(520, 53)
        Me.txt_amount_remain.Name = "txt_amount_remain"
        Me.txt_amount_remain.ReadOnly = True
        Me.txt_amount_remain.Size = New System.Drawing.Size(223, 54)
        Me.txt_amount_remain.TabIndex = 49
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
        'Label_US5
        '
        Me.Label_US5.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US5.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US5.Location = New System.Drawing.Point(515, 12)
        Me.Label_US5.Name = "Label_US5"
        Me.Label_US5.Size = New System.Drawing.Size(228, 31)
        Me.Label_US5.TabIndex = 48
        Me.Label_US5.Text = "ยอดที่ค้างจ่าย"
        '
        'txt_Amount
        '
        Me.txt_Amount.BackColor = System.Drawing.Color.DimGray
        Me.txt_Amount.Font = New System.Drawing.Font("Leelawadee UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Amount.ForeColor = System.Drawing.Color.White
        Me.txt_Amount.Location = New System.Drawing.Point(27, 53)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.ReadOnly = True
        Me.txt_Amount.Size = New System.Drawing.Size(196, 57)
        Me.txt_Amount.TabIndex = 44
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
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US4.Location = New System.Drawing.Point(254, 18)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(173, 32)
        Me.Label_US4.TabIndex = 47
        Me.Label_US4.Text = "ยอดจ่ายบัตรแล้ว"
        '
        'Label_US3
        '
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US3.Location = New System.Drawing.Point(23, 20)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(178, 30)
        Me.Label_US3.TabIndex = 45
        Me.Label_US3.Text = "ยอดสุทธิ"
        '
        'txt_pay_Amount
        '
        Me.txt_pay_Amount.BackColor = System.Drawing.Color.DimGray
        Me.txt_pay_Amount.Font = New System.Drawing.Font("Leelawadee UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_pay_Amount.ForeColor = System.Drawing.Color.White
        Me.txt_pay_Amount.Location = New System.Drawing.Point(259, 53)
        Me.txt_pay_Amount.Name = "txt_pay_Amount"
        Me.txt_pay_Amount.ReadOnly = True
        Me.txt_pay_Amount.Size = New System.Drawing.Size(195, 57)
        Me.txt_pay_Amount.TabIndex = 46
        Me.txt_pay_Amount.Text = "0"
        Me.txt_pay_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_pay_Amount.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_pay_Amount.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_pay_Amount.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_pay_Amount.US_Color_Enable = System.Drawing.Color.White
        Me.txt_pay_Amount.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_pay_Amount.Us_dataBindings_TOP = 10
        Me.txt_pay_Amount.US_Enable = False
        Me.txt_pay_Amount.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_pay_Amount.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_pay_Amount.US_Number = True
        Me.txt_pay_Amount.US_Tag2 = ""
        Me.txt_pay_Amount.US_value = Nothing
        '
        'DGV_Card_Normal
        '
        Me.DGV_Card_Normal.AllowUserToAddRows = False
        Me.DGV_Card_Normal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Card_Normal.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Card_Normal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Card_Normal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_Card_Normal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Card_Normal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Card_Normal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.delete})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Card_Normal.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Card_Normal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_Card_Normal.EnableHeadersVisualStyles = False
        Me.DGV_Card_Normal.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Card_Normal.Location = New System.Drawing.Point(3, 123)
        Me.DGV_Card_Normal.Name = "DGV_Card_Normal"
        Me.DGV_Card_Normal.RowHeadersVisible = False
        Me.DGV_Card_Normal.RowHeadersWidth = 51
        Me.DGV_Card_Normal.RowTemplate.Height = 30
        Me.DGV_Card_Normal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Card_Normal.Size = New System.Drawing.Size(969, 241)
        Me.DGV_Card_Normal.TabIndex = 43
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
        'delete
        '
        Me.delete.HeaderText = "ลบ"
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.delete.MinimumWidth = 6
        Me.delete.Name = "delete"
        Me.delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.delete.Width = 125
        '
        'C_TO_B
        '
        Me.C_TO_B.BackColor = System.Drawing.Color.AliceBlue
        Me.C_TO_B.Controls.Add(Me.txt_C_TO_B_payment_code)
        Me.C_TO_B.Controls.Add(Me.Label_US8)
        Me.C_TO_B.Controls.Add(Me.txt_QrthaiAmount)
        Me.C_TO_B.Controls.Add(Me.Label_US6)
        Me.C_TO_B.Controls.Add(Me.btn_REQUEST_QR_CODE)
        Me.C_TO_B.Controls.Add(Me.pbox_qtcode)
        Me.C_TO_B.Location = New System.Drawing.Point(4, 34)
        Me.C_TO_B.Name = "C_TO_B"
        Me.C_TO_B.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.C_TO_B.Size = New System.Drawing.Size(978, 357)
        Me.C_TO_B.TabIndex = 1
        Me.C_TO_B.Text = "C_TO_B"
        '
        'txt_C_TO_B_payment_code
        '
        Me.txt_C_TO_B_payment_code.BackColor = System.Drawing.Color.DimGray
        Me.txt_C_TO_B_payment_code.Font = New System.Drawing.Font("Leelawadee UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_C_TO_B_payment_code.ForeColor = System.Drawing.Color.Transparent
        Me.txt_C_TO_B_payment_code.Location = New System.Drawing.Point(345, 241)
        Me.txt_C_TO_B_payment_code.Name = "txt_C_TO_B_payment_code"
        Me.txt_C_TO_B_payment_code.ReadOnly = True
        Me.txt_C_TO_B_payment_code.Size = New System.Drawing.Size(558, 50)
        Me.txt_C_TO_B_payment_code.TabIndex = 58
        Me.txt_C_TO_B_payment_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_C_TO_B_payment_code.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_C_TO_B_payment_code.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_C_TO_B_payment_code.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_C_TO_B_payment_code.US_Color_Enable = System.Drawing.Color.White
        Me.txt_C_TO_B_payment_code.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_C_TO_B_payment_code.Us_dataBindings_TOP = 10
        Me.txt_C_TO_B_payment_code.US_Enable = False
        Me.txt_C_TO_B_payment_code.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_C_TO_B_payment_code.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_C_TO_B_payment_code.US_Number = False
        Me.txt_C_TO_B_payment_code.US_Tag2 = ""
        Me.txt_C_TO_B_payment_code.US_value = Nothing
        '
        'Label_US8
        '
        Me.Label_US8.Font = New System.Drawing.Font("Leelawadee UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US8.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US8.Location = New System.Drawing.Point(343, 179)
        Me.Label_US8.Name = "Label_US8"
        Me.Label_US8.Size = New System.Drawing.Size(150, 50)
        Me.Label_US8.TabIndex = 57
        Me.Label_US8.Text = "เลขที่จ่าย"
        '
        'txt_QrthaiAmount
        '
        Me.txt_QrthaiAmount.BackColor = System.Drawing.Color.DimGray
        Me.txt_QrthaiAmount.Font = New System.Drawing.Font("Leelawadee UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_QrthaiAmount.ForeColor = System.Drawing.Color.Transparent
        Me.txt_QrthaiAmount.Location = New System.Drawing.Point(610, 95)
        Me.txt_QrthaiAmount.Name = "txt_QrthaiAmount"
        Me.txt_QrthaiAmount.ReadOnly = True
        Me.txt_QrthaiAmount.Size = New System.Drawing.Size(278, 71)
        Me.txt_QrthaiAmount.TabIndex = 54
        Me.txt_QrthaiAmount.Text = "0"
        Me.txt_QrthaiAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_QrthaiAmount.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_QrthaiAmount.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_QrthaiAmount.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_QrthaiAmount.US_Color_Enable = System.Drawing.Color.White
        Me.txt_QrthaiAmount.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_QrthaiAmount.Us_dataBindings_TOP = 10
        Me.txt_QrthaiAmount.US_Enable = False
        Me.txt_QrthaiAmount.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_QrthaiAmount.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_QrthaiAmount.US_Number = True
        Me.txt_QrthaiAmount.US_Tag2 = ""
        Me.txt_QrthaiAmount.US_value = Nothing
        '
        'Label_US6
        '
        Me.Label_US6.Font = New System.Drawing.Font("Leelawadee UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US6.ForeColor = System.Drawing.Color.Red
        Me.Label_US6.Location = New System.Drawing.Point(329, 98)
        Me.Label_US6.Name = "Label_US6"
        Me.Label_US6.Size = New System.Drawing.Size(285, 57)
        Me.Label_US6.TabIndex = 53
        Me.Label_US6.Text = "ยอดที่ต้องจ่าย"
        '
        'btn_REQUEST_QR_CODE
        '
        Me.btn_REQUEST_QR_CODE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_REQUEST_QR_CODE.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_REQUEST_QR_CODE.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_REQUEST_QR_CODE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_REQUEST_QR_CODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_REQUEST_QR_CODE.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_REQUEST_QR_CODE.ForeColor = System.Drawing.Color.DimGray
        Me.btn_REQUEST_QR_CODE.Image = CType(resources.GetObject("btn_REQUEST_QR_CODE.Image"), System.Drawing.Image)
        Me.btn_REQUEST_QR_CODE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_REQUEST_QR_CODE.Location = New System.Drawing.Point(371, 28)
        Me.btn_REQUEST_QR_CODE.Name = "btn_REQUEST_QR_CODE"
        Me.btn_REQUEST_QR_CODE.Size = New System.Drawing.Size(569, 61)
        Me.btn_REQUEST_QR_CODE.TabIndex = 56
        Me.btn_REQUEST_QR_CODE.Text = "REQUEST QR CODE"
        Me.btn_REQUEST_QR_CODE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_REQUEST_QR_CODE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_REQUEST_QR_CODE.UseVisualStyleBackColor = False
        '
        'pbox_qtcode
        '
        Me.pbox_qtcode.BackColor = System.Drawing.Color.White
        Me.pbox_qtcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbox_qtcode.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pbox_qtcode.Image = CType(resources.GetObject("pbox_qtcode.Image"), System.Drawing.Image)
        Me.pbox_qtcode.Location = New System.Drawing.Point(16, 28)
        Me.pbox_qtcode.Name = "pbox_qtcode"
        Me.pbox_qtcode.Size = New System.Drawing.Size(307, 272)
        Me.pbox_qtcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox_qtcode.TabIndex = 55
        Me.pbox_qtcode.TabStop = False
        '
        'B_TO_C
        '
        Me.B_TO_C.BackColor = System.Drawing.Color.AliceBlue
        Me.B_TO_C.Controls.Add(Me.RT_display)
        Me.B_TO_C.Controls.Add(Me.GroupBox1)
        Me.B_TO_C.Controls.Add(Me.txt_PAYTYPE)
        Me.B_TO_C.Controls.Add(Me.Label_US13)
        Me.B_TO_C.Controls.Add(Me.FlowLayoutPanel1)
        Me.B_TO_C.Controls.Add(Me.Label_US10)
        Me.B_TO_C.Controls.Add(Me.txt_TrueAmount)
        Me.B_TO_C.Controls.Add(Me.Label_US2)
        Me.B_TO_C.Location = New System.Drawing.Point(4, 34)
        Me.B_TO_C.Name = "B_TO_C"
        Me.B_TO_C.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.B_TO_C.Size = New System.Drawing.Size(979, 357)
        Me.B_TO_C.TabIndex = 2
        Me.B_TO_C.Text = "B_TO_C"
        '
        'RT_display
        '
        Me.RT_display.BackColor = System.Drawing.Color.Gold
        Me.RT_display.Font = New System.Drawing.Font("Leelawadee UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RT_display.Location = New System.Drawing.Point(11, 180)
        Me.RT_display.Name = "RT_display"
        Me.RT_display.Size = New System.Drawing.Size(961, 147)
        Me.RT_display.TabIndex = 76
        Me.RT_display.Text = "แสกน QRCODE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_US9)
        Me.GroupBox1.Controls.Add(Me.Label_US7)
        Me.GroupBox1.Controls.Add(Me.txt_B_TO_C_payment_code)
        Me.GroupBox1.Controls.Add(Me.cur_docno)
        Me.GroupBox1.Controls.Add(Me.lbl_confirm)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(67, 32)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'Label_US9
        '
        Me.Label_US9.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US9.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US9.Location = New System.Drawing.Point(28, 29)
        Me.Label_US9.Name = "Label_US9"
        Me.Label_US9.Size = New System.Drawing.Size(145, 47)
        Me.Label_US9.TabIndex = 57
        Me.Label_US9.Text = "เลขที่บิลขาย"
        Me.Label_US9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_US7
        '
        Me.Label_US7.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US7.ForeColor = System.Drawing.Color.Blue
        Me.Label_US7.Location = New System.Drawing.Point(27, 78)
        Me.Label_US7.Name = "Label_US7"
        Me.Label_US7.Size = New System.Drawing.Size(146, 43)
        Me.Label_US7.TabIndex = 53
        Me.Label_US7.Text = "เลขที่จ่ายเงิน"
        Me.Label_US7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_B_TO_C_payment_code
        '
        Me.txt_B_TO_C_payment_code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_B_TO_C_payment_code.BackColor = System.Drawing.Color.DimGray
        Me.txt_B_TO_C_payment_code.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_B_TO_C_payment_code.ForeColor = System.Drawing.Color.Transparent
        Me.txt_B_TO_C_payment_code.Location = New System.Drawing.Point(205, 78)
        Me.txt_B_TO_C_payment_code.Name = "txt_B_TO_C_payment_code"
        Me.txt_B_TO_C_payment_code.ReadOnly = True
        Me.txt_B_TO_C_payment_code.Size = New System.Drawing.Size(1, 43)
        Me.txt_B_TO_C_payment_code.TabIndex = 54
        Me.txt_B_TO_C_payment_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_B_TO_C_payment_code.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_B_TO_C_payment_code.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_B_TO_C_payment_code.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_B_TO_C_payment_code.US_Color_Enable = System.Drawing.Color.White
        Me.txt_B_TO_C_payment_code.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_B_TO_C_payment_code.Us_dataBindings_TOP = 10
        Me.txt_B_TO_C_payment_code.US_Enable = False
        Me.txt_B_TO_C_payment_code.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_B_TO_C_payment_code.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_B_TO_C_payment_code.US_Number = False
        Me.txt_B_TO_C_payment_code.US_Tag2 = ""
        Me.txt_B_TO_C_payment_code.US_value = Nothing
        '
        'cur_docno
        '
        Me.cur_docno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cur_docno.BackColor = System.Drawing.Color.DimGray
        Me.cur_docno.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cur_docno.ForeColor = System.Drawing.Color.Transparent
        Me.cur_docno.Location = New System.Drawing.Point(206, 33)
        Me.cur_docno.Name = "cur_docno"
        Me.cur_docno.ReadOnly = True
        Me.cur_docno.Size = New System.Drawing.Size(1, 43)
        Me.cur_docno.TabIndex = 56
        Me.cur_docno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cur_docno.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.cur_docno.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.cur_docno.US_Color_Didable = System.Drawing.Color.DimGray
        Me.cur_docno.US_Color_Enable = System.Drawing.Color.White
        Me.cur_docno.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.cur_docno.Us_dataBindings_TOP = 10
        Me.cur_docno.US_Enable = False
        Me.cur_docno.US_foreColor_Didable = System.Drawing.Color.White
        Me.cur_docno.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.cur_docno.US_Number = False
        Me.cur_docno.US_Tag2 = ""
        Me.cur_docno.US_value = Nothing
        '
        'lbl_confirm
        '
        Me.lbl_confirm.AutoSize = True
        Me.lbl_confirm.Location = New System.Drawing.Point(5, 51)
        Me.lbl_confirm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_confirm.Name = "lbl_confirm"
        Me.lbl_confirm.Size = New System.Drawing.Size(67, 25)
        Me.lbl_confirm.TabIndex = 58
        Me.lbl_confirm.Text = "Label1"
        Me.lbl_confirm.Visible = False
        '
        'txt_PAYTYPE
        '
        Me.txt_PAYTYPE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PAYTYPE.BackColor = System.Drawing.Color.Orange
        Me.txt_PAYTYPE.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_PAYTYPE.ForeColor = System.Drawing.Color.Black
        Me.txt_PAYTYPE.Location = New System.Drawing.Point(125, 29)
        Me.txt_PAYTYPE.Name = "txt_PAYTYPE"
        Me.txt_PAYTYPE.ReadOnly = True
        Me.txt_PAYTYPE.Size = New System.Drawing.Size(317, 43)
        Me.txt_PAYTYPE.TabIndex = 74
        Me.txt_PAYTYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_PAYTYPE.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_PAYTYPE.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_PAYTYPE.US_Color_Didable = System.Drawing.Color.Orange
        Me.txt_PAYTYPE.US_Color_Enable = System.Drawing.Color.White
        Me.txt_PAYTYPE.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_PAYTYPE.Us_dataBindings_TOP = 10
        Me.txt_PAYTYPE.US_Enable = False
        Me.txt_PAYTYPE.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_PAYTYPE.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_PAYTYPE.US_Number = False
        Me.txt_PAYTYPE.US_Tag2 = ""
        Me.txt_PAYTYPE.US_value = Nothing
        '
        'Label_US13
        '
        Me.Label_US13.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US13.ForeColor = System.Drawing.Color.Red
        Me.Label_US13.Location = New System.Drawing.Point(4, 31)
        Me.Label_US13.Name = "Label_US13"
        Me.Label_US13.Size = New System.Drawing.Size(115, 37)
        Me.Label_US13.TabIndex = 73
        Me.Label_US13.Text = "ชำระด้วย"
        Me.Label_US13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Inquiry)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_Verify_slip)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_cancel)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(11, 80)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(959, 94)
        Me.FlowLayoutPanel1.TabIndex = 72
        '
        'btn_Inquiry
        '
        Me.btn_Inquiry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Inquiry.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_Inquiry.Enabled = False
        Me.btn_Inquiry.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.btn_Inquiry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_Inquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Inquiry.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Inquiry.ForeColor = System.Drawing.Color.Black
        Me.btn_Inquiry.Image = CType(resources.GetObject("btn_Inquiry.Image"), System.Drawing.Image)
        Me.btn_Inquiry.Location = New System.Drawing.Point(3, 3)
        Me.btn_Inquiry.Name = "btn_Inquiry"
        Me.btn_Inquiry.Size = New System.Drawing.Size(300, 80)
        Me.btn_Inquiry.TabIndex = 70
        Me.btn_Inquiry.Text = "ยืนยันการชำระเงิน"
        Me.btn_Inquiry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Inquiry.UseVisualStyleBackColor = False
        '
        'btn_Verify_slip
        '
        Me.btn_Verify_slip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Verify_slip.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_Verify_slip.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.btn_Verify_slip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_Verify_slip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Verify_slip.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Verify_slip.ForeColor = System.Drawing.Color.DimGray
        Me.btn_Verify_slip.Image = CType(resources.GetObject("btn_Verify_slip.Image"), System.Drawing.Image)
        Me.btn_Verify_slip.Location = New System.Drawing.Point(309, 3)
        Me.btn_Verify_slip.Name = "btn_Verify_slip"
        Me.btn_Verify_slip.Size = New System.Drawing.Size(300, 80)
        Me.btn_Verify_slip.TabIndex = 72
        Me.btn_Verify_slip.Text = "Verify slip"
        Me.btn_Verify_slip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Verify_slip.UseVisualStyleBackColor = False
        Me.btn_Verify_slip.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.DimGray
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(615, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(300, 80)
        Me.btn_cancel.TabIndex = 73
        Me.btn_cancel.Text = "ยกเลิกรายการรอจ่าย"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
        Me.btn_cancel.Visible = False
        '
        'Label_US10
        '
        Me.Label_US10.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US10.ForeColor = System.Drawing.Color.Red
        Me.Label_US10.Location = New System.Drawing.Point(547, 330)
        Me.Label_US10.Name = "Label_US10"
        Me.Label_US10.Size = New System.Drawing.Size(425, 24)
        Me.Label_US10.TabIndex = 59
        Me.Label_US10.Text = "เมื่อแสกนจ่ายปุ่ม ปิด จะถูกซ่อน และจะโชว์เมื่อมีการกดตรวจสอบ 3 ครั้ง"
        '
        'txt_TrueAmount
        '
        Me.txt_TrueAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TrueAmount.BackColor = System.Drawing.Color.DimGray
        Me.txt_TrueAmount.Font = New System.Drawing.Font("Leelawadee UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_TrueAmount.ForeColor = System.Drawing.Color.Transparent
        Me.txt_TrueAmount.Location = New System.Drawing.Point(747, 17)
        Me.txt_TrueAmount.Name = "txt_TrueAmount"
        Me.txt_TrueAmount.ReadOnly = True
        Me.txt_TrueAmount.Size = New System.Drawing.Size(226, 57)
        Me.txt_TrueAmount.TabIndex = 51
        Me.txt_TrueAmount.Text = "0"
        Me.txt_TrueAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TrueAmount.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_TrueAmount.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_TrueAmount.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_TrueAmount.US_Color_Enable = System.Drawing.Color.White
        Me.txt_TrueAmount.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_TrueAmount.Us_dataBindings_TOP = 10
        Me.txt_TrueAmount.US_Enable = False
        Me.txt_TrueAmount.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_TrueAmount.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_TrueAmount.US_Number = True
        Me.txt_TrueAmount.US_Tag2 = ""
        Me.txt_TrueAmount.US_value = Nothing
        '
        'Label_US2
        '
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Red
        Me.Label_US2.Location = New System.Drawing.Point(463, 22)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(278, 46)
        Me.Label_US2.TabIndex = 50
        Me.Label_US2.Text = "ยอดที่ต้องจ่าย"
        '
        'T_Waitpament
        '
        Me.T_Waitpament.Controls.Add(Me.Label_US12)
        Me.T_Waitpament.Controls.Add(Me.PictureBox_US1)
        Me.T_Waitpament.Location = New System.Drawing.Point(4, 34)
        Me.T_Waitpament.Name = "T_Waitpament"
        Me.T_Waitpament.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.T_Waitpament.Size = New System.Drawing.Size(979, 357)
        Me.T_Waitpament.TabIndex = 3
        Me.T_Waitpament.Text = "Waitpament"
        Me.T_Waitpament.UseVisualStyleBackColor = True
        '
        'Label_US12
        '
        Me.Label_US12.AutoSize = True
        Me.Label_US12.Font = New System.Drawing.Font("Leelawadee UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_US12.Location = New System.Drawing.Point(358, 146)
        Me.Label_US12.Name = "Label_US12"
        Me.Label_US12.Size = New System.Drawing.Size(195, 40)
        Me.Label_US12.TabIndex = 1
        Me.Label_US12.Text = "Wait Payment"
        '
        'PictureBox_US1
        '
        Me.PictureBox_US1.BackColor = System.Drawing.Color.White
        Me.PictureBox_US1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PictureBox_US1.Image = CType(resources.GetObject("PictureBox_US1.Image"), System.Drawing.Image)
        Me.PictureBox_US1.Location = New System.Drawing.Point(276, 15)
        Me.PictureBox_US1.Name = "PictureBox_US1"
        Me.PictureBox_US1.Size = New System.Drawing.Size(360, 316)
        Me.PictureBox_US1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_US1.TabIndex = 0
        Me.PictureBox_US1.TabStop = False
        '
        'txt_barcode_Normal
        '
        Me.txt_barcode_Normal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_barcode_Normal.BackColor = System.Drawing.Color.Lavender
        Me.txt_barcode_Normal.Font = New System.Drawing.Font("Leelawadee UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_barcode_Normal.ForeColor = System.Drawing.Color.DimGray
        Me.txt_barcode_Normal.Location = New System.Drawing.Point(0, 165)
        Me.txt_barcode_Normal.Name = "txt_barcode_Normal"
        Me.txt_barcode_Normal.Size = New System.Drawing.Size(988, 71)
        Me.txt_barcode_Normal.TabIndex = 7
        Me.txt_barcode_Normal.Text = "N0601110953"
        Me.txt_barcode_Normal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_barcode_Normal.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_barcode_Normal.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_barcode_Normal.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_barcode_Normal.US_Color_Enable = System.Drawing.Color.Lavender
        Me.txt_barcode_Normal.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_barcode_Normal.Us_dataBindings_TOP = 10
        Me.txt_barcode_Normal.US_Enable = True
        Me.txt_barcode_Normal.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_barcode_Normal.US_foreColor_Enable = System.Drawing.Color.White
        Me.txt_barcode_Normal.US_Number = False
        Me.txt_barcode_Normal.US_Tag2 = ""
        Me.txt_barcode_Normal.US_value = Nothing
        '
        'Panel_US1
        '
        Me.Panel_US1.Controls.Add(Me.Panel_US2)
        Me.Panel_US1.Controls.Add(Me.Panel_US3)
        Me.Panel_US1.Controls.Add(Me.Panel5)
        Me.Panel_US1.Controls.Add(Me.Panel4)
        Me.Panel_US1.Controls.Add(Me.Panel2)
        Me.Panel_US1.Controls.Add(Me.Panel1)
        Me.Panel_US1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_US1.Name = "Panel_US1"
        Me.Panel_US1.Size = New System.Drawing.Size(1000, 700)
        Me.Panel_US1.TabIndex = 1
        '
        'Panel_US2
        '
        Me.Panel_US2.Controls.Add(Me.Panel3)
        Me.Panel_US2.Controls.Add(Me.txt_barcode_Normal)
        Me.Panel_US2.Controls.Add(Me.Label_US11)
        Me.Panel_US2.Controls.Add(Me.tab_payment)
        Me.Panel_US2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US2.Location = New System.Drawing.Point(5, 46)
        Me.Panel_US2.Name = "Panel_US2"
        Me.Panel_US2.Size = New System.Drawing.Size(990, 588)
        Me.Panel_US2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.fl_cardtype_api)
        Me.Panel3.Controls.Add(Me.fl_paymenthub_cpn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(990, 164)
        Me.Panel3.TabIndex = 59
        '
        'fl_cardtype_api
        '
        Me.fl_cardtype_api.AutoScroll = True
        Me.fl_cardtype_api.BackColor = System.Drawing.Color.White
        Me.fl_cardtype_api.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fl_cardtype_api.Controls.Add(Me.btn_narmal)
        Me.fl_cardtype_api.Controls.Add(Me.btn_TMW)
        Me.fl_cardtype_api.Controls.Add(Me.btn_TMW_EDC)
        Me.fl_cardtype_api.Controls.Add(Me.btn_QYthai)
        Me.fl_cardtype_api.Controls.Add(Me.btn_Alipay)
        Me.fl_cardtype_api.Controls.Add(Me.btn_Wechat)
        Me.fl_cardtype_api.Controls.Add(Me.btn_Dolfin)
        Me.fl_cardtype_api.Controls.Add(Me.btn_rabbit)
        Me.fl_cardtype_api.Controls.Add(Me.btn_LINEPAY)
        Me.fl_cardtype_api.Controls.Add(Me.Btn_QRCS)
        Me.fl_cardtype_api.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fl_cardtype_api.Location = New System.Drawing.Point(49, 17)
        Me.fl_cardtype_api.Name = "fl_cardtype_api"
        Me.fl_cardtype_api.Size = New System.Drawing.Size(421, 132)
        Me.fl_cardtype_api.TabIndex = 39
        '
        'btn_narmal
        '
        Me.btn_narmal.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_narmal.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btn_narmal.FlatAppearance.BorderSize = 2
        Me.btn_narmal.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_narmal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_narmal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_narmal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_narmal.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_narmal.ForeColor = System.Drawing.Color.White
        Me.btn_narmal.Image = CType(resources.GetObject("btn_narmal.Image"), System.Drawing.Image)
        Me.btn_narmal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_narmal.Location = New System.Drawing.Point(3, 3)
        Me.btn_narmal.Name = "btn_narmal"
        Me.btn_narmal.Size = New System.Drawing.Size(205, 74)
        Me.btn_narmal.TabIndex = 36
        Me.btn_narmal.Tag = ""
        Me.btn_narmal.Text = "บัตรปกติ"
        Me.btn_narmal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_narmal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_narmal.UseVisualStyleBackColor = False
        '
        'btn_TMW
        '
        Me.btn_TMW.BackColor = System.Drawing.Color.Transparent
        Me.btn_TMW.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btn_TMW.FlatAppearance.BorderSize = 2
        Me.btn_TMW.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_TMW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_TMW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_TMW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TMW.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_TMW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_TMW.Image = CType(resources.GetObject("btn_TMW.Image"), System.Drawing.Image)
        Me.btn_TMW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_TMW.Location = New System.Drawing.Point(3, 83)
        Me.btn_TMW.Name = "btn_TMW"
        Me.btn_TMW.Size = New System.Drawing.Size(205, 74)
        Me.btn_TMW.TabIndex = 38
        Me.btn_TMW.Tag = "TRUEWALLET"
        Me.btn_TMW.Text = "True money"
        Me.btn_TMW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_TMW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TMW.UseVisualStyleBackColor = False
        '
        'btn_TMW_EDC
        '
        Me.btn_TMW_EDC.BackColor = System.Drawing.Color.Transparent
        Me.btn_TMW_EDC.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btn_TMW_EDC.FlatAppearance.BorderSize = 2
        Me.btn_TMW_EDC.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_TMW_EDC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_TMW_EDC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_TMW_EDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TMW_EDC.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_TMW_EDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_TMW_EDC.Image = CType(resources.GetObject("btn_TMW_EDC.Image"), System.Drawing.Image)
        Me.btn_TMW_EDC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_TMW_EDC.Location = New System.Drawing.Point(3, 163)
        Me.btn_TMW_EDC.Name = "btn_TMW_EDC"
        Me.btn_TMW_EDC.Size = New System.Drawing.Size(205, 74)
        Me.btn_TMW_EDC.TabIndex = 43
        Me.btn_TMW_EDC.Tag = "TRUEEDC"
        Me.btn_TMW_EDC.Text = "True EDC"
        Me.btn_TMW_EDC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_TMW_EDC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_TMW_EDC.UseVisualStyleBackColor = False
        '
        'btn_QYthai
        '
        Me.btn_QYthai.BackColor = System.Drawing.Color.Transparent
        Me.btn_QYthai.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btn_QYthai.FlatAppearance.BorderSize = 2
        Me.btn_QYthai.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_QYthai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_QYthai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_QYthai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_QYthai.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_QYthai.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btn_QYthai.Image = CType(resources.GetObject("btn_QYthai.Image"), System.Drawing.Image)
        Me.btn_QYthai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_QYthai.Location = New System.Drawing.Point(3, 243)
        Me.btn_QYthai.Name = "btn_QYthai"
        Me.btn_QYthai.Size = New System.Drawing.Size(205, 74)
        Me.btn_QYthai.TabIndex = 37
        Me.btn_QYthai.Tag = "ThaiQR"
        Me.btn_QYthai.Text = "Thai QR"
        Me.btn_QYthai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_QYthai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_QYthai.UseVisualStyleBackColor = False
        '
        'btn_Alipay
        '
        Me.btn_Alipay.BackColor = System.Drawing.Color.Transparent
        Me.btn_Alipay.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btn_Alipay.FlatAppearance.BorderSize = 2
        Me.btn_Alipay.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Alipay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Alipay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Alipay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Alipay.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Alipay.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btn_Alipay.Image = CType(resources.GetObject("btn_Alipay.Image"), System.Drawing.Image)
        Me.btn_Alipay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Alipay.Location = New System.Drawing.Point(3, 323)
        Me.btn_Alipay.Name = "btn_Alipay"
        Me.btn_Alipay.Size = New System.Drawing.Size(205, 74)
        Me.btn_Alipay.TabIndex = 39
        Me.btn_Alipay.Tag = "Alipay"
        Me.btn_Alipay.Text = "Alipay"
        Me.btn_Alipay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Alipay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Alipay.UseVisualStyleBackColor = False
        '
        'btn_Wechat
        '
        Me.btn_Wechat.BackColor = System.Drawing.Color.Transparent
        Me.btn_Wechat.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btn_Wechat.FlatAppearance.BorderSize = 2
        Me.btn_Wechat.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Wechat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Wechat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Wechat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Wechat.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Wechat.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btn_Wechat.Image = CType(resources.GetObject("btn_Wechat.Image"), System.Drawing.Image)
        Me.btn_Wechat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Wechat.Location = New System.Drawing.Point(3, 403)
        Me.btn_Wechat.Name = "btn_Wechat"
        Me.btn_Wechat.Size = New System.Drawing.Size(205, 74)
        Me.btn_Wechat.TabIndex = 40
        Me.btn_Wechat.Tag = "Wechat"
        Me.btn_Wechat.Text = "Wechat"
        Me.btn_Wechat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Wechat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Wechat.UseVisualStyleBackColor = False
        '
        'btn_Dolfin
        '
        Me.btn_Dolfin.BackColor = System.Drawing.Color.Transparent
        Me.btn_Dolfin.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btn_Dolfin.FlatAppearance.BorderSize = 2
        Me.btn_Dolfin.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Dolfin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Dolfin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Dolfin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Dolfin.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Dolfin.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btn_Dolfin.Image = CType(resources.GetObject("btn_Dolfin.Image"), System.Drawing.Image)
        Me.btn_Dolfin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Dolfin.Location = New System.Drawing.Point(3, 483)
        Me.btn_Dolfin.Name = "btn_Dolfin"
        Me.btn_Dolfin.Size = New System.Drawing.Size(205, 74)
        Me.btn_Dolfin.TabIndex = 41
        Me.btn_Dolfin.Tag = "Dolfin"
        Me.btn_Dolfin.Text = "Dolfin"
        Me.btn_Dolfin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Dolfin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Dolfin.UseVisualStyleBackColor = False
        '
        'btn_rabbit
        '
        Me.btn_rabbit.BackColor = System.Drawing.Color.Transparent
        Me.btn_rabbit.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btn_rabbit.FlatAppearance.BorderSize = 2
        Me.btn_rabbit.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_rabbit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_rabbit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_rabbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rabbit.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_rabbit.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btn_rabbit.Image = CType(resources.GetObject("btn_rabbit.Image"), System.Drawing.Image)
        Me.btn_rabbit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rabbit.Location = New System.Drawing.Point(3, 563)
        Me.btn_rabbit.Name = "btn_rabbit"
        Me.btn_rabbit.Size = New System.Drawing.Size(205, 74)
        Me.btn_rabbit.TabIndex = 42
        Me.btn_rabbit.Tag = "Rabbit"
        Me.btn_rabbit.Text = "Rabbit"
        Me.btn_rabbit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_rabbit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_rabbit.UseVisualStyleBackColor = False
        '
        'btn_LINEPAY
        '
        Me.btn_LINEPAY.BackColor = System.Drawing.Color.Transparent
        Me.btn_LINEPAY.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btn_LINEPAY.FlatAppearance.BorderSize = 2
        Me.btn_LINEPAY.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_LINEPAY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_LINEPAY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_LINEPAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LINEPAY.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_LINEPAY.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btn_LINEPAY.Image = CType(resources.GetObject("btn_LINEPAY.Image"), System.Drawing.Image)
        Me.btn_LINEPAY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_LINEPAY.Location = New System.Drawing.Point(3, 643)
        Me.btn_LINEPAY.Name = "btn_LINEPAY"
        Me.btn_LINEPAY.Size = New System.Drawing.Size(205, 74)
        Me.btn_LINEPAY.TabIndex = 44
        Me.btn_LINEPAY.Tag = "LINEPAY"
        Me.btn_LINEPAY.Text = "Line Pay"
        Me.btn_LINEPAY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_LINEPAY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_LINEPAY.UseVisualStyleBackColor = False
        '
        'Btn_QRCS
        '
        Me.Btn_QRCS.BackColor = System.Drawing.Color.Transparent
        Me.Btn_QRCS.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.Btn_QRCS.FlatAppearance.BorderSize = 2
        Me.Btn_QRCS.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_QRCS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_QRCS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_QRCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_QRCS.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_QRCS.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Btn_QRCS.Image = CType(resources.GetObject("Btn_QRCS.Image"), System.Drawing.Image)
        Me.Btn_QRCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_QRCS.Location = New System.Drawing.Point(3, 723)
        Me.Btn_QRCS.Name = "Btn_QRCS"
        Me.Btn_QRCS.Size = New System.Drawing.Size(205, 74)
        Me.Btn_QRCS.TabIndex = 45
        Me.Btn_QRCS.Tag = "QRCS"
        Me.Btn_QRCS.Text = "VISA"
        Me.Btn_QRCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_QRCS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_QRCS.UseVisualStyleBackColor = False
        '
        'fl_paymenthub_cpn
        '
        Me.fl_paymenthub_cpn.AutoScroll = True
        Me.fl_paymenthub_cpn.BackColor = System.Drawing.Color.White
        Me.fl_paymenthub_cpn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fl_paymenthub_cpn.Controls.Add(Me.Button_US1)
        Me.fl_paymenthub_cpn.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.fl_paymenthub_cpn.Location = New System.Drawing.Point(511, 17)
        Me.fl_paymenthub_cpn.Name = "fl_paymenthub_cpn"
        Me.fl_paymenthub_cpn.Size = New System.Drawing.Size(421, 132)
        Me.fl_paymenthub_cpn.TabIndex = 46
        '
        'Button_US1
        '
        Me.Button_US1.BackColor = System.Drawing.Color.Azure
        Me.Button_US1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.Button_US1.FlatAppearance.BorderSize = 2
        Me.Button_US1.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button_US1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button_US1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button_US1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button_US1.Image = Global.TouchPOS.My.Resources.Resources.No_image_available50_svg
        Me.Button_US1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_US1.Location = New System.Drawing.Point(3, 3)
        Me.Button_US1.Name = "Button_US1"
        Me.Button_US1.Size = New System.Drawing.Size(225, 74)
        Me.Button_US1.TabIndex = 41
        Me.Button_US1.Tag = "Wechat"
        Me.Button_US1.Text = "Wechat"
        Me.Button_US1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_US1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_US1.UseVisualStyleBackColor = False
        '
        'Label_US11
        '
        Me.Label_US11.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US11.ForeColor = System.Drawing.Color.Red
        Me.Label_US11.Location = New System.Drawing.Point(362, 167)
        Me.Label_US11.Name = "Label_US11"
        Me.Label_US11.Size = New System.Drawing.Size(570, 70)
        Me.Label_US11.TabIndex = 58
        Me.Label_US11.Text = "กรุณา กดเลือก E-Wallet"
        Me.Label_US11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_US3
        '
        Me.Panel_US3.Controls.Add(Me.btn_del)
        Me.Panel_US3.Controls.Add(Me.ProgressBar1)
        Me.Panel_US3.Controls.Add(Me.btn_close)
        Me.Panel_US3.Controls.Add(Me.btn_ok)
        Me.Panel_US3.Controls.Add(Me.btn_cancell)
        Me.Panel_US3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US3.Location = New System.Drawing.Point(5, 634)
        Me.Panel_US3.Name = "Panel_US3"
        Me.Panel_US3.Size = New System.Drawing.Size(990, 61)
        Me.Panel_US3.TabIndex = 44
        '
        'btn_del
        '
        Me.btn_del.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_del.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_del.ForeColor = System.Drawing.Color.DimGray
        Me.btn_del.Image = CType(resources.GetObject("btn_del.Image"), System.Drawing.Image)
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.Location = New System.Drawing.Point(463, 3)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(199, 54)
        Me.btn_del.TabIndex = 39
        Me.btn_del.Text = "ไม่ใช้บัตรนี้"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 12)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(381, 43)
        Me.ProgressBar1.TabIndex = 38
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
        Me.btn_close.Location = New System.Drawing.Point(852, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(130, 54)
        Me.btn_close.TabIndex = 37
        Me.btn_close.Text = "  ปิด"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.DimGray
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(669, 4)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(164, 51)
        Me.btn_ok.TabIndex = 36
        Me.btn_ok.Text = "บันทึก"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_cancell
        '
        Me.btn_cancell.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancell.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_cancell.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cancell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_cancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancell.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancell.ForeColor = System.Drawing.Color.DimGray
        Me.btn_cancell.Image = CType(resources.GetObject("btn_cancell.Image"), System.Drawing.Image)
        Me.btn_cancell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancell.Location = New System.Drawing.Point(1008, 2)
        Me.btn_cancell.Name = "btn_cancell"
        Me.btn_cancell.Size = New System.Drawing.Size(143, 53)
        Me.btn_cancell.TabIndex = 34
        Me.btn_cancell.Text = "ยกเลิก"
        Me.btn_cancell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancell.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Orange
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(5, 695)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(990, 5)
        Me.Panel5.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Orange
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(995, 46)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 654)
        Me.Panel4.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Controls.Add(Me.p_icon)
        Me.Panel2.Controls.Add(Me.Label_US1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 46)
        Me.Panel2.TabIndex = 2
        '
        'p_icon
        '
        Me.p_icon.Image = CType(resources.GetObject("p_icon.Image"), System.Drawing.Image)
        Me.p_icon.Location = New System.Drawing.Point(7, 9)
        Me.p_icon.Name = "p_icon"
        Me.p_icon.Size = New System.Drawing.Size(60, 30)
        Me.p_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_icon.TabIndex = 5
        Me.p_icon.TabStop = False
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.White
        Me.Label_US1.Location = New System.Drawing.Point(73, 14)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(72, 25)
        Me.Label_US1.TabIndex = 1
        Me.Label_US1.Text = "จ่ายเงิน"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 700)
        Me.Panel1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Tm_request
        '
        Me.Tm_request.Interval = 1000
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "ลบ"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 125
        '
        'Timer_blink
        '
        Me.Timer_blink.Interval = 500
        '
        'F_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.Panel_US1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จ่ายเงิน"
        Me.tab_payment.ResumeLayout(False)
        Me.TNormal.ResumeLayout(False)
        Me.TNormal.PerformLayout()
        CType(Me.DGV_Card_Normal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C_TO_B.ResumeLayout(False)
        Me.C_TO_B.PerformLayout()
        CType(Me.pbox_qtcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.B_TO_C.ResumeLayout(False)
        Me.B_TO_C.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.T_Waitpament.ResumeLayout(False)
        Me.T_Waitpament.PerformLayout()
        CType(Me.PictureBox_US1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_US1.ResumeLayout(False)
        Me.Panel_US2.ResumeLayout(False)
        Me.Panel_US2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.fl_cardtype_api.ResumeLayout(False)
        Me.fl_paymenthub_cpn.ResumeLayout(False)
        Me.Panel_US3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_payment As Control_us.TabControl_US
    Friend WithEvents TNormal As TabPage
    Friend WithEvents C_TO_B As TabPage
    Friend WithEvents Panel_US1 As Control_us.Panel_US
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents p_icon As PictureBox
    Friend WithEvents Panel_US2 As Control_us.Panel_US
    Friend WithEvents fl_cardtype_api As Control_us.FlowLayoutPanel_US
    Friend WithEvents btn_narmal As Control_us.Button_US
    Friend WithEvents btn_QYthai As Control_us.Button_US
    Friend WithEvents btn_TMW As Control_us.Button_US
    Friend WithEvents B_TO_C As TabPage
    Friend WithEvents Panel_US3 As Control_us.Panel_US
    Friend WithEvents btn_cancell As Control_us.Button_US
    Friend WithEvents txt_barcode_Normal As Control_us.Textbox_UC
    Friend WithEvents DGV_Card_Normal As Control_us.DataGridView_US
    Friend WithEvents txt_amount_remain As Control_us.Textbox_UC
    Friend WithEvents Label_US5 As Control_us.Label_US
    Friend WithEvents txt_Amount As Control_us.Textbox_UC
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents txt_pay_Amount As Control_us.Textbox_UC
    Friend WithEvents btn_ok As Control_us.Button_US
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_close As Control_us.Button_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewImageColumn
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txt_TrueAmount As Control_us.Textbox_UC
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents txt_QrthaiAmount As Control_us.Textbox_UC
    Friend WithEvents Label_US6 As Control_us.Label_US
    Friend WithEvents btn_del As Control_us.Button_US
    Friend WithEvents btn_Alipay As Control_us.Button_US
    Friend WithEvents btn_Wechat As Control_us.Button_US
    Friend WithEvents btn_Dolfin As Control_us.Button_US
    Friend WithEvents btn_rabbit As Control_us.Button_US
    Friend WithEvents pbox_qtcode As Control_us.PictureBox_US
    Friend WithEvents Tm_request As Timer
    Friend WithEvents txt_B_TO_C_payment_code As Control_us.Textbox_UC
    Friend WithEvents Label_US7 As Control_us.Label_US
    Friend WithEvents btn_REQUEST_QR_CODE As Control_us.Button_US
    Friend WithEvents txt_C_TO_B_payment_code As Control_us.Textbox_UC
    Friend WithEvents Label_US8 As Control_us.Label_US
    Friend WithEvents btn_TMW_EDC As Control_us.Button_US
    Friend WithEvents cur_docno As Control_us.Textbox_UC
    Friend WithEvents Label_US9 As Control_us.Label_US
    Friend WithEvents lbl_confirm As Label
    Friend WithEvents Label_US10 As Control_us.Label_US
    Friend WithEvents Label_US11 As Control_us.Label_US
    Friend WithEvents btn_LINEPAY As Control_us.Button_US
    Friend WithEvents T_Waitpament As TabPage
    Friend WithEvents Label_US12 As Control_us.Label_US
    Friend WithEvents PictureBox_US1 As Control_us.PictureBox_US
    Friend WithEvents Btn_QRCS As Control_us.Button_US
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_Inquiry As Control_us.Button_US
    Friend WithEvents fl_paymenthub_cpn As Control_us.FlowLayoutPanel_US
    Friend WithEvents Button_US1 As Control_us.Button_US
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btn_Verify_slip As Control_us.Button_US
    Friend WithEvents btn_cancel As Control_us.Button_US
    Friend WithEvents txt_PAYTYPE As Control_us.Textbox_UC
    Friend WithEvents Label_US13 As Control_us.Label_US
    Friend WithEvents RT_display As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer_blink As Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Main_Sale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Main_Sale))
        Dim ItemData1 As TouchPOS.ItemData = New TouchPOS.ItemData()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_time = New System.Windows.Forms.ToolStrip()
        Me.txt_IP = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtdatetime = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.txt_shopcode = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txt_shopname = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.txt_totel = New System.Windows.Forms.ToolStripLabel()
        Me.stataus_disconnect = New System.Windows.Forms.ToolStripButton()
        Me.stataus_connect = New System.Windows.Forms.ToolStripButton()
        Me.lbl_time = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.txt_version = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.lbl_reset = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Timer_setfocus = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel_Right = New Control_us.Panel_US()
        Me.FL_Items = New Control_us.FlowLayoutPanel_US()
        Me.UC_Product_Items1 = New TouchPOS.UC_Product_Items()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_US2 = New Control_us.Label_US()
        Me.lbl_cur_Items_page = New Control_us.Label_US()
        Me.btn_ItemsLast = New Control_us.Button_US()
        Me.btn_ItemsNext = New Control_us.Button_US()
        Me.Panel_US6 = New Control_us.Panel_US()
        Me.Panel_US7 = New Control_us.Panel_US()
        Me.Fl_shopButton = New Control_us.FlowLayoutPanel_US()
        Me.Button_US7 = New Control_us.Button_US()
        Me.Button_US6 = New Control_us.Button_US()
        Me.Button_US8 = New Control_us.Button_US()
        Me.Button_US9 = New Control_us.Button_US()
        Me.Button_US10 = New Control_us.Button_US()
        Me.Button_US11 = New Control_us.Button_US()
        Me.Button_US12 = New Control_us.Button_US()
        Me.Button_US13 = New Control_us.Button_US()
        Me.Button_US14 = New Control_us.Button_US()
        Me.Button_US15 = New Control_us.Button_US()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_US1 = New Control_us.Label_US()
        Me.lbl_cur_Group_page = New Control_us.Label_US()
        Me.btn_GroupLast = New Control_us.Button_US()
        Me.btn_GroupNext = New Control_us.Button_US()
        Me.FL_Shop = New Control_us.FlowLayoutPanel_US()
        Me.Button_US4 = New Control_us.Button_US()
        Me.Button_US5 = New Control_us.Button_US()
        Me.Panel_left = New System.Windows.Forms.Panel()
        Me.Panel_US3 = New Control_us.Panel_US()
        Me.DGV_Product = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel_US4 = New Control_us.Panel_US()
        Me.Label_US6 = New Control_us.Label_US()
        Me.fl_payment = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_payment = New Control_us.Button_US()
        Me.btn_Refund = New Control_us.Button_US()
        Me.btn_cancel = New Control_us.Button_US()
        Me.Button_US24 = New Control_us.Button_US()
        Me.Button_US22 = New Control_us.Button_US()
        Me.Button_US17 = New Control_us.Button_US()
        Me.Panel_US5 = New Control_us.Panel_US()
        Me.Button_US1 = New Control_us.Button_US()
        Me.Button_US2 = New Control_us.Button_US()
        Me.txt_barcode = New Control_us.Textbox_UC()
        Me.Label_US5 = New Control_us.Label_US()
        Me.Label_US4 = New Control_us.Label_US()
        Me.txt_Amount = New Control_us.Textbox_UC()
        Me.Label_US3 = New Control_us.Label_US()
        Me.txt_qty_totel = New Control_us.Textbox_UC()
        Me.chk_Print = New Control_us.CheckBox1_US()
        Me.Panel_US2 = New Control_us.Panel_US()
        Me.Panel_US1 = New Control_us.Panel_US()
        Me.txt_lcd = New Control_us.Textbox_UC()
        Me.lbl_docno = New Control_us.Label_US()
        Me.lbl_shopname = New Control_us.Label_US()
        Me.Panel_US8 = New Control_us.Panel_US()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button_US23 = New Control_us.Button_US()
        Me.Button_US3 = New Control_us.Button_US()
        Me.Panel_US9 = New Control_us.Panel_US()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Timer_Reconnect = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Reset = New System.Windows.Forms.Timer(Me.components)
        Me.txt_time.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_Right.SuspendLayout()
        Me.FL_Items.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel_US6.SuspendLayout()
        Me.Panel_US7.SuspendLayout()
        Me.Fl_shopButton.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FL_Shop.SuspendLayout()
        Me.Panel_left.SuspendLayout()
        Me.Panel_US3.SuspendLayout()
        CType(Me.DGV_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_US4.SuspendLayout()
        Me.fl_payment.SuspendLayout()
        Me.Panel_US5.SuspendLayout()
        Me.Panel_US2.SuspendLayout()
        Me.Panel_US1.SuspendLayout()
        Me.Panel_US8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_US9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_time
        '
        Me.txt_time.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_time.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.txt_time.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txt_IP, Me.ToolStripSeparator1, Me.txtdatetime, Me.ToolStripSeparator2, Me.txt_shopcode, Me.ToolStripSeparator3, Me.txt_shopname, Me.ToolStripSeparator4, Me.txt_totel, Me.stataus_disconnect, Me.stataus_connect, Me.lbl_time, Me.ToolStripSeparator5, Me.txt_version, Me.ToolStripSeparator6, Me.lbl_reset})
        Me.txt_time.Location = New System.Drawing.Point(0, 0)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(1026, 30)
        Me.txt_time.TabIndex = 7
        Me.txt_time.Text = "ToolStrip1"
        '
        'txt_IP
        '
        Me.txt_IP.Name = "txt_IP"
        Me.txt_IP.Size = New System.Drawing.Size(82, 27)
        Me.txt_IP.Text = "192.168.1.1"
        Me.txt_IP.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'txtdatetime
        '
        Me.txtdatetime.Name = "txtdatetime"
        Me.txtdatetime.Size = New System.Drawing.Size(34, 27)
        Me.txtdatetime.Text = "วันที่"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'txt_shopcode
        '
        Me.txt_shopcode.Name = "txt_shopcode"
        Me.txt_shopcode.Size = New System.Drawing.Size(97, 27)
        Me.txt_shopcode.Text = "txt_shopcode"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'txt_shopname
        '
        Me.txt_shopname.Name = "txt_shopname"
        Me.txt_shopname.Size = New System.Drawing.Size(101, 27)
        Me.txt_shopname.Text = "txt_shopname"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'txt_totel
        '
        Me.txt_totel.Name = "txt_totel"
        Me.txt_totel.Size = New System.Drawing.Size(63, 27)
        Me.txt_totel.Text = "txt_totel"
        '
        'stataus_disconnect
        '
        Me.stataus_disconnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.stataus_disconnect.ForeColor = System.Drawing.Color.Red
        Me.stataus_disconnect.Image = CType(resources.GetObject("stataus_disconnect.Image"), System.Drawing.Image)
        Me.stataus_disconnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stataus_disconnect.Name = "stataus_disconnect"
        Me.stataus_disconnect.Size = New System.Drawing.Size(93, 27)
        Me.stataus_disconnect.Text = "ไม่เชื่อมต่อ"
        Me.stataus_disconnect.Visible = False
        '
        'stataus_connect
        '
        Me.stataus_connect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.stataus_connect.Image = CType(resources.GetObject("stataus_connect.Image"), System.Drawing.Image)
        Me.stataus_connect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stataus_connect.Name = "stataus_connect"
        Me.stataus_connect.Size = New System.Drawing.Size(79, 27)
        Me.stataus_connect.Text = "เชื่อมต่อ"
        '
        'lbl_time
        '
        Me.lbl_time.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(39, 27)
        Me.lbl_time.Text = "time"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'txt_version
        '
        Me.txt_version.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_version.BackColor = System.Drawing.Color.Red
        Me.txt_version.ForeColor = System.Drawing.Color.Black
        Me.txt_version.ImageTransparentColor = System.Drawing.Color.Black
        Me.txt_version.Name = "txt_version"
        Me.txt_version.Size = New System.Drawing.Size(56, 27)
        Me.txt_version.Text = "version"
        Me.txt_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 30)
        '
        'lbl_reset
        '
        Me.lbl_reset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_reset.BackColor = System.Drawing.Color.Red
        Me.lbl_reset.ForeColor = System.Drawing.Color.Red
        Me.lbl_reset.ImageTransparentColor = System.Drawing.Color.Red
        Me.lbl_reset.Name = "lbl_reset"
        Me.lbl_reset.Size = New System.Drawing.Size(18, 27)
        Me.lbl_reset.Text = "..."
        Me.lbl_reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_time)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 588)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 30)
        Me.Panel1.TabIndex = 8
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Timer_setfocus
        '
        Me.Timer_setfocus.Interval = 1000
        '
        'Panel_Right
        '
        Me.Panel_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Right.Controls.Add(Me.FL_Items)
        Me.Panel_Right.Controls.Add(Me.Panel3)
        Me.Panel_Right.Controls.Add(Me.Panel_US6)
        Me.Panel_Right.Controls.Add(Me.FL_Shop)
        Me.Panel_Right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Right.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_Right.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(691, 548)
        Me.Panel_Right.TabIndex = 3
        '
        'FL_Items
        '
        Me.FL_Items.AutoScroll = True
        Me.FL_Items.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FL_Items.Controls.Add(Me.UC_Product_Items1)
        Me.FL_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FL_Items.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FL_Items.Location = New System.Drawing.Point(0, 266)
        Me.FL_Items.Name = "FL_Items"
        Me.FL_Items.Size = New System.Drawing.Size(689, 280)
        Me.FL_Items.TabIndex = 11
        '
        'UC_Product_Items1
        '
        Me.UC_Product_Items1.BackColor = System.Drawing.Color.Gray
        Me.UC_Product_Items1.Location = New System.Drawing.Point(2, 32767)
        Me.UC_Product_Items1.Margin = New System.Windows.Forms.Padding(2, 380859291, 2, 380859291)
        Me.UC_Product_Items1.Name = "UC_Product_Items1"
        Me.UC_Product_Items1.Size = New System.Drawing.Size(65535, 65535)
        Me.UC_Product_Items1.TabIndex = 0
        ItemData1.GP = 0R
        ItemData1.GPAMOUNT = 0R
        ItemData1.GPRULE = Nothing
        ItemData1.Items_ForeColor = System.Drawing.Color.Empty
        ItemData1.PCODE = Nothing
        ItemData1.PNAME = Nothing
        ItemData1.ProductID = Nothing
        ItemData1.ProductImage = Nothing
        ItemData1.ProductName = Nothing
        ItemData1.ProductPrice = New Decimal(New Integer() {0, 0, 0, 0})
        ItemData1.UNITCODE = Nothing
        ItemData1.UNITNAME = Nothing
        Me.UC_Product_Items1.value = ItemData1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label_US2)
        Me.Panel3.Controls.Add(Me.lbl_cur_Items_page)
        Me.Panel3.Controls.Add(Me.btn_ItemsLast)
        Me.Panel3.Controls.Add(Me.btn_ItemsNext)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 222)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(689, 44)
        Me.Panel3.TabIndex = 10
        '
        'Label_US2
        '
        Me.Label_US2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US2.Location = New System.Drawing.Point(162, 0)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(189, 42)
        Me.Label_US2.TabIndex = 7
        Me.Label_US2.Text = "เมนูสินค้า  หน้าที่ "
        Me.Label_US2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_cur_Items_page
        '
        Me.lbl_cur_Items_page.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_cur_Items_page.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_cur_Items_page.Location = New System.Drawing.Point(357, 0)
        Me.lbl_cur_Items_page.Name = "lbl_cur_Items_page"
        Me.lbl_cur_Items_page.Size = New System.Drawing.Size(168, 42)
        Me.lbl_cur_Items_page.TabIndex = 6
        Me.lbl_cur_Items_page.Text = "1"
        Me.lbl_cur_Items_page.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_ItemsLast
        '
        Me.btn_ItemsLast.BackColor = System.Drawing.Color.Transparent
        Me.btn_ItemsLast.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_ItemsLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ItemsLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ItemsLast.Font = New System.Drawing.Font("Leelawadee UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ItemsLast.ForeColor = System.Drawing.Color.DimGray
        Me.btn_ItemsLast.Image = CType(resources.GetObject("btn_ItemsLast.Image"), System.Drawing.Image)
        Me.btn_ItemsLast.Location = New System.Drawing.Point(0, 0)
        Me.btn_ItemsLast.Name = "btn_ItemsLast"
        Me.btn_ItemsLast.Size = New System.Drawing.Size(162, 42)
        Me.btn_ItemsLast.TabIndex = 5
        Me.btn_ItemsLast.Text = "ก่อนหน้า"
        Me.btn_ItemsLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ItemsLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ItemsLast.UseVisualStyleBackColor = False
        '
        'btn_ItemsNext
        '
        Me.btn_ItemsNext.BackColor = System.Drawing.Color.Transparent
        Me.btn_ItemsNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_ItemsNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ItemsNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ItemsNext.Font = New System.Drawing.Font("Leelawadee UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ItemsNext.ForeColor = System.Drawing.Color.DimGray
        Me.btn_ItemsNext.Image = CType(resources.GetObject("btn_ItemsNext.Image"), System.Drawing.Image)
        Me.btn_ItemsNext.Location = New System.Drawing.Point(525, 0)
        Me.btn_ItemsNext.Name = "btn_ItemsNext"
        Me.btn_ItemsNext.Size = New System.Drawing.Size(162, 42)
        Me.btn_ItemsNext.TabIndex = 4
        Me.btn_ItemsNext.Text = "หน้าถัดไป"
        Me.btn_ItemsNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ItemsNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ItemsNext.UseVisualStyleBackColor = False
        '
        'Panel_US6
        '
        Me.Panel_US6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_US6.Controls.Add(Me.Panel_US7)
        Me.Panel_US6.Controls.Add(Me.Panel2)
        Me.Panel_US6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_US6.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US6.Location = New System.Drawing.Point(0, 60)
        Me.Panel_US6.Name = "Panel_US6"
        Me.Panel_US6.Size = New System.Drawing.Size(689, 162)
        Me.Panel_US6.TabIndex = 8
        '
        'Panel_US7
        '
        Me.Panel_US7.Controls.Add(Me.Fl_shopButton)
        Me.Panel_US7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US7.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US7.Location = New System.Drawing.Point(0, 44)
        Me.Panel_US7.Name = "Panel_US7"
        Me.Panel_US7.Size = New System.Drawing.Size(687, 116)
        Me.Panel_US7.TabIndex = 6
        '
        'Fl_shopButton
        '
        Me.Fl_shopButton.AutoScroll = True
        Me.Fl_shopButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fl_shopButton.Controls.Add(Me.Button_US7)
        Me.Fl_shopButton.Controls.Add(Me.Button_US6)
        Me.Fl_shopButton.Controls.Add(Me.Button_US8)
        Me.Fl_shopButton.Controls.Add(Me.Button_US9)
        Me.Fl_shopButton.Controls.Add(Me.Button_US10)
        Me.Fl_shopButton.Controls.Add(Me.Button_US11)
        Me.Fl_shopButton.Controls.Add(Me.Button_US12)
        Me.Fl_shopButton.Controls.Add(Me.Button_US13)
        Me.Fl_shopButton.Controls.Add(Me.Button_US14)
        Me.Fl_shopButton.Controls.Add(Me.Button_US15)
        Me.Fl_shopButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fl_shopButton.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Fl_shopButton.Location = New System.Drawing.Point(0, 0)
        Me.Fl_shopButton.Name = "Fl_shopButton"
        Me.Fl_shopButton.Size = New System.Drawing.Size(687, 116)
        Me.Fl_shopButton.TabIndex = 4
        '
        'Button_US7
        '
        Me.Button_US7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_US7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_US7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US7.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US7.ForeColor = System.Drawing.Color.White
        Me.Button_US7.Location = New System.Drawing.Point(3, 3)
        Me.Button_US7.Name = "Button_US7"
        Me.Button_US7.Size = New System.Drawing.Size(120, 50)
        Me.Button_US7.TabIndex = 0
        Me.Button_US7.Text = "ไอติม 5"
        Me.Button_US7.UseVisualStyleBackColor = False
        '
        'Button_US6
        '
        Me.Button_US6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button_US6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US6.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US6.ForeColor = System.Drawing.Color.White
        Me.Button_US6.Location = New System.Drawing.Point(129, 3)
        Me.Button_US6.Name = "Button_US6"
        Me.Button_US6.Size = New System.Drawing.Size(120, 50)
        Me.Button_US6.TabIndex = 1
        Me.Button_US6.Text = "ไอติม 6"
        Me.Button_US6.UseVisualStyleBackColor = False
        '
        'Button_US8
        '
        Me.Button_US8.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button_US8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US8.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US8.ForeColor = System.Drawing.Color.White
        Me.Button_US8.Location = New System.Drawing.Point(255, 3)
        Me.Button_US8.Name = "Button_US8"
        Me.Button_US8.Size = New System.Drawing.Size(120, 50)
        Me.Button_US8.TabIndex = 2
        Me.Button_US8.Text = "ไอติม 7"
        Me.Button_US8.UseVisualStyleBackColor = False
        '
        'Button_US9
        '
        Me.Button_US9.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button_US9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US9.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US9.ForeColor = System.Drawing.Color.White
        Me.Button_US9.Location = New System.Drawing.Point(381, 3)
        Me.Button_US9.Name = "Button_US9"
        Me.Button_US9.Size = New System.Drawing.Size(120, 50)
        Me.Button_US9.TabIndex = 3
        Me.Button_US9.Text = "ไอติมตัก"
        Me.Button_US9.UseVisualStyleBackColor = False
        '
        'Button_US10
        '
        Me.Button_US10.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button_US10.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US10.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US10.ForeColor = System.Drawing.Color.White
        Me.Button_US10.Location = New System.Drawing.Point(507, 3)
        Me.Button_US10.Name = "Button_US10"
        Me.Button_US10.Size = New System.Drawing.Size(120, 50)
        Me.Button_US10.TabIndex = 4
        Me.Button_US10.Text = "น้ำดื่ม"
        Me.Button_US10.UseVisualStyleBackColor = False
        '
        'Button_US11
        '
        Me.Button_US11.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button_US11.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US11.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US11.ForeColor = System.Drawing.Color.White
        Me.Button_US11.Location = New System.Drawing.Point(3, 59)
        Me.Button_US11.Name = "Button_US11"
        Me.Button_US11.Size = New System.Drawing.Size(120, 50)
        Me.Button_US11.TabIndex = 5
        Me.Button_US11.Text = "น้ำผลไม่้แฟนซี"
        Me.Button_US11.UseVisualStyleBackColor = False
        '
        'Button_US12
        '
        Me.Button_US12.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button_US12.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US12.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US12.ForeColor = System.Drawing.Color.White
        Me.Button_US12.Location = New System.Drawing.Point(129, 59)
        Me.Button_US12.Name = "Button_US12"
        Me.Button_US12.Size = New System.Drawing.Size(120, 50)
        Me.Button_US12.TabIndex = 6
        Me.Button_US12.Text = "โปนโมชั่น"
        Me.Button_US12.UseVisualStyleBackColor = False
        '
        'Button_US13
        '
        Me.Button_US13.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button_US13.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US13.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US13.ForeColor = System.Drawing.Color.White
        Me.Button_US13.Location = New System.Drawing.Point(255, 59)
        Me.Button_US13.Name = "Button_US13"
        Me.Button_US13.Size = New System.Drawing.Size(120, 50)
        Me.Button_US13.TabIndex = 7
        Me.Button_US13.Text = "แม็กนั่ม"
        Me.Button_US13.UseVisualStyleBackColor = False
        '
        'Button_US14
        '
        Me.Button_US14.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button_US14.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US14.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US14.ForeColor = System.Drawing.Color.White
        Me.Button_US14.Location = New System.Drawing.Point(381, 59)
        Me.Button_US14.Name = "Button_US14"
        Me.Button_US14.Size = New System.Drawing.Size(120, 50)
        Me.Button_US14.TabIndex = 8
        Me.Button_US14.Text = "อัดลม"
        Me.Button_US14.UseVisualStyleBackColor = False
        '
        'Button_US15
        '
        Me.Button_US15.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Button_US15.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US15.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US15.ForeColor = System.Drawing.Color.White
        Me.Button_US15.Location = New System.Drawing.Point(507, 59)
        Me.Button_US15.Name = "Button_US15"
        Me.Button_US15.Size = New System.Drawing.Size(120, 50)
        Me.Button_US15.TabIndex = 9
        Me.Button_US15.Text = "เอสแฟนซี"
        Me.Button_US15.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label_US1)
        Me.Panel2.Controls.Add(Me.lbl_cur_Group_page)
        Me.Panel2.Controls.Add(Me.btn_GroupLast)
        Me.Panel2.Controls.Add(Me.btn_GroupNext)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(687, 44)
        Me.Panel2.TabIndex = 5
        '
        'Label_US1
        '
        Me.Label_US1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US1.Location = New System.Drawing.Point(162, 0)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(194, 42)
        Me.Label_US1.TabIndex = 4
        Me.Label_US1.Text = "กลุ่มสินค้า  หน้าที่ "
        Me.Label_US1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_cur_Group_page
        '
        Me.lbl_cur_Group_page.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_cur_Group_page.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_cur_Group_page.Location = New System.Drawing.Point(349, 0)
        Me.lbl_cur_Group_page.Name = "lbl_cur_Group_page"
        Me.lbl_cur_Group_page.Size = New System.Drawing.Size(109, 42)
        Me.lbl_cur_Group_page.TabIndex = 3
        Me.lbl_cur_Group_page.Text = "1"
        Me.lbl_cur_Group_page.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_GroupLast
        '
        Me.btn_GroupLast.BackColor = System.Drawing.Color.Transparent
        Me.btn_GroupLast.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_GroupLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_GroupLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_GroupLast.Font = New System.Drawing.Font("Leelawadee UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_GroupLast.ForeColor = System.Drawing.Color.DimGray
        Me.btn_GroupLast.Image = CType(resources.GetObject("btn_GroupLast.Image"), System.Drawing.Image)
        Me.btn_GroupLast.Location = New System.Drawing.Point(0, 0)
        Me.btn_GroupLast.Name = "btn_GroupLast"
        Me.btn_GroupLast.Size = New System.Drawing.Size(162, 42)
        Me.btn_GroupLast.TabIndex = 1
        Me.btn_GroupLast.Text = "ก่อนหน้า"
        Me.btn_GroupLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_GroupLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GroupLast.UseVisualStyleBackColor = False
        '
        'btn_GroupNext
        '
        Me.btn_GroupNext.BackColor = System.Drawing.Color.Transparent
        Me.btn_GroupNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_GroupNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_GroupNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_GroupNext.Font = New System.Drawing.Font("Leelawadee UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_GroupNext.ForeColor = System.Drawing.Color.DimGray
        Me.btn_GroupNext.Image = CType(resources.GetObject("btn_GroupNext.Image"), System.Drawing.Image)
        Me.btn_GroupNext.Location = New System.Drawing.Point(523, 0)
        Me.btn_GroupNext.Name = "btn_GroupNext"
        Me.btn_GroupNext.Size = New System.Drawing.Size(162, 42)
        Me.btn_GroupNext.TabIndex = 0
        Me.btn_GroupNext.Text = "หน้าถัดไป"
        Me.btn_GroupNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_GroupNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_GroupNext.UseVisualStyleBackColor = False
        '
        'FL_Shop
        '
        Me.FL_Shop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FL_Shop.Controls.Add(Me.Button_US4)
        Me.FL_Shop.Controls.Add(Me.Button_US5)
        Me.FL_Shop.Dock = System.Windows.Forms.DockStyle.Top
        Me.FL_Shop.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FL_Shop.Location = New System.Drawing.Point(0, 0)
        Me.FL_Shop.Name = "FL_Shop"
        Me.FL_Shop.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.FL_Shop.Size = New System.Drawing.Size(689, 60)
        Me.FL_Shop.TabIndex = 7
        '
        'Button_US4
        '
        Me.Button_US4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_US4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US4.ForeColor = System.Drawing.Color.White
        Me.Button_US4.Location = New System.Drawing.Point(4, 4)
        Me.Button_US4.Name = "Button_US4"
        Me.Button_US4.Size = New System.Drawing.Size(154, 50)
        Me.Button_US4.TabIndex = 0
        Me.Button_US4.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "บาร์น้ำจุด 1"
        Me.Button_US4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_US4.UseVisualStyleBackColor = False
        '
        'Button_US5
        '
        Me.Button_US5.BackColor = System.Drawing.Color.DarkGreen
        Me.Button_US5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US5.ForeColor = System.Drawing.Color.White
        Me.Button_US5.Location = New System.Drawing.Point(164, 4)
        Me.Button_US5.Name = "Button_US5"
        Me.Button_US5.Size = New System.Drawing.Size(154, 50)
        Me.Button_US5.TabIndex = 1
        Me.Button_US5.Text = "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "บาร์น้ำจุด 2"
        Me.Button_US5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_US5.UseVisualStyleBackColor = False
        '
        'Panel_left
        '
        Me.Panel_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_left.Controls.Add(Me.Panel_US3)
        Me.Panel_left.Controls.Add(Me.Panel_US4)
        Me.Panel_left.Controls.Add(Me.Panel_US2)
        Me.Panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left.Location = New System.Drawing.Point(0, 0)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(335, 548)
        Me.Panel_left.TabIndex = 0
        '
        'Panel_US3
        '
        Me.Panel_US3.Controls.Add(Me.DGV_Product)
        Me.Panel_US3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US3.Location = New System.Drawing.Point(0, 30)
        Me.Panel_US3.Name = "Panel_US3"
        Me.Panel_US3.Size = New System.Drawing.Size(333, 148)
        Me.Panel_US3.TabIndex = 39
        '
        'DGV_Product
        '
        Me.DGV_Product.AllowUserToAddRows = False
        Me.DGV_Product.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Product.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_Product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Product.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
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
        Me.DGV_Product.Size = New System.Drawing.Size(333, 148)
        Me.DGV_Product.TabIndex = 36
        '
        'Column1
        '
        Me.Column1.HeaderText = "รายการที่"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 116
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อ"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 115
        '
        'Column3
        '
        Me.Column3.HeaderText = "สถานะ"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 116
        '
        'Panel_US4
        '
        Me.Panel_US4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_US4.Controls.Add(Me.Label_US6)
        Me.Panel_US4.Controls.Add(Me.fl_payment)
        Me.Panel_US4.Controls.Add(Me.Button_US22)
        Me.Panel_US4.Controls.Add(Me.Button_US17)
        Me.Panel_US4.Controls.Add(Me.Panel_US5)
        Me.Panel_US4.Controls.Add(Me.txt_barcode)
        Me.Panel_US4.Controls.Add(Me.Label_US5)
        Me.Panel_US4.Controls.Add(Me.Label_US4)
        Me.Panel_US4.Controls.Add(Me.txt_Amount)
        Me.Panel_US4.Controls.Add(Me.Label_US3)
        Me.Panel_US4.Controls.Add(Me.txt_qty_totel)
        Me.Panel_US4.Controls.Add(Me.chk_Print)
        Me.Panel_US4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_US4.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US4.Location = New System.Drawing.Point(0, 178)
        Me.Panel_US4.Name = "Panel_US4"
        Me.Panel_US4.Size = New System.Drawing.Size(333, 368)
        Me.Panel_US4.TabIndex = 38
        '
        'Label_US6
        '
        Me.Label_US6.BackColor = System.Drawing.Color.Snow
        Me.Label_US6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US6.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label_US6.Location = New System.Drawing.Point(2, 117)
        Me.Label_US6.Name = "Label_US6"
        Me.Label_US6.Size = New System.Drawing.Size(330, 38)
        Me.Label_US6.TabIndex = 73
        Me.Label_US6.Text = "E-WALLTE  PAYMENT"
        Me.Label_US6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_US6.Visible = False
        '
        'fl_payment
        '
        Me.fl_payment.Controls.Add(Me.btn_payment)
        Me.fl_payment.Controls.Add(Me.btn_Refund)
        Me.fl_payment.Controls.Add(Me.btn_cancel)
        Me.fl_payment.Controls.Add(Me.Button_US24)
        Me.fl_payment.Location = New System.Drawing.Point(2, 158)
        Me.fl_payment.Name = "fl_payment"
        Me.fl_payment.Size = New System.Drawing.Size(330, 133)
        Me.fl_payment.TabIndex = 72
        Me.fl_payment.Visible = False
        '
        'btn_payment
        '
        Me.btn_payment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_payment.BackColor = System.Drawing.Color.Transparent
        Me.btn_payment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_payment.FlatAppearance.BorderSize = 2
        Me.btn_payment.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_payment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_payment.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_payment.ForeColor = System.Drawing.Color.DimGray
        Me.btn_payment.Image = CType(resources.GetObject("btn_payment.Image"), System.Drawing.Image)
        Me.btn_payment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_payment.Location = New System.Drawing.Point(3, 3)
        Me.btn_payment.Name = "btn_payment"
        Me.btn_payment.Size = New System.Drawing.Size(103, 65)
        Me.btn_payment.TabIndex = 36
        Me.btn_payment.Tag = "N"
        Me.btn_payment.Text = "Payment"
        Me.btn_payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_payment.UseVisualStyleBackColor = False
        '
        'btn_Refund
        '
        Me.btn_Refund.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Refund.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Refund.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Refund.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_Refund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refund.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Refund.ForeColor = System.Drawing.Color.DimGray
        Me.btn_Refund.Image = CType(resources.GetObject("btn_Refund.Image"), System.Drawing.Image)
        Me.btn_Refund.Location = New System.Drawing.Point(112, 3)
        Me.btn_Refund.Name = "btn_Refund"
        Me.btn_Refund.Size = New System.Drawing.Size(103, 65)
        Me.btn_Refund.TabIndex = 69
        Me.btn_Refund.Text = "Refund"
        Me.btn_Refund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Refund.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.DimGray
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(221, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(103, 65)
        Me.btn_cancel.TabIndex = 70
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Button_US24
        '
        Me.Button_US24.BackColor = System.Drawing.Color.OrangeRed
        Me.Button_US24.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button_US24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US24.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US24.ForeColor = System.Drawing.Color.White
        Me.Button_US24.Image = CType(resources.GetObject("Button_US24.Image"), System.Drawing.Image)
        Me.Button_US24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_US24.Location = New System.Drawing.Point(3, 74)
        Me.Button_US24.Name = "Button_US24"
        Me.Button_US24.Size = New System.Drawing.Size(321, 51)
        Me.Button_US24.TabIndex = 40
        Me.Button_US24.Text = "รายการค้างจ่าย"
        Me.Button_US24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_US24.UseVisualStyleBackColor = False
        Me.Button_US24.Visible = False
        '
        'Button_US22
        '
        Me.Button_US22.BackColor = System.Drawing.Color.White
        Me.Button_US22.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US22.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US22.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US22.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_US22.Location = New System.Drawing.Point(268, 40)
        Me.Button_US22.Name = "Button_US22"
        Me.Button_US22.Size = New System.Drawing.Size(58, 26)
        Me.Button_US22.TabIndex = 35
        Me.Button_US22.Text = "พิมพ์ย้อนหลัง"
        Me.Button_US22.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_US22.UseVisualStyleBackColor = False
        Me.Button_US22.Visible = False
        '
        'Button_US17
        '
        Me.Button_US17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_US17.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_US17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_US17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US17.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US17.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US17.Image = CType(resources.GetObject("Button_US17.Image"), System.Drawing.Image)
        Me.Button_US17.Location = New System.Drawing.Point(268, 90)
        Me.Button_US17.Name = "Button_US17"
        Me.Button_US17.Size = New System.Drawing.Size(48, 17)
        Me.Button_US17.TabIndex = 71
        Me.Button_US17.Text = "Verify slip"
        Me.Button_US17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button_US17.UseVisualStyleBackColor = False
        Me.Button_US17.Visible = False
        '
        'Panel_US5
        '
        Me.Panel_US5.Controls.Add(Me.Button_US1)
        Me.Panel_US5.Controls.Add(Me.Button_US2)
        Me.Panel_US5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_US5.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US5.Location = New System.Drawing.Point(0, 289)
        Me.Panel_US5.Name = "Panel_US5"
        Me.Panel_US5.Size = New System.Drawing.Size(331, 77)
        Me.Panel_US5.TabIndex = 39
        '
        'Button_US1
        '
        Me.Button_US1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_US1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US1.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US1.Image = Global.TouchPOS.My.Resources.Resources.Restart40
        Me.Button_US1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_US1.Location = New System.Drawing.Point(3, 8)
        Me.Button_US1.Name = "Button_US1"
        Me.Button_US1.Size = New System.Drawing.Size(154, 74)
        Me.Button_US1.TabIndex = 33
        Me.Button_US1.Text = "เริ่มใหม่"
        Me.Button_US1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_US1.UseVisualStyleBackColor = False
        '
        'Button_US2
        '
        Me.Button_US2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_US2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US2.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US2.Image = Global.TouchPOS.My.Resources.Resources.Delete40
        Me.Button_US2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_US2.Location = New System.Drawing.Point(163, 8)
        Me.Button_US2.Name = "Button_US2"
        Me.Button_US2.Size = New System.Drawing.Size(167, 71)
        Me.Button_US2.TabIndex = 34
        Me.Button_US2.Text = "ลบรายการ"
        Me.Button_US2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_US2.UseVisualStyleBackColor = False
        '
        'txt_barcode
        '
        Me.txt_barcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_barcode.BackColor = System.Drawing.Color.White
        Me.txt_barcode.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_barcode.ForeColor = System.Drawing.Color.DimGray
        Me.txt_barcode.Location = New System.Drawing.Point(3, 71)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(323, 52)
        Me.txt_barcode.TabIndex = 6
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
        Me.txt_barcode.US_foreColor_Enable = System.Drawing.Color.White
        Me.txt_barcode.US_Number = False
        Me.txt_barcode.US_Tag2 = ""
        Me.txt_barcode.US_value = Nothing
        '
        'Label_US5
        '
        Me.Label_US5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US5.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US5.Location = New System.Drawing.Point(282, 2)
        Me.Label_US5.Name = "Label_US5"
        Me.Label_US5.Size = New System.Drawing.Size(48, 35)
        Me.Label_US5.TabIndex = 5
        Me.Label_US5.Text = "บาท"
        Me.Label_US5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_US4
        '
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US4.Location = New System.Drawing.Point(98, 2)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(82, 35)
        Me.Label_US4.TabIndex = 4
        Me.Label_US4.Text = "รายการ"
        Me.Label_US4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Amount
        '
        Me.txt_Amount.BackColor = System.Drawing.Color.DimGray
        Me.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Amount.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_Amount.ForeColor = System.Drawing.Color.White
        Me.txt_Amount.Location = New System.Drawing.Point(177, 2)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.ReadOnly = True
        Me.txt_Amount.Size = New System.Drawing.Size(106, 42)
        Me.txt_Amount.TabIndex = 3
        Me.txt_Amount.Text = "0.00"
        Me.txt_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Amount.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_Amount.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_Amount.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_Amount.US_Color_Enable = System.Drawing.Color.White
        Me.txt_Amount.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_Amount.Us_dataBindings_TOP = 10
        Me.txt_Amount.US_Enable = False
        Me.txt_Amount.US_foreColor_Didable = System.Drawing.Color.Black
        Me.txt_Amount.US_foreColor_Enable = System.Drawing.Color.DarkGray
        Me.txt_Amount.US_Number = True
        Me.txt_Amount.US_Tag2 = ""
        Me.txt_Amount.US_value = Nothing
        '
        'Label_US3
        '
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.DimGray
        Me.Label_US3.Location = New System.Drawing.Point(6, 4)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(49, 35)
        Me.Label_US3.TabIndex = 2
        Me.Label_US3.Text = "รวม"
        Me.Label_US3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_qty_totel
        '
        Me.txt_qty_totel.BackColor = System.Drawing.Color.DimGray
        Me.txt_qty_totel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty_totel.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_qty_totel.ForeColor = System.Drawing.Color.White
        Me.txt_qty_totel.Location = New System.Drawing.Point(49, 4)
        Me.txt_qty_totel.Name = "txt_qty_totel"
        Me.txt_qty_totel.ReadOnly = True
        Me.txt_qty_totel.Size = New System.Drawing.Size(43, 42)
        Me.txt_qty_totel.TabIndex = 1
        Me.txt_qty_totel.Text = "0"
        Me.txt_qty_totel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_qty_totel.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_qty_totel.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_qty_totel.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_qty_totel.US_Color_Enable = System.Drawing.Color.White
        Me.txt_qty_totel.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_qty_totel.Us_dataBindings_TOP = 10
        Me.txt_qty_totel.US_Enable = False
        Me.txt_qty_totel.US_foreColor_Didable = System.Drawing.Color.Black
        Me.txt_qty_totel.US_foreColor_Enable = System.Drawing.Color.DarkGray
        Me.txt_qty_totel.US_Number = True
        Me.txt_qty_totel.US_Tag2 = ""
        Me.txt_qty_totel.US_value = Nothing
        '
        'chk_Print
        '
        Me.chk_Print.AutoSize = True
        Me.chk_Print.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_Print.ForeColor = System.Drawing.Color.DimGray
        Me.chk_Print.Location = New System.Drawing.Point(10, 44)
        Me.chk_Print.Name = "chk_Print"
        Me.chk_Print.Size = New System.Drawing.Size(163, 32)
        Me.chk_Print.TabIndex = 0
        Me.chk_Print.Text = "ไม่มีเครื่องพิมพ์"
        Me.chk_Print.UseVisualStyleBackColor = True
        '
        'Panel_US2
        '
        Me.Panel_US2.Controls.Add(Me.Panel_US1)
        Me.Panel_US2.Controls.Add(Me.lbl_docno)
        Me.Panel_US2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_US2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US2.Location = New System.Drawing.Point(0, 0)
        Me.Panel_US2.Name = "Panel_US2"
        Me.Panel_US2.Size = New System.Drawing.Size(333, 30)
        Me.Panel_US2.TabIndex = 35
        '
        'Panel_US1
        '
        Me.Panel_US1.Controls.Add(Me.txt_lcd)
        Me.Panel_US1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US1.Location = New System.Drawing.Point(246, 0)
        Me.Panel_US1.Name = "Panel_US1"
        Me.Panel_US1.Size = New System.Drawing.Size(97, 24)
        Me.Panel_US1.TabIndex = 34
        Me.Panel_US1.Visible = False
        '
        'txt_lcd
        '
        Me.txt_lcd.BackColor = System.Drawing.Color.DimGray
        Me.txt_lcd.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lcd.ForeColor = System.Drawing.Color.White
        Me.txt_lcd.Location = New System.Drawing.Point(3, 0)
        Me.txt_lcd.Name = "txt_lcd"
        Me.txt_lcd.ReadOnly = True
        Me.txt_lcd.Size = New System.Drawing.Size(44, 52)
        Me.txt_lcd.TabIndex = 33
        Me.txt_lcd.Text = "LCD"
        Me.txt_lcd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_lcd.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_lcd.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_lcd.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_lcd.US_Color_Enable = System.Drawing.Color.White
        Me.txt_lcd.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_lcd.Us_dataBindings_TOP = 10
        Me.txt_lcd.US_Enable = False
        Me.txt_lcd.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_lcd.US_foreColor_Enable = System.Drawing.Color.DarkGray
        Me.txt_lcd.US_Number = False
        Me.txt_lcd.US_Tag2 = ""
        Me.txt_lcd.US_value = Nothing
        Me.txt_lcd.Visible = False
        '
        'lbl_docno
        '
        Me.lbl_docno.BackColor = System.Drawing.Color.Orange
        Me.lbl_docno.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_docno.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_docno.ForeColor = System.Drawing.Color.White
        Me.lbl_docno.Location = New System.Drawing.Point(0, 0)
        Me.lbl_docno.Name = "lbl_docno"
        Me.lbl_docno.Size = New System.Drawing.Size(333, 27)
        Me.lbl_docno.TabIndex = 0
        Me.lbl_docno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_shopname
        '
        Me.lbl_shopname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_shopname.BackColor = System.Drawing.Color.Orange
        Me.lbl_shopname.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_shopname.ForeColor = System.Drawing.Color.White
        Me.lbl_shopname.Location = New System.Drawing.Point(60, 0)
        Me.lbl_shopname.Name = "lbl_shopname"
        Me.lbl_shopname.Size = New System.Drawing.Size(605, 39)
        Me.lbl_shopname.TabIndex = 1
        Me.lbl_shopname.Text = "บาร์น้ำจุด 1"
        Me.lbl_shopname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_US8
        '
        Me.Panel_US8.Controls.Add(Me.Panel5)
        Me.Panel_US8.Controls.Add(Me.Button_US23)
        Me.Panel_US8.Controls.Add(Me.lbl_shopname)
        Me.Panel_US8.Controls.Add(Me.Button_US3)
        Me.Panel_US8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_US8.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US8.Location = New System.Drawing.Point(0, 0)
        Me.Panel_US8.Name = "Panel_US8"
        Me.Panel_US8.Size = New System.Drawing.Size(1026, 40)
        Me.Panel_US8.TabIndex = 10
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Orange
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(61, 40)
        Me.Panel5.TabIndex = 36
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(55, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'Button_US23
        '
        Me.Button_US23.BackColor = System.Drawing.Color.Transparent
        Me.Button_US23.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button_US23.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US23.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US23.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US23.Image = CType(resources.GetObject("Button_US23.Image"), System.Drawing.Image)
        Me.Button_US23.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_US23.Location = New System.Drawing.Point(671, 0)
        Me.Button_US23.Name = "Button_US23"
        Me.Button_US23.Size = New System.Drawing.Size(176, 40)
        Me.Button_US23.TabIndex = 33
        Me.Button_US23.Text = "ย่อโปรแกรม"
        Me.Button_US23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_US23.UseVisualStyleBackColor = False
        '
        'Button_US3
        '
        Me.Button_US3.BackColor = System.Drawing.Color.Transparent
        Me.Button_US3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button_US3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US3.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US3.Image = CType(resources.GetObject("Button_US3.Image"), System.Drawing.Image)
        Me.Button_US3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_US3.Location = New System.Drawing.Point(847, 0)
        Me.Button_US3.Name = "Button_US3"
        Me.Button_US3.Size = New System.Drawing.Size(179, 40)
        Me.Button_US3.TabIndex = 32
        Me.Button_US3.Text = "ปิดโปรแกรม"
        Me.Button_US3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_US3.UseVisualStyleBackColor = False
        '
        'Panel_US9
        '
        Me.Panel_US9.Controls.Add(Me.Panel4)
        Me.Panel_US9.Controls.Add(Me.Panel_left)
        Me.Panel_US9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US9.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US9.Location = New System.Drawing.Point(0, 40)
        Me.Panel_US9.Name = "Panel_US9"
        Me.Panel_US9.Size = New System.Drawing.Size(1026, 548)
        Me.Panel_US9.TabIndex = 37
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel_Right)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(335, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(691, 548)
        Me.Panel4.TabIndex = 4
        '
        'Timer_Reconnect
        '
        Me.Timer_Reconnect.Interval = 1000
        '
        'Timer_Reset
        '
        Me.Timer_Reset.Interval = 1000
        '
        'F_Main_Sale
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1026, 618)
        Me.Controls.Add(Me.Panel_US9)
        Me.Controls.Add(Me.Panel_US8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Main_Sale"
        Me.Text = "ขายสินค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.txt_time.ResumeLayout(False)
        Me.txt_time.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_Right.ResumeLayout(False)
        Me.FL_Items.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel_US6.ResumeLayout(False)
        Me.Panel_US7.ResumeLayout(False)
        Me.Fl_shopButton.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.FL_Shop.ResumeLayout(False)
        Me.Panel_left.ResumeLayout(False)
        Me.Panel_US3.ResumeLayout(False)
        CType(Me.DGV_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_US4.ResumeLayout(False)
        Me.Panel_US4.PerformLayout()
        Me.fl_payment.ResumeLayout(False)
        Me.Panel_US5.ResumeLayout(False)
        Me.Panel_US2.ResumeLayout(False)
        Me.Panel_US1.ResumeLayout(False)
        Me.Panel_US1.PerformLayout()
        Me.Panel_US8.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_US9.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_left As Panel
    Friend WithEvents txt_lcd As Control_us.Textbox_UC
    Friend WithEvents Button_US3 As Control_us.Button_US
    Friend WithEvents Panel_US1 As Control_us.Panel_US
    Friend WithEvents Panel_US2 As Control_us.Panel_US
    Friend WithEvents lbl_shopname As Control_us.Label_US
    Friend WithEvents lbl_docno As Control_us.Label_US
    Friend WithEvents DGV_Product As Control_us.DataGridView_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel_US4 As Control_us.Panel_US
    Friend WithEvents chk_Print As Control_us.CheckBox1_US
    Friend WithEvents Label_US5 As Control_us.Label_US
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents txt_Amount As Control_us.Textbox_UC
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents txt_qty_totel As Control_us.Textbox_UC
    Friend WithEvents Panel_US3 As Control_us.Panel_US
    Friend WithEvents txt_barcode As Control_us.Textbox_UC
    Friend WithEvents Button_US2 As Control_us.Button_US
    Friend WithEvents Button_US1 As Control_us.Button_US
    Friend WithEvents Button_US5 As Control_us.Button_US
    Friend WithEvents Button_US4 As Control_us.Button_US
    Friend WithEvents Button_US6 As Control_us.Button_US
    Friend WithEvents Button_US7 As Control_us.Button_US
    Friend WithEvents Fl_shopButton As Control_us.FlowLayoutPanel_US
    Friend WithEvents Button_US8 As Control_us.Button_US
    Friend WithEvents Button_US9 As Control_us.Button_US
    Friend WithEvents Button_US10 As Control_us.Button_US
    Friend WithEvents Button_US11 As Control_us.Button_US
    Friend WithEvents Button_US12 As Control_us.Button_US
    Friend WithEvents Button_US13 As Control_us.Button_US
    Friend WithEvents Button_US14 As Control_us.Button_US
    Friend WithEvents Button_US15 As Control_us.Button_US
    Friend WithEvents txt_time As ToolStrip
    Friend WithEvents txt_IP As ToolStripLabel
    Friend WithEvents Panel_Right As Control_us.Panel_US
    Friend WithEvents Panel_US6 As Control_us.Panel_US
    Friend WithEvents FL_Shop As Control_us.FlowLayoutPanel_US
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txtdatetime As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txt_shopcode As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents txt_shopname As ToolStripLabel
    Friend WithEvents txt_totel As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Timer_setfocus As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button_US22 As Control_us.Button_US
    Friend WithEvents btn_payment As Control_us.Button_US
    Friend WithEvents Panel_US5 As Control_us.Panel_US
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FL_Items As Control_us.FlowLayoutPanel_US
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_GroupNext As Control_us.Button_US
    Friend WithEvents btn_GroupLast As Control_us.Button_US
    Friend WithEvents lbl_cur_Group_page As Control_us.Label_US
    Friend WithEvents lbl_cur_Items_page As Control_us.Label_US
    Friend WithEvents btn_ItemsLast As Control_us.Button_US
    Friend WithEvents btn_ItemsNext As Control_us.Button_US
    Friend WithEvents Panel_US7 As Control_us.Panel_US
    Friend WithEvents Panel_US8 As Control_us.Panel_US
    Friend WithEvents Panel_US9 As Control_us.Panel_US
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button_US23 As Control_us.Button_US
    Friend WithEvents lbl_reset As ToolStripLabel
    Friend WithEvents Timer_Reconnect As Timer
    Friend WithEvents stataus_disconnect As ToolStripButton
    Friend WithEvents stataus_connect As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents Timer_Reset As Timer
    Friend WithEvents lbl_time As ToolStripLabel
    Friend WithEvents txt_version As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents Button_US24 As Control_us.Button_US
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents UC_Product_Items1 As UC_Product_Items
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents btn_Refund As Control_us.Button_US
    Friend WithEvents btn_cancel As Control_us.Button_US
    Friend WithEvents Label_US6 As Control_us.Label_US
    Friend WithEvents fl_payment As FlowLayoutPanel
    Friend WithEvents Button_US17 As Control_us.Button_US
End Class

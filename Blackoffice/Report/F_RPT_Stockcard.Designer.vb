<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_RPT_Stockcard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_RPT_Stockcard))
        Me.ToolStrip_top = New System.Windows.Forms.ToolStrip()
        Me.btn_print = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox_US1 = New Control_us.GroupBox_US()
        Me.Label_US5 = New Control_us.Label_US()
        Me.dtp_dateEnd = New Control_us.DateTimePicker_US()
        Me.chk_datefillter = New Control_us.CheckBox1_US()
        Me.Label_US3 = New Control_us.Label_US()
        Me.dtp_dateStart = New Control_us.DateTimePicker_US()
        Me.btn_clear = New Control_us.Button_US()
        Me.btn_scr_Product2 = New Control_us.Button_US()
        Me.btn_scr_Product1 = New Control_us.Button_US()
        Me.Label_US2 = New Control_us.Label_US()
        Me.pname2 = New Control_us.Textbox_UC()
        Me.pcode2 = New Control_us.Textbox_UC()
        Me.pname1 = New Control_us.Textbox_UC()
        Me.pcode1 = New Control_us.Textbox_UC()
        Me.Label_US1 = New Control_us.Label_US()
        Me.STCODE = New Control_us.Combobox_US()
        Me.Label_US4 = New Control_us.Label_US()
        Me.ToolStrip_top.SuspendLayout()
        Me.GroupBox_US1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip_top
        '
        Me.ToolStrip_top.AutoSize = False
        Me.ToolStrip_top.BackColor = System.Drawing.Color.White
        Me.ToolStrip_top.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip_top.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_print, Me.btn_close})
        Me.ToolStrip_top.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_top.Name = "ToolStrip_top"
        Me.ToolStrip_top.Size = New System.Drawing.Size(863, 42)
        Me.ToolStrip_top.TabIndex = 22
        Me.ToolStrip_top.Text = "ToolStrip1"
        '
        'btn_print
        '
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(87, 39)
        Me.btn_print.Tag = "50"
        Me.btn_print.Text = "พิมพ์รายงาน"
        '
        'btn_close
        '
        Me.btn_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(85, 39)
        Me.btn_close.Tag = "50"
        Me.btn_close.Text = "ออกจากเมนู"
        '
        'GroupBox_US1
        '
        Me.GroupBox_US1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_US1.Controls.Add(Me.Label_US5)
        Me.GroupBox_US1.Controls.Add(Me.dtp_dateEnd)
        Me.GroupBox_US1.Controls.Add(Me.chk_datefillter)
        Me.GroupBox_US1.Controls.Add(Me.Label_US3)
        Me.GroupBox_US1.Controls.Add(Me.dtp_dateStart)
        Me.GroupBox_US1.Controls.Add(Me.btn_clear)
        Me.GroupBox_US1.Controls.Add(Me.btn_scr_Product2)
        Me.GroupBox_US1.Controls.Add(Me.btn_scr_Product1)
        Me.GroupBox_US1.Controls.Add(Me.Label_US2)
        Me.GroupBox_US1.Controls.Add(Me.pname2)
        Me.GroupBox_US1.Controls.Add(Me.pcode2)
        Me.GroupBox_US1.Controls.Add(Me.pname1)
        Me.GroupBox_US1.Controls.Add(Me.pcode1)
        Me.GroupBox_US1.Controls.Add(Me.Label_US1)
        Me.GroupBox_US1.Controls.Add(Me.STCODE)
        Me.GroupBox_US1.Controls.Add(Me.Label_US4)
        Me.GroupBox_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox_US1.Location = New System.Drawing.Point(0, 45)
        Me.GroupBox_US1.Name = "GroupBox_US1"
        Me.GroupBox_US1.Size = New System.Drawing.Size(851, 270)
        Me.GroupBox_US1.TabIndex = 23
        Me.GroupBox_US1.TabStop = False
        Me.GroupBox_US1.Text = "Report Fillter"
        '
        'Label_US5
        '
        Me.Label_US5.AutoSize = True
        Me.Label_US5.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US5.ForeColor = System.Drawing.Color.Black
        Me.Label_US5.Location = New System.Drawing.Point(311, 74)
        Me.Label_US5.Name = "Label_US5"
        Me.Label_US5.Size = New System.Drawing.Size(44, 19)
        Me.Label_US5.TabIndex = 28
        Me.Label_US5.Text = "ถึงวันที่"
        '
        'dtp_dateEnd
        '
        Me.dtp_dateEnd.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dateEnd.Location = New System.Drawing.Point(376, 68)
        Me.dtp_dateEnd.Name = "dtp_dateEnd"
        Me.dtp_dateEnd.Size = New System.Drawing.Size(119, 25)
        Me.dtp_dateEnd.TabIndex = 27
        '
        'chk_datefillter
        '
        Me.chk_datefillter.AutoSize = True
        Me.chk_datefillter.Checked = True
        Me.chk_datefillter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_datefillter.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_datefillter.Location = New System.Drawing.Point(132, 41)
        Me.chk_datefillter.Name = "chk_datefillter"
        Me.chk_datefillter.Size = New System.Drawing.Size(103, 23)
        Me.chk_datefillter.TabIndex = 26
        Me.chk_datefillter.Text = "ใช้ตัวกรองวันที่"
        Me.chk_datefillter.UseVisualStyleBackColor = True
        Me.chk_datefillter.Visible = False
        '
        'Label_US3
        '
        Me.Label_US3.AutoSize = True
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.Black
        Me.Label_US3.Location = New System.Drawing.Point(67, 76)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(59, 19)
        Me.Label_US3.TabIndex = 25
        Me.Label_US3.Text = "ตั้งแต่วันที่"
        '
        'dtp_dateStart
        '
        Me.dtp_dateStart.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_dateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_dateStart.Location = New System.Drawing.Point(132, 70)
        Me.dtp_dateStart.Name = "dtp_dateStart"
        Me.dtp_dateStart.Size = New System.Drawing.Size(119, 25)
        Me.dtp_dateStart.TabIndex = 24
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.White
        Me.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(257, 70)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(51, 25)
        Me.btn_clear.TabIndex = 23
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_scr_Product2
        '
        Me.btn_scr_Product2.BackColor = System.Drawing.Color.White
        Me.btn_scr_Product2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_scr_Product2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_scr_Product2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_scr_Product2.ForeColor = System.Drawing.Color.Black
        Me.btn_scr_Product2.Image = CType(resources.GetObject("btn_scr_Product2.Image"), System.Drawing.Image)
        Me.btn_scr_Product2.Location = New System.Drawing.Point(594, 163)
        Me.btn_scr_Product2.Name = "btn_scr_Product2"
        Me.btn_scr_Product2.Size = New System.Drawing.Size(51, 25)
        Me.btn_scr_Product2.TabIndex = 22
        Me.btn_scr_Product2.UseVisualStyleBackColor = False
        '
        'btn_scr_Product1
        '
        Me.btn_scr_Product1.BackColor = System.Drawing.Color.White
        Me.btn_scr_Product1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_scr_Product1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_scr_Product1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_scr_Product1.ForeColor = System.Drawing.Color.Black
        Me.btn_scr_Product1.Image = CType(resources.GetObject("btn_scr_Product1.Image"), System.Drawing.Image)
        Me.btn_scr_Product1.Location = New System.Drawing.Point(594, 132)
        Me.btn_scr_Product1.Name = "btn_scr_Product1"
        Me.btn_scr_Product1.Size = New System.Drawing.Size(51, 25)
        Me.btn_scr_Product1.TabIndex = 21
        Me.btn_scr_Product1.UseVisualStyleBackColor = False
        '
        'Label_US2
        '
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Black
        Me.Label_US2.Location = New System.Drawing.Point(32, 166)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(94, 19)
        Me.Label_US2.TabIndex = 20
        Me.Label_US2.Text = "ถึงสินค้า"
        '
        'pname2
        '
        Me.pname2.BackColor = System.Drawing.Color.Gainsboro
        Me.pname2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pname2.ForeColor = System.Drawing.Color.DarkGreen
        Me.pname2.Location = New System.Drawing.Point(266, 163)
        Me.pname2.Name = "pname2"
        Me.pname2.ReadOnly = True
        Me.pname2.Size = New System.Drawing.Size(322, 25)
        Me.pname2.TabIndex = 19
        Me.pname2.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.pname2.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.pname2.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.pname2.US_Color_Enable = System.Drawing.Color.White
        Me.pname2.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.pname2.Us_dataBindings_TOP = 10
        Me.pname2.US_Enable = False
        Me.pname2.US_foreColor_Didable = System.Drawing.Color.White
        Me.pname2.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.pname2.US_Number = False
        Me.pname2.US_Tag2 = ""
        Me.pname2.US_value = Nothing
        '
        'pcode2
        '
        Me.pcode2.BackColor = System.Drawing.Color.Gainsboro
        Me.pcode2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pcode2.ForeColor = System.Drawing.Color.DarkGreen
        Me.pcode2.Location = New System.Drawing.Point(132, 163)
        Me.pcode2.Name = "pcode2"
        Me.pcode2.ReadOnly = True
        Me.pcode2.Size = New System.Drawing.Size(128, 25)
        Me.pcode2.TabIndex = 18
        Me.pcode2.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.pcode2.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.pcode2.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.pcode2.US_Color_Enable = System.Drawing.Color.White
        Me.pcode2.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.pcode2.Us_dataBindings_TOP = 10
        Me.pcode2.US_Enable = False
        Me.pcode2.US_foreColor_Didable = System.Drawing.Color.White
        Me.pcode2.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.pcode2.US_Number = False
        Me.pcode2.US_Tag2 = ""
        Me.pcode2.US_value = Nothing
        '
        'pname1
        '
        Me.pname1.BackColor = System.Drawing.Color.Gainsboro
        Me.pname1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pname1.ForeColor = System.Drawing.Color.DarkGreen
        Me.pname1.Location = New System.Drawing.Point(266, 132)
        Me.pname1.Name = "pname1"
        Me.pname1.ReadOnly = True
        Me.pname1.Size = New System.Drawing.Size(322, 25)
        Me.pname1.TabIndex = 17
        Me.pname1.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.pname1.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.pname1.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.pname1.US_Color_Enable = System.Drawing.Color.White
        Me.pname1.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.pname1.Us_dataBindings_TOP = 10
        Me.pname1.US_Enable = False
        Me.pname1.US_foreColor_Didable = System.Drawing.Color.White
        Me.pname1.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.pname1.US_Number = False
        Me.pname1.US_Tag2 = ""
        Me.pname1.US_value = Nothing
        '
        'pcode1
        '
        Me.pcode1.BackColor = System.Drawing.Color.Gainsboro
        Me.pcode1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.pcode1.ForeColor = System.Drawing.Color.DarkGreen
        Me.pcode1.Location = New System.Drawing.Point(132, 132)
        Me.pcode1.Name = "pcode1"
        Me.pcode1.ReadOnly = True
        Me.pcode1.Size = New System.Drawing.Size(128, 25)
        Me.pcode1.TabIndex = 16
        Me.pcode1.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.pcode1.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.pcode1.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.pcode1.US_Color_Enable = System.Drawing.Color.White
        Me.pcode1.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.pcode1.Us_dataBindings_TOP = 10
        Me.pcode1.US_Enable = False
        Me.pcode1.US_foreColor_Didable = System.Drawing.Color.White
        Me.pcode1.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.pcode1.US_Number = False
        Me.pcode1.US_Tag2 = ""
        Me.pcode1.US_value = Nothing
        '
        'Label_US1
        '
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.Black
        Me.Label_US1.Location = New System.Drawing.Point(32, 135)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(94, 19)
        Me.Label_US1.TabIndex = 15
        Me.Label_US1.Text = "ตั้งแต่สินค้า"
        '
        'STCODE
        '
        Me.STCODE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.STCODE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.STCODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.STCODE.FormattingEnabled = True
        Me.STCODE.Location = New System.Drawing.Point(132, 101)
        Me.STCODE.Name = "STCODE"
        Me.STCODE.Size = New System.Drawing.Size(456, 25)
        Me.STCODE.TabIndex = 14
        '
        'Label_US4
        '
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.Black
        Me.Label_US4.Location = New System.Drawing.Point(32, 104)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(72, 19)
        Me.Label_US4.TabIndex = 13
        Me.Label_US4.Text = "คลัง"
        '
        'F_RPT_Stockcard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(863, 447)
        Me.Controls.Add(Me.GroupBox_US1)
        Me.Controls.Add(Me.ToolStrip_top)
        Me.Name = "F_RPT_Stockcard"
        Me.TabText = "F_Stockcard"
        Me.Text = "F_Stockcard"
        Me.ToolStrip_top.ResumeLayout(False)
        Me.ToolStrip_top.PerformLayout()
        Me.GroupBox_US1.ResumeLayout(False)
        Me.GroupBox_US1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip_top As ToolStrip
    Friend WithEvents btn_print As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents GroupBox_US1 As Control_us.GroupBox_US
    Friend WithEvents btn_clear As Control_us.Button_US
    Friend WithEvents btn_scr_Product2 As Control_us.Button_US
    Friend WithEvents btn_scr_Product1 As Control_us.Button_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents pname2 As Control_us.Textbox_UC
    Friend WithEvents pcode2 As Control_us.Textbox_UC
    Friend WithEvents pname1 As Control_us.Textbox_UC
    Friend WithEvents pcode1 As Control_us.Textbox_UC
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents STCODE As Control_us.Combobox_US
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents dtp_dateStart As Control_us.DateTimePicker_US
    Friend WithEvents Label_US5 As Control_us.Label_US
    Friend WithEvents dtp_dateEnd As Control_us.DateTimePicker_US
    Friend WithEvents chk_datefillter As Control_us.CheckBox1_US
End Class

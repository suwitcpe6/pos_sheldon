<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_RPT_Receive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_RPT_Receive))
        Me.GroupBox_US1 = New Control_us.GroupBox_US()
        Me.PERCODE = New Control_us.Combobox_US()
        Me.Label_US4 = New Control_us.Label_US()
        Me.Label_US3 = New Control_us.Label_US()
        Me.Label_US2 = New Control_us.Label_US()
        Me.chk_datefillter = New Control_us.CheckBox1_US()
        Me.Label_US1 = New Control_us.Label_US()
        Me.ref_docno = New Control_us.Textbox_UC()
        Me.docno = New Control_us.Textbox_UC()
        Me.dtp_date = New Control_us.DateTimePicker_US()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip_top = New System.Windows.Forms.ToolStrip()
        Me.btn_print = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox_US1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip_top.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_US1
        '
        Me.GroupBox_US1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_US1.Controls.Add(Me.PERCODE)
        Me.GroupBox_US1.Controls.Add(Me.Label_US4)
        Me.GroupBox_US1.Controls.Add(Me.Label_US3)
        Me.GroupBox_US1.Controls.Add(Me.Label_US2)
        Me.GroupBox_US1.Controls.Add(Me.chk_datefillter)
        Me.GroupBox_US1.Controls.Add(Me.Label_US1)
        Me.GroupBox_US1.Controls.Add(Me.ref_docno)
        Me.GroupBox_US1.Controls.Add(Me.docno)
        Me.GroupBox_US1.Controls.Add(Me.dtp_date)
        Me.GroupBox_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox_US1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox_US1.Name = "GroupBox_US1"
        Me.GroupBox_US1.Size = New System.Drawing.Size(903, 270)
        Me.GroupBox_US1.TabIndex = 0
        Me.GroupBox_US1.TabStop = False
        Me.GroupBox_US1.Text = "Report Fillter"
        '
        'PERCODE
        '
        Me.PERCODE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PERCODE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PERCODE.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PERCODE.FormattingEnabled = True
        Me.PERCODE.Location = New System.Drawing.Point(153, 180)
        Me.PERCODE.Name = "PERCODE"
        Me.PERCODE.Size = New System.Drawing.Size(426, 25)
        Me.PERCODE.TabIndex = 14
        '
        'Label_US4
        '
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.Black
        Me.Label_US4.Location = New System.Drawing.Point(39, 183)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(72, 19)
        Me.Label_US4.TabIndex = 13
        Me.Label_US4.Text = "ผู้ทำรายการ"
        '
        'Label_US3
        '
        Me.Label_US3.AutoSize = True
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.Black
        Me.Label_US3.Location = New System.Drawing.Point(39, 152)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(67, 19)
        Me.Label_US3.TabIndex = 6
        Me.Label_US3.Text = "เลขที่อ้างอิง"
        '
        'Label_US2
        '
        Me.Label_US2.AutoSize = True
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Black
        Me.Label_US2.Location = New System.Drawing.Point(39, 121)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(76, 19)
        Me.Label_US2.TabIndex = 5
        Me.Label_US2.Text = "เลขที่เอกสาร"
        '
        'chk_datefillter
        '
        Me.chk_datefillter.AutoSize = True
        Me.chk_datefillter.Checked = True
        Me.chk_datefillter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_datefillter.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_datefillter.Location = New System.Drawing.Point(153, 58)
        Me.chk_datefillter.Name = "chk_datefillter"
        Me.chk_datefillter.Size = New System.Drawing.Size(103, 23)
        Me.chk_datefillter.TabIndex = 4
        Me.chk_datefillter.Text = "ใช้ตัวกรองวันที่"
        Me.chk_datefillter.UseVisualStyleBackColor = True
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.Black
        Me.Label_US1.Location = New System.Drawing.Point(116, 87)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(31, 19)
        Me.Label_US1.TabIndex = 3
        Me.Label_US1.Text = "วันที่"
        '
        'ref_docno
        '
        Me.ref_docno.BackColor = System.Drawing.Color.White
        Me.ref_docno.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ref_docno.ForeColor = System.Drawing.Color.DarkGreen
        Me.ref_docno.Location = New System.Drawing.Point(153, 149)
        Me.ref_docno.Name = "ref_docno"
        Me.ref_docno.Size = New System.Drawing.Size(426, 25)
        Me.ref_docno.TabIndex = 2
        Me.ref_docno.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.ref_docno.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.ref_docno.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.ref_docno.US_Color_Enable = System.Drawing.Color.White
        Me.ref_docno.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.ref_docno.Us_dataBindings_TOP = 10
        Me.ref_docno.US_Enable = True
        Me.ref_docno.US_foreColor_Didable = System.Drawing.Color.White
        Me.ref_docno.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.ref_docno.US_Number = False
        Me.ref_docno.US_Tag2 = ""
        Me.ref_docno.US_value = Nothing
        '
        'docno
        '
        Me.docno.BackColor = System.Drawing.Color.White
        Me.docno.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.docno.ForeColor = System.Drawing.Color.DarkGreen
        Me.docno.Location = New System.Drawing.Point(153, 118)
        Me.docno.Name = "docno"
        Me.docno.Size = New System.Drawing.Size(426, 25)
        Me.docno.TabIndex = 1
        Me.docno.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.docno.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.docno.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.docno.US_Color_Enable = System.Drawing.Color.White
        Me.docno.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.docno.Us_dataBindings_TOP = 10
        Me.docno.US_Enable = True
        Me.docno.US_foreColor_Didable = System.Drawing.Color.White
        Me.docno.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.docno.US_Number = False
        Me.docno.US_Tag2 = ""
        Me.docno.US_value = Nothing
        '
        'dtp_date
        '
        Me.dtp_date.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date.Location = New System.Drawing.Point(153, 87)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(200, 25)
        Me.dtp_date.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip_top)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(927, 42)
        Me.Panel2.TabIndex = 23
        '
        'ToolStrip_top
        '
        Me.ToolStrip_top.AutoSize = False
        Me.ToolStrip_top.BackColor = System.Drawing.Color.White
        Me.ToolStrip_top.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip_top.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip_top.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_print, Me.btn_close})
        Me.ToolStrip_top.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_top.Name = "ToolStrip_top"
        Me.ToolStrip_top.Size = New System.Drawing.Size(927, 42)
        Me.ToolStrip_top.TabIndex = 20
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
        'F_RPT_Receive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 498)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox_US1)
        Me.Name = "F_RPT_Receive"
        Me.TabText = "F_RPT_Receive"
        Me.Text = "F_RPT_Receive"
        Me.GroupBox_US1.ResumeLayout(False)
        Me.GroupBox_US1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip_top.ResumeLayout(False)
        Me.ToolStrip_top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_US1 As Control_us.GroupBox_US
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents chk_datefillter As Control_us.CheckBox1_US
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents ref_docno As Control_us.Textbox_UC
    Friend WithEvents docno As Control_us.Textbox_UC
    Friend WithEvents dtp_date As Control_us.DateTimePicker_US
    Friend WithEvents PERCODE As Control_us.Combobox_US
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip_top As ToolStrip
    Friend WithEvents btn_print As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
End Class

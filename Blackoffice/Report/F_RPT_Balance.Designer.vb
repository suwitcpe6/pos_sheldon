<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_RPT_Balance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_RPT_Balance))
        Me.ToolStrip_top = New System.Windows.Forms.ToolStrip()
        Me.btn_print = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox_US1 = New Control_us.GroupBox_US()
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
        Me.btn_clear = New Control_us.Button_US()
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
        Me.ToolStrip_top.Size = New System.Drawing.Size(800, 42)
        Me.ToolStrip_top.TabIndex = 21
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
        Me.GroupBox_US1.Size = New System.Drawing.Size(800, 270)
        Me.GroupBox_US1.TabIndex = 22
        Me.GroupBox_US1.TabStop = False
        Me.GroupBox_US1.Text = "Report Fillter"
        '
        'btn_scr_Product2
        '
        Me.btn_scr_Product2.BackColor = System.Drawing.Color.White
        Me.btn_scr_Product2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_scr_Product2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_scr_Product2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_scr_Product2.ForeColor = System.Drawing.Color.Black
        Me.btn_scr_Product2.Image = CType(resources.GetObject("btn_scr_Product2.Image"), System.Drawing.Image)
        Me.btn_scr_Product2.Location = New System.Drawing.Point(594, 104)
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
        Me.btn_scr_Product1.Location = New System.Drawing.Point(594, 73)
        Me.btn_scr_Product1.Name = "btn_scr_Product1"
        Me.btn_scr_Product1.Size = New System.Drawing.Size(51, 25)
        Me.btn_scr_Product1.TabIndex = 21
        Me.btn_scr_Product1.UseVisualStyleBackColor = False
        '
        'Label_US2
        '
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Black
        Me.Label_US2.Location = New System.Drawing.Point(32, 107)
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
        Me.pname2.Location = New System.Drawing.Point(266, 104)
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
        Me.pcode2.Location = New System.Drawing.Point(132, 104)
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
        Me.pname1.Location = New System.Drawing.Point(266, 73)
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
        Me.pcode1.Location = New System.Drawing.Point(132, 73)
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
        Me.Label_US1.Location = New System.Drawing.Point(32, 76)
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
        Me.STCODE.Location = New System.Drawing.Point(132, 39)
        Me.STCODE.Name = "STCODE"
        Me.STCODE.Size = New System.Drawing.Size(456, 25)
        Me.STCODE.TabIndex = 14
        '
        'Label_US4
        '
        Me.Label_US4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US4.ForeColor = System.Drawing.Color.Black
        Me.Label_US4.Location = New System.Drawing.Point(32, 42)
        Me.Label_US4.Name = "Label_US4"
        Me.Label_US4.Size = New System.Drawing.Size(72, 19)
        Me.Label_US4.TabIndex = 13
        Me.Label_US4.Text = "คลัง"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.White
        Me.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.Location = New System.Drawing.Point(651, 76)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(51, 25)
        Me.btn_clear.TabIndex = 23
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'F_RPT_Balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox_US1)
        Me.Controls.Add(Me.ToolStrip_top)
        Me.Name = "F_RPT_Balance"
        Me.TabText = "F_RPT_Balance"
        Me.Text = "F_RPT_Balance"
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
    Friend WithEvents STCODE As Control_us.Combobox_US
    Friend WithEvents Label_US4 As Control_us.Label_US
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents pname2 As Control_us.Textbox_UC
    Friend WithEvents pcode2 As Control_us.Textbox_UC
    Friend WithEvents pname1 As Control_us.Textbox_UC
    Friend WithEvents pcode1 As Control_us.Textbox_UC
    Friend WithEvents btn_scr_Product2 As Control_us.Button_US
    Friend WithEvents btn_scr_Product1 As Control_us.Button_US
    Friend WithEvents btn_clear As Control_us.Button_US
End Class

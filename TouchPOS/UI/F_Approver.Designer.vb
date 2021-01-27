<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Approver
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Approver))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_US4 = New Control_us.Panel_US()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_display = New Control_us.Label_US()
        Me.btn_close = New Control_us.Button_US()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label_US3 = New Control_us.Label_US()
        Me.txt_barcode = New Control_us.Textbox_UC()
        Me.Label_US2 = New Control_us.Label_US()
        Me.Panel_US1 = New Control_us.Panel_US()
        Me.p_icon = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_US4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel_US1.SuspendLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(402, 4)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(4, 179)
        Me.Panel5.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(4, 179)
        Me.Panel4.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(406, 4)
        Me.Panel2.TabIndex = 12
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Panel_US4
        '
        Me.Panel_US4.Controls.Add(Me.Panel8)
        Me.Panel_US4.Controls.Add(Me.Panel7)
        Me.Panel_US4.Controls.Add(Me.Panel_US1)
        Me.Panel_US4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US4.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US4.Location = New System.Drawing.Point(0, 0)
        Me.Panel_US4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel_US4.Name = "Panel_US4"
        Me.Panel_US4.Size = New System.Drawing.Size(406, 183)
        Me.Panel_US4.TabIndex = 16
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txt_display)
        Me.Panel8.Controls.Add(Me.btn_close)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 113)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(406, 70)
        Me.Panel8.TabIndex = 46
        '
        'txt_display
        '
        Me.txt_display.BackColor = System.Drawing.Color.Gold
        Me.txt_display.Font = New System.Drawing.Font("Leelawadee UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_display.ForeColor = System.Drawing.Color.Black
        Me.txt_display.Location = New System.Drawing.Point(5, 3)
        Me.txt_display.Name = "txt_display"
        Me.txt_display.Size = New System.Drawing.Size(240, 63)
        Me.txt_display.TabIndex = 37
        Me.txt_display.Text = "กรุณาแสกนบัตร"
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
        Me.btn_close.Location = New System.Drawing.Point(251, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(146, 58)
        Me.btn_close.TabIndex = 34
        Me.btn_close.Text = "ปิด"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label_US3)
        Me.Panel7.Controls.Add(Me.txt_barcode)
        Me.Panel7.Controls.Add(Me.Label_US2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 44)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(406, 69)
        Me.Panel7.TabIndex = 45
        '
        'Label_US3
        '
        Me.Label_US3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US3.ForeColor = System.Drawing.Color.Black
        Me.Label_US3.Location = New System.Drawing.Point(14, 2)
        Me.Label_US3.Name = "Label_US3"
        Me.Label_US3.Size = New System.Drawing.Size(348, 29)
        Me.Label_US3.TabIndex = 36
        Me.Label_US3.Text = "กรุณาแสกนบัตรอนุมัติ"
        '
        'txt_barcode
        '
        Me.txt_barcode.BackColor = System.Drawing.Color.White
        Me.txt_barcode.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_barcode.ForeColor = System.Drawing.Color.DimGray
        Me.txt_barcode.Location = New System.Drawing.Point(92, 31)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_barcode.Size = New System.Drawing.Size(270, 35)
        Me.txt_barcode.TabIndex = 7
        Me.txt_barcode.Text = "12345"
        Me.txt_barcode.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_barcode.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_barcode.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_barcode.US_Color_Enable = System.Drawing.Color.White
        Me.txt_barcode.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_barcode.Us_dataBindings_TOP = 10
        Me.txt_barcode.US_Enable = True
        Me.txt_barcode.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_barcode.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_barcode.US_Number = False
        Me.txt_barcode.US_Tag2 = ""
        Me.txt_barcode.US_value = Nothing
        '
        'Label_US2
        '
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.Black
        Me.Label_US2.Location = New System.Drawing.Point(14, 31)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(72, 25)
        Me.Label_US2.TabIndex = 35
        Me.Label_US2.Text = "บาร์โค๊ด"
        '
        'Panel_US1
        '
        Me.Panel_US1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel_US1.Controls.Add(Me.p_icon)
        Me.Panel_US1.Controls.Add(Me.Panel6)
        Me.Panel_US1.Controls.Add(Me.Label_US1)
        Me.Panel_US1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_US1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel_US1.Name = "Panel_US1"
        Me.Panel_US1.Size = New System.Drawing.Size(406, 44)
        Me.Panel_US1.TabIndex = 2
        '
        'p_icon
        '
        Me.p_icon.Image = CType(resources.GetObject("p_icon.Image"), System.Drawing.Image)
        Me.p_icon.Location = New System.Drawing.Point(5, 3)
        Me.p_icon.Name = "p_icon"
        Me.p_icon.Size = New System.Drawing.Size(60, 30)
        Me.p_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_icon.TabIndex = 4
        Me.p_icon.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 40)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(406, 4)
        Me.Panel6.TabIndex = 3
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.White
        Me.Label_US1.Location = New System.Drawing.Point(71, 8)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(61, 25)
        Me.Label_US1.TabIndex = 1
        Me.Label_US1.Text = "อนุมัติ"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 183)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(406, 4)
        Me.Panel3.TabIndex = 13
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'F_Approver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 187)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_US4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Approver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Approver"
        Me.Panel_US4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel_US1.ResumeLayout(False)
        Me.Panel_US1.PerformLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel_US4 As Control_us.Panel_US
    Friend WithEvents Panel_US1 As Control_us.Panel_US
    Friend WithEvents p_icon As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btn_close As Control_us.Button_US
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_barcode As Control_us.Textbox_UC
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents Label_US3 As Control_us.Label_US
    Friend WithEvents txt_display As Control_us.Label_US
    Friend WithEvents Timer2 As Timer
End Class

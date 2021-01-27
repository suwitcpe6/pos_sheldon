<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_SearchData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_SearchData))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_ok = New Control_us.Button_US()
        Me.brn_scr = New Control_us.Button_US()
        Me.lbl_name = New Control_us.Label_US()
        Me.txt_name = New Control_us.Textbox_UC()
        Me.lbl_code = New Control_us.Label_US()
        Me.txt_code = New Control_us.Textbox_UC()
        Me.dgv_scr = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_ok)
        Me.Panel1.Controls.Add(Me.brn_scr)
        Me.Panel1.Controls.Add(Me.lbl_name)
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Controls.Add(Me.lbl_code)
        Me.Panel1.Controls.Add(Me.txt_code)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 87)
        Me.Panel1.TabIndex = 1
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.White
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.Location = New System.Drawing.Point(609, 12)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(99, 53)
        Me.btn_ok.TabIndex = 23
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'brn_scr
        '
        Me.brn_scr.BackColor = System.Drawing.Color.White
        Me.brn_scr.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.brn_scr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brn_scr.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.brn_scr.ForeColor = System.Drawing.Color.White
        Me.brn_scr.Image = CType(resources.GetObject("brn_scr.Image"), System.Drawing.Image)
        Me.brn_scr.Location = New System.Drawing.Point(504, 15)
        Me.brn_scr.Name = "brn_scr"
        Me.brn_scr.Size = New System.Drawing.Size(99, 53)
        Me.brn_scr.TabIndex = 22
        Me.brn_scr.UseVisualStyleBackColor = False
        '
        'lbl_name
        '
        Me.lbl_name.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_name.Location = New System.Drawing.Point(45, 46)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(87, 19)
        Me.lbl_name.TabIndex = 21
        Me.lbl_name.Text = "ชื่อสินค้า"
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.White
        Me.txt_name.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_name.Location = New System.Drawing.Point(138, 43)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(350, 25)
        Me.txt_name.TabIndex = 20
        Me.txt_name.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_name.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_name.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.txt_name.US_Color_Enable = System.Drawing.Color.White
        Me.txt_name.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_name.Us_dataBindings_TOP = 10
        Me.txt_name.US_Enable = True
        Me.txt_name.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_name.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_name.US_Number = False
        Me.txt_name.US_Tag2 = ""
        Me.txt_name.US_value = Nothing
        '
        'lbl_code
        '
        Me.lbl_code.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_code.ForeColor = System.Drawing.Color.Black
        Me.lbl_code.Location = New System.Drawing.Point(45, 15)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(87, 19)
        Me.lbl_code.TabIndex = 19
        Me.lbl_code.Text = "รหัสสินค้า"
        '
        'txt_code
        '
        Me.txt_code.BackColor = System.Drawing.Color.White
        Me.txt_code.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_code.ForeColor = System.Drawing.Color.DarkGreen
        Me.txt_code.Location = New System.Drawing.Point(138, 12)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(350, 25)
        Me.txt_code.TabIndex = 18
        Me.txt_code.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_code.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_code.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.txt_code.US_Color_Enable = System.Drawing.Color.White
        Me.txt_code.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_code.Us_dataBindings_TOP = 10
        Me.txt_code.US_Enable = True
        Me.txt_code.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_code.US_foreColor_Enable = System.Drawing.Color.DimGray
        Me.txt_code.US_Number = False
        Me.txt_code.US_Tag2 = ""
        Me.txt_code.US_value = Nothing
        '
        'dgv_scr
        '
        Me.dgv_scr.AllowUserToAddRows = False
        Me.dgv_scr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_scr.BackgroundColor = System.Drawing.Color.White
        Me.dgv_scr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_scr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_scr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_scr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_scr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_scr.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_scr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_scr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_scr.EnableHeadersVisualStyles = False
        Me.dgv_scr.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_scr.Location = New System.Drawing.Point(0, 87)
        Me.dgv_scr.Name = "dgv_scr"
        Me.dgv_scr.ReadOnly = True
        Me.dgv_scr.RowHeadersVisible = False
        Me.dgv_scr.RowTemplate.Height = 30
        Me.dgv_scr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_scr.Size = New System.Drawing.Size(800, 363)
        Me.dgv_scr.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'F_SearchData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgv_scr)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "F_SearchData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาข้อมูล"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_ok As Control_us.Button_US
    Friend WithEvents brn_scr As Control_us.Button_US
    Friend WithEvents lbl_name As Control_us.Label_US
    Friend WithEvents txt_name As Control_us.Textbox_UC
    Friend WithEvents lbl_code As Control_us.Label_US
    Friend WithEvents txt_code As Control_us.Textbox_UC
    Friend WithEvents dgv_scr As Control_us.DataGridView_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class

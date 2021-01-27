<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_SearchData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_SearchData))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.cbo_Search = New System.Windows.Forms.ComboBox()
        Me.txt_search = New MD.Textbox_New()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_search = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_Next = New System.Windows.Forms.ToolStripButton()
        Me.txt_curpage = New System.Windows.Forms.ToolStripTextBox()
        Me.Btn_last = New System.Windows.Forms.ToolStripButton()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancel = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Controls.Add(Me.cbo_Search)
        Me.Panel1.Controls.Add(Me.txt_search)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 52)
        Me.Panel1.TabIndex = 0
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_search.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(678, 8)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(77, 36)
        Me.btn_search.TabIndex = 238
        Me.btn_search.Text = "ค้นหา"
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'cbo_Search
        '
        Me.cbo_Search.BackColor = System.Drawing.Color.Lavender
        Me.cbo_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Search.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Search.FormattingEnabled = True
        Me.cbo_Search.Items.AddRange(New Object() {"ใช้งาน", "ไม่ใช้งาน"})
        Me.cbo_Search.Location = New System.Drawing.Point(74, 15)
        Me.cbo_Search.Name = "cbo_Search"
        Me.cbo_Search.Size = New System.Drawing.Size(258, 25)
        Me.cbo_Search.TabIndex = 237
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.White
        Me.txt_search.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_search.ForeColor = System.Drawing.Color.DarkCyan
        Me.txt_search.Location = New System.Drawing.Point(338, 15)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(325, 25)
        Me.txt_search.TabIndex = 236
        Me.txt_search.US_Color_Border_Normal = System.Drawing.Color.SteelBlue
        Me.txt_search.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_search.US_Color_Didable = System.Drawing.Color.Gainsboro
        Me.txt_search.US_Color_Enable = System.Drawing.Color.White
        Me.txt_search.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_search.Us_dataBindings_TOP = 10
        Me.txt_search.US_Enable = True
        Me.txt_search.US_Number = False
        Me.txt_search.US_Tag2 = Nothing
        Me.txt_search.US_value = Nothing
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SlateGray
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 235
        Me.Label2.Text = "ค้นหา"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_search
        '
        Me.dgv_search.AllowUserToAddRows = False
        Me.dgv_search.AllowUserToDeleteRows = False
        Me.dgv_search.AllowUserToOrderColumns = True
        Me.dgv_search.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_search.BackgroundColor = System.Drawing.Color.White
        Me.dgv_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_search.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_search.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_search.ColumnHeadersHeight = 25
        Me.dgv_search.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_search.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_search.EnableHeadersVisualStyles = False
        Me.dgv_search.GridColor = System.Drawing.Color.White
        Me.dgv_search.Location = New System.Drawing.Point(0, 0)
        Me.dgv_search.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.dgv_search.MultiSelect = False
        Me.dgv_search.Name = "dgv_search"
        Me.dgv_search.ReadOnly = True
        Me.dgv_search.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_search.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_search.RowHeadersVisible = False
        Me.dgv_search.RowHeadersWidth = 31
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgv_search.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_search.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgv_search.RowTemplate.DividerHeight = 4
        Me.dgv_search.RowTemplate.Height = 50
        Me.dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_search.Size = New System.Drawing.Size(800, 364)
        Me.dgv_search.TabIndex = 60
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 416)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 34)
        Me.Panel2.TabIndex = 61
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Next, Me.txt_curpage, Me.Btn_last, Me.btn_ok, Me.btn_cancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 34)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.Btn_Next.Size = New System.Drawing.Size(50, 25)
        Me.Btn_Next.Text = "หน้าถัดไป"
        '
        'txt_curpage
        '
        Me.txt_curpage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_curpage.AutoSize = False
        Me.txt_curpage.Enabled = False
        Me.txt_curpage.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_curpage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_curpage.Name = "txt_curpage"
        Me.txt_curpage.Size = New System.Drawing.Size(30, 25)
        Me.txt_curpage.Text = "1"
        Me.txt_curpage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Btn_last.Size = New System.Drawing.Size(50, 25)
        Me.Btn_last.Text = "ย้อนกลับ"
        '
        'btn_ok
        '
        Me.btn_ok.AutoSize = False
        Me.btn_ok.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_ok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_ok.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(100, 31)
        Me.btn_ok.Text = "ตกลง"
        '
        'btn_cancel
        '
        Me.btn_cancel.AutoSize = False
        Me.btn_cancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btn_cancel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(50, 31)
        Me.btn_cancel.Text = "ออก"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 364)
        Me.Panel3.TabIndex = 62
        '
        'Timer1
        '
        '
        'F_SearchData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_SearchData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหา"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_search As Textbox_New
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_Search As ComboBox
    Friend WithEvents btn_search As Button
    Friend WithEvents dgv_search As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btn_Next As ToolStripButton
    Friend WithEvents txt_curpage As ToolStripTextBox
    Friend WithEvents Btn_last As ToolStripButton
    Friend WithEvents btn_ok As ToolStripButton
    Friend WithEvents btn_cancel As ToolStripButton
    Friend WithEvents Timer1 As Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_YearEnd_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Receive_List))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbo_search = New System.Windows.Forms.ToolStripComboBox()
        Me.txt_scr = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_scr = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Next = New System.Windows.Forms.ToolStripButton()
        Me.txt_curpage = New System.Windows.Forms.ToolStripTextBox()
        Me.Btn_last = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cbo_topdisplay = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip_top = New System.Windows.Forms.ToolStrip()
        Me.btn_new = New System.Windows.Forms.ToolStripButton()
        Me.Btn_View = New System.Windows.Forms.ToolStripButton()
        Me.btn_edit = New System.Windows.Forms.ToolStripButton()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.btn_print = New System.Windows.Forms.ToolStripButton()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancel = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_scr = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip_top.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cbo_search, Me.txt_scr, Me.btn_scr, Me.Btn_Next, Me.txt_curpage, Me.Btn_last, Me.ToolStripLabel2, Me.cbo_topdisplay, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1155, 34)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(57, 31)
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
        Me.txt_scr.Size = New System.Drawing.Size(300, 34)
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(88, 31)
        Me.ToolStripLabel2.Text = "แสดงข้อมูลสูงสุด"
        '
        'cbo_topdisplay
        '
        Me.cbo_topdisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_topdisplay.Name = "cbo_topdisplay"
        Me.cbo_topdisplay.Size = New System.Drawing.Size(75, 34)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(46, 31)
        Me.ToolStripLabel3.Text = "รายการ"
        '
        'Timer1
        '
        '
        'ToolStrip_top
        '
        Me.ToolStrip_top.AutoSize = False
        Me.ToolStrip_top.BackColor = System.Drawing.Color.White
        Me.ToolStrip_top.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip_top.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip_top.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_new, Me.Btn_View, Me.btn_edit, Me.btndelete, Me.btn_print, Me.btn_close, Me.btn_cancel})
        Me.ToolStrip_top.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_top.Name = "ToolStrip_top"
        Me.ToolStrip_top.Size = New System.Drawing.Size(1155, 42)
        Me.ToolStrip_top.TabIndex = 20
        Me.ToolStrip_top.Text = "ToolStrip1"
        '
        'btn_new
        '
        Me.btn_new.Image = CType(resources.GetObject("btn_new.Image"), System.Drawing.Image)
        Me.btn_new.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(49, 39)
        Me.btn_new.Text = "เพิ่ม"
        '
        'Btn_View
        '
        Me.Btn_View.Image = CType(resources.GetObject("Btn_View.Image"), System.Drawing.Image)
        Me.Btn_View.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_View.Name = "Btn_View"
        Me.Btn_View.Size = New System.Drawing.Size(81, 39)
        Me.Btn_View.Text = "ดูอย่างเดียว"
        '
        'btn_edit
        '
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(56, 39)
        Me.btn_edit.Text = "แก้ไข"
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(44, 39)
        Me.btndelete.Text = "ลบ"
        Me.btndelete.Visible = False
        '
        'btn_print
        '
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(54, 39)
        Me.btn_print.Tag = "50"
        Me.btn_print.Text = "พิมพ์"
        Me.btn_print.Visible = False
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
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(92, 39)
        Me.btn_cancel.Text = "ยกเลิกเอกสาร"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip_top)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1155, 42)
        Me.Panel2.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ToolStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1155, 34)
        Me.Panel3.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_scr)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1155, 428)
        Me.Panel1.TabIndex = 24
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
        Me.dgv_scr.Location = New System.Drawing.Point(0, 0)
        Me.dgv_scr.Name = "dgv_scr"
        Me.dgv_scr.ReadOnly = True
        Me.dgv_scr.RowHeadersVisible = False
        Me.dgv_scr.RowHeadersWidth = 51
        Me.dgv_scr.RowTemplate.Height = 30
        Me.dgv_scr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_scr.Size = New System.Drawing.Size(1155, 428)
        Me.dgv_scr.TabIndex = 3
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
        'F_Receive_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1155, 504)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "F_Receive_List"
        Me.TabText = "F_Receive_List"
        Me.Text = "F_Receive_List"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip_top.ResumeLayout(False)
        Me.ToolStrip_top.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_scr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_scr As Control_us.DataGridView_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cbo_search As ToolStripComboBox
    Friend WithEvents txt_scr As ToolStripTextBox
    Friend WithEvents btn_scr As ToolStripButton
    Friend WithEvents Btn_Next As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txt_curpage As ToolStripTextBox
    Friend WithEvents Btn_last As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cbo_topdisplay As ToolStripComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStrip_top As ToolStrip
    Friend WithEvents btn_new As ToolStripButton
    Friend WithEvents Btn_View As ToolStripButton
    Friend WithEvents btn_edit As ToolStripButton
    Friend WithEvents btndelete As ToolStripButton
    Friend WithEvents btn_print As ToolStripButton
    Friend WithEvents btn_close As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cancel As ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Repay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Repay))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_US3 = New Control_us.Panel_US()
        Me.btn_del = New Control_us.Button_US()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn_close = New Control_us.Button_US()
        Me.btn_Start = New Control_us.Button_US()
        Me.btn_cancell = New Control_us.Button_US()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Panel_US1 = New Control_us.Panel_US()
        Me.Panel_US2 = New Control_us.Panel_US()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGV_Card_Normal = New Control_us.DataGridView_US()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.p_icon = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel_US3.SuspendLayout()
        Me.Panel_US1.SuspendLayout()
        Me.Panel_US2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_Card_Normal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_US3
        '
        Me.Panel_US3.Controls.Add(Me.btn_del)
        Me.Panel_US3.Controls.Add(Me.ProgressBar1)
        Me.Panel_US3.Controls.Add(Me.btn_close)
        Me.Panel_US3.Controls.Add(Me.btn_Start)
        Me.Panel_US3.Controls.Add(Me.btn_cancell)
        Me.Panel_US3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_US3.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US3.Location = New System.Drawing.Point(0, 385)
        Me.Panel_US3.Name = "Panel_US3"
        Me.Panel_US3.Size = New System.Drawing.Size(690, 61)
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
        Me.btn_del.Location = New System.Drawing.Point(165, 3)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(199, 54)
        Me.btn_del.TabIndex = 39
        Me.btn_del.Text = "   ลบรายการนี้"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(7, 12)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(224, 43)
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
        Me.btn_close.Location = New System.Drawing.Point(552, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(130, 54)
        Me.btn_close.TabIndex = 37
        Me.btn_close.Text = "    ปิด"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_Start
        '
        Me.btn_Start.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Start.BackColor = System.Drawing.Color.AliceBlue
        Me.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Start.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_Start.ForeColor = System.Drawing.Color.DimGray
        Me.btn_Start.Image = Global.TouchPOS.My.Resources.Resources.refresh40
        Me.btn_Start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Start.Location = New System.Drawing.Point(370, 4)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(176, 51)
        Me.btn_Start.TabIndex = 36
        Me.btn_Start.Text = "     เริ่ม"
        Me.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Start.UseVisualStyleBackColor = False
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
        Me.btn_cancell.Location = New System.Drawing.Point(710, 2)
        Me.btn_cancell.Name = "btn_cancell"
        Me.btn_cancell.Size = New System.Drawing.Size(143, 53)
        Me.btn_cancell.TabIndex = 34
        Me.btn_cancell.Text = "ยกเลิก"
        Me.btn_cancell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancell.UseVisualStyleBackColor = False
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.White
        Me.Label_US1.Location = New System.Drawing.Point(73, 14)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(138, 25)
        Me.Label_US1.TabIndex = 1
        Me.Label_US1.Text = "รายการค้างจ่าย"
        '
        'Panel_US1
        '
        Me.Panel_US1.Controls.Add(Me.Panel_US2)
        Me.Panel_US1.Controls.Add(Me.Panel5)
        Me.Panel_US1.Controls.Add(Me.Panel4)
        Me.Panel_US1.Controls.Add(Me.Panel2)
        Me.Panel_US1.Controls.Add(Me.Panel1)
        Me.Panel_US1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_US1.Name = "Panel_US1"
        Me.Panel_US1.Size = New System.Drawing.Size(700, 500)
        Me.Panel_US1.TabIndex = 2
        '
        'Panel_US2
        '
        Me.Panel_US2.Controls.Add(Me.Panel3)
        Me.Panel_US2.Controls.Add(Me.Panel_US3)
        Me.Panel_US2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US2.Location = New System.Drawing.Point(5, 49)
        Me.Panel_US2.Name = "Panel_US2"
        Me.Panel_US2.Size = New System.Drawing.Size(690, 446)
        Me.Panel_US2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGV_Card_Normal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(690, 385)
        Me.Panel3.TabIndex = 45
        '
        'DGV_Card_Normal
        '
        Me.DGV_Card_Normal.AllowUserToAddRows = False
        Me.DGV_Card_Normal.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Card_Normal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Card_Normal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_Card_Normal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Card_Normal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Card_Normal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.delete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Card_Normal.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Card_Normal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Card_Normal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_Card_Normal.EnableHeadersVisualStyles = False
        Me.DGV_Card_Normal.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Card_Normal.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Card_Normal.Name = "DGV_Card_Normal"
        Me.DGV_Card_Normal.RowHeadersVisible = False
        Me.DGV_Card_Normal.RowHeadersWidth = 51
        Me.DGV_Card_Normal.RowTemplate.Height = 30
        Me.DGV_Card_Normal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Card_Normal.Size = New System.Drawing.Size(690, 385)
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Orange
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(5, 495)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(690, 5)
        Me.Panel5.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Orange
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(695, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 451)
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
        Me.Panel2.Size = New System.Drawing.Size(695, 49)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 500)
        Me.Panel1.TabIndex = 1
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
        'F_Repay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.Panel_US1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Repay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_Repay"
        Me.Panel_US3.ResumeLayout(False)
        Me.Panel_US1.ResumeLayout(False)
        Me.Panel_US2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV_Card_Normal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.p_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_US3 As Control_us.Panel_US
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btn_close As Control_us.Button_US
    Friend WithEvents btn_Start As Control_us.Button_US
    Friend WithEvents btn_cancell As Control_us.Button_US
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents delete As DataGridViewImageColumn
    Friend WithEvents Panel_US1 As Control_us.Panel_US
    Friend WithEvents Panel_US2 As Control_us.Panel_US
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DGV_Card_Normal As Control_us.DataGridView_US
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents p_icon As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_del As Control_us.Button_US
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Main))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", 1, 0, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_US1 = New Control_us.Button_US()
        Me.Btn_master = New Control_us.Button_US()
        Me.Btn_inventory = New Control_us.Button_US()
        Me.Btn_Report = New Control_us.Button_US()
        Me.Btn_setting = New Control_us.Button_US()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_Display = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button_US7 = New Control_us.Button_US()
        Me.Button_US3 = New Control_us.Button_US()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.p_background = New System.Windows.Forms.PictureBox()
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Tree_Menu = New System.Windows.Forms.TreeView()
        Me.DockPanel = New WeifenLuo.WinFormsUI.DockPanel()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 663)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1155, 24)
        Me.Panel1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripLabel4, Me.ToolStripProgressBar1, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1155, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel2.Text = "User : admin"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.AutoSize = False
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel4.Text = "100%"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 22)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel3.Text = "Process"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(49, 663)
        Me.Panel2.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Orange
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_US1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_master)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_inventory)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Report)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_setting)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 41)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(49, 622)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'Button_US1
        '
        Me.Button_US1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_US1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US1.ForeColor = System.Drawing.Color.Black
        Me.Button_US1.Image = CType(resources.GetObject("Button_US1.Image"), System.Drawing.Image)
        Me.Button_US1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_US1.Location = New System.Drawing.Point(4, 4)
        Me.Button_US1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_US1.Name = "Button_US1"
        Me.Button_US1.Size = New System.Drawing.Size(43, 53)
        Me.Button_US1.TabIndex = 41
        Me.Button_US1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button_US1.UseVisualStyleBackColor = False
        '
        'Btn_master
        '
        Me.Btn_master.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_master.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_master.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Btn_master.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_master.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_master.ForeColor = System.Drawing.Color.Black
        Me.Btn_master.Image = CType(resources.GetObject("Btn_master.Image"), System.Drawing.Image)
        Me.Btn_master.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_master.Location = New System.Drawing.Point(4, 61)
        Me.Btn_master.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_master.Name = "Btn_master"
        Me.Btn_master.Size = New System.Drawing.Size(43, 53)
        Me.Btn_master.TabIndex = 40
        Me.Btn_master.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_master.UseVisualStyleBackColor = False
        Me.Btn_master.Visible = False
        '
        'Btn_inventory
        '
        Me.Btn_inventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_inventory.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_inventory.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_inventory.ForeColor = System.Drawing.Color.Black
        Me.Btn_inventory.Image = CType(resources.GetObject("Btn_inventory.Image"), System.Drawing.Image)
        Me.Btn_inventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_inventory.Location = New System.Drawing.Point(4, 118)
        Me.Btn_inventory.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_inventory.Name = "Btn_inventory"
        Me.Btn_inventory.Size = New System.Drawing.Size(43, 53)
        Me.Btn_inventory.TabIndex = 35
        Me.Btn_inventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_inventory.UseVisualStyleBackColor = False
        Me.Btn_inventory.Visible = False
        '
        'Btn_Report
        '
        Me.Btn_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Report.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Report.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_Report.ForeColor = System.Drawing.Color.Black
        Me.Btn_Report.Image = CType(resources.GetObject("Btn_Report.Image"), System.Drawing.Image)
        Me.Btn_Report.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Report.Location = New System.Drawing.Point(4, 175)
        Me.Btn_Report.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Report.Name = "Btn_Report"
        Me.Btn_Report.Size = New System.Drawing.Size(43, 53)
        Me.Btn_Report.TabIndex = 36
        Me.Btn_Report.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Report.UseVisualStyleBackColor = False
        Me.Btn_Report.Visible = False
        '
        'Btn_setting
        '
        Me.Btn_setting.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_setting.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_setting.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Btn_setting.ForeColor = System.Drawing.Color.Black
        Me.Btn_setting.Image = CType(resources.GetObject("Btn_setting.Image"), System.Drawing.Image)
        Me.Btn_setting.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_setting.Location = New System.Drawing.Point(4, 232)
        Me.Btn_setting.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_setting.Name = "Btn_setting"
        Me.Btn_setting.Size = New System.Drawing.Size(43, 53)
        Me.Btn_setting.TabIndex = 37
        Me.Btn_setting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_setting.UseVisualStyleBackColor = False
        Me.Btn_setting.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Orange
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(49, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1106, 41)
        Me.Panel3.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Orange
        Me.Panel6.Controls.Add(Me.lbl_Display)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(68, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(725, 41)
        Me.Panel6.TabIndex = 37
        '
        'lbl_Display
        '
        Me.lbl_Display.BackColor = System.Drawing.Color.Orange
        Me.lbl_Display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Display.Font = New System.Drawing.Font("Leelawadee UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_Display.ForeColor = System.Drawing.Color.White
        Me.lbl_Display.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Display.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Display.Name = "lbl_Display"
        Me.lbl_Display.Size = New System.Drawing.Size(725, 41)
        Me.lbl_Display.TabIndex = 0
        Me.lbl_Display.Text = "Foodcort"
        Me.lbl_Display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Button_US7)
        Me.Panel5.Controls.Add(Me.Button_US3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(793, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(313, 41)
        Me.Panel5.TabIndex = 36
        '
        'Button_US7
        '
        Me.Button_US7.BackColor = System.Drawing.Color.Transparent
        Me.Button_US7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button_US7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US7.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US7.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US7.Image = CType(resources.GetObject("Button_US7.Image"), System.Drawing.Image)
        Me.Button_US7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_US7.Location = New System.Drawing.Point(0, 0)
        Me.Button_US7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_US7.Name = "Button_US7"
        Me.Button_US7.Size = New System.Drawing.Size(184, 41)
        Me.Button_US7.TabIndex = 34
        Me.Button_US7.Text = "Close All Page"
        Me.Button_US7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_US7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_US7.UseVisualStyleBackColor = False
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
        Me.Button_US3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_US3.Location = New System.Drawing.Point(184, 0)
        Me.Button_US3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_US3.Name = "Button_US3"
        Me.Button_US3.Size = New System.Drawing.Size(129, 41)
        Me.Button_US3.TabIndex = 33
        Me.Button_US3.Text = "Logout"
        Me.Button_US3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_US3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_US3.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(68, 41)
        Me.Panel4.TabIndex = 35
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'p_background
        '
        Me.p_background.BackColor = System.Drawing.Color.GhostWhite
        Me.p_background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p_background.Image = CType(resources.GetObject("p_background.Image"), System.Drawing.Image)
        Me.p_background.Location = New System.Drawing.Point(407, 41)
        Me.p_background.Margin = New System.Windows.Forms.Padding(2)
        Me.p_background.Name = "p_background"
        Me.p_background.Size = New System.Drawing.Size(748, 622)
        Me.p_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.p_background.TabIndex = 8
        Me.p_background.TabStop = False
        '
        'Panel_Menu
        '
        Me.Panel_Menu.Controls.Add(Me.Tree_Menu)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Location = New System.Drawing.Point(49, 41)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(358, 622)
        Me.Panel_Menu.TabIndex = 13
        '
        'Tree_Menu
        '
        Me.Tree_Menu.BackColor = System.Drawing.Color.AliceBlue
        Me.Tree_Menu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tree_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tree_Menu.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Tree_Menu.ForeColor = System.Drawing.Color.Blue
        Me.Tree_Menu.FullRowSelect = True
        Me.Tree_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Tree_Menu.Name = "Tree_Menu"
        TreeNode1.Name = "Node3"
        TreeNode1.Text = "Node3"
        TreeNode2.Name = "Node4"
        TreeNode2.Text = "Node4"
        TreeNode3.BackColor = System.Drawing.Color.SteelBlue
        TreeNode3.ForeColor = System.Drawing.Color.White
        TreeNode3.ImageIndex = 1
        TreeNode3.Name = "Node0"
        TreeNode3.SelectedImageIndex = 0
        TreeNode3.Text = "Node0"
        TreeNode4.Name = "Node5"
        TreeNode4.Text = "Node5"
        TreeNode5.Name = "Node6"
        TreeNode5.Text = "Node6"
        TreeNode6.BackColor = System.Drawing.Color.SteelBlue
        TreeNode6.ForeColor = System.Drawing.Color.White
        TreeNode6.ImageIndex = 1
        TreeNode6.Name = "Node1"
        TreeNode6.SelectedImageIndex = 1
        TreeNode6.Text = "Node1"
        TreeNode7.Name = "Node7"
        TreeNode7.Text = "Node7"
        TreeNode8.Name = "Node8"
        TreeNode8.Text = "Node8"
        TreeNode9.BackColor = System.Drawing.Color.SteelBlue
        TreeNode9.ForeColor = System.Drawing.Color.White
        TreeNode9.ImageIndex = 2
        TreeNode9.Name = "Node2"
        TreeNode9.SelectedImageIndex = 2
        TreeNode9.Text = "Node2"
        Me.Tree_Menu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode9})
        Me.Tree_Menu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tree_Menu.ShowLines = False
        Me.Tree_Menu.ShowNodeToolTips = True
        Me.Tree_Menu.ShowPlusMinus = False
        Me.Tree_Menu.ShowRootLines = False
        Me.Tree_Menu.Size = New System.Drawing.Size(358, 622)
        Me.Tree_Menu.TabIndex = 6
        '
        'DockPanel
        '
        Me.DockPanel.ActiveAutoHideContent = Nothing
        Me.DockPanel.AutoScroll = True
        Me.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockPanel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.DockPanel.Location = New System.Drawing.Point(407, 41)
        Me.DockPanel.Name = "DockPanel"
        Me.DockPanel.Size = New System.Drawing.Size(748, 622)
        Me.DockPanel.TabIndex = 14
        '
        'F_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1155, 687)
        Me.Controls.Add(Me.p_background)
        Me.Controls.Add(Me.DockPanel)
        Me.Controls.Add(Me.Panel_Menu)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F_Main"
        Me.Opacity = 0.98R
        Me.Text = "Foodcort"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Button_US3 As Control_us.Button_US
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Btn_inventory As Control_us.Button_US
    Friend WithEvents Btn_Report As Control_us.Button_US
    Friend WithEvents Btn_setting As Control_us.Button_US
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_Display As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button_US7 As Control_us.Button_US
    Friend WithEvents Btn_master As Control_us.Button_US
    Friend WithEvents p_background As PictureBox
    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Tree_Menu As TreeView
    Friend WithEvents Button_US1 As Control_us.Button_US
    Friend WithEvents DockPanel As WeifenLuo.WinFormsUI.DockPanel
End Class

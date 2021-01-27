<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Reprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Reprint))
        Me.txt_docno = New Control_us.Textbox_UC()
        Me.btn_ok = New Control_us.Button_US()
        Me.SuspendLayout()
        '
        'txt_docno
        '
        Me.txt_docno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_docno.BackColor = System.Drawing.Color.White
        Me.txt_docno.Font = New System.Drawing.Font("Leelawadee UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_docno.ForeColor = System.Drawing.Color.DimGray
        Me.txt_docno.Location = New System.Drawing.Point(12, 25)
        Me.txt_docno.Name = "txt_docno"
        Me.txt_docno.Size = New System.Drawing.Size(468, 54)
        Me.txt_docno.TabIndex = 8
        Me.txt_docno.Text = "N0601110953"
        Me.txt_docno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_docno.US_Color_Border_Normal = System.Drawing.Color.RoyalBlue
        Me.txt_docno.US_Color_Borderr_Focus = System.Drawing.Color.Blue
        Me.txt_docno.US_Color_Didable = System.Drawing.Color.DimGray
        Me.txt_docno.US_Color_Enable = System.Drawing.Color.White
        Me.txt_docno.US_Color_MouseHover = System.Drawing.Color.Lavender
        Me.txt_docno.Us_dataBindings_TOP = 10
        Me.txt_docno.US_Enable = True
        Me.txt_docno.US_foreColor_Didable = System.Drawing.Color.White
        Me.txt_docno.US_foreColor_Enable = System.Drawing.Color.White
        Me.txt_docno.US_Number = False
        Me.txt_docno.US_Tag2 = ""
        Me.txt_docno.US_value = Nothing
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ok.BackColor = System.Drawing.Color.Transparent
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.DimGray
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.Location = New System.Drawing.Point(497, 25)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(139, 51)
        Me.btn_ok.TabIndex = 37
        Me.btn_ok.Text = "ตกลง"
        Me.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'F_Reprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 105)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txt_docno)
        Me.Name = "F_Reprint"
        Me.Text = "F_Reprint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_docno As Control_us.Textbox_UC
    Friend WithEvents btn_ok As Control_us.Button_US
End Class

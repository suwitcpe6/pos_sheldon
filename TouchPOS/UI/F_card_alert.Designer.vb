<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_card_alert
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
        Me.Panel_US1 = New Control_us.Panel_US()
        Me.Button_US3 = New Control_us.Button_US()
        Me.Label_US1 = New Control_us.Label_US()
        Me.Panel_US2 = New Control_us.Panel_US()
        Me.lbl_barcode = New Control_us.Label_US()
        Me.Label_US2 = New Control_us.Label_US()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_US1.SuspendLayout()
        Me.Panel_US2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_US1
        '
        Me.Panel_US1.Controls.Add(Me.Button_US3)
        Me.Panel_US1.Controls.Add(Me.Label_US1)
        Me.Panel_US1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_US1.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_US1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel_US1.Name = "Panel_US1"
        Me.Panel_US1.Size = New System.Drawing.Size(1067, 89)
        Me.Panel_US1.TabIndex = 0
        '
        'Button_US3
        '
        Me.Button_US3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_US3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_US3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.Button_US3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_US3.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_US3.ForeColor = System.Drawing.Color.DimGray
        Me.Button_US3.Image = Global.TouchPOS.My.Resources.Resources.Notpass50x50
        Me.Button_US3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button_US3.Location = New System.Drawing.Point(892, 4)
        Me.Button_US3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_US3.Name = "Button_US3"
        Me.Button_US3.Size = New System.Drawing.Size(159, 78)
        Me.Button_US3.TabIndex = 33
        Me.Button_US3.Text = "ปิด"
        Me.Button_US3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_US3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button_US3.UseVisualStyleBackColor = False
        '
        'Label_US1
        '
        Me.Label_US1.AutoSize = True
        Me.Label_US1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US1.ForeColor = System.Drawing.Color.White
        Me.Label_US1.Location = New System.Drawing.Point(44, 28)
        Me.Label_US1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_US1.Name = "Label_US1"
        Me.Label_US1.Size = New System.Drawing.Size(295, 32)
        Me.Label_US1.TabIndex = 0
        Me.Label_US1.Text = "การแจ้งเตือนบัตรหมดมูลค่า"
        '
        'Panel_US2
        '
        Me.Panel_US2.Controls.Add(Me.lbl_barcode)
        Me.Panel_US2.Controls.Add(Me.Label_US2)
        Me.Panel_US2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_US2.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel_US2.Location = New System.Drawing.Point(0, 89)
        Me.Panel_US2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel_US2.Name = "Panel_US2"
        Me.Panel_US2.Size = New System.Drawing.Size(1067, 567)
        Me.Panel_US2.TabIndex = 1
        '
        'lbl_barcode
        '
        Me.lbl_barcode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_barcode.Font = New System.Drawing.Font("Leelawadee UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_barcode.ForeColor = System.Drawing.Color.White
        Me.lbl_barcode.Location = New System.Drawing.Point(-4, 336)
        Me.lbl_barcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_barcode.Name = "lbl_barcode"
        Me.lbl_barcode.Size = New System.Drawing.Size(1067, 209)
        Me.lbl_barcode.TabIndex = 2
        Me.lbl_barcode.Text = "XXX"
        Me.lbl_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_US2
        '
        Me.Label_US2.BackColor = System.Drawing.Color.Transparent
        Me.Label_US2.Font = New System.Drawing.Font("Leelawadee UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label_US2.ForeColor = System.Drawing.Color.White
        Me.Label_US2.Location = New System.Drawing.Point(0, 0)
        Me.Label_US2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_US2.Name = "Label_US2"
        Me.Label_US2.Size = New System.Drawing.Size(1067, 336)
        Me.Label_US2.TabIndex = 1
        Me.Label_US2.Text = "บัตรหมดมูลค่า กรุณาเก็บบัตร"
        Me.Label_US2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 600
        '
        'F_card_alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1067, 656)
        Me.Controls.Add(Me.Panel_US2)
        Me.Controls.Add(Me.Panel_US1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "F_card_alert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_card_alert"
        Me.Panel_US1.ResumeLayout(False)
        Me.Panel_US1.PerformLayout()
        Me.Panel_US2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_US1 As Control_us.Panel_US
    Friend WithEvents Label_US1 As Control_us.Label_US
    Friend WithEvents Panel_US2 As Control_us.Panel_US
    Friend WithEvents Label_US2 As Control_us.Label_US
    Friend WithEvents Button_US3 As Control_us.Button_US
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_barcode As Control_us.Label_US
End Class

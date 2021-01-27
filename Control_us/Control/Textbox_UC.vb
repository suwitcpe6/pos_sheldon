Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class Textbox_UC
    Inherits TextBox
    Sub New()
        Enable_ = True
        'Me.BackColor = Color.White        
        Us_dataBindings_TOP_ = 10
        Enable_ = True

        'Me.Placeholder_ = "Enter Data"
        US_Default()
    End Sub

#Region "propperty"
    Private Enable_ As Boolean = True
    Dim back_col_dis As Color = Color.Gainsboro
    Dim back_col_en As Color = Color.White


    Dim CMouseHover As Color = Color.Lavender
    Dim border_focus As Color = Color.Blue
    Dim border_normal As Color = Color.RoyalBlue
    Dim is_Number_ As Boolean
    Dim value_ As Object
    Dim Us_dataBindings_TOP_ As Integer = 10
    Dim tag2_ As String = ""

    Public Property US_Tag2() As String
        Get
            Return tag2_
        End Get
        Set(ByVal value As String)
            tag2_ = value
        End Set
    End Property
    Public Property US_Enable() As Boolean
        Get
            Return Enable_
        End Get
        Set(ByVal value As Boolean)
            Enable_ = value
            If Enable_ Then
                Me.BackColor = back_col_en
                MyBase.BackColor = back_col_en

                'Me.ForeColor = _US_fore_Enable
                'MyBase.ForeColor = _US_fore_Enable
                Me.ReadOnly = Not value

            Else
                Me.BackColor = back_col_dis
                MyBase.BackColor = back_col_dis

                'Me.ForeColor = _US_fore_Didable
                'MyBase.ForeColor = _US_fore_Didable
                Me.ReadOnly = Not value
            End If

        End Set
    End Property

    Public Property US_Color_Enable() As Color
        Get
            Return back_col_en
        End Get
        Set(ByVal value As Color)
            back_col_en = value
        End Set
    End Property
    Public Property US_Color_Didable() As Color
        Get
            Return back_col_dis
        End Get
        Set(ByVal value As Color)
            back_col_dis = value
        End Set
    End Property
    Private _US_fore_Enable = Color.DimGray
    Public Property US_foreColor_Enable() As Color
        Get
            Return _US_fore_Enable
        End Get
        Set(ByVal value As Color)
            _US_fore_Enable = value
        End Set
    End Property
    Private _US_fore_Didable = Color.White
    Public Property US_foreColor_Didable() As Color
        Get
            Return _US_fore_Didable
        End Get
        Set(ByVal value As Color)
            _US_fore_Didable = value
        End Set
    End Property
    Public Property US_Color_Borderr_Focus() As Color
        Get
            Return border_focus
        End Get
        Set(ByVal value As Color)
            border_focus = value
        End Set
    End Property
    Public Property US_Color_Border_Normal() As Color
        Get
            Return border_normal
        End Get
        Set(ByVal value As Color)
            border_normal = value
        End Set
    End Property
    Public Property US_Color_MouseHover() As Color
        Get
            Return CMouseHover
        End Get
        Set(ByVal value As Color)
            CMouseHover = value
        End Set
    End Property

    Public Property US_Number() As Boolean
        Get
            Return is_Number_
        End Get
        Set(ByVal value As Boolean)
            is_Number_ = value
            US_Reset_text()
        End Set
    End Property
    Public Property US_value() As Object
        Get
            Return value_
        End Get
        Set(ByVal value As Object)
            value_ = value
        End Set
    End Property
    Public Property Us_dataBindings_TOP() As Integer
        Get
            Return Us_dataBindings_TOP_
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                Us_dataBindings_TOP_ = value
            Else
                Us_dataBindings_TOP_ = 1
            End If

        End Set
    End Property
    'Dim Placeholder_ As String
    'Public Property Placeholder() As String
    '    Get
    '        Return Placeholder_
    '    End Get
    '    Set(ByVal value As String)
    '        Placeholder_ = value
    '    End Set
    'End Property
#End Region
#Region "setevent"
    Private Sub Textbox_New_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If Enable_ Then Me.BackColor = CMouseHover

    End Sub
    Private Sub Textbox_New_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If Enable_ Then Me.BackColor = back_col_en
        If Me.is_Number_ Then
            Dim a As String = Me.Text
            If a.Length = 0 Then
                Me.Text = 0
            End If
        End If
    End Sub

    Private Sub Textbox_New_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        If Enable_ Then Me.BackColor = CMouseHover
    End Sub

    Private Sub Textbox_New_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        If Enable_ Then Me.BackColor = back_col_en
    End Sub

    Private Sub Textbox_New_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Me.is_Number_ Then
            If IsNumeric(e.KeyChar) Or (e.KeyChar = vbBack) Or (e.KeyChar = ".") Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If

    End Sub

#End Region
#Region "method"
    Private Sub US_Default()
        Me.Font = Center.Us_font
        Me.ForeColor = System.Drawing.Color.DarkGreen



        Me.Width = 200
    End Sub
    Private Sub US_Reconfig()
        'Me.Font = Center.Us_font
        'Me.ForeColor = System.Drawing.Color.Orange
    End Sub

#Region "Placeholder"

    Public Sub SetPlaceholder(Placeholder_ As String)
        Try
            'Dim p() As Process
            'p = Process.GetProcessesByName("TouchPOS")
            'If p.Count <= 0 Then
            '    Exit Sub
            '    'US_Reconfig()
            '    'SetPlaceholder()
            'End If

            'If MouseDown_ Then Exit Sub
            If Me.is_Number_ Then Exit Sub
            Dim placeholder As New Label With {
                .Text = Placeholder_,
                .Font = Me.Font,
                .ForeColor = Color.Silver,
                .BackColor = Color.Transparent,
                .Cursor = Cursors.IBeam,
                .Margin = Padding.Empty,
                .FlatStyle = FlatStyle.System,
                .AutoSize = False,
                .Size = New Size(Me.Size.Width - 4, Me.Size.Height - 4),
                .Location = New Point(Me.Location.X + 2, Me.Location.Y + 2),
                .Visible = Me.Visible
            }

            AddHandler placeholder.Click, Sub() lbl_click(Me, placeholder)
            AddHandler Me.Leave, Sub() Control_Leave(Me, placeholder)
            AddHandler Me.VisibleChanged, Sub() Visible_Changed(Me, placeholder)
            AddHandler Me.TextChanged, Sub() text_Changed(Me, placeholder)

            Me.Parent.Controls.Add(placeholder)
            placeholder.BringToFront()
            If Me.Text = "" And Me.Visible = True Then
                placeholder.Visible = True
            Else
                placeholder.Visible = False
            End If
            'Return placeholder
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lbl_click(control As Control, placeholder As Label)
        control.Focus()
        placeholder.Visible = False
    End Sub
    Private Sub Control_Leave(control As Control, placeholder As Label)
        'control.Focus()
        If control.Text = "" Then
            placeholder.Visible = True
        Else
            placeholder.Visible = False
        End If
    End Sub
    Private Sub Visible_Changed(control As Control, placeholder As Label)
        'control.Focus()
        If control.Visible = True Then
            placeholder.Visible = True
        Else
            placeholder.Visible = False
        End If
    End Sub
    Private Sub text_Changed(control As Control, placeholder As Label)
        'control.Focus()
        If control.Text.Trim = "" Then
            placeholder.Visible = True
        Else
            placeholder.Visible = False
        End If
    End Sub
#End Region

    Dim Err As New ErrorProvider
    Public Function US_Reset_text()
        'auto reset
        If is_Number_ Then
            If Not IsNumeric(Me.Text) Then 'ถ้าไม่ใช่ตัวเลขเปลี่ยน ให้ค่าเริ่มต้น = 0
                Me.Text = 0
            End If
        Else
            'ถ้าไม่ใช่ตัวเลขให้ใช้ค่าปัจจุบันเลย
            'Me.Text = ""

        End If
        Return True
    End Function
    Public Sub UCSet_err(value As String)
        Me.Err.SetError(Me, value)
    End Sub
    Public Sub UCClear_err()
        Me.Err.Clear()
    End Sub


#Region "Us_dataBindings"

    Private WithEvents Timer1 As Timer = New Timer
    Dim ListBox1 As ListBox

    Public Sub Us_dataBindings(ByVal list As ListBox, ByVal query As String, strConn As String)
        ListBox1 = list
        AddHandler Me.KeyUp, AddressOf txt_KeyUp
        AddHandler Me.KeyDown, AddressOf txt_KeyDown
        AddHandler Me.MouseUp, AddressOf txt_MouseUp
        AddHandler Timer1.Tick, Sub() Timer1_Tick(query, strConn)
    End Sub
    Private Sub txt_KeyUp(sender As Object, e As KeyEventArgs)
        Timer1.Interval = 200
        Timer1.Enabled = True
    End Sub
    Private Sub txt_KeyDown(sender As Object, e As KeyEventArgs)
        Timer1.Enabled = False
        If e.KeyCode = Keys.KeyCode.Down Then
            ListBox1.Focus()
        End If
    End Sub
    Private Sub txt_MouseUp(sender As Object, e As MouseEventArgs)
        Timer1.Enabled = False
        ListBox1.Focus()
    End Sub
    Private Sub Timer1_Tick(ByVal query As String, strConn As String)
        Searlist(query, strConn)
        Timer1.Enabled = False
    End Sub
    Private Sub Searlist(query As String, strConn As String)

        'Try
        '    Dim DT As DataTable
        '    With ListBox1
        '        .Location = New Point(Me.Location.X, Me.Location.Y + Me.Height + 3)
        '        .Width = Me.Width
        '        .Height = 150
        '        .Visible = True
        '        .BringToFront()
        '        AddHandler .MouseLeave, Sub() ListBox1_close(ListBox1)
        '        'AddHandler .SelectedIndexChanged, Sub() ListBox1_SelectedIndexChanged(ListBox1)
        '        AddHandler .KeyDown, AddressOf ListBox1_KeyDown
        '        AddHandler .MouseUp, AddressOf ListBox1_MouseUp
        '        AddHandler .LostFocus, Sub() ListBox1_close(ListBox1)
        '    End With


        '    AddHandler Me.MouseUp, Sub() ListBox1_close(ListBox1)
        '    Dim str = " select top " & Us_dataBindings_TOP_ & " * from (" & query & ") as ss where col1 like '%" & Me.Text & "%' "
        '    DT = DB.search_data(str, strConn)

        '    If DT.Rows.Count > 0 Then
        '        ListBox1.Items.Clear()
        '        For Each drow As DataRow In DT.Rows
        '            ListBox1.Items.Add(drow("col1"))
        '        Next

        '    Else
        '        ListBox1.Items.Clear()
        '    End If
        'Catch ex As Exception
        '    'Throw ex
        'End Try
    End Sub

    Private Sub ListBox1_close(ByVal ListBox1 As ListBox)
        ListBox1.Visible = False
    End Sub

    Private Sub ListBox1_MouseUp(sender As Object, e As MouseEventArgs)
        Me.Text = ListBox1.SelectedItem
        ListBox1.Visible = False
    End Sub
    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.Text = ListBox1.SelectedItem
            ListBox1.Visible = False
        End If
    End Sub
#End Region
#End Region


#Region "RoundedCorner_textbox"

    Declare Function GetWindowDC Lib "user32" (ByVal hwnd As IntPtr) As IntPtr
    Declare Function ReleaseDC Lib "user32.dll" _
       (ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Integer

#Region "Globals"
    Private mLeavingEventlist As ArrayList
    Private _OriText As String = ""
    Private _NewText As String = ""
    Private _Texthaschanged As Boolean = False
    Dim state As states = states.normal
    Dim BorderPen As Pen
    Dim ArrowBrush, ButtonBrush, TextBrush As Brush
    Dim MainRect As Rectangle
    Dim pointArrow(2) As PointF
    Dim VerticalMiddle As Integer
    Dim ArrowPath As GraphicsPath = New GraphicsPath
    Dim TxtLoc As PointF

    Enum states
        normal
        focused
        disabled
    End Enum
#End Region
#Region "Listeners"

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        Select Case m.Msg
            Case 129
                'Dim p() As Process
                'p = Process.GetProcessesByName("TouchPOS")
                'If p.Count > 0 Then
                US_Reconfig()
                '  SetPlaceholder()
                'End If

            Case &HF
                'WM_PAINT
                Dim rect As New Rectangle(0, 0, MyBase.Width, MyBase.Height)
                Dim hDC As IntPtr = GetWindowDC(Me.Handle)
                Dim g As Graphics = Graphics.FromHdc(hDC)

                DrawBorder(g)
                'DrawText(g)
                ReleaseDC(Me.Handle, hDC)
                g.Dispose()

            Case &H7, &H8, &H200, &H2A3

                UpdateState()
                'US_Reconfig()

                'Me.SetPlaceholder("Type what you're searching for")
        End Select

    End Sub
    Private Sub UpdateState()
        'save the current state
        Dim temp As states = state
        '
        If Me.Enabled Then
            If ClientRectangle.Contains(PointToClient(Control.MousePosition)) Then
                Me.state = states.focused
            ElseIf Me.Focused Then
                Me.state = states.focused
            Else
                Me.state = states.normal
            End If
        Else
            Me.state = states.disabled
        End If

        If state <> temp Then
            Me.Invalidate()
        End If
    End Sub
#End Region
#Region " Drawing functions "
    Private Sub TekenRondeRechthoek(ByVal g As Graphics, ByVal pen As Pen, ByVal rectangle As Rectangle, ByVal radius As Single)
        Dim size As Single = (radius * 2.0!)
        Dim gp As GraphicsPath = New GraphicsPath
        gp.AddArc(rectangle.X, rectangle.Y, size, size, 180, 90)
        gp.AddArc((rectangle.X _
                        + (rectangle.Width - size)), rectangle.Y, size, size, 270, 90)
        gp.AddArc((rectangle.X _
                        + (rectangle.Width - size)), (rectangle.Y _
                        + (rectangle.Height - size)), size, size, 0, 90)
        gp.AddArc(rectangle.X, (rectangle.Y _
                        + (rectangle.Height - size)), size, size, 90, 90)
        gp.CloseFigure()
        g.DrawPath(pen, gp)
        gp.Dispose()
    End Sub
    Private Sub DrawBorder(ByVal g As Graphics)
        MainRect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        'MainRect = New Rectangle(0, 0, Me.Width, Me.Height)
        Select Case state
            Case states.focused
                BorderPen = New Pen(border_focus)
            Case states.disabled
                BorderPen = New Pen(back_col_dis)
            Case states.normal
                BorderPen = New Pen(border_normal)
            Case Else
                Exit Sub
        End Select
        TekenRondeRechthoek(g, BorderPen, MainRect, 3.0!)

    End Sub
#End Region
#End Region
End Class

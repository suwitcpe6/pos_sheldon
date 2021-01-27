Imports System.Runtime.CompilerServices
Public Class F_SearchData
    Public Property Table As String
    Public Property Query As String
    Public Property Defaultfield As String
    Public Property Multi_Select As Boolean = False

    Public s_row As DataRow
    Public Property AutoSearch As Boolean = True
    Public Property Hid_col As String = ""
    Public Property TOP As Integer = 100
    Public ReturnSelected As DataTable


    Public conn As Connect_DB


#Region "SET_Event"
    Public Sub SetEvent()
        Try


            'text
            AddHandler Me.txt_search.KeyDown, AddressOf Text_KeyDown


            'btn
            AddHandler Me.btn_search.Click, AddressOf Btn_Click
            AddHandler Me.btn_ok.Click, AddressOf Btn_Click
            AddHandler Me.btn_cancel.Click, AddressOf Btn_Click
            AddHandler Me.Btn_Next.Click, AddressOf Btn_Click
            AddHandler Me.Btn_last.Click, AddressOf Btn_Click

            ' dgv

            AddHandler dgv_search.CellDoubleClick, AddressOf DGV_CellDoubleClick
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Event"

    Private Sub Text_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    txt_curpage.Text = 1
        '    Select Case sender.name
        '        Case txt_search.Name
        '            Me.loaddata(CInt(txt_curpage.Text))
        '    End Select
        'End If
        Timer1.Enabled = False
    End Sub
    Private Sub txt_search_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_search.KeyUp
        Timer1.Interval = 200
        Timer1.Enabled = True
    End Sub
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Me.loaddata(CInt(txt_curpage.Text))
    End Sub


    'Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
    '    loaddata()
    'End Sub
    'Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
    '    Select_()
    'End Sub
    'Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
    '    Me.Dispose()
    'End Sub
    'Private Sub dgv_search_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_search.CellDoubleClick
    '    Select_()
    'End Sub
    'Private Sub Btn_Next_Click(sender As Object, e As EventArgs) Handles Btn_Next.Click
    '    txt_curpage.Text = CInt(txt_curpage.Text) + 1
    'End Sub

    'Private Sub Btn_last_Click(sender As Object, e As EventArgs) Handles Btn_last.Click
    '    txt_curpage.Text = CInt(txt_curpage.Text) - 1
    '    If CInt(txt_curpage.Text) < 1 Then
    '        txt_curpage.Text = 1
    '    End If
    'End Sub
    Private Sub Btn_Click(sender As Object, e As EventArgs)
        Select Case sender.name
            Case Btn_Next.Name
                If Me.loaddata(CInt(txt_curpage.Text) + 1) Then
                    txt_curpage.Text = CInt(txt_curpage.Text) + 1
                End If
            Case Btn_last.Name
                If Me.loaddata(CInt(txt_curpage.Text) - 1) Then
                    txt_curpage.Text = CInt(txt_curpage.Text) - 1
                End If

            Case btn_search.Name
                txt_curpage.Text = 1
                Me.loaddata(CInt(txt_curpage.Text))
            Case btn_ok.Name
                Select_()
            Case btn_cancel.Name
                Me.Dispose()
        End Select
    End Sub

    Private Sub DGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Try

            Select_()
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub F_SearchData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetEvent()
        search_by()

    End Sub
    Private Sub Select_()
        Dim Cur As CurrencyManager = Me.dgv_search.BindingContext(Me.dgv_search.DataSource, Me.dgv_search.DataMember)
        Me.s_row = Cur.Current.row
        'Dim array As Object() = New Object(s_row.Table.Columns.Count - 1 + 1 - 1) {}
        'Dim enumerator As IEnumerator = Me.dgv_search.SelectedRows.GetEnumerator()
        'While enumerator.MoveNext()
        '    Dim dataGridViewRow As DataGridViewRow = CType(enumerator.Current, DataGridViewRow)
        '    Dim num As Integer = s_row.Table.Columns.Count - 1
        '    For i As Integer = 0 To num
        '        array(i) = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(i).Value)
        '    Next
        '    s_row.Table.Rows.Clear()
        '    s_row.Table.Rows.Add(array)
        'End While

        Me.DialogResult = Windows.Forms.DialogResult.OK
        'Me.ReturnSelected = s_row.Table
    End Sub

    Private Sub search_by()
        Try
            Me.dgv_search.Columns.Clear()
            Dim Str As String = " select COLUMN_NAME from   INFORMATION_SCHEMA.COLUMNS IC  where TABLE_NAME = '" & Table & "' "

            Dim dt1 As DataTable = conn.ReadData(str)
            If dt1.Rows.Count > 0 Then
                cbo_Search.Items.Clear()
                For Each Val As DataRow In dt1.Rows
                    If Val.Item("column_name") = "IDX" Then Continue For
                    cbo_Search.Items.Add(Val.Item("column_name"))
                Next
                cbo_Search.Text = Defaultfield
            End If
            If AutoSearch Then
                txt_curpage.Text = 1
                loaddata(CInt(txt_curpage.Text))
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function loaddata(page As Integer) As Boolean
        Try
            If page < 1 Then page = 1
            Dim str As String = " Select  * from (" & Query & ") As ss where [" & cbo_Search.Text.Trim & "] Like '%" & txt_search.Text.Trim & "%'"
            str &= " order by [" & cbo_Search.Text & "] desc "
            str &= " OFFSET ((" & page & " -1) * " & TOP & ") ROWS FETCH NEXT " & TOP & " ROWS ONLY "

            Dim dt As DataTable = conn.ReadData(str)

            dgv_search.Columns.Clear()
            dgv_search.DataSource = dt
                For Each dgvCol As DataGridViewColumn In dgv_search.Columns
                    dgvCol.HeaderText = UCase(dgvCol.HeaderText)
                Next
                dgv_search.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8)
            Try
                dgv_search.Columns("IDX").Visible = False
            Catch ex As Exception
            End Try
            If Hid_col <> String.Empty Then
                Dim col() As String = Hid_col.Split(",")
                For i As Integer = 0 To col.Length
                    Try
                        dgv_search.Columns(col(i)).Visible = False
                    Catch ex As Exception : End Try
                Next
            End If

            'For Each dgvRow As DataGridViewRow In DGSaleItem.Rows
            '    Select Case dgvRow.Cells("Status").Value
            '        Case "Cancelled"
            '            dgvRow.DefaultCellStyle.BackColor = Color.Silver
            '            dgvRow.DefaultCellStyle.ForeColor = Color.Black
            '    End Select
            'Next

            dgv_search.AutoResizeColumns()
                Return True
            If dt.Rows.Count <= 0 Then
                dgv_search.DataSource = Nothing
                MessageBox.Show("ไม่พบข้อมูล ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class

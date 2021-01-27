Imports Control_us
Imports MD
Imports Newtonsoft.Json
Public Class F_SearchData
    Public s_row As DataRow
    Public DTResult As DataTable
    Public Property Multiselect As Boolean = True
    Public Property Frm_text As String
    Public Property SCR_TYPE As String
    Public Property fixvalue As String
    Public Property lbl_CODE_text As String
    Public Property lbl_NAME_text As String
    Public Property grid_code_text As String
    Public Property grid_name_text As String

    'Public Property grid_txt_value1 As String = ""
    'Public Property grid_txt_value2 As String = ""
    'Public Property grid_Num_value1 As String = ""
    'Public Property grid_Num_value2 As String = ""

    Public Grid_column As New List(Of GridColumn)

    Public Class GridColumn
        Public Property Columntext As String = ""
        Public Property ColumnName As String = ""
        Public Property visible As Boolean = True
    End Class
    Private Sub F_SearchProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = F_Main.Icon
        Me.Text = Frm_text
        Me.lbl_code.Text = lbl_CODE_text
        Me.lbl_name.Text = lbl_NAME_text



        Gencolumn()
        Loaddata()
    End Sub

    Private Sub Loaddata()
        Try

            Gencolumn()

            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String

            Link = String.Format(Center.Get_API.Search_MAS, Me.SCR_TYPE, fixvalue, txt_code.Text.Trim, txt_name.Text.Trim)
            json_Response = conn_api.GETSON(Link)
            Dim ret As New SCR_MODELS.value_SeachMase
            ret = (JsonConvert.DeserializeObject(Of SCR_MODELS.value_SeachMase)(json_Response))
            If ret.Respon.Result Then
                If ret.Data.Count <= 0 Then
                    Messages.Texts("ค้นหา", Cl_massage.SCR01, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Exit Sub
                End If


                dgv_scr.DataSource = ret.Data
                Dim i As Integer = 1
                For Each val As DataGridViewRow In dgv_scr.Rows
                    val.Cells("SEQ").Value = i
                    i += 1
                Next

            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Public Sub Gencolumn()
        dgv_scr.DataSource = Nothing
        dgv_scr.Rows.Clear()
        dgv_scr.Columns.Clear()
        dgv_scr.AutoGenerateColumns = False
        Dim Col As New DataGridViewTextBoxColumn
        Dim btn As New DataGridViewButtonColumn
        'Dim Chk As New DataGridViewCheckBoxColumn
        Dim read As Boolean = True


        Me.dgv_scr.MultiSelect = Me.Multiselect

            Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ลำดับ"
        Col.Width = 50
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "SEQ"
        Col.Name = "SEQ"
        Me.dgv_scr.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = grid_code_text
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "CODE"
        Col.Name = "CODE"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = grid_name_text
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "NAME"
        Col.Name = "NAME"
        Me.dgv_scr.Columns.Add(Col)






        ' value
        For Each valcol As GridColumn In Me.Grid_column

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = valcol.Columntext
            Col.Width = 50
            Col.Visible = valcol.visible
            Col.ReadOnly = read
            Col.DataPropertyName = valcol.ColumnName
            Col.Name = valcol.ColumnName
            Me.dgv_scr.Columns.Add(Col)
        Next

        'Col = New DataGridViewTextBoxColumn
        'Col.HeaderText = grid_txt_value2
        'Col.Width = 50
        'Col.Visible = If(grid_txt_value2 = "", False, True)
        'Col.ReadOnly = read
        'Col.DataPropertyName = "value2"
        'Col.Name = "value2"
        'Me.dgv_scr.Columns.Add(Col)


        'Col = New DataGridViewTextBoxColumn
        'Col.HeaderText = grid_Num_value1
        'Col.Width = 50
        'Col.Visible = If(grid_Num_value1 = "", False, True)
        'Col.ReadOnly = read
        'Col.DataPropertyName = "value3"
        'Col.Name = "value3"
        'Me.dgv_scr.Columns.Add(Col)


        'Col = New DataGridViewTextBoxColumn
        'Col.HeaderText = grid_Num_value2
        'Col.Width = 50
        'Col.Visible = If(grid_Num_value2 = "", False, True)
        'Col.ReadOnly = read
        'Col.DataPropertyName = "value4"
        'Col.Name = "value4"
        'Me.dgv_scr.Columns.Add(Col)


    End Sub

    Private Sub Button_US1_Click(sender As Object, e As EventArgs) Handles brn_scr.Click
        Loaddata()
    End Sub


    Private Sub pcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_code.KeyDown, txt_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            Loaddata()
        End If
    End Sub


    Private Sub Button_US2_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        'If (DTResult IsNot Nothing) Then
        '    Dim tmpDT As DataTable = DTResult.Copy
        '    Dim param(tmpDT.Columns.Count - 1) As Object
        '    tmpDT.Rows.Clear()
        '    For Each Val As DataGridViewRow In dgv_scr.SelectedRows
        '        For icol As Integer = 0 To tmpDT.Columns.Count - 1
        '            param(icol) = Val.Cells(icol).Value
        '        Next
        '        tmpDT.Rows.Add(param)
        '    Next
        '    If tmpDT.Rows.Count > 0 Then
        '        ReturnSelected = tmpDT
        '    Else
        '        ReturnSelected = Nothing
        '    End If

        '    Me.DialogResult = DialogResult.OK
        '    Me.Close()
        'Else
        '    MessageBox.Show("Selection data not found !", "Message 138", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        Confirm()
    End Sub
    Private Sub Confirm()

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub dgv_scr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_scr.CellContentClick

    End Sub

    Private Sub dgv_scr_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_scr.CellDoubleClick
        'Dim Cur As CurrencyManager = Me.dgv_scr.BindingContext(Me.dgv_scr.DataSource, Me.dgv_scr.DataMember)
        'Me.s_row = Cur.Current.row
        Confirm()
    End Sub
End Class
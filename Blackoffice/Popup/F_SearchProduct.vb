Imports Control_us
Imports MD
Imports Newtonsoft.Json

Public Class F_SearchProduct
    Public s_row As DataRow
    Public DTResult As DataTable
    Private Sub F_SearchProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = F_Main.Icon
        Gencolumn()
        Loaddata()
    End Sub

    Private Sub Loaddata()
        Try

            Gencolumn()

            Dim conn_api As New API(Center.Data_Config.API_SRV)
            'Dim Link As String
            'Dim json_Response As String



            ''Link = String.Format(Center.Post_API.SCR_PRODUCT_chk_stock, pcode.Text.Trim, pname.Text.Trim, "")
            ''json_Response = conn_api.GETSON(Link)
            ''Dim ret As New Mas_Product_Model.value_SCR
            ''ret = (JsonConvert.DeserializeObject(Of Mas_Product_Model.value_SCR)(json_Response))

            Dim value As New Mas_Product_Model.Product_SCR
            value.PCODE = pcode.Text.Trim
            value.PNAME = pname.Text.Trim
            value.PTNAME = PTNAME.Text.Trim
            value.PGNAME = PGNAME.Text.Trim

            Dim json As String = JsonConvert.SerializeObject(value)
            Dim link As String = String.Format(Center.Post_API.SCR_PRODUCT_chk_stock, Center.Limit_Search)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV).POSTResponse(Link, json, "POST")
            Dim ret As Mas_Product_Model.value_SCR = JsonConvert.DeserializeObject(Of Mas_Product_Model.value_SCR)(json_Response)




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


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ลำดับ"
        Col.Width = 50
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "SEQ"
        Col.Name = "SEQ"
        Me.dgv_scr.Columns.Add(Col)



        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "รหัสสินค้า"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PCODE"
        Col.Name = "PCODE"
        Me.dgv_scr.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ชื่อสินค้า"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PNAME"
        Col.Name = "PNAME"
        Me.dgv_scr.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ประเภทสินค้า"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PTNAME"
        Col.Name = "PTNAME"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "กลุ่มสินค้า"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PGNAME"
        Col.Name = "PGNAME"
        Me.dgv_scr.Columns.Add(Col)



        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ต้นทุนทาตรฐาน"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "COST_STD"
        Col.Name = "COST_STD"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "UNITCODE"
        Col.Width = 50
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "UNITCODE"
        Col.Name = "UNITCODE"
        Me.dgv_scr.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "หน่วยนับ"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "UNITNAME"
        Col.Name = "UNITNAME"
        Me.dgv_scr.Columns.Add(Col)

    End Sub

    Private Sub Button_US1_Click(sender As Object, e As EventArgs) Handles Button_US1.Click
        Loaddata()
    End Sub


    Private Sub pcode_KeyDown(sender As Object, e As KeyEventArgs) Handles pcode.KeyDown, pname.KeyDown, PTNAME.KeyDown, PGNAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            Loaddata()
        End If
    End Sub


    Private Sub Button_US2_Click(sender As Object, e As EventArgs) Handles Button_US2.Click
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
Imports Control_us
Imports MD
Imports Newtonsoft.Json
Public Class F_Multicard
    Public dt_card As New DataTable
    Public Property Amount As Decimal
    Public Property Barcode As String
    Private Sub F_Multicard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = F_Main_Sale.Icon
        Gencolumn()
        ClearControl()
        Me.Timer1.Enabled = True
    End Sub
    Private Sub ClearControl()
        txt_barcode.Text = ""
        txt_Amount.Text = Me.Amount
        txt_card_Amount.Text = 0
        txt_amount_remain.Text = Me.Amount
    End Sub
    Private Sub Button_US1_Click(sender As Object, e As EventArgs) Handles btn_cancell.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub Button_US2_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If Me.DGV_Card.Rows.Count > 0 Then
                Me.DGV_Card.Rows.Remove(Me.DGV_Card.CurrentRow)
                Me.dt_card.AcceptChanges()
                calTotel()
            Else
                ClearControl()
            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Public Sub Gencolumn()
        Try
            Me.DGV_Card.AutoGenerateColumns = False
            Me.DGV_Card.Columns.Clear()
            Dim Col As New DataGridViewTextBoxColumn
            'Dim btn As New DataGridViewButtonColumn
            'Dim Chk As New DataGridViewCheckBoxColumn
            Dim read As Boolean = True

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รายการที่"
            Col.Width = 80
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "SEQ"
            Col.Name = "SEQ"
            Me.DGV_Card.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "บาร์โค๊ด"
            'Col.Width = 80
            Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "BARCODE"
            Col.Name = "BARCODE"
            Me.DGV_Card.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รอบที่"
            Col.Width = 80
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "CUSED"
            Col.Name = "CUSED"
            Me.DGV_Card.Columns.Add(Col)
            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รอบที่"
            Col.Width = 80
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "CUSED1"
            Col.Name = "CUSED1"
            Me.DGV_Card.Columns.Add(Col)


            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จำนวนเงิน"
            Col.Width = 80
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "MRTAMOUNT"
            Col.Name = "MRTAMOUNT"
            Me.DGV_Card.Columns.Add(Col)
            'Me.DGV_Product.AutoResizeColumns()

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จำนวนเงินปัจจุบัน"
            Col.Width = 80
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "CBALANCE"
            Col.Name = "CBALANCE"
            Me.DGV_Card.Columns.Add(Col)
            'Me.DGV_Product.AutoResizeColumns()

            Me.dt_card.Rows.Clear()
            Me.dt_card.Columns.Clear()
            With Me.dt_card.Columns
                .Add("SEQ")
                .Add("BARCODE")
                .Add("CUSED")
                .Add("CUSED1")
                .Add("MRTAMOUNT", GetType(Decimal))
                .Add("CBALANCE", GetType(Decimal))

            End With
            DGV_Card.DataSource = Me.dt_card

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try

    End Sub
    Private Sub Txt_barcode_GotFocus(sender As Object, e As EventArgs) Handles txt_barcode.GotFocus
        txt_barcode.Clear()
    End Sub
    Private Sub txt_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            scan_barcode()
            txt_barcode.Clear()
        End If
    End Sub
    Private Function chkbarcode() As Boolean
        If Me.txt_barcode.Text.Trim = Me.Barcode.Trim Then
            Messages.Texts(Me.Text, "บาร์โค๊ด " & Me.txt_barcode.Text & " ถูกใช้แล้ว", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            Return False
        End If
        Dim drow() As DataRow
        drow = Me.dt_card.Select("BARCODE = '" & Me.txt_barcode.Text.Trim & "'")
        If drow.Length > 0 Then
            Messages.Texts(Me.Text, "บาร์โค๊ด " & Me.txt_barcode.Text & " ถูกใช้แล้ว", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            Return False
        End If
        Return True
    End Function
    Private Sub scan_barcode()
        Try

            If Not chkbarcode() Then
                Exit Sub
            End If

            'Dim dt As DataTable
            Dim ret As New CHK_cardsModels.value
            Dim link As String = Center.Link_API.Get_API.CARDTRANS_CHKcard_Multi & Me.txt_barcode.Text & "&Nettotel=" & txt_amount_remain.Text
            Dim json = New API(Center.Data_Config.API,).GETSON(link)
            ret = (JsonConvert.DeserializeObject(Of CHK_cardsModels.value)(json))
            If ret.Respon.Result Then
                If ret.Data.Count > 0 Then
a:
                    DGV_Product_Add(ret.Data(0))
                    calTotel()
                End If
            Else
                If ret.Respon.Result_value = "BROKE" Then
                    GoTo a
                End If
                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            'Return "0"
        End Try
    End Sub
    Private Sub calTotel()
        Try


            txt_card_Amount.Text = Me.dt_card.Compute("sum(MRTAMOUNT)", "")
            txt_amount_remain.Text = CInt(txt_Amount.Text) - CInt(txt_card_Amount.Text)
            If CInt(txt_amount_remain.Text) > 0 Then
                Me.txt_barcode.US_Enable = True
                Me.txt_barcode.ForeColor = Color.DimGray
                Me.Timer1.Enabled = True
            Else
                Me.txt_barcode.US_Enable = False
                Me.txt_barcode.ForeColor = Color.White
                Me.Timer1.Enabled = False
            End If
        Catch ex As Exception
            txt_card_Amount.Text = 0
            txt_amount_remain.Text = 0
        End Try
    End Sub

    Private Sub DGV_Product_Add(val As CHK_cardsModels.Model)
        Try
            Dim drow As DataRow
            drow = dt_card.NewRow
            drow("SEQ") = dt_card.Rows.Count + 1
            drow("BARCODE") = val.BARCODE
            drow("CUSED") = val.CUSED
            drow("CUSED1") = val.CUSED1
            Dim cbal As Double = 0
            If (val.CBALANCE >= Int(txt_amount_remain.Text)) Then
                cbal = txt_amount_remain.Text
            Else
                cbal = val.CBALANCE
            End If
            drow("MRTAMOUNT") = cbal
            drow("CBALANCE") = val.CBALANCE
            Me.dt_card.Rows.Add(drow)
            DGV_Card.DataSource = Me.dt_card
            Me.dt_card.AcceptChanges()

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txt_barcode.Focus()
    End Sub

    Private Sub Txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged

    End Sub
End Class
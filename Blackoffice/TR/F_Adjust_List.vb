Imports Control_us
Imports MD
Imports Newtonsoft.Json
Public Class F_Adjust_List
    Implements MD.CL_interface.DefultFoundation

    Dim UI_STAT As MD.CL_interface.MemberFormStatus = CL_interface.MemberFormStatus.UIOpen
    Public SCR_TR_ID As String
    Dim frm_sub As New F_Adjust
    Dim menustruc As New Menu.menuStruct

    Private Sub F_MAS_Product_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        F_Main.lbl_Display.Text = Me.Tag.MenuName
    End Sub
    Private Sub F_Receive_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
#Region "Event"
    Public Sub SetEvent() Implements CL_interface.DefultFoundation.SetEvent
        'text
        'AddHandler Me.UNITCODE.TextChanged, AddressOf EV_Text_Changed
        'AddHandler Me.UNITNAME.TextChanged, AddressOf EV_Text_Changed

        'Text_KeyUp
        AddHandler txt_scr.KeyUp, AddressOf EV_Text_KeyUp


        'KeyDown
        AddHandler txt_scr.KeyDown, AddressOf EV_Text_KeyDown



        'KeyPress
        AddHandler txt_curpage.KeyPress, AddressOf EV_Text_KeyPress

        'btn
        AddHandler Me.btn_new.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_edit.Click, AddressOf EV_Btn_Click
        AddHandler Me.Btn_View.Click, AddressOf EV_Btn_Click
        AddHandler Me.btndelete.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_close.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_cancel.Click, AddressOf EV_Btn_Click


        AddHandler Me.btn_scr.Click, AddressOf EV_Btn_Click







        ' dgv
        AddHandler dgv_scr.CellMouseClick, AddressOf EV_DGV_CellMouseClick
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Timer1.Enabled = False
            If IsNumeric(txt_curpage.Text) Then
                Me.FSearch()
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub EV_Text_Changed(sender As Object, e As EventArgs)
        sender.ucClear_err()
    End Sub
    Private Sub EV_Text_KeyUp(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then Exit Sub
        Select Case sender.name
            Case txt_scr.Name
                txt_curpage.Text = 1
                Timer1.Interval = Center.Auto_Search_Interval
                Timer1.Enabled = True
            Case txt_curpage.Name
                Timer1.Interval = Center.Auto_Search_Interval
                Timer1.Enabled = True
        End Select

    End Sub
    Private Sub EV_Text_KeyPress(sender As Object, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or (e.KeyChar = vbBack) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub EV_Text_KeyDown(sender As Object, e As KeyEventArgs)
        Timer1.Enabled = False

    End Sub
    Private Sub EV_Btn_Click(sender As Object, e As EventArgs)
        Try
            Select Case sender.name
                Case btn_scr.Name
                    txt_curpage.Text = 1
                    Me.FSearch()


                Case btn_new.Name : FNew()
                Case btn_edit.Name : FEdit()
                Case Btn_View.Name : FView()
                Case btndelete.Name : FDelete()
                Case btn_close.Name : FExit()
                Case btn_cancel.Name : FCancel()
                Case Btn_last.Name
                    'All_Function.pag_search.page_last(txt_curpage)
                    'Me.ToolbarSearch()
                Case Btn_Next.Name
                    'All_Function.pag_search.page_Next(txt_curpage)
                    'scr.List_Master(Me.dgv_scr, Me.ToolStripComboBox1, txt_scr, v_table, CInt(txt_curpage.Text))

            End Select
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Private Sub EV_DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            EnableControl(True)
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
#End Region

    Public Sub EnableControl(Value As Boolean) Implements CL_interface.DefultFoundation.EnableControl
        Try

            If dgv_scr.CurrentRow.Cells("DCSTAT").Value = "SUBMIT" Then
                btn_edit.Enabled = False
            Else
                btn_edit.Enabled = True
            End If

            If dgv_scr.CurrentRow.Cells("DCSTAT").Value = "CANCEL" Then
                btn_cancel.Enabled = False
            Else
                btn_cancel.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ClearControl() Implements CL_interface.DefultFoundation.ClearControl
        Gencolumn()
    End Sub

    Public Sub Load_MAS() Implements CL_interface.DefultFoundation.Load_MAS
        Try
            Dim dt As New DataTable
            dt.Columns.Add("value")
            dt.Columns.Add("name")
            dt.Rows.Add("DOCNO", "เลขที่เอกสาร")
            dt.Rows.Add("DOCDATE", "วันที่เอกสาร")
            dt.Rows.Add("PERNAME", "ผู้ทำรายการ")
            dt.Rows.Add("STNAME", "คลัง")
            With cbo_search.ComboBox
                .DataSource = dt
                .ValueMember = "value"
                .DisplayMember = "name"
                .SelectedIndex = 0
            End With

            With cbo_topdisplay.ComboBox
                .DataSource = Tmp_Data.selecttop
                .ValueMember = "value"
                .DisplayMember = "name"
                .SelectedIndex = 0
            End With

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Public Sub Load_Data(value1 As String, value2 As String, value3 As Object) Implements CL_interface.DefultFoundation.Load_Data

    End Sub

    Public Sub Gencolumn() Implements CL_interface.DefultFoundation.Gencolumn

        dgv_scr.DataSource = Nothing
        dgv_scr.Rows.Clear()
        dgv_scr.Columns.Clear()
        Dim Col As New DataGridViewTextBoxColumn
        'Dim btn As New DataGridViewButtonColumn
        'Dim Chk As New DataGridViewCheckBoxColumn
        Dim read As Boolean = True


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "หมายเลขเอกสาร"
        Col.Width = 100
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "TR_ID"
        Col.Name = "TR_ID"
        Me.dgv_scr.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "เลขที่เอกสาร"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "DOCNO"
        Col.Name = "DOCNO"
        Me.dgv_scr.Columns.Add(Col)



        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ประเภทเอกสาร"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "DOCTYPE"
        Col.Name = "DOCTYPE"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "วันที่เอกสาร"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "DOCDATE"
        Col.Name = "DOCDATE"
        Me.dgv_scr.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "เลขอ้างอิง"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "REF_DOCNO"
        Col.Name = "REF_DOCNO"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "คลัง"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "STNAME"
        Col.Name = "STNAME"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "จำนวนรับเข้า"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "TOTAL_QTY"
        Col.Name = "TOTAL_QTY"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ผู้ทำรายการ"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PERNAME"
        Col.Name = "PERNAME"
        Me.dgv_scr.Columns.Add(Col)



        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "สถานะเอกสาร"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "DCSTAT"
        Col.Name = "DCSTAT"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "วันที่แก้ไข"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "MDATE"
        Col.Name = "MDATE"
        Me.dgv_scr.Columns.Add(Col)

        'Col = New DataGridViewTextBoxColumn
        'Col.HeaderText = "หมายเหตุ"
        'Col.Width = 50
        'Col.Visible = True
        'Col.ReadOnly = read
        'Col.DataPropertyName = "REMARK"
        'Col.Name = "REMARK"
        'Me.dgv_scr.Columns.Add(Col)




    End Sub

    Public Sub SetDefalt() Implements CL_interface.DefultFoundation.SetDefalt
        menustruc = Me.Tag
    End Sub

    Public Sub Err(value1 As Object, Optional value2 As String = "") Implements CL_interface.DefultFoundation.Err

    End Sub



    Public Function FNew() As CL_interface.Answer Implements CL_interface.DefultFoundation.FNew
        Try
            Dim Menu As New Menu
            Me.UI_STAT = CL_interface.MemberFormStatus.UINew
            'frm.TR_ID = dgv_scr.CurrentRow.Cells("TR_ID").Value
            frm_sub.Tag = Me.Tag
            frm_sub.UI_STAT = CL_interface.MemberFormStatus.UINew
            Menu.LoadSubform(frm_sub)
            Return CL_interface.Answer.Yes
        Catch ex As Exception
            If ex.ToString.Contains("Cannot access a disposed object") Then
                frm_sub = New F_Adjust
                FNew()
            Else
                Me.UI_STAT = CL_interface.MemberFormStatus.OnError
                Msg_err.Show_Err(ex, Me.Text)
            End If

        End Try
    End Function

    Public Function FEdit() As CL_interface.Answer Implements CL_interface.DefultFoundation.FEdit
        Try
            If dgv_scr.Rows.Count = 0 Then
                Messages.Texts(Me.Text, "กรุณาเลือกรายการ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Function
            End If
            If dgv_scr.CurrentRow.Cells("TR_ID").Value Is Nothing Then
                Messages.Texts(Me.Text, "กรุณาเลือกรายการ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Function
            End If

            Dim Menu As New Menu

            frm_sub.SCR_TR_ID = dgv_scr.CurrentRow.Cells("TR_ID").Value
            frm_sub.Tag = Me.Tag
            frm_sub.UI_STAT = CL_interface.MemberFormStatus.UIEdit
            Dim ret = Menu.LoadSubform(frm_sub)
            If ret = Menu.Frm_State.BringToFront Then
                frm_sub.state_view()
            End If
            Return CL_interface.Answer.Yes
        Catch ex As Exception
            If ex.ToString.Contains("Cannot access a disposed object") Then
                frm_sub = New F_Adjust
                FEdit()
            Else
                Me.UI_STAT = CL_interface.MemberFormStatus.OnError
                Msg_err.Show_Err(ex, Me.Text)
            End If
        End Try
    End Function

    Public Function FView(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FView
        Try
            If dgv_scr.Rows.Count = 0 Then
                Messages.Texts(Me.Text, "กรุณาเลือกรายการ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Function
            End If
            If dgv_scr.CurrentRow.Cells("TR_ID").Value Is Nothing Then
                Messages.Texts(Me.Text, "กรุณาเลือกรายการ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Exit Function
            End If
            Dim Menu As New Menu

            frm_sub.SCR_TR_ID = dgv_scr.CurrentRow.Cells("TR_ID").Value
            frm_sub.Tag = Me.Tag
            frm_sub.UI_STAT = CL_interface.MemberFormStatus.UIView
            Dim ret = Menu.LoadSubform(frm_sub)
            If ret = Menu.Frm_State.BringToFront Then
                frm_sub.state_view()
            End If


            Return CL_interface.Answer.Yes
        Catch ex As Exception
            If ex.ToString.Contains("Cannot access a disposed object") Then
                frm_sub = New F_Adjust
                FView()
            Else
                Me.UI_STAT = CL_interface.MemberFormStatus.OnError
                Msg_err.Show_Err(ex, Me.Text)
            End If
        End Try
    End Function

    Public Function FExit() As CL_interface.Answer Implements CL_interface.DefultFoundation.FExit
        Me.Close()
    End Function

    Public Function Checkdata() As Boolean Implements CL_interface.DefultFoundation.Checkdata

    End Function

    Public Function FSave(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FSave

    End Function

    Public Function FSearch(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FSearch

        Try

            UI_STAT = CL_interface.MemberFormStatus.UISearch
            Gencolumn()
            Dim DOCNO As String = ""
            Dim DOCDATE As String = ""
            Dim PERNAME As String = ""
            Dim STNAME As String = ""



            If cbo_search.ComboBox.SelectedValue = "DOCNO" Then
                DOCNO = txt_scr.Text.Trim
            ElseIf cbo_search.ComboBox.SelectedValue = "DOCDATE" Then
                If IsDate(txt_scr.Text.Trim) Then
                    DOCDATE = txt_scr.Text.Trim
                Else
                    Throw New Exception("Incorrect date format <br/> EX. 12/08/2020 or 2020/08/12")
                End If

            ElseIf cbo_search.ComboBox.SelectedValue = "PERNAME" Then
                PERNAME = txt_scr.Text.Trim
            ElseIf cbo_search.ComboBox.SelectedValue = "STNAME" Then
                STNAME = txt_scr.Text.Trim
            End If



            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String

            Link = String.Format(Center.Get_API.TR_MOV_List_Data, menustruc.DOCTYPE, DOCNO, DOCDATE, PERNAME, STNAME, cbo_topdisplay.Text)
            json_Response = conn_api.GETSON(Link)
            Dim ret As New TR_Mmovment_Models.value_List
            ret = (JsonConvert.DeserializeObject(Of TR_Mmovment_Models.value_List)(json_Response))
            If ret.Respon.Result Then
                If ret.Data.Count <= 0 Then
                    Messages.Texts("ค้นหา", Cl_massage.SCR01, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Return False
                End If


                dgv_scr.DataSource = ret.Data

                EnableControl(True)

            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        Finally
            SCR_TR_ID = Nothing
        End Try

    End Function

    Public Function FCancelSave(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancelSave

    End Function

    Public Function FDelete(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FDelete

    End Function

    Public Function FCancel(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancel

        Try


            If Messages.Texts(Me.Text, Cl_massage.ConfirmSave_Cancel & " เลขที่ " & dgv_scr.CurrentRow.Cells("DOCNO").Value, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.No Then
                Return CL_interface.Answer.No
            End If

            Dim data As New TR_Mmovment_Models.Data_List
            data.TR_ID = dgv_scr.CurrentRow.Cells("TR_ID").Value
            data.DCSTAT = dgv_scr.CurrentRow.Cells("DCSTAT").Value
            data.DOCTYPE = dgv_scr.CurrentRow.Cells("DOCTYPE").Value

            Dim json As String = JsonConvert.SerializeObject(data)
            Dim link As String = String.Format(Center.Post_API.TR_Movment_Cancel, UI_STAT)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV).POSTResponse(link, json, "POST")
            Dim retValue As TR_Mmovment_Models.value_Cancel = JsonConvert.DeserializeObject(Of TR_Mmovment_Models.value_Cancel)(json_Response)



            If retValue.Respon.Result Then
                Messages.Texts(Me.Text, Cl_massage.Confirmcancel_success, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                FSearch()
                Return CL_interface.Answer.Yes
            Else
                If retValue.Respon.SystemErrorMessage <> "" Then
                    'จากระบบ
                    Messages.Texts(Me.Text, retValue.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Else
                    Messages.Texts(Me.Text, retValue.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                End If
            End If


        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try



    End Function

    Public Function FPrint(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FPrint

    End Function

    Public Function FClose(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FClose

    End Function

    Public Function FCopy(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCopy
        Throw New NotImplementedException()
    End Function
End Class
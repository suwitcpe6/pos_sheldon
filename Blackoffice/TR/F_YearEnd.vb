Imports Control_us
Imports MD
Imports Newtonsoft.Json
Public Class F_YearEnd
    Implements MD.CL_interface.DefultFoundation

    Public UI_STAT As MD.CL_interface.MemberFormStatus
    Dim data As New TR_Mmovment_Models.Data_SAVE
    Public MOV_TYPE As String
    Public SCR_TR_ID As String
    Dim menustruc As New Menu.menuStruct
    Private Sub F_MAS_Product_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        F_Main.lbl_Display.Text = Me.Tag.MenuName2
    End Sub
    Private Sub F_Unit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        state_view()

    End Sub
    Public Sub state_view()

        Select Case Me.UI_STAT
            Case CL_interface.MemberFormStatus.UINew
                EnableControl(True)
            Case CL_interface.MemberFormStatus.UIEdit
                Me.Load_Data(SCR_TR_ID, Nothing, Nothing)
                EnableControl(True)
            Case CL_interface.MemberFormStatus.UIView
                Me.Load_Data(SCR_TR_ID, Nothing, Nothing)
                EnableControl(False)
            Case Else

        End Select
    End Sub

#Region "Event"
    Public Sub SetEvent() Implements CL_interface.DefultFoundation.SetEvent
        ''text
        'AddHandler Me.PCODE.TextChanged, AddressOf EV_Text_Changed
        'AddHandler Me.PNAME.TextChanged, AddressOf EV_Text_Changed

        ''Text_KeyUp
        'AddHandler txt_scr.KeyUp, AddressOf EV_Text_KeyUp


        ''KeyDown
        'AddHandler txt_scr.KeyDown, AddressOf EV_Text_KeyDown



        ''KeyPress
        'AddHandler txt_curpage.KeyPress, AddressOf EV_Text_KeyPress

        ''btn
        AddHandler Me.btn_addItems.Click, AddressOf EV_Btn_Click
        'AddHandler Me.btn_edit.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_save.Click, AddressOf EV_Btn_Click
        'AddHandler Me.btn_cancel_save.Click, AddressOf EV_Btn_Click

        'AddHandler Me.btndelete.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_Close.Click, AddressOf EV_Btn_Click


        AddHandler Me.btn_clear.Click, AddressOf EV_Btn_Click
        'AddHandler Me.IMGNAME1.Click, AddressOf EV_Btn_Click

        'AddHandler Me.btn_addunit.Click, AddressOf EV_Btn_Click





        '' dgv
        AddHandler DgvItems.CellClick, AddressOf Ev_DGV_CellClick

        'AddHandler dgv_unit.CellEndEdit, AddressOf EV_DGV_CellEndEdit
        AddHandler DgvItems.CellValueChanged, AddressOf EV_DGV_CellValueChanged
        'AddHandler dgv_unit.CellClick, AddressOf Ev_DGV_CellClick

        ''cbo
        AddHandler STCODE.SelectedIndexChanged, AddressOf EV_CBO_SelectedIndexChanged
        AddHandler STCODE.SelectionChangeCommitted, AddressOf EV_CBO_SelectionChangeCommitted
    End Sub



    Private Sub Ev_DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If e.RowIndex < 0 Then Exit Sub
            Select Case sender.Columns(e.ColumnIndex).Name
                Case "DEL"
                    sender.Rows.RemoveAt(e.RowIndex)
                    For i As Integer = 0 To sender.Rows.Count - 1
                        sender.Rows(i).Cells("seq").Value = i + 1
                    Next
                    sumTotal()
                Case "btn_unit"
                    SearchUnit()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EV_DGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

        Try

            Select Case sender.Columns(e.ColumnIndex).Name
                Case "QTY"
                    If Not IsNumeric(sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                        Messages.Texts(Me.Text, "กรุณาใส่ตัวเลข ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                        sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                    Else
                        With sender.Rows(e.RowIndex)
                            .Cells("ST_QTY").Value = CDbl(.Cells("QTY").Value) * CDbl(.Cells("ST_QTY2").Value)
                            .Cells("TOTAL_COST").Value = CDbl(.Cells("UNIT_COST").Value) * CDbl(.Cells("ST_QTY").Value)
                        End With

                    End If
                    sumTotal()
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub EV_DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        Try

            Select Case sender.Columns(e.ColumnIndex).Name
                Case "QTY_MAIN"
                    If Not IsNumeric(sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                        Messages.Texts(Me.Text, "กรุณาใส่ตัวเลข ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                        sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                    End If
                    sumTotal()
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub EV_Text_Changed(sender As Object, e As EventArgs)
        sender.ucClear_err()
    End Sub
    Private Sub EV_CBO_SelectedIndexChanged(sender As Object, e As EventArgs)
        sender.ucClear_err()
    End Sub
    Private Sub EV_CBO_SelectionChangeCommitted(sender As Object, e As EventArgs)
        'Select Case sender.name
        '    Case DCSTAT.Name
        '        If DCSTAT.SelectedValue = "SUBMIT" Then
        'End Select
    End Sub
    Private Sub EV_Text_KeyPress(sender As Object, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or (e.KeyChar = vbBack) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub EV_Btn_Click(sender As Object, e As EventArgs)
        Try
            Select Case sender.name
                Case btn_addItems.Name
                    SearchItems()

                Case btn_clear.Name
                    Gencolumn()

                'Case btn_new.Name : FNew()
                    'Case btn_edit.Name : FEdit()
                Case btn_save.Name : FSave()
                    'Case btn_cancel_save.Name : FCancelSave()
                    'Case btndelete.Name : FDelete()
                Case btn_Close.Name : FExit()
                    'Case Btn_last.Name
                    '    All_Function.pag_search.page_last(txt_curpage)
                    '    Me.ToolbarSearch()
                    'Case Btn_Next.Name
                    '    All_Function.pag_search.page_Next(txt_curpage)
                    '    scr.List_Master(Me.dgv_scr, Me.ToolStripComboBox1, txt_scr, v_table, CInt(txt_curpage.Text))
                    'Case IMGNAME1.Name
                    '    IMGNAME1.Image = FileDialog.FileDialog_img

                    'Case btn_addunit.Name
                    '    AddUnit()
            End Select
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub


#End Region
#Region "Implements"
    Public Sub EnableControl(Value As Boolean) Implements CL_interface.DefultFoundation.EnableControl

        Select Case Me.UI_STAT
            Case CL_interface.MemberFormStatus.UINew
                DOCTYPE.Enabled = Not Value
                DOCDATE.Enabled = Value
                DCSTAT.Enabled = Value
                REF_DOCNO.US_Enable = Value
                PERCODE.Enabled = Value
                STCODE.Enabled = Value
                DgvItems.ReadOnly = Not Value


                REMARK1.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                btn_save.Enabled = Value
            Case CL_interface.MemberFormStatus.UIEdit
                DOCTYPE.Enabled = False
                DOCDATE.Enabled = False
                DCSTAT.Enabled = Value
                REF_DOCNO.US_Enable = Value
                PERCODE.Enabled = Value
                STCODE.Enabled = False
                DgvItems.ReadOnly = Not Value


                REMARK1.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                btn_save.Enabled = Value
            Case CL_interface.MemberFormStatus.UIView
                DOCTYPE.Enabled = Value
                DOCDATE.Enabled = Value
                DCSTAT.Enabled = Value
                REF_DOCNO.US_Enable = Value
                PERCODE.Enabled = Value
                STCODE.Enabled = Value
                DgvItems.ReadOnly = Not Value


                REMARK1.US_Enable = Value
                DESCRIPTION.US_Enable = Value

                btn_save.Enabled = False
            Case Else

        End Select




    End Sub

    Public Sub ClearControl() Implements CL_interface.DefultFoundation.ClearControl


        DOCDATE.Value = Center.date_now
        'DCSTAT.SelectedIndex = 0
        REF_DOCNO.Text = ""
        'PERCODE.SelectedValue = cen
        'STCODE.Enabled = Value
        'DgvItems.ReadOnly = Not Value


        REMARK1.Text = ""
        DESCRIPTION.Text = ""





        Gencolumn()

    End Sub

    Public Sub Load_MAS() Implements CL_interface.DefultFoundation.Load_MAS
        Try
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String


            Link = String.Format(Center.Get_API.MAS_DOC_STATUS_Select, menustruc.DOCTYPE, Me.UI_STAT)
            json_Response = conn_api.GETSON(Link)

            Dim ret As New MAS_DOC_STATUS_MODELS.value
            ret = (JsonConvert.DeserializeObject(Of MAS_DOC_STATUS_MODELS.value)(json_Response))
            If ret.Respon.Result Then
                DCSTAT.DataSource = ret.Data
                DCSTAT.DisplayMember = "DOS_NAME"
                DCSTAT.ValueMember = "DOS_ID"
                DCSTAT.SelectedValue = "DRAFT"
            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                End If
            End If

            Load_Doctype()
            USERPROFILE()
            Load_stock()

            '    Dim dt As New DataTable
            '    dt.Columns.Add("value")
            '    dt.Columns.Add("name")
            '    dt.Rows.Add("PCODE", "รหัสสินค้า")
            '    dt.Rows.Add("PNAME", "ชื่อสินค้า")
            '    dt.Rows.Add("PGNAME", "ชื่อกลุ่มสินค้า")
            '    With cbo_search.ComboBox
            '        .DataSource = dt
            '        .ValueMember = "value"
            '        .DisplayMember = "name"
            '        .SelectedIndex = 0
            '    End With


        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Public Sub Load_Data(value1 As String, value2 As String, value3 As Object) Implements CL_interface.DefultFoundation.Load_Data

        Try

            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String

            Link = String.Format(Center.Get_API.TR_MOV_Select_Data, SCR_TR_ID)
            json_Response = conn_api.GETSON(Link)
            Dim ret As New TR_Mmovment_Models.value_SAVE
            ret = (JsonConvert.DeserializeObject(Of TR_Mmovment_Models.value_SAVE)(json_Response))

            If ret.Respon.Result Then
                data = ret.Data


                Me.TR_ID.Text = data.Data_H.TR_ID
                Me.DOCTYPE.SelectedValue = data.Data_H.DOCTYPE
                Me.DOCNO.Text = data.Data_H.DOCNO
                Me.DOCDATE.Value = data.Data_H.DOCDATE

                Me.TOTAL_QTY.Text = data.Data_H.TOTAL_QTY
                Me.TOTAL_AMOUNT.Text = data.Data_H.TOTAL_AMOUNT
                Me.REF_DOCNO.Text = data.Data_H.REF_DOCNO
                'Me.REF_DOCTYPE.Text = data.Data_H.REF_DOCTYPE
                'Me.LOT_ID.Text = data.Data_H.LOT_ID
                Me.STCODE.SelectedValue = data.Data_H.STCODE
                Me.REMARK1.Text = data.Data_H.REMARK1
                'Me.REMARK2.Text = data.Data_H.REMARK2
                'Me.REMARK3.Text = data.Data_H.REMARK3
                'Me.REMARK4.Text = data.Data_H.REMARK4
                'Me.REMARK5.Text = data.Data_H.REMARK5
                Me.DESCRIPTION.Text = data.Data_H.DESCRIPTION
                Me.DCSTAT.SelectedValue = data.Data_H.DCSTAT
                If data.Data_H.DCSTAT = CL_constan.DCSTAT.SUBMIT Then
                    DCSTAT.Enabled = False
                End If


                'Me.CDATE.Text = data.Data_H.CDATE
                'Me.CUSE.Text = data.Data_H.CUSE
                'Me.MDATE.Text = data.Data_H.MDATE
                'Me.MUSE.Text = data.Data_H.MUSE
                'Me.ISTAT.Text = data.Data_H.ISTAT
                Me.PERCODE.SelectedValue = data.Data_H.PERCODE
                'Me.PERNAME.Text = data.Data_H.PERNAME
                'Me.DAY_END.Text = data.Data_H.DAY_END
                Me.dtp_Year.Value = CDate("01/01/" & (CInt(data.Data_H.YEAR) + 543).ToString)


                Gencolumn()
                Dim cur_row As Integer
                For Each val As TR_Mmovment_Models.Data_MOVT_D In data.Data_ITEMS
                    cur_row = DgvItems.Rows.Add()
                    With DgvItems.Rows(cur_row)
                        .Cells("SEQ").Value = val.SEQ
                        .Cells("PCODE").Value = val.PCODE
                        .Cells("PNAME").Value = val.PNAME
                        .Cells("QTY").Value = val.QTY

                        .Cells("UNIT_COST").Value = val.UNIT_COST
                        .Cells("UNITCODE").Value = val.UNITCODE
                        .Cells("UNITNAME").Value = val.UNITNAME
                        .Cells("ST_QTY").Value = val.ST_QTY
                        .Cells("ST_QTY2").Value = val.ST_QTY2
                        '.Cells("ST_COST").Value = val.ST_COST
                        .Cells("ST_UNITCODE").Value = val.ST_UNITCODE
                        .Cells("ST_UNITNAME").Value = val.ST_UNITNAME
                        .Cells("TOTAL_COST").Value = val.TOTAL_COST
                        .Cells("REMARK1").Value = val.REMARK1
                        '.Cells("REMARK2").Value = val.REMARK2
                        '.Cells("REMARK3").Value = val.REMARK3
                        '.Cells("REMARK4").Value = val.REMARK4
                        '.Cells("REMARK5").Value = val.REMARK5
                    End With



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

    Public Sub Gencolumn() Implements CL_interface.DefultFoundation.Gencolumn
        DgvItems.DataSource = Nothing
        DgvItems.Rows.Clear()
        DgvItems.Columns.Clear()
        Dim Col As New DataGridViewTextBoxColumn
        Dim btn As New DataGridViewButtonColumn
        'Dim Chk As New DataGridViewCheckBoxColumn
        Dim read As Boolean = True


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ลำดับ"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "SEQ"
        Col.Name = "SEQ"
        Me.DgvItems.Columns.Add(Col)



        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "รหัสสินค้า"
        Col.Width = 100
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PCODE"
        Col.Name = "PCODE"
        Me.DgvItems.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ชื่อสินค้า"
        Col.Width = 300
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PNAME"
        Col.Name = "PNAME"
        Me.DgvItems.Columns.Add(Col)



        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "จำนวน"
        Col.Width = 80
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "QTY"
        Col.Name = "QTY"
        'Col.DefaultCellStyle.BackColor = T_Color.Grid_Cell_Edit
        Me.DgvItems.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "UNITCODE"
        Col.Width = 80
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "UNITCODE"
        Col.Name = "UNITCODE"
        Me.DgvItems.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "หน่วย"
        Col.Width = 80
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "UNITNAME"
        Col.Name = "UNITNAME"
        Me.DgvItems.Columns.Add(Col)


        'btn = New DataGridViewButtonColumn
        'btn.HeaderText = "..."
        'btn.Width = 50
        'btn.Visible = True
        'btn.ReadOnly = read
        'btn.DataPropertyName = "btn_unit"
        'btn.DefaultCellStyle.BackColor = T_Color.Grid_btn_SCR
        'btn.FlatStyle = FlatStyle.Flat
        'btn.Name = "btn_unit"
        'Me.DgvItems.Columns.Add(btn)




        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "จำนวนสต๊อก"
        Col.Width = 80
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "ST_QTY"
        Col.Name = "ST_QTY"
        Me.DgvItems.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "จำนวนสต๊อก2"
        Col.Width = 80
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "ST_QTY2"
        Col.Name = "ST_QTY2"
        Me.DgvItems.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ST_UNITCODE"
        Col.Width = 80
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "ST_UNITCODE"
        Col.Name = "ST_UNITCODE"
        Me.DgvItems.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "หน่วยสต๊อก"
        Col.Width = 80
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "ST_UNITNAME"
        Col.Name = "ST_UNITNAME"
        Me.DgvItems.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ต้นทุนต่อหน่วย(เฉลี่ย)"
        Col.Width = 150
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "UNIT_COST"
        Col.Name = "UNIT_COST"
        Me.DgvItems.Columns.Add(Col)



        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ต้นทุนรวม"
        Col.Width = 80
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "TOTAL_COST"
        Col.Name = "TOTAL_COST"
        Me.DgvItems.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "หมายเหตุ"
        Col.Width = 80
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "REMARK1"
        Col.Name = "REMARK1"
        Me.DgvItems.Columns.Add(Col)


        'btn = New DataGridViewButtonColumn
        'btn.HeaderText = "ลบ"
        'btn.Width = 50
        'btn.Visible = True
        'btn.ReadOnly = read
        'btn.DataPropertyName = "DEL"
        'btn.Name = "DEL"
        'btn.DefaultCellStyle.BackColor = T_Color.Grid_btn_DEL
        'btn.FlatStyle = FlatStyle.Flat
        'Me.DgvItems.Columns.Add(btn)

    End Sub


    Public Sub SetDefalt() Implements CL_interface.DefultFoundation.SetDefalt
        menustruc = Me.Tag
        MOV_TYPE = "IN"

    End Sub

    Public Sub Err(value1 As Object, Optional value2 As String = "") Implements CL_interface.DefultFoundation.Err

    End Sub
    Public Function FNew() As CL_interface.Answer Implements CL_interface.DefultFoundation.FNew

        Try
            Me.UI_STAT = CL_interface.MemberFormStatus.UINew
            ClearControl()
            EnableControl(True)
            Return CL_interface.Answer.Yes
        Catch ex As Exception
            Me.UI_STAT = CL_interface.MemberFormStatus.OnError
            Throw ex
        End Try
    End Function

    Public Function FEdit() As CL_interface.Answer Implements CL_interface.DefultFoundation.FEdit

        Try
            Me.UI_STAT = CL_interface.MemberFormStatus.UIEdit
            EnableControl(True)
            Return CL_interface.Answer.Yes
        Catch ex As Exception
            Me.UI_STAT = CL_interface.MemberFormStatus.OnError
            Throw ex
        End Try

    End Function

    Public Function FExit() As CL_interface.Answer Implements CL_interface.DefultFoundation.FExit


        Try


            'ตรวจสอบว่ามี Error ไหม
            If Me.UI_STAT = CL_interface.MemberFormStatus.OnError Then
                Me.Close()
            Else
                'ตรวจสอบสถานะว่าเป็น NEW หรือ EDIT ไหม
                If Me.UI_STAT = CL_interface.MemberFormStatus.UINew OrElse Me.UI_STAT = CL_interface.MemberFormStatus.UIEdit Then
                    If Me.UI_STAT = CL_interface.MemberFormStatus.UIEdit Then
                        FSearch()
                    End If
                    Select Case Messages.Texts(Me.Text, Cl_massage.ConfirmSave01, Messages.ButtonType.YesNoCancel, Messages.MessageBoxIcon.Question)


                        'ถาม Save ตอบ Yes
                        Case MsgBoxResult.Yes
                            'เข้า Function Save
                            FSave()
                            Select Case Me.UI_STAT
                                'Save ผ่าน
                                Case CL_interface.Answer.Yes
                                    Me.UI_STAT = CL_interface.MemberFormStatus.UIExit
                                    Me.Close()
                                    'Save ไม่ผ่าน
                                Case CL_interface.Answer.No
                                    Return CL_interface.Answer.No
                            End Select
                            'ไม่ Save
                        Case MsgBoxResult.No
                            Me.UI_STAT = CL_interface.MemberFormStatus.UIExit
                            Me.Close()
                            Return CL_interface.Answer.No
                            'กด Cancel ตอน Dialog Save
                        Case Else
                            Return CL_interface.Answer.Cancel
                    End Select
                Else
                    'ถ้าไม่ได้อยู่ในสถานะ NEW กับ EDIT ให้ออกได้เลย

                    Me.UI_STAT = CL_interface.MemberFormStatus.UIExit
                    Me.Close()
                    Return CL_interface.Answer.No
                End If

            End If
            Return True
        Catch ex As Exception
            Me.UI_STAT = CL_interface.MemberFormStatus.OnError
            Throw ex
            Return False
        End Try
    End Function

    Public Function Checkdata() As Boolean Implements CL_interface.DefultFoundation.Checkdata
        Dim msg As String = ""

        If STCODE.SelectedValue = "" Then
            STCODE.UCSet_err("กรุณาเลือกคลังสินค้า")
            msg = "- กรุณาเลือกคลังสินค้า"
        End If
        If Me.DgvItems.RowCount <= 0 Then
            msg &= vbNewLine & "- กรุณาเลือกรายการสินค้า"
        End If

        If msg <> "" Then
            Messages.Texts(Me.Text, " คุณไม่ได้กรอกข้อมูลดังต่อไปนี้" & vbNewLine & msg, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Public Function FSave(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FSave
        Try

            If Not Checkdata() Then
                Return CL_interface.Answer.No
            End If
            If Messages.Texts(Me.Text, Cl_massage.ConfirmSave01, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.No Then
                Return CL_interface.Answer.No
            End If

            If Not Save_H() Then
                Messages.Texts(Me.Text, Cl_massage.ConfirmSave_not_success, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Return CL_interface.Answer.No
            End If


            If Not Save_items() Then
                Messages.Texts(Me.Text, Cl_massage.ConfirmSave_not_success, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Return CL_interface.Answer.No
            End If

            Dim json As String = JsonConvert.SerializeObject(Me.data)
            Dim link As String = String.Format(Center.Post_API.Save_Data_YearEnd, UI_STAT)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV).POSTResponse(link, json, "POST")
            Dim retValue As Mas_Product_Group_Models.value_data = JsonConvert.DeserializeObject(Of Mas_Product_Group_Models.value_data)(json_Response)



            If retValue.Respon.Result Then
                Messages.Texts(Me.Text, Cl_massage.ConfirmSave_success, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                ClearControl()

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


    Public Function FSearch(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FSearch
        'Try
        '    EnableControl(False)
        '    UI_STAT = CL_interface.MemberFormStatus.UISearch
        '    Gencolumn()
        '    Dim PCODE As String = ""
        '    Dim PNAME As String = ""
        '    Dim PGCODE As String = ""
        '    If cbo_search.ComboBox.SelectedValue = "PCODE" Then
        '        PCODE = txt_scr.Text.Trim
        '    ElseIf cbo_search.ComboBox.SelectedValue = "PNAME" Then
        '        PNAME = txt_scr.Text.Trim
        '    ElseIf cbo_search.ComboBox.SelectedValue = "PGCODE" Then
        '        PGCODE = txt_scr.Text.Trim
        '    End If

        '    Dim conn_api As New API(Center.Data_Config.API_SRV)
        '    Dim Link As String
        '    Dim json_Response As String

        '    Link = String.Format(Center.Post_API.Get_API.PRODUCT_List, PCODE, PNAME, PGCODE)
        '    json_Response = conn_api.GETSON(Link)
        '    Dim ret As New Mas_Product_Model.value_List
        '    ret = (JsonConvert.DeserializeObject(Of Mas_Product_Model.value_List)(json_Response))
        '    If ret.Respon.Result Then
        '        If ret.Data.Count <= 0 Then
        '            Messages.Texts("ค้นหา", Cl_massage.SCR01, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
        '            Exit Function
        '        End If


        '        dgv_scr.DataSource = ret.Data
        '        Dim i As Integer = 1
        '        For Each val As DataGridViewRow In dgv_scr.Rows
        '            val.Cells("SEQ").Value = i
        '            i += 1
        '        Next

        '    Else
        '        If ret.Respon.SystemErrorMessage <> "" Then
        '            Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
        '        Else
        '            Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
        '        End If
        '    End If
        'Catch ex As Exception
        '    Msg_err.Show_Err(ex, Me.Text)
        'End Try
    End Function

    Public Function FCancelSave(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancelSave
        Try
            Select Case Messages.Texts(Me.Text, Cl_massage.ConfirmSave01, Messages.ButtonType.YesNoCancel, Messages.MessageBoxIcon.Question)
                        'ถาม Save ตอบ Yes
                Case MsgBoxResult.Yes
                    'เข้า Function Save
                    FSave()
                Case MsgBoxResult.No
                    UI_STAT = CL_interface.MemberFormStatus.UISearch
                    ClearControl()
                    EnableControl(False)
                Case Else

            End Select
        Catch ex As Exception

        End Try
    End Function

    Public Function FDelete(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FDelete

    End Function

    Public Function FCancel(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancel

    End Function

    Public Function FPrint(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FPrint

    End Function

    Public Function FClose(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FClose

    End Function
#End Region

#Region "SAVE"
    Private Function Save_H() As Boolean
        data.Data_H = New TR_Mmovment_Models.Data_MOVT

        data.Data_H.ID = 0
        data.Data_H.TR_ID = TR_ID.Text
        data.Data_H.DOCTYPE = DOCTYPE.SelectedValue
        data.Data_H.DOCNO = DOCNO.Text
        data.Data_H.DOCDATE = DOCDATE.Value
        data.Data_H.DOCYEAR = DOCDATE.Value.Year
        data.Data_H.DOCMONTH = DOCDATE.Value.Month
        data.Data_H.CORP_CODE = Center.data_profile.Corp.COMPANYCODE
        data.Data_H.Branch_CODE = Center.data_profile.Corp.BRNID
        data.Data_H.MOV_TYPE = MOV_TYPE
        data.Data_H.TOTAL_QTY = TOTAL_QTY.Text
        data.Data_H.TOTAL_AMOUNT = TOTAL_AMOUNT.Text
        data.Data_H.REF_DOCNO = REF_DOCNO.Text
        data.Data_H.REF_DOCTYPE = ""
        data.Data_H.LOT_ID = ""
        data.Data_H.STCODE = STCODE.SelectedValue
        data.Data_H.REMARK1 = REMARK1.Text
        data.Data_H.REMARK2 = ""
        data.Data_H.REMARK3 = ""
        data.Data_H.REMARK4 = ""
        data.Data_H.REMARK5 = ""
        data.Data_H.DESCRIPTION = DESCRIPTION.Text
        data.Data_H.DCSTAT = DCSTAT.Text
        data.Data_H.CDATE = Now
        data.Data_H.CUSE = Center.data_profile.user_id
        data.Data_H.MDATE = Now
        data.Data_H.MUSE = Center.data_profile.user_id
        data.Data_H.ISTAT = "1"
        data.Data_H.PERCODE = PERCODE.SelectedValue
        data.Data_H.PERNAME = PERCODE.Text
        data.Data_H.DAY_END = "N"
        data.Data_H.YEAR = New CL_date().Condate(dtp_Year.Value, "yyyy")

        Return True
    End Function
    Private Function Save_items() As Boolean
        data.Data_ITEMS = New List(Of TR_Mmovment_Models.Data_MOVT_D)

        Dim val As TR_Mmovment_Models.Data_MOVT_D
        For Each drow As DataGridViewRow In Me.DgvItems.Rows
            val = New TR_Mmovment_Models.Data_MOVT_D

            val.SEQ = drow.Cells("SEQ").Value


            val.TR_ID = TR_ID.Text
            val.DOCTYPE = DOCTYPE.SelectedValue
            val.DOCNO = DOCNO.Text


            val.SEQ = drow.Cells("SEQ").Value
            val.PCODE = drow.Cells("PCODE").Value
            val.PNAME = drow.Cells("PNAME").Value
            val.QTY = drow.Cells("QTY").Value
            val.IDC = 1
            val.UNIT_COST = drow.Cells("UNIT_COST").Value
            val.UNITCODE = drow.Cells("UNITCODE").Value
            val.UNITNAME = drow.Cells("UNITNAME").Value
            val.ST_QTY = drow.Cells("ST_QTY").Value
            val.ST_QTY2 = drow.Cells("ST_QTY2").Value
            val.ST_COST = drow.Cells("UNIT_COST").Value
            val.ST_UNITCODE = drow.Cells("ST_UNITCODE").Value
            val.ST_UNITNAME = drow.Cells("ST_UNITNAME").Value
            val.TOTAL_COST = drow.Cells("TOTAL_COST").Value
            val.REMARK1 = drow.Cells("REMARK1").Value
            val.REMARK2 = ""
            val.REMARK3 = ""
            val.REMARK4 = ""
            val.REMARK5 = ""



            data.Data_ITEMS.Add(val)
        Next
        Return True
    End Function

#End Region

#Region "Method"
    Private Sub sumTotal()
        Dim qty As Double = 0
        Dim amount As Double = 0
        For Each drow As DataGridViewRow In Me.DgvItems.Rows
            qty += CDbl(drow.Cells("QTY").Value)
            amount += CDbl(drow.Cells("TOTAL_COST").Value)
        Next

        Me.TOTAL_QTY.Text = qty
        Me.TOTAL_AMOUNT.Text = amount
    End Sub

    Public Function Load_Doctype()
        Try
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String
            Link = String.Format(Center.Get_API.MAS_DOCTYPE_Select, menustruc.DOCTYPE)

            json_Response = conn_api.GETSON(Link)
            Dim ret As New MAS_DOCTYPE_Models.value
            ret = (JsonConvert.DeserializeObject(Of MAS_DOCTYPE_Models.value)(json_Response))
            If ret.Respon.Result Then
                DOCTYPE.DataSource = ret.Data
                DOCTYPE.DisplayMember = "DOCTYPENAME"
                DOCTYPE.ValueMember = "DOCTYPECODE"
                'set default
                DOCTYPE.SelectedValue = menustruc.DOCTYPE

            Else

                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage.ToString)
                Else
                    If ret.Respon.SystemErrorMessage <> "" Then
                        Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Else
                        Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    End If
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Function

    Public Function USERPROFILE()
        Try
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String
            Link = String.Format(Center.Get_API.USERPROFILE_Select, "")

            json_Response = conn_api.GETSON(Link)
            Dim ret As New USERPROFILE_Mmodels.value
            ret = (JsonConvert.DeserializeObject(Of USERPROFILE_Mmodels.value)(json_Response))
            If ret.Respon.Result Then
                PERCODE.DataSource = ret.Data
                PERCODE.DisplayMember = "UFULLNAME"
                PERCODE.ValueMember = "UID"
                'set default
                PERCODE.SelectedValue = Center.data_profile.user_id

            Else

                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage.ToString)
                Else
                    If ret.Respon.SystemErrorMessage <> "" Then
                        Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Else
                        Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    End If
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Function



    Public Function Load_stock()
        Try
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String
            Link = String.Format(Center.Get_API.MAS_STOCK_List_CBO, "")

            json_Response = conn_api.GETSON(Link)
            Dim ret As New Mas_Stock_Models.value_List
            ret = (JsonConvert.DeserializeObject(Of Mas_Stock_Models.value_List)(json_Response))
            If ret.Respon.Result Then
                STCODE.DataSource = ret.Data
                STCODE.DisplayMember = "STNAME"
                STCODE.ValueMember = "STCODE"
                'set default
                STCODE.SelectedIndex = 0
                'STCODE.Text = "กรุณาเลือกคลัง"
            Else

                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage.ToString)
                Else
                    If ret.Respon.SystemErrorMessage <> "" Then
                        Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Else
                        Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    End If
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Function

    Private Sub SearchItems()

        Try

            'Dim f As New F_SearchProduct
            'f.Icon = Center.icon

            'If (f.ShowDialog) = DialogResult.OK Then






            '    Dim currow As Integer
            '    For Each Val As DataGridViewRow In f.dgv_scr.SelectedRows
            '        If Not check_items(Val.Cells("PCODE").Value) Then
            '            Continue For
            '        End If

            '        currow = Me.DgvItems.Rows.Add()
            '        With Me.DgvItems.Rows(currow)
            '            .Cells("SEQ").Value = currow + 1
            '            .Cells("PCODE").Value = Val.Cells("PCODE").Value
            '            .Cells("PNAME").Value = Val.Cells("PNAME").Value
            '            .Cells("QTY").Value = 1
            '            .Cells("ST_QTY").Value = 1
            '            .Cells("ST_QTY2").Value = 1
            '            .Cells("UNIT_COST").Value = Val.Cells("COST_STD").Value


            '            .Cells("UNITCODE").Value = Val.Cells("UNITCODE").Value
            '            .Cells("ST_UNITCODE").Value = Val.Cells("UNITCODE").Value


            '            .Cells("UNITNAME").Value = Val.Cells("UNITNAME").Value
            '            .Cells("ST_UNITNAME").Value = Val.Cells("UNITNAME").Value
            '            .Cells("TOTAL_COST").Value = Val.Cells("COST_STD").Value
            '            .Cells("REMARK1").Value = ""


            '        End With
            '    Next







            '    sumTotal()
            'End If





            Dim year As String = New CL_date().Condate(dtp_Year.Value, "yyyy")


            DgvItems.Rows.Clear()
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String
            Link = String.Format(Center.Get_API.Load_Data_YearEnd, year)

            json_Response = conn_api.GETSON(Link)
            Dim ret As New TR_Mmovment_Models.value_Data_Yearend
            ret = (JsonConvert.DeserializeObject(Of TR_Mmovment_Models.value_Data_Yearend)(json_Response))
            If ret.Respon.Result Then
                Dim currow As Integer
                For Each val As TR_Mmovment_Models.Data_MOVT_D In ret.Data



                    currow = Me.DgvItems.Rows.Add()
                    With Me.DgvItems.Rows(currow)
                        .Cells("SEQ").Value = currow + 1
                        .Cells("PCODE").Value = val.PCODE
                        .Cells("PNAME").Value = val.PNAME
                        .Cells("QTY").Value = val.ST_QTY
                        .Cells("ST_QTY").Value = val.ST_QTY
                        .Cells("ST_QTY2").Value = 1
                        .Cells("UNIT_COST").Value = val.ST_COST

                        .Cells("UNITCODE").Value = val.ST_UNITCODE
                        .Cells("ST_UNITCODE").Value = val.ST_UNITCODE


                        .Cells("UNITNAME").Value = val.ST_UNITNAME
                        .Cells("ST_UNITNAME").Value = val.ST_UNITNAME
                        .Cells("TOTAL_COST").Value = val.TOTAL_COST
                        .Cells("REMARK1").Value = ""


                    End With

                Next
                sumTotal()
            Else

                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage.ToString)
                Else
                    If ret.Respon.SystemErrorMessage <> "" Then
                        Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Else
                        Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    End If
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Function check_items(PCODE As String) As Boolean

        For Each g_row As DataGridViewRow In DgvItems.Rows
            If g_row.Cells("PCODE").Value = PCODE Then
                Return False
            End If
        Next

        Return True
    End Function


    Private Sub SearchUnit()

        Try
            Dim Grid_column As New List(Of F_SearchData.GridColumn)
            Grid_column.Add(New F_SearchData.GridColumn With {.Columntext = "จำนวนหน่วยหลัก", .ColumnName = "value1"})
            Dim f As New F_SearchData With {
                                                .Multiselect = False,
                                                .Frm_text = "ค้นหาหน่วยนับรอง",
                                                .SCR_TYPE = "UNIT",
                                                .fixvalue = DgvItems.CurrentRow.Cells("PCODE").Value,
                                                .lbl_CODE_text = "รหัสหน่วยนับ",
                                                .lbl_NAME_text = "ชื่อหน่วยนับ",
                                                .grid_code_text = "รหัสหน่วยนับ",
                                                .grid_name_text = "ชื่อหน่วยนับ",
                                                .Grid_column = Grid_column
                                            }
            f.Icon = Center.icon

            If (f.ShowDialog) = DialogResult.OK Then
                Dim currow As Integer
                For Each Val As DataGridViewRow In f.dgv_scr.SelectedRows
                    With Me.DgvItems.CurrentRow
                        .Cells("ST_QTY").Value = CDbl(.Cells("QTY").Value) * CDbl(Val.Cells("value1").Value)
                        .Cells("ST_QTY2").Value = CDbl(Val.Cells("value1").Value)
                        .Cells("UNITCODE").Value = Val.Cells("CODE").Value
                        .Cells("UNITNAME").Value = Val.Cells("NAME").Value
                        .Cells("TOTAL_COST").Value = CDbl(.Cells("UNIT_COST").Value) * CDbl(.Cells("ST_QTY").Value)
                    End With
                Next
                sumTotal()
            End If


        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Public Function FView(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FView
        Throw New NotImplementedException()
    End Function

    Public Function FCopy(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCopy
        Throw New NotImplementedException()
    End Function



#End Region
End Class
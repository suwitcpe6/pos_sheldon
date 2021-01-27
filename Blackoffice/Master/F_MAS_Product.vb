Imports System.ComponentModel
Imports Control_us
Imports MD
Imports Newtonsoft.Json
Public Class F_MAS_Product
    Implements MD.CL_interface.DefultFoundation

    Dim UI_STAT As MD.CL_interface.MemberFormStatus = CL_interface.MemberFormStatus.UIOpen
    Dim data_H As New Mas_Product_Model.Product_data
    Private Sub F_MAS_Product_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        F_Main.lbl_Display.Text = Me.Tag.MenuName
    End Sub
    Private Sub F_Unit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FSearch() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)

    End Sub
#Region "Event"
    Public Sub SetEvent() Implements CL_interface.DefultFoundation.SetEvent

        'text
        AddHandler Me.PCODE.TextChanged, AddressOf EV_Text_Changed
        AddHandler Me.PNAME.TextChanged, AddressOf EV_Text_Changed
        AddHandler Me.PRICE_STD.TextChanged, AddressOf EV_Text_Changed

        'Text_KeyUp
        AddHandler txt_scr.KeyUp, AddressOf EV_Text_KeyUp


        'KeyDown
        AddHandler txt_scr.KeyDown, AddressOf EV_Text_KeyDown



        'KeyPress
        AddHandler txt_curpage.KeyPress, AddressOf EV_Text_KeyPress

        'btn
        AddHandler Me.btn_new.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_edit.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_save.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_cancel_save.Click, AddressOf EV_Btn_Click

        AddHandler Me.btndelete.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_close.Click, AddressOf EV_Btn_Click


        AddHandler Me.btn_scr.Click, AddressOf EV_Btn_Click
        AddHandler Me.IMGNAME1.Click, AddressOf EV_Btn_Click

        AddHandler Me.btn_addunit.Click, AddressOf EV_Btn_Click





        ' dgv
        AddHandler dgv_scr.CellMouseClick, AddressOf EV_DGV_CellMouseClick

        AddHandler dgv_unit.CellEndEdit, AddressOf EV_DGV_CellEndEdit
        AddHandler dgv_unit.CellValueChanged, AddressOf EV_DGV_CellValueChanged
        AddHandler dgv_unit.CellClick, AddressOf Ev_DGV_CellClick

        'cbo
        AddHandler unit_add.SelectedIndexChanged, AddressOf EV_CBO_SelectedIndexChanged
        AddHandler UNITCODE.SelectedIndexChanged, AddressOf EV_CBO_SelectedIndexChanged
        AddHandler PTCODE.SelectedIndexChanged, AddressOf EV_CBO_SelectedIndexChanged
        AddHandler PGCODE.SelectedIndexChanged, AddressOf EV_CBO_SelectedIndexChanged
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
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EV_DGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

        Try

            Select Case sender.Columns(e.ColumnIndex).Name
                Case "QTY_MAIN"
                    If Not IsNumeric(sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                        Messages.Texts(Me.Text, "กรุณาใส่ตัวเลข ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                        sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                    End If
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
            End Select

        Catch ex As Exception

        End Try
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
    Private Sub EV_CBO_SelectedIndexChanged(sender As Object, e As EventArgs)
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


                Case btn_new.Name : FNew() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
                Case btn_edit.Name : FEdit() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
                Case btn_save.Name : FSave() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
                Case btn_cancel_save.Name : FCancelSave() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
                Case btndelete.Name : FDelete() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
                Case btn_close.Name : FExit()
                Case Btn_last.Name
                    'All_Function.pag_search.page_last(txt_curpage)
                    'Me.ToolbarSearch()
                Case Btn_Next.Name
                    'All_Function.pag_search.page_Next(txt_curpage)
                    'scr.List_Master(Me.dgv_scr, Me.ToolStripComboBox1, txt_scr, v_table, CInt(txt_curpage.Text))
                Case IMGNAME1.Name
                    IMGNAME1.Image = FileDialog.FileDialog_img

                Case btn_addunit.Name
                    AddUnit()
            End Select
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Private Sub EV_DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If UI_STAT = CL_interface.MemberFormStatus.UISearch Then
                Me.Load_Data(dgv_scr.CurrentRow.Cells("ID").Value, "", Nothing)
            Else
                FCancelSave() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
#End Region
#Region "Implements"
    Public Sub EnableControl(Value As Boolean) Implements CL_interface.DefultFoundation.EnableControl

        Select Case Me.UI_STAT
            Case CL_interface.MemberFormStatus.UINew
                PCODE.US_Enable = Value
                PNAME.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                REMARK.US_Enable = Value
                ACTIVEFLAG.Enabled = Value
                PGCODE.Enabled = Value
                UNITCODE.Enabled = Value
                unit_add.Enabled = Value
                btn_addunit.Enabled = Value
                COST_STD.US_Enable = Value

                PTCODE.Enabled = Value
                PRICE_STD.US_Enable = Value
            Case CL_interface.MemberFormStatus.UIEdit
                PCODE.US_Enable = False
                PNAME.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                REMARK.US_Enable = Value
                ACTIVEFLAG.Enabled = Value
                PGCODE.Enabled = Value
                UNITCODE.Enabled = Value
                unit_add.Enabled = Value
                btn_addunit.Enabled = Value
                COST_STD.US_Enable = Value
                PTCODE.Enabled = Value
                PRICE_STD.US_Enable = Value
            Case Else
                PCODE.US_Enable = Value
                PNAME.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                REMARK.US_Enable = Value
                ACTIVEFLAG.Enabled = Value
                PGCODE.Enabled = Value
                UNITCODE.Enabled = Value
                unit_add.Enabled = Value
                btn_addunit.Enabled = Value
                COST_STD.US_Enable = Value
                PTCODE.Enabled = Value
                PRICE_STD.US_Enable = Value
        End Select




    End Sub

    Public Sub ClearControl() Implements CL_interface.DefultFoundation.ClearControl

        ID.Text = 0
        PCODE.Clear()
        PNAME.Clear()
        DESCRIPTION.Clear()
        REMARK.Clear()
        ACTIVEFLAG.SelectedValue = "A"
        COST_STD.Text = 0
        PRICE_STD.Text = 0

        PTCODE.SelectedValue = "" : PTCODE.Text = "เลือกกลุ่มสินค้า"
        PGCODE.SelectedValue = "" : PGCODE.Text = "เลือกกลุ่มสินค้า"
        'UNITCODE.SelectedValue = "" : UNITCODE.Text = "เลือกหน่วยนับ"
        If UNITCODE.DataSource IsNot Nothing Then UNITCODE.SelectedIndex = 0
        unit_add.SelectedValue = "" : unit_add.Text = "เลือกหน่วยนับ"

        dgv_unit.Rows.Clear()
    End Sub

    Public Sub Load_MAS() Implements CL_interface.DefultFoundation.Load_MAS
        Try
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String


            Link = String.Format(Center.Get_API.MAS_DOC_STATUS_Select, "MASTER", UI_STAT)
            json_Response = conn_api.GETSON(Link)

            Dim ret As New MAS_DOC_STATUS_MODELS.value
            ret = (JsonConvert.DeserializeObject(Of MAS_DOC_STATUS_MODELS.value)(json_Response))
            If ret.Respon.Result Then
                ACTIVEFLAG.DataSource = ret.Data
                ACTIVEFLAG.DisplayMember = "DOS_NAME"
                ACTIVEFLAG.ValueMember = "DOS_ID"
                ACTIVEFLAG.SelectedValue = "A"
            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                End If
            End If





            Dim dt As New DataTable
            dt.Columns.Add("value")
            dt.Columns.Add("name")
            dt.Rows.Add("PCODE", "รหัสสินค้า")
            dt.Rows.Add("PNAME", "ชื่อสินค้า")
            dt.Rows.Add("PTNAME", "ชื่อประเภทสินค้า")
            dt.Rows.Add("PGNAME", "ชื่อกลุ่มสินค้า")
            With cbo_search.ComboBox
                .DataSource = dt
                .ValueMember = "value"
                .DisplayMember = "name"
                .SelectedIndex = 0
            End With


            LoadProductType()
            LoadProductgroup()
            LoadProductUnit()
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Public Sub Load_Data(value1 As String, value2 As String, value3 As Object) Implements CL_interface.DefultFoundation.Load_Data

        Try
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String
            Link = String.Format(Center.Get_API.MAS_PRODUCT_Select, value1)
            json_Response = conn_api.GETSON(Link)
            Dim ret As New Mas_Product_Model.value_data
            ret = (JsonConvert.DeserializeObject(Of Mas_Product_Model.value_data)(json_Response))
            If ret.Respon.Result Then
                data_H = ret.Data

                ID.Text = data_H.Product.ID
                PCODE.Text = data_H.Product.PCODE
                PNAME.Text = data_H.Product.PNAME
                DESCRIPTION.Text = data_H.Product.DESCRIPTION
                COST_STD.Text = data_H.Product.COST_STD
                REMARK.Text = data_H.Product.REMARK
                ACTIVEFLAG.SelectedValue = data_H.Product.ACTIVEFLAG

                PGCODE.SelectedValue = data_H.Product.PGCODE
                UNITCODE.SelectedValue = data_H.Product.UNITCODE

                PTCODE.SelectedValue = data_H.Product.PTCODE
                PRICE_STD.Text = data_H.Product.PRICE_STD

                dgv_unit.Rows.Clear()
                Dim cur_row As Integer
                For Each val As Mas_Product_Model.MAS_PRODUCT_SED_UNIT In data_H.PRODUCT_SED_UNIT
                    cur_row = dgv_unit.Rows.Add()
                    dgv_unit.Rows(cur_row).Cells("SEQ").Value = val.SEQ
                    dgv_unit.Rows(cur_row).Cells("UNITCODE").Value = val.UNITCODE
                    dgv_unit.Rows(cur_row).Cells("UNITNAME").Value = val.UNITNAME
                    dgv_unit.Rows(cur_row).Cells("QTY_SED").Value = val.QTY_SED
                    dgv_unit.Rows(cur_row).Cells("QTY_MAIN").Value = val.QTY_MAIN
                Next
                'dgv_unit.DataSource = data_H.PRODUCT_SED_UNIT

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
        dgv_scr.DataSource = Nothing
        dgv_scr.Rows.Clear()
        dgv_scr.Columns.Clear()
        dgv_scr.AutoGenerateColumns = False
        Dim Col As New DataGridViewTextBoxColumn
        Dim btn As New DataGridViewButtonColumn
        'Dim Chk As New DataGridViewCheckBoxColumn
        Dim read As Boolean = True


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ID"
        Col.Width = 50
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "ID"
        Col.Name = "ID"
        Me.dgv_scr.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ลำดับ"
        Col.Width = 50
        Col.Visible = True
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
        Col.HeaderText = "ชื่อประเภทสินค้า"
        Col.Width = 100
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PTNAME"
        Col.Name = "PTNAME"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ชื่อกลุ่มสินค้า"
        Col.Width = 100
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PGNAME"
        Col.Name = "PGNAME"
        Me.dgv_scr.Columns.Add(Col)



        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "สถานะ"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "ACTIVEFLAG"
        Col.Name = "ACTIVEFLAG"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "วันที่แก้ไข"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "MDATE"
        Col.Name = "MDATE"
        Me.dgv_scr.Columns.Add(Col)




        '//////////////////////////////////////////////////////////////////'
        '///////////////////////////////////////////////////////////////////

        dgv_unit.DataSource = Nothing
        dgv_unit.Rows.Clear()
        dgv_unit.Columns.Clear()
        dgv_unit.AutoGenerateColumns = False
        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ลำดับ"
        Col.Width = 100
        Col.Visible = True
        Col.ReadOnly = True
        Col.DataPropertyName = "SEQ"
        Col.Name = "SEQ"
        Me.dgv_unit.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "PCODE"
        Col.Width = 200
        Col.Visible = False
        Col.ReadOnly = True
        Col.DataPropertyName = "PCODE"
        Col.Name = "PCODE"
        Me.dgv_unit.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "รหัสหน่วยนับ"
        Col.Width = 200
        Col.Visible = True
        Col.ReadOnly = True
        Col.DataPropertyName = "UNITCODE"
        Col.Name = "UNITCODE"
        Me.dgv_unit.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ชื่อหน่วยนับ"
        Col.Width = 400
        Col.Visible = True
        Col.ReadOnly = True
        Col.DataPropertyName = "UNITNAME"
        Col.Name = "UNITNAME"
        Me.dgv_unit.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "จำนวนหน่วยรอง"
        Col.Width = 100
        Col.Visible = True
        Col.ReadOnly = True
        Col.DataPropertyName = "QTY_SED"
        Col.Name = "QTY_SED"
        Me.dgv_unit.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "จำนวนหน่วยหลัก"
        Col.Width = 140
        Col.Visible = True
        Col.ReadOnly = False
        Col.DataPropertyName = "QTY_MAIN"
        Col.Name = "QTY_MAIN"
        Col.DefaultCellStyle.BackColor = T_Color.Grid_Cell_Edit
        Me.dgv_unit.Columns.Add(Col)



        btn = New DataGridViewButtonColumn
        btn.HeaderText = "ลบ"
        btn.Width = 50
        btn.Visible = True
        btn.DataPropertyName = "DEL"
        btn.Name = "DEL"
        btn.FlatStyle = FlatStyle.Flat
        btn.DefaultCellStyle.BackColor = T_Color.Grid_btn_DEL
        Me.dgv_unit.Columns.Add(btn)


    End Sub


    Public Sub SetDefalt() Implements CL_interface.DefultFoundation.SetDefalt

        Select Case Me.UI_STAT
            Case CL_interface.MemberFormStatus.UINew
                PCODE.US_Enable = True
            Case CL_interface.MemberFormStatus.UIEdit
                PCODE.US_Enable = False
            Case Else
                PCODE.US_Enable = False
        End Select

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
            If PCODE.Text = "" Then
                Messages.Texts(Me.Text, Cl_massage.Edit_Not_found_data, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Return CL_interface.Answer.No
            End If
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

        If PCODE.Text = "" Then
            PCODE.UCSet_err("ไม่ได้ใส่รหัสสินค้า")
            msg = "- ไม่ได้ใส่รหัสสินค้า"
            TabControl1.SelectedTab = TabPage1
        End If
        If PNAME.Text = "" Then
            PNAME.UCSet_err("ไม่ได้ใส่ชื่อสินค้า")
            msg &= vbNewLine & "- ไม่ได้ใส่ชื่อสิ่นค้า"
            TabControl1.SelectedTab = TabPage1
        End If
        If PTCODE.SelectedValue = "" Then
            PTCODE.UCSet_err("ไม่ได้เลือกประเภทสินค้า")
            msg &= vbNewLine & "- ไม่ได้เลือกประเภทสินค้า"
            TabControl1.SelectedTab = TabPage1
        End If
        If PGCODE.SelectedValue = "" Then
            PGCODE.UCSet_err("ไม่ได้เลือกกลุ่มสินค้า")
            msg &= vbNewLine & "- ไม่ได้เลือกกลุ่มสินค้า"
            TabControl1.SelectedTab = TabPage1
        End If


        If CDbl(PRICE_STD.Text) = 0 Then
            PRICE_STD.UCSet_err("ไม่ได้กำหนดราคาสินค้า")
            msg &= vbNewLine & "- ไม่ได้กำหนดราคาสินค้า"
            TabControl1.SelectedTab = TabPage1
        End If






        If UNITCODE.SelectedValue = "" Then
            UNITCODE.UCSet_err("ไม่ได้เลือกหน่วยนับ")
            msg &= vbNewLine & "- ไม่ได้เลือกหน่วยนับ"
            If msg = "" Then TabControl1.SelectedTab = TabPage2
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

            Dim json As String = JsonConvert.SerializeObject(Me.data_H)
            Dim link As String = String.Format(Center.Post_API.Mas_Product_Save, UI_STAT)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV).POSTResponse(link, json, "POST")
            Dim retValue As Mas_Product_Group_Models.value_data = JsonConvert.DeserializeObject(Of Mas_Product_Group_Models.value_data)(json_Response)



            If retValue.Respon.Result Then
                Messages.Texts(Me.Text, Cl_massage.ConfirmSave_success, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                ClearControl()
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


    Public Function FSearch(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FSearch
        Try
            EnableControl(False)
            UI_STAT = CL_interface.MemberFormStatus.UISearch
            Gencolumn()
            Dim PCODE As String = ""
            Dim PNAME As String = ""
            Dim PTNAME As String = ""
            Dim PGNAME As String = ""
            If cbo_search.ComboBox.SelectedValue = "PCODE" Then
                PCODE = txt_scr.Text.Trim
            ElseIf cbo_search.ComboBox.SelectedValue = "PNAME" Then
                PNAME = txt_scr.Text.Trim
            ElseIf cbo_search.ComboBox.SelectedValue = "PGNAME" Then
                PGNAME = txt_scr.Text.Trim
            ElseIf cbo_search.ComboBox.SelectedValue = "PTNAME" Then
                PTNAME = txt_scr.Text.Trim
            End If

            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String

            Link = String.Format(Center.Get_API.MAS_PRODUCT_List, PCODE, PNAME, PGNAME, PTNAME, Center.Limit_Search)
            json_Response = conn_api.GETSON(Link)
            Dim ret As New Mas_Product_Model.value_List
            ret = (JsonConvert.DeserializeObject(Of Mas_Product_Model.value_List)(json_Response))
            If ret.Respon.Result Then
                If ret.Data.Count <= 0 Then
                    Messages.Texts("ค้นหา", Cl_massage.SCR01, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Exit Function
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
        Try
            If Me.dgv_scr.RowCount < 0 Or PCODE.Text = "" Then
                Messages.Texts(Me.Text, Cl_massage.Selectdata_Delete, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Warning)
                Return False
            End If

            If Messages.Texts(Me.Text, Cl_massage.ConfirmSave_Delete, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.No Then
                Return CL_interface.Answer.No
            End If

            Dim link As String = String.Format(Center.Post_API.Mas_PRODUCT_DELETE, PCODE.Text)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV).POSTResponse(link, "", "Delete")
            Dim retValue As Mas_Product_Model.value_data = JsonConvert.DeserializeObject(Of Mas_Product_Model.value_data)(json_Response)

            If retValue.Respon.Result Then
                Messages.Texts(Me.Text, Cl_massage.ConfirmSave_success, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                ClearControl()
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

    Public Function FCancel(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancel

    End Function

    Public Function FPrint(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FPrint

    End Function

    Public Function FClose(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FClose

    End Function
#End Region

#Region "SAVE"
    Private Function Save_H() As Boolean
        data_H.Product = New Mas_Product_Model.Product

        data_H.Product.ID = Me.ID.Text
        data_H.Product.PCODE = PCODE.Text
        data_H.Product.PCODE2 = PCODE.Text
        data_H.Product.PNAME = PNAME.Text
        data_H.Product.PGCODE = PGCODE.SelectedValue
        data_H.Product.PGNAME = PGCODE.Text

        data_H.Product.UNITCODE = UNITCODE.SelectedValue
        data_H.Product.DESCRIPTION = DESCRIPTION.Text
        data_H.Product.COST_STD = COST_STD.Text
        data_H.Product.REMARK = REMARK.Text
        data_H.Product.ACTIVEFLAG = ACTIVEFLAG.SelectedValue
        data_H.Product.CDATE = Date.Now
        data_H.Product.CUSE = Center.data_profile.user_id
        data_H.Product.MDATE = Date.Now
        data_H.Product.MUSE = Center.data_profile.user_id
        data_H.Product.ISTAT = "1"


        data_H.Product.PTCODE = PTCODE.SelectedValue
        data_H.Product.PRICE_STD = PRICE_STD.Text
        Return True
    End Function
    Private Function Save_items() As Boolean
        data_H.PRODUCT_SED_UNIT = New List(Of Mas_Product_Model.MAS_PRODUCT_SED_UNIT)

        Dim val As Mas_Product_Model.MAS_PRODUCT_SED_UNIT
        For Each drow As DataGridViewRow In Me.dgv_unit.Rows
            val = New Mas_Product_Model.MAS_PRODUCT_SED_UNIT

            val.SEQ = drow.Cells("SEQ").Value
            val.PCODE = PCODE.Text
            val.UNITCODE = drow.Cells("UNITCODE").Value
            val.QTY_MAIN = drow.Cells("QTY_MAIN").Value
            val.QTY_SED = drow.Cells("QTY_SED").Value

            data_H.PRODUCT_SED_UNIT.Add(val)
        Next
        Return True
    End Function

#End Region

#Region "Method"
    Private Sub AddUnit()
        Try
            If unit_add.SelectedValue = "" Then
                Messages.Texts(Me.Text, "กรุณาเลือกหน่วยนับ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                unit_add.UCSet_err("กรุณาเลือกหน่วยนับ")
                Exit Sub
            End If

            For Each grow As DataGridViewRow In dgv_unit.Rows
                If grow.Cells("UNITCODE").Value = unit_add.SelectedValue Then
                    Messages.Texts(Me.Text, "หน่วยนับ """ & unit_add.Text & """ มีอยู่ในรายการแล้ว", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next

            Dim cur_row As Integer
            cur_row = dgv_unit.Rows.Add()
            dgv_unit.Rows(cur_row).Cells("SEQ").Value = cur_row + 1
            dgv_unit.Rows(cur_row).Cells("UNITCODE").Value = unit_add.SelectedValue
            dgv_unit.Rows(cur_row).Cells("UNITNAME").Value = unit_add.Text
            dgv_unit.Rows(cur_row).Cells("QTY_SED").Value = 1
            dgv_unit.Rows(cur_row).Cells("QTY_MAIN").Value = 1
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub LoadProductgroup()
        Try

            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String

            Link = String.Format(Center.Get_API.MAS_PRODUCT_Group_List_CBO, "")
            json_Response = conn_api.GETSON(Link)
            Dim ret As New Mas_Product_Group_Models.value_List
            ret = (JsonConvert.DeserializeObject(Of Mas_Product_Group_Models.value_List)(json_Response))
            If ret.Respon.Result Then
                If ret.Data.Count > 0 Then
                    With PGCODE
                        .DataSource = ret.Data
                        .ValueMember = "PGCODE"
                        .DisplayMember = "PGNAME"
                        .SelectedValue = ""
                        .Text = "เลือกกลุ่มสินค้า"
                    End With
                End If
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
    Private Sub LoadProductType()
        Try

            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String

            Link = String.Format(Center.Get_API.MAS_PRODUCT_Type_List_CBO, "")
            json_Response = conn_api.GETSON(Link)
            Dim ret As New MAS_PRODUCT_TYPE_Models.value_List
            ret = (JsonConvert.DeserializeObject(Of MAS_PRODUCT_TYPE_Models.value_List)(json_Response))
            If ret.Respon.Result Then
                If ret.Data.Count > 0 Then
                    With PTCODE
                        .DataSource = ret.Data
                        .ValueMember = "PTCODE"
                        .DisplayMember = "PTNAME"
                        .SelectedValue = ""
                        .Text = "เลือกประเภทสินค้า"
                    End With
                End If
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
    Private Sub LoadProductUnit()
        Try

            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String

            Link = String.Format(Center.Get_API.MAS_PRODUCT_Unit_List_CBO, "")
            json_Response = conn_api.GETSON(Link)
            Dim ret As New Mas_Product_UNIT_Models.value_List
            ret = (JsonConvert.DeserializeObject(Of Mas_Product_UNIT_Models.value_List)(json_Response))
            If ret.Respon.Result Then


                If ret.Data.Count > 0 Then
                    With unit_add
                        .DataSource = ret.Data
                        .ValueMember = "UNITCODE"
                        .DisplayMember = "UNITNAME"
                        .SelectedIndex = 0
                        '.Text = "เลือกหน่วยนับ"
                    End With
                End If

                Dim unit As New List(Of Mas_Product_UNIT_Models.PRODUCT_UNIT_List)

                unit = ret.Data.Select(Function(a) a).ToList()

                If ret.Data.Count > 0 Then
                    With UNITCODE
                        .DataSource = unit
                        .ValueMember = "UNITCODE"
                        .DisplayMember = "UNITNAME"
                        .SelectedValue = ""
                        .Text = "เลือกหน่วยนับ"
                    End With
                End If


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

    Public Function FView(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FView
        Throw New NotImplementedException()
    End Function

    Private Sub F_MAS_Product_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate

    End Sub

    Public Function FCopy(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCopy
        Throw New NotImplementedException()
    End Function


#End Region
End Class
Imports Control_us
Imports MD
Imports Newtonsoft.Json
Public Class F_MAS_Permiss

    Implements MD.CL_interface.DefultFoundation

    Dim UI_STAT As MD.CL_interface.MemberFormStatus = CL_interface.MemberFormStatus.UIOpen
    Dim data_Save As New MAS_Menu_Permis_Models.Data_SAVE
    Private Sub F_MAS_Product_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        F_Main.lbl_Display.Text = Me.Tag.MenuName
    End Sub
    Private Sub F_Unit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FSearch() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)

    End Sub
#Region "Event"
    Public Sub SetEvent() Implements CL_interface.DefultFoundation.SetEvent
        'text
        AddHandler Me.PERMIS_CODE.TextChanged, AddressOf EV_Text_Changed
        AddHandler Me.PERMIS_NAME.TextChanged, AddressOf EV_Text_Changed

        'Text_KeyUp
        AddHandler txt_scr.KeyUp, AddressOf EV_Text_KeyUp


        'KeyDown
        AddHandler txt_scr.KeyDown, AddressOf EV_Text_KeyDown



        'KeyPress
        AddHandler txt_curpage.KeyPress, AddressOf EV_Text_KeyPress

        'btn
        AddHandler Me.btn_new.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_Copy.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_edit.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_save.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_cancel_save.Click, AddressOf EV_Btn_Click

        AddHandler Me.btndelete.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_close.Click, AddressOf EV_Btn_Click


        AddHandler Me.btn_scr.Click, AddressOf EV_Btn_Click

        AddHandler Me.btn_scr_uid.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_clear_uid.Click, AddressOf EV_Btn_Click



        'checkbox
        AddHandler Me.chk_selectall.Click, AddressOf chk_selectall_Click


        ' dgv
        AddHandler dgv_scr.CellMouseClick, AddressOf EV_DGV_CellMouseClick
    End Sub
    Private Sub chk_selectall_Click(sender As Object, e As EventArgs)
        Select Case sender.name
            Case chk_selectall.Name
                If chk_selectall.Checked Then
                    For Each grow As DataGridViewRow In dgv_permiss.Rows
                        grow.Cells("M_AT").Value = True
                    Next
                Else
                    For Each grow As DataGridViewRow In dgv_permiss.Rows
                        grow.Cells("M_AT").Value = False
                    Next
                End If
        End Select
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


                Case btn_new.Name : FNew() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
                Case btn_edit.Name : FEdit() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
                Case btn_Copy.Name : FCopy() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
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
                Case btn_clear_uid.Name
                    UID.Clear()
                    PERMIS_NAME.Clear()
                Case btn_scr_uid.Name
                    SearchUID()
            End Select
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Private Sub EV_DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            Select Case sender.name
                Case dgv_scr.Name
                    If UI_STAT = CL_interface.MemberFormStatus.UISearch Then
                        Me.Load_Data(dgv_scr.CurrentRow.Cells("TR_ID").Value, "", Nothing)
                    Else
                        FCancelSave() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)
                    End If
                Case dgv_permiss.Name



            End Select

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
#End Region



    Public Sub EnableControl(Value As Boolean) Implements CL_interface.DefultFoundation.EnableControl

        Select Case Me.UI_STAT
            Case CL_interface.MemberFormStatus.UINew
A:
                PERMIS_CODE.US_Enable = False
                'PERMIS_NAME.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                REMARK.US_Enable = Value
                ACTIVEFLAG.Enabled = Value

                btn_scr_uid.Enabled = Value
                btn_clear_uid.Enabled = Value

                chk_selectall.Enabled = Value
                dgv_permiss.ReadOnly = Not Value
            Case CL_interface.MemberFormStatus.UICopy
                GoTo A
            Case CL_interface.MemberFormStatus.UIEdit
                PERMIS_CODE.US_Enable = False
                'PERMIS_NAME.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                REMARK.US_Enable = Value
                ACTIVEFLAG.Enabled = Value

                btn_scr_uid.Enabled = Value
                btn_clear_uid.Enabled = Value
                chk_selectall.Enabled = Value
                dgv_permiss.ReadOnly = Not Value
            Case Else
                PERMIS_CODE.US_Enable = Value
                'PERMIS_NAME.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                REMARK.US_Enable = Value
                ACTIVEFLAG.Enabled = Value

                btn_scr_uid.Enabled = Value
                btn_clear_uid.Enabled = Value


                chk_selectall.Enabled = Value
                dgv_permiss.ReadOnly = Not Value
        End Select




    End Sub

    Public Sub ClearControl() Implements CL_interface.DefultFoundation.ClearControl

        TR_ID.Text = 0
        PERMIS_CODE.Clear()
        PERMIS_NAME.Clear()
        UID.Clear()
        DESCRIPTION.Clear()
        REMARK.Clear()
        ACTIVEFLAG.SelectedValue = "A"


        chk_selectall.Checked = False


        For Each grow As DataGridViewRow In dgv_permiss.Rows
            grow.Cells("M_AT").Value = False
        Next
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
            Load_Menu()




            Dim dt As New DataTable
            dt.Columns.Add("value")
            dt.Columns.Add("name")
            dt.Rows.Add("PERMIS_CODE", "รหัสสิทธิื")
            dt.Rows.Add("PERMIS_NAME", "ชื่อ")
            dt.Rows.Add("UID", "User ID")
            With cbo_search.ComboBox
                .DataSource = dt
                .ValueMember = "value"
                .DisplayMember = "name"
                .SelectedIndex = 0
            End With
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Public Sub Load_Data(value1 As String, value2 As String, value3 As Object) Implements CL_interface.DefultFoundation.Load_Data

        Try
            If value1 = TR_ID.Text Then Exit Sub
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String
            Link = String.Format(Center.Get_API.MAS_Permis_Select_Data, value1)
            json_Response = conn_api.GETSON(Link)
            Dim ret As New MAS_Menu_Permis_Models.value_SAVE
            ret = (JsonConvert.DeserializeObject(Of MAS_Menu_Permis_Models.value_SAVE)(json_Response))
            If ret.Respon.Result Then
                data_Save = ret.Data

                TR_ID.Text = data_Save.Data_H.TR_ID
                PERMIS_CODE.Text = data_Save.Data_H.PERMIS_CODE
                PERMIS_NAME.Text = data_Save.Data_H.PERMIS_NAME
                UID.Text = data_Save.Data_H.UID
                DESCRIPTION.Text = data_Save.Data_H.DESCRIPTION
                REMARK.Text = data_Save.Data_H.REMARK
                ACTIVEFLAG.SelectedValue = data_Save.Data_H.ACTIVEFLAG



                For Each grow As DataGridViewRow In dgv_permiss.Rows

                    For Each val As MAS_Menu_Permis_Models.Data_PER_MIS_D In Me.data_Save.Data_ITEMS
                        val.BTN_ADD = True
                        val.BTN_DEL = True
                        val.BTN_EDIT = True
                        val.BTN_VIEW = True
                        If grow.Cells("MNU_CODE").Value = val.MNU_CODE Then
                            grow.Cells("M_AT").Value = val.M_AT
                            Exit For
                        End If

                    Next

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
        dgv_scr.DataSource = Nothing
        dgv_scr.Rows.Clear()
        dgv_scr.Columns.Clear()
        dgv_scr.AutoGenerateColumns = False
        Dim Col As New DataGridViewTextBoxColumn
        'Dim btn As New DataGridViewButtonColumn
        Dim Chk As New DataGridViewCheckBoxColumn
        Dim read As Boolean = True


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "TR_ID"
        Col.Width = 50
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "TR_ID"
        Col.Name = "TR_ID"
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
        Col.HeaderText = "รหัสสิทธิ์"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PERMIS_CODE"
        Col.Name = "PERMIS_CODE"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "User ID"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "UID"
        Col.Name = "UID"
        Me.dgv_scr.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ชื่อ"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "PERMIS_NAME"
        Col.Name = "PERMIS_NAME"
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

    End Sub
    Public Sub Gencolumn_permiss()
        dgv_scr.DataSource = Nothing
        dgv_scr.Rows.Clear()
        dgv_scr.Columns.Clear()
        dgv_permiss.AutoGenerateColumns = False
        Dim Col As New DataGridViewTextBoxColumn
        'Dim btn As New DataGridViewButtonColumn
        Dim Chk As New DataGridViewCheckBoxColumn
        Dim read As Boolean = True

        dgv_permiss.DataSource = Nothing
        dgv_permiss.Rows.Clear()
        dgv_permiss.Columns.Clear()


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ID"
        Col.Width = 50
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "ID"
        Col.Name = "ID"
        Me.dgv_permiss.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "ลำดับ"
        Col.Width = 50
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "SEQ"
        Col.Name = "SEQ"
        Me.dgv_permiss.Columns.Add(Col)



        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "รหัสเมนู"
        Col.Width = 50
        Col.Visible = False
        Col.ReadOnly = read
        Col.DataPropertyName = "MNU_CODE"
        Col.Name = "MNU_CODE"
        Me.dgv_permiss.Columns.Add(Col)


        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "กลุ่มเมนู"
        Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "MNU_HNAME_1"
        Col.Name = "MNU_HNAME_1"
        Me.dgv_permiss.Columns.Add(Col)

        Col = New DataGridViewTextBoxColumn
        Col.HeaderText = "เมนู"
        Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Col.Visible = True
        Col.ReadOnly = read
        Col.DataPropertyName = "MNU_SNAME_1"
        Col.Name = "MNU_SNAME_1"
        Me.dgv_permiss.Columns.Add(Col)


        Chk = New DataGridViewCheckBoxColumn
        Chk.HeaderText = "ใช้งาน"
        Chk.Width = 150
        Chk.Visible = True
        Chk.ReadOnly = False
        Chk.DataPropertyName = "M_AT"
        Chk.Name = "M_AT"
        Me.dgv_permiss.Columns.Add(Chk)
    End Sub

    Public Sub SetDefalt() Implements CL_interface.DefultFoundation.SetDefalt

        Select Case Me.UI_STAT
            Case CL_interface.MemberFormStatus.UINew
                PERMIS_CODE.US_Enable = True
            Case CL_interface.MemberFormStatus.UIEdit
                PERMIS_CODE.US_Enable = False
            Case Else
                PERMIS_CODE.US_Enable = False
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
            If PERMIS_CODE.Text = "" Then
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
    Public Function FCopy(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCopy
        Try
            If PERMIS_CODE.Text = "" Then
                Messages.Texts(Me.Text, Cl_massage.Edit_Not_found_data, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Return CL_interface.Answer.No
            End If
            PERMIS_CODE.Text = ""
            TR_ID.Text = ""
            Me.UI_STAT = CL_interface.MemberFormStatus.UICopy
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
                    Select Case MessageBox.Show(Cl_massage.ConfirmSave01, Me.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
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

        'If UNITCODE.Text = "" Then
        '    UNITCODE.UCSet_err("ไม่ได้ใส่รหัสหน่วยนับ")
        '    msg = "1 ไม่ได้ใส่รหัสหน่วยนับ"
        'End If
        If PERMIS_NAME.Text = "" Then
            PERMIS_NAME.UCSet_err("กรุณาเลือก User")
            msg &= vbNewLine & "1 กรุณาเลือก User"
            TabControl_US1.SelectedIndex = 0
        End If

        Dim sel As Boolean = False
        For Each grow As DataGridViewRow In dgv_permiss.Rows
            If grow.Cells("M_AT").Value Then
                sel = True
            End If
        Next

        If Not sel Then
            PERMIS_NAME.UCSet_err("2 กรุณาเลือกสิทธิ์ใช้งาน")
            msg &= vbNewLine & "2 กรุณาเลือกสิทธิ์ใช้งาน"
            TabControl_US1.SelectedIndex = 1
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

            Save_H()
            Save_Items()
            Dim json As String = JsonConvert.SerializeObject(Me.data_Save)
            Dim link As String = String.Format(Center.Post_API.MAS_Permis_Save, UI_STAT)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV).POSTResponse(link, json, "POST")
            Dim retValue As Mas_Product_UNIT_Models.value_data = JsonConvert.DeserializeObject(Of Mas_Product_UNIT_Models.value_data)(json_Response)



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
            Dim CODE As String = ""
            Dim NAME As String = ""
            Dim UID As String = ""
            If cbo_search.ComboBox.SelectedValue = "PERMIS_CODE" Then
                CODE = txt_scr.Text.Trim
            ElseIf cbo_search.ComboBox.SelectedValue = "PERMIS_NAME" Then
                NAME = txt_scr.Text.Trim
            ElseIf cbo_search.ComboBox.SelectedValue = "UID" Then
                UID = txt_scr.Text.Trim
            End If

            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String

            Link = String.Format(Center.Get_API.MAS_Permis_List_Data, CODE, NAME, UID, Center.Limit_Search)
            json_Response = conn_api.GETSON(Link)
            Dim ret As New MAS_Menu_Permis_Models.value_List
            ret = (JsonConvert.DeserializeObject(Of MAS_Menu_Permis_Models.value_List)(json_Response))
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
            If Me.dgv_scr.RowCount < 0 Or PERMIS_CODE.Text = "" Then
                Messages.Texts(Me.Text, Cl_massage.Selectdata_Delete, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Warning)
                Return False
            End If

            If Messages.Texts(Me.Text, Cl_massage.ConfirmSave_Delete, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.No Then
                Return CL_interface.Answer.No
            End If

            Dim link As String = String.Format(Center.Post_API.MAS_Permis_DELETE, TR_ID.Text)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV).POSTResponse(link, "", "Delete")
            Dim retValue As MAS_Menu_Permis_Models.value_SAVE = JsonConvert.DeserializeObject(Of MAS_Menu_Permis_Models.value_SAVE)(json_Response)

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
    Public Function FView(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FView
        Throw New NotImplementedException()
    End Function



#Region "Method"
    Private Sub Load_Menu()
        Try
            Gencolumn_permiss()
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String


            Link = String.Format(Center.Get_API.MAS_Load_Menus, "")
            json_Response = conn_api.GETSON(Link)

            Dim ret As New MAS_Menu_Permis_Models.value_menu
            ret = (JsonConvert.DeserializeObject(Of MAS_Menu_Permis_Models.value_menu)(json_Response))
            If ret.Respon.Result Then

                data_Save.Data_ITEMS = New List(Of MAS_Menu_Permis_Models.Data_PER_MIS_D)
                Dim value As MAS_Menu_Permis_Models.Data_PER_MIS_D
                Dim i As Integer = 1
                For Each val As MAS_Menu_Permis_Models.Data_Menu In ret.Data
                    value = New MAS_Menu_Permis_Models.Data_PER_MIS_D


                    value.PERMIS_CODE = ""
                    value.SEQ = i
                    value.MNU_CODE = val.MNU_CODE
                    value.MNU_HNAME_1 = val.MNU_HNAME_1
                    value.MNU_SNAME_1 = val.MNU_SNAME_1
                    value.M_AT = False
                    value.BTN_ADD = False
                    value.BTN_EDIT = False
                    value.BTN_VIEW = False
                    value.BTN_DEL = False
                    value.REMARK = ""
                    data_Save.Data_ITEMS.Add(value)

                    i += 1
                Next
                dgv_permiss.DataSource = Me.data_Save.Data_ITEMS
            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    'จากระบบ
                    Messages.Texts(Me.Text, ret.Respon.SystemErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                End If
            End If


        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub


    Private Sub SearchUID()

        Try
            Dim Grid_column As New List(Of F_SearchData.GridColumn)
            Grid_column.Add(New F_SearchData.GridColumn With {.Columntext = "Level", .ColumnName = "value1"})
            Dim f As New F_SearchData With {
                                                .Multiselect = False,
                                                .Frm_text = "User ID",
                                                .SCR_TYPE = "User",
                                                .fixvalue = "",
                                                .lbl_CODE_text = "User ID",
                                                .lbl_NAME_text = "User Name",
                                                .grid_code_text = "User ID",
                                                .grid_name_text = "User Name",
                                                .Grid_column = Grid_column
                                            }
            f.Icon = Center.icon

            If (f.ShowDialog) = DialogResult.OK Then
                Dim currow As Integer
                For Each Val As DataGridViewRow In f.dgv_scr.SelectedRows
                    UID.Text = Val.Cells("CODE").Value
                    PERMIS_NAME.Text = Val.Cells("NAME").Value
                Next
            End If


        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

#End Region

#Region "SAVE"
    Private Function Save_H() As Boolean
        data_Save.Data_H = New MAS_Menu_Permis_Models.Data_PER_MIS
        data_Save.Data_H.TR_ID = Me.TR_ID.Text
        data_Save.Data_H.PERMIS_CODE = PERMIS_CODE.Text
        data_Save.Data_H.PERMIS_NAME = PERMIS_NAME.Text
        data_Save.Data_H.UID = UID.Text
        data_Save.Data_H.DESCRIPTION = DESCRIPTION.Text
        data_Save.Data_H.REMARK = REMARK.Text
        data_Save.Data_H.ACTIVEFLAG = ACTIVEFLAG.SelectedValue
        data_Save.Data_H.CDATE = Date.Now
        data_Save.Data_H.CUSE = Center.data_profile.user_id
        data_Save.Data_H.MDATE = Date.Now
        data_Save.Data_H.MUSE = Center.data_profile.user_id
        data_Save.Data_H.ISTAT = "1"



        Return True
    End Function
    Private Function Save_Items() As Boolean

        'Me.data_Save.Data_ITEMS = New MAS_Menu_Permis_Models.Data_PER_MIS_D
        For Each grow As DataGridViewRow In dgv_permiss.Rows

            For Each val As MAS_Menu_Permis_Models.Data_PER_MIS_D In Me.data_Save.Data_ITEMS
                val.BTN_ADD = True
                val.BTN_DEL = True
                val.BTN_EDIT = True
                val.BTN_VIEW = True
                If grow.Cells("MNU_CODE").Value = val.MNU_CODE Then
                    val.M_AT = grow.Cells("M_AT").Value
                    Exit For
                End If

            Next

        Next
        Return True
    End Function





#End Region
End Class
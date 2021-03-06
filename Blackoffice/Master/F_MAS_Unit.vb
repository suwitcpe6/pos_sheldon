﻿Imports Control_us
Imports MD
Imports Newtonsoft.Json
Public Class F_MAS_Unit

    Implements MD.CL_interface.DefultFoundation

    Dim UI_STAT As MD.CL_interface.MemberFormStatus = CL_interface.MemberFormStatus.UIOpen
    Dim data_H As Mas_Product_UNIT_Models.PRODUCT_UNIT
    Private Sub F_MAS_Product_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        F_Main.lbl_Display.Text = Me.Tag.MenuName
    End Sub
    Private Sub F_Unit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FSearch() : Btn_menu.Hid_Button(ToolStrip_top, Me.UI_STAT)

    End Sub
#Region "Event"
    Public Sub SetEvent() Implements CL_interface.DefultFoundation.SetEvent
        'text
        AddHandler Me.UNITCODE.TextChanged, AddressOf EV_Text_Changed
        AddHandler Me.UNITNAME.TextChanged, AddressOf EV_Text_Changed

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



    Public Sub EnableControl(Value As Boolean) Implements CL_interface.DefultFoundation.EnableControl

        Select Case Me.UI_STAT
            Case CL_interface.MemberFormStatus.UINew
                UNITCODE.US_Enable = False
                UNITNAME.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                REMARK.US_Enable = Value
                ACTIVEFLAG.Enabled = Value

            Case CL_interface.MemberFormStatus.UIEdit
                UNITCODE.US_Enable = False
                UNITNAME.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                REMARK.US_Enable = Value
                ACTIVEFLAG.Enabled = Value
            Case Else
                UNITCODE.US_Enable = Value
                UNITNAME.US_Enable = Value
                DESCRIPTION.US_Enable = Value
                REMARK.US_Enable = Value
                ACTIVEFLAG.Enabled = Value
        End Select




    End Sub

    Public Sub ClearControl() Implements CL_interface.DefultFoundation.ClearControl

        ID.Text = 0
        UNITCODE.Clear()
        UNITNAME.Clear()
        DESCRIPTION.Clear()
        REMARK.Clear()
        ACTIVEFLAG.SelectedValue = "A"



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
            dt.Rows.Add("UNITCODE", "รหัสหน่วยนับ")
            dt.Rows.Add("UNITNAME", "ชื่อหน่วยนับ")
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
            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String
            Link = String.Format(Center.Get_API.MAS_PRODUCT_UNIT_Select, value1)
            json_Response = conn_api.GETSON(Link)
            Dim ret As New Mas_Product_UNIT_Models.value_data
            ret = (JsonConvert.DeserializeObject(Of Mas_Product_UNIT_Models.value_data)(json_Response))
            If ret.Respon.Result Then
                data_H = ret.Data(0)

                ID.Text = data_H.ID
                UNITCODE.Text = data_H.UNITCODE
                UNITNAME.Text = data_H.UNITNAME
                DESCRIPTION.Text = data_H.DESCRIPTION
                REMARK.Text = data_H.REMARK
                ACTIVEFLAG.SelectedValue = data_H.ACTIVEFLAG


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
        Dim Col As New DataGridViewTextBoxColumn
        'Dim btn As New DataGridViewButtonColumn
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
        Col.HeaderText = "ID หน่วยนับ"
        Col.Width = 50
        Col.Visible = True
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


        'Col = New DataGridViewTextBoxColumn
        'Col.HeaderText = "รายละเอียด"
        'Col.Width = 50
        'Col.Visible = True
        'Col.ReadOnly = read
        'Col.DataPropertyName = "DESCRIPTION"
        'Col.Name = "DESCRIPTION"
        'Me.dgv_scr.Columns.Add(Col)

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

        'Col = New DataGridViewTextBoxColumn
        'Col.HeaderText = "หมายเหตุ"
        'Col.Width = 50
        'Col.Visible = True
        'Col.ReadOnly = read
        'Col.DataPropertyName = "REMARK"
        'Col.Name = "REMARK"
        'Me.dgv_scr.Columns.Add(Col)





        'Me.DGV_Product.AutoResizeColumns()


        'Me.dt_paroduct.Rows.Clear()
        'Me.dt_paroduct.Columns.Clear()
        'With Me.dt_paroduct.Columns
        '    .Add("SEQ")
        '    .Add("CTID")
        '    .Add("CUSED")
        '    .Add("BARCODE")
        '    .Add("SHOPID")
        '    .Add("POSID")
        '    .Add("MRTAMOUNT", GetType(Decimal))
        '    .Add("MRTSTATUS")
        '    .Add("MRTSLIPNO")
        '    .Add("MRTLUPDATE")
        '    .Add("TID")
        '    .Add("UID")
        '    .Add("LUPDATE")
        '    .Add("BACKUPFLG")
        '    .Add("CHKFLG")
        '    .Add("VOIDNO")
        '    .Add("CUSED1")
        '    .Add("FOODID")
        '    .Add("FOODNAME")
        '    .Add("SHOPENDFLG")
        '    .Add("GP")
        '    .Add("GPAMOUNT")
        '    .Add("GPRULE")
        '    .Add("STOCKID")
        '    .Add("TAXINVOICE")
        '    .Add("CREDITNOTES")
        '    .Add("CARDTENDOR")
        '    .Add("CARDREF")
        '    .Add("CARDPURSE")
        '    .Add("taxPrint")
        '    .Add("status")
        '    .Add("Qty", GetType(Integer))
        'End With
        'DGV_Product.DataSource = Me.dt_paroduct

    End Sub

    Public Sub SetDefalt() Implements CL_interface.DefultFoundation.SetDefalt

        Select Case Me.UI_STAT
            Case CL_interface.MemberFormStatus.UINew
                UNITCODE.US_Enable = True
            Case CL_interface.MemberFormStatus.UIEdit
                UNITCODE.US_Enable = False
            Case Else
                UNITCODE.US_Enable = False
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
            If UNITCODE.Text = "" Then
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
        If UNITNAME.Text = "" Then
            UNITNAME.UCSet_err("ไม่ได้ใส่ชื่อหน่วยนับ")
            msg &= vbNewLine & "2 ไม่ได้ใส่ชื่อหน่วยนับ"
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

            If Save_H() Then

                Dim json As String = JsonConvert.SerializeObject(Me.data_H)
                Dim link As String = String.Format(Center.Post_API.Mas_Product_Unit_Save, UI_STAT)
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
            Dim UnitCODE As String = ""
            Dim UnitNAME As String = ""
            If cbo_search.ComboBox.SelectedValue = "UNITCODE" Then
                UnitCODE = txt_scr.Text.Trim
            ElseIf cbo_search.ComboBox.SelectedValue = "UNITNAME" Then
                UnitNAME = txt_scr.Text.Trim
            End If

            Dim conn_api As New API(Center.Data_Config.API_SRV)
            Dim Link As String
            Dim json_Response As String

            Link = String.Format(Center.Get_API.MAS_PRODUCT_Unit_List, UnitCODE, UnitNAME)
            json_Response = conn_api.GETSON(Link)
            Dim ret As New Mas_Product_UNIT_Models.value_List
            ret = (JsonConvert.DeserializeObject(Of Mas_Product_UNIT_Models.value_List)(json_Response))
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
            If Me.dgv_scr.RowCount < 0 Or UNITCODE.Text = "" Then
                Messages.Texts(Me.Text, Cl_massage.Selectdata_Delete, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Warning)
                Return False
            End If

            If Messages.Texts(Me.Text, Cl_massage.ConfirmSave_Delete, Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.No Then
                Return CL_interface.Answer.No
            End If

            Dim link As String = String.Format(Center.Post_API.Mas_PRODUCT_UNIT_DELETE, ID.Text)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV).POSTResponse(link, "", "Delete")
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

    Public Function FCancel(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancel

    End Function

    Public Function FPrint(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FPrint

    End Function

    Public Function FClose(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FClose

    End Function

#Region "SAVE"
    Private Function Save_H() As Boolean
        data_H = New Mas_Product_UNIT_Models.PRODUCT_UNIT
        data_H.ID = Me.ID.Text
        data_H.UNITCODE = UNITCODE.Text
        data_H.UNITNAME = UNITNAME.Text
        data_H.DESCRIPTION = DESCRIPTION.Text
        data_H.REMARK = REMARK.Text
        data_H.ACTIVEFLAG = ACTIVEFLAG.SelectedValue
        data_H.CDATE = Date.Now
        data_H.CUSE = Center.data_profile.user_id
        data_H.MDATE = Date.Now
        data_H.MUSE = Center.data_profile.user_id
        data_H.ISTAT = "1"



        Return True
    End Function

    Public Function FView(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FView
        Throw New NotImplementedException()
    End Function

    Public Function FCopy(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCopy
        Throw New NotImplementedException()
    End Function


#End Region
End Class
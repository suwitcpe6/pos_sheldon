Imports Control_us
Imports MD
Imports Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution
Imports Newtonsoft.Json
Imports Microsoft.Reporting.WinForms
Public Class F_RPT_Stockcard
    Implements MD.CL_interface.DefultFoundation

    Dim UI_STAT As MD.CL_interface.MemberFormStatus = CL_interface.MemberFormStatus.UIOpen
    Public SCR_TR_ID As String
    Dim frm_sub As New F_Receive
    Dim menustruc As New Menu.menuStruct

    Private Sub F_MAS_Product_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        F_Main.lbl_Display.Text = Me.Tag.MenuName
    End Sub
    Private Sub F_Receive_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#Region "Event"
    Public Sub SetEvent() Implements CL_interface.DefultFoundation.SetEvent
        'text
        'AddHandler Me.UNITCODE.TextChanged, AddressOf EV_Text_Changed
        'AddHandler Me.UNITNAME.TextChanged, AddressOf EV_Text_Changed

        'Text_KeyUp
        'AddHandler txt_scr.KeyUp, AddressOf EV_Text_KeyUp


        'KeyDown
        'AddHandler txt_scr.KeyDown, AddressOf EV_Text_KeyDown



        'KeyPress
        'AddHandler txt_curpage.KeyPress, AddressOf EV_Text_KeyPress

        'btn
        AddHandler Me.btn_print.Click, AddressOf EV_Btn_Click
        'AddHandler Me.btn_edit.Click, AddressOf EV_Btn_Click
        'AddHandler Me.Btn_View.Click, AddressOf EV_Btn_Click
        'AddHandler Me.btndelete.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_close.Click, AddressOf EV_Btn_Click
        'AddHandler Me.btn_cancel.Click, AddressOf EV_Btn_Click


        AddHandler Me.btn_scr_Product1.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_scr_Product2.Click, AddressOf EV_Btn_Click
        AddHandler Me.btn_clear.Click, AddressOf EV_Btn_Click






        ' dgv
        'AddHandler dgv_scr.CellMouseClick, AddressOf EV_DGV_CellMouseClick
    End Sub

    Private Sub EV_Btn_Click(sender As Object, e As EventArgs)
        Try
            Select Case sender.name

                Case btn_print.Name : FPrint()
                    'Case btn_edit.Name : FEdit()
                    'Case Btn_View.Name : FView()
                    'Case btndelete.Name : FDelete()
                Case btn_close.Name : FExit()
                    'Case btn_cancel.Name : FCancel()
                    'Case Btn_last.Name
                    '    'All_Function.pag_search.page_last(txt_curpage)
                    '    'Me.ToolbarSearch()
                    'Case Btn_Next.Name
                    '    'All_Function.pag_search.page_Next(txt_curpage)
                    '    'scr.List_Master(Me.dgv_scr, Me.ToolStripComboBox1, txt_scr, v_table, CInt(txt_curpage.Text))
                Case btn_scr_Product1.Name : Search_Product(sender)
                Case btn_scr_Product2.Name : Search_Product(sender)
                Case btn_clear.Name : ClearControl()
            End Select
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

#End Region

    Public Sub EnableControl(Value As Boolean) Implements CL_interface.DefultFoundation.EnableControl

    End Sub

    Public Sub ClearControl() Implements CL_interface.DefultFoundation.ClearControl
        pcode1.Text = ""
        pname1.Text = ""
        pcode2.Text = ""
        pname2.Text = ""
        If Not IsNothing(STCODE.DataSource) Then STCODE.SelectedIndex = 0
        Me.dtp_dateStart.Value = Center.date_now
        Me.dtp_dateEnd.Value = Center.date_now

        Gencolumn()
    End Sub

    Public Sub Load_MAS() Implements CL_interface.DefultFoundation.Load_MAS
        Try
            Load_stock()
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Public Sub Load_Data(value1 As String, value2 As String, value3 As Object) Implements CL_interface.DefultFoundation.Load_Data



    End Sub

    Public Sub Gencolumn() Implements CL_interface.DefultFoundation.Gencolumn
    End Sub

    Public Sub SetDefalt() Implements CL_interface.DefultFoundation.SetDefalt
        menustruc = Me.Tag
    End Sub

    Public Sub Err(value1 As Object, Optional value2 As String = "") Implements CL_interface.DefultFoundation.Err

    End Sub



    Public Function FNew() As CL_interface.Answer Implements CL_interface.DefultFoundation.FNew

    End Function

    Public Function FEdit() As CL_interface.Answer Implements CL_interface.DefultFoundation.FEdit

    End Function

    Public Function FView(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FView

    End Function

    Public Function FExit() As CL_interface.Answer Implements CL_interface.DefultFoundation.FExit
        Me.Close()
    End Function

    Public Function Checkdata() As Boolean Implements CL_interface.DefultFoundation.Checkdata

    End Function

    Public Function FSave(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FSave

    End Function

    Public Function FSearch(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FSearch

    End Function

    Public Function FCancelSave(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancelSave

    End Function

    Public Function FDelete(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FDelete

    End Function

    Public Function FCancel(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancel

    End Function

    Public Function FPrint(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FPrint
        Try

            UI_STAT = CL_interface.MemberFormStatus.UIPrint
            Dim fill_data As New RPT_StockcardModels.Fillter_Stockcard
            If chk_datefillter.Checked Then
                If IsDate(dtp_dateStart.Value) And IsDate(dtp_dateEnd.Value) Then
                    fill_data.Date_Start = CL_date.Condate(dtp_dateStart.Value, "yyyy/MM/dd", "TH")
                    fill_data.Date_End = CL_date.Condate(dtp_dateEnd.Value, "yyyy/MM/dd", "TH")
                Else
                    Throw New Exception("รูปแบบวันที่ไม่ถูกต้อง " & vbNewLine & " EX. 12/08/2020 or 2020/08/12")
                End If
            End If

            If STCODE.SelectedValue <> "" Then
                fill_data.STCODE = STCODE.SelectedValue
            End If
            If pcode1.Text <> "" Then
                fill_data.PCODE1 = pcode1.Text.Trim
            End If
            If pcode2.Text <> "" Then
                fill_data.PCODE2 = pcode2.Text.Trim
            End If

            Dim json As String = JsonConvert.SerializeObject(fill_data)
            Dim link As String = String.Format(Center.Post_API.RPT_Stockcard, UI_STAT)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV, API.set_Timeout.Min_5).POSTResponse(link, json, "POST")
            Dim retValue As RPT_StockcardModels.value = JsonConvert.DeserializeObject(Of RPT_StockcardModels.value)(json_Response)

            If retValue.Respon.Result Then

                'Dim dt As New DataTable
                'dt = New Convert_Data().ToDataTable(Of RPT_BalanceModels.Balance_data)(retValue.Data)

                Dim p As String
                Dim Parameter As New List(Of ReportParameter)
                Parameter.Add(New ReportParameter("Corpname", Center.data_profile.Corp.BRNNAMETHAI))

                Dim rpt_path As String = Center.Default_Path_RPT & "RPT_Stockcard.rdlc"

                Dim data_ As New Frm_Reportviewer.datasoucemodel
                Dim datasouce As New List(Of Frm_Reportviewer.datasoucemodel)
                data_.data = retValue.Data
                data_.ReportData = "data"
                datasouce.Add(data_)
                Dim reportview As New Frm_Reportviewer(New Frm_Reportviewer.model With {
                                                    .datasouce = datasouce,
                                                    .ReportPath = rpt_path,
                                                    .ReportParameter = Parameter,
                                                    .Report_Type = Frm_Reportviewer.Report_Type.show,
                                                    .Titletext = Me.Text
    })

                reportview.ShowDialog()
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
        Finally
            SCR_TR_ID = Nothing
        End Try
    End Function

    Public Function FClose(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FClose

    End Function



#Region "Method"

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


    Private Sub Search_Product(obj As Object)

        Try
            'Dim Grid_column As New List(Of F_SearchData.GridColumn)
            'Grid_column.Add(New F_SearchData.GridColumn With {.Columntext = "จำนวนหน่วยหลัก", .ColumnName = "value1"})
            Dim f As New F_SearchData With {
                                                .Multiselect = False,
                                                .Frm_text = "ค้นหาหน่วยนับรอง",
                                                .SCR_TYPE = "PROD",
                                                .fixvalue = "",
                                                .lbl_CODE_text = "รหัสสินค้า",
                                                .lbl_NAME_text = "ชื่อสินค้า",
                                                .grid_code_text = "รหัสสินค้า",
                                                .grid_name_text = "ชื่อสินค้า"
                                            }
            f.Icon = Center.icon

            If (f.ShowDialog) = DialogResult.OK Then
                If obj.name = btn_scr_Product1.Name Then
                    For Each Val As DataGridViewRow In f.dgv_scr.SelectedRows
                        pcode1.Text = Val.Cells("CODE").Value
                        pname1.Text = Val.Cells("NAME").Value
                        pcode2.Text = Val.Cells("CODE").Value
                        pname2.Text = Val.Cells("NAME").Value
                    Next
                ElseIf obj.name = btn_scr_Product2.Name Then
                    For Each Val As DataGridViewRow In f.dgv_scr.SelectedRows
                        pcode2.Text = Val.Cells("CODE").Value
                        pname2.Text = Val.Cells("NAME").Value
                    Next
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Public Function FCopy(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCopy
        Throw New NotImplementedException()
    End Function
#End Region
End Class
Imports Control_us
Imports MD
Imports Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution
Imports Newtonsoft.Json
Imports Microsoft.Reporting.WinForms

Public Class F_RPT_Receive
    Implements MD.CL_interface.DefultFoundation

    Dim UI_STAT As MD.CL_interface.MemberFormStatus = CL_interface.MemberFormStatus.UIOpen
    Public SCR_TR_ID As String
    Dim frm_sub As New F_Receive
    Dim menustruc As New Menu.menuStruct

    Private Sub F_MAS_Product_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        F_Main.lbl_Display.Text = Me.Tag.MenuName
        Me.TabText = Me.Tag.MenuName
    End Sub
    Private Sub F_Receive_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        USERPROFILE()
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


        'AddHandler Me.btn_scr.Click, AddressOf EV_Btn_Click






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

            End Select
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

#End Region

    Public Sub EnableControl(Value As Boolean) Implements CL_interface.DefultFoundation.EnableControl

    End Sub

    Public Sub ClearControl() Implements CL_interface.DefultFoundation.ClearControl
        dtp_date.Value = Center.date_now
        Gencolumn()
    End Sub

    Public Sub Load_MAS() Implements CL_interface.DefultFoundation.Load_MAS
        Try
            USERPROFILE()
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
            Dim fill_data As New RPT_ReceiveModels.Fillter_Receive
            fill_data.DOCTYPE = menustruc.DOCTYPE
            If chk_datefillter.Checked Then
                If IsDate(dtp_date.Value) Then
                    fill_data.DCDATE = CL_date.Condate(dtp_date.Value, "yyyy/MM/dd", "TH")
                Else
                    Throw New Exception("รูปแบบวันที่ไม่ถูกต้อง " & vbNewLine & " EX. 12/08/2020 or 2020/08/12")
                End If
            End If
            If docno.Text <> "" Then
                fill_data.DOCNO = docno.Text.Trim
            End If
            If ref_docno.Text <> "" Then
                fill_data.REFDOCNO = ref_docno.Text.Trim
            End If
            If PERCODE.Text <> "" Then
                fill_data.PERCODE = PERCODE.Text.Trim
            End If

            Dim json As String = JsonConvert.SerializeObject(fill_data)
            Dim link As String = String.Format(Center.Post_API.RPT_Receive, UI_STAT)
            Dim json_Response As String = New API(Center.Data_Config.API_SRV, API.set_Timeout.Min_5).POSTResponse(link, json, "POST")
            Dim retValue As RPT_ReceiveModels.value = JsonConvert.DeserializeObject(Of RPT_ReceiveModels.value)(json_Response)

            If retValue.Respon.Result Then

                'Dim dt As New DataTable
                'dt = New Convert_Data().ToDataTable(Of RPT_ReceiveModels.Rceive_data)(retValue.Data)

                Dim p As String
                Dim Parameter As New List(Of ReportParameter)
                Parameter.Add(New ReportParameter("Corpname", Center.data_profile.Corp.BRNNAMETHAI))
                Parameter.Add(New ReportParameter("ReportName", menustruc.MenuName2))

                Dim rpt_path As String = ""
                If Me.menustruc.DOCTYPE = "MOV.ADJ" Then
                    rpt_path = Center.Default_Path_RPT & "RPT_Adjust.rdlc"
                ElseIf Me.menustruc.DOCTYPE = "MOV.REC" Then
                    rpt_path = Center.Default_Path_RPT & "RPT_Receive.rdlc"
                Else
                    rpt_path = Center.Default_Path_RPT & "RPT_MOV_Bytype.rdlc"
                End If


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
                PERCODE.SelectedValue = ""
                PERCODE.Text = ""
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

    Public Function FCopy(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCopy
        Throw New NotImplementedException()
    End Function
#End Region
End Class
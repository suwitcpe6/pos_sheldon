Imports Control_us
Imports MD
Imports Newtonsoft.Json
Imports System.IO
Imports System.Threading

Public Class F_Main_Sale
    Implements CL_interface.DefultFoundation

    Public Frmcurrentstatus As CL_interface.MemberFormStatus = CL_interface.MemberFormStatus.UINew
    Dim dt_shop As DataTable
    Dim dt_shopBTN As New DataTable
    'Dim SHOP_Buttons As New List(Of SHOP_Buttons_Model.ShopbuttonsModels)
    'Dim happyhour As New List(Of SHOP_Buttons_Model.happyhourModels)
    Public dt_paroduct As New DataTable
    Public dt_Tender As New DataTable
    Public WithEvents pItems As UC_Product_Items
    Public SP(1) As Ports.SerialPort

    'Public save As Boolean = False
    Dim IS_PAY_MENT As Boolean = False
    Dim dt_happyhour As New DataTable
    Dim Display2 As F_Display2
    Private Sub F_Sale_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            txt_version.Text = " V. " & New AUTO_UPDATE().version & "  " & Replace(New AUTO_UPDATE().version_InRoom, "_", " ") & " : " & Replace(Replace(Module1.API_version, "_", " "), """", "")


            Me.CheckForIllegalCrossThreadCalls = False
            lbl_cur_Group_page.Tag = 1
            lbl_cur_Items_page.Tag = 1
            ClearControl()
            Load_MAS()


            If Center.Data_Config.SHOWNETSALE = F_Setting.rd_shownet_s.Tag Then
                Invoke(Sub() Me.txt_totel.Visible = True)
            Else
                Invoke(Sub() Me.txt_totel.Visible = False)
            End If

            Timer_Reconnect.Enabled = True
            Time_reset(True)

            check_Display()

            If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then
                Label_US6.Visible = True
                Button_US24.Visible = True
                fl_payment.Visible = True
            Else
                Label_US6.Visible = False
                Button_US24.Visible = False
                fl_payment.Visible = False
            End If



        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub check_Display()

        If Center.Data_Config.COMPORT = "" And Center.Data_Config.CUSDISPLAY = F_Setting.rd_comport.Tag Then
            Messages.Texts(Me.Text, "ไม่ได้ตั้งค่า COMPORT Customer Display ", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
        End If
        If Center.Data_Config.CUSDISPLAY = F_Setting.rd_Monitor.Tag Then
            Display2 = New F_Display2
            If Not Multidisplay.display2(Display2) Then '
                Messages.Texts("Customer Display False !!", "กรุณาเชื่อมต่อ Customer Display", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
            Else
                Display2.lbl_corpname.Text = Center.data_profile.COMPNAME
            End If
        End If

    End Sub
    Dim time_count = Center.Data_Config.refresh_screen
    Private Sub Time_reset(start As Boolean)
        If start Then
            time_count = Center.Data_Config.refresh_screen
            Timer_Reset.Enabled = False
            If Center.Data_Config.refresh_screen > 0 Then
                Timer_Reset.Interval = 1000 : Timer_Reset.Enabled = True
            End If
        Else
            Timer_Reset.Enabled = False
            time_count = Center.Data_Config.refresh_screen
        End If
    End Sub
    Private Sub Timer_Reset_Tick(sender As Object, e As EventArgs) Handles Timer_Reset.Tick
        time_count -= 1
        Invoke(Sub() lbl_reset.Text = "ล้างหน้าจอใน " & time_count & " แตะเพื่อเริ่มใหม่")
        If time_count < 10 Then
            If lbl_reset.ForeColor = Color.Black Then
                'lbl_reset.BackColor = Color.Red
                lbl_reset.ForeColor = Color.Red
            Else
                'lbl_reset.BackColor = Color.White
                lbl_reset.ForeColor = Color.Black
            End If
        End If
        If time_count = 0 Then
            time_count = Center.Data_Config.refresh_screen
            Me.ClearControl()
            Me.SetDefalt()

        End If

    End Sub
    Private Sub Lbl_reset_Click(sender As Object, e As EventArgs) Handles lbl_reset.Click
        time_count = Center.Data_Config.refresh_screen
    End Sub
    Public Sub SetEvent() Implements CL_interface.DefultFoundation.SetEvent
        Throw New NotImplementedException()
    End Sub

    Public Sub EnableControl(Value As Boolean) Implements CL_interface.DefultFoundation.EnableControl
        Throw New NotImplementedException()
    End Sub

    Public Sub ClearControl() Implements CL_interface.DefultFoundation.ClearControl
        Try



            Me.cur_Items = Nothing

            'Me.lbl_docno.Text = ""

            'Fl_shopButton_clear
            'FL_Items_clear

            Me.txt_qty_totel.Text = "0"
            Me.txt_Amount.Text = "0.00"

            txt_lcd.Text = "0.00"
            'Unselect_Fl_shopButton()
            Gencolumn()
            Timer_setfocus.Enabled = False
            'save = False

            txt_barcode.Text = ""
            'Me.txt_barcode.US_Enable = False
            ''Me.txt_barcode.Enabled = False
            'Me.ForeColor = Color.White
            'cardtype_Click("")


            MD.Memory.FlushMemory()
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        Finally

        End Try
    End Sub
    Dim Shop_id As String = ""

    Private Sub Fl_shopButton_clear()
        For Each c As Control In Fl_shopButton.Controls
            c = Nothing
        Next
        Fl_shopButton.Controls.Clear()
    End Sub
    Private Sub FL_Items_clear()
        For Each c As Control In FL_Items.Controls
            c = Nothing
        Next
        FL_Items.Controls.Clear()
    End Sub
    Public Sub Load_MAS() Implements CL_interface.DefultFoundation.Load_MAS
        Try
            FL_Shop.Controls.Clear()
            Fl_shopButton_clear()
            Shop_id = ""
            For Each val As Shop_list In Center.Data_Config.SHOP_list
                If Not val Is Nothing Then
                    If val.SHOP_ID = 0 Then Continue For
                    If Shop_id = "" Then
                        Shop_id &= val.SHOP_ID.ToString()
                    Else
                        Shop_id &= "," & val.SHOP_ID.ToString()
                    End If
                End If
            Next
            If Shop_id = "" Then
                Messages.Texts(Me.Text, "ไม่ได้ตั้งค่าร้านค้า", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)

                Exit Sub
            End If

            '/////////////////////////////[SHOPBUTTONS]////////////////////////////////////////////////
            Me.Invoke(Sub() Load_SHOP_Buttons(Shop_id))
            '[SHOPS]
            'Me.Invoke(Sub() Load_shop(Shop_id))
            ThreadPool.QueueUserWorkItem(New System.Threading.WaitCallback(AddressOf Load_shop), Shop_id)

            Dim Tender_val As New Load_Tender_val With {.Shop_id = Shop_id}
            ThreadPool.QueueUserWorkItem(New System.Threading.WaitCallback(AddressOf Load_Tender), Tender_val)

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try

    End Sub
    Structure Load_Tender_val
        Dim Shop_id As String
    End Structure
    Private Sub Load_Tender(Tender_val As Load_Tender_val)
        Try
            Dim ret2 As New TenderModels.value
            Dim json2 = New API(Center.Data_Config.API).GETSON(Center.Link_API.Get_API.SEL_TenderCL & Tender_val.Shop_id.ToString)
            'Dim json2 = New API(Center.Data_Config.API)GETSON(String.Format(Center.Link_API.Get_API.SEL_TenderCL, Tender_val.Shop_id))
            ret2 = (JsonConvert.DeserializeObject(Of TenderModels.value)(json2))
            If ret2.Respon.Result Then
                dt_Tender = New API(Center.Data_Config.API).ToDataTable(Of TenderModels.Sel_Tender)(ret2.Data)
            Else
                If ret2.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret2.Respon.SystemErrorMessage.ToString)
                Else
                    Messages.Texts(Me.Text, ret2.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub Load_SHOP_Buttons(Shop_id As String)
        Try

            cur_Items = Nothing
            Dim ret2 As New SHOP_Buttons_Model.value_button
            Dim json2 = New API(Center.Data_Config.API).GETSON(Center.Link_API.Get_API.Shop_Buttons & Shop_id)
            ret2 = (JsonConvert.DeserializeObject(Of SHOP_Buttons_Model.value_button)(json2))
            If ret2.Respon.Result Then
                Dim con_data As New API(Center.Data_Config.API)
                dt_shopBTN = con_data.ToDataTable(Of SHOP_Buttons_Model.ShopbuttonsModels)(ret2.Data.Shopbuttons)

                dt_shopBTN.Columns.Add("SEQ", GetType(Integer))
                For i As Integer = 0 To dt_shopBTN.Rows.Count - 1
                    dt_shopBTN.Rows(i)("SEQ") = i + 1
                Next
                'Me.SHOP_Buttons = ret2.Data.Shopbuttons
                'Me.happyhour = ret2.Data.happyhour




                Dim col() As String = {"SHOPID", "timestart", "timeend", "happyhour_id"}
                Dim dt As New DataTable
                Try
                    dt_happyhour = Me.dt_shopBTN.DefaultView.ToTable(True, col).Select(" SHOPID = '" & Shop_id & "' ", " happyhour_id asc").CopyToDataTable
                    dt_happyhour.Columns.Add("UI_Reset", GetType(Boolean))
                    dt_happyhour.Columns.Add("UI_Reset2", GetType(Boolean))
                    For Each drow As DataRow In dt_happyhour.Rows
                        drow("UI_Reset") = False
                        drow("UI_Reset2") = False
                    Next
                Catch ex As Exception
                    Exit Sub
                End Try



            Else
                If ret2.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret2.Respon.SystemErrorMessage.ToString)
                Else
                    Messages.Texts(Me.Text, ret2.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
#Region "Menu"
    Dim Group_display As Integer = 0
    Dim cur_Group As New Button
    Dim Items_display As Integer = 0
    Dim cur_Items As New Button
    Private Sub Load_shop(Shop_id As String)
        Try
            Me.ClearControl()
            Dim ret As New SHOP_ModelS.value
            Dim json = New API(Center.Data_Config.API).GETSON(Center.Link_API.Get_API.shop_loaddata & Shop_id)
            If IsNothing(json) Then Exit Sub
            ret = (JsonConvert.DeserializeObject(Of SHOP_ModelS.value)(json))
            If ret.Respon.Result Then
                'dt_shop = New API(Center.Data_Config.API)ToDataTable(Of SHOP_ModelS.shop_value)(JsonConvert.DeserializeObject(Of List(Of SHOP_ModelS))(json))
                dt_shop = New API(Center.Data_Config.API).ToDataTable(Of SHOP_ModelS.Model)(ret.Data)

                'If ret.Data.Count > 1 Then
                '    Messages.Texts(Me.Text, "มีการกำหนดจุดขายมากกว่า 1 จุด" & vbNewLine & "กรุณาตรวจสอบการตั้งค่า IP ร้านค้ากับจุดขาย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                '    Application.Exit()
                'End If

                If ret.Data.Count > 0 Then

                    'Dim gen_btn As New CL_Flowlayout
                    'gen_btn.fill_BTN(ret.Data, FL_Shop)

                    FL_Shop.Controls.Clear()
                    Dim btn As Button
                    For Each val As SHOP_ModelS.Model In ret.Data

                        'Dim drow() As DataRow
                        'Dim col() As String = {"SHOPID", "TERMINAL_ID"}
                        'Dim dt As DataTable
                        Try
                            'dt = Me.dt_shopBTN.DefaultView.ToTable(True, col).Select("  SHOPID = '" & val.SHOPID & "' ", " SHOPID asc").CopyToDataTable
                            Dim data = ret.Data.Where(Function(x) x.SHOPID = val.SHOPID)
                            If data.Count > 1 Then
                                Messages.Texts(Me.Text, "มีการกำหนดจุดขายมากกว่า 1 จุด" & vbNewLine & "กรุณาตรวจสอบการตั้งค่า IP ร้านค้ากับจุดขาย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                                Application.Exit()
                            End If
                        Catch ex As Exception
                            Exit Sub
                        End Try


                        btn = New Button

                        btn.Name = val.SHOPID
                        btn.Text = val.SHOPNAME
                        btn.BackColor = CL_Flowlayout.SHOP_Unselect
                        btn.ForeColor = CL_Flowlayout.SHOP_ForeColor
                        btn.Width = CL_Flowlayout.SHOP_Width
                        btn.Height = CL_Flowlayout.SHOP_Height
                        btn.FlatAppearance.BorderColor = System.Drawing.Color.White
                        btn.FlatStyle = System.Windows.Forms.FlatStyle.Standard
                        btn.Font = CL_Flowlayout.SHOP_Font
                        'btn.Size = New System.Drawing.Size(154, 72)
                        btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                        btn.UseVisualStyleBackColor = False
                        btn.Tag = val

                        AddHandler btn.Click, AddressOf shop_click
                        Me.Invoke(Sub() FL_Shop.Controls.Add(btn))
                    Next
                Else
                    Messages.Texts(Me.Text, "ไม่พบข้อมูลร้านค้า หรือจุดขาย" & vbNewLine & "กรุณาตรวจสอบการตั้งค่า IP ร้านค้ากับจุดขาย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                    Application.Exit()
                End If
            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)
                End If
            End If
            For Each c As Control In Me.FL_Shop.Controls
                'Dim btn_call As New Button With {.Name = c.Name, .Text = c.Text}
                shop_click(c, Nothing)
                Exit For
            Next
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)

        End Try
    End Sub
    Private Sub btn_GroupNext_Click(sender As Object, e As EventArgs) Handles btn_GroupNext.Click
        Try
            lbl_cur_Group_page.Tag = CInt(lbl_cur_Group_page.Tag) + 1

            shop_click(cur_Group, Nothing)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_GroupLast_Click(sender As Object, e As EventArgs) Handles btn_GroupLast.Click
        Try
            lbl_cur_Group_page.Tag = CInt(lbl_cur_Group_page.Tag) - 1
            shop_click(cur_Group, Nothing)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Btn_ItemsNext_Click(sender As Object, e As EventArgs) Handles btn_ItemsNext.Click
        Try

            lbl_cur_Items_page.Tag = CInt(lbl_cur_Items_page.Tag) + 1
            btn_group_click(cur_Items, Nothing)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Btn_ItemsLast_Click(sender As Object, e As EventArgs) Handles btn_ItemsLast.Click
        Try
            lbl_cur_Items_page.Tag = CInt(lbl_cur_Items_page.Tag) - 1
            btn_group_click(cur_Items, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub shop_click(sender As Object, e As EventArgs)
        Try
            If dt_shopBTN.Rows.Count = 0 Then
                Exit Sub
            End If
            If Not IsNothing(e) Then
                lbl_cur_Group_page.Text = "1/1"
                lbl_cur_Group_page.Tag = 1
                Me.ClearControl()

            End If

            lbl_cur_Items_page.Text = "1/1"
            lbl_cur_Items_page.Tag = "1"

            Fl_shopButton_clear()
            FL_Items_clear()


            Me.txt_barcode.Focus()
            Dim btn_sen As New Button
            btn_sen = sender

            Dim val As SHOP_ModelS.Model
            val = btn_sen.Tag
            Center.load_profile(val)



            SetDefalt()

            Dim drow() As DataRow
            Dim col() As String = {"SHOPID", "BTNGROUP"}
            Dim dt As DataTable
            Try
                dt = Me.dt_shopBTN.DefaultView.ToTable(True, col).Select("  SHOPID = '" & btn_sen.Name & "' ", " SHOPID asc").CopyToDataTable
            Catch ex As Exception
                Exit Sub
            End Try



            Dim max As Int16 = CInt(Math.Ceiling(dt.Rows.Count / Group_display))
            If lbl_cur_Group_page.Tag > max Then
                lbl_cur_Group_page.Text = max & "/" & max
                lbl_cur_Group_page.Tag = max
                Me.btn_GroupNext.Enabled = False
            Else
                Me.btn_GroupNext.Enabled = True
                lbl_cur_Group_page.Text = lbl_cur_Group_page.Tag & "/" & max
            End If
            If lbl_cur_Group_page.Tag < 1 Then
                lbl_cur_Group_page.Text = "1/1"
                lbl_cur_Group_page.Tag = 1
                btn_GroupLast.Enabled = False
            Else
                btn_GroupLast.Enabled = True
            End If

            dt.Columns.Add("SEQ", GetType(Integer))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("SEQ") = i + 1
            Next
            Dim start As Integer = (CInt(lbl_cur_Group_page.Tag) - 1) * Group_display
            Dim end_ As Integer = ((CInt(lbl_cur_Group_page.Tag) - 1) * Group_display) + Group_display
            Dim condition As String = "  ( seq > " & start & " and seq <= " & end_ & ") "
            cur_Group = sender

            drow = dt.Select(condition, " SHOPID asc")



            Dim btn As Button

            For Each row As DataRow In drow

                btn = New Button

                btn.Name = row("BTNGROUP")
                btn.Text = row("BTNGROUP")
                btn.Width = CL_Flowlayout.GROUP_Width
                btn.Height = CL_Flowlayout.GROUP_Height
                btn.BackColor = CL_Flowlayout.GROUPB_Unselect
                btn.ForeColor = CL_Flowlayout.GROUP_ForeColor
                btn.FlatAppearance.BorderColor = System.Drawing.Color.White
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Standard
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                btn.UseVisualStyleBackColor = False
                btn.Font = CL_Flowlayout.GROUP_Font

                AddHandler btn.Click, AddressOf btn_group_click
                Me.Invoke(Sub() Fl_shopButton.Controls.Add(btn))

            Next
            For Each c As Control In FL_Shop.Controls
                If btn_sen.Name = c.Name Then
                    c.BackColor = CL_Flowlayout.SHOP_select
                Else
                    c.BackColor = CL_Flowlayout.SHOP_Unselect
                End If
            Next


        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Me.Invoke(Sub() Me.ClearControl())
        Finally
            Time_reset(True)
        End Try
    End Sub
    Private Sub btn_group_click(sender As Object, e As EventArgs)
        Try
            FL_Items_clear()

            If Not IsNothing(e) Then
                lbl_cur_Items_page.Text = "1/1"
                lbl_cur_Items_page.Tag = 1
            End If
            Me.txt_barcode.Focus()
            Dim btn_sen As New Button
            btn_sen = sender
            Dim drow() As DataRow
            Dim col() As String = {"SHOPID", "BTNID", "BTNNAME", "BTNGROUP", "BTNPRICE", "BTNPRICE2", "BTNGPRULE", "PCODE", "PNAME", "UNITCODE", "UNITNAME"} ', "BTNGP", "btnflg", "timestart", "timeend", "happyhour_id"}
            Dim dt As New DataTable
            Try
                dt = Me.dt_shopBTN.DefaultView.ToTable(True, col).Select(" BTNGROUP = '" & btn_sen.Name & "' and SHOPID = '" & Center.data_profile.SHOPID & "' ", " BTNID asc").CopyToDataTable
            Catch ex As Exception
                Exit Sub
            End Try
            Dim max As Int16 = Math.Ceiling(dt.Rows.Count / Items_display)
            If lbl_cur_Items_page.Tag > max Then
                lbl_cur_Items_page.Text = max & "/" & max
                lbl_cur_Items_page.Tag = max
                Me.btn_ItemsNext.Enabled = False
            Else
                Me.btn_ItemsNext.Enabled = True
                lbl_cur_Items_page.Text = lbl_cur_Items_page.Tag & "/" & max
            End If
            If lbl_cur_Items_page.Tag < 1 Then
                lbl_cur_Items_page.Text = "1/1"
                lbl_cur_Items_page.Tag = 1
                btn_ItemsLast.Enabled = False
            Else
                btn_ItemsLast.Enabled = True
            End If
            dt.Columns.Add("SEQ", GetType(Integer))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("SEQ") = i + 1
            Next
            Dim start As Integer = (CInt(lbl_cur_Items_page.Tag) - 1) * Items_display
            Dim end_ As Integer = ((CInt(lbl_cur_Items_page.Tag) - 1) * Items_display) + Items_display
            Dim condition As String = "  ( seq > " & start & " and seq <= " & end_ & ") "
            cur_Items = sender
            drow = dt.Select(condition, " BTNID asc")


            'Dim UC_P As UC_Product_Items

            For Each row As DataRow In drow

                pItems = New UC_Product_Items

                pItems.Name = row("BTNID")
                pItems.Text = row("BTNNAME")
                pItems.value.ProductID = row("BTNID")
                pItems.value.ProductName = row("BTNNAME")
                pItems.value.PCODE = row("PCODE")
                pItems.value.PNAME = row("PNAME")
                pItems.value.UNITCODE = row("UNITCODE")
                pItems.value.UNITNAME = row("UNITNAME")

                Dim GP_row() As DataRow


                GP_row = Me.dt_shopBTN.Select(" BTNID = '" & row("BTNID") & "' and  SHOPID = '" & Center.data_profile.SHOPID & "'  ", " happyhour_id asc")
                If GP_row.Length > 0 Then
                    For Each GP_row2 As DataRow In GP_row
                        Dim GP As New CL_GP()
                        GP.Call_GP(GP_row2)
                        pItems.value.ProductPrice = GP.data.BTNPRICE ' row("BTNPRICE")
                        pItems.value.GP = GP.data.GP
                        pItems.value.GPAMOUNT = GP.data.GPAMOUNT
                        pItems.value.GPRULE = GP.data.BTNGPRULE
                        If GP.data.IN_Time Then Exit For
                    Next

                Else
                    Dim GP As New CL_GP()
                    GP.std_GP(row("BTNPRICE"), row("BTNGPRULE"))

                    pItems.value.ProductPrice = row("BTNPRICE")
                    pItems.value.GP = GP.data.GP
                    pItems.value.GPAMOUNT = GP.data.GPAMOUNT
                    pItems.value.GPRULE = GP.data.BTNGPRULE
                End If



                '''old GP
                'If Center.data_profile.GP_FLAG = 2 Then

                '    '    Dim GP As New CL_GP()
                '    '    If GP.Call_GP(Me.happyhour, row("BTNID")) Then
                '    '        pItems.value.GP = GP.data.GP
                '    '        pItems.value.GPAMOUNT = GP.data.GPAMOUNT
                '    '    Else
                '    '        pItems.value.GP = CDbl(row("BTNGP"))
                '    '        pItems.value.GPAMOUNT = Math.Round((CDbl(row("BTNPRICE")) * CDbl(row("BTNGP"))) / 100, 3, MidpointRounding.AwayFromZero)

                '    '    End If
                'Else
                '    
                '    '    pItems.value.GP = Center.data_profile.GP
                '    '    pItems.value.GPAMOUNT = Math.Round((CDbl(row("BTNPRICE")) * Center.data_profile.GP) / 100, 3, MidpointRounding.AwayFromZero)
                'End If


                pItems.Width = CL_Flowlayout.Items_width
                pItems.Height = CL_Flowlayout.Items_Height
                pItems.BackColor = CL_Flowlayout.Items_unselect
                pItems.value.Items_ForeColor = CL_Flowlayout.Items_ForeColor
                pItems.Font = CL_Flowlayout.Items_Font
                'pItems.FlatAppearance.BorderColor = System.Drawing.Color.White
                'pItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                'pItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                'pItems.UseVisualStyleBackColor = False

                AddHandler pItems.Items_Click, AddressOf btn_Items_click
                FL_Items.Controls.Add(pItems)

            Next
            For Each c As Control In Fl_shopButton.Controls
                If btn_sen.Name = c.Name Then
                    c.BackColor = CL_Flowlayout.GROUP_select
                Else
                    c.BackColor = CL_Flowlayout.GROUPB_Unselect
                End If
            Next
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        Finally
            Time_reset(True)
        End Try
    End Sub
    Private Sub btn_Items_click(sender As Object, e As EventArgs)
        Try
            Me.txt_barcode.Focus()
            Timer_setfocus.Enabled = True
            Dim btn_sen As New UC_Product_Items
            btn_sen = sender


            DGV_Product_Add(btn_sen)
            callTotel()

            For Each c As Control In FL_Items.Controls
                If btn_sen.Name = c.Name Then
                    c.BackColor = CL_Flowlayout.Items_select
                Else
                    c.BackColor = CL_Flowlayout.Items_unselect
                End If
            Next

            btn_sen = Nothing
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        Finally
            Time_reset(True)
        End Try
    End Sub
    Private Sub Unselect_Fl_shopButton()
        For Each c As Control In Fl_shopButton.Controls
            c.BackColor = CL_Flowlayout.SHOP_Unselect
        Next
    End Sub
    Private Sub callTotel()
        Try
            Me.txt_qty_totel.Text = Me.dt_paroduct.Compute("sum(Qty)", "")
            Me.txt_Amount.Text = CDbl(Me.dt_paroduct.Compute("sum(MRTAMOUNT)", "")).ToString("#,##0.00")
        Catch ex As Exception
            Me.txt_qty_totel.Text = 0
            Me.txt_Amount.Text = 0
        End Try

    End Sub



#End Region

    Public Sub Load_Data(value1 As String, value2 As String, value3 As Object) Implements CL_interface.DefultFoundation.Load_Data
        Throw New NotImplementedException()
    End Sub

    Public Sub Gencolumn() Implements CL_interface.DefultFoundation.Gencolumn

        Try

            Me.DGV_Product.AutoGenerateColumns = False
            Me.DGV_Product.Columns.Clear()
            Dim Col As New DataGridViewTextBoxColumn
            'Dim btn As New DataGridViewButtonColumn
            'Dim Chk As New DataGridViewCheckBoxColumn
            Dim read As Boolean = True

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับ"
            Col.Width = 50
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "SEQ"
            Col.Name = "SEQ"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อ"
            'Col.Width = 80
            Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "FOODID"
            Col.Name = "FOODID"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รายการอาหาร"
            'Col.Width = 250
            Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Col.Visible = True
            Col.ReadOnly = read
            Col.DataPropertyName = "FOODNAME"
            Col.Name = "FOODNAME"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จำนวน"
            Col.Width = 80
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "Qty"
            Col.Name = "Qty"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ราคา"
            Col.Width = 60
            Col.Visible = True
            Col.ReadOnly = read
            Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Col.DataPropertyName = "MRTAMOUNT"
            Col.Name = "MRTAMOUNT"
            Me.DGV_Product.Columns.Add(Col)


            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "สถานะ"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "status"
            Col.Name = "status"
            Me.DGV_Product.Columns.Add(Col)


            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "GP"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "GP"
            Col.Name = "GP"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "GPAMOUNT"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "GPAMOUNT"
            Col.Name = "GPAMOUNT"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "PCODE"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "PCODE"
            Col.Name = "PCODE"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "PNAME"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "PNAME"
            Col.Name = "PNAME"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "UNITCODE"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "UNITCODE"
            Col.Name = "UNITCODE"
            Me.DGV_Product.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "UNITNAME"
            Col.Width = 50
            Col.Visible = False
            Col.ReadOnly = read
            Col.DataPropertyName = "UNITNAME"
            Col.Name = "UNITNAME"
            Me.DGV_Product.Columns.Add(Col)



            Me.dt_paroduct.Rows.Clear()
            Me.dt_paroduct.Columns.Clear()
            With Me.dt_paroduct.Columns
                .Add("SEQ")
                .Add("CTID")
                .Add("CUSED")
                .Add("BARCODE")
                .Add("SHOPID")
                .Add("POSID")
                .Add("MRTAMOUNT", GetType(Decimal))
                .Add("MRTSTATUS")
                .Add("MRTSLIPNO")
                .Add("MRTLUPDATE")
                .Add("TID")
                .Add("UID")
                .Add("LUPDATE")
                .Add("BACKUPFLG")
                .Add("CHKFLG")
                .Add("VOIDNO")
                .Add("CUSED1")
                .Add("FOODID")
                .Add("FOODNAME")
                .Add("SHOPENDFLG")
                .Add("GP")
                .Add("GPAMOUNT")
                .Add("GPRULE")
                .Add("STOCKID")
                .Add("TAXINVOICE")
                .Add("CREDITNOTES")
                .Add("CARDTENDOR")
                .Add("CARDREF")
                .Add("CARDPURSE")
                .Add("taxPrint")
                .Add("status")
                .Add("Qty", GetType(Integer))
                .Add("PCODE")
                .Add("PNAME")
                .Add("UNITCODE")
                .Add("UNITNAME")
            End With
            DGV_Product.DataSource = Me.dt_paroduct


            If Not IsNothing(Display2) Then
                Display2.dt_data = Me.dt_paroduct
            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try

    End Sub
    Private Sub Gen_dt_card()
        Me.dt_paroduct.Rows.Clear()
        Me.dt_paroduct.Columns.Clear()
        With Me.dt_paroduct.Columns
            .Add("MRTSLIPNO")
            .Add("BARCODE")
            .Add("CARDTYPE")
            .Add("SEQ", GetType(Integer))
            .Add("SHOPID")
            .Add("POSID")
            .Add("CUSED")
            .Add("CUSED1")
            .Add("MRTAMOUNT", GetType(Double))
            .Add("CBALANCE", GetType(Double))
            .Add("CBALANCEREMAIN", GetType(Double))
            .Add("GP", GetType(Integer))
            .Add("GPAMOUNT", GetType(Double))
            .Add("STATUS")


        End With
    End Sub
    Private Sub DGV_Product_Add(btn As UC_Product_Items)
        Try
            Dim Val As ItemData = btn.value
            If dt_paroduct.Rows.Count >= 20 Then
                Messages.Texts("รายการขายเกินกำหนด", "รายการขายเกิน 20 ราย ไม่สามารถเพิ่มได้", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Exit Sub
            End If

            Dim drow As DataRow
            drow = dt_paroduct.NewRow

            'Dim GP As New CL_GP()
            'Dim S_row() As DataRow
            'S_row = Me.dt_shopBTN.Select(" BTNID = '" & btn.Name & "' ", " BTNID asc")
            'GP.Call_GP(S_row(0))



            drow("SEQ") = dt_paroduct.Rows.Count + 1
            'drow("CTID") = 0
            drow("CUSED") = 0
            drow("BARCODE") = ""
            'drow("SHOPID") = 0
            drow("POSID") = ""
            drow("MRTAMOUNT") = Val.ProductPrice.ToString("#,###.00")
            drow("MRTSTATUS") = ""
            drow("MRTSLIPNO") = ""
            'drow("MRTLUPDATE") = Date.Now
            drow("TID") = ""
            drow("UID") = ""
            drow("LUPDATE") = ""
            'drow("BACKUPFLG") = ""
            'drow("CHKFLG") = ""
            drow("VOIDNO") = ""
            drow("CUSED1") = ""
            drow("FOODID") = Val.ProductID
            drow("FOODNAME") = Val.ProductName
            'drow("SHOPENDFLG") = ""


            drow("GP") = Val.GP
            drow("GPAMOUNT") = Val.GPAMOUNT
            drow("GPRULE") = Val.GPRULE
            drow("STOCKID") = ""
            drow("TAXINVOICE") = ""
            drow("CREDITNOTES") = ""
            drow("CARDTENDOR") = ""
            drow("CARDREF") = ""
            drow("CARDPURSE") = ""
            drow("taxPrint") = ""
            drow("status") = "ขาย"
            drow("Qty") = 1

            drow("PCODE") = Val.PCODE
            drow("PNAME") = Val.PNAME

            drow("UNITCODE") = Val.UNITCODE
            drow("UNITNAME") = Val.UNITNAME



            Me.dt_paroduct.Rows.Add(drow)
            DGV_Product.DataSource = Me.dt_paroduct
            Me.dt_paroduct.AcceptChanges()

            Me.DGV_Product.Rows.Item(0).Selected = False
            Dim row As Integer = Me.DGV_Product.RowCount - 1
            Me.DGV_Product.FirstDisplayedScrollingRowIndex = row
            Me.DGV_Product.Rows.Item(row).Selected = True
            row_focus(DGV_Product)

            If Not IsNothing(Display2) Then
                Display2.DGV_Product.DataSource = dt_paroduct
                Display2.dt_data = dt_paroduct
            End If

            Val = Nothing
            drow = Nothing
            row = Nothing

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub row_focus(dgv As DataGridView)
        If dgv.RowCount <= 0 Then Exit Sub
        dgv.Rows.Item(0).Selected = False
        Dim row As Integer = dgv.RowCount - 1
        dgv.FirstDisplayedScrollingRowIndex = row
        dgv.Rows.Item(row).Selected = True

    End Sub


    Public Sub SetDefalt() Implements CL_interface.DefultFoundation.SetDefalt

        Me.Group_display = Center.Data_Config.GroupmenuQTY
        Me.Items_display = Center.Data_Config.menuQTY

        Me.txt_shopcode.Text = Center.data_profile.POSID
        Me.txt_shopname.Text = Center.data_profile.SHOPNAME
        Me.lbl_shopname.Text = Center.data_profile.SHOPNAME


        Invoke(Sub() Me.txt_totel.Text = "ยอดขาย = " & sum_net())

        If Me.SP(0) Is Nothing Then
            Me.SP(0) = New Ports.SerialPort
        End If
    End Sub
    Private Function sum_net() As String
        Try
            If IsNothing(Center.data_profile.SHOPID) Then
                Return 0
            End If
            'Dim dt As DataTable
            Dim ret2 As New ResponseMessage
            Dim json2 = New API(Center.Data_Config.API).GETSON(Center.Link_API.Get_API.CARDTRANS_sum_net & Center.data_profile.SHOPID)
            ret2 = (JsonConvert.DeserializeObject(Of ResponseMessage)(json2))
            If ret2.Respon.Result Then
                Return ret2.Respon.ErrorMessage.ToString()
            Else
                If ret2.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret2.Respon.SystemErrorMessage)
                Else
                    Messages.Texts(Me.Text, ret2.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return "0"
        End Try
    End Function

    Public Sub Err(value1 As Object, Optional value2 As String = "") Implements CL_interface.DefultFoundation.Err
        Throw New NotImplementedException()
    End Sub



    Public Function FNew() As CL_interface.Answer Implements CL_interface.DefultFoundation.FNew
        Throw New NotImplementedException()
    End Function

    Public Function FEdit() As CL_interface.Answer Implements CL_interface.DefultFoundation.FEdit
        Throw New NotImplementedException()
    End Function

    Public Function FExit() As CL_interface.Answer Implements CL_interface.DefultFoundation.FExit
        Throw New NotImplementedException()
    End Function

    Public Function Checkdata() As Boolean Implements CL_interface.DefultFoundation.Checkdata
        Throw New NotImplementedException()
    End Function

    Public Function FSave(Optional ByVal obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FSave
        Try
            Using f As New F_payment(Me)
                Me.IS_PAY_MENT = True
                Time_reset(False)
                If Me.DGV_Product.Rows.Count <= 0 Then
                    Messages.Texts(Me.Text, "ไม่พบรายการสินค้า", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                    Exit Function
                End If
                If IsNothing(obj) Then
                    f.IS_CASHcard = False
                Else
                    f.IS_CASHcard = obj
                    f.sale_barcode = Me.txt_barcode.Text
                End If

                If f.ShowDialog() = DialogResult.OK Then
                    Me.ClearControl()
                    Me.SetDefalt()
                    'Messages.Texts(Me.Text, "บันทึกข้อมูลเรียบร้อย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)

                Else
                    'Me.ClearControl()
                End If
            End Using


            'Me.IS_PAY_MENT = True
            'Time_reset(False)
            'If Me.DGV_Product.Rows.Count <= 0 Then
            '    Messages.Texts(Me.Text, "ไม่พบรายการสินค้า", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
            '    Exit Function
            'End If
            'Dim f As New F_payment(Me)
            'If IsNothing(obj) Then
            '    f.is_scan = False
            'Else
            '    f.is_scan = True
            '    f.sale_barcode = Me.txt_barcode.Text
            'End If

            'If f.ShowDialog() = DialogResult.OK Then
            '    Me.ClearControl()
            '    Me.SetDefalt()
            '    'Messages.Texts(Me.Text, "บันทึกข้อมูลเรียบร้อย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Information)

            'Else
            '    'Me.ClearControl()
            'End If
            'f = Nothing
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)

        Finally
            'Me.ClearControl()
            'Me.SetDefalt()
            txt_barcode.Enabled = True
            Timer_setfocus.Enabled = True
            Time_reset(True)
            Me.IS_PAY_MENT = False
        End Try

    End Function
    Private Function Multicard(val As Decimal, Barcode As String)
        Try
            Dim f As New F_Multicard With {.Amount = val, .Barcode = Barcode}

            If f.ShowDialog() = DialogResult.OK Then
                'Me.dt_card = New DataTable

                Me.FSave()
            Else
                Me.ClearControl()
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Function

    Public Function FSearch(Optional ByVal obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FSearch
        Throw New NotImplementedException()
    End Function

    Public Function FCancelSave(Optional ByVal obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancelSave
        Throw New NotImplementedException()
    End Function

    Public Function FDelete(Optional ByVal obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FDelete
        Throw New NotImplementedException()
    End Function

    Public Function FCancel(Optional ByVal obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FCancel
        Throw New NotImplementedException()
    End Function

    Public Function FClose(Optional ByVal obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FClose
        Throw New NotImplementedException()
    End Function

    Private Sub Button_US3_Click(sender As Object, e As EventArgs) Handles Button_US3.Click
        Try
            Dim repay As New F_Repay(Me)
            If Not repay.Loaddata_Repay() Then
                If Messages.Texts("รายการค้างจ่าย", "ตรวจสอบรายการค้างจ่ายไม่สำเร็จ การเชื่อมต่อ Server ขัดข้อง" & vbNewLine & " คุณต้องการปิดโปรโดยไม่มีการตรวจสอบยอดค้างจ่ายหรือไม่ ?", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Warning) = DialogResult.No Then
                    Exit Sub
                End If
            End If
            If Not IsNothing(repay.data_repay) Then
                If repay.data_repay.Count > 0 Then
                    If Messages.Texts("รายการค้างจ่าย", "พบรายการค้างจ่าย Wallet ที่ยังไม่สำเร็จ ทำรายการค้างจ่ายเดี๋ยวนี้", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning) = DialogResult.OK Then
                        repay.ShowDialog()
                        repay = Nothing
                        Exit Sub
                    End If
                End If
            End If

            'If Messages.Texts("ออกจากโปรแกรม", "คุณต้องการออกจากโปรแกรมหรือไม่ ", Messages.ButtonType.YesNo, Messages.MessageBoxIcon.Question) = DialogResult.Yes Then




            Dim val = Messages.Texts("รายงานสรุปยอดขาย", "คุณต้องการปริ้นรายงานสรุปยอดขายรายวันหรือไม่ ", Messages.ButtonType.YesNoCancel, Messages.MessageBoxIcon.Question)
            If val = DialogResult.Yes Then
                Rpt_dayend()
                Application.Exit()
                'End If

            ElseIf val = DialogResult.No Then
                Application.Exit()
            End If

            'End If
        Catch ex As Exception
            'Msg_err.Show_Err(ex, Me.Text)
            Application.Exit()
        End Try
    End Sub
    Private Function Rpt_dayend() As Boolean
        Dim dataslip As List(Of SALE_Models.dayend_Model)
        Try
            Dim ret As New SALE_Models.Sel_Rpt_dayend
            'Dim json = New API(Center.Data_Config.API).GETSON(Center.Link_API.Get_API.Sel_Rpt_dayend & Center.data_profile.SHOPID & "&MRTLUPDATE=" & Center.DATEWORKING.ToString("yyyy/MM/dd"))
            Dim json = New API(Center.Data_Config.API).GETSON(String.Format(Center.Link_API.Get_API.Sel_Rpt_dayend, Center.data_profile.BRNID, Center.data_profile.SHOPID, Center.DATEWORKING.ToString("yyyy/MM/dd")))


            ret = (JsonConvert.DeserializeObject(Of SALE_Models.Sel_Rpt_dayend)(json))
            If ret.Respon.Result Then
                If ret.Data.Count <= 0 Then
                    Messages.Texts("การแจ้งเตือน", "ไม่พบรายการขาย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Return False
                End If

                dataslip = New List(Of SALE_Models.dayend_Model)
                dataslip = ret.Data

                Dim Print As New CL_PrintDocument(New CL_PrintDocument.print_model With {.workdate = Center.DATEWORKING,
                                                                                        .shopname = Me.txt_shopname.Text,
                                                                                        .dayend_Model = dataslip
        })
                Print.Print_to_printter("dayend")

            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If
            Return True
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return False
        Finally
            dataslip = Nothing
            'save = False
        End Try
    End Function

    Private Sub Button_US1_Click(sender As Object, e As EventArgs) Handles Button_US1.Click
        Me.ClearControl()
    End Sub

    Private Sub Button_US2_Click(sender As Object, e As EventArgs) Handles Button_US2.Click
        Try
            If Me.DGV_Product.Rows.Count > 0 Then
                Me.DGV_Product.Rows.Remove(Me.DGV_Product.Rows(Me.DGV_Product.Rows.Count - 1))
                Me.dt_paroduct.AcceptChanges()
                Me.callTotel()
                Dim i As Integer = 1
                'For Each row As DataGridViewRow In Me.DGV_Product.Rows
                '    row.Cells("SEQ").Value = i
                '    i += 1
                'Next
                row_focus(Me.DGV_Product)
            Else
                'ClearControl()
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Private Sub Txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged

    End Sub
    Private Sub txt_barcode_GotFocus(sender As Object, e As EventArgs) Handles txt_barcode.GotFocus
        'If save = False Then
        txt_barcode.Text = ""
        'End If
    End Sub

    Private Sub txt_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txt_barcode.Text = "" Then Exit Sub
            txt_barcode.Enabled = False
            Me.FSave(True)
            txt_barcode.Enabled = True
        End If
        '    Try
        '        If Me.PAYTYPE = "" Then
        '            Messages.Texts("การแจ้งเตือน", "กรุณาเลือกประเภทบัตร", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
        '        End If
        '        txt_barcode.Enabled = False
        '        save = True
        '        Me.FSave()

        '    Catch ex As Exception
        '    Finally
        '        save = False
        '        txt_barcode.Enabled = True
        '    End Try
        'End If
    End Sub
    Dim dataslip As List(Of SALE_Models.slipModel)
    Private Sub Button_US22_Click(sender As Object, e As EventArgs) Handles Button_US22.Click
        Dim f As New F_Reprint

        Dim old_doc = Me.lbl_docno.Text
        If f.ShowDialog = DialogResult.OK Then
            Me.lbl_docno.Text = f.txt_docno.Text
            FPrint_inv(False)
            Me.lbl_docno.Text = old_doc
        End If



    End Sub
    Public Function FPrint(Optional ByVal obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FPrint
        Dim dataslip As List(Of SALE_Models.slipModel)
        Try


            Dim ret As New SALE_Models.print_slip
            Dim multicard As Boolean = obj
            Dim aa As String = String.Format(Center.Link_API.Get_API.CARDTRANS_PrintSlip, Center.data_profile.BRNID, Me.lbl_docno.Text)
            Dim json = New API(Center.Data_Config.API).GETSON(aa)

            ret = (JsonConvert.DeserializeObject(Of SALE_Models.print_slip)(json))
            If ret.Respon.Result Then
                If ret.Data.Count <= 0 Then
                    Messages.Texts("การแจ้งเตือน", "ไม่พบรายการขาย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Return CL_interface.Answer.No
                End If

                dataslip = New List(Of SALE_Models.slipModel)
                dataslip = ret.Data

                Dim Print As New CL_PrintDocument(New CL_PrintDocument.print_model With {
                    .multicard = multicard,
                    .docno = lbl_docno.Text,
                    .shopname = Me.txt_shopname.Text,
                    .dataslip = dataslip
                    })
                Print.Print_to_printter("slip")

            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If

            Return CL_interface.Answer.Yes
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return CL_interface.Answer.No
        Finally
            dataslip = Nothing
            'save = False
        End Try
    End Function
    Public Function FPrint_inv(Optional ByVal obj As Object = Nothing)
        Dim dataslip As List(Of SALE_Models.slipModel)
        Try

            Dim ret As New SALE_Models.print_slip
            Dim json = New API(Center.Data_Config.API).GETSON(Center.Link_API.Get_API.CARDTRANS_PrintSlip_INV & Me.lbl_docno.Text)

            ret = (JsonConvert.DeserializeObject(Of SALE_Models.print_slip)(json))
            If ret.Respon.Result Then
                If ret.Data.Count <= 0 Then
                    Messages.Texts("การแจ้งเตือน", "ไม่พบรายการขาย", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Warning)
                    Return CL_interface.Answer.No
                End If

                dataslip = New List(Of SALE_Models.slipModel)
                dataslip = ret.Data

                Dim Print As New CL_PrintDocument(New CL_PrintDocument.print_model With {
                    .multicard = False,
                    .docno = lbl_docno.Text,
                    .shopname = Me.txt_shopname.Text,
                    .dataslip = dataslip
                    })
                Print.Print_to_printter("slip")

            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If

            Return CL_interface.Answer.Yes
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
            Return CL_interface.Answer.No
        Finally
            dataslip = Nothing
            'save = False
        End Try
    End Function

    Dim lcd As New COMPORT

    Private Sub Txt_Amount_TextChanged(sender As Object, e As EventArgs) Handles txt_Amount.TextChanged
        Try
            Me.txt_lcd.Text = txt_Amount.Text & " Bath"
            If Me.SP(0) Is Nothing Then Exit Sub
            If Center.Data_Config.CUSDISPLAY = F_Setting.rd_Monitor.Tag Then
                If Not IsNothing(Display2) Then
                    Display2.Lbl_Total.Text = txt_Amount.Text
                End If
            ElseIf Center.Data_Config.CUSDISPLAY = F_Setting.rd_comport.Tag Then
                If Center.Data_Config.COMPORT <> "" Then
                    lcd.Print(Center.Data_Config.dafault_display, Me.txt_lcd.Text, Me.SerialPort1, Center.Data_Config.COMPORT)
                End If
            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        Finally
            'Me.SP(0) = Nothing
        End Try
    End Sub

    Private Sub Btn_narmal_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        Me.FSave(False)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_setfocus.Tick
        txt_barcode.Focus()

    End Sub

    Private Sub Chk_Print_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Print.CheckedChanged
        If chk_Print.Checked Then
            chk_Print.ForeColor = Color.Red
        Else
            chk_Print.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Button_US23_Click(sender As Object, e As EventArgs) Handles Button_US23.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer_Reconnect.Tick
        Try
            If API.pingHost(Center.Data_Config.API) Then
                Center.date_now = (New CL_date().Condate((New CL_getdate().Getdate_Realtime), "dd/MM/yyyy HH:mm:ss", "TH"))
                lbl_time.Text = Center.date_now
                lbl_time.ForeColor = Color.Black
                stataus_connect.Visible = True
                stataus_disconnect.Visible = False
            Else
                lbl_time.ForeColor = Color.Red
                stataus_connect.Visible = False
                stataus_disconnect.Visible = True
            End If


            Happy_Hour_Reset()
        Catch ex As Exception
            'If Tooltxt_time.ForeColor = Color.Black Then
            lbl_time.ForeColor = Color.Red
            stataus_connect.Visible = False
            stataus_disconnect.Visible = True
            'Else
            '    Tooltxt_time.ForeColor = Color.Black
            'End If

        End Try

    End Sub
    Public Sub Happy_Hour_Reset()
        If Me.IS_PAY_MENT = False Then
            If Center.data_profile.GP_FLAG = 2 Then
                If IsNothing(dt_happyhour) Then
                    Exit Sub
                End If
                Dim i As Integer = 0
                For Each drow As DataRow In dt_happyhour.Rows
                    If drow("UI_Reset") = False Then
                        Dim G_P As New CL_GP
                        Dim UI_Reset = G_P.UI_Reset(drow)
                        If UI_Reset Then
                            Me.ClearControl()
                            'Load_MAS()
                            'Fl_shopButton_clear
                            FL_Items_clear()
                            Me.SetDefalt()
                            dt_happyhour(i)("UI_Reset") = True
                        End If
                    End If
                    'If drow("UI_Reset") = True Then
                    If drow("UI_Reset2") = False Then
                        Dim G_P As New CL_GP
                        Dim UI_Reset2 = G_P.UI_Reset2(drow)
                        If UI_Reset2 Then
                            Me.ClearControl()
                            'Load_MAS()
                            'Fl_shopButton_clear
                            FL_Items_clear()
                            Me.SetDefalt()
                            dt_happyhour(i)("UI_Reset2") = True
                        End If
                    End If
                    'End If
                    i += 1
                Next
            End If
        End If
    End Sub

    Private Sub Button_US24_Click(sender As Object, e As EventArgs) Handles Button_US24.Click
        Dim repay As New F_Repay(Me)
        repay.ShowDialog()
        repay = Nothing
    End Sub

    Public Function FView(Optional obj As Object = Nothing) As CL_interface.Answer Implements CL_interface.DefultFoundation.FView
        Throw New NotImplementedException()
    End Function

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Dim f As New F_Void(CL_constan.Void_TYPE.CANCEL, False)
        f.ShowDialog()
    End Sub

    Private Sub btn_Refund_Click(sender As Object, e As EventArgs) Handles btn_Refund.Click
        Dim f As New F_Void(CL_constan.Void_TYPE.REFUND, False)
        f.ShowDialog()
    End Sub

    Private Sub Button_US17_Click(sender As Object, e As EventArgs) Handles Button_US17.Click

        Dim f As New F_Void(CL_constan.Void_TYPE.Verify_slip, False)
        f.ShowDialog()
    End Sub





    'Private Sub btn_narmal_Click(sender As Object, e As EventArgs) Handles btn_narmal.Click
    '    Me.PAYTYPE = sender.tag
    '    'Me.txt_barcode.US_Enable = True
    '    ''Me.txt_barcode.Enabled = True
    '    'Me.ForeColor = Color.DimGray

    '    cardtype_Click(sender.name)
    '    Me.txt_barcode.Focus()
    'End Sub
    'Private Sub cardtype_Click(Name As String)
    '    For Each c As Button_US In fl_cardtype.Controls
    '        If c.Name = Name Then
    '            c.BackColor = Color.SkyBlue
    '            c.FlatAppearance.MouseOverBackColor = Color.SkyBlue
    '        Else
    '            c.BackColor = Color.Transparent
    '            c.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
    '        End If
    '    Next
    'End Sub

End Class
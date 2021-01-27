Imports System.ComponentModel
Imports System.Reflection
Imports WeifenLuo.WinFormsUI
Imports MD

Public Class Menu

    Public MenuValue As menuStruct
    Dim Langu As String

    Public HeaderNodeBackColor As Color = Color.SteelBlue
    Public HeaderNodeForeColor As Color = Color.White
    Public SubNodeBackColor As Color = Color.AliceBlue
    Public SubNodeForeColor As Color = Color.Blue

    Public Event F_Closing As CL_Delegate.Form_close
    Enum Frm_State
        BringToFront = 0
        show = 1
    End Enum
    Sub New(Optional val As String = "TH")
        Langu = "TH"
    End Sub
    Structure menuStruct
        Dim ID As String
        Dim MenuObject As String
        Dim MenuObject_sub As String
        Dim MenuName As String
        Dim MenuName2 As String
        Dim MenuCall As String
        Dim MenuCode As String
        Dim DOCTYPE As String
    End Structure
    Public Function ClearMenu(ByRef TMenu As TreeView) As Boolean
        TMenu.Nodes.Clear()
    End Function
    Public Function GenerateFuncMenu(ByRef TMenu As TreeView, ByVal data As DataTable) As Boolean
        Try

            Dim col() As String = {"MNU_HSEQ", "MNU_HNAME_1", "MNU_HNAME_2"}

            Dim dtHead As DataTable = data.DefaultView.ToTable(True, col)
            Dim dtSub As DataTable = data

            Dim menudata As menuStruct = Nothing

            'Add header root
            'Dim headNamefield As String = IIf(Langu = "ENG", "MNU_HNAME_1", "MNU_HNAME_2")
            TMenu.Nodes.Clear()
            For Each Val As DataRow In dtHead.Rows
                If Val.Item("MNU_HSEQ").ToString.Trim = "" Then Continue For
                TMenu.Nodes.Add(New TreeNode With {.Name = Val.Item("MNU_HNAME_2") _
                                                  , .BackColor = HeaderNodeBackColor _
                                                  , .ForeColor = HeaderNodeForeColor _
                                                  , .Text = Val.Item("MNU_HNAME_2") _
                                                  , .Tag = Val.Item("MNU_HSEQ")})
            Next

            'Add Chield root
            'Dim cheildNamefield As String = IIf(Langu = "ENG", "MNU_SNAME_1", "MNU_SNAME_2")
            For Each hdNode As TreeNode In TMenu.Nodes
                For Each Val2 As DataRow In dtSub.Rows
                    If Val2.Item("MNU_CODE").ToString.Trim = "" Then Continue For
                    If Val2.Item("MNU_HSEQ") = hdNode.Tag Then
                        MenuValue = New menuStruct With {.MenuObject = Val2.Item("MNU_OBJ1") _
                                                      , .MenuObject_sub = Val2.Item("MNU_OBJ2") _
                                                      , .MenuName = Val2.Item("MNU_SNAME_1") _
                                                      , .MenuName2 = Val2.Item("MNU_SNAME_2") _
                                                      , .MenuCall = Val2.Item("MNU_SSEQ") _
                                                      , .MenuCode = Val2.Item("MNU_CODE") _
                                                      , .DOCTYPE = Val2.Item("MNU_DEFAULT_DOCTYPE")
                        }

                        hdNode.Nodes.Add(New TreeNode With {.Name = Val2.Item("MNU_OBJ2") _
                                                  , .BackColor = SubNodeBackColor _
                                                  , .ForeColor = SubNodeForeColor _
                                                  , .Text = Val2.Item("MNU_SNAME_2") _
                                                  , .Tag = MenuValue})
                    End If
                Next
            Next

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Function CreateObjectInstance(ByVal objectName As String) As Object
        Dim obj As Object
        Try


            Dim asm As Assembly = Assembly.GetExecutingAssembly()
            Dim location As String = asm.Location
            Dim appName As String = System.IO.Path.GetFileName(location)
            appName = Replace(appName, ".exe", ".") & objectName
            obj = [Assembly].GetEntryAssembly.CreateInstance(appName)



            'Dim appName As String = objectName
            ''If appName.LastIndexOf(".") = -1 Then
            ''appName = [Assembly].GetEntryAssembly.GetName.Name & "." & appName
            ''End If

            'obj = [Assembly].GetEntryAssembly.CreateInstance(appName)



            'Select Case objectName
            '    Case "F_Setting" : obj = New F_Setting
            '    Case "F_MAS_Unit" : obj = New F_MAS_Unit
            '    Case "F_Mas_Product_Group" : obj = New F_Mas_Product_Group
            '    Case "F_MAS_Product" : obj = New F_MAS_Product
            '    Case "F_MAS_Stock" : obj = New F_MAS_Stock


            '    Case "F_Receive_List" : obj = New F_Receive_List



            '        ' Report
            '    Case "F_RPT_Receive" : obj = New F_RPT_Receive
            '    Case "F_RPT_Balance" : obj = New F_RPT_Balance
            '    Case "F_RPT_Stockcard" : obj = New F_RPT_Stockcard
            'End Select

        Catch ex As Exception
            obj = Nothing
        End Try
        Return obj

    End Function
    Public Function LoadSelectedAssembly(ByVal menu_tag As Menu.menuStruct) As String

        Dim frm As New Object
        Try
            menu_tag = menu_tag


            frm = DirectCast(CreateObjectInstance(menu_tag.MenuObject), Form)

            If frm IsNot Nothing Then
                'Check current from had opened
                For Each obj As Form In F_Main.MdiChildren
                    If obj.Name = frm.Name Then
                        If obj.Tag.DOCTYPE = menu_tag.DOCTYPE Then
                            obj.Show()
                            obj.BringToFront()
                            Return obj.Name
                        Else

                            obj.Close()
                        End If

                    End If
                    'If obj.Name = ASMValue.MenuObject_sub Then
                    '    obj.Show()
                    '    obj.BringToFront()
                    '    Return obj.Name
                    'End If
                Next




                'frm = OBJ


                frm.name = menu_tag.MenuObject
                frm.Text = menu_tag.MenuName
                frm.tabtext = menu_tag.MenuName
                frm.tag = menu_tag
                F_Main.Text = menu_tag.MenuName

                'frm.MdiParent = Me
                frm.ControlBox = False
                frm.ShowIcon = False
                frm.ShowInTaskbar = False
                frm.AutoScaleMode = AutoScaleMode.None
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                frm.Dock = DockStyle.Fill
                frm.EnableControl(False)
                frm.ClearControl()
                'frm.Prooerties_control
                frm.SetEvent
                frm.SetDefalt
                frm.Load_MAS()
                frm.Show(Center.DockPanel)
                frm.BringToFront()

                'Dim aa As New Form
                'AddHandler frm.Closing, AddressOf F_Main.from_close
                addHandlers_OBJ(frm)

                Return "Show"


            Else
                Throw New Exception("ไม่พบหน้าจอ '" & menu_tag.MenuName & "' ในระบบ กรุณาตรวจสอบการตั้งค่าเมนู !")
            End If
        Catch ex As Exception
            Msg_err.Show_Err(ex, F_Main.Text)

        End Try
        Return True
    End Function
    Sub addHandlers_OBJ(ByVal inputObject As Object)
        Dim type = inputObject.GetType()
        Dim Form_close = New EventHandler(AddressOf RaiseEvent_formclose)
        type.GetEvent("Closed").AddEventHandler(inputObject, Form_close)
    End Sub
    Private Sub RaiseEvent_formclose()
        RaiseEvent F_Closing()
    End Sub
    Public Function LoadSubform(frm As Object) As Frm_State

        'Dim frm As New Object
        'Try
        Dim menu_tag As New menuStruct
        menu_tag = frm.Tag
        If frm IsNot Nothing Then
            'Check current from had opened
            For Each obj As Form In F_Main.MdiChildren
                If obj.Name = frm.Name Then
                    obj.Show()
                    obj.BringToFront()
                    Return Frm_State.BringToFront
                End If
            Next




            'frm = OBJ
            frm.Name = menu_tag.MenuObject_sub
            frm.Text = menu_tag.MenuName2
            frm.tabtext = menu_tag.MenuName2
            frm.Tag = menu_tag
            F_Main.Text = menu_tag.MenuName2

            'frm.MdiParent = Me
            frm.ControlBox = False
            frm.ShowIcon = False
            frm.ShowInTaskbar = False
            frm.AutoScaleMode = AutoScaleMode.None
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm.Dock = DockStyle.Fill
            frm.EnableControl(False)
            frm.ClearControl()
            'frm.Prooerties_control
            frm.SetEvent
            frm.SetDefalt
            frm.Load_MAS()

            frm.Show(Center.DockPanel)
            frm.BringToFront()

            Return Frm_State.show


        Else
            Throw New Exception("ไม่พบหน้าจอ '" & menu_tag.MenuName & "' ในระบบ กรุณาตรวจสอบการตั้งค่าเมนู !")
        End If
        'Catch ex As Exception
        '    Msg_err.Show_Err(ex, f_main.Text)
        'End Try
        Return True
    End Function







End Class
Public Class Btn_menu
    Public Shared Function Hid_Button(ByRef ts As ToolStrip, UI_STAT As CL_interface.MemberFormStatus)
        For Each ct In ts.Items.OfType(Of ToolStripButton)()



            Select Case UI_STAT
                Case CL_interface.MemberFormStatus.UINew
                    Select Case ct.Name
                        Case "btn_new" : ct.Visible = False
                        Case "btn_Copy" : ct.Visible = False
                        Case "btn_edit" : ct.Visible = False
                        Case "btn_save" : ct.Visible = True
                        Case "btn_cancel_save" : ct.Visible = True
                        Case "btndelete" : ct.Visible = False
                    End Select
                Case CL_interface.MemberFormStatus.UIEdit
                    Select Case ct.Name
                        Case "btn_new" : ct.Visible = False
                        Case "btn_Copy" : ct.Visible = False
                        Case "btn_edit" : ct.Visible = False
                        Case "btn_save" : ct.Visible = True
                        Case "btn_cancel_save" : ct.Visible = True
                        Case "btndelete" : ct.Visible = False
                    End Select
                Case CL_interface.MemberFormStatus.UISearch
                    Select Case ct.Name
                        Case "btn_new" : ct.Visible = True
                        Case "btn_Copy" : ct.Visible = True
                        Case "btn_edit" : ct.Visible = True
                        Case "btn_save" : ct.Visible = False
                        Case "btn_cancel_save" : ct.Visible = False
                        Case "btndelete" : ct.Visible = True
                    End Select
                Case CL_interface.MemberFormStatus.UIOpen
                    Select Case ct.Name
                        Case "btn_new" : ct.Visible = True
                        Case "btn_Copy" : ct.Visible = True
                        Case "btn_edit" : ct.Visible = True
                        Case "btn_save" : ct.Visible = False
                        Case "btn_cancel_save" : ct.Visible = False
                        Case "btndelete" : ct.Visible = True
                    End Select
                Case CL_interface.MemberFormStatus.UICopy
                    Select Case ct.Name
                        Case "btn_new" : ct.Visible = False
                        Case "btn_Copy" : ct.Visible = False
                        Case "btn_edit" : ct.Visible = False
                        Case "btn_save" : ct.Visible = True
                        Case "btn_cancel_save" : ct.Visible = True
                        Case "btndelete" : ct.Visible = False
                    End Select
            End Select




        Next
    End Function

End Class


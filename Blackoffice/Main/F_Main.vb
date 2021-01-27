Imports System.Windows.Forms
Imports WeifenLuo.WinFormsUI
Imports VS2005Extender
Imports MD
Imports Newtonsoft.Json
Imports Control_us
Imports System.Reflection
Imports System.ComponentModel

Public Class F_Main
    'Public F_close As New Menu
    Dim Menu As New Menu
    'Public data_profile As New data_profile
    'Public Data_Config As New data_config
    Private Sub Children_close()
        If Me.MdiChildren.Count - 1 <= 0 Then
            Me.p_background.Visible = True
            Me.p_background.BringToFront()
        Else
            Me.p_background.Visible = False
            'Me.p_background.BringToFront()
        End If

    End Sub
    Private Sub F_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler Menu.F_Closing, AddressOf Children_close
        'Center.icon = Me.Icon
        'Center.data_profile = data_profile
        'Center.Data_Config = Data_Config

        'Public data_profile As New data_profile



        setpanel()



        Prop_Treeview.Add_icon(Tree_Menu)
        'genmenu()
        Load_COMPANYPROFILE()

        switch_bk(True)


        Center.DockPanel = DockPanel

        Children_close()
    End Sub

    Public Function genmenu()
        Menu.GenerateFuncMenu(Tree_Menu, Center.dt_menu)
    End Function

#Region "Dockpanel"

    Public Sub setpanel()
        Dim configFile As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config")
        DockPanel.ActiveAutoHideContent = Nothing
        DockPanel.Parent = Me
        VS2005Style.Extender.SetSchema(DockPanel, VS2005Style.Extender.Schema.FromBase)

        DockPanel.SuspendLayout(True)
        If System.IO.File.Exists(configFile) Then
            'DockPanel.LoadFromXml(configFile, AddressOf ReloadContent)
        Else
            ' Load a basic layout
            CreateBasicLayout()
        End If
        DockPanel.ResumeLayout(True, True)


    End Sub
    Private Sub CreateBasicLayout()
        'SolutionExplorer.Show(DockPanel, WeifenLuo.WinFormsUI.DockState.DockLeft)
        'PropertiesWindow.Show(DockPanel, WeifenLuo.WinFormsUI.DockState.DockLeft)
    End Sub


#End Region


    Private Sub switch_bk(show_bk As Boolean)
        'If show_bk Then
        '    Me.p_background.Visible = True
        '    Me.p_background.BringToFront()
        '    Me.p_background.Dock = DockStyle.Fill

        '    Me.FL_Menu.Visible = False
        '    Me.FL_Menu.SendToBack()
        '    Me.FL_Menu.Dock = DockStyle.Fill
        'Else
        '    Me.p_background.Visible = False
        '    Me.p_background.SendToBack()
        '    Me.p_background.Dock = DockStyle.Fill

        '    Me.FL_Menu.Visible = True
        '    Me.FL_Menu.BringToFront()
        '    Me.FL_Menu.Dock = DockStyle.Fill
        'End If
    End Sub
    Private Sub Btn_inventory_Click(sender As Object, e As EventArgs) Handles Btn_inventory.Click
        'switch_bk(False)
        'Dim f As New F_Receive
        ''f.MdiParent = Me
        ''f.WindowState = FormWindowState.Maximized
        ''f.ControlBox = False
        'f.Icon = Me.Icon
        'f.Show(DockPanel)
        ''hide_menu(False)
    End Sub

    Private Sub hide_menu(val As Boolean)
        'Me.FL_Menu.Visible = val
    End Sub

    Private Sub Btn_setting_Click(sender As Object, e As EventArgs) Handles Btn_setting.Click
        'switch_bk(False)
        'Dim f As New F_settingBlackEnd

        ''f.MdiParent = Me
        ''f.WindowState = FormWindowState.Maximized
        ''f.ControlBox = False
        'f.Icon = Me.Icon
        'f.Show(DockPanel)
        ''hide_menu(False)
    End Sub

    Private Sub Btn_Report_Click(sender As Object, e As EventArgs) Handles Btn_Report.Click
        'switch_bk(False)
        ''Dim f As New F_Receive
        ''f.MdiParent = Me
        ''f.WindowState = FormWindowState.Maximized
        ''f.ControlBox = False
        ''f.Icon = Me.Icon
        ''f.Show()
        ''hide_menu(False)
    End Sub

    Private Sub Btn_master_Click(sender As Object, e As EventArgs) Handles Btn_master.Click

    End Sub

    Private Sub Button_US1_Click(sender As Object, e As EventArgs) Handles Button_US1.Click
        'If Panel_Menu.Visible = True Then
        Panel_Menu.Visible = Not Panel_Menu.Visible
        'Else

        'End If
    End Sub

    Private Sub Tree_Menu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Tree_Menu.AfterSelect
        Try
            If e.Node.Nodes.Count > 0 Then Exit Sub

            Menu.LoadSelectedAssembly(e.Node.Tag)
            Panel_Menu.Visible = False
            Panel_Menu.Width = 250
            p_background.Visible = False
        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub
    Private Sub Tree_Menu_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles Tree_Menu.NodeMouseClick
        If e.Node.IsExpanded = False Then
            Tree_Menu.CollapseAll()
            e.Node.Expand()
        Else
            e.Node.Collapse()
        End If
    End Sub


    'Function CreateObjectInstance(ByVal objectName As String) As Object
    '    Dim obj As Object
    '    Try


    '        'ยังทำไม่ได้ มันอยู่ภายใต้ tjouchpos

    '        ''Dim asm As Assembly = Assembly.GetExecutingAssembly()
    '        ''Dim location As String = asm.Location
    '        ''Dim appName As String = System.IO.Path.GetFileName(location)
    '        ''appName = Replace(appName, ".exe", ".") & objectName
    '        ''obj = [Assembly].GetEntryAssembly.CreateInstance(appName)

    '        'Dim appName As String = objectName
    '        ''If appName.LastIndexOf(".") = -1 Then
    '        ''appName = [Assembly].GetEntryAssembly.GetName.Name & "." & appName
    '        ''End If

    '        'obj = [Assembly].GetEntryAssembly.CreateInstance(appName)



    '        Select Case objectName
    '            Case "F_MAS_Unit" : obj = New F_MAS_Unit
    '            Case "F_Mas_Product_Group" : obj = New F_Mas_Product_Group
    '            Case "F_MAS_Product" : obj = New F_MAS_Product
    '            Case "F_MAS_Stock" : obj = New F_MAS_Stock


    '            Case "F_Receive_List" : obj = New F_Receive_List
    '        End Select

    '    Catch ex As Exception
    '        obj = Nothing
    '    End Try
    '    Return obj

    'End Function
    'Public Function LoadSelectedAssembly(ByVal menu_tag As Menu.menuStruct) As String

    '    Dim frm As New Object
    '    Try
    '        menu_tag = menu_tag
    '        frm = DirectCast(CreateObjectInstance(menu_tag.MenuObject), Form)
    '        If frm IsNot Nothing Then
    '            'Check current from had opened
    '            For Each obj As Form In Me.MdiChildren
    '                If obj.Name = frm.Name Then
    '                    obj.Show()
    '                    obj.BringToFront()
    '                    Return obj.Name
    '                End If
    '                'If obj.Name = ASMValue.MenuObject_sub Then
    '                '    obj.Show()
    '                '    obj.BringToFront()
    '                '    Return obj.Name
    '                'End If
    '            Next




    '            'frm = OBJ
    '            frm.name = menu_tag.MenuObject
    '            frm.Text = menu_tag.MenuName
    '            frm.tabtext = menu_tag.MenuName
    '            frm.tag = menu_tag
    '            lbl_Display.Text = menu_tag.MenuName

    '            'frm.MdiParent = Me
    '            frm.ControlBox = False
    '            frm.ShowIcon = False
    '            frm.ShowInTaskbar = False
    '            frm.AutoScaleMode = AutoScaleMode.None
    '            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    '            frm.Dock = DockStyle.Fill
    '            frm.EnableControl(False)
    '            frm.ClearControl()
    '            frm.SetDefalt
    '            'frm.Prooerties_control
    '            frm.SetEvent
    '            frm.Load_MAS()
    '            frm.Show(DockPanel)
    '            Return "Show"


    '        Else
    '            Throw New Exception("ไม่พบหน้าจอ '" & menu_tag.MenuName & "' ในระบบ กรุณาตรวจสอบการตั้งค่าเมนู !")
    '        End If
    '    Catch ex As Exception
    '        Msg_err.Show_Err(ex, Me.Text)
    '    End Try
    '    Return True
    'End Function

    Private Sub F_Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub Button_US7_Click(sender As Object, e As EventArgs) Handles Button_US7.Click

        close_Children()
    End Sub

    Private Sub close_Children()
        Try
            For Each f As Form In Me.MdiChildren
                f.Close()
            Next
            'f_main.DockPanel.Controls.Clear()
            Children_close()
        Catch ex As Exception

        End Try
    End Sub



#Region "Load main data"

    Private Sub Load_COMPANYPROFILE()
        Try

            Dim ret As New COMPANYPROFILE_Models.value
            Dim json = New API(Center.Data_Config.API_SRV).GETSON(String.Format(Center.Get_API.COMPANYPROFILE_Select))
            ret = (JsonConvert.DeserializeObject(Of COMPANYPROFILE_Models.value)(json))
            If ret.Respon.Result Then
                Center.data_profile.Corp = ret.Data(0)
            Else
                If ret.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret.Respon.SystemErrorMessage.ToString)
                Else
                    Messages.Texts(Me.Text, ret.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If

        Catch ex As Exception
            Msg_err.Show_Err(ex, Me.Text)
        End Try
    End Sub

    Private Sub DockPanel_Paint(sender As Object, e As PaintEventArgs) Handles DockPanel.Paint

    End Sub

    Private Sub Button_US3_Click(sender As Object, e As EventArgs) Handles Button_US3.Click
        Logout()
    End Sub

    Private Sub Logout()
        Me.Menu.ClearMenu(Me.Tree_Menu)
        close_Children()
        Me.Hide()
        F_Lockin.Show()
    End Sub




#End Region
End Class
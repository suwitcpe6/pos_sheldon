Public Class CL_interface
    Public Enum Answer
        Yes = 0
        No = 1
        Cancel = 2
        Special = 3
    End Enum
    Public Interface F_popup
        Sub Clearcotrol()
        Sub Load_MAS()
        Sub Load_Data()
        Sub Gencolumn()
        Sub Prooerties_control()
        Sub SetDefalt()
        Sub Err()
    End Interface
    'Public Enum MemberFormStatus ' ETCStatus
    '    Openform = 1
    '    New_doc = 2
    '    save = 3
    '    Cancelsave = 4
    '    Load_data = 5
    '    Edit = 6
    '    Search = 7
    '    Delete = 8
    '    Cancel_doc = 9
    '    OnError = 0
    'End Enum
    Public Enum MemberFormStatus
        None = 0
        UIOpen = 1
        UINew = 2
        UIEdit = 3
        UIView = 4
        UISave = 5
        UICancelSave = 6
        UISearch = 7
        UIDelete = 8
        UICancel = 9
        UIClose = 10
        UIPrint = 11
        UIExit = 12
        UICopy = 13

        Browse = 20
        Document = 21
        OnError = 99

    End Enum
    Public Enum Type_page
        None = 0
        Master = 1
        Document = 2
    End Enum

    'Sub RefreshToolbar()
    '    Sub EnableControl(Value As Boolean)
    '    Sub ClearControl()
    'Public Interface ToolbarFoundation
    '    Sub SetEvent()
    '    'ReadOnly Property ETCStatus As ETCStatus
    '    ReadOnly Property FormStatus As MemberFormStatus
    '    Function ToolbarNew() As Answer
    '    Function ToolbarEdit() As Answer
    '    Function ToolbarExit() As Answer
    '    Function Checkdata() As Boolean
    '    Function ToolbarSave() As Answer
    '    Function ToolbarSearch() As Answer
    '    Function ToolbarCancelSave() As Answer
    '    Function ToolbarDelete() As Answer
    '    Function ToolbarCancel() As Answer
    '    Function ToolbarPrint() As Answer
    '    Function ToolbarClose() As Answer



    '    Sub RefreshToolbar()
    '    Sub EnableControl(Value As Boolean)
    '    Sub ClearControl()
    '    Sub Load_MAS()
    '    Sub Load_Data(ByVal value1 As String, ByVal value2 As String, ByVal value3 As Object)
    '    Sub Gencolumn()
    '    Sub Prooerties_control()
    '    Sub SetDefalt()
    '    Sub Err(ByVal value1 As Object, Optional ByVal value2 As String = "")

    'End Interface
    Public Interface DefultFoundation
        Sub SetEvent()
        'ReadOnly Property ETCStatus As ETCStatus

        Function FNew() As Answer
        Function FEdit() As Answer
        Function FExit() As Answer
        Function FView(Optional ByVal obj As Object = Nothing) As Answer
        Function FCopy(Optional ByVal obj As Object = Nothing) As Answer
        Function Checkdata() As Boolean
        Function FSave(Optional ByVal obj As Object = Nothing) As Answer
        Function FSearch(Optional ByVal obj As Object = Nothing) As Answer
        Function FCancelSave(Optional ByVal obj As Object = Nothing) As Answer
        Function FDelete(Optional ByVal obj As Object = Nothing) As Answer
        Function FCancel(Optional ByVal obj As Object = Nothing) As Answer
        Function FPrint(Optional ByVal obj As Object = Nothing) As Answer
        Function FClose(Optional ByVal obj As Object = Nothing) As Answer



        Sub EnableControl(Value As Boolean)
        Sub ClearControl()
        Sub Load_MAS()
        Sub Load_Data(ByVal value1 As String, ByVal value2 As String, ByVal value3 As Object)
        Sub Gencolumn()
        Sub SetDefalt()
        Sub Err(ByVal value1 As Object, Optional ByVal value2 As String = "")

    End Interface

End Class

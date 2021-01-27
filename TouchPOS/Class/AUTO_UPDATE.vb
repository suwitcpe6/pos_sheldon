Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
'Imports PublicClassUsed
Imports System.Management
Imports Newtonsoft.Json
Imports Control_us
Imports MD.QR


Public Class AUTO_UPDATE
    Public version_InRoom As String = System.Configuration.ConfigurationManager.AppSettings("LastUpdate").ToString
    Public version As String = System.Configuration.ConfigurationManager.AppSettings("Version").ToString

#Region "เช็ค vertion"

    Public Function version_CheckMRP(ByVal type As String) As Boolean


        Dim sys As String = "POS"
        Dim runexe As String = "TouchPOS.exe"
        Dim colorBackGround As String = "Green"


        Dim pathServ As String = get_pathServer(sys)
        If pathServ = "" Then
            MessageBox.Show("ไม่พบ Path File server ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Dim pathCnt As String = Application.StartupPath & "\Tmp_update"

        Dim di As DirectoryInfo = New DirectoryInfo(pathCnt)
        If Not di.Exists Then
            di.Create()
        End If
        Dim pathCnt_start As String = Application.StartupPath
        Dim verServ As String = get_versionServer(pathServ & "\sys.version.dll")
        If Trim(verServ) = "" Then
            Return False
        End If
        If Trim(verServ) <> Trim(Me.version_InRoom) Then

            For Each fi As IO.FileInfo In di.GetFiles("*", SearchOption.AllDirectories)
                Dim fileNameOnly As String = fi.Name
                Dim createDate As Date = fi.CreationTime.Date
                fi.Delete()
            Next

            Dim p As New Process
            p.StartInfo.Arguments = String.Format("""{0}"" ""{1}"" ""{2}"" ""{3}"" ""{4}""", pathServ, pathCnt, pathCnt_start, runexe, colorBackGround)
            p.StartInfo.FileName = Application.StartupPath & "\Update\POS_UPDATE.exe"
            p.Start()

            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "TouchPOS" Then
                    prog.Kill()
                End If
            Next
            Return True
        Else
            Return False
        End If

    End Function


    Public Function get_pathServer(ByVal sys As String) As String
        Try
            Dim ret2 As New SysVersionModel.value
            Dim json2 = New MD.API(Center.Data_Config.API,).GETSON(Center.Link_API.Get_API.SEL_SysVersion & "0")
            'Dim json2 = New API(Center.Data_Config.API,).GETSON(String.Format(Center.Link_API.Get_API.SEL_TenderCL, Tender_val.Shop_id))
            ret2 = (JsonConvert.DeserializeObject(Of SysVersionModel.value)(json2))
            If ret2.Respon.Result Then

                Return ret2.Data(0).path
            Else
                If ret2.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret2.Respon.SystemErrorMessage.ToString)
                Else
                    Messages.Texts("Error", ret2.Respon.ErrorMessage, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
                End If
            End If
        Catch ex As Exception
            Return ""
        End Try




        'Dim conn As New PrivateClassConnect
        'Dim sql As String
        'sql = " SELECT path  FROM  SysVersion"
        'Dim dt As DataTable = conn.GetData(sql, strConn2)
        'If dt.Rows.Count > 0 Then Return dt.Rows(0)(0)

        'Return ""
    End Function

    Public Function get_versionServer(ByVal _path As String) As String
        Try

            Dim verS As String = ""
            If File.Exists(_path) = True Then
                Dim sFileName As String = _path
                Dim srFileReader As System.IO.StreamReader = System.IO.File.OpenText(sFileName)
                Dim sInputLine As String
                sInputLine = srFileReader.ReadLine()
                Do Until sInputLine Is Nothing
                    verS = sInputLine
                    sInputLine = srFileReader.ReadLine()
                    If sInputLine Is Nothing Then Exit Do
                    If sInputLine.Trim = "" Then Exit Do
                Loop
                srFileReader.Close()
                Return verS
            End If

        Catch ex As Exception
            Return ""
        End Try
        Return ""
    End Function
    Public Shared Function except_updateverstionexe(ByVal ex_name As String) As Boolean
        If InStr(Application.StartupPath, ex_name, CompareMethod.Text) > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Sub SaveConfigSYSVersion()
        Try
            Dim FileDLL_ver As String = "\sys.version.dll"
            If File.Exists(Application.StartupPath & FileDLL_ver) = True Then
                File.Delete((Application.StartupPath & FileDLL_ver))
            End If
            Dim MyWriter As New StreamWriter(Application.StartupPath & FileDLL_ver, FileMode.Append)
            Dim str As String

            str = Me.version_InRoom
            MyWriter.WriteLine(str, True)
            MyWriter.Close()

        Catch ex As Exception

        End Try
    End Sub


#End Region

End Class

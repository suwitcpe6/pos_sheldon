
Imports System.IO
'Imports PublicClassUsed
Imports Newtonsoft.Json
Imports System.IO.Compression
Imports ComponentAce.Compression.Archiver
Imports ComponentAce.Compression.ZipForge
Public Class AUTO_UPDATE
    Public version_InRoom As String = "" ' System.Configuration.ConfigurationManager.AppSettings("LastUpdate").ToString

    Dim version_filename As String = "sys.version.dll"
    Dim colorBackGround As String = "Green"
    Dim filename_last_update As String = "last_update.dll"
    Dim program_update_name As String = "\Update\POS_UPDATE.exe"
    Dim sys As String = "POS"

    Dim API_SRV As String = ""
    Dim sub_link_api As New link_api

    Property mode As Update_mode

    Public Class link_api
        Public SEL_SysVersion As String = ""
        Public DownloadFiles As String = ""
        Public Checkfile_update As String = ""
    End Class
    Public Enum Update_mode
        Shared_file = 0
        API = 1
    End Enum

    Sub New(API_SRV As String, link_api As link_api, Update_mode As Update_mode, Optional sys As String = "POS")
        Me.sys = sys
        Me.API_SRV = API_SRV
        Me.sub_link_api = link_api
        Me.mode = Update_mode
        If Me.API_SRV = "" Then Throw New Exception("API_SRV not found")
        If Update_mode = Update_mode.Shared_file Then
            If Me.sub_link_api.SEL_SysVersion = "" Then Throw New Exception("SEL_SysVersion not found")
        Else
            If Me.sub_link_api.DownloadFiles = "" Then Throw New Exception("DownloadFiles not found")
            If Me.sub_link_api.Checkfile_update = "" Then Throw New Exception("Checkfile_update not found")
        End If


    End Sub

    Public Function Update() As Boolean

        If Me.mode = Update_mode.Shared_file Then
            Update_shared_file()
        Else
            Update_API()
        End If
    End Function




#Region "Auto update  shared file"
    Public Function Update_shared_file() As Boolean



        Dim Appname As String = Get_application_name() '"Blackoffice.exe"


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
        Dim verServ As String = get_File_version(pathServ & "\" & version_filename)
        Me.version_InRoom = get_File_version(Application.StartupPath & "\" & version_filename)
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
            p.StartInfo.Arguments = String.Format("""{0}"" ""{1}"" ""{2}"" ""{3}"" ""{4}""", pathServ, pathCnt, pathCnt_start, Appname, colorBackGround)
            p.StartInfo.FileName = Application.StartupPath & program_update_name
            p.Start()

            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = Appname Then
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
            Dim json2 = New MD.API(API_SRV).GETSON(sub_link_api.SEL_SysVersion & "0")
            'Dim json2 = New API(Center.Data_Config.API,).GETSON(String.Format(Center.Link_API.Get_API.SEL_TenderCL, Tender_val.Shop_id))
            ret2 = (JsonConvert.DeserializeObject(Of SysVersionModel.value)(json2))
            If ret2.Respon.Result Then

                Return ret2.Data(0).path
            Else
                If ret2.Respon.SystemErrorMessage <> "" Then
                    Throw New Exception(ret2.Respon.SystemErrorMessage.ToString)
                Else
                    Throw New Exception(ret2.Respon.ErrorMessage.ToString)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function get_File_version(ByVal _path As String) As String
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
            Dim FileDLL_ver As String = "\" & version_filename
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
#Region "Auto update API"


    Public Function Get_application_name() As String
        Dim location As String = System.Environment.GetCommandLineArgs()(0)
        Dim appName As String = System.IO.Path.GetFileName(location)
        Return appName
    End Function

    Public Function Update_API() As Boolean


        'Dim sys As String = "POS"
        Dim Appname As String = Get_application_name()
        Dim colorBackGround As String = "Green"

        Dim Tmp_update As String = Application.StartupPath & "\Tmp_update"
        Dim di As DirectoryInfo = New DirectoryInfo(Tmp_update)
        If Not di.Exists Then
            di.Create()
        End If




        Dim path_download As String = Application.StartupPath & "\download"
        Dim di_pathdownload As DirectoryInfo = New DirectoryInfo(path_download)
        If Not di_pathdownload.Exists Then
            di_pathdownload.Create()
        End If



        Dim download_file_name As String = "update_" & Appname.Replace(".exe", ".zip")
        Dim Extract_folder_name As String = path_download & "\" & Extractfolder_Name(download_file_name)
        Dim path_start As String = Application.StartupPath




        'ตรวจสอบว่าใน client มีไฟล์มั้ย
        If File.Exists(path_download & "\" & download_file_name) Then
            'ตรวจสอบ modifydate
            If checkfile(path_download, download_file_name, Extract_folder_name & "\" & version_filename) Then
                'เริ่มทำการ download
                If Not downloadfile(download_file_name, path_download) Then
                    MessageBox.Show("Update ไม่สำเร็จ ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
            End If
        Else
            'เริ่มทำการ download
            If Not downloadfile(download_file_name, path_download) Then
                MessageBox.Show("Update ไม่สำเร็จ ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        End If



        Dim verServ As String = get_File_version(Extract_folder_name & "\" & version_filename)
        Me.version_InRoom = get_File_version(Application.StartupPath & "\" & version_filename)

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

            'p.StartInfo.Arguments = String.Format("""{0}"" ""{1}"" ""{2}"" ""{3}"" ""{4}""", Extract_folder_name, Tmp_update, path_start, Appname, colorBackGround)
            p.StartInfo.Arguments = String.Format("""{0}"" ""{1}"" ""{2}"" ""{3}"" ""{4}""", Extract_folder_name, Tmp_update, "D:\test_update", Appname, colorBackGround)

            p.StartInfo.FileName = Application.StartupPath & program_update_name
            p.Start()

            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = Appname Then
                    prog.Kill()
                End If
            Next
            Return True
        Else
            Return False
        End If

    End Function
    Private Function downloadfile(filename As String, path_download As String) As Boolean


        Dim url = String.Format(sub_link_api.DownloadFiles, filename)
        Dim ret = New MD.API(Me.API_SRV).Download(url, path_download & "\" & filename)

        If Not File.Exists(path_download & "\" & filename) Then
            Return False

        Else
            MD.CL_File.Savefile_overwrite(path_download & "\" & filename_last_update, ret)
            Extractfile(path_download & "\" & filename, path_download & "\" & Extractfolder_Name(filename))
            Return True
        End If



    End Function

    Public Function checkfile(ByVal pathfile As String, ByVal filename As String, ByVal fileverServ As String) As Boolean
        Dim ret2 As New SysVersionModel.value_fileupdate
        Dim url As String = String.Format(sub_link_api.Checkfile_update, filename)
        Dim json2 = New MD.API(Me.API_SRV,).GETSON(url)
        'Dim json2 = New API(Center.Data_Config.API,).GETSON(String.Format(Center.Link_API.Get_API.SEL_TenderCL, Tender_val.Shop_id))
        ret2 = (JsonConvert.DeserializeObject(Of SysVersionModel.value_fileupdate)(json2))
        If ret2.Respon.Result Then


            'Dim filelasupdate As DateTime = System.IO.File.GetLastWriteTime(pathfile & "\" & filename)
            Dim last_update As String
            Dim data_ReadFile = MD.CL_File.ReadFile(pathfile & "\" & filename_last_update)
            If data_ReadFile = "" Then
                'ไม่พบไฟล์ สั่ง download เลย
                Return True
            Else
                last_update = data_ReadFile
            End If

            If ret2.Data <> last_update Then
                ' สั่ง update
                Return True
            ElseIf ret2.Data = last_update Then
                ' มีอยู่แล้วไม่ต้อง download ใหม่
                If Not File.Exists(fileverServ) Then
                    Extractfile(pathfile & "\" & filename, pathfile & "\" & Extractfolder_Name(filename))
                End If
                Return False
            Else
                Return True
            End If
        Else
            If ret2.Respon.SystemErrorMessage <> "" Then
                Throw New Exception(ret2.Respon.SystemErrorMessage.ToString)
            Else
                Throw New Exception(ret2.Respon.ErrorMessage.ToString)
            End If
            Return False
        End If
    End Function
    Private Function Extractfile(zipPath As String, extractPath As String)

        'Dim startPath As String = path_download
        'Dim zipPath As String = path_download & "\" & filename
        'Dim extractPath As String = path_download & "\extractPath"

        'ZipFile.CreateFromDirectory(startPath, zipPath)

        Dim di As DirectoryInfo = New DirectoryInfo(extractPath)
        If di.Exists Then
            di.Delete(True)
        End If
        '.net 4.6.1
        ZipFile.ExtractToDirectory(zipPath, extractPath)



    End Function
    Private Function Extractfolder_Name(value)
        Return value.Replace(".zip", "")
    End Function
#End Region

End Class

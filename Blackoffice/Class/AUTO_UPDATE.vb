Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
'Imports PublicClassUsed
Imports System.Management
Imports Newtonsoft.Json
Imports Control_us
Imports System.IO.Compression

Public Class AUTO_UPDATE
    Public version_InRoom As String = "" ' System.Configuration.ConfigurationManager.AppSettings("LastUpdate").ToString
    Public version As String = System.Configuration.ConfigurationManager.AppSettings("Version").ToString
    Dim sys As String = "POS"
    Dim runexe As String = "Blackoffice.exe"
    Dim version_filename As String = "sys.version.dll"
    Dim colorBackGround As String = "Green"
    Dim filename_last_update As String = "last_update.dll"
#Region "เช็ค vertion"
    Sub New()

    End Sub
    'Public Function version_CheckMRP(ByVal type As String) As Boolean





    '    Dim pathServ As String = get_pathServer(sys)
    '    If pathServ = "" Then
    '        MessageBox.Show("ไม่พบ Path File server ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Return False
    '    End If

    '    Dim pathCnt As String = Application.StartupPath & "\Tmp_update"

    '    Dim di As DirectoryInfo = New DirectoryInfo(pathCnt)
    '    If Not di.Exists Then
    '        di.Create()
    '    End If

    '    Dim pathCnt_start As String = Application.StartupPath
    '    Dim verServ As String = get_File_version(pathServ & "\sys.version.dll")
    '    Me.version_InRoom = get_File_version(Application.StartupPath & "\sys.version.dll")
    '    If Trim(verServ) = "" Then
    '        Return False
    '    End If
    '    If Trim(verServ) <> Trim(Me.version_InRoom) Then

    '        For Each fi As IO.FileInfo In di.GetFiles("*", SearchOption.AllDirectories)
    '            Dim fileNameOnly As String = fi.Name
    '            Dim createDate As Date = fi.CreationTime.Date
    '            fi.Delete()
    '        Next

    '        Dim p As New Process
    '        p.StartInfo.Arguments = String.Format("""{0}"" ""{1}"" ""{2}"" ""{3}"" ""{4}""", pathServ, pathCnt, pathCnt_start, runexe, colorBackGround)
    '        p.StartInfo.FileName = Application.StartupPath & "\Update\POS_UPDATE.exe"
    '        p.Start()

    '        For Each prog As Process In Process.GetProcesses
    '            If prog.ProcessName = "TouchPOS" Then
    '                prog.Kill()
    '            End If
    '        Next
    '        Return True
    '    Else
    '        Return False
    '    End If

    'End Function



    Public Function get_pathServer(ByVal sys As String) As String
        Try
            Dim ret2 As New SysVersionModel.value
            Dim json2 = New MD.API(Center.Data_Config.API_SRV,).GETSON(Center.Get_API.SEL_SysVersion & "0")
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

    Public Function version_Check(ByVal type As String) As Boolean


        Dim sys As String = "POS"
        Dim Appname As String = Get_application_name()
        Dim colorBackGround As String = "Green"


        'Dim pathServ As String = get_pathServer(sys)
        'If pathServ = "" Then
        '    MessageBox.Show("ไม่พบ Path File server ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return False
        'End If

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

            'D:\SOR\Shell_don\TouchPOS\Blackoffice\bin\Debug\download\Blackoffice
            'D:\SOR\Shell_don\TouchPOS\Blackoffice\bin\Debug\Tmp_update
            'D:\test_update
            'Blackoffice.exe
            'Green
            'p.StartInfo.Arguments = String.Format("""{0}"" ""{1}"" ""{2}"" ""{3}"" ""{4}""", Extract_folder_name, Tmp_update, path_start, Appname, colorBackGround)
            p.StartInfo.Arguments = String.Format("""{0}"" ""{1}"" ""{2}"" ""{3}"" ""{4}""", Extract_folder_name, Tmp_update, "D:\test_update", Appname, colorBackGround)

            p.StartInfo.FileName = Application.StartupPath & "\Update\POS_UPDATE.exe"
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


        Dim url = String.Format(Center.Get_API.DownloadFiles, filename)
        Dim ret = New MD.API(Center.Data_Config.API_SRV,).Download(url, path_download & "\" & filename)

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
        Dim url As String = String.Format(Center.Get_API.Checkfile_update, filename)
        Dim json2 = New MD.API(Center.Data_Config.API_SRV,).GETSON(url)
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

        ZipFile.ExtractToDirectory(zipPath, extractPath)

    End Function
    Private Function Extractfolder_Name(value)
        Return value.Replace(".zip", "")
    End Function
#End Region

End Class

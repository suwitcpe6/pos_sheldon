
Imports System.IO
Public Class CL_File
    Public Shared Function Save_file(Path_DES As String, file_source As String, file_des As String) As Boolean

        If file_source = "" And file_des = "" Then Throw New Exception("ไม่พบพาร์ทไฟล์")
        'สร้างของตัวเองใหม่
        Dim di As DirectoryInfo = New DirectoryInfo(Path_DES)
        If Not di.Exists Then
            di.Create()
        End If

        'For Each Item As clData.CE_RECEIVE_D In CE_RECEIVE_D
        'If Item.ATTACH_FILE_PATH_Local <> "" Then
        My.Computer.FileSystem.CopyFile(file_source, file_des, overwrite:=True)
        'End If
        'If Item.ATTACH_IMG_PATH_local <> "" Then
        '    My.Computer.FileSystem.CopyFile(Item.ATTACH_IMG_PATH_local, Item.ATTACH_IMG_PATH, overwrite:=True)
        'End If

        'Next
        'End If
        Return True

    End Function

    Public Shared Sub Savefile_overwrite(path_file As String, data As String)
        If File.Exists(path_file) = True Then
            File.Delete((path_file))
        End If
        Dim MyWriter As New StreamWriter(path_file, FileMode.Append)
        Dim str As String
        MyWriter.WriteLine(data, True)
        MyWriter.Close()

    End Sub
    Public Shared Function ReadFile(ByVal _path As String) As String
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
            Else
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function



End Class

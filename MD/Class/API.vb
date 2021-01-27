Imports System.IO
Imports System.Net
Imports System.Reflection
Imports Newtonsoft.Json

Public Class API
    Dim Timeout As Integer = 0 '(1000 * 60) * 5
    Dim Link_srv As String = ""
    Sub New(Link As String, Optional ByVal val As Integer = 30)
        Me.Link_srv = Link
        Timeout = (1000) * val
    End Sub
    Public Enum set_Timeout

        Min_1 = 60
        Min_2 = 120
        Min_5 = 300
        Min_10 = 600



    End Enum
    Public Function GETSON(ByRef geturl As String, Optional API As String = "") As String
        Dim dt As New DataTable
        Dim jsonURL As String
        If API = "" Then
            jsonURL = Me.Link_srv + geturl
        Else
            jsonURL = API + geturl
        End If
        'Dim jsonURL As String = Center.Data_Config.API + geturl
        Dim reader As StreamReader
        Dim errorMsg As String = Nothing

        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create(jsonURL), HttpWebRequest)
            request.ReadWriteTimeout = Timeout
            request.Timeout = Timeout
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim jsonStr As String = reader.ReadToEnd()
            Return jsonStr
        Catch ex As WebException

            If ex.Response IsNot Nothing Then
                If ex.Response.ContentLength <> 0 Then
                    Using stream As IO.Stream = ex.Response.GetResponseStream()
                        Using reader2 As IO.StreamReader = New IO.StreamReader(stream)
                            Dim jsonResponse = reader2.ReadToEnd()
                            ' Return jsonResponse  convert to model ไม่ได้
                            Throw New Exception(jsonResponse)
                        End Using
                    End Using
                Else
                    'Throw ex
                    Return Nothing
                End If
            Else
                If ex.Message = "Unable to connect to the remote server" Then
                    Throw New Exception("เชื่อมต่อ API ไม่สำเร็จ")
                Else
                    Return Nothing    'ตอนขึ้น error เดาสาเหตุไม่ได้
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function Download(ByRef geturl As String, PathDes As String, Optional API As String = "") As String
        Dim jsonURL As String
        If API = "" Then
            jsonURL = Me.Link_srv + geturl
        Else
            jsonURL = API + geturl
        End If

        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(jsonURL), HttpWebRequest)
            request.ReadWriteTimeout = Timeout
            request.Timeout = Timeout
            request.AllowAutoRedirect = True


            Dim response As HttpWebResponse = Nothing
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            If response.StatusDescription = "NoUpdate" Then
                Throw New Exception("")
            End If

            Dim reader As Stream = response.GetResponseStream()


            'Write to disk
            Dim fs As New FileStream(PathDes, FileMode.Create)
            reader.CopyTo(fs)
            'Dim read_buff As Byte() = New Byte(255) {}
            'Dim count As Integer = reader.Read(read_buff, 0, read_buff.Length)
            'While count > 0
            '    fs.Write(read_buff, 0, count)
            '    count = reader.Read(read_buff, 0, read_buff.Length)
            'End While




            response.Close()
            fs.Close()
            reader.Close()

            Return response.StatusDescription

        Catch ex As Exception

            Throw ex
        End Try
    End Function
    Public Function ToDataTable(Of T)(ByVal items As List(Of T)) As DataTable
        Try

            Dim dataTable As DataTable = New DataTable(GetType(T).Name)
            Dim Props As PropertyInfo() = GetType(T).GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)

            For Each prop As PropertyInfo In Props
                dataTable.Columns.Add(prop.Name, prop.PropertyType)
            Next

            For Each item As T In items
                Dim values = New Object(Props.Length - 1) {}

                For i As Integer = 0 To Props.Length - 1
                    values(i) = IIf(IsDBNull(Props(i).GetValue(item, Nothing)), "", Props(i).GetValue(item, Nothing))
                Next

                dataTable.Rows.Add(values)
            Next

            Return dataTable
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function POSTResponse(uri As Uri, data As String, method As String, Optional token As String = "") As String
        Try

            ' Create a request for the URL. 
            Dim request As WebRequest = WebRequest.Create(uri)
            request.Method = method
            request.ContentType = "application/json"
            request.Timeout = Timeout

            If token <> "" Then
                request.Headers.Add("Authorization", token)
            End If

            If method = "POST" Then
                Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(data)
                Dim dataStreamPost As Stream = request.GetRequestStream()
                dataStreamPost.Write(byteArray, 0, byteArray.Length)
                dataStreamPost.Close()
            End If

            Dim res As WebResponse = request.GetResponse()
            Dim stream As Stream = res.GetResponseStream()
            Dim streamReader As New StreamReader(stream)
            Dim Str = streamReader.ReadToEnd

            Return Str
        Catch ex As WebException

            If ex.Response IsNot Nothing Then
                If ex.Response.ContentLength <> 0 Then
                    Using stream As IO.Stream = ex.Response.GetResponseStream()
                        Using reader2 As IO.StreamReader = New IO.StreamReader(stream)
                            Dim jsonResponse = reader2.ReadToEnd()
                            ' Return jsonResponse  convert to model ไม่ได้
                            Throw New Exception(jsonResponse)
                        End Using
                    End Using
                Else
                    'Throw ex
                    Return Nothing
                End If
            Else
                Return Nothing
                'Throw ex
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function POSTResponse(link As String, data As String, method As String, Optional token As String = "") As String
        Try

            ' Create a request for the URL. 
            Dim Uri As New Uri(Link_srv & link)

            Dim request As WebRequest = WebRequest.Create(Uri)
            request.Method = method
            request.ContentType = "application/json"
            request.Timeout = Timeout

            If token <> "" Then
                request.Headers.Add("Authorization", token)
            End If

            If method = "POST" Then
                Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(data)
                Dim dataStreamPost As Stream = request.GetRequestStream()
                dataStreamPost.Write(byteArray, 0, byteArray.Length)
                dataStreamPost.Close()
            ElseIf method = "DELETE" Then
                Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(data)
                Dim dataStreamPost As Stream = request.GetRequestStream()
                dataStreamPost.Write(byteArray, 0, byteArray.Length)
                dataStreamPost.Close()
            End If

            Dim res As WebResponse = request.GetResponse()
            Dim stream As Stream = res.GetResponseStream()
            Dim streamReader As New StreamReader(stream)
            Dim Str = streamReader.ReadToEnd

            Return Str

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function pingHost(host)
        'If My.Computer.Network.Ping(host, 2000) Then
        Return True
        '    Else
        '        Return False
        '    End If
    End Function

End Class

'Public Shared DataTableAlm As DataTable

Public Class Convert_Data
    Public Function ToDataTable(Of T)(ByVal items As List(Of T)) As DataTable
        Try
            Dim dataTable As DataTable = New DataTable(GetType(T).Name)
            Dim Props As PropertyInfo() = GetType(T).GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)

            For Each prop As PropertyInfo In Props
                dataTable.Columns.Add(prop.Name, prop.PropertyType)
            Next

            For Each item As T In items
                'Dim values = New Object(Props.Length - 1) {}
                Dim drow As DataRow
                drow = dataTable.NewRow
                For i As Integer = 0 To Props.Length - 1
                    'values(i) = IIf(IsDBNull(Props(i).GetValue(item, Nothing)), "", Props(i).GetValue(item, Nothing))
                    drow(i) = IIf(IsDBNull(Props(i).GetValue(item, Nothing)), "", Props(i).GetValue(item, Nothing))
                Next

                'dataTable.Rows.Add(values)
                dataTable.Rows.Add(drow)
            Next

            Return dataTable
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class


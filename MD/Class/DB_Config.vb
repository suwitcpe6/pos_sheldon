Public Class DB_Config
    Public Shared con_DB1 As New Connect
    '    Public Shared con_DB1 As New Connect With {
    '    .strConn = "Data Source=BCISERVER\MSSQLSERVER2012;Database=FAO;User Id=SA;Password=P@SSW0RD",
    '    .Timeout = 600,
    '    .iso = IsolationLevel.ReadCommitted
    '}
    Public Structure Connect
        Public strConn As String
        Public Timeout As String
        Public severname As String
        Public databasename As String
        Public LockTypeconfig As String
        Public iso As IsolationLevel
    End Structure
    Public Shared Sub Setconstr(StrInput() As String)
        con_DB1.strConn = "server =" & StrInput(1).ToString() & ";initial catalog=" & StrInput(2).ToString() & ";user id=" & StrInput(3).ToString() & ";pwd=" & StrInput(4).ToString & ";Max Pool Size=4000;Connect Timeout=30;"
        con_DB1.severname = StrInput(1).ToString()
        con_DB1.databasename = StrInput(2).ToString()
        con_DB1.LockTypeconfig = StrInput(5).ToString()
        con_DB1.Timeout = 600
        con_DB1.iso = IsolationLevel.ReadCommitted
    End Sub


    Public Shared Function get_config(ByVal profilename As String, ByVal filename As String) As String()
        Try

            Dim sFileName As String = Application.StartupPath & "\" & filename
            Dim srFileReader As System.IO.StreamReader = System.IO.File.OpenText(sFileName)
            Dim sInputLine As String
            Dim StrInput() As String
            sInputLine = srFileReader.ReadLine()
            Do Until sInputLine Is Nothing
                StrInput = sInputLine.Split("|")
                If StrInput(0).ToString() = profilename Then
                    Setconstr(StrInput)
                    'con_DB1.strConn = "server =" & StrInput(1).ToString() & ";initial catalog=" & StrInput(2).ToString() & ";user id=" & StrInput(3).ToString() & ";pwd=" & StrInput(4).ToString & ";Max Pool Size=4000;Connect Timeout=30;"
                    'con_DB1.severname = StrInput(1).ToString()
                    'con_DB1.databasename = StrInput(2).ToString()
                    'con_DB1.LockTypeconfig = StrInput(5).ToString()

                    srFileReader.Close()
                    srFileReader = Nothing
                    'Return True
                    Return StrInput
                End If
                sInputLine = srFileReader.ReadLine()
            Loop
            srFileReader.Close()
        Catch ex As Exception
            'Return False
            'MessageBox.Show(ex.Message, Cl_massage.error_massage.err, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw ex
            Return Nothing
        End Try
        Return Nothing

    End Function
End Class

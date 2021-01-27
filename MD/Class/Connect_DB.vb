'Imports MD
Imports System.Data.SqlClient
Public Class Connect_DB
    Dim Conn As SqlClient.SqlConnection = New SqlClient.SqlConnection
    Public tr As SqlTransaction
    Dim comm As SqlCommand
    Dim Timeout As Integer = 600
    Public Property value As String
    Public config_DB As New DB_Config.Connect

#Region "ReadData"
    Sub New(ByVal val As DB_Config.Connect)
        config_DB = val
    End Sub
    Public Function ReadData(ByVal sql As String, Optional ByVal strcon_ As String = "") As Object
        ' ใช้กับ select
        If strcon_ <> "" Then config_DB.strConn = strcon_
        Dim ds As New DataSet
        Dim da As SqlClient.SqlDataAdapter
        Dim Conn1 As SqlClient.SqlConnection = New SqlClient.SqlConnection
        Try

            With Conn1
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = config_DB.strConn
                .Open()
            End With

            ds.Clear()
            da = New SqlClient.SqlDataAdapter(sql, Conn1)
            da.SelectCommand.CommandTimeout = Timeout
            da.Fill(ds, "S")

            If Conn1.State = ConnectionState.Open Then Conn1.Close()
            If ds.Tables.Count = 1 Then
                Return ds.Tables(0)
            ElseIf ds.Tables.Count > 1 Then
                Return ds
            End If
            Return Nothing
        Catch ex As Exception
            Throw ex
        Finally
            Conn1.Close()
        End Try

    End Function

#End Region

#Region "excute"
    Public Function setidentity(ByVal name As String, ByVal value As Boolean) As String
        If value Then
            Return (" SET IDENTITY_INSERT " & name & " on ")
        Else
            Return (" SET IDENTITY_INSERT " & name & " off ")
        End If

    End Function

    Public Function Executecommit(query As String, Optional ByVal strcon_ As String = "") As Boolean

        '' ใช้ insert ชุดเดียว
        'If InStr(query, "IDENTITY_INSERT") = 0 Then
        '    ''ผู้ออกแบบกำหนดให้รันออโต้จากโปรแกรมเท่านั้น ตอนแก้ข้อมูลจะได้ไม่เป็นปัญหา
        '    Throw New Exception("ไม่ได้กำหนด IDENTITY_INSERT")
        'End If
        If strcon_ <> "" Then config_DB.strConn = strcon_
        Dim Conn1 As SqlClient.SqlConnection = New SqlClient.SqlConnection
        With Conn1
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = config_DB.strConn
            .Open()
        End With
        tr = Conn1.BeginTransaction(IsolationLevel.ReadCommitted, "a1")
        Try
            Dim comm As New SqlCommand
            With comm
                .Connection = Conn1
                .CommandType = CommandType.Text
                .CommandText = query
                .Transaction = tr
                value = .ExecuteScalar()
            End With
            tr.Commit()
            If Conn1.State = ConnectionState.Open Then Conn1.Close()
            Return True
        Catch ex As Exception
            tr.Rollback()
            If Conn1.State = ConnectionState.Open Then Conn1.Close()
            'MessageBox.Show(Message.ERR_EX + " : " + ex.Message, Message.AlertEnterNoDataHeader, MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Throw ex
        End Try

    End Function


    Public Function Execute(query As String, ByRef ParamList As List(Of SqlParameter), ByRef SQLConn As SqlConnection, ByRef SQLTran As SqlTransaction) As Boolean
        'ส่ง connecttion เข้ามา      
        Try
            Dim comm As New SqlCommand
            With comm
                .Connection = SQLConn
                .CommandType = CommandType.Text
                If ParamList IsNot Nothing Then .Parameters.AddRange(ParamList.ToArray)
                .CommandText = query
                .Transaction = SQLTran
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    'Public Function Execute(query As String, ByRef ParamList As List(Of SqlParameter), ByRef sqlCon As SqlConnection, ByRef sqlTran As SqlTransaction) As Boolean

    '    Try
    '        Dim comm As New SqlCommand
    '        With comm
    '            .Connection = sqlCon
    '            .CommandType = CommandType.Text
    '            .CommandText = query
    '            .Transaction = sqlTran
    '            .ExecuteNonQuery()
    '            .Parameters.AddRange(ParamList.ToArray)
    '        End With
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '        Return False
    '    End Try
    'End Function


#End Region

End Class

Public Class CL_LibLoading
    Public Shared Function LoadAssembly(ByVal Lib_Name As String, ByVal AssemblyName As String) As Object
        Dim NewPlugIn As Object = Nothing
        Try
            Dim PlugInAssembly As Reflection.Assembly
            PlugInAssembly = Reflection.Assembly.Load(Lib_Name)

            For Each PlugInType As Type In PlugInAssembly.GetTypes
                If PlugInType.Name = AssemblyName Then
                    NewPlugIn = PlugInAssembly.CreateInstance(PlugInType.FullName)
                End If
            Next
            Return NewPlugIn
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

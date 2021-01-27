Imports System.Runtime.InteropServices
Public Class Memory
    Public Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer

    Public Shared Sub FlushMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                Dim pch As IntPtr
                pch = Process.GetCurrentProcess().Handle
                SetProcessWorkingSetSize(pch, Process.GetCurrentProcess().MinWorkingSet, Process.GetCurrentProcess().MaxWorkingSet)
                Dim mypcs As Process() = Process.GetProcessesByName("MasterPlaning")
                Dim mypc As Process
                For Each mypcs1 As Process In mypcs
                    SetProcessWorkingSetSize(mypcs1.Handle, mypcs1.MinWorkingSet, mypcs1.MaxWorkingSet)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class

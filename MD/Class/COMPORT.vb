'Imports System.IO.Ports
Imports System.IO
Public Class COMPORT
    Public Function Set_SP_Value(ByRef serialport As Ports.SerialPort, PortName As String) As Boolean
        Try
            If PortName <> "" Then
                If serialport.IsOpen Then
                    serialport.Close()
                End If
                serialport.PortName = PortName
                serialport.BaudRate = "9600"
                serialport.Parity = Ports.Parity.None
                serialport.DataBits = 8
                serialport.StopBits = 1

                serialport.Open()
                Return True
            End If
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    Public Function Print(val1 As String, val2 As String, ByRef serialport As Ports.SerialPort, PortName As String)
        Try
            If Set_SP_Value(serialport, PortName) Then
                serialport.Write(Convert.ToString(Chr(12)))
                serialport.WriteLine(val1 & Chr(13))
                serialport.WriteLine(val2)
                serialport.Close()
            End If
        Catch ex As Exception
            Throw ex
        Finally

        End Try



    End Function
End Class

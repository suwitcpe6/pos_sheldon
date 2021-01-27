Imports MD
Public Class CL_GP
    Public data As New G_data
    Public Class G_data

        Public GP As Double
        Public GPAMOUNT As Double
        Public BTNGPRULE As String
        Public BTNPRICE As Double
        Public IN_Time As Boolean = False
    End Class
    Public Function Call_GP(drow As DataRow) As Boolean
        Try


            If Center.data_profile.GP_FLAG = 2 Then
                If drow("happyhour_id") = 0 Then
                    std_GP(drow("BTNPRICE"), drow("BTNGPRULE"))
                    data.BTNPRICE = drow("BTNPRICE")
                    Return True
                End If

                Dim curtime As DateTime = Center.date_now.ToString("HH:mm")
                Dim timestart As DateTime = drow("timestart") '.ToString("hh:mm")
                Dim timeend As DateTime = drow("timeend") '.ToString("hh:mm")
                If curtime >= timestart And curtime <= timeend Then
                    data.IN_Time = True
                    If drow("btnflg") = "1" Then
A:
                        data.GP = CDbl(drow("BTNGP"))
                        data.GPAMOUNT = Math.Round((CDbl(drow("BTNPRICE")) * CDbl(drow("BTNGP"))) / 100, 3, MidpointRounding.AwayFromZero)
                        data.BTNGPRULE = drow("BTNGPRULE")
                        data.BTNPRICE = CDbl(drow("BTNPRICE"))
                    ElseIf drow("btnflg") = "2" Then
                        data.GP = CDbl(drow("BTNGP2"))
                        data.GPAMOUNT = Math.Round((CDbl(drow("BTNPRICE2")) * CDbl(drow("BTNGP2"))) / 100, 3, MidpointRounding.AwayFromZero)
                        data.BTNGPRULE = drow("BTNGPRULE2")
                        data.BTNPRICE = CDbl(drow("BTNPRICE2"))
                    Else
                        GoTo A
                    End If

                Else
                    'data.IN_Time = False
                    GoTo A
                End If
            Else
                std_GP(drow("BTNPRICE"), drow("BTNGPRULE"))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Call_GP_Price(drow As DataRow) As Double

        If Center.data_profile.GP_FLAG = 2 Then

            If drow("happyhour_id") = 0 Then
                Return drow("BTNPRICE")
            End If

            Dim curtime As DateTime = Center.date_now.ToString("HH:mm")
            Dim timestart As DateTime = drow("timestart") '.ToString("hh:mm")
            Dim timeend As DateTime = drow("timeend") '.ToString("hh:mm")
            If curtime >= timestart And curtime <= timeend Then

                If drow("btnflg") = "1" Then
                    Return drow("BTNPRICE")
                ElseIf drow("btnflg") = "2" Then
                    Return drow("BTNPRICE2")
                Else
                    Return drow("BTNPRICE")
                End If
            Else
                Return drow("BTNPRICE")
            End If
        Else
            Return drow("BTNPRICE")
        End If



    End Function

    Public Function UI_Reset(drow As DataRow) As Boolean

        If drow("happyhour_id") = 0 Then
            Return False
        End If

        Dim curtime As DateTime = Center.date_now.ToString("HH:mm")
        Dim timestart As DateTime = drow("timestart") '.ToString("hh:mm")
        Dim timeend As DateTime = drow("timeend") '.ToString("hh:mm")
        If curtime >= timestart And curtime <= timeend Then
            Return True
        Else
            Return False
        End If


    End Function
    Public Function UI_Reset2(drow As DataRow) As Boolean

        If drow("happyhour_id") = 0 Then
            Return False
        End If

        Dim curtime As DateTime = Center.date_now.ToString("HH:mm")
        Dim timestart As DateTime = drow("timestart") '.ToString("hh:mm")
        Dim timeend As DateTime = drow("timeend") '.ToString("hh:mm")
        If curtime > timeend Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Sub std_GP(BTNPRICE As Double, BTNGPRULE As String)
        data.GP = Center.data_profile.GP
        data.BTNPRICE = BTNPRICE
        data.BTNGPRULE = BTNGPRULE
        data.GPAMOUNT = Math.Round((BTNPRICE * Center.data_profile.GP) / 100, 3, MidpointRounding.AwayFromZero)
    End Sub

End Class


Imports MD

Public Class CL_PrintDocument
    'Inherits Printing.PrintDocument
    Property print_value As New print_model
    Dim PrintDialog1 As New PrintDialog
    Dim PrintDocument1 As New Printing.PrintDocument

    Sub New(ByVal print_value As print_model)
        Me.print_value = print_value
    End Sub
    Public Class print_model
        Public workdate As String
        Public multicard As Boolean
        Public docno As String
        Public shopname As String
        Public dataslip As List(Of SALE_Models.slipModel)
        Public dayend_Model As List(Of SALE_Models.dayend_Model)
    End Class
    Public Function DefaultPrinterName() As String


        Dim oPS As New System.Drawing.Printing.PrinterSettings

        'Dim oPS2 As New System.Drawing.Printing.PrinterSettings
        Try
            Dim PrinterName As String = ""
            PrinterName = oPS.PrinterName


            If PrinterName = "" Then
                Throw New Exception("ไม่การตั้งค่าปริ้น")
            End If
            Return PrinterName
        Catch ex As System.Exception
            Throw ex
        Finally
            oPS = Nothing
        End Try
    End Function
    Public Sub Print_to_printter(ByVal Ptinttype As String)
        Try


            Dim ss As New F_payment(Nothing)
            'AddHandler PrintDocument1.PrintPage, AddressOf R880NP_PrintPage_INV
            If Ptinttype = "dayend" Then
                AddHandler PrintDocument1.PrintPage, AddressOf R880NP_PrintPage_Rpt_dayend
            ElseIf Ptinttype = "CN" Then
                AddHandler PrintDocument1.PrintPage, AddressOf R880NP_PrintPage_CN
            Else
                'If Center.SYS_Config.WALLET_TYPE = CL_constan.WALLET_TYPE.APIHUBCPN Then

                '    If print_value.dataslip(0).CARDTENDOR = ss.btn_narmal.Tag Then
                '        AddHandler PrintDocument1.PrintPage, AddressOf R880NP_PrintPage
                '    Else
                '        '' INV
                '        AddHandler PrintDocument1.PrintPage, AddressOf R880NP_PrintPage_INV
                '    End If

                'Else
                If print_value.dataslip(0).CARDTENDOR = ss.btn_narmal.Tag Then
                    AddHandler PrintDocument1.PrintPage, AddressOf R880NP_PrintPage
                Else
                    '' INV
                    AddHandler PrintDocument1.PrintPage, AddressOf R880NP_PrintPage_INV
                End If
            End If
            'End If


            Dim strPrinterName As String = DefaultPrinterName()
            PrintDialog1.Document = PrintDocument1
            PrintDialog1.PrinterSettings.PrinterName = strPrinterName

            PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
            PrintDialog1.AllowSomePages = True


            If Not PrintDocument1.PrinterSettings.IsValid Then
                Throw New Exception("ขาดการเชื่อมต่อปริ้นเตอร์ กรุณาตรวจสอบ")

                'Dim WsNetwork As Object
                'WsNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
                'WsNetwork.SetDefaultPrinter()
                'PrintDialog1.PrinterSettings.PrinterName = strPrinterName
            End If




            PrintDocument1.Print()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub R880NP_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Try
            Dim dt As New DataTable
            dt = New API(Center.Data_Config.API,).ToDataTable(Of SALE_Models.slipModel)(print_value.dataslip)
            Dim x As Integer = 10
            Dim y As Integer = 0
            Dim max_pixel As Integer = 250

            Dim PrintFont As New Font("Angsana NEW", 12)
            Dim PrintFont1 As New Font("Angsana NEW", 12)
            Dim PrintFont2 As New Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))

            Dim PrintColor As New SolidBrush(Color.Black)
            Dim PrintPosition As New PointF
            PrintPosition = New PointF(0, 0)
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Far

            'e.Graphics.DrawString("", PrintFont1, PrintColor, PrintPosition)
            'y += 0
            PrintPosition = New PointF(x + 70, y)
            e.Graphics.DrawString("ใบบันทึกรายการ", PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString(" เลขที่ " & Me.print_value.docno, PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString(" ชื่อร้าน " & Me.print_value.shopname, PrintFont, PrintColor, PrintPosition)

            Pnewline(y, 20)
            PrintPosition = New PointF(x, y - 10)
            e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 8)
            PrintPosition = New PointF(x, y - 10)

            Dim qty_totel As Int16 = 0
            Dim Amount As Double = 0

            'If print_value.multicard Then



            PrintPosition = New PointF(10, y)


            If Center.SYS_Config.CUSGROUP = CL_constan.CUSGROUP.ATR Then

                For Each val As SALE_Models.slipModel In print_value.dataslip
                    'PrintPosition = New PointF(10, y)
                    'e.Graphics.DrawString(val("SEQ"), PrintFont, PrintColor, PrintPosition)
                    PrintPosition = New PointF(x, y)
                    e.Graphics.DrawString(val.FOODNAME, PrintFont, PrintColor, PrintPosition)
                    PrintPosition = New PointF(x + max_pixel, y)
                    e.Graphics.DrawString(CDbl(val.MRTAMOUNT).ToString("#,##0.00") & "  บาท", PrintFont, PrintColor, PrintPosition, format)
                    Pnewline(y, 20)
                    qty_totel += 1
                    Amount += val.MRTAMOUNT
                Next

                y = y - 10
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)

                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("จำนวน " & qty_totel & " รายการ", PrintFont, PrintColor, PrintPosition)

                PrintPosition = New PointF(x + max_pixel, y)
                e.Graphics.DrawString("มูลค่ารวม " & Amount.ToString("#,##0.00") & " บาท", PrintFont, PrintColor, PrintPosition, format)
                Pnewline(y, 20)
            Else
                e.Graphics.DrawString("อาหารเครื่องดื่ม ", PrintFont, PrintColor, PrintPosition)
                PrintPosition = New PointF(x + max_pixel, y)
                'Dim MRTAMOUNT As Double = 0
                'For Each val As CARDTRANS_Models.slipModel In print_value.dataslip
                '    MRTAMOUNT = val.MRTAMOUNT
                'Next
                Dim MRTAMOUNT As Double = dt.Compute(" sum(MRTAMOUNT)", "")
                qty_totel = dt.Compute(" sum(QTY)", "")
                e.Graphics.DrawString(CDbl(MRTAMOUNT).ToString("#,##0.00") & "  บาท", PrintFont, PrintColor, PrintPosition, format)
                Pnewline(y, 20)

                Amount = MRTAMOUNT

                y = y - 10
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)
                Pnewline(y, 20)
            End If
            ''Pnewline(y)



            'Pnewline(y, 20)
            PrintPosition = New PointF(10, y)
            e.Graphics.DrawString(New CL_date().Condate(print_value.dataslip(0).LUPDATE, "dd/MM/yyyy HH:mm:ss", "TH") & "  " & print_value.dataslip(0).BARCODE, PrintFont, PrintColor, PrintPosition)
            Dim f As New F_payment(Nothing)
            Dim paytype As String = f.btn_narmal.Tag
            'If print_value.dataslip(0).CARDTENDOR = paytype Then
            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString(" บัตรใช้งานได้ถึงวันที่ " & New CL_date().Condate(print_value.dataslip(0).CEXPIRED.Date, "dd/MM/yyyy", "TH"), PrintFont, PrintColor, PrintPosition)

            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString(" มูลค่าบัตรคงเหลือ ", PrintFont, PrintColor, PrintPosition)
            PrintPosition = New PointF(x + max_pixel, y)
            e.Graphics.DrawString(CDbl(print_value.dataslip(0).CBALANCE).ToString("#,##0.00") & " บาท ", PrintFont, PrintColor, PrintPosition, format)
            'Else
            '    Pnewline(y, 20)
            '    PrintPosition = New PointF(x, y)
            '    e.Graphics.DrawString(" *** ชำระด้วยบัตร " & print_value.dataslip(0).CARDTENDOR & " ***", PrintFont, PrintColor, PrintPosition)
            '    'PrintPosition = New PointF(x + max_pixel, y)
            '    'e.Graphics.DrawString(CDbl(print_value.dataslip(0).CBALANCE).ToString("#,##0.00") & " บาท ", PrintFont, PrintColor, PrintPosition, format)
            'End If


            If print_value.multicard Then
                'dt_paroduct.Clear()
                Pnewline(y, 15)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("____________________________________", PrintFont, PrintColor, PrintPosition)

                Pnewline(y, 15)
                PrintPosition = New PointF(x + 40, y)
                e.Graphics.DrawString("รายละเอียดการชำระเงิน", PrintFont, PrintColor, PrintPosition)

                Pnewline(y, 20)
                PrintPosition = New PointF(x + (max_pixel - 60), y)
                e.Graphics.DrawString("มูลค่าเดิม", PrintFont, PrintColor, PrintPosition, format)
                PrintPosition = New PointF(x + max_pixel, y)
                e.Graphics.DrawString("คงเหลือ ", PrintFont, PrintColor, PrintPosition, format)


                Pnewline(y, 8)
                PrintPosition = New PointF(x, y - 10)

                Dim col() As String = {"BARCODE", "OLD_BALANCE", "CBALANCE"}
                Dim dt_barcode As DataTable = dt.DefaultView.ToTable(True, col)
                Pnewline(y, 8)
                PrintPosition = New PointF(x, y - 10)
                For Each val As DataRow In dt_barcode.Rows



                    PrintPosition = New PointF(x, y)
                    e.Graphics.DrawString(val("BARCODE"), PrintFont, PrintColor, PrintPosition)
                    PrintPosition = New PointF(x + (max_pixel - 60), y)
                    e.Graphics.DrawString(CDbl(val("OLD_BALANCE")).ToString("#,##0.00"), PrintFont, PrintColor, PrintPosition, format)
                    PrintPosition = New PointF(x + max_pixel, y)
                    e.Graphics.DrawString(CDbl(val("CBALANCE")).ToString("#,##0.00"), PrintFont, PrintColor, PrintPosition, format)


                    Pnewline(y, 20)

                Next

            End If

        Catch ex As Exception
            Throw ex
        Finally
            print_value.dataslip = Nothing
        End Try
    End Sub
    Private Sub R880NP_PrintPage_INV(sender As Object, e As Printing.PrintPageEventArgs)
        Try
            Dim dt As New DataTable
            dt = New API(Center.Data_Config.API,).ToDataTable(Of SALE_Models.slipModel)(print_value.dataslip)


            Dim x As Integer = 10
            Dim y As Integer = 0
            Dim max_pixel As Integer = 250

            Dim PrintFont As New Font("Angsana NEW", 12)
            Dim PrintFont1 As New Font("Angsana NEW", 12)
            Dim PrintFont2 As New Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))

            Dim PrintColor As New SolidBrush(Color.Black)
            Dim PrintPosition As New PointF
            PrintPosition = New PointF(0, 0)
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Far

            Dim format_center As New StringFormat
            format_center.Alignment = StringAlignment.Center

            'e.Graphics.DrawString("", PrintFont1, PrintColor, PrintPosition)
            'y += 0
            PrintPosition = New PointF(x + 30, y)
            e.Graphics.DrawString(print_value.dataslip(0).COMPNAME, PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 20)

            PrintPosition = New PointF(x + 60, y)
            e.Graphics.DrawString(print_value.dataslip(0).COMPNAME_remark, PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 20)


            If print_value.dataslip(0).CARDTENDOR = "TRUEEDC" Then
                PrintPosition = New PointF(x + 70, y)
                e.Graphics.DrawString("ใบบันทึกรายการ", PrintFont, PrintColor, PrintPosition)

            Else
                PrintPosition = New PointF(x + 27, y)
                e.Graphics.DrawString("ใบเสร็จรับเงิน/ใบกำกับภาษีอย่างย่อ", PrintFont, PrintColor, PrintPosition)
                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("(VAT INCLUDED)", PrintFont, PrintColor, PrintPosition)

                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("TAXID  " & Center.data_profile.TERMINAL_TTAXID, PrintFont, PrintColor, PrintPosition)
            End If




            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("POS# " & Center.data_profile.POSID, PrintFont, PrintColor, PrintPosition)
            If print_value.dataslip(0).CARDTENDOR = "TRUEEDC" Then
            Else
                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("TAX INV : " & print_value.dataslip(0).TAXINVOICE, PrintFont, PrintColor, PrintPosition)
            End If


            'Pnewline(y, 20)
            'PrintPosition = New PointF(x, y)
            'e.Graphics.DrawString(" เลขที่ " & Me.print_value.docno, PrintFont, PrintColor, PrintPosition)

            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString(" ชื่อร้าน " & Me.print_value.shopname, PrintFont, PrintColor, PrintPosition)

            Pnewline(y, 20)
            PrintPosition = New PointF(x, y - 10)
            e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 8)
            PrintPosition = New PointF(x, y - 10)

            Dim qty_totel As Int16 = 0
            Dim Amount As Double = 0

            'If print_value.multicard Then



            PrintPosition = New PointF(10, y)
            e.Graphics.DrawString("อาหารเครื่องดื่ม ", PrintFont, PrintColor, PrintPosition)
            PrintPosition = New PointF(x + max_pixel, y)
            'Dim MRTAMOUNT As Double = 0
            'For Each val As CARDTRANS_Models.slipModel In print_value.dataslip
            '    MRTAMOUNT = val.MRTAMOUNT
            'Next

            Dim MRTAMOUNT As Double = dt.Compute(" sum(MRTAMOUNT)", "")
            qty_totel = dt.Compute(" sum(QTY)", "")
            e.Graphics.DrawString(CDbl(MRTAMOUNT).ToString("#,##0.00") & " บาท", PrintFont, PrintColor, PrintPosition, format)
            Pnewline(y, 20)

            Amount = MRTAMOUNT

            'Else
            '    For Each val As SALE_Models.slipModel In print_value.dataslip
            '        'PrintPosition = New PointF(10, y)
            '        'e.Graphics.DrawString(val("SEQ"), PrintFont, PrintColor, PrintPosition)
            '        PrintPosition = New PointF(x, y)
            '        e.Graphics.DrawString(val.FOODNAME, PrintFont, PrintColor, PrintPosition)
            '        PrintPosition = New PointF(x + max_pixel, y)
            '        e.Graphics.DrawString(CDbl(val.MRTAMOUNT).ToString("#,##0.00") & "  บาท", PrintFont, PrintColor, PrintPosition, format)
            '        Pnewline(y, 20)
            '        qty_totel += 1
            '        Amount += val.MRTAMOUNT
            '    Next
            'End If

            ''Pnewline(y)
            y = y - 10
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)


            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("จำนวน " & qty_totel & " รายการ", PrintFont, PrintColor, PrintPosition)

            PrintPosition = New PointF(x + max_pixel, y)
            e.Graphics.DrawString("รวม " & Amount.ToString("#,##0.00") & " บาท", PrintFont, PrintColor, PrintPosition, format)



            'Pnewline(y, 20)
            'PrintPosition = New PointF(10, y)
            'e.Graphics.DrawString(print_value.dataslip(0).LUPDATE & "  " & print_value.dataslip(0).BARCODE, PrintFont, PrintColor, PrintPosition)
            'Dim f As New F_payment(Nothing)
            'Dim paytype As String = f.btn_narmal.Tag
            'If print_value.dataslip(0).CARDTENDOR = paytype Then
            '    Pnewline(y, 20)
            '    PrintPosition = New PointF(x, y)
            '    e.Graphics.DrawString(" บัตรใช้งานได้ถึงวันที่ " & print_value.dataslip(0).CEXPIRED.Date, PrintFont, PrintColor, PrintPosition)

            '    Pnewline(y, 20)
            '    PrintPosition = New PointF(x, y)
            '    e.Graphics.DrawString(" มูลค่าบัตรคงเหลือ ", PrintFont, PrintColor, PrintPosition)
            '    PrintPosition = New PointF(x + max_pixel, y)
            '    e.Graphics.DrawString(CDbl(print_value.dataslip(0).CBALANCE).ToString("#,##0.00") & " บาท ", PrintFont, PrintColor, PrintPosition, format)
            'Else
            If print_value.dataslip(0).CARDTENDOR = "TRUEEDC" Then
                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("        **** Payment By " & print_value.dataslip(0).CARDTENDOR & " ****", PrintFont, PrintColor, PrintPosition)

            Else
                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("        **** " & print_value.dataslip(0).CARDTENDOR & " ****", PrintFont, PrintColor, PrintPosition)
                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("Payment ID : " & print_value.dataslip(0).CARDREF, PrintFont, PrintColor, PrintPosition)

            End If



            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("วันที่ : " & New CL_date().Condate(print_value.dataslip(0).LUPDATE, "dd/MM/yyyy HH:mm:ss", "TH"), PrintFont, PrintColor, PrintPosition)


            'PrintPosition = New PointF(x + max_pixel, y)
            'e.Graphics.DrawString(CDbl(print_value.dataslip(0).CBALANCE).ToString("#,##0.00") & " บาท ", PrintFont, PrintColor, PrintPosition, format)
            'End If











            Pnewline(y, 30)
            PrintPosition = New PointF(x + 60, y)
            Dim img As Image
            img = QR.GenerateQrCode_img(print_value.dataslip(0).BARCODE)
            e.Graphics.DrawImage(img, PrintPosition.X, PrintPosition.Y, 100, 80)

            'Dim bar_format As New StringFormat
            'bar_format.Alignment = StringAlignment.Center
            'bar_format.LineAlignment = StringAlignment.Center
            Pnewline(y, 80)
            PrintPosition = New PointF(x + 60, y)
            'PrintPosition = New PointF(x, y)
            'e.Graphics.DrawString(print_value.dataslip(0).BARCODE, PrintFont, PrintColor, PrintPosition)

        Catch ex As Exception
            Throw ex
        Finally
            print_value.dataslip = Nothing
        End Try
    End Sub
    Private Sub R880NP_PrintPage_CN(sender As Object, e As Printing.PrintPageEventArgs)
        Try
            Dim dt As New DataTable
            dt = New API(Center.Data_Config.API,).ToDataTable(Of SALE_Models.slipModel)(print_value.dataslip)



            Dim x As Integer = 10
            Dim y As Integer = 0
            Dim max_pixel As Integer = 250

            Dim PrintFont As New Font("Angsana NEW", 12)
            Dim PrintFont1 As New Font("Angsana NEW", 12)
            Dim PrintFont2 As New Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))

            Dim PrintColor As New SolidBrush(Color.Black)
            Dim PrintPosition As New PointF
            PrintPosition = New PointF(0, 0)
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Far


            PrintPosition = New PointF(x + 30, y)
            e.Graphics.DrawString(print_value.dataslip(0).COMPNAME, PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 20)

            PrintPosition = New PointF(x + 60, y)
            e.Graphics.DrawString(print_value.dataslip(0).COMPNAME_remark, PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 20)




            PrintPosition = New PointF(x + 27, y)
            e.Graphics.DrawString("ใบลดหนี้/ใบกำกับภาษีอย่างย่อ", PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("(VAT INCLUDED)", PrintFont, PrintColor, PrintPosition)

            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("TAXID  " & Center.data_profile.TERMINAL_TTAXID, PrintFont, PrintColor, PrintPosition)


            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("POS# " & Center.data_profile.POSID, PrintFont, PrintColor, PrintPosition)

            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("TAX CN : " & print_value.dataslip(0).CREDITNOTES, PrintFont, PrintColor, PrintPosition)




            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString(" ชื่อร้าน " & Me.print_value.shopname, PrintFont, PrintColor, PrintPosition)

            Pnewline(y, 20)
            PrintPosition = New PointF(x, y - 10)
            e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 8)
            PrintPosition = New PointF(x, y - 10)

            Dim qty_totel As Int16 = 0
            Dim Amount As Double = 0



            PrintPosition = New PointF(10, y)
            e.Graphics.DrawString("อาหารเครื่องดื่ม ", PrintFont, PrintColor, PrintPosition)
            PrintPosition = New PointF(x + max_pixel, y)


            Dim MRTAMOUNT As Double = dt.Compute(" sum(MRTAMOUNT)", "")
            qty_totel = dt.Compute(" sum(QTY)", "")
            e.Graphics.DrawString(CDbl(MRTAMOUNT).ToString("#,##0.00") & " บาท", PrintFont, PrintColor, PrintPosition, format)
            Pnewline(y, 20)

            Amount = MRTAMOUNT

            y = y - 10
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)


            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("จำนวน " & qty_totel & " รายการ", PrintFont, PrintColor, PrintPosition)

            PrintPosition = New PointF(x + max_pixel, y)
            e.Graphics.DrawString("รวม " & Amount.ToString("#,##0.00") & " บาท", PrintFont, PrintColor, PrintPosition, format)

            If print_value.dataslip(0).CARDTENDOR = "TRUEEDC" Then
                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("        **** Payment By " & print_value.dataslip(0).CARDTENDOR & " ****", PrintFont, PrintColor, PrintPosition)

            Else
                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("        **** " & print_value.dataslip(0).CARDTENDOR & " ****", PrintFont, PrintColor, PrintPosition)
                Pnewline(y, 20)
                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString("CN ID : " & print_value.dataslip(0).CARDREF_CN, PrintFont, PrintColor, PrintPosition)

            End If

            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("Ref Tax INV : " & print_value.dataslip(0).TAXINVOICE, PrintFont, PrintColor, PrintPosition)


            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("วันที่ : " & New CL_date().Condate(print_value.dataslip(0).LUPDATE, "dd/MM/yyyy HH:mm:ss", "TH"), PrintFont, PrintColor, PrintPosition)

            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("เหตุผลการ VOID : การบริการบกพร่อง", PrintFont, PrintColor, PrintPosition)



        Catch ex As Exception
            Throw ex
        Finally
            print_value.dataslip = Nothing
        End Try
    End Sub

    Private Sub R880NP_PrintPage_Rpt_dayend(sender As Object, e As Printing.PrintPageEventArgs)
        Try
            'Dim dt As New DataTable
            'dt = New API(Center.Data_Config.API,).ToDataTable(Of SALE_Models.slipModel)(print_value.dataslip)

            Dim x As Integer = 10
            Dim y As Integer = 0
            Dim max_pixel As Integer = 250

            Dim PrintFont As New Font("Angsana NEW", 12)
            Dim PrintFont1 As New Font("Angsana NEW", 12)
            Dim PrintFont2 As New Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))

            Dim PrintColor As New SolidBrush(Color.Black)
            Dim PrintPosition As New PointF
            PrintPosition = New PointF(0, 0)
            Dim format As New StringFormat
            format.Alignment = StringAlignment.Far

            Pnewline(y, 20)
            PrintPosition = New PointF(x + 40, y)
            e.Graphics.DrawString("รายงานสรุปยอดขายประจำวัน ", PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("  ชื่อร้าน " & Me.print_value.shopname, PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("  วันที่ " & Center.date_now, PrintFont, PrintColor, PrintPosition)


            Pnewline(y, 2)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)
            Dim qty_totel As Int16 = 0
            Dim Amount As Double = 0

            Pnewline(y, 19)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("ประเภทยอดขาย", PrintFont, PrintColor, PrintPosition)
            PrintPosition = New PointF(x + (max_pixel) - 70, y)
            e.Graphics.DrawString("จำนวนครั้ง", PrintFont, PrintColor, PrintPosition, format)
            PrintPosition = New PointF(x + (max_pixel), y)
            e.Graphics.DrawString("มูลค่า", PrintFont, PrintColor, PrintPosition, format)

            Pnewline(y, 4)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)


            Pnewline(y, 15)
            PrintPosition = New PointF(x, y - 10)
            For Each val As SALE_Models.dayend_Model In print_value.dayend_Model

                PrintPosition = New PointF(x, y)
                e.Graphics.DrawString(val.CARDTENDOR, PrintFont, PrintColor, PrintPosition)
                PrintPosition = New PointF(x + (max_pixel) - 100, y)
                e.Graphics.DrawString(CDbl(val.TOTALCARD_QTY).ToString("#,##0"), PrintFont, PrintColor, PrintPosition, format)
                PrintPosition = New PointF(x + (max_pixel), y)
                If val.CARDTENDOR = "ยกเลิกการขาย" Then
                    e.Graphics.DrawString("(" & (CDbl(val.MRTAMOUNT).ToString("#,##0.00").ToString) & ")", PrintFont, PrintColor, PrintPosition, format)
                Else
                    e.Graphics.DrawString(CDbl(val.MRTAMOUNT).ToString("#,##0.00"), PrintFont, PrintColor, PrintPosition, format)
                End If
                Pnewline(y, 15)
            Next
            Pnewline(y, -12)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString("______________________________________________", PrintFont, PrintColor, PrintPosition)


            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString(" รวมยอดขาย", PrintFont, PrintColor, PrintPosition)

            Dim sumMRTAMOUNT = (From c In print_value.dayend_Model Where c.CARDTENDOR <> "ยกเลิกการขาย" Select c.MRTAMOUNT).Sum()


            'ไม่ต้องมีแล้ว เพราะยอดที่ส่งมาเป็นยอดขายอย่างเดียวหักวอยแล้ว ไม่ต้องนำไปลบ 24/11/63
            'Dim VOID = (From c In print_value.dayend_Model Where c.CARDTENDOR = "ยกเลิกการขาย" Select c.MRTAMOUNT).Sum()
            'sumMRTAMOUNT -= VOID

            PrintPosition = New PointF(x + max_pixel, y)
            e.Graphics.DrawString(sumMRTAMOUNT.ToString("#,##0.00"), PrintFont, PrintColor, PrintPosition, format)

            Pnewline(y, 2)
            PrintPosition = New PointF(x + max_pixel - 70, y)
            e.Graphics.DrawString("____________", PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 2)
            PrintPosition = New PointF(x + max_pixel - 70, y)
            e.Graphics.DrawString("____________", PrintFont, PrintColor, PrintPosition)





            Pnewline(y, 20)
            PrintPosition = New PointF(x, y)
            e.Graphics.DrawString(" รวมบัตรหมดมูลค่าที่ร้านค้า", PrintFont, PrintColor, PrintPosition)

            PrintPosition = New PointF(x + max_pixel, y)
            Dim sumTOTALCARD = print_value.dayend_Model(0).TOTALCARD '(From c In print_value.dayend_Model Select c.TOTALCARD).Sum()
            e.Graphics.DrawString(sumTOTALCARD.ToString("#,##0"), PrintFont, PrintColor, PrintPosition, format)

            Pnewline(y, 2)
            PrintPosition = New PointF(x + max_pixel - 70, y)
            e.Graphics.DrawString("____________", PrintFont, PrintColor, PrintPosition)
            Pnewline(y, 2)
            PrintPosition = New PointF(x + max_pixel - 70, y)
            e.Graphics.DrawString("____________", PrintFont, PrintColor, PrintPosition)

        Catch ex As Exception
            Throw ex
        Finally
            print_value.dataslip = Nothing
        End Try
    End Sub
    Private Function Pnewline(ByRef val1 As Int16, ByVal val2 As Int16) As Int16
        val1 = val1 + val2
        Return val1
    End Function
End Class

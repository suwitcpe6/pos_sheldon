Imports System.IO.Ports
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Xml.Serialization
Imports Control_us

Public Class GHL_EDC_Payment
    Dim PAYTYPE As String = ""
    Dim PAYTYPE_value As New TenderModels.Sel_Tender
    Dim Payment_Log As New CL_Payment_Log
    Dim EDC_IP As String


    'config EDC 

    'CUSGROUP =CPN ,HOMEPRO
    'VENDOR_GETWAY= ,TRUE,QRTHAI,==>>> GHL
    'CONN_LINK = WIFI  , BT
    'WALLET_TYPE = API, EDC
    Sub New(val1 As String, val2 As TenderModels.Sel_Tender, EDC_IP As String)
        Me.PAYTYPE = val1
        Me.PAYTYPE_value = val2
        Me.EDC_IP = EDC_IP
    End Sub
    Public Class SENT_MODEL
        Public Property trade_type As String
        Public Property amount As String
        Public Property pos_ref_no As String
        Public Property transaction_type As String
    End Class
    <Serializable()>
    Public Class xml
        Public pos_ref_no As String
        Public response_code As String
        Public response_msg As String
        Public transaction_id As String
        Public invoice_no As String
        Public card_no As String
        Public amount As String
        Public card_approval_code As String
        Public card_type As String

    End Class

    Public Function C_PAYTYPE(val As String) As String
        Select Case val.ToUpper
            Case "ALIPAY" : Return "ALIPAY"
            Case "DOLFIN" : Return ""
            Case "RABBIT" : Return ""
            Case "LINEPAY" : Return "LINEPAY"
            Case "THAIQR" : Return "THAIQRCODE"
            Case "WECHAT" : Return "WECHATPAY"
            Case "TRUEWALLET" : Return "TRUEMONEY"
            Case "WECHAT" : Return "ALIPAY"
            Case "QRCS" : Return "QRCS"
            Case Else : Return ""

        End Select
    End Function
    Public Function Conn_EDC(CONN_LINK As String, val As SALE_Models.SALE_INT) As ConfirmpayModels_log
        Select Case CONN_LINK
            Case "WIFI"
                Return Sent_LINK_TCP(val)
            Case "BT"
        End Select
    End Function
    Public Function Sent_LINK_TCP(val As SALE_Models.SALE_INT) As ConfirmpayModels_log
        Dim ret As New ConfirmpayModels_log
        Dim port As Int32 = 8020  '// This Is the port number
        Try
            Dim localAddr1 As IPAddress = IPAddress.Parse(Me.EDC_IP) ' // This Is the ip address
            Dim client As TcpClient = New TcpClient()
            client.Connect(localAddr1, port)

            If (client.Connected) Then
                Dim data As New SENT_MODEL
                data.trade_type = C_PAYTYPE(Me.PAYTYPE)
                data.amount = val.NETAMOUNT * 100
                data.pos_ref_no = val.MRTSLIPNO
                data.transaction_type = "SALE"


                Dim sw As StringWriter = New StringWriter()
                Dim s As New XmlSerializer(data.GetType())
                s.Serialize(sw, data)

                Dim xml_str = "<xml><trade_type>" & data.trade_type & "</trade_type><amount>" & data.amount & "</amount><pos_ref_no>" & data.pos_ref_no & "</pos_ref_no><transaction_type>" & data.transaction_type & "</transaction_type></xml>"
                'xml_str = sw.ToString

                Dim buf() As Byte
                buf = Encoding.UTF8.GetBytes(xml_str & vbNewLine)
                Dim Stream As NetworkStream = client.GetStream()
                Stream.Write(buf, 0, xml_str.Length + 1)

                '// read Data from EDC
                Dim buf_read(1024) As Byte
                Stream.Read(buf_read, 0, 1024)
                Dim Xml As String = Encoding.UTF8.GetString(buf_read)
                Stream.Close()

                'Dim xs As New XmlSerializer(GetType(List(Of GHL_EDC_Payment.Xml)))
                'Dim RETList As New List(Of GHL_EDC_Payment.Xml)
                'RETList = xs.Deserialize(New StringReader(Xml))

                Dim RETList As GHL_EDC_Payment.xml = ConvertFromXml(Of xml)(Xml)
                'Dim c As Class1 = ConvertFromXml(Of Class1)("<Class1><country>USA</country><province>TestP</province></Class1>")


                Payment_Log = New CL_Payment_Log
                Dim data_log As New CL_Payment_Log.MD_data

                data_log.TENDERCODE = PAYTYPE_value.CODE
                data_log.DOCNO = val.MRTSLIPNO
                data_log.MERCHAND_ID = ""
                data_log.LOG_TYPE = CL_Payment_Log.Request
                data_log.DATA_TYPE = "XML"
                data_log.DATA1 = xml_str
                data_log.DATA2 = Xml
                Payment_Log.Payment_Log(data_log)


                ret.PAYMENT_CODE = RETList.invoice_no
                ret.PAY_AMOUNT = RETList.amount
                ret.PAY_DESCRIPTION = RETList.response_msg
                ret.PAY_Remark = "GHL EDC"
                ret.PAY_STATE = RETList.response_code


            Else
                Messages.Texts("EDC Payment", "กรุณาเลือกช่องทางการเชื่อมต่อ WIFI หรือ bluetooth", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Stopp)
                Return Nothing
            End If
            client.Close()

            Return ret
        Catch ex As System.Net.Sockets.SocketException
            If ex.ErrorCode = 10061 Then
                Messages.Texts("EDC Payment", "กรุณากด LinkPOS ที่เครื่อง EDC", Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            Else
                Messages.Texts("EDC Payment", ex.Message.ToString, Messages.ButtonType.OkOnly, Messages.MessageBoxIcon.Errorr)
            End If

        End Try
    End Function
    Public Function Test_LINK() As Boolean
        Try


            If My.Computer.Network.Ping(Me.EDC_IP) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("เชื่อมเครื่อง EDC ไม่ได้ กรุณาตรวจสอบ WIFI หรือการตั้งค่า IP")
        End Try
    End Function
    Function ConvertFromXml(Of T As Class)(ByRef str As String) As T
        Dim char_() As Char
        char_ = str
        Dim str2 As String = ""
        For Each val As String In char_
            If val = vbLf Then Exit For
            str2 += val
        Next
        Dim serializer As XmlSerializer = New XmlSerializer(GetType(T))


        Dim reader As StringReader = New StringReader(str2)


        Dim c As T = TryCast(serializer.Deserialize(reader), T)


        Return c


    End Function


    'Function ConvertFromXml(Of T As Class)(ByRef str As String) As List(Of T)

    '    Dim char_() As Char
    '    char_ = str
    '    Dim str2 As String = ""
    '    For Each val As String In char_
    '        If val = vbLf Then Exit For
    '        str2 += val
    '    Next

    '    Dim serializer As XmlSerializer = New XmlSerializer(GetType(T))


    '    Dim reader As StringReader = New StringReader(str2)


    '    Dim c As List(Of T) = TryCast(serializer.Deserialize(reader), List(Of T))


    '    Return c


    'End Function

    ''Public Shared Function DataSerialize(ByVal myList As List(Of int)) As String
    ''    Dim sw As StringWriter = New StringWriter()
    ''    Dim s As New XmlSerializer(myList.GetType())
    ''    s.Serialize(sw, myList)
    ''    Return sw.ToString()
    ''End Function

    ''Public Shared Function DataDeserialize(ByVal data As String) As List(Of int)
    ''    Dim xs As New XmlSerializer(GetType(List(Of int)))
    ''    Dim newList As List(Of int) = CType(xs.Deserialize(New StringReader(data)), List(Of int))
    ''    Return newList
    ''End Function

    <Serializable()>
    Public Class Class1
        Public country As String
        Public province As String
    End Class

    Private Sub Sent_LINK_Bluetooth()

    End Sub
    '    Private Function blu()
    '        Boolean Enable_BLUETOOTH = True;
    'BluetoothChatFragment fragment = New BluetoothChatFragment();

    'String cmd = "<xml><trade_type>ALIPAY</trade_type><pos_ref_no>" + generateref1() + "</pos_ref_no><amount>" + amount + "</amount><transaction_type>SALE</transaction_type></xml>";

    'fragment.sendBluetoothMessage(cmd);
    '    End Function
End Class

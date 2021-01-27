
Imports System.IO
Imports QRCoder

Public Class QR

    Public Shared Function Gen_QRtext(ByVal txtinput As String, Prefix As String) As String
        Return Prefix & txtinput
    End Function
    Public Shared Function Cut_QRtext(ByVal txtinput As String) As String
        Return txtinput.Substring(2)
    End Function
    Public Shared Function Cut_Prefix(ByVal txtinput As String) As String
        Return txtinput.Substring(0, 1)
    End Function
    Public Shared Function Gen_QRcode(ByVal txtinput As String) As Image
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(txtinput, QRCodeGenerator.ECCLevel.M)
        Dim code As New QRCode(data)
        Return code.GetGraphic(100)
    End Function
    Public Shared Function GenerateQrCode(qrmsg As String) As Byte()
        'อันนี้ดีกว่า
        Dim code As String = qrmsg

        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        qrcode.QRCodeErrorCorrect = MessagingToolkit.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.Q
        'qrcode.QRCodeScale = 100
        'QRcode.QRCodeVersion = 0
        'Dim bmp As Bitmap = qrcode.Encode(code)



        Using bitMap As Bitmap = qrcode.Encode(code)
            Using ms As New MemoryStream()
                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                Dim byteImage As Byte() = ms.ToArray()
                Return byteImage
            End Using
        End Using
    End Function
    Public Shared Function GenerateQrCode_img(qrmsg As String) As Image
        'อันนี้ดีกว่า
        Dim code As String = qrmsg

        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        qrcode.QRCodeErrorCorrect = MessagingToolkit.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.Q
        'qrcode.QRCodeScale = 100
        'QRcode.QRCodeVersion = 0
        'Dim bmp As Bitmap = qrcode.Encode(code)



        Using bitMap As Bitmap = qrcode.Encode(code)
            'Using ms As New MemoryStream()
            '    bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
            '    Dim byteImage As Byte() = ms.ToArray()
            Dim img As Image
            img = Image.FromHbitmap(bitMap.GetHbitmap)
            Return img
            'End Using
        End Using
    End Function
End Class

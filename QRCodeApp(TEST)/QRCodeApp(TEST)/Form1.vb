Imports QRCoder

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(txtInput.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        pic.Image = code.GetGraphic(6)
    End Sub
End Class

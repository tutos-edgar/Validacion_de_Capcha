Imports System.Drawing
Imports System.Drawing.Imaging

Public Class Form1

    Private caraterCaptcha As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789"
    Dim capchaTexto


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generarCaptcha()
    End Sub


    Private Sub generarCaptcha()
        Try
            Dim aleatorio = New Random

            capchaTexto = New String(Enumerable.Range(1, 5).Select(Function(x) caraterCaptcha(aleatorio.Next(caraterCaptcha.Length))).ToArray())

            Dim image As New Bitmap(200, 50)

            Using captcha As Graphics = Graphics.FromImage(image)
                captcha.Clear(Color.White)
                captcha.DrawString(capchaTexto, New Font("Arial", 20, FontStyle.Bold), Brushes.Gray, New PointF(10, 5))

            End Using

            PictureBox2.Image = image

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "123" And TextBox2.Text = "hola" And TextBox3.Text = capchaTexto Then
            MessageBox.Show("CONTRASEÑA CORRECTA ", "LOGIN CAPTCHA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("CONTRASEÑA INCORRECTA", "LOGIN CAPTCHA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            generarCaptcha()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        generarCaptcha()
    End Sub

End Class

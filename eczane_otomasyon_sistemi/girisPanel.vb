Imports System.Data
Imports System.Data.SqlClient
Public Class girisPanel
    Public bag As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
    Public kmt As New SqlCommand
    Dim sonuc As Integer
    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        sonuc = 0
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "Select count(id) from kullanicibil where kullaniciAdi=@kullaniciAdi and parola=@parola"
        kmt.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text.ToLower().Trim())
        kmt.Parameters.AddWithValue("@parola", textBox2.Text.ToLower().Trim())
        sonuc = Convert.ToInt32(kmt.ExecuteScalar().ToString())
        If (sonuc = 1) Then
            giris.Show()
            Me.Hide()
        Else
            label3.Text = "Kullanici adı veya parola Hatalı !"
        End If
        bag.Close()
        kmt.Parameters.Clear()
        kmt.Dispose()
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Close()
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub
End Class
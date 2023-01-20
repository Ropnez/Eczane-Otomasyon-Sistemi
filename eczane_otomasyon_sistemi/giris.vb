Imports System.Data
Imports System.Data.SqlClient

Public Class giris
    Public bag As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
    Public kmt As New SqlCommand
    Public adtr As New SqlDataAdapter
    Public tablo As New DataTable()

    Private Sub giris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        recete_satis.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hasta_kaydi.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ilac_ekle.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient

Public Class firma_ekle
    Public bag As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
    Public kmt As New SqlCommand
    Public adtr As New SqlDataAdapter
    Public tablo As New DataTable()
    Public Sub listele()
        tablo.Clear()
        Dim adtr As New SqlDataAdapter("select * From firmabil ", bag)
        adtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        adtr.Dispose()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "INSERT INTO firmabil(adi) VALUES (@adi)"
        kmt.Parameters.AddWithValue("@adi", textBox1.Text)
        kmt.ExecuteNonQuery()
        kmt.Dispose()
        bag.Close()
        kmt.Parameters.Clear()
        listele()
        MessageBox.Show("Kayıt işlemi tamamlandı !")
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "UPDATE firmabil SET adi=@adi WHERE id=@id"
        kmt.Parameters.AddWithValue("@adi", textBox1.Text)
        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        kmt.ExecuteNonQuery()
        bag.Close()
        kmt.Parameters.Clear()
        listele()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "DELETE from firmabil WHERE id=@id"
        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        kmt.ExecuteNonQuery()
        kmt.Dispose()
        bag.Close()
        kmt.Parameters.Clear()
        listele()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        textBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        giris.Show()
        Me.Hide()
    End Sub

    Private Sub firma_ekle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub

    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Dim adtr As New SqlDataAdapter("select * From firmabil", bag)
        Dim alan As String = ""
        If ComboBox3.Text = "Firma Adı" Then
            alan = "adi"
        End If

        If ComboBox3.Text = "Tümü" Then
            bag.Open()
            tablo.Clear()
            kmt.Connection = bag
            kmt.CommandText = "Select * from firmabil"
            adtr.SelectCommand = kmt
            adtr.Fill(tablo)
            bag.Close()
        End If

        If alan <> "" Then
            bag.Open()
            adtr.SelectCommand.CommandText = (" Select * From firmabil" & " where(" & alan & " like '%") + TextBox6.Text & "%' )"
            tablo.Clear()
            adtr.Fill(tablo)
            bag.Close()
        End If
        kmt.Dispose()
    End Sub
End Class
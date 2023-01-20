Imports System.Data
Imports System.Data.SqlClient
Public Class hasta_kaydi
    Public bag As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
    Public kmt As New SqlCommand
    Public adtr As New SqlDataAdapter
    Public tablo As New DataTable()
    Public Sub listele()
        tablo.Clear()
        Dim adtr As New SqlDataAdapter("select * From hastabil ", bag)
        adtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        adtr.Dispose()
    End Sub
    Private Sub hasta_kaydi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        giris.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "INSERT INTO hastabil(adi,soyadi,tcKimlik,cepTel,adres) VALUES (@adi,@soyadi,@tcKimlik,@cepTel,@adres) "
        kmt.Parameters.AddWithValue("@adi", textBox1.Text)
        kmt.Parameters.AddWithValue("@soyadi", textBox2.Text)
        kmt.Parameters.AddWithValue("@tcKimlik", TextBox3.Text)
        kmt.Parameters.AddWithValue("@cepTel", TextBox4.Text)
        kmt.Parameters.AddWithValue("@adres", TextBox5.Text)
        kmt.ExecuteNonQuery()
        kmt.Dispose()
        bag.Close()
        kmt.Parameters.Clear()
        For i As Integer = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(i) Is TextBox Then
                Me.Controls(i).Text = ""
            End If
        Next
        listele()
        MessageBox.Show("Kayıt işlemi tamamlandı !")
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        textBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        textBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "UPDATE hastabil SET adi=@adi,soyadi=@soyadi,tcKimlik=@tcKimlik,cepTel=@cepTel,adres=@adres WHERE id=@id"
        kmt.Parameters.AddWithValue("@adi", textBox1.Text)
        kmt.Parameters.AddWithValue("@soyadi", textBox2.Text)
        kmt.Parameters.AddWithValue("@tcKimlik", TextBox3.Text)
        kmt.Parameters.AddWithValue("@cepTel", TextBox4.Text)
        kmt.Parameters.AddWithValue("@adres", TextBox5.Text)
        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        kmt.ExecuteNonQuery()
        bag.Close()
        kmt.Parameters.Clear()
        listele()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "DELETE from hastabil WHERE id=@id"
        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        kmt.ExecuteNonQuery()
        kmt.Dispose()
        bag.Close()
        kmt.Parameters.Clear()
        listele()
    End Sub

    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Dim adtr As New SqlDataAdapter("select * From hastabil", bag)
        Dim alan As String = ""
        If comboBox1.Text = "Tc Kimlik" Then
            alan = "tcKimlik"
        ElseIf comboBox1.Text = "Adı" Then
            alan = "adi"
        ElseIf comboBox1.Text = "Soyadı" Then
            alan = "soyadi"
        End If

        If comboBox1.Text = "Tümü" Then
            bag.Open()
            tablo.Clear()
            kmt.Connection = bag
            kmt.CommandText = "Select * from hastabil"
            adtr.SelectCommand = kmt
            adtr.Fill(tablo)
            bag.Close()
        End If

        If alan <> "" Then
            bag.Open()
            adtr.SelectCommand.CommandText = (" Select * From hastabil" & " where(" & alan & " like '%") + TextBox6.Text & "%' )"
            tablo.Clear()
            adtr.Fill(tablo)
            bag.Close()
        End If
        kmt.Dispose()
    End Sub
End Class
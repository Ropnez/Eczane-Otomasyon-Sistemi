Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class ilac_ekle
    Public bag As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
    Public kmt As New SqlCommand
    Public adtr As New SqlDataAdapter
    Public tablo As New DataTable()
    Dim idfir As Integer

    Public Sub firmaEkle()
        Using connection As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
            connection.Open()
            Dim command As New SqlCommand("Select * from firmabil", connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                ComboBox1.Items.Add(New DictionaryEntry(reader(1).ToString(), reader(0).ToString()))
            End While
            reader.Close()
            command.Dispose()
        End Using
        ComboBox1.DisplayMember = "Key"
        ComboBox1.ValueMember = "Value"
        ComboBox1.DataSource = ComboBox1.Items
        ComboBox1.Text = ""
    End Sub
    Public Sub idFirma()
        Try
            Using connection As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
                connection.Open()

                Dim command2 As New SqlCommand("Select * from firmabil where id=@id", connection)
                command2.Parameters.AddWithValue("@id", idfir)
                Dim reader As SqlDataReader = command2.ExecuteReader()
                While reader.Read()

                    ComboBox1.Text = reader(1).ToString()
                End While
                reader.Close()
                command2.Parameters.Clear()
                command2.Dispose()
            End Using

        Catch ex As Exception

        End Try



    End Sub
    Public Sub listele()
        tablo.Clear()
        Dim adtr As New SqlDataAdapter("select * From ilacbil ", bag)
        adtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        adtr.Dispose()
    End Sub
    Private Sub ilac_ekle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        listele()
        firmaEkle()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        giris.Show()
        Me.Hide()
    End Sub

    Private Sub btnFirmaEkle_Click(sender As Object, e As EventArgs) Handles btnFirmaEkle.Click
        firma_ekle.Show()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click

        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "INSERT INTO ilacbil(barkod,adi,fiyat,miktar,firmaId) VALUES (@barkod,@adi,@fiyat,@miktar,@firmaId) "
        kmt.Parameters.AddWithValue("@barkod", textBox1.Text)
        kmt.Parameters.AddWithValue("@adi", textBox2.Text)
        kmt.Parameters.AddWithValue("@fiyat", TextBox3.Text)
        kmt.Parameters.AddWithValue("@miktar", TextBox4.Text)
        kmt.Parameters.AddWithValue("@firmaId", ComboBox1.SelectedValue)
        kmt.ExecuteNonQuery()
        kmt.Dispose()
        bag.Close()
        For i As Integer = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(i) Is TextBox Then
                Me.Controls(i).Text = ""
            End If
            If TypeOf Me.Controls(i) Is ComboBox Then
                Me.Controls(i).Text = ""
            End If
        Next
        kmt.Parameters.Clear()
        listele()
        MessageBox.Show("Kayıt işlemi tamamlandı !")

    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "DELETE from ilacbil WHERE id=@id"
        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        kmt.ExecuteNonQuery()
        kmt.Dispose()
        bag.Close()
        kmt.Parameters.Clear()
        listele()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        textBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        textBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        ComboBox1.Text = ComboBox1.DisplayMember.Length.ToString()
        idfir = DataGridView1.CurrentRow.Cells(5).Value
        idFirma()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "UPDATE ilacbil SET barkod=@barkod,adi=@adi,fiyat=@fiyat,miktar=@miktar,firmaId=@firmaId WHERE id=@id"
        kmt.Parameters.AddWithValue("@barkod", textBox1.Text)
        kmt.Parameters.AddWithValue("@adi", textBox2.Text)
        kmt.Parameters.AddWithValue("@fiyat", TextBox3.Text)
        kmt.Parameters.AddWithValue("@miktar", TextBox4.Text)
        kmt.Parameters.AddWithValue("@firmaId",ComboBox1.SelectedValue)
        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        kmt.ExecuteNonQuery()
        bag.Close()
        kmt.Parameters.Clear()
        listele()
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Close()
    End Sub

    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Dim adtr As New SqlDataAdapter("select * From ilacbil", bag)
        Dim alan As String = ""
        If ComboBox2.Text = "Barkod" Then
            alan = "barkod"
        ElseIf ComboBox2.Text = "Adı" Then
            alan = "adi"
        End If

        If ComboBox2.Text = "Tümü" Then
            bag.Open()
            tablo.Clear()
            kmt.Connection = bag
            kmt.CommandText = "Select * from ilacbil"
            adtr.SelectCommand = kmt
            adtr.Fill(tablo)
            bag.Close()
        End If

        If alan <> "" Then
            bag.Open()
            adtr.SelectCommand.CommandText = (" Select * From ilacbil" & " where(" & alan & " like '%") + TextBox6.Text & "%' )"
            tablo.Clear()
            adtr.Fill(tablo)
            bag.Close()
        End If
        kmt.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        label1.Text = ComboBox1.SelectedValue.ToString()
    End Sub
End Class
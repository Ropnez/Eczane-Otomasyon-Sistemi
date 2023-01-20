Imports System.Data
Imports System.Data.SqlClient
Public Class recete_satis
    Public bag As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
    Public kmt As New SqlCommand
    Public adtr As New SqlDataAdapter
    Public tablo As New DataTable()
    Dim idHas, idIla As Integer
    Public Sub tcEkle()
        Using connection As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
            connection.Open()
            Dim command As New SqlCommand("Select id,tcKimlik from hastabil", connection)
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
    Public Sub ilacEkle()
        Using connection As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
            connection.Open()
            Dim command As New SqlCommand("Select id,adi from ilacbil", connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                ComboBox2.Items.Add(New DictionaryEntry(reader(1).ToString(), reader(0).ToString()))

            End While
            reader.Close()
            command.Dispose()
        End Using
        ComboBox2.DisplayMember = "Key"
        ComboBox2.ValueMember = "Value"
        ComboBox2.DataSource = ComboBox2.Items
        ComboBox2.Text = ""
    End Sub
    Public Sub idHasta()
        Using connection As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
            connection.Open()
            Dim command2 As New SqlCommand("Select * from hastabil where id=@id", connection)
            command2.Parameters.AddWithValue("@id", idHas)
            Dim reader As SqlDataReader = command2.ExecuteReader()
            While reader.Read()
                ComboBox1.Text = reader(3).ToString()
            End While
            reader.Close()
            command2.Parameters.Clear()
            command2.Dispose()
        End Using
    End Sub
    Public Sub idIlac()
        Using connection As New SqlConnection("Data Source=WIN-O5VIOU6A92D\MSSQLSERVERR;Initial Catalog=data;Integrated Security=True")
            connection.Open()
            Dim command3 As New SqlCommand("Select * from ilacbil where id=@id", connection)
            command3.Parameters.AddWithValue("@id", idIla)
            Dim reader As SqlDataReader = command3.ExecuteReader()
            While reader.Read()
                ComboBox2.Text = reader(2).ToString()
            End While
            reader.Close()
            command3.Parameters.Clear()
            command3.Dispose()
        End Using
    End Sub
    Public Sub listele()
        tablo.Clear()
        Dim adtr As New SqlDataAdapter("select * From satisbil ", bag)
        adtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        adtr.Dispose()
    End Sub
    
    Private Sub recete_satis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ilacEkle()
        tcEkle()
        listele()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        giris.Show()
        Me.Hide()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "INSERT INTO satisbil(hastaId,ilacId,tarih,miktar,faturaNo) VALUES (@hastaId,@ilacId,@tarih,@miktar,@faturaNo) "
        kmt.Parameters.AddWithValue("@hastaId", ComboBox1.SelectedValue)
        kmt.Parameters.AddWithValue("@ilacId", ComboBox2.SelectedValue)
        kmt.Parameters.AddWithValue("@tarih", DateTimePicker1.Text)
        kmt.Parameters.AddWithValue("@miktar", TextBox1.Text)
        kmt.Parameters.AddWithValue("@faturaNo", TextBox2.Text)
        kmt.ExecuteNonQuery()
        kmt.Parameters.Clear()
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
        listele()
        MessageBox.Show("Kayıt işlemi tamamlandı !")
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "DELETE from satisbil WHERE id=@id"
        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        kmt.ExecuteNonQuery()
        kmt.Dispose()
        bag.Close()
        kmt.Parameters.Clear()
        listele()
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Close()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "UPDATE satisbil SET hastaId=@hastaId,ilacId=@ilacId,tarih=@tarih,miktar=@miktar,faturaNo=@faturaNo WHERE id=@id"
        kmt.Parameters.AddWithValue("@hastaId", ComboBox1.SelectedValue)
        kmt.Parameters.AddWithValue("@ilacId", ComboBox2.SelectedValue)
        kmt.Parameters.AddWithValue("@tarih", DateTimePicker1.Text)
        kmt.Parameters.AddWithValue("@miktar", TextBox1.Text)
        kmt.Parameters.AddWithValue("@faturaNo", TextBox2.Text)
        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
        kmt.ExecuteNonQuery()
        bag.Close()
        kmt.Parameters.Clear()
        listele()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        TextBox2.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()

        idHas = DataGridView1.CurrentRow.Cells(1).Value
        idIla = DataGridView1.CurrentRow.Cells(2).Value
        idHasta()
        idIlac()

    End Sub

    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        Dim adtr As New SqlDataAdapter("select * From satisbil", bag)
        Dim alan As String = ""
        If ComboBox3.Text = "Hasta Id" Then
            alan = "hastaId"
        ElseIf ComboBox3.Text = "Fatura No" Then
            alan = "faturaNo"
        End If

        If ComboBox3.Text = "Tümü" Then
            bag.Open()
            tablo.Clear()
            kmt.Connection = bag
            kmt.CommandText = "Select * from satisbil"
            adtr.SelectCommand = kmt
            adtr.Fill(tablo)
            bag.Close()
        End If

        If alan <> "" Then
            bag.Open()
            adtr.SelectCommand.CommandText = (" Select * From satisbil" & " where(" & alan & " like '%") + TextBox6.Text & "%' )"
            tablo.Clear()
            adtr.Fill(tablo)
            bag.Close()
        End If
        kmt.Dispose()
    End Sub
End Class
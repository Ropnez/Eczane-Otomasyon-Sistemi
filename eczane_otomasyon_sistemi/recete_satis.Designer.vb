<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recete_satis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnAra = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(696, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ana Menü"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(449, 16)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "* Güncellemek istediğiniz kayıt üzerinde mouse ile çift tıklayınız !"
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.Color.Crimson
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSil.ImageKey = "1274298004_Floppy-64.png"
        Me.btnSil.Location = New System.Drawing.Point(644, 279)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(87, 60)
        Me.btnSil.TabIndex = 96
        Me.btnSil.Text = "Sil"
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.Crimson
        Me.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuncelle.ImageKey = "1274298004_Floppy-64.png"
        Me.btnGuncelle.Location = New System.Drawing.Point(754, 279)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(87, 60)
        Me.btnGuncelle.TabIndex = 95
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Location = New System.Drawing.Point(697, 122)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(31, 13)
        Me.label3.TabIndex = 91
        Me.label3.Text = "Tarih"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Location = New System.Drawing.Point(625, 66)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(103, 13)
        Me.label1.TabIndex = 89
        Me.label1.Text = "Hasta Tc Kimlik Seç"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Location = New System.Drawing.Point(682, 94)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(46, 13)
        Me.label2.TabIndex = 90
        Me.label2.Text = "İlaç Seç"
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Crimson
        Me.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKaydet.ImageKey = "1274298004_Floppy-64.png"
        Me.btnKaydet.Location = New System.Drawing.Point(644, 213)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 60)
        Me.btnKaydet.TabIndex = 86
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.Color.Crimson
        Me.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCikis.ImageKey = "1274298505_cancel.png"
        Me.btnCikis.Location = New System.Drawing.Point(754, 213)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(87, 60)
        Me.btnCikis.TabIndex = 85
        Me.btnCikis.Text = "Çıkış"
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(583, 300)
        Me.DataGridView1.TabIndex = 84
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(746, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(116, 21)
        Me.ComboBox1.TabIndex = 99
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(746, 89)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(116, 21)
        Me.ComboBox2.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(699, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Adet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(674, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Fatura No"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(746, 117)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 20)
        Me.DateTimePicker1.TabIndex = 103
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(746, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 104
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(746, 171)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 20)
        Me.TextBox2.TabIndex = 105
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Tümü", "Hasta Id", "Fatura No", "", ""})
        Me.ComboBox3.Location = New System.Drawing.Point(337, 59)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 135
        Me.ComboBox3.Text = "Tümü"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(200, 60)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 134
        '
        'btnAra
        '
        Me.btnAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAra.ImageKey = "1274298004_Floppy-64.png"
        Me.btnAra.Location = New System.Drawing.Point(479, 59)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(102, 24)
        Me.btnAra.TabIndex = 133
        Me.btnAra.Text = "Ara"
        Me.btnAra.UseVisualStyleBackColor = True
        '
        'recete_satis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = Global.eczane_otomasyon_sistemi.My.Resources.Resources._262330_minimalistic_gaussian_blur_748x421
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 432)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "recete_satis"
        Me.Text = "İlac Satış"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents btnSil As System.Windows.Forms.Button
    Private WithEvents btnGuncelle As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents btnKaydet As System.Windows.Forms.Button
    Private WithEvents btnCikis As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Private WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Private WithEvents btnAra As System.Windows.Forms.Button
End Class

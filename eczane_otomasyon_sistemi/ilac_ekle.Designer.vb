<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ilac_ekle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFirmaEkle = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnAra = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(663, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ana Menü"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnFirmaEkle
        '
        Me.btnFirmaEkle.BackColor = System.Drawing.Color.Black
        Me.btnFirmaEkle.ForeColor = System.Drawing.Color.White
        Me.btnFirmaEkle.Location = New System.Drawing.Point(773, 337)
        Me.btnFirmaEkle.Name = "btnFirmaEkle"
        Me.btnFirmaEkle.Size = New System.Drawing.Size(87, 48)
        Me.btnFirmaEkle.TabIndex = 6
        Me.btnFirmaEkle.Text = "Firma Ekle"
        Me.btnFirmaEkle.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(449, 16)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "* Güncellemek istediğiniz kayıt üzerinde mouse ile çift tıklayınız !"
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.Color.Crimson
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSil.ImageKey = "1274298004_Floppy-64.png"
        Me.btnSil.Location = New System.Drawing.Point(663, 260)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(87, 60)
        Me.btnSil.TabIndex = 77
        Me.btnSil.Text = "Sil"
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.Crimson
        Me.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuncelle.ImageKey = "1274298004_Floppy-64.png"
        Me.btnGuncelle.Location = New System.Drawing.Point(773, 260)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(87, 60)
        Me.btnGuncelle.TabIndex = 76
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(743, 111)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 74
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(743, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 73
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Location = New System.Drawing.Point(691, 118)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(36, 13)
        Me.label4.TabIndex = 71
        Me.label4.Text = "Miktar"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Location = New System.Drawing.Point(698, 92)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(29, 13)
        Me.label3.TabIndex = 70
        Me.label3.Text = "Fiyat"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Location = New System.Drawing.Point(669, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 13)
        Me.label1.TabIndex = 68
        Me.label1.Text = "Barkod No"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Location = New System.Drawing.Point(705, 66)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(22, 13)
        Me.label2.TabIndex = 69
        Me.label2.Text = "Adı"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(743, 59)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 67
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(743, 33)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 66
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Crimson
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKaydet.ImageKey = "1274298004_Floppy-64.png"
        Me.btnKaydet.Location = New System.Drawing.Point(663, 194)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 60)
        Me.btnKaydet.TabIndex = 65
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.Color.Crimson
        Me.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCikis.ImageKey = "1274298505_cancel.png"
        Me.btnCikis.Location = New System.Drawing.Point(773, 194)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(87, 60)
        Me.btnCikis.TabIndex = 64
        Me.btnCikis.Text = "Çıkış"
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(619, 299)
        Me.DataGridView1.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(677, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Firma Adı"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "id"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(743, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 81
        Me.ComboBox1.ValueMember = "id"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Tümü", "Barkod", "Adı"})
        Me.ComboBox2.Location = New System.Drawing.Point(340, 57)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 132
        Me.ComboBox2.Text = "Tümü"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(208, 57)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 131
        '
        'btnAra
        '
        Me.btnAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAra.ImageKey = "1274298004_Floppy-64.png"
        Me.btnAra.Location = New System.Drawing.Point(483, 57)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(105, 23)
        Me.btnAra.TabIndex = 130
        Me.btnAra.Text = "Ara"
        Me.btnAra.UseVisualStyleBackColor = True
        '
        'ilac_ekle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = Global.eczane_otomasyon_sistemi.My.Resources.Resources._262330_minimalistic_gaussian_blur_748x421
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 432)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnFirmaEkle)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ilac_ekle"
        Me.Text = "İlaç Ekle"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnFirmaEkle As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents btnSil As System.Windows.Forms.Button
    Private WithEvents btnGuncelle As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Public WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents btnKaydet As System.Windows.Forms.Button
    Private WithEvents btnCikis As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Private WithEvents btnAra As System.Windows.Forms.Button
End Class

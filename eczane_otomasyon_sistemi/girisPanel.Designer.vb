<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class girisPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(girisPanel))
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnKapat = New System.Windows.Forms.Button()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.label3.Location = New System.Drawing.Point(134, 80)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(0, 13)
        Me.label3.TabIndex = 31
        '
        'btnKapat
        '
        Me.btnKapat.BackColor = System.Drawing.Color.Black
        Me.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnKapat.ForeColor = System.Drawing.Color.White
        Me.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnKapat.ImageIndex = 1
        Me.btnKapat.Location = New System.Drawing.Point(254, 109)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 58)
        Me.btnKapat.TabIndex = 30
        Me.btnKapat.Text = "Kapat"
        Me.btnKapat.UseVisualStyleBackColor = False
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.Color.Black
        Me.btnGiris.ForeColor = System.Drawing.Color.White
        Me.btnGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGiris.ImageIndex = 0
        Me.btnGiris.Location = New System.Drawing.Point(173, 109)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(75, 58)
        Me.btnGiris.TabIndex = 29
        Me.btnGiris.Text = "Giriş"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(20, 38)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(101, 129)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 28
        Me.pictureBox1.TabStop = False
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(229, 61)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 27
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(229, 35)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 26
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(177, 62)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 15)
        Me.label2.TabIndex = 25
        Me.label2.Text = "Parola"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(146, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 15)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Kullanıcı Adı"
        '
        'girisPanel
        '
        Me.AcceptButton = Me.btnGiris
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnKapat
        Me.ClientSize = New System.Drawing.Size(352, 206)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "girisPanel"
        Me.Text = "Giriş Paneli"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents btnKapat As System.Windows.Forms.Button
    Private WithEvents btnGiris As System.Windows.Forms.Button
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class

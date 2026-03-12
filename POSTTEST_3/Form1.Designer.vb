<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        picProfil = New PictureBox()
        btnGambar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        txtTelp = New TextBox()
        txtUmur = New TextBox()
        TLahir = New DateTimePicker()
        group1 = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grup2 = New GroupBox()
        cbMasak = New CheckBox()
        cbNyanyi = New CheckBox()
        cbOlahraga = New CheckBox()
        cbGambar = New CheckBox()
        cbLukis = New CheckBox()
        cbMancing = New CheckBox()
        cbTari = New CheckBox()
        cbBaca = New CheckBox()
        cbCoding = New CheckBox()
        cbGame = New CheckBox()
        btnCetak = New Button()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        group1.SuspendLayout()
        grup2.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = SystemColors.ButtonFace
        picProfil.Location = New Point(89, 67)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(215, 314)
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' btnGambar
        ' 
        btnGambar.Location = New Point(141, 417)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(94, 29)
        btnGambar.TabIndex = 1
        btnGambar.Text = "Browse"
        btnGambar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(410, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 21)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(410, 309)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 20)
        Label2.TabIndex = 3
        Label2.Text = "Alamat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(410, 243)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 4
        Label3.Text = "No. Telp"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(410, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 21)
        Label4.TabIndex = 5
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(410, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 21)
        Label5.TabIndex = 6
        Label5.Text = "Umur"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(559, 80)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 7
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(559, 303)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(250, 27)
        txtAlamat.TabIndex = 8
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(559, 237)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(250, 27)
        txtTelp.TabIndex = 9
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(559, 129)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(250, 27)
        txtUmur.TabIndex = 10
        ' 
        ' TLahir
        ' 
        TLahir.CalendarFont = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TLahir.Location = New Point(559, 181)
        TLahir.Name = "TLahir"
        TLahir.Size = New Size(250, 27)
        TLahir.TabIndex = 11
        ' 
        ' group1
        ' 
        group1.Controls.Add(rbPerempuan)
        group1.Controls.Add(rbLaki)
        group1.Font = New Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        group1.Location = New Point(865, 56)
        group1.Name = "group1"
        group1.Size = New Size(329, 100)
        group1.TabIndex = 12
        group1.TabStop = False
        group1.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(177, 52)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(131, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(24, 52)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(112, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grup2
        ' 
        grup2.Controls.Add(cbMasak)
        grup2.Controls.Add(cbNyanyi)
        grup2.Controls.Add(cbOlahraga)
        grup2.Controls.Add(cbGambar)
        grup2.Controls.Add(cbLukis)
        grup2.Controls.Add(cbMancing)
        grup2.Controls.Add(cbTari)
        grup2.Controls.Add(cbBaca)
        grup2.Controls.Add(cbCoding)
        grup2.Controls.Add(cbGame)
        grup2.Font = New Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grup2.Location = New Point(865, 172)
        grup2.Name = "grup2"
        grup2.Size = New Size(329, 254)
        grup2.TabIndex = 13
        grup2.TabStop = False
        grup2.Text = "Hobi"
        ' 
        ' cbMasak
        ' 
        cbMasak.AutoSize = True
        cbMasak.Location = New Point(177, 206)
        cbMasak.Name = "cbMasak"
        cbMasak.Size = New Size(111, 24)
        cbMasak.TabIndex = 9
        cbMasak.Text = "Memasak"
        cbMasak.UseVisualStyleBackColor = True
        ' 
        ' cbNyanyi
        ' 
        cbNyanyi.AutoSize = True
        cbNyanyi.Location = New Point(24, 207)
        cbNyanyi.Name = "cbNyanyi"
        cbNyanyi.Size = New Size(114, 24)
        cbNyanyi.TabIndex = 8
        cbNyanyi.Text = "Menyanyi"
        cbNyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(177, 170)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(120, 24)
        cbOlahraga.TabIndex = 7
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbGambar
        ' 
        cbGambar.AutoSize = True
        cbGambar.Location = New Point(177, 128)
        cbGambar.Name = "cbGambar"
        cbGambar.Size = New Size(145, 24)
        cbGambar.TabIndex = 6
        cbGambar.Text = "Menggambar"
        cbGambar.UseVisualStyleBackColor = True
        ' 
        ' cbLukis
        ' 
        cbLukis.AutoSize = True
        cbLukis.Location = New Point(177, 87)
        cbLukis.Name = "cbLukis"
        cbLukis.Size = New Size(104, 24)
        cbLukis.TabIndex = 5
        cbLukis.Text = "Melukis"
        cbLukis.UseVisualStyleBackColor = True
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Location = New Point(177, 47)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(105, 24)
        cbMancing.TabIndex = 4
        cbMancing.Text = "Mancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' cbTari
        ' 
        cbTari.AutoSize = True
        cbTari.Location = New Point(24, 167)
        cbTari.Name = "cbTari"
        cbTari.Size = New Size(95, 24)
        cbTari.TabIndex = 3
        cbTari.Text = "Menari"
        cbTari.UseVisualStyleBackColor = True
        ' 
        ' cbBaca
        ' 
        cbBaca.AutoSize = True
        cbBaca.Location = New Point(24, 128)
        cbBaca.Name = "cbBaca"
        cbBaca.Size = New Size(110, 24)
        cbBaca.TabIndex = 2
        cbBaca.Text = "Membaca"
        cbBaca.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(24, 87)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(92, 24)
        cbCoding.TabIndex = 1
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGame
        ' 
        cbGame.AutoSize = True
        cbGame.Location = New Point(24, 47)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(76, 24)
        cbGame.TabIndex = 0
        cbGame.Text = "Game"
        cbGame.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(409, 417)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(420, 29)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.WindowFrame
        ClientSize = New Size(1234, 517)
        Controls.Add(btnCetak)
        Controls.Add(grup2)
        Controls.Add(group1)
        Controls.Add(TLahir)
        Controls.Add(txtUmur)
        Controls.Add(txtTelp)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnGambar)
        Controls.Add(picProfil)
        Name = "Form1"
        Text = "Form1"
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        group1.ResumeLayout(False)
        group1.PerformLayout()
        grup2.ResumeLayout(False)
        grup2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnGambar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents TLahir As DateTimePicker
    Friend WithEvents group1 As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents grup2 As GroupBox
    Friend WithEvents cbMasak As CheckBox
    Friend WithEvents cbNyanyi As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbGambar As CheckBox
    Friend WithEvents cbLukis As CheckBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbTari As CheckBox
    Friend WithEvents cbBaca As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents btnCetak As Button

End Class

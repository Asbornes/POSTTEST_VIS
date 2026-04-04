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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        rbPerempuan = New RadioButton()
        cbDivisi = New ComboBox()
        rbLaki = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        mtbNotelpon = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        TabPage3 = New TabPage()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        btnCetak = New Button()
        gbHobi = New GroupBox()
        cbLukis = New CheckBox()
        cbMasak = New CheckBox()
        cbTari = New CheckBox()
        cbFilm = New CheckBox()
        cbMusik = New CheckBox()
        cbGaming = New CheckBox()
        cbMancing = New CheckBox()
        cbCoding = New CheckBox()
        gbPeran = New GroupBox()
        rbAnggota = New RadioButton()
        rbBendahara = New RadioButton()
        rbSekre = New RadioButton()
        rbWakil = New RadioButton()
        rbKetua = New RadioButton()
        btnUpload = New Button()
        picProfil = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox2 = New PictureBox()
        Label9 = New Label()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbHobi.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(902, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(91, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(113, 31)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(628, 570)
        TabControl1.TabIndex = 3
        TabControl1.Visible = False
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(cbDivisi)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(620, 537)
        TabPage1.TabIndex = 0
        TabPage1.Text = "DataUtama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(394, 264)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 10
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' cbDivisi
        ' 
        cbDivisi.FormattingEnabled = True
        cbDivisi.Items.AddRange(New Object() {"Alpha Edge", "Beta Smash", "Gamma Future", "Delta Rise"})
        cbDivisi.Location = New Point(259, 318)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(250, 28)
        cbDivisi.TabIndex = 9
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(259, 262)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(85, 24)
        rbLaki.TabIndex = 8
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(259, 199)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 7
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(259, 138)
        txtID.Name = "txtID"
        txtID.Size = New Size(250, 27)
        txtID.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(259, 77)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(125, 321)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 4
        Label5.Text = "Divisi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(125, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 3
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(125, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 2
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(125, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "ID Anggota"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(125, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(mtbNotelpon)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(620, 537)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' mtbNotelpon
        ' 
        mtbNotelpon.Location = New Point(246, 93)
        mtbNotelpon.Mask = "0000-0000-0000"
        mtbNotelpon.Name = "mtbNotelpon"
        mtbNotelpon.PromptChar = "X"c
        mtbNotelpon.Size = New Size(263, 27)
        mtbNotelpon.TabIndex = 6
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(246, 214)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(263, 113)
        txtAlamat.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(246, 152)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(263, 27)
        txtEmail.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(118, 217)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 20)
        Label8.TabIndex = 2
        Label8.Text = "Alamat"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(118, 155)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 1
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(118, 93)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 20)
        Label6.TabIndex = 0
        Label6.Text = "No Telpon"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Panel4)
        TabPage3.Controls.Add(Panel3)
        TabPage3.Controls.Add(Panel2)
        TabPage3.Controls.Add(Panel1)
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(gbHobi)
        TabPage3.Controls.Add(gbPeran)
        TabPage3.Controls.Add(btnUpload)
        TabPage3.Controls.Add(picProfil)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(620, 537)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.Location = New Point(29, 26)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(208, 10)
        Panel4.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Location = New Point(29, 313)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(208, 10)
        Panel3.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(29, 34)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(10, 281)
        Panel2.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(226, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(10, 281)
        Panel1.TabIndex = 6
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(170, 443)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(295, 29)
        btnCetak.TabIndex = 4
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(cbLukis)
        gbHobi.Controls.Add(cbMasak)
        gbHobi.Controls.Add(cbTari)
        gbHobi.Controls.Add(cbFilm)
        gbHobi.Controls.Add(cbMusik)
        gbHobi.Controls.Add(cbGaming)
        gbHobi.Controls.Add(cbMancing)
        gbHobi.Controls.Add(cbCoding)
        gbHobi.Location = New Point(282, 225)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(287, 191)
        gbHobi.TabIndex = 3
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbLukis
        ' 
        cbLukis.AutoSize = True
        cbLukis.Location = New Point(158, 154)
        cbLukis.Name = "cbLukis"
        cbLukis.Size = New Size(63, 24)
        cbLukis.TabIndex = 7
        cbLukis.Text = "Lukis"
        cbLukis.UseVisualStyleBackColor = True
        ' 
        ' cbMasak
        ' 
        cbMasak.AutoSize = True
        cbMasak.Location = New Point(158, 117)
        cbMasak.Name = "cbMasak"
        cbMasak.Size = New Size(73, 24)
        cbMasak.TabIndex = 6
        cbMasak.Text = "Masak"
        cbMasak.UseVisualStyleBackColor = True
        ' 
        ' cbTari
        ' 
        cbTari.AutoSize = True
        cbTari.Location = New Point(158, 78)
        cbTari.Name = "cbTari"
        cbTari.Size = New Size(54, 24)
        cbTari.TabIndex = 5
        cbTari.Text = "Tari"
        cbTari.UseVisualStyleBackColor = True
        ' 
        ' cbFilm
        ' 
        cbFilm.AutoSize = True
        cbFilm.Location = New Point(158, 38)
        cbFilm.Name = "cbFilm"
        cbFilm.Size = New Size(59, 24)
        cbFilm.TabIndex = 4
        cbFilm.Text = "Film"
        cbFilm.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(28, 154)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(69, 24)
        cbMusik.TabIndex = 3
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(28, 117)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(83, 24)
        cbGaming.TabIndex = 2
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Location = New Point(28, 78)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(88, 24)
        cbMancing.TabIndex = 1
        cbMancing.Text = "Mancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(28, 38)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(79, 24)
        cbCoding.TabIndex = 0
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbBendahara)
        gbPeran.Controls.Add(rbSekre)
        gbPeran.Controls.Add(rbWakil)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Location = New Point(282, 34)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(287, 167)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(27, 127)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 4
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbBendahara
        ' 
        rbBendahara.AutoSize = True
        rbBendahara.Location = New Point(160, 84)
        rbBendahara.Name = "rbBendahara"
        rbBendahara.Size = New Size(101, 24)
        rbBendahara.TabIndex = 3
        rbBendahara.TabStop = True
        rbBendahara.Text = "Bendahara"
        rbBendahara.UseVisualStyleBackColor = True
        ' 
        ' rbSekre
        ' 
        rbSekre.AutoSize = True
        rbSekre.Location = New Point(160, 40)
        rbSekre.Name = "rbSekre"
        rbSekre.Size = New Size(94, 24)
        rbSekre.TabIndex = 2
        rbSekre.TabStop = True
        rbSekre.Text = "Sekretaris"
        rbSekre.UseVisualStyleBackColor = True
        ' 
        ' rbWakil
        ' 
        rbWakil.AutoSize = True
        rbWakil.Location = New Point(27, 84)
        rbWakil.Name = "rbWakil"
        rbWakil.Size = New Size(108, 24)
        rbWakil.TabIndex = 1
        rbWakil.TabStop = True
        rbWakil.Text = "Wakil Ketua"
        rbWakil.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(27, 40)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(92, 353)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(94, 29)
        btnUpload.TabIndex = 1
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' picProfil
        ' 
        picProfil.Location = New Point(37, 34)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(190, 281)
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources._123
        PictureBox2.Location = New Point(263, 84)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(394, 315)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 42
        PictureBox2.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(282, 402)
        Label9.Name = "Label9"
        Label9.Size = New Size(344, 39)
        Label9.TabIndex = 43
        Label9.Text = "ID CARD GENERATOR"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(902, 596)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox2)
        Controls.Add(Label9)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cbDivisi As ComboBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents mtbNotelpon As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbBendahara As RadioButton
    Friend WithEvents rbSekre As RadioButton
    Friend WithEvents rbWakil As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbLukis As CheckBox
    Friend WithEvents cbMasak As CheckBox
    Friend WithEvents cbTari As CheckBox
    Friend WithEvents cbFilm As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox

End Class

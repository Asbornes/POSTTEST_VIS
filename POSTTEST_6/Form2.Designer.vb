<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Panel3 = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnUpdate = New Button()
        btnSimpan = New Button()
        btnHapus = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        dgvProduk = New DataGridView()
        Panel4 = New Panel()
        txtCari = New TextBox()
        cbJenis = New ComboBox()
        txtStok = New TextBox()
        txtID = New TextBox()
        txtNama = New TextBox()
        Label1 = New Label()
        Label8 = New Label()
        txtHarga = New TextBox()
        Label9 = New Label()
        txtGaransi = New TextBox()
        Label10 = New Label()
        txtSpek = New TextBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-10, -18)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1258, 853)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 35
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonHighlight
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label5.Location = New Point(333, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 23)
        Label5.TabIndex = 4
        Label5.Text = "Jenis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.Location = New Point(57, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 23)
        Label2.TabIndex = 1
        Label2.Text = "Nama Produk"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(885, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 23)
        Label3.TabIndex = 2
        Label3.Text = "Stok"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonHighlight
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label4.Location = New Point(606, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 23)
        Label4.TabIndex = 3
        Label4.Text = "ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Highlight
        Label6.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(14, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(160, 25)
        Label6.TabIndex = 2
        Label6.Text = "Daftar Produk"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(188, 437)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(29, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Highlight
        Label7.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(14, 26)
        Label7.Name = "Label7"
        Label7.Size = New Size(204, 25)
        Label7.TabIndex = 2
        Label7.Text = "Input Data Produk"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Highlight
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(49, 96)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1155, 62)
        Panel3.TabIndex = 32
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Highlight
        Panel1.Location = New Point(-58, -9)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1360, 81)
        Panel1.TabIndex = 30
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(txtSpek)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(txtGaransi)
        Panel2.Controls.Add(btnSimpan)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(txtHarga)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(49, 153)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1155, 272)
        Panel2.TabIndex = 31
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.ForestGreen
        btnUpdate.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnUpdate.ForeColor = SystemColors.Control
        btnUpdate.Location = New Point(230, 223)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(149, 29)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = SystemColors.HotTrack
        btnSimpan.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnSimpan.ForeColor = SystemColors.Control
        btnSimpan.Location = New Point(57, 223)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(147, 29)
        btnSimpan.TabIndex = 15
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        btnHapus.Location = New Point(410, 223)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(160, 29)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' dgvProduk
        ' 
        dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProduk.BackgroundColor = Color.White
        dgvProduk.ColumnHeadersHeight = 29
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Info
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvProduk.DefaultCellStyle = DataGridViewCellStyle1
        dgvProduk.Location = New Point(49, 544)
        dgvProduk.Name = "dgvProduk"
        dgvProduk.RowHeadersWidth = 51
        dgvProduk.Size = New Size(1155, 268)
        dgvProduk.TabIndex = 29
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Highlight
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(49, 494)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1155, 50)
        Panel4.TabIndex = 34
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtCari.Location = New Point(223, 437)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari disini..."
        txtCari.Size = New Size(780, 27)
        txtCari.TabIndex = 28
        ' 
        ' cbJenis
        ' 
        cbJenis.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        cbJenis.FormattingEnabled = True
        cbJenis.Items.AddRange(New Object() {"Kipas angin", "AC", "Mesin cuci", "Raket nyamuk", "Dispenser", "Oven", "Kulkas", "TV", "Jam dinding", "Lampu", "Senter", "Penanak nasi"})
        cbJenis.Location = New Point(382, 206)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(237, 27)
        cbJenis.TabIndex = 27
        ' 
        ' txtStok
        ' 
        txtStok.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtStok.Location = New Point(934, 204)
        txtStok.Name = "txtStok"
        txtStok.PlaceholderText = "Stok Produk"
        txtStok.Size = New Size(237, 27)
        txtStok.TabIndex = 26
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtID.Location = New Point(655, 206)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID Produk"
        txtID.Size = New Size(237, 27)
        txtID.TabIndex = 25
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtNama.Location = New Point(106, 206)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Produk"
        txtNama.Size = New Size(237, 27)
        txtNama.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Highlight
        Label1.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(414, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(473, 37)
        Label1.TabIndex = 23
        Label1.Text = "MANAJEMEN TOKO ELEKTRONIK"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ButtonHighlight
        Label8.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label8.Location = New Point(57, 106)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 23)
        Label8.TabIndex = 5
        Label8.Text = "Harga"
        ' 
        ' txtHarga
        ' 
        txtHarga.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtHarga.Location = New Point(57, 141)
        txtHarga.Name = "txtHarga"
        txtHarga.PlaceholderText = "Harga Produk"
        txtHarga.Size = New Size(237, 27)
        txtHarga.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ButtonHighlight
        Label9.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label9.Location = New Point(333, 106)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 23)
        Label9.TabIndex = 26
        Label9.Text = "Garansi"
        ' 
        ' txtGaransi
        ' 
        txtGaransi.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtGaransi.Location = New Point(333, 141)
        txtGaransi.Name = "txtGaransi"
        txtGaransi.PlaceholderText = "Masa Garansi"
        txtGaransi.Size = New Size(237, 27)
        txtGaransi.TabIndex = 27
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ButtonHighlight
        Label10.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label10.Location = New Point(606, 106)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 23)
        Label10.TabIndex = 28
        Label10.Text = "Spesifikasi"
        ' 
        ' txtSpek
        ' 
        txtSpek.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtSpek.Location = New Point(606, 141)
        txtSpek.Multiline = True
        txtSpek.Name = "txtSpek"
        txtSpek.PlaceholderText = "Deskripsi Spesifikasi"
        txtSpek.Size = New Size(516, 111)
        txtSpek.TabIndex = 29
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1249, 830)
        Controls.Add(txtStok)
        Controls.Add(txtID)
        Controls.Add(cbJenis)
        Controls.Add(txtNama)
        Controls.Add(PictureBox1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(txtCari)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(dgvProduk)
        Controls.Add(PictureBox2)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtCari As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSpek As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtGaransi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label8 As Label
End Class

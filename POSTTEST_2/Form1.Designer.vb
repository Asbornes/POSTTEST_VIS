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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        dgvBuku = New DataGridView()
        colJudul = New DataGridViewTextBoxColumn()
        colGenre = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudul1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        btnHapus = New Button()
        Label3 = New Label()
        txtJudul2 = New TextBox()
        Panel1.SuspendLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(dgvBuku)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(txtGenre)
        Panel1.Controls.Add(txtJudul1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(3, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 455)
        Panel1.TabIndex = 0
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AccessibleName = "dgvBuku"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvBuku.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {colJudul, colGenre})
        dgvBuku.Location = New Point(264, 219)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.Size = New Size(303, 232)
        dgvBuku.TabIndex = 1
        ' 
        ' colJudul
        ' 
        colJudul.HeaderText = "Judul"
        colJudul.MinimumWidth = 6
        colJudul.Name = "colJudul"
        colJudul.Width = 125
        ' 
        ' colGenre
        ' 
        colGenre.HeaderText = "Genre"
        colGenre.MinimumWidth = 6
        colGenre.Name = "colGenre"
        colGenre.Width = 125
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(128, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 26)
        Label4.TabIndex = 8
        Label4.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(270, 175)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 7
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(239, 125)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(125, 27)
        txtGenre.TabIndex = 6
        ' 
        ' txtJudul1
        ' 
        txtJudul1.Location = New Point(239, 72)
        txtJudul1.Name = "txtJudul1"
        txtJudul1.Size = New Size(125, 27)
        txtJudul1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(128, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 21)
        Label2.TabIndex = 3
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(128, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 21)
        Label1.TabIndex = 2
        Label1.Text = "Judul"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.OrangeRed
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txtJudul2)
        Panel2.Location = New Point(420, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(386, 449)
        Panel2.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(149, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 26)
        Label5.TabIndex = 9
        Label5.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(241, 172)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(110, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 21)
        Label3.TabIndex = 7
        Label3.Text = "Judul"
        ' 
        ' txtJudul2
        ' 
        txtJudul2.Location = New Point(210, 65)
        txtJudul2.Name = "txtJudul2"
        txtJudul2.Size = New Size(125, 27)
        txtJudul2.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul1 As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJudul2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents colJudul As DataGridViewTextBoxColumn
    Friend WithEvents colGenre As DataGridViewTextBoxColumn

End Class

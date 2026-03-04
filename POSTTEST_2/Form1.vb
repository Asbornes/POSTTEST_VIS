Public Class Form1
    Public Judul As String
    Public Genre As String

    Private Sub tampilBuku()
        dgvBuku.Rows.Clear()
        For i As Integer = 0 To Module1.jumlahBuku - 1
            dgvBuku.Rows.Add(Module1.daftarBuku(i, 0), Module1.daftarBuku(i, 1))
        Next
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudul1.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("judul dan genre buku tidak boleh kosong!")
            Exit Sub
        End If
        Judul = txtJudul1.Text
        Genre = txtGenre.Text
        Module1.tambahBuku(Judul, Genre)
        tampilBuku()
        txtJudul1.Clear()
        txtGenre.Clear()
        MessageBox.Show("Buku berhasil ditambahkan!")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtJudul2.Text = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!")
            Exit Sub
        End If
        If Module1.hapusBuku(txtJudul2.Text) Then
            tampilBuku()
            MessageBox.Show("Buku berhasil dihapus!")
        Else
            MessageBox.Show("Buku tidak ditemukan!")
        End If
        txtJudul2.Clear()
    End Sub
End Class

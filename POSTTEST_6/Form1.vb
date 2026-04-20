Public Class Form1

    Private Sub Kosong()
        txtID.Clear()
        txtNama.Clear()
        txtStok.Clear()
        cbJenis.SelectedIndex = -1
        txtCari.Clear()
        ErrorProvider1.Clear()
        txtID.Enabled = True
        txtID.Focus()
    End Sub

    Private Sub TampilData()
        dgvProduk.DataSource = GetAllProduk()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput(ErrorProvider1, txtNama, txtID, txtStok, cbJenis) Then Exit Sub

        Dim id As Integer = Val(txtID.Text)
        Dim nama As String = txtNama.Text.Trim()
        Dim jenis As String = cbJenis.Text
        Dim stok As Integer = Val(txtStok.Text)

        If IDSudahAda(id) Then
            MessageBox.Show("ID Produk sudah terdaftar! Gunakan ID lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Focus()
            Exit Sub
        End If

        If SimpanProduk(id, nama, jenis, stok) Then
            MessageBox.Show("Data produk berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not ValidasiInput(ErrorProvider1, txtNama, txtID, txtStok, cbJenis) Then Exit Sub

        Dim id As Integer = Val(txtID.Text)
        Dim nama As String = txtNama.Text.Trim()
        Dim jenis As String = cbJenis.Text
        Dim stok As Integer = Val(txtStok.Text)

        If UbahProduk(id, nama, jenis, stok) Then
            MessageBox.Show("Data produk berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Gagal mengubah data. ID tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusProduk(txtID.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvProduk.DataSource = SearchProduk(txtCari.Text.Trim())
        End If
    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProduk.Rows(e.RowIndex)

            txtID.Text = row.Cells("ID").Value.ToString()
            txtNama.Text = row.Cells("Nama").Value.ToString()
            cbJenis.Text = row.Cells("Jenis").Value.ToString()
            txtStok.Text = row.Cells("STOK").Value.ToString()
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub btnRinci_Click(sender As Object, e As EventArgs) Handles btnRinci.Click
        Form2.Show()
    End Sub
End Class
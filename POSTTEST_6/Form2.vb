Public Class Form2

    Private Sub Kosong()
        txtID.Clear()
        txtNama.Clear()
        cbJenis.SelectedIndex = -1
        cbJenis.Text = ""
        txtStok.Clear()
        txtHarga.Clear()
        txtGaransi.Clear()
        txtSpek.Clear()
        ErrorProvider1.Clear()
        txtID.Focus()
    End Sub

    Private Sub TampilData()
        dgvProduk.DataSource = DataModule.GetAllDetail()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataProduk(ErrorProvider1, txtID, txtNama, cbJenis, txtStok, txtHarga, txtGaransi, txtSpek) Then Exit Sub

        Dim id As String = txtID.Text.Trim()
        Dim harga As Double = Convert.ToDouble(Val(txtHarga.Text.Trim()))
        Dim garansi As String = txtGaransi.Text.Trim()
        Dim spesifikasi As String = txtSpek.Text.Trim()

        If DataModule.idDetailSudahAda(id) Then
            MessageBox.Show("Detail untuk ID ini sudah ada. Gunakan tombol Update.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If DataModule.SimpanDetail(id, harga, garansi, spesifikasi) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataProduk(ErrorProvider1, txtID, txtNama, cbJenis, txtStok, txtHarga, txtGaransi, txtSpek) Then Exit Sub

        Dim id As String = txtID.Text.Trim()
        Dim harga As Double = Convert.ToDouble(Val(txtHarga.Text.Trim()))
        Dim garansi As String = txtGaransi.Text.Trim()
        Dim spesifikasi As String = txtSpek.Text.Trim()

        If DataModule.idDetailSudahAda(id) Then
            If DataModule.UbahDetail(id, harga, garansi, spesifikasi) Then
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        Else
            If DataModule.SimpanDetail(id, harga, garansi, spesifikasi) Then
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Hapus rincian produk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If DataModule.HapusDetail(txtID.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            txtID.Text = dgvProduk.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNama.Text = dgvProduk.Rows(e.RowIndex).Cells(1).Value.ToString()
            cbJenis.Text = dgvProduk.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtStok.Text = dgvProduk.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtHarga.Text = dgvProduk.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtGaransi.Text = dgvProduk.Rows(e.RowIndex).Cells(5).Value.ToString()
            txtSpek.Text = dgvProduk.Rows(e.RowIndex).Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        ValidationModule.HanyaAngka(e)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Dim dt As DataTable = DataModule.GetDetailByID(txtID.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtNama.Text = dt.Rows(0)("Nama").ToString()
                cbJenis.Text = dt.Rows(0)("Jenis").ToString()
                txtStok.Text = dt.Rows(0)("Stok").ToString()
                txtHarga.Text = dt.Rows(0)("Harga").ToString()
                txtGaransi.Text = dt.Rows(0)("Garansi").ToString()
                txtSpek.Text = dt.Rows(0)("Spesifikasi").ToString()
                txtHarga.Focus()
            Else
                MessageBox.Show("ID tidak ditemukan di database utama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Kosong()
            End If
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvProduk.DataSource = DataModule.SearchDetail(txtCari.Text.Trim())
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

End Class
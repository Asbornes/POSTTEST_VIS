Imports System.IO

Public Class Form1

    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton
    Dim grupPeran() As RadioButton
    Dim pathFoto As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grupHobi = {cbGaming, cbFilm, cbCoding, cbLukis, cbMancing, cbMasak,
                    cbMusik, cbTari}

        grupJK = {rbLaki, rbPerempuan}
        grupPeran = {rbKetua, rbAnggota, rbBendahara, rbSekre, rbWakil}
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.Visible = Not TabControl1.Visible
    End Sub

    Private Function CekData() As Boolean
        Dim valid As Boolean = True
        ErrorProvider1.Clear()

        If Not ValidationModule.ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong") Then valid = False
        If Not ValidationModule.ValidasiTextBox(ErrorProvider1, txtID, "ID tidak boleh kosong") Then valid = False
        If Not ValidationModule.ValidasiMaskedTextBox(ErrorProvider1, mtbNotelpon, "No HP belum lengkap") Then valid = False
        If Not ValidationModule.ValidasiTextBox(ErrorProvider1, txtAlamat, "Alamat tidak boleh kosong") Then valid = False

        If cbDivisi.Text = "" Then
            ErrorProvider1.SetError(cbDivisi, "Pilih divisi")
            valid = False
        End If

        If pathFoto = "" Then
            ErrorProvider1.SetError(picProfil, "Pilih foto terlebih dahulu")
            valid = False
        End If

        Return valid
    End Function

    Private Function ValidasiCheckBox(grup() As CheckBox, pesan As String) As Boolean
        For Each cb In grup
            If cb.Checked Then Return True
        Next
        MessageBox.Show(pesan)
        Return False
    End Function

    Private Function ValidasiRadioButtonCustom(grup() As RadioButton, pesan As String) As Boolean
        For Each rb In grup
            If rb.Checked Then Return True
        Next
        MessageBox.Show(pesan)
        Return False
    End Function

    Private Function GetSelectedCheckBox(grup() As CheckBox) As String
        Dim list As New List(Of String)

        For Each cb In grup
            If cb.Checked Then
                list.Add(cb.Text)
            End If
        Next

        Return String.Join(",", list)
    End Function

    Private Function GetSelectedRadioButton(grup() As RadioButton) As String
        For Each rb In grup
            If rb.Checked Then Return rb.Text
        Next
        Return ""
    End Function

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ValidationModule.HanyaHuruf(e)
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub mtbNotelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbNotelpon.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If Not CekData() Then Exit Sub
        DataModule.nama = txtNama.Text
        DataModule.id = txtID.Text
        DataModule.tgl = DateTimePicker1.Value.ToShortDateString()
        DataModule.telp = mtbNotelpon.Text
        DataModule.divisi = cbDivisi.Text
        DataModule.jk = GetSelectedRadioButton(grupJK)
        DataModule.hobi = GetSelectedCheckBox(grupHobi)
        DataModule.foto = pathFoto
        Dim frm As New Form2
        frm.Show()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Title = "Pilih Foto"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pathFoto = OpenFileDialog1.FileName
            picProfil.Image = Image.FromFile(pathFoto)
            picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If Not CekData() Then Exit Sub

        DataModule.nama = txtNama.Text
        DataModule.id = txtID.Text
        DataModule.tgl = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
        DataModule.telp = mtbNotelpon.Text
        DataModule.divisi = cbDivisi.Text
        DataModule.jk = GetSelectedRadioButton(grupJK)
        DataModule.hobi = GetSelectedCheckBox(grupHobi)
        DataModule.foto = pathFoto

        Dim tanya As DialogResult = MessageBox.Show("Simpan & Cetak kartu sekarang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.No Then Exit Sub

        Dim simpan As New SaveFileDialog
        simpan.Title = "Simpan Data Kartu"
        simpan.Filter = "Text File|*.txt"
        simpan.FileName = "Data_Kartu"

        If simpan.ShowDialog() = DialogResult.OK Then
            Try
                Dim isi As String =
                DataModule.nama & "|" &
                DataModule.id & "|" &
                DataModule.tgl & "|" &
                DataModule.jk & "|" &
                DataModule.divisi & "|" &
                DataModule.telp & "|" &
                txtEmail.Text & "|" &
                txtAlamat.Text & "|" &
                GetSelectedRadioButton(grupPeran) & "|" &
                DataModule.hobi & "|" &
                DataModule.foto

                IO.File.WriteAllText(simpan.FileName, isi)

                MessageBox.Show("Data berhasil disimpan!", "Sukses")

                Dim frm As New Form2
                frm.Show()

            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If Not CekData() Then Exit Sub

        If MessageBox.Show("Simpan data sekarang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"
        sfd.FileName = "Data_Kartu"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim data As String =
            txtNama.Text & "|" &
            txtID.Text & "|" &
            DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") & "|" &
            GetSelectedRadioButton(grupJK) & "|" &
            cbDivisi.Text & "|" &
            mtbNotelpon.Text & "|" &
            txtEmail.Text & "|" &
            txtAlamat.Text & "|" &
            GetSelectedRadioButton(grupPeran) & "|" &
            GetSelectedCheckBox(grupHobi) & "|" &
            pathFoto

            IO.File.WriteAllText(sfd.FileName, data)

            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim isi = IO.File.ReadAllText(ofd.FileName)
            Dim data = isi.Split("|"c)

            If data.Length >= 11 Then
                txtNama.Text = data(0)
                txtID.Text = data(1)

                Try
                    DateTimePicker1.Value = DateTime.Parse(data(2).Replace(".", ":"))
                Catch
                    Try
                        DateTimePicker1.Value = DateTime.ParseExact(data(2), "dd/MM/yyyy HH:mm:ss", Nothing)
                    Catch
                        MessageBox.Show("Format tanggal tidak valid")
                    End Try
                End Try

                If data(3) = "Laki-laki" Then
                    rbLaki.Checked = True
                Else
                    rbPerempuan.Checked = True
                End If

                cbDivisi.Text = data(4)
                mtbNotelpon.Text = data(5)
                txtEmail.Text = data(6)
                txtAlamat.Text = data(7)

                For Each rb In grupPeran
                    rb.Checked = (rb.Text = data(8))
                Next

                Dim hobiList = data(9).TrimEnd(","c).Split(","c)

                For Each cb In grupHobi
                    cb.Checked = False
                    For Each h In hobiList
                        If h.Trim <> "" AndAlso cb.Text.Trim = h.Trim Then
                            cb.Checked = True
                        End If
                    Next
                Next

                pathFoto = data(10)

                If IO.File.Exists(pathFoto) Then
                    picProfil.Image = Image.FromFile(pathFoto)
                    picProfil.SizeMode = PictureBoxSizeMode.StretchImage
                End If

                DataModule.nama = txtNama.Text
                DataModule.id = txtID.Text
                DataModule.tgl = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
                DataModule.telp = mtbNotelpon.Text
                DataModule.divisi = cbDivisi.Text
                DataModule.jk = GetSelectedRadioButton(grupJK)
                DataModule.hobi = GetSelectedCheckBox(grupHobi)
                DataModule.foto = pathFoto

                Dim frm As New Form2
                frm.Show()

            Else
                MessageBox.Show("Data tidak lengkap")
            End If
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin keluar?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
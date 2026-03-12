Public Class Form2
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblNama.Text = DataModule.nama
		lblUmur.Text = DataModule.umur
        lblTLahir.Text = DataModule.tLahir
		lblnoTelp.Text = DataModule.noTelp
		lblJK.Text = DataModule.jk
        lblHobi.Text = DataModule.Hobi
        lblAlamat.Text = DataModule.alamat
        PictureBox1.Image = Image.FromFile(DataModule.Foto)
	End Sub
End Class
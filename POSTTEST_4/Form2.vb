Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.nama
        lblID.Text = DataModule.id
        lblDivisi.Text = DataModule.divisi
        lblnoTelp.Text = DataModule.telp
        lblHobi.Text = DataModule.hobi
        lblTLahir.Text = DataModule.tgl
        lblJK.Text = DataModule.jk

        If IO.File.Exists(DataModule.foto) Then
            PictureBox1.Image = Image.FromFile(DataModule.foto)
        End If
    End Sub
End Class
Module ValidationModule
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function
    Public Function ValidasiStok(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        Dim nilai As Integer
        If Integer.TryParse(txt.Text, nilai) AndAlso nilai > 0 Then
            ep.SetError(txt, "")
            Return True
        Else
            ep.SetError(txt, pesan)
            Return False
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 OrElse cb.Text = "" Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiInput(ep As ErrorProvider, txtNama As TextBox, txtID As TextBox, txtStok As TextBox, cbJenis As ComboBox) As Boolean
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama Produk tidak boleh kosong")
        Dim idValid As Boolean = ValidasiTextBox(ep, txtID, "ID tidak boleh kosong")
        Dim stokValid As Boolean = ValidasiStok(ep, txtStok, "Stok harus lebih besar dari 0")
        Dim jenisValid As Boolean = ValidasiComboBox(ep, cbJenis, "Jenis harus dipilih")

        Return idValid And namaValid And stokValid And jenisValid
    End Function

End Module
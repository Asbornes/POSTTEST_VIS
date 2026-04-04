Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

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

    Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.SelectedIndex = -1 Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function


    Public Function ValidasiRadioButton(ep As ErrorProvider, rb1 As RadioButton, rb2 As RadioButton, pesan As String) As Boolean
        If Not rb1.Checked And Not rb2.Checked Then
            ep.SetError(rb1, pesan)
            Return False
        Else
            ep.SetError(rb1, "")
            Return True
        End If
    End Function

    Public Function ValidasiEmail(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Contains("@") And txt.Text.Contains(".") Then
            ep.SetError(txt, "")
            Return True
        Else
            ep.SetError(txt, pesan)
            Return False
        End If
    End Function

    Public Function ValidasiTanggal(ep As ErrorProvider, dtp As DateTimePicker, pesan As String) As Boolean
        If dtp.Value.Date > DateTime.Now.Date Then
            ep.SetError(dtp, pesan)
            Return False
        Else
            ep.SetError(dtp, "")
            Return True
        End If
    End Function


    Public Function ValidasiSemuaInput(
        ep As ErrorProvider,
        txtNama As TextBox,
        txtID As TextBox,
        dtp As DateTimePicker,
        rbLaki As RadioButton,
        rbPerempuan As RadioButton,
        cbDivisi As ComboBox,
        mtbNoHP As MaskedTextBox,
        txtEmail As TextBox,
        txtAlamat As TextBox
    ) As Boolean

        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Dim idValid As Boolean = ValidasiTextBox(ep, txtID, "ID tidak boleh kosong")
        Dim jkValid As Boolean = ValidasiRadioButton(ep, rbLaki, rbPerempuan, "Pilih jenis kelamin")
        Dim divisiValid As Boolean = ValidasiComboBox(ep, cbDivisi, "Pilih divisi")
        Dim noHpValid As Boolean = ValidasiMaskedTextBox(ep, mtbNoHP, "Nomor HP belum lengkap")
        Dim emailValid As Boolean = ValidasiEmail(ep, txtEmail, "Format email tidak valid")
        Dim alamatValid As Boolean = ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong")
        Dim tanggalValid As Boolean = ValidasiTanggal(ep, dtp, "Tanggal tidak valid")

        Return namaValid And idValid And jkValid And divisiValid And noHpValid And emailValid And alamatValid And tanggalValid
    End Function

End Module
Module Module1
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub tambahBuku(ByVal judul As String, ByVal Genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = Genre
            jumlahBuku += 1
        Else
            MessageBox.Show("Daftar buku sudah penuh!")
        End If
    End Sub

    Public Function hapusBuku(ByVal judul As String) As Boolean
        Dim index As Integer = -1
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0) = judul Then
                index = i
                Exit For
            End If
        Next
        If index <> -1 Then
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1
            Return True
        Else
            Return False
        End If
    End Function
End Module

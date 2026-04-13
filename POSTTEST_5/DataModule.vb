Imports MySqlConnector

Module DataModule

    Public Function GetAllProduk() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT ID, Nama, Jenis, STOK FROM tbproduk ORDER BY ID ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchProduk(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT ID, Nama, Jenis, STOK FROM tbproduk WHERE ID LIKE @keyword OR Nama LIKE @keyword ORDER BY ID ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetProdukByID(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT ID, Nama, Jenis, STOK FROM tbproduk WHERE ID = @ID"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@ID", id)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function IDSudahAda(id As Integer) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbproduk WHERE ID = @ID"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanProduk(id As Integer, nama As String, jenis As String, stok As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tbproduk (ID, Nama, Jenis, STOK) VALUES (@ID, @Nama, @Jenis, @STOK)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    cmd.Parameters.AddWithValue("@Nama", nama)
                    cmd.Parameters.AddWithValue("@Jenis", jenis)
                    cmd.Parameters.AddWithValue("@STOK", stok)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahProduk(id As Integer, nama As String, jenis As String, stok As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tbproduk SET Nama = @Nama, Jenis = @Jenis, STOK = @STOK WHERE ID = @ID"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    cmd.Parameters.AddWithValue("@Nama", nama)
                    cmd.Parameters.AddWithValue("@Jenis", jenis)
                    cmd.Parameters.AddWithValue("@STOK", stok)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusProduk(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tbproduk WHERE ID = @ID"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module
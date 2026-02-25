Public Class Form1
    Dim totalIp As Integer = 0
    Dim jumlahSemester As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        Dim ip As Double
        ip = Val(InputIP.Text)
        totalIp = totalIp + ip
        jumlahSemester += 1
        Dim ipk As Double = totalIp / jumlahSemester
        IPkumu.Text = Format(ipk, "0.00")

        If ipk >= 2.0 And ipk <= 2.75 Then
            Keterangan.Text = "Cukup"
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            Keterangan.Text = "Memuaskan"
        ElseIf ipk >= 3.01 Then
            Keterangan.Text = "Sangat Memuaskan"
        Else Keterangan.Text = "Anomali jir"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles InputIP.TextChanged

    End Sub

    Private Sub Keterangan_Click(sender As Object, e As EventArgs) Handles Keterangan.Click

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        totalIp = 0
        jumlahSemester = 0
        IPkumu.Text = "0.00"
        Keterangan.Text = "-"
    End Sub

    Private Sub IPkumu_TextChanged(sender As Object, e As EventArgs) Handles IPkumu.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


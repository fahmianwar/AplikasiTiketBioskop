Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Masuk.Click
        If _isBOF2("Select count(nama_pengguna) from Pengguna where nama_pengguna='" & Me.Kotak_Nama_Pengguna.Text & "' and kata_sandi='" & Me.Kotak_Kata_Sandi.Text & "'") = True Then
            MsgBox("Login Salah")
        ElseIf Me.Kotak_Nama_Pengguna.Text = "admin" Then
            Admin.Show()
            Me.Hide()
        Else
            Pemesanan.Nama_User.Text = _DataToValue("Select nama from Pengguna Where nama_pengguna ='" & Me.Kotak_Nama_Pengguna.Text & "'")
            Pemesanan.Kotak_Harga.Text = _DataToValue("Select harga from Harga Where no_hari =" & Pemesanan.Acuan_Waktu.Value.DayOfWeek & "")
            Pemesanan.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        Me.Close()
    End Sub

End Class

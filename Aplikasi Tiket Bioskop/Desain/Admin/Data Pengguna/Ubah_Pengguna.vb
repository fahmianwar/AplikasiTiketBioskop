Public Class Ubah_Pengguna

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _RunSQL("UPDATE Film SET no_pengguna=" & Me.Kotak_Admin_No_Pengguna.Text & ",nama_pengguna='" & Me.Kotak_Admin_Nama_Pengguna.Text & "',nama='" & Me.Kotak_Admin_Nama.Text & "',kata_sandi='" & Me.Kotak_Admin_Kata_Sandi.Text & "',akses='" & Me.Kotak_Admin_Akses.Text & "' WHERE no_pengguna=" & Me.Kotak_Admin_No_Pengguna.Text & "")
        Database._BindingView("Select * from Pengguna", Admin.Load_Data_Pengguna)
        _TxtNull(Me)
        Me.Kotak_Admin_No_Pengguna.Text = _DataToValue("SELECT MAX(no_pengguna) FROM Pengguna") + 1
        MsgBox("Sukses mengubah data", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class
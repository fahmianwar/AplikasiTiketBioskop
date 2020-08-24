Public Class Tambah_Pengguna

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _RunSQL("INSERT INTO Film VALUES(" & Me.Kotak_Admin_No_Pengguna.Text & ",'" & Me.Kotak_Admin_Nama_Pengguna.Text & "','" & Me.Kotak_Admin_Nama.Text & "','" & Me.Kotak_Admin_Kata_Sandi.Text & "','" & Me.Kotak_Admin_Akses.Text & "')")
        Database._BindingView("Select * from Pengguna", Admin.Load_Data_Pengguna)
        _TxtNull(Me)
        Me.Kotak_Admin_No_Pengguna.Text = _DataToValue("SELECT MAX(no_pengguna) FROM Pengguna") + 1
        MsgBox("Sukses menambah data", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class
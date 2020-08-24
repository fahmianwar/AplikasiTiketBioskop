Public Class Ubah_Film

    Private Sub Tombol_Ubah_Film_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Ubah_Film_Keluar.Click
        Me.Close()
    End Sub

    Private Sub Tombol_Ubah_Film_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Ubah_Film.Click
        _RunSQL("UPDATE Film SET no_film=" & Me.Kotak_Admin_No_Film.Text & ",judul_film='" & Me.Kotak_Admin_Judul_Film.Text & "',jenis_film='" & Me.Kotak_Admin_Jenis_Film.Text & "',produser='" & Me.Kotak_Admin_Produser.Text & "',sutradara='" & Me.Kotak_Admin_Sutradara.Text & "',penulis='" & Me.Kotak_Admin_Penulis.Text & "',produksi='" & Me.Kotak_Admin_Produksi.Text & "',rilis='" & Me.Kotak_Admin_Rilis.Text & "',sinopsis='" & Me.Kotak_Admin_Sinopsis.Text & "' WHERE no_film=" & Me.Kotak_Admin_No_Film.Text & "")
        Database._BindingView("Select * from Film", Admin.Load_Data_Film)
        _TxtNull(Me)
        Me.Kotak_Admin_No_Film.Text = _DataToValue("SELECT MAX(no_film) FROM Film") + 1
        MsgBox("Sukses mengubah data", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class
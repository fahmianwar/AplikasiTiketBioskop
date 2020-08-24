Public Class Hapus_Film

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Hapus_Data_Film_Ya.Click
        Dim NOMOR As Integer
        NOMOR = Ubah_Film.Kotak_Admin_No_Film.Text
        _RunSQL("DELETE FROM Film WHERE no_film=" & NOMOR & "")
        Database._BindingView("Select * from Film", Admin.Load_Data_Film)
        _TxtNull(Me)
        MsgBox("Sukses menghapus data", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
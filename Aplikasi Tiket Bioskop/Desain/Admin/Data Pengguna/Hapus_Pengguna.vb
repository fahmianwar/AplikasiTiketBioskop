Public Class Hapus_Pengguna

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NOMOR As Integer
        NOMOR = Ubah_Film.Kotak_Admin_No_Film.Text
        _RunSQL("DELETE FROM Pengguna WHERE no_pengguna=" & NOMOR & "")
        Database._BindingView("Select * from Pengguna", Admin.Load_Data_Pengguna)
        _TxtNull(Me)
        MsgBox("Sukses menghapus data", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class
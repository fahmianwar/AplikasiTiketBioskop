Public Class Hapus_Waktu

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _RunSQL("DELETE FROM Waktu_Penayangan WHERE no_waktu=" & Ubah_Waktu.Kotak_Admin_No_Waktu.Text & "")
        Database._BindingView("Select * from Waktu_Penayangan", Admin.Load_Data_Waktu)
        _TxtNull(Me)
        MsgBox("Sukses menghapus data", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
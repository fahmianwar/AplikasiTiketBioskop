Public Class Tambah_Waktu

    Private Sub Kotak_Tambah_Waktu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kotak_Tambah_Waktu.Click
        _RunSQL("INSERT INTO Waktu_Penayangan VALUES(" & Me.Kotak_Admin_No_Waktu.Text & ",'" & Me.Kotak_Admin_Waktu.Text & "')")
        Database._BindingView("Select * from Waktu_Penayangan", Admin.Load_Data_Waktu)
        _TxtNull(Me)
        Me.Kotak_Admin_No_Waktu.Text = _DataToValue("SELECT MAX(no_waktu) FROM Waktu_Penayangan") + 1
        MsgBox("Sukses menambah data", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class
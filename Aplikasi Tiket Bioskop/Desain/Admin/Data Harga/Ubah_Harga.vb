Public Class Ubah_Harga

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Tombol_Admin_Ubah_Harga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Admin_Ubah_Harga.Click
        _RunSQL("UPDATE Harga SET no_hari=" & Me.Kotak_Admin_No_Harga.Text & ",harga='" & Me.Kotak_Admin_Harga.Text & "' WHERE no_hari=" & Me.Kotak_Admin_No_Harga.Text & "")
        Database._BindingView("Select * from Film", Admin.Load_Data_Film)
        _TxtNull(Me)
        Me.Kotak_Admin_No_Harga.Text = _DataToValue("SELECT MAX(no_harga) FROM Harga") + 1
        MsgBox("Sukses mengubah data", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class
Public Class Ubah_Waktu

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _RunSQL("UPDATE Waktu_Penayangan SET no_waktu=" & Me.Kotak_Admin_No_Waktu.Text & ",waktu_penayangan='" & Me.Kotak_Admin_Waktu.Text & "' WHERE no_waktu=" & Me.Kotak_Admin_No_Waktu.Text & "")
        Database._BindingView("Select * from Pengguna", Admin.Load_Data_Pengguna)
        _TxtNull(Me)
        Me.Kotak_Admin_No_Waktu.Text = _DataToValue("SELECT MAX(no_waktu) FROM Waktu_Penayangan") + 1
        MsgBox("Sukses mengubah data", MsgBoxStyle.Information)
        Me.Close()
    End Sub
End Class
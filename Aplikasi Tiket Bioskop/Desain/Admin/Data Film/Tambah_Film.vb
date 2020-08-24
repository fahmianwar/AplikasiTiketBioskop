Public Class Tambah_Film

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        _RunSQL("INSERT INTO Film VALUES(" & Me.Kotak_Admin_No_Film.Text & ",'" & Me.Kotak_Admin_Judul_Film.Text & "','" & Me.Kotak_Admin_Jenis_Film.Text & "','" & Me.Kotak_Admin_Produser.Text & "','" & Me.Kotak_Admin_Sutradara.Text & "','" & Me.Kotak_Admin_Rilis.Text & "','" & Me.Kotak_Admin_Penulis.Text & "','" & Me.Kotak_Admin_Produksi.Text & "','" & Me.Kotak_Admin_Sinopsis.Text & "',0)")
        Database._BindingView("Select * from Film", Admin.Load_Data_Film)
        _TxtNull(Me)
        Me.Kotak_Admin_No_Film.Text = _DataToValue("SELECT MAX(no_film) FROM Film") + 1
        MsgBox("Sukses menambah data", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Kotak_Admin_No_Film.Text = _DataToValue("SELECT MAX(no_film) FROM Film") + 1
        Me.Kotak_Admin_Judul_Film.Text = ""
        Me.Kotak_Admin_Jenis_Film.Text = ""
        Me.Kotak_Admin_Produser.Text = ""
        Me.Kotak_Admin_Sutradara.Text = ""
        Me.Kotak_Admin_Penulis.Text = ""
        Me.Kotak_Admin_Produksi.Text = ""
        Me.Kotak_Admin_Sinopsis.Text = ""
        Me.Kotak_Admin_Rilis.Text = ""
    End Sub

    Private Sub Tombol_Admin_Tambah_Film_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Admin_Tambah_Film_Keluar.Click
        Me.Close()
    End Sub
End Class
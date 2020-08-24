Public Class Admin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tambah_Film.Kotak_Admin_No_Film.Text = _DataToValue("SELECT MAX(no_film) FROM Film") + 1
        Tambah_Film.Kotak_Admin_Judul_Film.Text = ""
        Tambah_Film.Kotak_Admin_Jenis_Film.Text = ""
        Tambah_Film.Kotak_Admin_Produser.Text = ""
        Tambah_Film.Kotak_Admin_Sutradara.Text = ""
        Tambah_Film.Kotak_Admin_Penulis.Text = ""
        Tambah_Film.Kotak_Admin_Produksi.Text = ""
        Tambah_Film.Kotak_Admin_Sinopsis.Text = ""
        Tambah_Film.Kotak_Admin_Rilis.Text = ""
        Tambah_Film.Show()
    End Sub
    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BioskopDataSet.Pemesanan' table. You can move, or remove it, as needed.
        Me.PemesananTableAdapter.Fill(Me.BioskopDataSet.Pemesanan)
        'TODO: This line of code loads data into the 'BioskopDataSet.Pengguna' table. You can move, or remove it, as needed.
        Me.PenggunaTableAdapter.Fill(Me.BioskopDataSet.Pengguna)
        'TODO: This line of code loads data into the 'BioskopDataSet.Harga' table. You can move, or remove it, as needed.
        Me.HargaTableAdapter.Fill(Me.BioskopDataSet.Harga)
        'TODO: This line of code loads data into the 'BioskopDataSet.Film' table. You can move, or remove it, as needed.
        Me.FilmTableAdapter.Fill(Me.BioskopDataSet.Film)
        'TODO: This line of code loads data into the 'BioskopDataSet.Penayangan' table. You can move, or remove it, as needed.
        Me.PenayanganTableAdapter.Fill(Me.BioskopDataSet.Penayangan)
        'TODO: This line of code loads data into the 'BioskopDataSet.Film' table. You can move, or remove it, as needed.
        Me.FilmTableAdapter.Fill(Me.BioskopDataSet.Film)
        'TODO: This line of code loads data into the 'BioskopDataSet.Waktu_Penayangan' table. You can move, or remove it, as needed.
        Me.Waktu_PenayanganTableAdapter.Fill(Me.BioskopDataSet.Waktu_Penayangan)

    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Load_Data_Film.CellClick
        On Error Resume Next
        Ubah_Film.Kotak_Admin_No_Film.Text = Load_Data_Film.Rows(e.RowIndex).Cells(0).Value
        Ubah_Film.Kotak_Admin_Judul_Film.Text = Load_Data_Film.Rows(e.RowIndex).Cells(1).Value
        Ubah_Film.Kotak_Admin_Jenis_Film.Text = Load_Data_Film.Rows(e.RowIndex).Cells(2).Value
        Ubah_Film.Kotak_Admin_Produser.Text = Load_Data_Film.Rows(e.RowIndex).Cells(3).Value
        Ubah_Film.Kotak_Admin_Sutradara.Text = Load_Data_Film.Rows(e.RowIndex).Cells(4).Value
        Ubah_Film.Kotak_Admin_Penulis.Text = Load_Data_Film.Rows(e.RowIndex).Cells(5).Value
        Ubah_Film.Kotak_Admin_Produksi.Text = Load_Data_Film.Rows(e.RowIndex).Cells(6).Value
        Ubah_Film.Kotak_Admin_Rilis.Text = Load_Data_Film.Rows(e.RowIndex).Cells(7).Value
        Ubah_Film.Kotak_Admin_Sinopsis.Text = Load_Data_Film.Rows(e.RowIndex).Cells(8).Value

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Ubah_Film.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Hapus_Film.Show()
    End Sub

    Private Sub Load_Data_Waktu_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Load_Data_Waktu.CellClick
        On Error Resume Next
        Ubah_Waktu.Kotak_Admin_No_Waktu.Text = Load_Data_Waktu.Rows(e.RowIndex).Cells(0).Value
        Ubah_Waktu.Kotak_Admin_Waktu.Text = Load_Data_Waktu.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub Tombol_Admin_Ubah_Waktu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Admin_Ubah_Waktu.Click
        'Dim Pisah_Waktu As String
        'Dim Pisah_Waktu_Jam As Integer
        'Dim Pisah_Waktu_Menit As Integer

        'Pisah_Waktu_Jam = _DataToValue("SELECT LEFT('30:12',2)")
        'Pisah_Waktu_Menit = _DataToValue("SELECT RIGHT('30:12',2)")
        'If Ubah_Waktu.Kotak_Admin_Waktu_Jam.Items.Count > 0 Then
        ' Ubah_Waktu.Kotak_Admin_Waktu_Jam.SelectedIndex = Pisah_Waktu_Jam
        'End If

        'If Ubah_Waktu.Kotak_Admin_Waktu_Menit.Items.Count > 0 Then
        'Ubah_Waktu.Kotak_Admin_Waktu_Menit.SelectedIndex = Pisah_Waktu_Menit
        'End If
        Ubah_Waktu.Show()

    End Sub

    Private Sub Tombol_Admin_Tambah_Waktu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Admin_Tambah_Waktu.Click
        Tambah_Waktu.Kotak_Admin_No_Waktu.Text = _DataToValue("SELECT MAX(no_waktu) FROM Waktu_Penayangan") + 1
        Tambah_Waktu.Kotak_Admin_Waktu.Text = ""
        Tambah_Waktu.Show()
    End Sub

    Private Sub Tombol_Admin_Hapus_Waktu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Admin_Hapus_Waktu.Click
        Hapus_Waktu.Show()
    End Sub
    Private Sub Tombol_Admin_Ubah_Harga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tombol_Admin_Ubah_Harga.Click
        Ubah_Harga.Show()
    End Sub
    Private Sub Load_Data_Harga_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Load_Data_Harga.CellClick
        On Error Resume Next
        Ubah_Harga.Kotak_Admin_No_Harga.Text = Load_Data_Harga.Rows(e.RowIndex).Cells(0).Value
        Ubah_Harga.Kotak_Admin_Harga.Text = Load_Data_Harga.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Tambah_Pengguna.Kotak_Admin_No_Pengguna.Text = _DataToValue("SELECT MAX(no_pengguna) FROM Pengguna") + 1
        Tambah_Pengguna.Kotak_Admin_Nama_Pengguna.Text = ""
        Tambah_Pengguna.Kotak_Admin_Nama.Text = ""
        Tambah_Pengguna.Kotak_Admin_Kata_Sandi.Text = ""
        Tambah_Pengguna.Kotak_Admin_Akses.Text = ""
        Tambah_Pengguna.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Ubah_Pengguna.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Hapus_Pengguna.Show()
    End Sub

    Private Sub Load_Data_Pengguna_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Load_Data_Pengguna.CellClick
        On Error Resume Next
        Ubah_Pengguna.Kotak_Admin_No_Pengguna.Text = Load_Data_Pengguna.Rows(e.RowIndex).Cells(0).Value
        Ubah_Pengguna.Kotak_Admin_Nama_Pengguna.Text = Load_Data_Pengguna.Rows(e.RowIndex).Cells(1).Value
        Ubah_Pengguna.Kotak_Admin_Nama.Text = Load_Data_Pengguna.Rows(e.RowIndex).Cells(2).Value
        Ubah_Pengguna.Kotak_Admin_Kata_Sandi.Text = Load_Data_Pengguna.Rows(e.RowIndex).Cells(3).Value
        Ubah_Pengguna.Kotak_Admin_Akses.Text = Load_Data_Pengguna.Rows(e.RowIndex).Cells(4).Value
    End Sub
End Class
Public Class Pemesanan
    Private Sub Label_Bersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Bersihkan.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub Pemesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BioskopDataSet.Film' table. You can move, or remove it, as needed.
        Me.FilmTableAdapter.Fill(Me.BioskopDataSet.Film)
        'TODO: This line of code loads data into the 'BioskopDataSet.Baris' table. You can move, or remove it, as needed.
        Me.BarisTableAdapter.Fill(Me.BioskopDataSet.Baris)
        'TODO: This line of code loads data into the 'BioskopDataSet.Kolom' table. You can move, or remove it, as needed.
        Me.KolomTableAdapter.Fill(Me.BioskopDataSet.Kolom)
        'TODO: This line of code loads data into the 'BioskopDataSet.Waktu_Penayangan' table. You can move, or remove it, as needed.
        Me.Waktu_PenayanganTableAdapter.Fill(Me.BioskopDataSet.Waktu_Penayangan)
        'TODO: This line of code loads data into the 'BioskopDataSet.Film' table. You can move, or remove it, as needed.
        Me.FilmTableAdapter.Fill(Me.BioskopDataSet.Film)

    End Sub

    Private Sub Kotak_Harga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kotak_Harga.TextChanged

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.BarisTableAdapter.FillBy(Me.BioskopDataSet.Baris)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.BarisTableAdapter.FillBy(Me.BioskopDataSet.Baris)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label_Pesan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_Pesan.Click
        Tiket.Hasil_Nomor.Text = Me.Acuan_Waktu.Value.Year & Me.Acuan_Waktu.Value.Month & Me.Acuan_Waktu.Value.Day & Me.Acuan_Waktu.Value.Hour
        Tiket.Hasil_Waktu.Text = Me.Kotak_Waktu.Text
        Tiket.Hasil_Posisi_Duduk.Text = Me.Kotak_Kolom.Text & Me.Kotak_Baris.Text
        Tiket.Hasil_Studio.Text = 1
        Tiket.Show()
    End Sub
End Class
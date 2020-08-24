<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pemesanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Nama_User = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Informasi = New System.Windows.Forms.GroupBox()
        Me.Tampilan = New System.Windows.Forms.PictureBox()
        Me.Kotak_Judul_Film = New System.Windows.Forms.ComboBox()
        Me.BioskopDataSet = New Aplikasi_Tiket_Bioskop.BioskopDataSet()
        Me.Kotak_Waktu = New System.Windows.Forms.ComboBox()
        Me.WaktuPenayanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kotak_Kolom = New System.Windows.Forms.ComboBox()
        Me.KolomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kotak_Baris = New System.Windows.Forms.ComboBox()
        Me.BarisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kotak_Harga = New System.Windows.Forms.TextBox()
        Me.Acuan_Waktu = New System.Windows.Forms.DateTimePicker()
        Me.Label_Pesan = New System.Windows.Forms.Button()
        Me.Label_Bersihkan = New System.Windows.Forms.Button()
        Me.Label_Judul_Film = New System.Windows.Forms.Label()
        Me.Label_Waktu = New System.Windows.Forms.Label()
        Me.Label_Posisi_Duduk = New System.Windows.Forms.Label()
        Me.Label_Harga = New System.Windows.Forms.Label()
        Me.Label_Kolom = New System.Windows.Forms.Label()
        Me.Label_Baris = New System.Windows.Forms.Label()
        Me.Label_Rupiah = New System.Windows.Forms.Label()
        Me.Waktu_PenayanganTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.Waktu_PenayanganTableAdapter()
        Me.KolomTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.KolomTableAdapter()
        Me.BarisTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.BarisTableAdapter()
        Me.BioskopDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilmTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.FilmTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Informasi.SuspendLayout()
        CType(Me.Tampilan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioskopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaktuPenayanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KolomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioskopDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nama_User
        '
        Me.Nama_User.BackColor = System.Drawing.SystemColors.Control
        Me.Nama_User.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nama_User.Location = New System.Drawing.Point(172, 12)
        Me.Nama_User.Name = "Nama_User"
        Me.Nama_User.Size = New System.Drawing.Size(100, 13)
        Me.Nama_User.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Tiket_Bioskop.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bioskop 95 - Pemesanan Tiket"
        '
        'Informasi
        '
        Me.Informasi.Controls.Add(Me.Tampilan)
        Me.Informasi.Location = New System.Drawing.Point(347, 89)
        Me.Informasi.Name = "Informasi"
        Me.Informasi.Size = New System.Drawing.Size(223, 238)
        Me.Informasi.TabIndex = 3
        Me.Informasi.TabStop = False
        Me.Informasi.Text = "Pemesanan Tiket"
        '
        'Tampilan
        '
        Me.Tampilan.Location = New System.Drawing.Point(39, 21)
        Me.Tampilan.Name = "Tampilan"
        Me.Tampilan.Size = New System.Drawing.Size(154, 196)
        Me.Tampilan.TabIndex = 0
        Me.Tampilan.TabStop = False
        '
        'Kotak_Judul_Film
        '
        Me.Kotak_Judul_Film.DataSource = Me.FilmBindingSource
        Me.Kotak_Judul_Film.DisplayMember = "judul_film"
        Me.Kotak_Judul_Film.FormattingEnabled = True
        Me.Kotak_Judul_Film.Location = New System.Drawing.Point(120, 110)
        Me.Kotak_Judul_Film.Name = "Kotak_Judul_Film"
        Me.Kotak_Judul_Film.Size = New System.Drawing.Size(221, 21)
        Me.Kotak_Judul_Film.TabIndex = 4
        Me.Kotak_Judul_Film.ValueMember = "no_film"
        '
        'BioskopDataSet
        '
        Me.BioskopDataSet.DataSetName = "BioskopDataSet"
        Me.BioskopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Kotak_Waktu
        '
        Me.Kotak_Waktu.DataSource = Me.FilmBindingSource
        Me.Kotak_Waktu.DisplayMember = "judul_film"
        Me.Kotak_Waktu.FormattingEnabled = True
        Me.Kotak_Waktu.Location = New System.Drawing.Point(120, 159)
        Me.Kotak_Waktu.Name = "Kotak_Waktu"
        Me.Kotak_Waktu.Size = New System.Drawing.Size(221, 21)
        Me.Kotak_Waktu.TabIndex = 5
        Me.Kotak_Waktu.ValueMember = "no_film"
        '
        'WaktuPenayanganBindingSource
        '
        Me.WaktuPenayanganBindingSource.DataMember = "Waktu_Penayangan"
        Me.WaktuPenayanganBindingSource.DataSource = Me.BioskopDataSet
        '
        'Kotak_Kolom
        '
        Me.Kotak_Kolom.DataSource = Me.KolomBindingSource
        Me.Kotak_Kolom.DisplayMember = "nama_kolom"
        Me.Kotak_Kolom.FormattingEnabled = True
        Me.Kotak_Kolom.Location = New System.Drawing.Point(145, 212)
        Me.Kotak_Kolom.Name = "Kotak_Kolom"
        Me.Kotak_Kolom.Size = New System.Drawing.Size(61, 21)
        Me.Kotak_Kolom.TabIndex = 6
        Me.Kotak_Kolom.ValueMember = "no_kolom"
        '
        'KolomBindingSource
        '
        Me.KolomBindingSource.DataMember = "Kolom"
        Me.KolomBindingSource.DataSource = Me.BioskopDataSet
        '
        'Kotak_Baris
        '
        Me.Kotak_Baris.DataSource = Me.BarisBindingSource
        Me.Kotak_Baris.DisplayMember = "nama_kursi"
        Me.Kotak_Baris.FormattingEnabled = True
        Me.Kotak_Baris.Location = New System.Drawing.Point(251, 212)
        Me.Kotak_Baris.Name = "Kotak_Baris"
        Me.Kotak_Baris.Size = New System.Drawing.Size(61, 21)
        Me.Kotak_Baris.TabIndex = 7
        Me.Kotak_Baris.ValueMember = "no_kursi"
        '
        'BarisBindingSource
        '
        Me.BarisBindingSource.DataMember = "Baris"
        Me.BarisBindingSource.DataSource = Me.BioskopDataSet
        '
        'Kotak_Harga
        '
        Me.Kotak_Harga.BackColor = System.Drawing.SystemColors.Control
        Me.Kotak_Harga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Kotak_Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kotak_Harga.Location = New System.Drawing.Point(145, 261)
        Me.Kotak_Harga.Name = "Kotak_Harga"
        Me.Kotak_Harga.ReadOnly = True
        Me.Kotak_Harga.Size = New System.Drawing.Size(112, 19)
        Me.Kotak_Harga.TabIndex = 8
        '
        'Acuan_Waktu
        '
        Me.Acuan_Waktu.Location = New System.Drawing.Point(431, 5)
        Me.Acuan_Waktu.Name = "Acuan_Waktu"
        Me.Acuan_Waktu.Size = New System.Drawing.Size(139, 20)
        Me.Acuan_Waktu.TabIndex = 9
        '
        'Label_Pesan
        '
        Me.Label_Pesan.Location = New System.Drawing.Point(105, 304)
        Me.Label_Pesan.Name = "Label_Pesan"
        Me.Label_Pesan.Size = New System.Drawing.Size(75, 23)
        Me.Label_Pesan.TabIndex = 10
        Me.Label_Pesan.Text = "Pesan"
        Me.Label_Pesan.UseVisualStyleBackColor = True
        '
        'Label_Bersihkan
        '
        Me.Label_Bersihkan.Location = New System.Drawing.Point(211, 304)
        Me.Label_Bersihkan.Name = "Label_Bersihkan"
        Me.Label_Bersihkan.Size = New System.Drawing.Size(75, 23)
        Me.Label_Bersihkan.TabIndex = 11
        Me.Label_Bersihkan.Text = "Keluar"
        Me.Label_Bersihkan.UseVisualStyleBackColor = True
        '
        'Label_Judul_Film
        '
        Me.Label_Judul_Film.AutoSize = True
        Me.Label_Judul_Film.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Judul_Film.Location = New System.Drawing.Point(19, 108)
        Me.Label_Judul_Film.Name = "Label_Judul_Film"
        Me.Label_Judul_Film.Size = New System.Drawing.Size(80, 20)
        Me.Label_Judul_Film.TabIndex = 12
        Me.Label_Judul_Film.Text = "Judul Film"
        '
        'Label_Waktu
        '
        Me.Label_Waktu.AutoSize = True
        Me.Label_Waktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Waktu.Location = New System.Drawing.Point(22, 162)
        Me.Label_Waktu.Name = "Label_Waktu"
        Me.Label_Waktu.Size = New System.Drawing.Size(55, 20)
        Me.Label_Waktu.TabIndex = 13
        Me.Label_Waktu.Text = "Waktu"
        '
        'Label_Posisi_Duduk
        '
        Me.Label_Posisi_Duduk.AutoSize = True
        Me.Label_Posisi_Duduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Posisi_Duduk.Location = New System.Drawing.Point(22, 213)
        Me.Label_Posisi_Duduk.Name = "Label_Posisi_Duduk"
        Me.Label_Posisi_Duduk.Size = New System.Drawing.Size(101, 20)
        Me.Label_Posisi_Duduk.TabIndex = 14
        Me.Label_Posisi_Duduk.Text = "Posisi Duduk"
        '
        'Label_Harga
        '
        Me.Label_Harga.AutoSize = True
        Me.Label_Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Harga.Location = New System.Drawing.Point(22, 259)
        Me.Label_Harga.Name = "Label_Harga"
        Me.Label_Harga.Size = New System.Drawing.Size(53, 20)
        Me.Label_Harga.TabIndex = 15
        Me.Label_Harga.Text = "Harga"
        '
        'Label_Kolom
        '
        Me.Label_Kolom.AutoSize = True
        Me.Label_Kolom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Kolom.Location = New System.Drawing.Point(153, 193)
        Me.Label_Kolom.Name = "Label_Kolom"
        Me.Label_Kolom.Size = New System.Drawing.Size(46, 16)
        Me.Label_Kolom.TabIndex = 16
        Me.Label_Kolom.Text = "Kolom"
        '
        'Label_Baris
        '
        Me.Label_Baris.AutoSize = True
        Me.Label_Baris.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Baris.Location = New System.Drawing.Point(262, 193)
        Me.Label_Baris.Name = "Label_Baris"
        Me.Label_Baris.Size = New System.Drawing.Size(39, 16)
        Me.Label_Baris.TabIndex = 17
        Me.Label_Baris.Text = "Baris"
        '
        'Label_Rupiah
        '
        Me.Label_Rupiah.AutoSize = True
        Me.Label_Rupiah.Location = New System.Drawing.Point(117, 264)
        Me.Label_Rupiah.Name = "Label_Rupiah"
        Me.Label_Rupiah.Size = New System.Drawing.Size(24, 13)
        Me.Label_Rupiah.TabIndex = 18
        Me.Label_Rupiah.Text = "Rp."
        '
        'Waktu_PenayanganTableAdapter
        '
        Me.Waktu_PenayanganTableAdapter.ClearBeforeFill = True
        '
        'KolomTableAdapter
        '
        Me.KolomTableAdapter.ClearBeforeFill = True
        '
        'BarisTableAdapter
        '
        Me.BarisTableAdapter.ClearBeforeFill = True
        '
        'BioskopDataSetBindingSource
        '
        Me.BioskopDataSetBindingSource.DataSource = Me.BioskopDataSet
        Me.BioskopDataSetBindingSource.Position = 0
        '
        'FilmBindingSource
        '
        Me.FilmBindingSource.DataMember = "Film"
        Me.FilmBindingSource.DataSource = Me.BioskopDataSet
        '
        'FilmTableAdapter
        '
        Me.FilmTableAdapter.ClearBeforeFill = True
        '
        'Pemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 347)
        Me.Controls.Add(Me.Label_Rupiah)
        Me.Controls.Add(Me.Label_Baris)
        Me.Controls.Add(Me.Label_Kolom)
        Me.Controls.Add(Me.Label_Harga)
        Me.Controls.Add(Me.Label_Posisi_Duduk)
        Me.Controls.Add(Me.Label_Waktu)
        Me.Controls.Add(Me.Label_Judul_Film)
        Me.Controls.Add(Me.Label_Bersihkan)
        Me.Controls.Add(Me.Label_Pesan)
        Me.Controls.Add(Me.Acuan_Waktu)
        Me.Controls.Add(Me.Kotak_Harga)
        Me.Controls.Add(Me.Kotak_Baris)
        Me.Controls.Add(Me.Kotak_Kolom)
        Me.Controls.Add(Me.Kotak_Waktu)
        Me.Controls.Add(Me.Kotak_Judul_Film)
        Me.Controls.Add(Me.Informasi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Nama_User)
        Me.Name = "Pemesanan"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Informasi.ResumeLayout(False)
        CType(Me.Tampilan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioskopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaktuPenayanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KolomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioskopDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nama_User As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Informasi As System.Windows.Forms.GroupBox
    Friend WithEvents Kotak_Judul_Film As System.Windows.Forms.ComboBox
    Friend WithEvents Kotak_Waktu As System.Windows.Forms.ComboBox
    Friend WithEvents Kotak_Kolom As System.Windows.Forms.ComboBox
    Friend WithEvents Kotak_Baris As System.Windows.Forms.ComboBox
    Friend WithEvents Acuan_Waktu As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_Pesan As System.Windows.Forms.Button
    Friend WithEvents Label_Bersihkan As System.Windows.Forms.Button
    Friend WithEvents Label_Judul_Film As System.Windows.Forms.Label
    Friend WithEvents Label_Waktu As System.Windows.Forms.Label
    Friend WithEvents Label_Posisi_Duduk As System.Windows.Forms.Label
    Friend WithEvents Label_Harga As System.Windows.Forms.Label
    Friend WithEvents Label_Kolom As System.Windows.Forms.Label
    Friend WithEvents Label_Baris As System.Windows.Forms.Label
    Friend WithEvents Label_Rupiah As System.Windows.Forms.Label
    Friend WithEvents BioskopDataSet As Aplikasi_Tiket_Bioskop.BioskopDataSet
    Friend WithEvents WaktuPenayanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Waktu_PenayanganTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.Waktu_PenayanganTableAdapter
    Friend WithEvents KolomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KolomTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.KolomTableAdapter
    Friend WithEvents BarisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarisTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.BarisTableAdapter
    Friend WithEvents Tampilan As System.Windows.Forms.PictureBox
    Friend WithEvents Kotak_Harga As System.Windows.Forms.TextBox
    Friend WithEvents BioskopDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FilmBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FilmTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.FilmTableAdapter
End Class

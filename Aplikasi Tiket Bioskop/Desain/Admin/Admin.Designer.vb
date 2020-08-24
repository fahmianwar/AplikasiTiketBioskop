<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tab_Admin = New System.Windows.Forms.TabControl()
        Me.Data_Film = New System.Windows.Forms.TabPage()
        Me.Load_Data_Film = New System.Windows.Forms.DataGridView()
        Me.NofilmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulfilmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisfilmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SutradaraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenulisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduksiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RilisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinopsisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BioskopDataSet = New Aplikasi_Tiket_Bioskop.BioskopDataSet()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Data_Waktu = New System.Windows.Forms.TabPage()
        Me.Tombol_Admin_Hapus_Waktu = New System.Windows.Forms.Button()
        Me.Tombol_Admin_Ubah_Waktu = New System.Windows.Forms.Button()
        Me.Tombol_Admin_Tambah_Waktu = New System.Windows.Forms.Button()
        Me.Load_Data_Waktu = New System.Windows.Forms.DataGridView()
        Me.NowaktuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktupenayanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktuPenayanganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_Harga = New System.Windows.Forms.TabPage()
        Me.Tombol_Admin_Ubah_Harga = New System.Windows.Forms.Button()
        Me.Load_Data_Harga = New System.Windows.Forms.DataGridView()
        Me.NohariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamahariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_Pengguna = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Load_Data_Pengguna = New System.Windows.Forms.DataGridView()
        Me.NopenggunaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapenggunaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KatasandiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AksesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenggunaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_Pemesanan = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.NotiketDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakasirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktupenayanganDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktupembelianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakolomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakursiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RuangstudioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NohariDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PemesananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Waktu_PenayanganTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.Waktu_PenayanganTableAdapter()
        Me.PenayanganTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.PenayanganTableAdapter()
        Me.FilmTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.FilmTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HargaTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.HargaTableAdapter()
        Me.PenggunaTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.PenggunaTableAdapter()
        Me.PemesananTableAdapter = New Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.PemesananTableAdapter()
        Me.BioskopDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilmBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tab_Admin.SuspendLayout()
        Me.Data_Film.SuspendLayout()
        CType(Me.Load_Data_Film, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioskopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data_Waktu.SuspendLayout()
        CType(Me.Load_Data_Waktu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaktuPenayanganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data_Harga.SuspendLayout()
        CType(Me.Load_Data_Harga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HargaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data_Pengguna.SuspendLayout()
        CType(Me.Load_Data_Pengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggunaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data_Pemesanan.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioskopDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bioskop 95 - Admin"
        '
        'Tab_Admin
        '
        Me.Tab_Admin.Controls.Add(Me.Data_Film)
        Me.Tab_Admin.Controls.Add(Me.Data_Waktu)
        Me.Tab_Admin.Controls.Add(Me.Data_Harga)
        Me.Tab_Admin.Controls.Add(Me.Data_Pengguna)
        Me.Tab_Admin.Controls.Add(Me.Data_Pemesanan)
        Me.Tab_Admin.Location = New System.Drawing.Point(15, 82)
        Me.Tab_Admin.Name = "Tab_Admin"
        Me.Tab_Admin.SelectedIndex = 0
        Me.Tab_Admin.Size = New System.Drawing.Size(587, 279)
        Me.Tab_Admin.TabIndex = 5
        '
        'Data_Film
        '
        Me.Data_Film.Controls.Add(Me.Load_Data_Film)
        Me.Data_Film.Controls.Add(Me.Button3)
        Me.Data_Film.Controls.Add(Me.Button2)
        Me.Data_Film.Controls.Add(Me.Button1)
        Me.Data_Film.Location = New System.Drawing.Point(4, 22)
        Me.Data_Film.Name = "Data_Film"
        Me.Data_Film.Padding = New System.Windows.Forms.Padding(3)
        Me.Data_Film.Size = New System.Drawing.Size(579, 253)
        Me.Data_Film.TabIndex = 0
        Me.Data_Film.Text = "Data Film"
        Me.Data_Film.UseVisualStyleBackColor = True
        '
        'Load_Data_Film
        '
        Me.Load_Data_Film.AllowUserToAddRows = False
        Me.Load_Data_Film.AllowUserToDeleteRows = False
        Me.Load_Data_Film.AutoGenerateColumns = False
        Me.Load_Data_Film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Load_Data_Film.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NofilmDataGridViewTextBoxColumn, Me.JudulfilmDataGridViewTextBoxColumn, Me.JenisfilmDataGridViewTextBoxColumn, Me.ProduserDataGridViewTextBoxColumn, Me.SutradaraDataGridViewTextBoxColumn, Me.PenulisDataGridViewTextBoxColumn, Me.ProduksiDataGridViewTextBoxColumn, Me.RilisDataGridViewTextBoxColumn, Me.SinopsisDataGridViewTextBoxColumn})
        Me.Load_Data_Film.DataSource = Me.FilmBindingSource
        Me.Load_Data_Film.Location = New System.Drawing.Point(2, 0)
        Me.Load_Data_Film.Name = "Load_Data_Film"
        Me.Load_Data_Film.ReadOnly = True
        Me.Load_Data_Film.Size = New System.Drawing.Size(574, 211)
        Me.Load_Data_Film.TabIndex = 4
        '
        'NofilmDataGridViewTextBoxColumn
        '
        Me.NofilmDataGridViewTextBoxColumn.DataPropertyName = "no_film"
        Me.NofilmDataGridViewTextBoxColumn.HeaderText = "No."
        Me.NofilmDataGridViewTextBoxColumn.Name = "NofilmDataGridViewTextBoxColumn"
        Me.NofilmDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JudulfilmDataGridViewTextBoxColumn
        '
        Me.JudulfilmDataGridViewTextBoxColumn.DataPropertyName = "judul_film"
        Me.JudulfilmDataGridViewTextBoxColumn.HeaderText = "Judul"
        Me.JudulfilmDataGridViewTextBoxColumn.Name = "JudulfilmDataGridViewTextBoxColumn"
        Me.JudulfilmDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JenisfilmDataGridViewTextBoxColumn
        '
        Me.JenisfilmDataGridViewTextBoxColumn.DataPropertyName = "jenis_film"
        Me.JenisfilmDataGridViewTextBoxColumn.HeaderText = "Jenis"
        Me.JenisfilmDataGridViewTextBoxColumn.Name = "JenisfilmDataGridViewTextBoxColumn"
        Me.JenisfilmDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProduserDataGridViewTextBoxColumn
        '
        Me.ProduserDataGridViewTextBoxColumn.DataPropertyName = "produser"
        Me.ProduserDataGridViewTextBoxColumn.HeaderText = "Produser"
        Me.ProduserDataGridViewTextBoxColumn.Name = "ProduserDataGridViewTextBoxColumn"
        Me.ProduserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SutradaraDataGridViewTextBoxColumn
        '
        Me.SutradaraDataGridViewTextBoxColumn.DataPropertyName = "sutradara"
        Me.SutradaraDataGridViewTextBoxColumn.HeaderText = "Sutradara"
        Me.SutradaraDataGridViewTextBoxColumn.Name = "SutradaraDataGridViewTextBoxColumn"
        Me.SutradaraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PenulisDataGridViewTextBoxColumn
        '
        Me.PenulisDataGridViewTextBoxColumn.DataPropertyName = "penulis"
        Me.PenulisDataGridViewTextBoxColumn.HeaderText = "Penulis"
        Me.PenulisDataGridViewTextBoxColumn.Name = "PenulisDataGridViewTextBoxColumn"
        Me.PenulisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProduksiDataGridViewTextBoxColumn
        '
        Me.ProduksiDataGridViewTextBoxColumn.DataPropertyName = "produksi"
        Me.ProduksiDataGridViewTextBoxColumn.HeaderText = "Produksi"
        Me.ProduksiDataGridViewTextBoxColumn.Name = "ProduksiDataGridViewTextBoxColumn"
        Me.ProduksiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RilisDataGridViewTextBoxColumn
        '
        Me.RilisDataGridViewTextBoxColumn.DataPropertyName = "rilis"
        Me.RilisDataGridViewTextBoxColumn.HeaderText = "Rilis"
        Me.RilisDataGridViewTextBoxColumn.Name = "RilisDataGridViewTextBoxColumn"
        Me.RilisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SinopsisDataGridViewTextBoxColumn
        '
        Me.SinopsisDataGridViewTextBoxColumn.DataPropertyName = "sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.HeaderText = "Sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.Name = "SinopsisDataGridViewTextBoxColumn"
        Me.SinopsisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FilmBindingSource
        '
        Me.FilmBindingSource.DataMember = "Film"
        Me.FilmBindingSource.DataSource = Me.BioskopDataSet
        '
        'BioskopDataSet
        '
        Me.BioskopDataSet.DataSetName = "BioskopDataSet"
        Me.BioskopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(191, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 27)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Hapus Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 27)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Ubah Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tambah Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Data_Waktu
        '
        Me.Data_Waktu.Controls.Add(Me.Tombol_Admin_Hapus_Waktu)
        Me.Data_Waktu.Controls.Add(Me.Tombol_Admin_Ubah_Waktu)
        Me.Data_Waktu.Controls.Add(Me.Tombol_Admin_Tambah_Waktu)
        Me.Data_Waktu.Controls.Add(Me.Load_Data_Waktu)
        Me.Data_Waktu.Location = New System.Drawing.Point(4, 22)
        Me.Data_Waktu.Name = "Data_Waktu"
        Me.Data_Waktu.Padding = New System.Windows.Forms.Padding(3)
        Me.Data_Waktu.Size = New System.Drawing.Size(579, 253)
        Me.Data_Waktu.TabIndex = 1
        Me.Data_Waktu.Text = "Data Waktu"
        Me.Data_Waktu.UseVisualStyleBackColor = True
        '
        'Tombol_Admin_Hapus_Waktu
        '
        Me.Tombol_Admin_Hapus_Waktu.Location = New System.Drawing.Point(222, 106)
        Me.Tombol_Admin_Hapus_Waktu.Name = "Tombol_Admin_Hapus_Waktu"
        Me.Tombol_Admin_Hapus_Waktu.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Admin_Hapus_Waktu.TabIndex = 3
        Me.Tombol_Admin_Hapus_Waktu.Text = "Hapus"
        Me.Tombol_Admin_Hapus_Waktu.UseVisualStyleBackColor = True
        '
        'Tombol_Admin_Ubah_Waktu
        '
        Me.Tombol_Admin_Ubah_Waktu.Location = New System.Drawing.Point(222, 63)
        Me.Tombol_Admin_Ubah_Waktu.Name = "Tombol_Admin_Ubah_Waktu"
        Me.Tombol_Admin_Ubah_Waktu.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Admin_Ubah_Waktu.TabIndex = 2
        Me.Tombol_Admin_Ubah_Waktu.Text = "Ubah"
        Me.Tombol_Admin_Ubah_Waktu.UseVisualStyleBackColor = True
        '
        'Tombol_Admin_Tambah_Waktu
        '
        Me.Tombol_Admin_Tambah_Waktu.Location = New System.Drawing.Point(222, 21)
        Me.Tombol_Admin_Tambah_Waktu.Name = "Tombol_Admin_Tambah_Waktu"
        Me.Tombol_Admin_Tambah_Waktu.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Admin_Tambah_Waktu.TabIndex = 1
        Me.Tombol_Admin_Tambah_Waktu.Text = "Tambah"
        Me.Tombol_Admin_Tambah_Waktu.UseVisualStyleBackColor = True
        '
        'Load_Data_Waktu
        '
        Me.Load_Data_Waktu.AllowUserToAddRows = False
        Me.Load_Data_Waktu.AllowUserToDeleteRows = False
        Me.Load_Data_Waktu.AutoGenerateColumns = False
        Me.Load_Data_Waktu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Load_Data_Waktu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NowaktuDataGridViewTextBoxColumn, Me.WaktupenayanganDataGridViewTextBoxColumn})
        Me.Load_Data_Waktu.DataSource = Me.WaktuPenayanganBindingSource
        Me.Load_Data_Waktu.Location = New System.Drawing.Point(0, 2)
        Me.Load_Data_Waktu.Name = "Load_Data_Waktu"
        Me.Load_Data_Waktu.ReadOnly = True
        Me.Load_Data_Waktu.Size = New System.Drawing.Size(193, 255)
        Me.Load_Data_Waktu.TabIndex = 0
        '
        'NowaktuDataGridViewTextBoxColumn
        '
        Me.NowaktuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NowaktuDataGridViewTextBoxColumn.DataPropertyName = "no_waktu"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.NowaktuDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.NowaktuDataGridViewTextBoxColumn.HeaderText = "No."
        Me.NowaktuDataGridViewTextBoxColumn.Name = "NowaktuDataGridViewTextBoxColumn"
        Me.NowaktuDataGridViewTextBoxColumn.ReadOnly = True
        Me.NowaktuDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NowaktuDataGridViewTextBoxColumn.Width = 49
        '
        'WaktupenayanganDataGridViewTextBoxColumn
        '
        Me.WaktupenayanganDataGridViewTextBoxColumn.DataPropertyName = "waktu_penayangan"
        Me.WaktupenayanganDataGridViewTextBoxColumn.HeaderText = "Waktu"
        Me.WaktupenayanganDataGridViewTextBoxColumn.Name = "WaktupenayanganDataGridViewTextBoxColumn"
        Me.WaktupenayanganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WaktuPenayanganBindingSource
        '
        Me.WaktuPenayanganBindingSource.DataMember = "Waktu_Penayangan"
        Me.WaktuPenayanganBindingSource.DataSource = Me.BioskopDataSet
        '
        'Data_Harga
        '
        Me.Data_Harga.Controls.Add(Me.Tombol_Admin_Ubah_Harga)
        Me.Data_Harga.Controls.Add(Me.Load_Data_Harga)
        Me.Data_Harga.Location = New System.Drawing.Point(4, 22)
        Me.Data_Harga.Name = "Data_Harga"
        Me.Data_Harga.Padding = New System.Windows.Forms.Padding(3)
        Me.Data_Harga.Size = New System.Drawing.Size(579, 253)
        Me.Data_Harga.TabIndex = 2
        Me.Data_Harga.Text = "Data Harga"
        Me.Data_Harga.UseVisualStyleBackColor = True
        '
        'Tombol_Admin_Ubah_Harga
        '
        Me.Tombol_Admin_Ubah_Harga.Location = New System.Drawing.Point(282, 67)
        Me.Tombol_Admin_Ubah_Harga.Name = "Tombol_Admin_Ubah_Harga"
        Me.Tombol_Admin_Ubah_Harga.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Admin_Ubah_Harga.TabIndex = 2
        Me.Tombol_Admin_Ubah_Harga.Text = "Ubah"
        Me.Tombol_Admin_Ubah_Harga.UseVisualStyleBackColor = True
        '
        'Load_Data_Harga
        '
        Me.Load_Data_Harga.AllowUserToAddRows = False
        Me.Load_Data_Harga.AllowUserToDeleteRows = False
        Me.Load_Data_Harga.AutoGenerateColumns = False
        Me.Load_Data_Harga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Load_Data_Harga.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NohariDataGridViewTextBoxColumn, Me.NamahariDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn})
        Me.Load_Data_Harga.DataSource = Me.HargaBindingSource
        Me.Load_Data_Harga.Location = New System.Drawing.Point(3, 2)
        Me.Load_Data_Harga.Name = "Load_Data_Harga"
        Me.Load_Data_Harga.ReadOnly = True
        Me.Load_Data_Harga.Size = New System.Drawing.Size(234, 250)
        Me.Load_Data_Harga.TabIndex = 0
        '
        'NohariDataGridViewTextBoxColumn
        '
        Me.NohariDataGridViewTextBoxColumn.DataPropertyName = "no_hari"
        Me.NohariDataGridViewTextBoxColumn.HeaderText = "No."
        Me.NohariDataGridViewTextBoxColumn.Name = "NohariDataGridViewTextBoxColumn"
        Me.NohariDataGridViewTextBoxColumn.ReadOnly = True
        Me.NohariDataGridViewTextBoxColumn.Width = 30
        '
        'NamahariDataGridViewTextBoxColumn
        '
        Me.NamahariDataGridViewTextBoxColumn.DataPropertyName = "nama_hari"
        Me.NamahariDataGridViewTextBoxColumn.HeaderText = "Hari"
        Me.NamahariDataGridViewTextBoxColumn.Name = "NamahariDataGridViewTextBoxColumn"
        Me.NamahariDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamahariDataGridViewTextBoxColumn.Width = 60
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaBindingSource
        '
        Me.HargaBindingSource.DataMember = "Harga"
        Me.HargaBindingSource.DataSource = Me.BioskopDataSet
        '
        'Data_Pengguna
        '
        Me.Data_Pengguna.Controls.Add(Me.Button9)
        Me.Data_Pengguna.Controls.Add(Me.Button8)
        Me.Data_Pengguna.Controls.Add(Me.Button7)
        Me.Data_Pengguna.Controls.Add(Me.Load_Data_Pengguna)
        Me.Data_Pengguna.Location = New System.Drawing.Point(4, 22)
        Me.Data_Pengguna.Name = "Data_Pengguna"
        Me.Data_Pengguna.Padding = New System.Windows.Forms.Padding(3)
        Me.Data_Pengguna.Size = New System.Drawing.Size(579, 253)
        Me.Data_Pengguna.TabIndex = 3
        Me.Data_Pengguna.Text = "Data Pengguna"
        Me.Data_Pengguna.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(207, 220)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "Hapus"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(108, 220)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Ubah"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(10, 220)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Tambah"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Load_Data_Pengguna
        '
        Me.Load_Data_Pengguna.AllowUserToAddRows = False
        Me.Load_Data_Pengguna.AllowUserToDeleteRows = False
        Me.Load_Data_Pengguna.AutoGenerateColumns = False
        Me.Load_Data_Pengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Load_Data_Pengguna.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NopenggunaDataGridViewTextBoxColumn, Me.NamapenggunaDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.KatasandiDataGridViewTextBoxColumn, Me.AksesDataGridViewTextBoxColumn})
        Me.Load_Data_Pengguna.DataSource = Me.PenggunaBindingSource
        Me.Load_Data_Pengguna.Location = New System.Drawing.Point(2, 3)
        Me.Load_Data_Pengguna.Name = "Load_Data_Pengguna"
        Me.Load_Data_Pengguna.ReadOnly = True
        Me.Load_Data_Pengguna.Size = New System.Drawing.Size(574, 207)
        Me.Load_Data_Pengguna.TabIndex = 0
        '
        'NopenggunaDataGridViewTextBoxColumn
        '
        Me.NopenggunaDataGridViewTextBoxColumn.DataPropertyName = "no_pengguna"
        Me.NopenggunaDataGridViewTextBoxColumn.HeaderText = "No."
        Me.NopenggunaDataGridViewTextBoxColumn.Name = "NopenggunaDataGridViewTextBoxColumn"
        Me.NopenggunaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NopenggunaDataGridViewTextBoxColumn.Width = 30
        '
        'NamapenggunaDataGridViewTextBoxColumn
        '
        Me.NamapenggunaDataGridViewTextBoxColumn.DataPropertyName = "nama_pengguna"
        Me.NamapenggunaDataGridViewTextBoxColumn.HeaderText = "Nama Pengguna"
        Me.NamapenggunaDataGridViewTextBoxColumn.Name = "NamapenggunaDataGridViewTextBoxColumn"
        Me.NamapenggunaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamapenggunaDataGridViewTextBoxColumn.Width = 150
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama Lengkap"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaDataGridViewTextBoxColumn.Width = 180
        '
        'KatasandiDataGridViewTextBoxColumn
        '
        Me.KatasandiDataGridViewTextBoxColumn.DataPropertyName = "kata_sandi"
        Me.KatasandiDataGridViewTextBoxColumn.HeaderText = "Kata Sandi"
        Me.KatasandiDataGridViewTextBoxColumn.Name = "KatasandiDataGridViewTextBoxColumn"
        Me.KatasandiDataGridViewTextBoxColumn.ReadOnly = True
        Me.KatasandiDataGridViewTextBoxColumn.Width = 120
        '
        'AksesDataGridViewTextBoxColumn
        '
        Me.AksesDataGridViewTextBoxColumn.DataPropertyName = "akses"
        Me.AksesDataGridViewTextBoxColumn.HeaderText = "Akses"
        Me.AksesDataGridViewTextBoxColumn.Name = "AksesDataGridViewTextBoxColumn"
        Me.AksesDataGridViewTextBoxColumn.ReadOnly = True
        Me.AksesDataGridViewTextBoxColumn.Width = 50
        '
        'PenggunaBindingSource
        '
        Me.PenggunaBindingSource.DataMember = "Pengguna"
        Me.PenggunaBindingSource.DataSource = Me.BioskopDataSet
        '
        'Data_Pemesanan
        '
        Me.Data_Pemesanan.Controls.Add(Me.DataGridView3)
        Me.Data_Pemesanan.Location = New System.Drawing.Point(4, 22)
        Me.Data_Pemesanan.Name = "Data_Pemesanan"
        Me.Data_Pemesanan.Padding = New System.Windows.Forms.Padding(3)
        Me.Data_Pemesanan.Size = New System.Drawing.Size(579, 253)
        Me.Data_Pemesanan.TabIndex = 4
        Me.Data_Pemesanan.Text = "Data Pemesanan"
        Me.Data_Pemesanan.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NotiketDataGridViewTextBoxColumn, Me.NamakasirDataGridViewTextBoxColumn, Me.WaktupenayanganDataGridViewTextBoxColumn1, Me.WaktupembelianDataGridViewTextBoxColumn, Me.NamakolomDataGridViewTextBoxColumn, Me.NamakursiDataGridViewTextBoxColumn, Me.RuangstudioDataGridViewTextBoxColumn, Me.NohariDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.PemesananBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(2, 3)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(576, 214)
        Me.DataGridView3.TabIndex = 0
        '
        'NotiketDataGridViewTextBoxColumn
        '
        Me.NotiketDataGridViewTextBoxColumn.DataPropertyName = "no_tiket"
        Me.NotiketDataGridViewTextBoxColumn.HeaderText = "No"
        Me.NotiketDataGridViewTextBoxColumn.Name = "NotiketDataGridViewTextBoxColumn"
        Me.NotiketDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotiketDataGridViewTextBoxColumn.Width = 30
        '
        'NamakasirDataGridViewTextBoxColumn
        '
        Me.NamakasirDataGridViewTextBoxColumn.DataPropertyName = "nama_kasir"
        Me.NamakasirDataGridViewTextBoxColumn.HeaderText = "Nama Kasir"
        Me.NamakasirDataGridViewTextBoxColumn.Name = "NamakasirDataGridViewTextBoxColumn"
        Me.NamakasirDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamakasirDataGridViewTextBoxColumn.Width = 60
        '
        'WaktupenayanganDataGridViewTextBoxColumn1
        '
        Me.WaktupenayanganDataGridViewTextBoxColumn1.DataPropertyName = "waktu_penayangan"
        Me.WaktupenayanganDataGridViewTextBoxColumn1.HeaderText = "Waktu Penayangan"
        Me.WaktupenayanganDataGridViewTextBoxColumn1.Name = "WaktupenayanganDataGridViewTextBoxColumn1"
        Me.WaktupenayanganDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'WaktupembelianDataGridViewTextBoxColumn
        '
        Me.WaktupembelianDataGridViewTextBoxColumn.DataPropertyName = "waktu_pembelian"
        Me.WaktupembelianDataGridViewTextBoxColumn.HeaderText = "Waktu Pembelian"
        Me.WaktupembelianDataGridViewTextBoxColumn.Name = "WaktupembelianDataGridViewTextBoxColumn"
        Me.WaktupembelianDataGridViewTextBoxColumn.ReadOnly = True
        Me.WaktupembelianDataGridViewTextBoxColumn.Width = 50
        '
        'NamakolomDataGridViewTextBoxColumn
        '
        Me.NamakolomDataGridViewTextBoxColumn.DataPropertyName = "nama_kolom"
        Me.NamakolomDataGridViewTextBoxColumn.HeaderText = "Kolom Duduk"
        Me.NamakolomDataGridViewTextBoxColumn.Name = "NamakolomDataGridViewTextBoxColumn"
        Me.NamakolomDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamakolomDataGridViewTextBoxColumn.Width = 80
        '
        'NamakursiDataGridViewTextBoxColumn
        '
        Me.NamakursiDataGridViewTextBoxColumn.DataPropertyName = "nama_kursi"
        Me.NamakursiDataGridViewTextBoxColumn.HeaderText = "Baris Duduk"
        Me.NamakursiDataGridViewTextBoxColumn.Name = "NamakursiDataGridViewTextBoxColumn"
        Me.NamakursiDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamakursiDataGridViewTextBoxColumn.Width = 80
        '
        'RuangstudioDataGridViewTextBoxColumn
        '
        Me.RuangstudioDataGridViewTextBoxColumn.DataPropertyName = "ruang_studio"
        Me.RuangstudioDataGridViewTextBoxColumn.HeaderText = "Ruang Studio"
        Me.RuangstudioDataGridViewTextBoxColumn.Name = "RuangstudioDataGridViewTextBoxColumn"
        Me.RuangstudioDataGridViewTextBoxColumn.ReadOnly = True
        Me.RuangstudioDataGridViewTextBoxColumn.Width = 80
        '
        'NohariDataGridViewTextBoxColumn1
        '
        Me.NohariDataGridViewTextBoxColumn1.DataPropertyName = "no_hari"
        Me.NohariDataGridViewTextBoxColumn1.HeaderText = "Hari Pembelian"
        Me.NohariDataGridViewTextBoxColumn1.Name = "NohariDataGridViewTextBoxColumn1"
        Me.NohariDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NohariDataGridViewTextBoxColumn1.Width = 90
        '
        'PemesananBindingSource
        '
        Me.PemesananBindingSource.DataMember = "Pemesanan"
        Me.PemesananBindingSource.DataSource = Me.BioskopDataSet
        '
        'Waktu_PenayanganTableAdapter
        '
        Me.Waktu_PenayanganTableAdapter.ClearBeforeFill = True
        '
        'PenayanganTableAdapter
        '
        Me.PenayanganTableAdapter.ClearBeforeFill = True
        '
        'FilmTableAdapter
        '
        Me.FilmTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Tiket_Bioskop.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'HargaTableAdapter
        '
        Me.HargaTableAdapter.ClearBeforeFill = True
        '
        'PenggunaTableAdapter
        '
        Me.PenggunaTableAdapter.ClearBeforeFill = True
        '
        'PemesananTableAdapter
        '
        Me.PemesananTableAdapter.ClearBeforeFill = True
        '
        'BioskopDataSetBindingSource
        '
        Me.BioskopDataSetBindingSource.DataSource = Me.BioskopDataSet
        Me.BioskopDataSetBindingSource.Position = 0
        '
        'FilmBindingSource1
        '
        Me.FilmBindingSource1.DataMember = "Film"
        Me.FilmBindingSource1.DataSource = Me.BioskopDataSetBindingSource
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 373)
        Me.Controls.Add(Me.Tab_Admin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Tab_Admin.ResumeLayout(False)
        Me.Data_Film.ResumeLayout(False)
        CType(Me.Load_Data_Film, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioskopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data_Waktu.ResumeLayout(False)
        CType(Me.Load_Data_Waktu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaktuPenayanganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data_Harga.ResumeLayout(False)
        CType(Me.Load_Data_Harga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HargaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data_Pengguna.ResumeLayout(False)
        CType(Me.Load_Data_Pengguna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggunaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data_Pemesanan.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioskopDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tab_Admin As System.Windows.Forms.TabControl
    Friend WithEvents Data_Film As System.Windows.Forms.TabPage
    Friend WithEvents Data_Waktu As System.Windows.Forms.TabPage
    Friend WithEvents Data_Harga As System.Windows.Forms.TabPage
    Friend WithEvents Data_Pengguna As System.Windows.Forms.TabPage
    Friend WithEvents Data_Pemesanan As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Load_Data_Waktu As System.Windows.Forms.DataGridView
    Friend WithEvents BioskopDataSet As Aplikasi_Tiket_Bioskop.BioskopDataSet
    Friend WithEvents WaktuPenayanganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Waktu_PenayanganTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.Waktu_PenayanganTableAdapter
    Friend WithEvents NowaktuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaktupenayanganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Load_Data_Film As System.Windows.Forms.DataGridView
    Friend WithEvents PenayanganTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.PenayanganTableAdapter
    Friend WithEvents FilmBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FilmTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.FilmTableAdapter
    Friend WithEvents Tombol_Admin_Hapus_Waktu As System.Windows.Forms.Button
    Friend WithEvents Tombol_Admin_Ubah_Waktu As System.Windows.Forms.Button
    Friend WithEvents Tombol_Admin_Tambah_Waktu As System.Windows.Forms.Button
    Friend WithEvents Load_Data_Harga As System.Windows.Forms.DataGridView
    Friend WithEvents HargaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HargaTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.HargaTableAdapter
    Friend WithEvents Tombol_Admin_Ubah_Harga As System.Windows.Forms.Button
    Friend WithEvents NohariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamahariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Load_Data_Pengguna As System.Windows.Forms.DataGridView
    Friend WithEvents PenggunaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenggunaTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.PenggunaTableAdapter
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents NopenggunaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamapenggunaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KatasandiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AksesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents PemesananBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PemesananTableAdapter As Aplikasi_Tiket_Bioskop.BioskopDataSetTableAdapters.PemesananTableAdapter
    Friend WithEvents NotiketDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamakasirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaktupenayanganDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaktupembelianDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamakolomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamakursiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RuangstudioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NohariDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilmBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BioskopDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NofilmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JudulfilmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisfilmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProduserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SutradaraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PenulisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProduksiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RilisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SinopsisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

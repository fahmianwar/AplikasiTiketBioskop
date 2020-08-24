<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubah_Film
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Kotak_Admin_No_Film = New System.Windows.Forms.TextBox()
        Me.Kotak_Admin_Judul_Film = New System.Windows.Forms.TextBox()
        Me.Kotak_Admin_Jenis_Film = New System.Windows.Forms.TextBox()
        Me.Kotak_Admin_Produser = New System.Windows.Forms.TextBox()
        Me.Kotak_Admin_Sutradara = New System.Windows.Forms.TextBox()
        Me.Kotak_Admin_Penulis = New System.Windows.Forms.TextBox()
        Me.Kotak_Admin_Produksi = New System.Windows.Forms.TextBox()
        Me.Kotak_Admin_Rilis = New System.Windows.Forms.TextBox()
        Me.Kotak_Admin_Sinopsis = New System.Windows.Forms.TextBox()
        Me.Tombol_Ubah_Film = New System.Windows.Forms.Button()
        Me.Tombol_Reset_Film = New System.Windows.Forms.Button()
        Me.Tombol_Ubah_Film_Keluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ubah Data Film"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Judul Film"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Film"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Produser"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sutradara"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Penulis"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Produksi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Rilis"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Sinopsis"
        '
        'Kotak_Admin_No_Film
        '
        Me.Kotak_Admin_No_Film.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Kotak_Admin_No_Film.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kotak_Admin_No_Film.Enabled = False
        Me.Kotak_Admin_No_Film.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kotak_Admin_No_Film.Location = New System.Drawing.Point(73, 59)
        Me.Kotak_Admin_No_Film.Name = "Kotak_Admin_No_Film"
        Me.Kotak_Admin_No_Film.Size = New System.Drawing.Size(53, 20)
        Me.Kotak_Admin_No_Film.TabIndex = 10
        Me.Kotak_Admin_No_Film.WordWrap = False
        '
        'Kotak_Admin_Judul_Film
        '
        Me.Kotak_Admin_Judul_Film.Location = New System.Drawing.Point(73, 87)
        Me.Kotak_Admin_Judul_Film.Name = "Kotak_Admin_Judul_Film"
        Me.Kotak_Admin_Judul_Film.Size = New System.Drawing.Size(180, 20)
        Me.Kotak_Admin_Judul_Film.TabIndex = 11
        '
        'Kotak_Admin_Jenis_Film
        '
        Me.Kotak_Admin_Jenis_Film.Location = New System.Drawing.Point(73, 115)
        Me.Kotak_Admin_Jenis_Film.Name = "Kotak_Admin_Jenis_Film"
        Me.Kotak_Admin_Jenis_Film.Size = New System.Drawing.Size(180, 20)
        Me.Kotak_Admin_Jenis_Film.TabIndex = 12
        '
        'Kotak_Admin_Produser
        '
        Me.Kotak_Admin_Produser.Location = New System.Drawing.Point(73, 143)
        Me.Kotak_Admin_Produser.Name = "Kotak_Admin_Produser"
        Me.Kotak_Admin_Produser.Size = New System.Drawing.Size(180, 20)
        Me.Kotak_Admin_Produser.TabIndex = 13
        '
        'Kotak_Admin_Sutradara
        '
        Me.Kotak_Admin_Sutradara.Location = New System.Drawing.Point(73, 170)
        Me.Kotak_Admin_Sutradara.Name = "Kotak_Admin_Sutradara"
        Me.Kotak_Admin_Sutradara.Size = New System.Drawing.Size(180, 20)
        Me.Kotak_Admin_Sutradara.TabIndex = 14
        '
        'Kotak_Admin_Penulis
        '
        Me.Kotak_Admin_Penulis.Location = New System.Drawing.Point(73, 197)
        Me.Kotak_Admin_Penulis.Name = "Kotak_Admin_Penulis"
        Me.Kotak_Admin_Penulis.Size = New System.Drawing.Size(180, 20)
        Me.Kotak_Admin_Penulis.TabIndex = 15
        '
        'Kotak_Admin_Produksi
        '
        Me.Kotak_Admin_Produksi.Location = New System.Drawing.Point(73, 224)
        Me.Kotak_Admin_Produksi.Name = "Kotak_Admin_Produksi"
        Me.Kotak_Admin_Produksi.Size = New System.Drawing.Size(180, 20)
        Me.Kotak_Admin_Produksi.TabIndex = 16
        '
        'Kotak_Admin_Rilis
        '
        Me.Kotak_Admin_Rilis.Location = New System.Drawing.Point(73, 252)
        Me.Kotak_Admin_Rilis.Name = "Kotak_Admin_Rilis"
        Me.Kotak_Admin_Rilis.Size = New System.Drawing.Size(180, 20)
        Me.Kotak_Admin_Rilis.TabIndex = 17
        '
        'Kotak_Admin_Sinopsis
        '
        Me.Kotak_Admin_Sinopsis.Location = New System.Drawing.Point(73, 279)
        Me.Kotak_Admin_Sinopsis.Multiline = True
        Me.Kotak_Admin_Sinopsis.Name = "Kotak_Admin_Sinopsis"
        Me.Kotak_Admin_Sinopsis.Size = New System.Drawing.Size(180, 80)
        Me.Kotak_Admin_Sinopsis.TabIndex = 18
        '
        'Tombol_Ubah_Film
        '
        Me.Tombol_Ubah_Film.Location = New System.Drawing.Point(270, 59)
        Me.Tombol_Ubah_Film.Name = "Tombol_Ubah_Film"
        Me.Tombol_Ubah_Film.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Ubah_Film.TabIndex = 19
        Me.Tombol_Ubah_Film.Text = "Ubah"
        Me.Tombol_Ubah_Film.UseVisualStyleBackColor = True
        '
        'Tombol_Reset_Film
        '
        Me.Tombol_Reset_Film.Location = New System.Drawing.Point(270, 90)
        Me.Tombol_Reset_Film.Name = "Tombol_Reset_Film"
        Me.Tombol_Reset_Film.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Reset_Film.TabIndex = 20
        Me.Tombol_Reset_Film.Text = "Bersihkan"
        Me.Tombol_Reset_Film.UseVisualStyleBackColor = True
        '
        'Tombol_Ubah_Film_Keluar
        '
        Me.Tombol_Ubah_Film_Keluar.Location = New System.Drawing.Point(270, 336)
        Me.Tombol_Ubah_Film_Keluar.Name = "Tombol_Ubah_Film_Keluar"
        Me.Tombol_Ubah_Film_Keluar.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Ubah_Film_Keluar.TabIndex = 21
        Me.Tombol_Ubah_Film_Keluar.Text = "Keluar"
        Me.Tombol_Ubah_Film_Keluar.UseVisualStyleBackColor = True
        '
        'Ubah_Film
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 371)
        Me.Controls.Add(Me.Tombol_Ubah_Film_Keluar)
        Me.Controls.Add(Me.Tombol_Reset_Film)
        Me.Controls.Add(Me.Tombol_Ubah_Film)
        Me.Controls.Add(Me.Kotak_Admin_Sinopsis)
        Me.Controls.Add(Me.Kotak_Admin_Rilis)
        Me.Controls.Add(Me.Kotak_Admin_Produksi)
        Me.Controls.Add(Me.Kotak_Admin_Penulis)
        Me.Controls.Add(Me.Kotak_Admin_Sutradara)
        Me.Controls.Add(Me.Kotak_Admin_Produser)
        Me.Controls.Add(Me.Kotak_Admin_Jenis_Film)
        Me.Controls.Add(Me.Kotak_Admin_Judul_Film)
        Me.Controls.Add(Me.Kotak_Admin_No_Film)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ubah_Film"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Kotak_Admin_No_Film As System.Windows.Forms.TextBox
    Friend WithEvents Kotak_Admin_Judul_Film As System.Windows.Forms.TextBox
    Friend WithEvents Kotak_Admin_Jenis_Film As System.Windows.Forms.TextBox
    Friend WithEvents Kotak_Admin_Produser As System.Windows.Forms.TextBox
    Friend WithEvents Kotak_Admin_Sutradara As System.Windows.Forms.TextBox
    Friend WithEvents Kotak_Admin_Penulis As System.Windows.Forms.TextBox
    Friend WithEvents Kotak_Admin_Produksi As System.Windows.Forms.TextBox
    Friend WithEvents Kotak_Admin_Rilis As System.Windows.Forms.TextBox
    Friend WithEvents Kotak_Admin_Sinopsis As System.Windows.Forms.TextBox
    Friend WithEvents Tombol_Ubah_Film As System.Windows.Forms.Button
    Friend WithEvents Tombol_Reset_Film As System.Windows.Forms.Button
    Friend WithEvents Tombol_Ubah_Film_Keluar As System.Windows.Forms.Button
End Class

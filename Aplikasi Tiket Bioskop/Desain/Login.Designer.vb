<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents Logo_Pembukaan As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents Kotak_Nama_Pengguna As System.Windows.Forms.TextBox
    Friend WithEvents Kotak_Kata_Sandi As System.Windows.Forms.TextBox
    Friend WithEvents Masuk As System.Windows.Forms.Button
    Friend WithEvents Keluar As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Logo_Pembukaan = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Kotak_Nama_Pengguna = New System.Windows.Forms.TextBox()
        Me.Kotak_Kata_Sandi = New System.Windows.Forms.TextBox()
        Me.Masuk = New System.Windows.Forms.Button()
        Me.Keluar = New System.Windows.Forms.Button()
        CType(Me.Logo_Pembukaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo_Pembukaan
        '
        Me.Logo_Pembukaan.Image = Global.Aplikasi_Tiket_Bioskop.My.Resources.Resources.logo
        Me.Logo_Pembukaan.Location = New System.Drawing.Point(0, 0)
        Me.Logo_Pembukaan.Name = "Logo_Pembukaan"
        Me.Logo_Pembukaan.Size = New System.Drawing.Size(165, 193)
        Me.Logo_Pembukaan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_Pembukaan.TabIndex = 0
        Me.Logo_Pembukaan.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 24)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nama Pengguna"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 81)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Kata Sandi"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Kotak_Nama_Pengguna
        '
        Me.Kotak_Nama_Pengguna.Location = New System.Drawing.Point(174, 44)
        Me.Kotak_Nama_Pengguna.Name = "Kotak_Nama_Pengguna"
        Me.Kotak_Nama_Pengguna.Size = New System.Drawing.Size(220, 20)
        Me.Kotak_Nama_Pengguna.TabIndex = 1
        '
        'Kotak_Kata_Sandi
        '
        Me.Kotak_Kata_Sandi.Location = New System.Drawing.Point(174, 101)
        Me.Kotak_Kata_Sandi.Name = "Kotak_Kata_Sandi"
        Me.Kotak_Kata_Sandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Kotak_Kata_Sandi.Size = New System.Drawing.Size(220, 20)
        Me.Kotak_Kata_Sandi.TabIndex = 3
        '
        'Masuk
        '
        Me.Masuk.Location = New System.Drawing.Point(197, 161)
        Me.Masuk.Name = "Masuk"
        Me.Masuk.Size = New System.Drawing.Size(94, 23)
        Me.Masuk.TabIndex = 4
        Me.Masuk.Text = "&Masuk"
        '
        'Keluar
        '
        Me.Keluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Keluar.Location = New System.Drawing.Point(300, 161)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(94, 23)
        Me.Keluar.TabIndex = 5
        Me.Keluar.Text = "&Keluar"
        '
        'Login
        '
        Me.AcceptButton = Me.Masuk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Keluar
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.Keluar)
        Me.Controls.Add(Me.Masuk)
        Me.Controls.Add(Me.Kotak_Kata_Sandi)
        Me.Controls.Add(Me.Kotak_Nama_Pengguna)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Logo_Pembukaan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bioskop 95 - Login"
        CType(Me.Logo_Pembukaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class

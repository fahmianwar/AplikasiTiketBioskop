<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubah_Harga
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
        Me.Kotak_Admin_No_Harga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tombol_Admin_Ubah_Harga = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label_Ubah_Data_Harga = New System.Windows.Forms.Label()
        Me.Kotak_Admin_Harga = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Kotak_Admin_No_Harga
        '
        Me.Kotak_Admin_No_Harga.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Kotak_Admin_No_Harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kotak_Admin_No_Harga.Location = New System.Drawing.Point(87, 72)
        Me.Kotak_Admin_No_Harga.Name = "Kotak_Admin_No_Harga"
        Me.Kotak_Admin_No_Harga.Size = New System.Drawing.Size(100, 20)
        Me.Kotak_Admin_No_Harga.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Harga"
        '
        'Tombol_Admin_Ubah_Harga
        '
        Me.Tombol_Admin_Ubah_Harga.Location = New System.Drawing.Point(27, 165)
        Me.Tombol_Admin_Ubah_Harga.Name = "Tombol_Admin_Ubah_Harga"
        Me.Tombol_Admin_Ubah_Harga.Size = New System.Drawing.Size(75, 23)
        Me.Tombol_Admin_Ubah_Harga.TabIndex = 4
        Me.Tombol_Admin_Ubah_Harga.Text = "Ubah"
        Me.Tombol_Admin_Ubah_Harga.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(147, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label_Ubah_Data_Harga
        '
        Me.Label_Ubah_Data_Harga.AutoSize = True
        Me.Label_Ubah_Data_Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Ubah_Data_Harga.Location = New System.Drawing.Point(12, 9)
        Me.Label_Ubah_Data_Harga.Name = "Label_Ubah_Data_Harga"
        Me.Label_Ubah_Data_Harga.Size = New System.Drawing.Size(193, 25)
        Me.Label_Ubah_Data_Harga.TabIndex = 8
        Me.Label_Ubah_Data_Harga.Text = "Ubah Data Harga"
        '
        'Kotak_Admin_Harga
        '
        Me.Kotak_Admin_Harga.Location = New System.Drawing.Point(87, 107)
        Me.Kotak_Admin_Harga.Name = "Kotak_Admin_Harga"
        Me.Kotak_Admin_Harga.Size = New System.Drawing.Size(100, 20)
        Me.Kotak_Admin_Harga.TabIndex = 9
        '
        'Ubah_Harga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 217)
        Me.Controls.Add(Me.Kotak_Admin_Harga)
        Me.Controls.Add(Me.Label_Ubah_Data_Harga)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Tombol_Admin_Ubah_Harga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Kotak_Admin_No_Harga)
        Me.Name = "Ubah_Harga"
        Me.Text = "Bioskop 95 - Tambah Data Waktu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kotak_Admin_No_Harga As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tombol_Admin_Ubah_Harga As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label_Ubah_Data_Harga As System.Windows.Forms.Label
    Friend WithEvents Kotak_Admin_Harga As System.Windows.Forms.TextBox
End Class

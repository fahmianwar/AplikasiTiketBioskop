<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Waktu
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
        Me.Kotak_Admin_No_Waktu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Kotak_Tambah_Waktu = New System.Windows.Forms.Button()
        Me.Kotak_Batal_Waktu = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Kotak_Admin_Waktu = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Kotak_Admin_No_Waktu
        '
        Me.Kotak_Admin_No_Waktu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Kotak_Admin_No_Waktu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kotak_Admin_No_Waktu.Enabled = False
        Me.Kotak_Admin_No_Waktu.Location = New System.Drawing.Point(87, 72)
        Me.Kotak_Admin_No_Waktu.Name = "Kotak_Admin_No_Waktu"
        Me.Kotak_Admin_No_Waktu.Size = New System.Drawing.Size(61, 20)
        Me.Kotak_Admin_No_Waktu.TabIndex = 0
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
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Waktu"
        '
        'Kotak_Tambah_Waktu
        '
        Me.Kotak_Tambah_Waktu.Location = New System.Drawing.Point(27, 165)
        Me.Kotak_Tambah_Waktu.Name = "Kotak_Tambah_Waktu"
        Me.Kotak_Tambah_Waktu.Size = New System.Drawing.Size(75, 23)
        Me.Kotak_Tambah_Waktu.TabIndex = 4
        Me.Kotak_Tambah_Waktu.Text = "Buat"
        Me.Kotak_Tambah_Waktu.UseVisualStyleBackColor = True
        '
        'Kotak_Batal_Waktu
        '
        Me.Kotak_Batal_Waktu.Location = New System.Drawing.Point(147, 165)
        Me.Kotak_Batal_Waktu.Name = "Kotak_Batal_Waktu"
        Me.Kotak_Batal_Waktu.Size = New System.Drawing.Size(75, 23)
        Me.Kotak_Batal_Waktu.TabIndex = 5
        Me.Kotak_Batal_Waktu.Text = "Batal"
        Me.Kotak_Batal_Waktu.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tambah Data"
        '
        'Kotak_Admin_Waktu
        '
        Me.Kotak_Admin_Waktu.Location = New System.Drawing.Point(87, 110)
        Me.Kotak_Admin_Waktu.Name = "Kotak_Admin_Waktu"
        Me.Kotak_Admin_Waktu.Size = New System.Drawing.Size(61, 20)
        Me.Kotak_Admin_Waktu.TabIndex = 9
        '
        'Tambah_Waktu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 217)
        Me.Controls.Add(Me.Kotak_Admin_Waktu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Kotak_Batal_Waktu)
        Me.Controls.Add(Me.Kotak_Tambah_Waktu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Kotak_Admin_No_Waktu)
        Me.Name = "Tambah_Waktu"
        Me.Text = "Bioskop 95 - Tambah Data Waktu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kotak_Admin_No_Waktu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Kotak_Tambah_Waktu As System.Windows.Forms.Button
    Friend WithEvents Kotak_Batal_Waktu As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Kotak_Admin_Waktu As System.Windows.Forms.TextBox
End Class

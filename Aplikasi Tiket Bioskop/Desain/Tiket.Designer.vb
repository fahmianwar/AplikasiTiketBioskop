<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tiket
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Hasil_Nomor = New System.Windows.Forms.TextBox()
        Me.Hasil_Waktu = New System.Windows.Forms.TextBox()
        Me.Hasil_Studio = New System.Windows.Forms.TextBox()
        Me.Hasil_Posisi_Duduk = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nomor Pesanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Studio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Waktu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Posisi Duduk"
        '
        'Hasil_Nomor
        '
        Me.Hasil_Nomor.BackColor = System.Drawing.SystemColors.Control
        Me.Hasil_Nomor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Hasil_Nomor.Location = New System.Drawing.Point(27, 40)
        Me.Hasil_Nomor.Name = "Hasil_Nomor"
        Me.Hasil_Nomor.Size = New System.Drawing.Size(69, 13)
        Me.Hasil_Nomor.TabIndex = 5
        '
        'Hasil_Waktu
        '
        Me.Hasil_Waktu.BackColor = System.Drawing.SystemColors.Control
        Me.Hasil_Waktu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Hasil_Waktu.Location = New System.Drawing.Point(210, 40)
        Me.Hasil_Waktu.Name = "Hasil_Waktu"
        Me.Hasil_Waktu.Size = New System.Drawing.Size(69, 13)
        Me.Hasil_Waktu.TabIndex = 6
        '
        'Hasil_Studio
        '
        Me.Hasil_Studio.BackColor = System.Drawing.SystemColors.Control
        Me.Hasil_Studio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Hasil_Studio.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasil_Studio.Location = New System.Drawing.Point(27, 81)
        Me.Hasil_Studio.Name = "Hasil_Studio"
        Me.Hasil_Studio.Size = New System.Drawing.Size(69, 73)
        Me.Hasil_Studio.TabIndex = 7
        '
        'Hasil_Posisi_Duduk
        '
        Me.Hasil_Posisi_Duduk.BackColor = System.Drawing.SystemColors.Control
        Me.Hasil_Posisi_Duduk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Hasil_Posisi_Duduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasil_Posisi_Duduk.Location = New System.Drawing.Point(210, 81)
        Me.Hasil_Posisi_Duduk.Name = "Hasil_Posisi_Duduk"
        Me.Hasil_Posisi_Duduk.Size = New System.Drawing.Size(69, 31)
        Me.Hasil_Posisi_Duduk.TabIndex = 8
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Tiket"
        '
        'Tiket
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.Hasil_Posisi_Duduk)
        Me.Controls.Add(Me.Hasil_Studio)
        Me.Controls.Add(Me.Hasil_Waktu)
        Me.Controls.Add(Me.Hasil_Nomor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tiket"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bioskop 95 - Tiket"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Hasil_Nomor As System.Windows.Forms.TextBox
    Friend WithEvents Hasil_Waktu As System.Windows.Forms.TextBox
    Friend WithEvents Hasil_Studio As System.Windows.Forms.TextBox
    Friend WithEvents Hasil_Posisi_Duduk As System.Windows.Forms.TextBox

End Class

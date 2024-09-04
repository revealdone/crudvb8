<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tnim = New System.Windows.Forms.TextBox()
        Me.talamat = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.rpria = New System.Windows.Forms.RadioButton()
        Me.rwanita = New System.Windows.Forms.RadioButton()
        Me.cprodi = New System.Windows.Forms.ComboBox()
        Me.bkosongkan = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bkeluar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nim :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Program Studi :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat  :"
        '
        'tnim
        '
        Me.tnim.Location = New System.Drawing.Point(147, 32)
        Me.tnim.Name = "tnim"
        Me.tnim.Size = New System.Drawing.Size(148, 24)
        Me.tnim.TabIndex = 5
        '
        'talamat
        '
        Me.talamat.Location = New System.Drawing.Point(147, 187)
        Me.talamat.Multiline = True
        Me.talamat.Name = "talamat"
        Me.talamat.Size = New System.Drawing.Size(331, 88)
        Me.talamat.TabIndex = 6
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(147, 72)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(331, 24)
        Me.tnama.TabIndex = 7
        '
        'rpria
        '
        Me.rpria.AutoSize = True
        Me.rpria.Location = New System.Drawing.Point(147, 114)
        Me.rpria.Name = "rpria"
        Me.rpria.Size = New System.Drawing.Size(52, 22)
        Me.rpria.TabIndex = 8
        Me.rpria.TabStop = True
        Me.rpria.Text = "Pria"
        Me.rpria.UseVisualStyleBackColor = True
        '
        'rwanita
        '
        Me.rwanita.AutoSize = True
        Me.rwanita.Location = New System.Drawing.Point(220, 114)
        Me.rwanita.Name = "rwanita"
        Me.rwanita.Size = New System.Drawing.Size(72, 22)
        Me.rwanita.TabIndex = 9
        Me.rwanita.TabStop = True
        Me.rwanita.Text = "Wanita"
        Me.rwanita.UseVisualStyleBackColor = True
        '
        'cprodi
        '
        Me.cprodi.FormattingEnabled = True
        Me.cprodi.Items.AddRange(New Object() {"S1- Sistem Informasi", "S1- Teknik Informatika", "S1- Manajemen Informatika"})
        Me.cprodi.Location = New System.Drawing.Point(147, 150)
        Me.cprodi.Name = "cprodi"
        Me.cprodi.Size = New System.Drawing.Size(148, 26)
        Me.cprodi.TabIndex = 10
        '
        'bkosongkan
        '
        Me.bkosongkan.Location = New System.Drawing.Point(38, 307)
        Me.bkosongkan.Name = "bkosongkan"
        Me.bkosongkan.Size = New System.Drawing.Size(98, 29)
        Me.bkosongkan.TabIndex = 11
        Me.bkosongkan.Text = "kosongkan"
        Me.bkosongkan.UseVisualStyleBackColor = True
        '
        'bsimpan
        '
        Me.bsimpan.Location = New System.Drawing.Point(147, 307)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(98, 29)
        Me.bsimpan.TabIndex = 12
        Me.bsimpan.Text = "simpan"
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'bhapus
        '
        Me.bhapus.Location = New System.Drawing.Point(262, 307)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(98, 29)
        Me.bhapus.TabIndex = 13
        Me.bhapus.Text = "hapus"
        Me.bhapus.UseVisualStyleBackColor = True
        '
        'bkeluar
        '
        Me.bkeluar.Location = New System.Drawing.Point(380, 307)
        Me.bkeluar.Name = "bkeluar"
        Me.bkeluar.Size = New System.Drawing.Size(98, 29)
        Me.bkeluar.TabIndex = 14
        Me.bkeluar.Text = "keluar"
        Me.bkeluar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DGV.Location = New System.Drawing.Point(15, 353)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(518, 218)
        Me.DGV.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nim"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "jekel"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Prodi"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Alamat"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 583)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.bkeluar)
        Me.Controls.Add(Me.bhapus)
        Me.Controls.Add(Me.bsimpan)
        Me.Controls.Add(Me.bkosongkan)
        Me.Controls.Add(Me.cprodi)
        Me.Controls.Add(Me.rwanita)
        Me.Controls.Add(Me.rpria)
        Me.Controls.Add(Me.tnama)
        Me.Controls.Add(Me.talamat)
        Me.Controls.Add(Me.tnim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form Data Mahasiswa"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tnim As TextBox
    Friend WithEvents talamat As TextBox
    Friend WithEvents tnama As TextBox
    Friend WithEvents rpria As RadioButton
    Friend WithEvents rwanita As RadioButton
    Friend WithEvents cprodi As ComboBox
    Friend WithEvents bkosongkan As Button
    Friend WithEvents bsimpan As Button
    Friend WithEvents bhapus As Button
    Friend WithEvents bkeluar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class

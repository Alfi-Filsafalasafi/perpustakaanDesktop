<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_pinjam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tambah_pinjam))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel_teks = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_cari_buku = New System.Windows.Forms.Button()
        Me.txt_ket = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.txt_tgl_kembali = New System.Windows.Forms.DateTimePicker()
        Me.txt_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.Panel_teks.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(187, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAMBAH PINJAM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(708, 96)
        Me.Panel1.TabIndex = 2
        '
        'Panel_teks
        '
        Me.Panel_teks.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel_teks.Controls.Add(Me.txt_tgl_kembali)
        Me.Panel_teks.Controls.Add(Me.txt_tanggal)
        Me.Panel_teks.Controls.Add(Me.Button1)
        Me.Panel_teks.Controls.Add(Me.btn_cari_buku)
        Me.Panel_teks.Controls.Add(Me.txt_ket)
        Me.Panel_teks.Controls.Add(Me.Label6)
        Me.Panel_teks.Controls.Add(Me.Label5)
        Me.Panel_teks.Controls.Add(Me.txt_jumlah)
        Me.Panel_teks.Controls.Add(Me.Label4)
        Me.Panel_teks.Controls.Add(Me.txt_kode)
        Me.Panel_teks.Controls.Add(Me.Label3)
        Me.Panel_teks.Controls.Add(Me.txt_id)
        Me.Panel_teks.Controls.Add(Me.Label2)
        Me.Panel_teks.Location = New System.Drawing.Point(53, 146)
        Me.Panel_teks.Name = "Panel_teks"
        Me.Panel_teks.Size = New System.Drawing.Size(605, 421)
        Me.Panel_teks.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(506, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 36)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "...."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_cari_buku
        '
        Me.btn_cari_buku.Location = New System.Drawing.Point(506, 93)
        Me.btn_cari_buku.Name = "btn_cari_buku"
        Me.btn_cari_buku.Size = New System.Drawing.Size(70, 36)
        Me.btn_cari_buku.TabIndex = 10
        Me.btn_cari_buku.Text = "...."
        Me.btn_cari_buku.UseVisualStyleBackColor = True
        '
        'txt_ket
        '
        Me.txt_ket.Location = New System.Drawing.Point(147, 337)
        Me.txt_ket.Multiline = True
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.Size = New System.Drawing.Size(429, 53)
        Me.txt_ket.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Keterangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tgl Pinjam"
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(147, 182)
        Me.txt_jumlah.Multiline = True
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(429, 49)
        Me.txt_jumlah.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jumlah"
        '
        'txt_kode
        '
        Me.txt_kode.Location = New System.Drawing.Point(147, 93)
        Me.txt_kode.Multiline = True
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(353, 36)
        Me.txt_kode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Buku"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(147, 33)
        Me.txt_id.Multiline = True
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(353, 36)
        Me.txt_id.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Siswa"
        '
        'btn_batal
        '
        Me.btn_batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_batal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.Image = CType(resources.GetObject("btn_batal.Image"), System.Drawing.Image)
        Me.btn_batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_batal.Location = New System.Drawing.Point(575, 627)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(83, 45)
        Me.btn_batal.TabIndex = 39
        Me.btn_batal.Text = "        Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tambah.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah.Image = CType(resources.GetObject("btn_tambah.Image"), System.Drawing.Image)
        Me.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tambah.Location = New System.Drawing.Point(457, 627)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(83, 45)
        Me.btn_tambah.TabIndex = 40
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'txt_tgl_kembali
        '
        Me.txt_tgl_kembali.Location = New System.Drawing.Point(147, 280)
        Me.txt_tgl_kembali.Name = "txt_tgl_kembali"
        Me.txt_tgl_kembali.Size = New System.Drawing.Size(429, 20)
        Me.txt_tgl_kembali.TabIndex = 16
        Me.txt_tgl_kembali.Visible = False
        '
        'txt_tanggal
        '
        Me.txt_tanggal.Location = New System.Drawing.Point(147, 254)
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.Size = New System.Drawing.Size(429, 20)
        Me.txt_tanggal.TabIndex = 15
        '
        'tambah_pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 749)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.Panel_teks)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "tambah_pinjam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tambah_pinjam"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_teks.ResumeLayout(False)
        Me.Panel_teks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_teks As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_cari_buku As System.Windows.Forms.Button
    Friend WithEvents txt_ket As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_kode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents txt_tgl_kembali As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_tanggal As System.Windows.Forms.DateTimePicker
End Class

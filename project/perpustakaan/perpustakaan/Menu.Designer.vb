<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_histori_pengembalian = New System.Windows.Forms.Button()
        Me.btn_laporan_peminjam = New System.Windows.Forms.Button()
        Me.btn_data_pengembalian = New System.Windows.Forms.Button()
        Me.btn_data_peminjam = New System.Windows.Forms.Button()
        Me.btn_daftar_petugas = New System.Windows.Forms.Button()
        Me.btn_daftar_anggota = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnsdatabuku = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.CausesValidation = False
        Me.Panel4.Enabled = False
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(21, 113)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 4)
        Me.Panel4.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(29, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMKN 1 PURWOSARI"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.btn_logout)
        Me.Panel2.Controls.Add(Me.btn_histori_pengembalian)
        Me.Panel2.Controls.Add(Me.btn_laporan_peminjam)
        Me.Panel2.Controls.Add(Me.btn_data_pengembalian)
        Me.Panel2.Controls.Add(Me.btn_data_peminjam)
        Me.Panel2.Controls.Add(Me.btn_daftar_petugas)
        Me.Panel2.Controls.Add(Me.btn_daftar_anggota)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnsdatabuku)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 1190)
        Me.Panel2.TabIndex = 39
        '
        'btn_logout
        '
        Me.btn_logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_logout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.Location = New System.Drawing.Point(18, 415)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(114, 38)
        Me.btn_logout.TabIndex = 46
        Me.btn_logout.Text = "   Log Out"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_histori_pengembalian
        '
        Me.btn_histori_pengembalian.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_histori_pengembalian.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_histori_pengembalian.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_histori_pengembalian.FlatAppearance.BorderSize = 0
        Me.btn_histori_pengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_histori_pengembalian.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_histori_pengembalian.ForeColor = System.Drawing.Color.White
        Me.btn_histori_pengembalian.Image = CType(resources.GetObject("btn_histori_pengembalian.Image"), System.Drawing.Image)
        Me.btn_histori_pengembalian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_histori_pengembalian.Location = New System.Drawing.Point(15, 376)
        Me.btn_histori_pengembalian.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_histori_pengembalian.Name = "btn_histori_pengembalian"
        Me.btn_histori_pengembalian.Size = New System.Drawing.Size(214, 38)
        Me.btn_histori_pengembalian.TabIndex = 45
        Me.btn_histori_pengembalian.Text = "   History  Pengembalian"
        Me.btn_histori_pengembalian.UseVisualStyleBackColor = False
        '
        'btn_laporan_peminjam
        '
        Me.btn_laporan_peminjam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_laporan_peminjam.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_laporan_peminjam.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_laporan_peminjam.FlatAppearance.BorderSize = 0
        Me.btn_laporan_peminjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_laporan_peminjam.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_laporan_peminjam.ForeColor = System.Drawing.Color.White
        Me.btn_laporan_peminjam.Image = CType(resources.GetObject("btn_laporan_peminjam.Image"), System.Drawing.Image)
        Me.btn_laporan_peminjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_laporan_peminjam.Location = New System.Drawing.Point(18, 335)
        Me.btn_laporan_peminjam.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_laporan_peminjam.Name = "btn_laporan_peminjam"
        Me.btn_laporan_peminjam.Size = New System.Drawing.Size(211, 38)
        Me.btn_laporan_peminjam.TabIndex = 44
        Me.btn_laporan_peminjam.Text = "   Laporan  Peminjaman"
        Me.btn_laporan_peminjam.UseVisualStyleBackColor = False
        '
        'btn_data_pengembalian
        '
        Me.btn_data_pengembalian.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_data_pengembalian.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_data_pengembalian.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_data_pengembalian.FlatAppearance.BorderSize = 0
        Me.btn_data_pengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_data_pengembalian.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_data_pengembalian.ForeColor = System.Drawing.Color.White
        Me.btn_data_pengembalian.Image = CType(resources.GetObject("btn_data_pengembalian.Image"), System.Drawing.Image)
        Me.btn_data_pengembalian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_data_pengembalian.Location = New System.Drawing.Point(16, 296)
        Me.btn_data_pengembalian.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_data_pengembalian.Name = "btn_data_pengembalian"
        Me.btn_data_pengembalian.Size = New System.Drawing.Size(208, 38)
        Me.btn_data_pengembalian.TabIndex = 43
        Me.btn_data_pengembalian.Text = "   Data  Pengembalian"
        Me.btn_data_pengembalian.UseVisualStyleBackColor = False
        '
        'btn_data_peminjam
        '
        Me.btn_data_peminjam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_data_peminjam.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_data_peminjam.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_data_peminjam.FlatAppearance.BorderSize = 0
        Me.btn_data_peminjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_data_peminjam.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_data_peminjam.ForeColor = System.Drawing.Color.White
        Me.btn_data_peminjam.Image = CType(resources.GetObject("btn_data_peminjam.Image"), System.Drawing.Image)
        Me.btn_data_peminjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_data_peminjam.Location = New System.Drawing.Point(16, 258)
        Me.btn_data_peminjam.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_data_peminjam.Name = "btn_data_peminjam"
        Me.btn_data_peminjam.Size = New System.Drawing.Size(192, 38)
        Me.btn_data_peminjam.TabIndex = 43
        Me.btn_data_peminjam.Text = "   Data  Peminjaman"
        Me.btn_data_peminjam.UseVisualStyleBackColor = False
        '
        'btn_daftar_petugas
        '
        Me.btn_daftar_petugas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_daftar_petugas.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_daftar_petugas.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_daftar_petugas.FlatAppearance.BorderSize = 0
        Me.btn_daftar_petugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_daftar_petugas.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_daftar_petugas.ForeColor = System.Drawing.Color.White
        Me.btn_daftar_petugas.Image = CType(resources.GetObject("btn_daftar_petugas.Image"), System.Drawing.Image)
        Me.btn_daftar_petugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_daftar_petugas.Location = New System.Drawing.Point(15, 221)
        Me.btn_daftar_petugas.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_daftar_petugas.Name = "btn_daftar_petugas"
        Me.btn_daftar_petugas.Size = New System.Drawing.Size(168, 38)
        Me.btn_daftar_petugas.TabIndex = 43
        Me.btn_daftar_petugas.Text = "    Daftar Petugas"
        Me.btn_daftar_petugas.UseVisualStyleBackColor = False
        '
        'btn_daftar_anggota
        '
        Me.btn_daftar_anggota.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_daftar_anggota.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_daftar_anggota.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btn_daftar_anggota.FlatAppearance.BorderSize = 0
        Me.btn_daftar_anggota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_daftar_anggota.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_daftar_anggota.ForeColor = System.Drawing.Color.White
        Me.btn_daftar_anggota.Image = CType(resources.GetObject("btn_daftar_anggota.Image"), System.Drawing.Image)
        Me.btn_daftar_anggota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_daftar_anggota.Location = New System.Drawing.Point(15, 184)
        Me.btn_daftar_anggota.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_daftar_anggota.Name = "btn_daftar_anggota"
        Me.btn_daftar_anggota.Size = New System.Drawing.Size(174, 38)
        Me.btn_daftar_anggota.TabIndex = 41
        Me.btn_daftar_anggota.Text = "   Daftar Anggota"
        Me.btn_daftar_anggota.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(69, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnsdatabuku
        '
        Me.btnsdatabuku.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnsdatabuku.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnsdatabuku.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnsdatabuku.FlatAppearance.BorderSize = 0
        Me.btnsdatabuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsdatabuku.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsdatabuku.ForeColor = System.Drawing.Color.White
        Me.btnsdatabuku.Image = CType(resources.GetObject("btnsdatabuku.Image"), System.Drawing.Image)
        Me.btnsdatabuku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsdatabuku.Location = New System.Drawing.Point(15, 146)
        Me.btnsdatabuku.Margin = New System.Windows.Forms.Padding(6)
        Me.btnsdatabuku.Name = "btnsdatabuku"
        Me.btnsdatabuku.Size = New System.Drawing.Size(147, 38)
        Me.btnsdatabuku.TabIndex = 40
        Me.btnsdatabuku.Text = "   Data  Buku"
        Me.btnsdatabuku.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(388, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(739, 495)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(674, 554)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(248, 67)
        Me.lbl_time.TabIndex = 42
        Me.lbl_time.Text = "08.45 AM"
        '
        'lbl_nama
        '
        Me.lbl_nama.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(269, 456)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(975, 67)
        Me.lbl_nama.TabIndex = 43
        Me.lbl_nama.Text = "Selamat Datang ,"
        Me.lbl_nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1256, 687)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Dashboard"
        Me.Text = "Menu"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnsdatabuku As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents btn_histori_pengembalian As System.Windows.Forms.Button
    Friend WithEvents btn_laporan_peminjam As System.Windows.Forms.Button
    Friend WithEvents btn_data_pengembalian As System.Windows.Forms.Button
    Friend WithEvents btn_data_peminjam As System.Windows.Forms.Button
    Friend WithEvents btn_daftar_petugas As System.Windows.Forms.Button
    Friend WithEvents btn_daftar_anggota As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

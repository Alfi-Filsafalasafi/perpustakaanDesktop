Public Class form_history
    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_peminjaman ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_pinjam)
            lv_menu.Items(i).SubItems.Add(reader!kode_buku)
            lv_menu.Items(i).SubItems.Add(reader!nama_lengkap)
            lv_menu.Items(i).SubItems.Add(reader!judul)
            lv_menu.Items(i).SubItems.Add(reader!jumlah)
            lv_menu.Items(i).SubItems.Add(reader!tgl_pinjam)
            lv_menu.Items(i).SubItems.Add(reader!tgl_kembali)
            lv_menu.Items(i).SubItems.Add(reader!keterangan)
            i = i + +1
        Loop
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        tampildata()
        txt_cari_buku.Text = ""
        txt_cari_pinjam.Text = ""
    End Sub

    Private Sub form_history_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_cari_pinjam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari_pinjam.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_peminjaman where nama_lengkap LIKE '%" & txt_cari_pinjam.Text & "%' ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_pinjam)
            lv_menu.Items(i).SubItems.Add(reader!kode_buku)
            lv_menu.Items(i).SubItems.Add(reader!nama_lengkap)
            lv_menu.Items(i).SubItems.Add(reader!judul)
            lv_menu.Items(i).SubItems.Add(reader!jumlah)
            lv_menu.Items(i).SubItems.Add(reader!tgl_pinjam)
            lv_menu.Items(i).SubItems.Add(reader!tgl_kembali)
            lv_menu.Items(i).SubItems.Add(reader!keterangan)
            i = i + +1
        Loop
    End Sub

    Private Sub txt_cari_buku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari_buku.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_peminjaman where judul LIKE '%" & txt_cari_buku.Text & "%' ", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_pinjam)
            lv_menu.Items(i).SubItems.Add(reader!kode_buku)
            lv_menu.Items(i).SubItems.Add(reader!nama_lengkap)
            lv_menu.Items(i).SubItems.Add(reader!judul)
            lv_menu.Items(i).SubItems.Add(reader!jumlah)
            lv_menu.Items(i).SubItems.Add(reader!tgl_pinjam)
            lv_menu.Items(i).SubItems.Add(reader!tgl_kembali)
            lv_menu.Items(i).SubItems.Add(reader!keterangan)
            i = i + +1
        Loop
    End Sub
    Private Sub histori_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
    End Sub
End Class
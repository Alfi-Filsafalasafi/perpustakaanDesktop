Public Class daftar_peminjam
    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_peminjaman where keterangan = 'baru pinjam'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_pinjam)
            lv_menu.Items(i).SubItems.Add(reader!nama_lengkap)
            lv_menu.Items(i).SubItems.Add(reader!kelas)
            lv_menu.Items(i).SubItems.Add(reader!kode_buku)
            lv_menu.Items(i).SubItems.Add(reader!jumlah)
            lv_menu.Items(i).SubItems.Add(reader!tgl_pinjam)
            lv_menu.Items(i).SubItems.Add(reader!keterangan)
            i = i + +1
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tambah_pinjam.Show()
    End Sub

    Private Sub daftar_peminjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub daftar_peminjam_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
    End Sub
End Class
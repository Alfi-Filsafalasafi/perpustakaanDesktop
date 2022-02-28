Public Class daftar_pengembalian
    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_peminjaman where keterangan = 'Baru Pinjam'", koneksi)
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
    Sub bersihteks()
        txt_id_buku.Text = ""
        txt_judul.Text = ""
        txt_jumlah.Text = ""
        txt_tgl_pinjam.Text = ""
        txt_tgl_kembali.Text = ""
        txt_id_pinjam.Text = Date.Now
        txt_nama.Text = Date.Now
    End Sub
    Private Sub daftar_pengembalian_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
    End Sub

    Private Sub lv_menu_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_peminjaman where id_pinjam = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id_pinjam.Text = reader!id_pinjam
            txt_nama.Text = reader!nama_lengkap
            txt_judul.Text = reader!judul
            txt_jumlah.Text = reader!jumlah
            txt_tgl_pinjam.Text = reader!tgl_pinjam
            txt_tgl_kembali.Text = reader!tgl_kembali
            txt_id_buku.Text = reader!kode_buku
        Loop
    End Sub

    Private Sub txt_cari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_peminjaman where nama_lengkap LIKE '%" & txt_cari.Text & "%' and where keterangan = 'Baru Pinjam'", koneksi)
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

    Private Sub txt_tgl_kembali_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_tgl_kembali.ValueChanged
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select datediff(day,'" & Format(txt_tgl_kembali.Value, "yyyy-MM-dd") & "','" & Format(Date.Now, "yyyy-MM-dd") & "') as denda", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_denda.Text = reader!denda * 1000
            If txt_denda.Text < 0 Then
                txt_denda.Text = 0
            End If
        Loop
    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        tampildata()

        bersihteks()
    End Sub

    Private Sub btn_kembalikan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kembalikan.Click
        konek_db()
        Dim ubah As New SqlClient.SqlCommand("update tbl_peminjaman set keterangan  = 'sudah kembali' where id_pinjam = '" & txt_id_pinjam.Text & "' ", koneksi)
        Try
            ubah.ExecuteNonQuery()
            MsgBox("data berhasi dikembalikan", MsgBoxStyle.Information)
            bersihteks()
            tampildata()
        Catch ex As Exception
            MsgBox("data gagal di kembalikan karena" + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
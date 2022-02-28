Public Class daftar_buku
    Dim aksi As String
    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_buku", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!kode_buku)
            lv_menu.Items(i).SubItems.Add(reader!judul)
            lv_menu.Items(i).SubItems.Add(reader!kategori)
            lv_menu.Items(i).SubItems.Add(reader!penulis)
            lv_menu.Items(i).SubItems.Add(reader!penerbit)
            lv_menu.Items(i).SubItems.Add(reader!stok)
            lv_menu.Items(i).SubItems.Add(reader!nama_rak)
            i = i + +1
        Loop
    End Sub
    Sub aksesteks(ByVal akses As Boolean)
        panel_teks.Enabled = akses

    End Sub
    Sub buttonawal()
        btn_tambah.Enabled = True
        btn_edit.Enabled = False
        btn_simpan.Enabled = False
        btn_batal.Enabled = False
        btn_hapus.Enabled = False
    End Sub

    Sub bersihteks()
        txt_kode.Text = ""
        txt_judul.Text = ""
        txt_penulis.Text = ""
        txt_penerbit.Text = ""
        txt_kategori.Text = ""
        txt_stok.Text = ""
        txt_koderak.Text = ""
    End Sub
    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        aksi = "T"

        aksesteks(True)
        btn_tambah.Enabled = False
        btn_edit.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        aksi = "E"

        aksesteks(True)
        btn_tambah.Enabled = False
        btn_edit.Enabled = False
        btn_simpan.Enabled = True
        btn_hapus.Enabled = False
        btn_batal.Enabled = True
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        konek_db()
        Dim hapus As New SqlClient.SqlCommand("delete from tbl_buku where kode_buku = '" & txt_kode.Text & "'", koneksi)
        Try
            hapus.ExecuteNonQuery()
            MsgBox("data berhasil di hapus", MsgBoxStyle.Information)

            tampildata()
            buttonawal()
            aksesteks(False)
            bersihteks()
        Catch ex As Exception
            MsgBox("data gagal di hapus  " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        tampildata()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        If aksi = "T" Then
            konek_db()
            Dim tambah As New SqlClient.SqlCommand("insert into tbl_buku values ( '" & txt_judul.Text & "', '" & txt_penulis.Text & "', '" & txt_penerbit.Text &
                                                   "', '" & txt_kategori.Text & "', '" & txt_stok.Text & "', '" & txt_koderak.Text & "')", koneksi)
            Try
                tambah.ExecuteNonQuery()
                MsgBox("data berhasil di tambah", MsgBoxStyle.Information)
                buttonawal()
                bersihteks()
                tampildata()
                aksesteks(False)
            Catch ex As Exception
                MsgBox("data gagal di tambah karena  " + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        If aksi = "E" Then
            konek_db()
            Dim ubah As New SqlClient.SqlCommand("update tbl_buku set judul = '" & txt_judul.Text & "', penulis= '" & txt_penulis.Text & "', penerbit = '" & txt_penerbit.Text &
                                                 "', kategori = '" & txt_kategori.Text & "', stok = '" & txt_stok.Text & "', kode_rak = '" & txt_koderak.Text & "' where kode_buku = '" & txt_kode.Text & "'", koneksi)
            Try
                ubah.ExecuteNonQuery()
                MsgBox("data berhasil di ubah", MsgBoxStyle.Information)
                buttonawal()
                bersihteks()
                tampildata()
                aksesteks(False)
            Catch ex As Exception
                MsgBox("data gagal di edit  " + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    Private Sub form_admin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        aksesteks(False)
        buttonawal()
        tampildata()
    End Sub
    Private Sub lv_menu_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from tbl_buku where kode_buku = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_kode.Text = reader!kode_buku
            txt_judul.Text = reader!judul
            txt_kategori.Text = reader!kategori
            txt_penulis.Text = reader!penulis
            txt_penerbit.Text = reader!penerbit
            txt_stok.Text = reader!stok
            txt_koderak.Text = reader!kode_rak
        Loop
        btn_tambah.Enabled = False
        btn_edit.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
        btn_batal.Enabled = True
    End Sub

    Private Sub txt_cari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from v_buku where judul LIKE '%" & txt_cari.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!kode_buku)
            lv_menu.Items(i).SubItems.Add(reader!judul)
            lv_menu.Items(i).SubItems.Add(reader!kategori)
            lv_menu.Items(i).SubItems.Add(reader!penulis)
            lv_menu.Items(i).SubItems.Add(reader!penerbit)
            lv_menu.Items(i).SubItems.Add(reader!stok)
            lv_menu.Items(i).SubItems.Add(reader!nama_rak)
            i = i + +1
        Loop
    End Sub
    Private Sub btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pilih.Click
        If txt_kode.Text = "" Then
            MsgBox("pilih data terlebih dahulu", MsgBoxStyle.Information)
        Else
            tambah_pinjam.txt_kode.Text = txt_kode.Text
            Me.Close()
        End If
    End Sub
End Class
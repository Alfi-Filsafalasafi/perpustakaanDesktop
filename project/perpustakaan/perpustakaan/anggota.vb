Public Class anggota
    Dim aksi As String
    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from tbl_siswa", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_siswa)
            lv_menu.Items(i).SubItems.Add(reader!nama_lengkap)
            lv_menu.Items(i).SubItems.Add(reader!gender)
            lv_menu.Items(i).SubItems.Add(reader!kelas)
            lv_menu.Items(i).SubItems.Add(reader!Alamat)
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
        txt_id.Text = ""
        txt_alamat.Text = ""
        txt_gender.Text = ""
        txt_nama.Text = ""
        txt_pass.Text = ""
        txt_kelas.Text = ""
        txt_user.Text = ""
    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

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
        Dim hapus As New SqlClient.SqlCommand("delete from tbl_siswa where id_siswa = '" & txt_id.Text & "'", koneksi)
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
            Dim tambah As New SqlClient.SqlCommand("insert into tbl_siswa values ( '" & txt_nama.Text & "', '" & txt_gender.Text & "', '" & txt_user.Text &
                                                   "', '" & txt_pass.Text & "', '" & txt_kelas.Text & "', '" & txt_alamat.Text & "')", koneksi)
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
            Dim ubah As New SqlClient.SqlCommand("update tbl_siswa set nama_lengkap = '" & txt_nama.Text & "', gender= '" & txt_gender.Text & "', username = '" & txt_user.Text &
                                                 "', password = '" & txt_pass.Text & "', kelas = '" & txt_kelas.Text & "', Alamat = '" & txt_alamat.Text & "' where id_siswa = '" & txt_id.Text & "'", koneksi)
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

    Private Sub txt_cari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cari.TextChanged
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from tbl_siswa where nama_lengkap LIKE '%" & txt_cari.Text & "%'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_siswa)
            lv_menu.Items(i).SubItems.Add(reader!nama_lengkap)
            lv_menu.Items(i).SubItems.Add(reader!gender)
            lv_menu.Items(i).SubItems.Add(reader!kelas)
            lv_menu.Items(i).SubItems.Add(reader!Alamat)
            i = i + +1
        Loop
    End Sub

    Private Sub anggota_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        aksesteks(False)
        buttonawal()
        tampildata()
    End Sub

    Private Sub lv_menu_MouseClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_menu.MouseClick
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from tbl_siswa where id_siswa = '" & lv_menu.SelectedItems(0).SubItems(0).Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Do While reader.Read
            txt_id.Text = reader!id_siswa
            txt_nama.Text = reader!nama_lengkap
            txt_gender.Text = reader!gender
            txt_alamat.Text = reader!Alamat
            txt_kelas.Text = reader!kelas
            txt_user.Text = reader!username
            txt_pass.Text = reader!password
        Loop
        btn_tambah.Enabled = False
        btn_edit.Enabled = True
        btn_simpan.Enabled = False
        btn_hapus.Enabled = True
        btn_batal.Enabled = True
    End Sub

    Private Sub btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pilih.Click
        If txt_id.Text = "" Then
            MsgBox("pilih data terlebih dahulu", MsgBoxStyle.Information)
        Else
            tambah_pinjam.txt_id.Text = txt_id.Text
            Me.Close()
        End If
    End Sub

    Private Sub anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
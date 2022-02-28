Public Class from_admin
    Dim aksi As String
    Sub tampildata()
        lv_menu.Items.Clear()
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("select * from tbl_admin", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        Dim i As Integer = 0
        Do While reader.Read
            lv_menu.Items.Add(reader!id_admin)
            lv_menu.Items(i).SubItems.Add(reader!nama)
            lv_menu.Items(i).SubItems.Add(reader!gender)
            lv_menu.Items(i).SubItems.Add(reader!no_telepon)
            lv_menu.Items(i).SubItems.Add(reader!alamat)
            i = i + +1
        Loop
    End Sub
    Sub aksesteks(ByVal akses As Boolean)
        panel_teks.Enabled = akses
        Panel_userpass.Enabled = akses

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
        txt_password.Text = ""
        txt_notelpn.Text = ""
        txt_username.Text = ""
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
        Dim hapus As New SqlClient.SqlCommand("delete from tbl_admin where id_admin = '" & txt_id.Text & "'", koneksi)
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
            Dim tambah As New SqlClient.SqlCommand("insert into tbl_admin values ( '" & txt_nama.Text & "', '" & txt_username.Text & "', '" & txt_password.Text &
                                                   "', '" & txt_gender.Text & "', '" & txt_alamat.Text & "', '" & txt_notelpn.Text & "')", koneksi)
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
            Dim ubah As New SqlClient.SqlCommand("update tbl_admin set nama = '" & txt_nama.Text & "', username= '" & txt_username.Text & "', password = '" & txt_password.Text &
                                                 "', gender = '" & txt_gender.Text & "', alamat = '" & txt_alamat.Text & "', no_telp = '" & txt_notelpn.Text & "' where id_admin = '" & txt_id.Text & "'", koneksi)
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

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_laki.CheckedChanged
        If ck_laki.CheckState = CheckState.Checked Then
            txt_gender.Text = "L"
            ck_perempuan.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub txt_gender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_gender.TextChanged
        If txt_gender.Text = "P" Then
            ck_perempuan.CheckState = CheckState.Checked
        End If
        If txt_gender.Text = "L" Then
            ck_laki.CheckState = CheckState.Checked
        End If
        If txt_gender.Text = "" Then
            ck_laki.CheckState = CheckState.Unchecked
            ck_perempuan.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub from_admin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        tampildata()
        buttonawal()
        bersihteks()
        aksesteks(False)
    End Sub
    Private Sub ck_perempuan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_perempuan.CheckedChanged
        If ck_perempuan.CheckState = CheckState.Checked Then
            txt_gender.Text = "P"
            ck_laki.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub Panel_teks_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel_teks.Paint

    End Sub
End Class
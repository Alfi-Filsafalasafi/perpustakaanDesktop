Public Class tambah_pinjam

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        konek_db()


        Dim tambah As New SqlClient.SqlCommand("insert into tbl_peminjaman values ( '" & txt_id.Text & "', '" & txt_kode.Text & "', '" & txt_jumlah.Text &
                                                   "', '" & Format(txt_tanggal.Value, "yyyy-MM-dd") & "', '" & txt_ket.Text & "', '" & Format(txt_tgl_kembali.Value, "yyyy-MM-dd") & "','')", koneksi)
        Try
            tambah.ExecuteNonQuery()
            MsgBox("data berhasil di pinjam", MsgBoxStyle.Information)
            daftar_peminjaman.tampildata()
        Catch ex As Exception
            MsgBox("Data gagal di pinjam karena " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        anggota.Show()
    End Sub

    Private Sub btn_cari_buku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_buku.Click
        daftar_buku.Show()
    End Sub

    Private Sub tambah_pinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_batal.Click
        Me.Close()
    End Sub
    Private Sub tambah_pinjam_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        konek_db()
        Dim tgl_kembali As New SqlClient.SqlCommand("select DateAdd(day,7, '" & Format(txt_tanggal.Value, "yyyy-MM-dd") & "') as tgl", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tgl_kembali.ExecuteReader
        Do While reader.Read
            txt_tgl_kembali.Text = reader!tgl
        Loop
    End Sub
End Class
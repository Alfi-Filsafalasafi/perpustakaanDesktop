Public Class Dashboard

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        lbl_time.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsdatabuku.Click
        daftar_buku.Show()
    End Sub

    Private Sub btn_daftar_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_daftar_anggota.Click
        anggota.Show()
    End Sub

    Private Sub btn_daftar_petugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_daftar_petugas.Click
        from_admin.Show()
    End Sub

    Private Sub btn_data_peminjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_data_peminjam.Click
        daftar_peminjam.Show()
    End Sub

    Private Sub btn_data_pengembalian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_data_pengembalian.Click
        daftar_pengembalian.Show()
    End Sub

    Private Sub btn_laporan_peminjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_laporan_peminjam.Click
        laporan_peminjaman.Show()
    End Sub

    Private Sub btn_histori_pengembalian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_histori_pengembalian.Click
        histori.Show()
    End Sub

  

    Private Sub btn_logout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        Dim mssag As Integer
        mssag = MsgBox("apakah anda yakin akan kluar ? ", MsgBoxStyle.YesNo)
        If mssag = DialogResult.Yes Then
            Me.Close()
            login.Visible = True
        End If
    End Sub

    Private Sub Dashboard_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
   
            login.Visible = True

    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
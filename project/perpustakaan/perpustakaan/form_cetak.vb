Public Class Form_cetak

    Private Sub Form_cetak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek_db()
        Dim report_peminjamana = New report_peminjamana
        Dim tampil As New SqlClient.SqlCommand("select * from v_history_real", koneksi)
        Dim reader As SqlClient.SqlDataReader
        Dim data As New DataTable
        reader = tampil.ExecuteReader
        data.Load(reader)
        report_peminjamana.SetDataSource(data)
        Me.report_peminjamanku.ReportSource = report_peminjamana
    End Sub
End Class
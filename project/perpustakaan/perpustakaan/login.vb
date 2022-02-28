Public Class login
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        konek_db()
        Dim tampil As New SqlClient.SqlCommand("Select * from tbl_admin where username = '" & txt_user.Text & "' and password = '" & txt_pass.Text & "'", koneksi)
        Dim reader As SqlClient.SqlDataReader
        reader = tampil.ExecuteReader
        reader.Read()
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
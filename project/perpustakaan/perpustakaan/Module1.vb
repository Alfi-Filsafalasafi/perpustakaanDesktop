
Imports System.Data.SqlClient
Module Module1
    Public koneksi As SqlConnection = Nothing
    Public Sub konek_db()

        Dim server As String
        server = "server = DESKTOP-NCIA0RI\SQLEXPRESS; database = perpustakaan; integrated security = true"
        koneksi = New SqlConnection(server)
        koneksi.Open()
    End Sub
End Module

Imports System.Data
Imports System.Data.OleDb

Module Modulekoneksi
    Public Conn As New OleDbConnection
    Public Sql As String
    Sub konek()
        Dim connString As String
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DbKamar.accdb"
        Try
            Conn.ConnectionString = connString
            Conn.Open()
        Catch ex As Exception
            MsgBox("Tidak Terhubung Ke Database,silahkan cek:" & ex.Message)
        End Try
    End Sub

End Module

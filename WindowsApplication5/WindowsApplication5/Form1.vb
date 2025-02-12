Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isi()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Conn.State = ConnectionState.Closed Then
                konek()
            End If
            Sql = "SELECT*FROM DbKamar"
            Dim cmd As New OleDbCommand(Sql, Conn)
            Dim rs As OleDbDataReader
            rs = cmd.ExecuteReader
            Dim itung As Integer = 0
            While rs.Read
                Dim baris0 As New ListViewItem
                With baris0
                    .Text = rs("No")
                    .SubItems.Add(rs("Nama"))
                    .SubItems.Add(rs("Alamat"))
                End With
                ListView1.Items.Add(baris0)
            End While
            rs.Close()
            cmd.Dispose()
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub isi()
        With ListView1
            .Columns.Add("No", 40, HorizontalAlignment.Center)
            .Columns.Add("Nama", 200, HorizontalAlignment.Center)
            .Columns.Add("Alamat", 200, HorizontalAlignment.Center)
            .GridLines = True
            .View = View.Details
            .FullRowSelect = True
        End With
    End Sub
End Class

Imports System.Data.OleDb
Public Class Form1
    Dim Conn As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim Ds As DataSet
    Dim LokasiDB As String
    Sub Koneksi()
        LokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Visual Studio 2010\VBNET\WindowsApplication1\WindowsApplication1\bin\Debug\DbApalah.accdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OleDbDataAdapter("Select * from TBL_UJI", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "TBL_UJI")
        DataGridView1.DataSource = (Ds.Tables("TBL_UJI"))
    End Sub
End Class

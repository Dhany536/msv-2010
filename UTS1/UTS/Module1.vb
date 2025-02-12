Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    Public rd As OleDbDataReader
    Public bs As BindingSource
    Public LokasiDB As String
    Public Sub koneksi()
        LokasiDB = "provider=microsoft.ACE.oledb.12.0;data source=C:\Users\LK1-11\Documents\zul\UTS\UTS\bin\Debug\Database1.accdb"
        conn = New OleDbConnection(LokasiDB)
        conn.Open()
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module
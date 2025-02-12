Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Sub Kosongkan()
        a.Text = ""
        b.Text = ""
        c.Text = ""
        d.Text = ""
        k.Text = ""
        f.Text = ""
        g.Text = ""
        h.Text = ""
        CB1.Text = ""
    End Sub
    Sub databaru()
        b.Text = ""
        c.Text = ""
        d.Text = ""
        k.Text = ""
        f.Text = ""
        g.Text = ""
        h.Text = ""
        CB1.Text = ""
        b.Focus()
    End Sub
    Sub tutup()
        a.Enabled = False
        b.Enabled = False
        c.Enabled = False
        d.Enabled = False
        k.Enabled = False
        f.Enabled = False
        g.Enabled = False
        h.Enabled = False
        CB1.Enabled = False
    End Sub
    Sub buka()
        a.Enabled = True
        b.Enabled = True
        c.Enabled = True
        d.Enabled = True
        k.Enabled = True
        f.Enabled = True
        g.Enabled = True
        h.Enabled = True
        CB1.Enabled = True
    End Sub
    Private Sub Tampildata()
        da = New OleDbDataAdapter("select * from Peminjam", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Peminjam")
        DG.DataSource = (ds.Tables("Peminjam"))
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        da = New OleDbDataAdapter("select * from Peminjam", conn)
        ds.Clear()
        da.Fill(ds, "Peminjam")
        DG.DataSource = (ds.Tables("Peminjam"))
        Call Tampildata()
        Call tutup()
        Button1.Focus()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles b.KeyPress
        b.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            c.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles c.KeyPress
        c.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            d.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles d.KeyPress
        d.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            k.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles k.KeyPress
        k.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            f.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles k.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles f.KeyPress
        f.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            g.Focus()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call buka()
        Call Kosongkan()
        Button2.Enabled = True
        a.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If a.Text = "" Or b.Text = "" Or c.Text = "" Or d.Text = "" Or k.Text = "" Or f.Text = "" Or g.Text = "" Or CB1.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call koneksi()
            Dim dm1 As New OleDbCommand
            dm1.Connection = conn
            dm1.CommandType = CommandType.Text
            dm1.CommandText = "insert into Peminjam values ('" & a.Text & "','" & b.Text & "','" & c.Text & "','" & d.Text & "','" & k.Text & "','" & f.Text & "','" & g.Text & "','" & CB1.Text & "','" & h.Text & "')"
            dm1.ExecuteNonQuery()
            MsgBox("input data Peminjam telah berhasil disimpan !!!")
            Call Tampildata()
            Button1.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If a.Text = "" Then
            MsgBox("Isi Identitas Motor yang akan di hapus !!!")
            a.Focus()
            Exit Sub
        Else
            If MessageBox.Show("yakin akan menghapus data motor ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Peminjam where plnomor='" & a.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampildata()
            Else
                Call Kosongkan()
            End If

        End If
    End Sub

    Private Sub a_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles a.KeyPress
        a.MaxLength = 20
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("Select * from Peminjam where plnomor='" & a.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Data Sudah Pernah ada!!!")
                    b.Text = rd.GetString(1)
                    c.Text = rd.GetString(2)
                    d.Text = rd.GetString(3)
                    k.Text = rd.GetString(4)
                    f.Text = rd.GetString(5)
                    g.Text = rd.GetValue(6)
                    h.Text = rd.GetValue(7)
                    Call tutup()
                    a.Enabled = True
                Else
                    Call databaru()
                    b.Focus()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.TextChanged

    End Sub

    Private Sub g_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub g_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles g.KeyPress
        g.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            h.Focus()
        End If
    End Sub

    Private Sub g_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g.TextChanged

    End Sub
End Class
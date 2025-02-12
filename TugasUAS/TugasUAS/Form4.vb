Imports System.Data
Imports System.Data.OleDb
Public Class Form4
    Public xstock As Integer
    Sub Kosongkan()
        a.Text = ""
        b.Text = ""
        c.Text = ""
        d.Text = ""
        f.Text = ""
        g.Text = ""
        h.Text = ""
        cb1.Text = ""
        cb2.Text = ""
    End Sub
    Sub databaru()
        b.Text = ""
        c.Text = ""
        d.Text = ""
        f.Text = ""
        g.Text = ""
        h.Text = ""
        cb1.Text = ""
        cb2.Text = ""
        b.Focus()
    End Sub
    Sub tampilnama()
        cmd = New OleDbCommand("Select * from Identitas", conn)
        rd = cmd.ExecuteReader
        cb1.Items.Clear()
        Do While rd.Read
            cb1.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub caridatanama()
        cb1.MaxLength = 10
        cmd = New OleDbCommand("Select * from Identitas where nomorid = '" & cb1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            c.Text = rd.Item("namapj")
            d.Text = rd.Item("telepon")
        End If
    End Sub
    Sub tampilplat()
        cmd = New OleDbCommand("Select * from Peminjam", conn)
        rd = cmd.ExecuteReader
        cb2.Items.Clear()
        Do While rd.Read
            cb2.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub cariplat()
        cb2.MaxLength = 20
        cmd = New OleDbCommand("Select * from Peminjam where plnomor = '" & cb2.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            f.Text = rd.Item("nomorrk")
            g.Text = rd.Item("nomorms")
            h.Text = rd.Item("unit")
            xstock = Val(h.Text) - 1
        End If
    End Sub
    Sub bukacmd()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub
    Sub tutupcmd()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
    End Sub
    Sub tutupbox()
        a.Enabled = False
        b.Enabled = False
        c.Enabled = False
        d.Enabled = False
        f.Enabled = False
        g.Enabled = False
        h.Enabled = False
        cb1.Enabled = False
        cb2.Enabled = False
    End Sub
    Sub bukabox()
        a.Enabled = True
        b.Enabled = True
        c.Enabled = True
        d.Enabled = True
        f.Enabled = True
        g.Enabled = True
        h.Enabled = True
        cb1.Enabled = True
        cb2.Enabled = True
    End Sub
    Private Sub tampildata()
        da = New OleDbDataAdapter("select * from Motor", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Motor")
        DG.DataSource = (ds.Tables("Motor"))
    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        da = New OleDbDataAdapter("select * from Motor", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Motor")
        DG.DataSource = (ds.Tables("Motor"))
        Call tampildata()
        Call tutupbox()
        Call tutupcmd()
        Button1.Enabled = True
        Button1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub a_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles a.KeyPress
        a.MaxLength = 20
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("Select * from Motor where nomorpjm='" & a.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Data Sudah Pernah ada....Tampilkan!!!")
                    b.Text = rd.GetString(1)
                    cb1.Text = rd.GetString(2)
                    cb2.Text = rd.GetString(3)
                    Call caridatanama()
                    Call cariplat()
                    Call tutupcmd()
                    Button3.Enabled = True
                    Button4.Enabled = True
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

    Private Sub b_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles b.KeyPress
        b.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            cb1.Focus()
        End If
    End Sub

    Private Sub b_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b.TextChanged

    End Sub

    Private Sub c_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles c.KeyPress
        c.MaxLength = 30
        If e.KeyChar = Chr(13) Then
        End If
        d.Focus()
    End Sub

    Private Sub c_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c.TextChanged

    End Sub

    Private Sub d_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles d.KeyPress
        d.MaxLength = 30
        If e.KeyChar = Chr(13) Then
        End If
        cb2.Focus()
    End Sub

    Private Sub d_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Kosongkan()
        Call bukacmd()
        Call bukabox()
        Call tutupcmd()
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        a.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call koneksi()
        Dim dm1 As New OleDbCommand
        dm1.Connection = conn
        dm1.CommandType = CommandType.Text
        dm1.CommandText = "insert into Motor (nomorpjm,tglpj,nomoridd,namapjm,hp,plat,rangka,mesin,unitt,status) values ('" & a.Text & "','" & b.Text & "','" & cb1.Text & "','" & c.Text & "','" & d.Text & "','" & cb2.Text & "','" & f.Text & "','" & g.Text & "','" & h.Text & "','" & cb3.Text & "')"
        dm1.ExecuteNonQuery()
        MsgBox("Data Pinjam Telah Disimpan !!!")
        Call tampildata()

        Dim cmd As OleDbCommand
        Dim edit As String = "update Peminjam set unit ='" & xstock & "'where plnomor ='" & cb2.Text & "'"
        cmd = New OleDbCommand(edit, conn)
        cmd.ExecuteNonQuery()

        Call tutupcmd()
        Call tutupbox()
        Button1.Enabled = True
        Button1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If a.Text = "" Then
            MsgBox("Isi Nomor Pinjam yang akan di hapus !!!")
            a.Focus()
            Exit Sub
        Else
            If MessageBox.Show("yakin akan menghapus data ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Motor where nomorpjm='" & a.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call tampildata()
                Call tutupcmd()
                Call tutupbox()
                Button1.Enabled = True
                Button1.Focus()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub cb1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb1.Click
        Call tampilnama()
    End Sub

    Private Sub cb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.SelectedIndexChanged
        Call caridatanama()
        cb2.Focus()
    End Sub

    Private Sub cb2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb2.Click
        Call tampilplat()
    End Sub

    Private Sub cb2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.SelectedIndexChanged
        Call cariplat()
    End Sub
End Class
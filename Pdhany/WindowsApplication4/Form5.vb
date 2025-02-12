Imports System.Data
Imports System.Data.OleDb
Public Class Form5
    Public xstock As Integer
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
    Sub databaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Focus()
    End Sub
    Sub tampilanggota()
        cmd = New OleDbCommand("Select * from Anggota", conn)
        rd = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub caridataang()
        ComboBox1.MaxLength = 4
        cmd = New OleDbCommand("Select * from Anggota where nomoragt = '" & ComboBox1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox3.Text = rd.Item("namaagt")
            TextBox4.Text = rd.Item("teleponagt")
        End If
    End Sub
    Sub tampilbuku()
        cmd = New OleDbCommand("Select * from Buku", conn)
        rd = cmd.ExecuteReader
        ComboBox2.Items.Clear()
        Do While rd.Read
            ComboBox2.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub caribuku()
        ComboBox2.MaxLength = 4
        cmd = New OleDbCommand("Select * from Buku where NomorBK = '" & ComboBox2.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox5.Text = rd.Item("judul")
            TextBox6.Text = rd.Item("stock")
            xstock = Val(TextBox6.Text) - 1
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
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
    End Sub
    Sub bukabox()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
    End Sub
    Private Sub tampildata()
        da = New OleDbDataAdapter("select * from Pinjam", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Pinjam")
        DataGridView1.DataSource = (ds.Tables("Pinjam"))
    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        da = New OleDbDataAdapter("select * from Pinjam", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pinjam")
        DataGridView1.DataSource = (ds.Tables("Pinjam"))
        Call tampildata()
        Call tutupbox()
        Call tutupcmd()
        Button1.Enabled = True
        Button1.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 5
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("Select * from Pinjam where nomorpj='" & TextBox1.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Data Sudah Pernah ada....Tampilkan!!!")
                    TextBox2.Text = rd.GetString(1)
                    ComboBox1.Text = rd.GetString(2)
                    ComboBox2.Text = rd.GetString(3)
                    Call caridataang()
                    Call caribuku()
                    Call tutupcmd()
                    Button3.Enabled = True
                    Button4.Enabled = True
                Else
                    Call databaru()
                    TextBox2.Focus()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 30
        If e.KeyChar = Chr(13) Then
        End If
        TextBox4.Focus()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        TextBox4.MaxLength = 30
        If e.KeyChar = Chr(13) Then
        End If
        ComboBox2.Focus()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Call buka()
        Call Kosongkan()
        Call bukabox()
        Call tutupcmd()
        Button2.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call koneksi()
        Dim dm1 As New OleDbCommand
        dm1.Connection = conn
        dm1.CommandType = CommandType.Text
        dm1.CommandText = "insert into Pinjam (nomorpj,tanggalpj,nomoragt,namaagt,kodebk) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "')"
        dm1.ExecuteNonQuery()
        MsgBox("Data Pinjam Telah Disismpan !!!")
        Call tampildata()

        Dim cmd As OleDbCommand
        Dim edit As String = "update Buku set stock ='" & xstock & "'where nomorbk ='" & ComboBox2.Text & "'"
        cmd = New OleDbCommand(edit, conn)
        cmd.ExecuteNonQuery()

        Call tutupcmd()
        Call tutupbox()
        Button1.Enabled = True
        Button1.Focus()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi Nomor Petugas yang di edit !!!")
            TextBox1.Focus()
            Exit Sub
        Else
            TextBox2.Focus()
            If MessageBox.Show("yakin akan meng-edit Petugas ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Button2.Enabled = False
                Dim cmd As OleDbCommand
                Dim edit As String = " update Pinjam set tanggalpj='" & TextBox2.Text & "',nomoragt='" & ComboBox1.Text & "',kodebk='" & ComboBox2.Text & "' where nomoragt='" & TextBox1.Text & "'"
                cmd = New OleDbCommand(edit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Pinjam Berhasil Di Update")
                Call tampildata()
            Else
                Call Kosongkan()
                Call tutupcmd()
                Call tutupbox()
                Button1.Enabled = True
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi Nomor Pinjam yang akan di hapus !!!")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("yakin akan menghapus data ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Pinjam where nomorpj='" & TextBox1.Text & "'", conn)
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

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        Call tampilanggota()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call caridataang()
        ComboBox2.Focus()
    End Sub

    Private Sub ComboBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.Click
        Call tampilbuku()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call caribuku()
    End Sub
End Class
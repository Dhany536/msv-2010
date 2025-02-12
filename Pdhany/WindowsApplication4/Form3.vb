Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = 0
    End Sub
    Sub databaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = 0
        TextBox2.Focus()
    End Sub
    Sub tutup()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
    End Sub
    Sub buka()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
    End Sub
    Private Sub Tampildata()
        da = New OleDbDataAdapter("select * from Buku", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Buku")
        DataGridView1.DataSource = (ds.Tables("Buku"))
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        da = New OleDbDataAdapter("select* from Buku", conn)
        ds.Clear()
        da.Fill(ds, "Buku")
        DataGridView1.DataSource = (ds.Tables("Buku"))
        Call Tampildata()
        Call tutup()
        Button1.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 4
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("Select * from Buku where nomorbk='" & TextBox1.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Data Sudah Pernah ada!!!")
                    TextBox2.Text = rd.GetString(1)
                    TextBox3.Text = rd.GetString(2)
                    TextBox4.Text = rd.GetString(3)
                    TextBox5.Text = rd.GetString(4)
                    TextBox6.Text = rd.GetValue(5)
                    Call tutup()
                    TextBox1.Enabled = True
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
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        TextBox4.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        TextBox5.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call buka()
        Call Kosongkan()
        Button2.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call koneksi()
            Dim dm1 As New OleDbCommand
            dm1.Connection = conn
            dm1.CommandType = CommandType.Text
            dm1.CommandText = "insert into buku values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
            dm1.ExecuteNonQuery()
            MsgBox("input data buku telah berhasil disimpan !!!")
            Call Tampildata()
            Button1.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi Nomor Buku yang di edit !!!")
            TextBox1.Focus()
            Exit Sub
        Else
            Call buka()
            TextBox2.Focus()
            If MessageBox.Show("yakin akan meng-edit buku ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Button2.Enabled = False
                Dim cmd As OleDbCommand
                Dim edit As String = " update buku set judul='" & TextBox2.Text & "',pengarang='" & TextBox3.Text & "',penerbit='" & TextBox4.Text & "',tahun='" & TextBox5.Text & "',stock='" & TextBox6.Text & "' where nomorbk='" & TextBox1.Text & "'"
                cmd = New OleDbCommand(edit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Buku Berhasil Di Update")
                Call Tampildata()
            Else
                Call Kosongkan()
                Call tutup()
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi Nomor Buku yang akan di hapus !!!")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("yakin akan menghapus data buku ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Buku where nomorbk='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampildata()
            Else
                Call Kosongkan()
            End If

        End If
    End Sub
End Class
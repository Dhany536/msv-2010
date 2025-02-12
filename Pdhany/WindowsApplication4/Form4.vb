Imports System.Data
Imports System.Data.OleDb
Public Class Form4
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub
    Sub databaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox2.Focus()
    End Sub
    Sub tutup()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
    End Sub
    Sub buka()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
    End Sub
    Private Sub tampildata()
        da = New OleDbDataAdapter("select * from Petugas", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Petugas")
        DataGridView1.DataSource = (ds.Tables("Petugas"))
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Button2.Focus()
    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        da = New OleDbDataAdapter("select * from Petugas", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Petugas")
        DataGridView1.DataSource = (ds.Tables("Petugas"))
        Call tampildata()
        Call tutup()
        Button1.Focus()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call buka()
        Call Kosongkan()
        Button2.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call koneksi()
        Dim dm1 As New OleDbCommand
        dm1.Connection = conn
        dm1.CommandType = CommandType.Text
        dm1.CommandText = "insert into Petugas (kodeptg,namaptg,passwordptg,statusptg) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
        dm1.ExecuteNonQuery()
        MsgBox("Data Petugas Telah Disismpan !!!")
        Call tampildata()
        Button1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi Nomor Petugas yang di edit !!!")
            TextBox1.Focus()
            Exit Sub
        Else
            Call buka()
            TextBox2.Focus()
            If MessageBox.Show("yakin akan meng-edit Petugas ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Button2.Enabled = False
                Dim cmd As OleDbCommand
                Dim edit As String = " update Petugas set namaptg='" & TextBox2.Text & "',passwordptg='" & TextBox3.Text & "',statusptg='" & ComboBox1.Text & "' where nomoragt='" & TextBox1.Text & "'"
                cmd = New OleDbCommand(edit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Petugas Berhasil Di Update")
                Call tampildata()
            Else
                Call Kosongkan()
                Call tutup()
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi Nomor Petugas yang akan di hapus !!!")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("yakin akan menghapus data ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Petugas where kodeptg='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call tampildata()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 5
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("Select * from Petugas where kodeptg='" & TextBox1.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Data Sudah Pernah ada....Tampilkan!!!")
                    TextBox2.Text = rd.GetString(1)
                    TextBox3.Text = rd.GetString(2)
                    ComboBox1.Text = rd.GetString(3)
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
End Class
Imports System.Data.OleDb
Public Class Form2
    Private xjkel As String
    Sub kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Text = ""
        L.Checked = False
        P.Checked = False
        ComboBox1.Text = ""
    End Sub
    Sub databaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Text = ""
        L.Checked = False
        P.Checked = False
        ComboBox1.Focus()
    End Sub
    Sub tutup()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox4.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        ComboBox1.Enabled = False
    End Sub
    Sub buka()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox4.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
    End Sub
    Private Sub Tampildata()
        da = New OleDbDataAdapter("Select * from Identitas", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Identitas")
        DG.DataSource = (ds.Tables("Identitas"))
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        da = New OleDbDataAdapter("select * from Identitas", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Identitas")
        DG.DataSource = (ds.Tables("Identitas"))
        Call Tampildata()
        Call tutup()
        Button1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim pjkel As String
        TextBox1.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("select * from Identias where nomorid='" & TextBox1.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Tampilkan Data Sudah Pernah Ada !!!")
                    TextBox2.Text = rd.GetString(1)
                    TextBox3.Text = rd.GetString(2)
                    TextBox4.Text = rd.GetString(3)
                    TextBox5.Text = rd.GetString(4)
                    DateTimePicker1.Text = rd.GetString(5)
                    pjkel = rd.GetString(6)
                    If pjkel = "laki-laki" Then
                        L.Checked = True
                        P.Checked = True
                    End If
                    If pjkel = "Perempuan" Then
                        P.Checked = True
                    End If
                    ComboBox1.Text = rd.GetString(7)
                    Call tutup()
                    TextBox2.Enabled = False
                    TextBox3.Enabled = False
                    TextBox4.Enabled = False
                    TextBox5.Enabled = False
                    DateTimePicker1.Enabled = False
                    ComboBox1.Enabled = False
                Else
                    Call databaru()
                    TextBox2.Focus()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox1_SystemColorsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.SystemColorsChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call buka()
        Call kosongkan()
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        DateTimePicker1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi Nomor Identitas terlebih dahulu !!")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan Menghapus data ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("DELETE FROM Identitas WHERE nomoragt='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call kosongkan()
                Call Tampildata()
            Else
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call koneksi()
        Dim dm1 As New OleDbCommand
        dm1.Connection = conn
        dm1.CommandType = CommandType.Text
        dm1.CommandText = "insert into Identitas(nomorid,namapj,alamat,tgllahir,agama,jkel,telepon,email) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & ComboBox1.Text & "','" & xjkel & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        dm1.ExecuteNonQuery()
        MsgBox("Data Telah Disimpan !!!")
        Call Tampildata()
        Button1.Focus()
    End Sub

    Private Sub L_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L.CheckedChanged
        If L.Checked = True Then
            xjkel = "Laki-Laki"
        End If
    End Sub

    Private Sub P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P.CheckedChanged
        If P.Checked = True Then
            xjkel = "Perempuan"
        End If
    End Sub
End Class
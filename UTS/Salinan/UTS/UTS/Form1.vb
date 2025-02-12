Imports System.Data.OleDb
Public Class Form1
    Private xjkel As String
    Sub kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        L.Checked = False
        P.Checked = False
        TextBox10.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox7.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
    Sub databaru()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        L.Checked = False
        P.Checked = False
        TextBox10.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox7.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Focus()
    End Sub
    Sub tutup()
        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox10.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox7.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        L.Enabled = True
        P.Enabled = True
    End Sub
    Sub buka()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox10.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox7.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        L.Enabled = True
        P.Enabled = True
    End Sub

    Sub edit()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox10.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox7.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True

    End Sub

    Private Sub Tampildata()
        da = New OleDbDataAdapter("Select * from ktp", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "ktp")
        DG.DataSource = (ds.Tables("ktp"))
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        da = New OleDbDataAdapter("select * from ktp", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "ktp")
        DG.DataSource = (ds.Tables("ktp"))
        Call Tampildata()
        Call tutup()
        Button1.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim pjkel As String
        Dim pjkaw As String
        TextBox1.MaxLength = 12
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("select * from ktp where nik='" & TextBox1.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Tampilkan Data Sudah Pernah Ada !!!")
                    TextBox2.Text = rd.GetString(1)
                    TextBox3.Text = rd.GetString(2)
                    pjkel = rd.GetString(3)
                    If pjkel = "laki-laki" Then
                        L.Checked = True
                        P.Checked = True
                    End If
                    If pjkel = "Perempuan" Then
                        P.Checked = True
                    End If
                    TextBox4.Text = rd.GetString(4)
                    TextBox5.Text = rd.GetString(5)
                    TextBox6.Text = rd.GetString(6)
                    TextBox10.Text = rd.GetString(7)
                    ComboBox1.Text = rd.GetString(8)
                    ComboBox2.Text = rd.GetString(9)
                    TextBox8.Text = rd.GetString(10)
                    TextBox9.Text = rd.GetString(11)
                    TextBox7.Text = rd.GetString(12)
                    Call tutup()
                    TextBox2.Enabled = False
                    TextBox3.Enabled = False
                    TextBox4.Enabled = False
                    TextBox5.Enabled = False
                    TextBox6.Enabled = False
                    TextBox10.Enabled = False
                    TextBox8.Enabled = False
                    TextBox9.Enabled = False
                    TextBox7.Enabled = False
                    ComboBox1.Enabled = False
                    ComboBox2.Enabled = False
                Else
                    Call databaru()
                    TextBox2.Focus()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
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
        TextBox6.Enabled = True
        TextBox10.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox7.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call koneksi()
        Dim dm1 As New OleDbCommand
        dm1.Connection = conn
        dm1.CommandType = CommandType.Text
        dm1.CommandText = "insert into ktp(nik,nama,tempattgl,jeniskelamin,alamat,rtrw,keldesa,kecamatan,agama,status,pekerjaan,kewarganegaraan,berlakuhingga) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & xjkel & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox10.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox7.Text & "')"
        dm1.ExecuteNonQuery()
        MsgBox("Data Telah Disimpan !!!")
        Call Tampildata()
        Button1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MsgBox("Isi Nomor NIK yang di edit !!!")
            TextBox1.Focus()
            Return
        End If

        If MessageBox.Show("Yakin akan meng-edit data KTP ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call buka()
            TextBox2.Focus()

            Try
                Using cmd As New OleDbCommand("UPDATE ktp SET nama=@nama, tempattgl=@tempattgl, jeniskelamin=@jeniskelamin, alamat=@alamat, rtrw=@rtrw, keldesa=@keldesa, kecamatan=@kecamatan, agama=@agama, status=@status, pekerjaan=@pekerjaan, kewarganegaraan=@kewarganegaraan, berlakuhingga=@berlakuhingga WHERE nik=@nik", conn)
                    cmd.Parameters.AddWithValue("@nama", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@tempattgl", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@jeniskelamin", xjkel)
                    cmd.Parameters.AddWithValue("@alamat", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@rtrw", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@keldesa", TextBox6.Text)
                    cmd.Parameters.AddWithValue("@kecamatan", TextBox10.Text)
                    cmd.Parameters.AddWithValue("@agama", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@status", ComboBox2.Text)
                    cmd.Parameters.AddWithValue("@pekerjaan", TextBox8.Text)
                    cmd.Parameters.AddWithValue("@kewarganegaraan", TextBox9.Text)
                    cmd.Parameters.AddWithValue("@berlakuhingga", TextBox7.Text)
                    cmd.Parameters.AddWithValue("@nik", TextBox1.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Data Berhasil Di Update")
                    Else
                        MsgBox("Data tidak ditemukan untuk di-update.")
                    End If
                End Using

                Call Tampildata()
            Catch ex As Exception
                MsgBox("Terjadi kesalahan: " & ex.Message)
            Finally
                Call kosongkan()
                Call buka()
                Button1.Focus()
            End Try
        Else
            Call kosongkan()
            Call tutup()
            Button1.Focus()
        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = " " Then
            MsgBox("Isi Nomor NIK terlebih dahulu !!")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan Menghapus data ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("DELETE FROM ktp WHERE nik='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Call kosongkan()
                Call Tampildata()
            Else
                Call kosongkan()
            End If
        End If
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

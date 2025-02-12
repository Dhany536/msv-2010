Imports System.Data.OleDb
Public Class Form1
    Private pjkel As String
    Private status As String
    Sub kosongkan()
        N1.Text = ""
        N2.Text = ""
        N3.Text = ""
        N5.Text = ""
        N6.Text = ""
        L.Checked = False
        P.Checked = False
        N7.Text = ""
        C1.Text = ""
        N8.Text = ""
        N4.Text = ""
        C2.Text = ""
        CH1.Text = False
        CH2.Text = False
        CH3.Text = False
        CH4.Text = False
    End Sub
    Sub databaru()
        N1.Text = ""
        N2.Text = ""
        N3.Text = ""
        N5.Text = ""
        N6.Text = ""
        L.Checked = False
        P.Checked = False
        N7.Text = ""
        C1.Text = ""
        N8.Text = ""
        N4.Text = ""
        CH1.Text = False
        CH2.Text = False
        CH3.Text = False
        CH4.Text = False
        C2.Focus()
    End Sub
    Sub tutup()
        N1.Enabled = False
        N2.Enabled = False
        N3.Enabled = False
        N5.Enabled = False
        N6.Enabled = False
        N7.Enabled = False
        C1.Enabled = False
        N8.Enabled = False
        N4.Enabled = False
        C2.Enabled = False
        CH1.Text = False
        CH2.Text = False
        CH3.Text = False
        CH4.Text = False
    End Sub
    Sub buka()
        N1.Enabled = True
        N2.Enabled = True
        N3.Enabled = True
        N5.Enabled = True
        N6.Enabled = True
        N7.Enabled = True
        C1.Enabled = True
        N8.Enabled = True
        N4.Enabled = True
        C2.Enabled = True
        CH1.Text = True
        CH2.Text = True
        CH3.Text = True
        CH4.Text = True
    End Sub
    Private Sub Tampildata()
        da = New OleDbDataAdapter("Select * from ektp", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "ektp")
        DG.DataSource = (ds.Tables("ektp"))
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        da = New OleDbDataAdapter("select * from ektp", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "ektp")
        DG.DataSource = (ds.Tables("ektp"))
        Call Tampildata()
        Call tutup()
        Button1.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub N1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles N1.KeyPress
        Dim pjkel As String
        Dim status As String
        N1.MaxLength = 12
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("select * from ktp where nomorpd='" & N1.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Tampilkan Data Sudah Pernah Ada !!!")
                    N2.Text = rd.GetString(1)
                    N3.Text = rd.GetString(2)
                    pjkel = rd.GetString(3)
                    If pjkel = "laki-laki" Then
                        L.Checked = True
                        P.Checked = True
                    End If
                    If pjkel = "Perempuan" Then
                        P.Checked = True
                    End If
                    status = rd.GetString(4)
                    If status = "Menikah" Then
                        CH1.Checked = True
                        CH2.Checked = True
                    End If
                    If status = "Belum Menikah" Then
                        CH2.Checked = True
                    End If
                    If status = "Janda" Then
                        CH3.Checked = True
                    End If
                    If status = "Duda" Then
                        CH4.Checked = True
                    End If
                    N5.Text = rd.GetString(5)
                    N6.Text = rd.GetString(6)
                    N7.Text = rd.GetString(7)
                    C2.Text = rd.GetString(8)
                    C1.Text = rd.GetString(9)
                    N8.Text = rd.GetString(10)
                    N4.Text = rd.GetString(11)
                    CH1.Text = rd.GetString(12)
                    CH2.Text = rd.GetString(13)
                    CH3.Text = rd.GetString(14)
                    CH4.Text = rd.GetString(15)
                    Call tutup()
                    N2.Enabled = False
                    N3.Enabled = False
                    N5.Enabled = False
                    N6.Enabled = False
                    N7.Enabled = False
                    C1.Enabled = False
                    N8.Enabled = False
                    N4.Enabled = False
                    C2.Enabled = False
                Else
                    Call databaru()
                    N2.Focus()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub N1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call buka()
        Call kosongkan()
        N2.Enabled = True
        N3.Enabled = True
        N5.Enabled = True
        N6.Enabled = True
        N7.Enabled = True
        C1.Enabled = True
        N8.Enabled = True
        N4.Enabled = True
        C2.Enabled = True
        CH1.Text = True
        CH2.Text = True
        CH3.Text = True
        CH4.Text = True
        N1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call koneksi()
        Dim dm1 As New OleDbCommand
        dm1.Connection = conn
        dm1.CommandType = CommandType.Text
        dm1.CommandText = "insert into ektp(nomorpd,nama,tempat,tanggallahir,pekerjaan,status,alamat,agama,email,provinsi,kota,kecamatan,jkel) values ('" & N1.Text & "','" & N2.Text & "','" & N3.Text & "','" & N4.Text & "','" & xjkel & "','" & N5.Text & "','" & N6.Text & "','" & C1.Text & "','" & N7.Text & "','" & N8.Text & "','" & C2.Text & "')"
        dm1.ExecuteNonQuery()
        MsgBox("Data Telah Disimpan !!!")
        Call Tampildata()
        Button1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If N1.Text = "" Then
            MsgBox("Isi Nomor Pendaftaran yang di edit !!!")
            N1.Focus()
            Exit Sub
        Else
            N2.Focus()
            If MessageBox.Show("yakin akan meng-edit nama E-KTP ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Button2.Enabled = False
                Dim cmd As OleDbCommand
                Dim edit As String = "update ktp set nama='" & N2.Text & "', tempat='" & N3.Text & "',tanggallahir='" & N4.Text & "', jkel='" & pjkel & "', alamat='" & N5.Text & "', email='" & N6.Text & "',provinsi='" & C1.Text & "',kota='" & N7.Text & "',kecamatan='" & N8.Text & "',agama='" & C2.Text & "',status='" & status & "' where nomorpd='" & N1.Text & "'"
                cmd = New OleDbCommand(edit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Update")
                Call Tampildata()
            Else
                Call kosongkan()
                Button1.Enabled = True
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Delete the selected row from the DataGridView
        If DG.SelectedRows.Count > 0 Then
            'Confirm deletion
            If MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'Delete the row
                ds.Tables(0).Rows.RemoveAt(DG.SelectedRows(0).Index)
            End If
        End If
    End Sub

    Private Sub L_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L.CheckedChanged
        If L.Checked = True Then
            pjkel = "Laki-Laki"
        End If
    End Sub

    Private Sub P_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P.CheckedChanged
        If P.Checked = True Then
            pjkel = "Perempuan"
        End If
    End Sub

    Private Sub CH1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CH1.CheckedChanged
        If CH1.Checked = True Then
            status = "Menikah"
        End If
    End Sub

    Private Sub CH2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CH2.CheckedChanged
        If CH2.Checked = True Then
            status = "Belum Menikah"
        End If
    End Sub

    Private Sub CH3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CH3.CheckedChanged
        If CH3.Checked = True Then
            status = "Janda"
        End If
    End Sub

    Private Sub CH4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CH4.CheckedChanged
        If CH4.Checked = True Then
            status = "Duda"
        End If
    End Sub
End Class

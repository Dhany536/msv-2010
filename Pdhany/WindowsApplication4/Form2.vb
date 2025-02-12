Imports System.Data.OleDb
Public Class Form2
    Private xjkel As String

    Sub kosongkan()
        nomoragt.Text = ""
        namaagt.Text = ""
        alamat.Text = ""
        telephone.Text = ""
        tempatlahir.Text = ""
        tgllahir.Text = ""
        L.Checked = False
        P.Checked = False
        agama.Text = ""
    End Sub

    Sub databaru()
        namaagt.Text = ""
        alamat.Text = ""
        telephone.Text = ""
        tempatlahir.Text = ""
        tgllahir.Text = ""
        L.Checked = False
        P.Checked = False
        agama.Focus()
    End Sub

    Sub tutup()
        nomoragt.Enabled = False
        namaagt.Enabled = False
        alamat.Enabled = False
        telephone.Enabled = False
        tempatlahir.Enabled = False
        agama.Enabled = False
    End Sub

    Sub buka()
        nomoragt.Enabled = True
        namaagt.Enabled = True
        alamat.Enabled = True
        telephone.Enabled = True
        tempatlahir.Enabled = True
        agama.Enabled = True
    End Sub

    Private Sub Tampildata()
        da = New OleDbDataAdapter("Select * from Anggota", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Anggota")
        DG.DataSource = (ds.Tables("Anggota"))
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        da = New OleDbDataAdapter("select * from Anggota", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Anggota")
        DG.DataSource = (ds.Tables("Anggota"))
        Call Tampildata()
        Call tutup()
        btntambah.Focus()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub nomoragt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nomoragt.KeyPress
        Dim pjkel As String
        nomoragt.MaxLength = 4
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("select * from Anggota where nomoragt='" & nomoragt.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Tampilkan Data Sudah Pernah Ada !!!")
                    namaagt.Text = rd.GetString(1)
                    alamat.Text = rd.GetString(2)
                    telephone.Text = rd.GetString(3)
                    tempatlahir.Text = rd.GetString(4)
                    tgllahir.Text = rd.GetString(5)
                    pjkel = rd.GetString(6)
                    If pjkel = "laki-laki" Then
                        L.Checked = True
                        P.Checked = True
                    End If
                    If pjkel = "Perempuan" Then
                        P.Checked = True
                    End If
                    agama.Text = rd.GetString(7)
                    Call tutup()
                    namaagt.Enabled = False
                    alamat.Enabled = False
                    telephone.Enabled = False
                    tempatlahir.Enabled = False
                    tgllahir.Enabled = False
                    agama.Enabled = False
                Else
                    Call databaru()
                    namaagt.Focus()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call buka()
        Call kosongkan()
        namaagt.Enabled = True
        alamat.Enabled = True
        telephone.Enabled = True
        tempatlahir.Enabled = True
        tgllahir.Enabled = True
        nomoragt.Focus()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Call koneksi()
        Dim dm1 As New OleDbCommand
        dm1.Connection = conn
        dm1.CommandType = CommandType.Text
        dm1.CommandText = "insert into Anggota(nomoragt,namaagt,alamatagt,teleponagt,tempat,tanggallahir,jeniskelamin,agama) values ('" & nomoragt.Text & "','" & namaagt.Text & "','" & alamat.Text & "','" & telephone.Text & "','" & tempatlahir.Text & "','" & tgllahir.Text & "','" & xjkel & "','" & agama.Text & "')"
        dm1.ExecuteNonQuery()
        MsgBox("Data Telah Disimpan !!!")
        Call Tampildata()
        btntambah.Focus()
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If nomoragt.Text = "" Then
            MsgBox("Isi Nomor Anggota terlebih dahulu !!")
            nomoragt.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan Menghapus data ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("DELETE FROM Anggota WHERE nomoragt='" & nomoragt.Text & "'", conn)
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

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If nomoragt.Text = "" Then
            MsgBox("Isi Nomor Anggota yang di edit !!!")
            nomoragt.Focus()
            Exit Sub
        Else
            Call buka()
            namaagt.Focus()
            If MessageBox.Show("yakin akan meng-edit nama Anggota ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim cmd As OleDbCommand
                Dim edit As String = "UPDATE Anggota SET namaagt='" & namaagt.Text & "', alamatagt='" & alamat.Text & "', teleponagt='" & telephone.Text & "', tempat='" & tempatlahir.Text & "' WHERE nomoragt='" & nomoragt.Text & "'"
                cmd = New OleDbCommand(edit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Update")
                Call Tampildata()
            Else
                Call kosongkan()
                Call tutup()
                btntambah.Focus()
            End If
        End If
    End Sub

    Private Sub agama_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agama.SelectedIndexChanged

    End Sub
End Class

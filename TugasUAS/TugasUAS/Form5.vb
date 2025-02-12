Imports System.Data.OleDb
Public Class Form5
    Public xstock As Integer
    Sub Kosongkan()
        a.Text = ""
        b.Text = ""
        c.Text = ""
        d.Text = ""
        f.Text = ""
        g.Text = ""
        cb1.Text = ""
        cb2.Text = ""
        cb3.Text = ""
        h.Text = ""
        i.Text = ""
        j.Text = ""
        k.Text = ""
    End Sub
    Sub databaru()
        b.Text = ""
        c.Text = ""
        d.Text = ""
        f.Text = ""
        g.Text = ""
        cb1.Text = ""
        cb2.Text = ""
        cb3.Text = ""
        h.Text = ""
        i.Text = ""
        j.Text = ""
        k.Text = ""
        b.Focus()
    End Sub
    Sub caripinjam()
        b.MaxLength = 5
        cmd = New OleDbCommand("Select * from Motor where nomorpjm = '" & b.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            i.Text = rd.Item("tglpj")
            cb1.Text = rd.Item("nomoridd")
            cb2.Text = rd.Item("plat")
            h.Focus()
        Else
            MsgBox("Data Pinjam Tidak Ada!!!")
            b.Text = " "
            b.Focus()
        End If
    End Sub
    Sub caridatanama()
        cb1.MaxLength = 15
        cmd = New OleDbCommand("Select * from Identitas where nomorid = '" & cb1.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            c.Text = rd.Item("namapj")
            d.Text = rd.Item("telepon")
        End If
    End Sub

    Sub cariplat()
        cb2.MaxLength = 8
        cmd = New OleDbCommand("Select * from Peminjam where plnomor = '" & cb2.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            f.Text = rd.Item("nomorrk")
            g.Text = rd.Item("unit")
            xstock = Val(g.Text) + 1
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
        Button3.Enabled = True
        Button4.Enabled = False
    End Sub
    Sub bukabox()
        a.Enabled = True
        b.Enabled = True
        c.Enabled = True
        d.Enabled = True
        f.Enabled = True
        g.Enabled = True
        h.Enabled = True
        i.Enabled = True
        j.Enabled = True
        k.Enabled = True
        cb1.Enabled = True
        cb2.Enabled = True
        cb3.Enabled = True
    End Sub
    Sub tutupbox()
        a.Enabled = True
        b.Enabled = False
        c.Enabled = False
        d.Enabled = False
        f.Enabled = False
        g.Enabled = False
        h.Enabled = False
        i.Enabled = False
        j.Enabled = False
        k.Enabled = False
        cb1.Enabled = False
        cb2.Enabled = False
        cb3.Enabled = False
    End Sub
    Private Sub tampildata()
        da = New OleDbDataAdapter("select * from Motor", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Motor")
        DG.DataSource = (ds.Tables("Motor"))
    End Sub
    Private Sub tampildatakembali()
        da = New OleDbDataAdapter("select * from Pengembalian", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "Pengembalian")
        DG.DataSource = (ds.Tables("Pengembalian"))
    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        da = New OleDbDataAdapter("select * from Motor", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Motor")
        DG.DataSource = (ds.Tables("Motor"))
        Call tampildata()

        da = New OleDbDataAdapter("select * from Pengembalian", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pengembalian")
        DG.DataSource = (ds.Tables("Pengembalian"))
        Call tampildatakembali()

        Call tutupbox()
        Call tutupcmd()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub a_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles a.KeyPress
        a.MaxLength = 20
        If e.KeyChar = Chr(13) Then
            Try
                cmd = New OleDbCommand("Select * from Pengembalian where nopgm='" & a.Text & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("Data Sudah Pernah ada....Tampilkan!!!")
                    Call bukabox()
                    b.Text = rd.Item("nopjm")
                    c.Text = rd.Item("naid")
                    d.Text = rd.Item("hppp")
                    f.Text = rd.Item("nork")
                    g.Text = rd.Item("tt")
                    h.Text = rd.Item("tglkem")
                    i.Text = rd.Item("tglpj")
                    j.Text = rd.Item("seltgl")
                    k.Text = rd.Item("denda")
                    cb1.Text = rd.Item("noid")
                    cb2.Text = rd.Item("nopl")
                    Call caridatanama()
                    Call cariplat()
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
        b.MaxLength = 12
        If e.KeyChar = Chr(13) Then
            caridatanama()
            caripinjam()
            cariplat()
        End If
    End Sub

    Private Sub b_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Kosongkan()
        Call bukabox()
        Call bukacmd()
        a.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Call koneksi() ' Pastikan koneksi dibuka

            ' Membuat perintah untuk menyimpan data ke tabel Pengembalian
            Dim dm1 As New OleDbCommand("INSERT INTO Pengembalian (nopgm, nopjm, noid, naid, hppp, nopt, nork, tt, tglkem, tglpj, seltgl, status, denda) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)

            ' Menambahkan parameter ke perintah
            dm1.Parameters.AddWithValue("?", a.Text) ' nopgm
            dm1.Parameters.AddWithValue("?", b.Text) ' nopjm
            dm1.Parameters.AddWithValue("?", cb1.Text) ' noid
            dm1.Parameters.AddWithValue("?", c.Text) ' naid
            dm1.Parameters.AddWithValue("?", d.Text) ' hppp
            dm1.Parameters.AddWithValue("?", cb2.Text) ' nopt
            dm1.Parameters.AddWithValue("?", f.Text) ' nork
            dm1.Parameters.AddWithValue("?", g.Text) ' tt
            dm1.Parameters.AddWithValue("?", h.Text) ' tglkem
            dm1.Parameters.AddWithValue("?", i.Text) ' tglpj
            dm1.Parameters.AddWithValue("?", j.Text) ' seltgl
            dm1.Parameters.AddWithValue("?", cb3.Text) ' status (misalnya, status bisa diisi dengan "Active" atau sesuai kebutuhan)
            dm1.Parameters.AddWithValue("?", k.Text) ' denda

            ' Menjalankan perintah
            dm1.ExecuteNonQuery()

            MsgBox("Data Pinjam Telah Disimpan !!!")
            Call tampildata()

            ' Update stok motor
            Dim cmdx As New OleDbCommand("UPDATE Peminjam SET unit = ? WHERE plnomor = ?", conn)
            cmdx.Parameters.AddWithValue("?", xstock) ' unit
            cmdx.Parameters.AddWithValue("?", cb2.Text) ' plnomor
            cmdx.ExecuteNonQuery()

            Call tutupcmd()
            Call tutupbox()
            Button1.Enabled = True
            Button1.Focus()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close() ' Pastikan koneksi ditutup
            End If
        End Try
    End Sub

    Private Sub k_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles k.KeyPress
       
    End Sub

    Private Sub k_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles k.TextChanged

    End Sub

    Private Sub h_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles h.KeyPress
        Dim dendaPerHari As Long = 20000 ' Denda per hari
        Dim selisih As Long
        Dim totalDenda As Long = 0
        Dim tanggalKembali As DateTime
        Dim tanggalPinjam As DateTime

        If e.KeyChar = Chr(13) Then ' Jika tombol Enter ditekan
            ' Coba parsing tanggal dari input
            If DateTime.TryParse(h.Text, tanggalKembali) AndAlso DateTime.TryParse(i.Text, tanggalPinjam) Then
                ' Menghitung selisih hari
                selisih = (tanggalKembali - tanggalPinjam).Days

                If selisih > 0 Then
                    ' Jika selisih positif, hitung denda
                    totalDenda = dendaPerHari * selisih
                End If

                j.Text = selisih.ToString() ' Menampilkan selisih tanggal
                k.Text = totalDenda.ToString() ' Menampilkan total denda
            Else
                MessageBox.Show("Tanggal yang dimasukkan tidak valid. Silakan masukkan tanggal yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Button2.Focus() ' Memindahkan fokus ke Button2
        End If
    End Sub

    Private Sub h_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Call koneksi() ' Pastikan koneksi dibuka

            ' Membuat perintah untuk memperbarui data di tabel Pengembalian
            Dim updateCmd As New OleDbCommand("UPDATE Pengembalian SET nopjm = ?, noid = ?, naid = ?, hppp = ?, nopt = ?, nork = ?, tt = ?, tglkem = ?, tglpj = ?, seltgl = ?, status = ?, denda = ? WHERE nopgm = ?", conn)

            ' Menambahkan parameter ke perintah
            updateCmd.Parameters.AddWithValue("?", b.Text) ' nopjm
            updateCmd.Parameters.AddWithValue("?", cb1.Text) ' noid
            updateCmd.Parameters.AddWithValue("?", c.Text) ' naid
            updateCmd.Parameters.AddWithValue("?", d.Text) ' hppp
            updateCmd.Parameters.AddWithValue("?", cb2.Text) ' nopt
            updateCmd.Parameters.AddWithValue("?", f.Text) ' nork
            updateCmd.Parameters.AddWithValue("?", g.Text) ' tt
            updateCmd.Parameters.AddWithValue("?", h.Text) ' tglkem
            updateCmd.Parameters.AddWithValue("?", i.Text) ' tglpj
            updateCmd.Parameters.AddWithValue("?", j.Text) ' seltgl
            updateCmd.Parameters.AddWithValue("?", cb3.Text) ' status (misalnya, status bisa diisi dengan "Active" atau sesuai kebutuhan)
            updateCmd.Parameters.AddWithValue("?", k.Text) ' denda
            updateCmd.Parameters.AddWithValue("?", a.Text) ' nopgm (kunci untuk update)

            ' Menjalankan perintah
            Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Data Pinjam Telah Diperbarui !!!")
                Call tampildatakembali() ' Memperbarui tampilan data
            Else
                MsgBox("Data tidak ditemukan atau tidak ada perubahan.")
            End If

            Call tutupcmd()
            Call tutupbox()
            Button1.Enabled = True
            Button1.Focus()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close() ' Pastikan koneksi ditutup
            End If
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Call koneksi() ' Pastikan koneksi dibuka

            ' Membuat perintah untuk menghapus data di tabel Pengembalian
            Dim deleteCmd As New OleDbCommand("DELETE FROM Pengembalian WHERE nopgm = ?", conn)

            ' Menambahkan parameter ke perintah
            deleteCmd.Parameters.AddWithValue("?", a.Text) ' nopgm (kunci untuk hapus)

            ' Menjalankan perintah
            Dim rowsAffected As Integer = deleteCmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Data Pinjam Telah Dihapus !!!")
                Call tampildatakembali() ' Memperbarui tampilan data
                Call Kosongkan() ' Mengosongkan form setelah penghapusan
            Else
                MsgBox("Data tidak ditemukan atau tidak ada yang dihapus.")
            End If

            Call tutupcmd()
            Call tutupbox()
            Button1.Enabled = True
            Button1.Focus()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close() ' Pastikan koneksi ditutup
            End If
        End Try
    End Sub
End Class
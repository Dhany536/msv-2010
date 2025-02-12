Imports System.Data.OleDb
Public Class Form1
    Private xjkel As String
    Private status As String

    Private Sub Tampildata()
        da = New OleDbDataAdapter("Select * from DatabaseKTP", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "DatabaseKTP")
        DG.DataSource = (ds.Tables("DatabaseKTP"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        da = New OleDbDataAdapter("select * from DatabaseKTP", conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "DatabaseKTP")
        DG.DataSource = (ds.Tables("DatabaseKTP"))
        Call Tampildata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Dim dm1 As New OleDbCommand
        dm1.Connection = conn
        dm1.CommandType = CommandType.Text
        dm1.CommandText = "INSERT INTO DatabaseKTP([Nomor Pendaftaran], [Nama], [Tempat Tanggal Lahir], [Pekerjaan], [Status Pernikahan], [Alamat], [Agama], [Email], [Provinsi], [Kota], [Jenis Kelamin]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        ' Adding parameters
        dm1.Parameters.AddWithValue("?", TextBox2.Text)
        dm1.Parameters.AddWithValue("?", TextBox7.Text)
        dm1.Parameters.AddWithValue("?", TextBox8.Text)
        dm1.Parameters.AddWithValue("?", TextBox10.Text)
        dm1.Parameters.AddWithValue("?", status)
        dm1.Parameters.AddWithValue("?", TextBox11.Text)
        dm1.Parameters.AddWithValue("?", ComboBox1.Text)
        dm1.Parameters.AddWithValue("?", TextBox12.Text)
        dm1.Parameters.AddWithValue("?", TextBox13.Text)
        dm1.Parameters.AddWithValue("?", TextBox14.Text)
        dm1.Parameters.AddWithValue("?", xjkel)

        dm1.ExecuteNonQuery()
        MsgBox("Data Telah Disimpan !!!")
        Call Tampildata()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            xjkel = "Laki-Laki"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            xjkel = "Perempuan"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            status = "Menikah"
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            status = "Belum Menikah"
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            status = "Janda/Duda"
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if a row is selected in the DataGridView
        If DG.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DG.SelectedRows(0)

            ' Populate the text boxes with the data from the selected row
            TextBox2.Text = selectedRow.Cells("Nomor Pendaftaran").Value.ToString()
            TextBox7.Text = selectedRow.Cells("Nama").Value.ToString()
            TextBox8.Text = selectedRow.Cells("Tempat Tanggal Lahir").Value.ToString()
            TextBox10.Text = selectedRow.Cells("Pekerjaan").Value.ToString()
            status = selectedRow.Cells("Status Pernikahan").Value.ToString()
            TextBox11.Text = selectedRow.Cells("Alamat").Value.ToString()
            ComboBox1.Text = selectedRow.Cells("Agama").Value.ToString()
            TextBox12.Text = selectedRow.Cells("Email").Value.ToString()
            TextBox13.Text = selectedRow.Cells("Provinsi").Value.ToString()
            TextBox14.Text = selectedRow.Cells("Kota").Value.ToString()
            xjkel = selectedRow.Cells("Jenis Kelamin").Value.ToString()

            ' Set the appropriate radio button based on the selected gender
            If xjkel = "Laki-Laki" Then
                RadioButton1.Checked = True
            ElseIf xjkel = "Perempuan" Then
                RadioButton2.Checked = True
            End If

            ' Set the appropriate checkbox based on the marital status
            If status = "Menikah" Then
                CheckBox1.Checked = True
            ElseIf status = "Belum Menikah" Then
                CheckBox2.Checked = True
            ElseIf status = "Janda/Duda" Then
                CheckBox3.Checked = True
            End If
        Else
            MsgBox("Silakan pilih data yang ingin diedit.")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Check if a row is selected in the DataGridView
        If DG.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DG.SelectedRows(0)
            Dim nomorPendaftaran As String = selectedRow.Cells("Nomor Pendaftaran").Value.ToString() ' Use Nomor Pendaftaran as the identifier

            Call koneksi()
            Dim dm1 As New OleDbCommand
            dm1.Connection = conn
            dm1.CommandType = CommandType.Text
            dm1.CommandText = "UPDATE DatabaseKTP SET [Nama] = ?, [Tempat Tanggal Lahir] = ?, [Pekerjaan] = ?, [Status Pernikahan] = ?, [Alamat] = ?, [Agama] = ?, [Email] = ?, [Provinsi] = ?, [Kota] = ?, [Jenis Kelamin] = ? WHERE [Nomor Pendaftaran] = ?"

            ' Adding parameters
            dm1.Parameters.AddWithValue("?", TextBox7.Text) ' Nama
            dm1.Parameters.AddWithValue("?", TextBox8.Text) ' Tempat Tanggal Lahir
            dm1.Parameters.AddWithValue("?", TextBox10.Text) ' Pekerjaan
            dm1.Parameters.AddWithValue("?", status) ' Status Pernikahan
            dm1.Parameters.AddWithValue("?", TextBox11.Text) ' Alamat
            dm1.Parameters.AddWithValue("?", ComboBox1.Text) ' Agama
            dm1.Parameters.AddWithValue("?", TextBox12.Text) ' Email
            dm1.Parameters.AddWithValue("?", TextBox13.Text) ' Provinsi
            dm1.Parameters.AddWithValue("?", TextBox14.Text) ' Kota
            dm1.Parameters.AddWithValue("?", xjkel) ' Jenis Kelamin
            dm1.Parameters.AddWithValue("?", nomorPendaftaran) ' Nomor Pendaftaran for WHERE clause

            ' Execute the update command
            dm1.ExecuteNonQuery()
            MsgBox("Data Telah Diperbarui !!!")
            Call Tampildata()
        Else
            MsgBox("Silakan pilih data yang ingin diedit.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Check if a row is selected in the DataGridView
        If DG.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DG.SelectedRows(0)
            Dim nomorPendaftaran As String = selectedRow.Cells("Nomor Pendaftaran").Value.ToString() ' Use Nomor Pendaftaran as the identifier

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Call koneksi()
                Dim dm1 As New OleDbCommand
                dm1.Connection = conn
                dm1.CommandType = CommandType.Text
                dm1.CommandText = "DELETE FROM DatabaseKTP WHERE [Nomor Pendaftaran] = ?"

                ' Adding parameter
                dm1.Parameters.AddWithValue("?", nomorPendaftaran) ' Nomor Pendaftaran for WHERE clause

                ' Execute the delete command
                dm1.ExecuteNonQuery()
                MsgBox("Data Telah Dihapus !!!")
                Call Tampildata() ' Refresh the DataGridView
            End If
        Else
            MsgBox("Silakan pilih data yang ingin dihapus.")
        End If
    End Sub
End Class

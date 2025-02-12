Imports System.Data.OleDb

Public Class Form1

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Visual Studio 2010\FORM_UAS\FORM_UAS\bin\Debug\Database5.accdb"
    Private conn As OleDbConnection
    Private da As OleDbDataAdapter
    Private cb As OleDbCommandBuilder
    Private ds As DataSet

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Connect to the Access database
        conn = New OleDbConnection(connectionString)

        Try
            'Open the connection
            conn.Open()

            'Create a data adapter
            da = New OleDbDataAdapter("SELECT NIK, Nama, Tempat_Tanggal_Lahir, Jenis_Kelamin, Alamat, RT_RW, Kel_Desa, Kecamatan, Agama, Status_Perkawinan, Pekerjaan, Kewarganegaraan, Berlaku_Hingga FROM TBL_uas", conn)

            'Create a dataset
            ds = New DataSet
            da.Fill(ds)

            'Bind the data to the DataGridView
            DG.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        rbBelumKawin.Visible = False
        rbKawin.Visible = False
    End Sub

    Private Sub Tambah_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTambah.Click
        'Add a new row to the DataGridView
        Dim newRow As DataRow = ds.Tables(0).NewRow()
        Dim nik As Integer
        If Integer.TryParse(txtNIK.Text, nik) Then
            ' Store the value in the NIK column
            newRow("NIK") = nik
        Else
            MessageBox.Show("Invalid NIK format. Please enter a valid integer.")
        End If
        Dim rtRw As Integer
        If Integer.TryParse(txtRTRW.Text, rtRw) Then
            ' Store the value in the RT_RW column
            newRow("RT_RW") = rtRw
        Else
            MessageBox.Show("Invalid RT_RW format. Please enter a valid integer.")
        End If
        Dim berlakuHingga As Integer
        If Integer.TryParse(txtBerlakuHingga.Text, berlakuHingga) Then
            ' Store the value in the Berlaku_Hingga column
            newRow("Berlaku_Hingga") = berlakuHingga
        Else
            MessageBox.Show("Invalid Berlaku_Hingga format. Please enter a valid integer.")
        End If
        newRow("NIK") = txtNIK.Text
        newRow("Nama") = txtNama.Text
        newRow("Tempat_Tanggal_Lahir") = txtTempattanggal.Text
        newRow("Jenis_Kelamin") = If(rbPria.Checked, "Pria", "Wanita")
        newRow("Alamat") = txtAlamat.Text
        newRow("RT_RW") = txtRTRW.Text
        newRow("Kel_Desa") = txtKelDesa.Text
        newRow("Kecamatan") = txtKecamatan.Text
        newRow("Agama") = cbAgama.Text
        newRow("Status_Perkawinan") = If(cbKawin.Checked, "Kawin", "Belum Kawin")
        newRow("Pekerjaan") = txtPekerjaan.Text
        newRow("Kewarganegaraan") = txtKewarganegaraan.Text
        newRow("Berlaku_Hingga") = txtBerlakuHingga.Text

        'Add the new row to the table
        ds.Tables(0).Rows.Add(newRow)

        'Clear the input fields
        ClearInputFields()
    End Sub

    Private Sub Simpan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSimpan.Click
        'Save the changes to the database
        Try
            conn.Open()
            da.Update(ds.Tables(0))
            conn.Close()
            MessageBox.Show("Data berhasil disimpan.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Edit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        'Edit the selected row in the DataGridView
        If DG.SelectedRows.Count > 0 Then
            'Get the selected row
            Dim row As DataRow = ds.Tables(0).Rows(DG.SelectedRows(0).Index)

            'Update the input fields
            txtNIK.Text = row("NIK")
            txtNama.Text = row("Nama")
            txtTempattanggal.Text = row("Tempat_Tanggal_Lahir")
            If row("Jenis_Kelamin") = "Pria" Then
                rbPria.Checked = True
            Else
                rbWanita.Checked = True
            End If
            txtAlamat.Text = row("Alamat")
            txtRTRW.Text = row("RT_RW")
            txtKelDesa.Text = row("Kel_Desa")
            txtKecamatan.Text = row("Kecamatan")
            cbAgama.Text = row("Agama")
            If row("Status_Perkawinan") = "Kawin" Then
                rbKawin.Checked = True
            Else
                rbBelumKawin.Checked = True
            End If
            txtPekerjaan.Text = row("Pekerjaan")
            txtKewarganegaraan.Text = row("Kewarganegaraan")
            txtBerlakuHingga.Text = row("Berlaku_Hingga")
        End If
    End Sub

    Private Sub Hapus_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHapus.Click
        'Delete the selected row from the DataGridView
        If DG.SelectedRows.Count > 0 Then
            'Confirm deletion
            If MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'Delete the row
                ds.Tables(0).Rows.RemoveAt(DG.SelectedRows(0).Index)
            End If
        End If
    End Sub

    Private Sub ClearInputFields()
        'Clear the input fields
        txtNIK.Text = ""
        txtNama.Text = ""
        txtTempattanggal.Text = ""
        rbPria.Checked = False
        rbWanita.Checked = False
        txtAlamat.Text = ""
        txtRTRW.Text = ""
        txtKelDesa.Text = ""
        txtKecamatan.Text = ""
        cbAgama.Text = ""
        rbKawin.Checked = False
        rbBelumKawin.Checked = False
        txtPekerjaan.Text = ""
        txtKewarganegaraan.Text = ""
        txtBerlakuHingga.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cbKawin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKawin.CheckedChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub rbKawin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbKawin.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
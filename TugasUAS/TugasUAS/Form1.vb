Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Identitas Peminjam" Then
            Form2.Show()
        End If
        If ComboBox1.SelectedItem = "Peminjaman,Pengembalian, Identitas Motor" Then
            Hide()
        End If
        If ComboBox1.SelectedItem = "Identitas Motor" Then
            Form3.Show()
        End If
        If ComboBox1.SelectedItem = "Identitas Peminjam" Then
            Hide()
        End If
        If ComboBox1.SelectedItem = "Data Rental" Then
            Form4.Show()
        End If
        If ComboBox1.SelectedItem = "Identitas Peminjam,Identitas Motor" Then
            Hide()
        End If
        If ComboBox1.SelectedItem = "Pengembalian" Then
            Form5.Show()
        End If
        If ComboBox1.SelectedItem = "Identitas Peminjam,Identitas Motor,Data Rental" Then
            Hide()
        End If
    End Sub
End Class

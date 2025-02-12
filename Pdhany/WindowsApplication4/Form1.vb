Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Anggota" Then
            Form2.Show()
        End If
        If ComboBox1.SelectedItem = "Anggota" Then
            Hide()
        End If
        If ComboBox1.SelectedItem = "Buku" Then
            Form3.Show()
        End If
        If ComboBox1.SelectedItem = "Anggota" Then
            Hide()
        End If
        If ComboBox1.SelectedItem = "Petugas" Then
            Form4.Show()
        End If
        If ComboBox1.SelectedItem = "Anggota,Buku" Then
            Hide()
        End If
        If ComboBox1.SelectedItem = "Pinjam" Then
            Form5.Show()
        End If
        If ComboBox1.SelectedItem = "Anggota,Buku,Petugas" Then
            Hide()
        End If
        If ComboBox1.SelectedItem = "Pinjam" Then
            Form6.Show()
        End If
        If ComboBox1.SelectedItem = "Anggota,Buku,Petugas,Pinjam" Then
            Hide()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

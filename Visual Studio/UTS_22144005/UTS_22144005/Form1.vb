Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Hitung Faktorial" Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
        End If
        If ComboBox1.SelectedItem = "Hitung Kombinasi" Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
        End If
        If ComboBox1.SelectedItem = "Hitung Pangkat" Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim faktorial As Integer
        Dim hasil As Integer
        Dim i As Integer
        faktorial = Val(TextBox1.Text)
        hasil = 1
        For i = 1 To faktorial
            hasil = hasil * i
        Next i
        TextBox2.Text = hasil
        If TextBox1.Text = " " Then
            TextBox2.Text = 0
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Dim n As Integer
        Dim r As Integer
        If Integer.TryParse(TextBox3.Text, n) AndAlso Integer.TryParse(TextBox4.Text, r) Then
            Dim numCombs As Integer = Combination(n, r)
            TextBox5.Text = numCombs
        End If
    End Sub

    Private Function Combination(ByVal n As Integer, ByVal r As Integer) As Integer
        If n < r Then
            Return 0
        Else
            Return Factorial(n) / (Factorial(r) * Factorial(n - r))
        End If
    End Function

    Private Function Factorial(ByVal n As Integer) As Integer
        If n = 0 Or n = 1 Then
            Return 1
        Else
            Return n * Factorial(n - 1)
        End If
    End Function

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        HitungPangkat()
    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        HitungPangkat()
    End Sub
    Private Function HitungPangkat() As Double
        Dim Angka As Double = Val(TextBox6.Text)
        Dim Pangkat As Double = Val(TextBox7.Text)
        Dim Hasil As Double = Math.Pow(Angka, Pangkat)
        TextBox8.Text = Hasil.ToString()
        Return Hasil
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.ResetText()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

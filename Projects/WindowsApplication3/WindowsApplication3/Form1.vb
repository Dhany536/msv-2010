Public Class Form1

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnilai.Enabled = False
        txthasil.Enabled = False
        txtcombn.Enabled = False
        txtcombm.Enabled = False
        txtcombnm.Enabled = False
        txtx.Enabled = False
        txty.Enabled = False
        txtxy.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtnilai_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnilai.TextChanged
        Dim faktorial As Integer
        Dim hasil As Integer
        Dim i As Integer
        faktorial = Val(txtnilai.Text)
        hasil = 1
        For i = 1 To faktorial
            hasil = hasil * i
        Next i
        txthasil.Text = hasil
        If txtnilai.Text = " " Then
            txthasil.Text = 0
        End If
    End Sub

    Private Sub cmb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb1.SelectedIndexChanged
        If cmb1.SelectedItem = "Hitung Faktorial" Then
            txtnilai.Enabled = True
            txthasil.Enabled = False
            txtcombn.Enabled = False
            txtcombm.Enabled = False
            txtcombnm.Enabled = False
            txtx.Enabled = False
            txty.Enabled = False
            txtxy.Enabled = False
        End If
        If cmb1.SelectedItem = "Hitung Combinasi" Then
            txtnilai.Enabled = False
            txthasil.Enabled = False
            txtcombn.Enabled = True
            txtcombm.Enabled = True
            txtcombnm.Enabled = False
            txtx.Enabled = False
            txty.Enabled = False
            txtxy.Enabled = False
        End If
        If cmb1.SelectedItem = "Hitung Pangkat" Then
            txtnilai.Enabled = False
            txthasil.Enabled = False
            txtcombn.Enabled = False
            txtcombm.Enabled = False
            txtcombnm.Enabled = False
            txtx.Enabled = True
            txty.Enabled = True
            txtxy.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtnilai.Text = ""
        txthasil.Text = ""
        txtcombn.Text = ""
        txtcombm.Text = ""
        txtcombnm.Text = ""
        txtx.Text = ""
        txty.Text = ""
        txtxy.Text = ""
    End Sub

    Private Sub txtcombm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcombm.TextChanged
        Dim n As Integer
        Dim r As Integer
        If Integer.TryParse(txtcombn.Text, n) AndAlso Integer.TryParse(txtcombm.Text, r) Then
            Dim numCombs As Integer = Combination(n, r)
            txtcombnm.Text = numCombs
        End If
    End Sub

    Private Function combination(ByVal n As Integer, ByVal r As Integer) As Integer
        If n < r Then
            Return 0
        Else
            Return factorial(n) / (factorial(r) * factorial(n - r))

        End If
    End Function
    Private Function factorial(ByVal n As Integer) As Integer
        If n = 0 Or n = 1 Then
            Return 1
        Else
            Return n * factorial(n - 1)
        End If
    End Function

    Private Function HitungPangkat() As Double
        Dim angka As Double = Val(txtx.Text)
        Dim pangkat As Double = Val(txty.Text)
        Dim hasil As Double = Math.Pow(angka, pangkat)
        txtxy.Text = hasil.ToString()
        Return hasil
    End Function

    Private Sub txtx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtx.TextChanged
        HitungPangkat()
    End Sub

    Private Sub txty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txty.TextChanged
        HitungPangkat()
    End Sub
End Class

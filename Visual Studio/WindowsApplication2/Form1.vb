Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbcombinasi.Checked = False
        rbfaktorial.Checked = False
        txtnilaifaktorial.Enabled = False
        txthasilfaktorial.Enabled = False
        txtcombn.Enabled = False
        txtcombm.Enabled = False
        txtcombnm.Enabled = False
    End Sub

    Private Sub rbfaktorial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfaktorial.CheckedChanged
        If rbfaktorial.Checked = True Then
            txtnilaifaktorial.Enabled = True
            txthasilfaktorial.Enabled = True
        Else
            txtnilaifaktorial.Enabled = False
            txthasilfaktorial.Enabled = False
        End If
    End Sub

    Private Sub rbcombinasi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcombinasi.CheckedChanged
        If rbcombinasi.Checked = True Then
            txtcombn.Enabled = True
            txtcombm.Enabled = True
            txtcombnm.Enabled = True
        Else
            txtcombn.Enabled = False
            txtcombm.Enabled = False
            txtcombnm.Enabled = False
        End If
    End Sub

    Private Sub btncobalagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncobalagi.Click
        rbfaktorial.Checked = False
        rbcombinasi.Checked = False
        txtnilaifaktorial.Text = ""
        txthasilfaktorial.Text = ""
        txtcombn.Text = ""
        txtcombm.Text = ""
        txtcombnm.Text = ""
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub txtnilaifaktorial_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtnilaifaktorial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnilaifaktorial.TextChanged
        Dim faktorial As Integer
        Dim hasil As Integer
        Dim i As Integer
        faktorial = Val(txtnilaifaktorial.Text)
        hasil = 1
        For i = 1 To faktorial
            hasil = hasil * i
        Next i
        txthasilfaktorial.Text = hasil
        If txtnilaifaktorial.Text = " " Then
            txthasilfaktorial.Text = 0
        End If
    End Sub

    Private Sub txtcombm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcombm.TextChanged
        Dim i, j, k, l, m, n, o, q As Integer
        n = 1
        k = 1
        o = 1
        i = Val(txtcombn.Text) - Val(txtcombm.Text)
        For j = 1 To Val(txtcombn.Text)
            n = n * j
        Next j
        For l = 1 To Val(txtcombm.Text)
            k = k * 1
        Next l
        For m = 1 To i
            o = o * m
        Next m
        q = n / (o * k)
        txtcombnm.Text = q

    End Sub
End Class

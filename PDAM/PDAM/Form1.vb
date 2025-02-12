Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txttotpakai.Text = Val(txtskrg.Text - txtlalu.Text)

        If Val(txttotpakai.Text) <= 10 Then
            txttama.Text = Val(txttotpakai.Text) * 1000
            txtduwa.Text = 0
            txttiga.Text = 0
            txtlebih.Text = 0

        ElseIf Val(txttotpakai.Text) <= 20 Then
            txttama.Text = 10 * 1000
            txtduwa.Text = (Val(txttotpakai.Text) - 10) * 1500
            txttiga.Text = 0
            txtlebih.Text = 0
        ElseIf Val(txttotpakai.Text) <= 20 Then
            txttama.Text = 10 * 1000
            txtduwa.Text = 10 * 1500
            txttiga.Text = (Val(txttotpakai.Text) - 20) * 2000
            txtlebih.Text = 0
        ElseIf Val(txttotpakai.Text) <= 20 Then
            txttama.Text = 10 * 1000
            txtduwa.Text = 10 * 1500
            txttiga.Text = 10 * 2000
            txtlebih.Text = (Val(txttotpakai.Text) - 30) * 2500
        End If

        txttotbayar.Text = Val(txttama.Text + txtduwa.Text + txttiga.Text + txtlebih.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

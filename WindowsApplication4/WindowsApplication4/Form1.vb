Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        Me.txtnpm.Text = ""
        Me.txtnama.Text = ""
        Me.txtuts.Text = ""
        Me.txtuas.Text = ""
        Me.txtnilai.Text = ""
        Me.txtakhir.Text = ""
        Me.txthuruf.Text = ""
        Me.lblhuruf.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnpm.TextChanged

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim TGSQZ As Integer
        Dim UTS As Integer
        Dim UAS As Integer
        Dim NA As Integer

        TGSQZ = txtnilai.Text
        UTS = txtuts.Text
        UAS = txtuas.Text

        NA = (TGSQZ + UTS + UAS) / 3
        txtakhir.Text = NA

        Select Case NA
            Case 86 To 100
                txthuruf.Text = "A"
                lblhuruf.Text = "Sangat Mmemuaskan"
            Case 76 To 85
                txthuruf.Text = "B"
                lblhuruf.Text = "BAIK"
            Case 56 To 75
                txthuruf.Text = "C"
                lblhuruf.Text = "CUKUP"
            Case 46 To 55
                txthuruf.Text = "D"
                lblhuruf.Text = "KURANG"
            Case 0 To 45
                txthuruf.Text = "E"
                lblhuruf.Text = "ELEK"
        End Select


    End Sub

    Private Sub btnEX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEX.Click
        Me.Close()
    End Sub
End Class

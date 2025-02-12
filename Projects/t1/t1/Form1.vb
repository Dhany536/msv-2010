Public Class Form1

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        Dim lalu, sekarang, total As Double
        lalu = Val(txtlalu.Text)
        sekarang = Val(txtsekarang.Text)
        total = sekarang - lalu
        txttotal.Text = total

        txttotal.Text = total.ToString()

        Dim a1 As Integer
        Dim a2 As Integer
        Dim a3 As Integer
        Dim a4 As Integer

        If cmb1.SelectedItem = "Gol 1" Then
            a1 = 1000
            a2 = 1500
            a3 = 2000
            a4 = 2500
        ElseIf cmb1.SelectedItem = "Gol 2" Then
            a1 = 2000
            a2 = 2500
            a3 = 3000
            a4 = 3500
        ElseIf cmb1.SelectedItem = "Gol 3" Then
            a1 = 3000
            a2 = 3500
            a3 = 4000
            a4 = 4500
        End If

        Dim total1 As Integer = 0
        Dim total2 As Integer = 0
        Dim total3 As Integer = 0
        Dim total4 As Integer = 0

        If total <= 10 Then
            total1 = total * a1
        ElseIf total <= 20 Then
            total1 = 10 * a1
            total2 = (total - 10) * a2
        ElseIf total <= 30 Then
            total1 = 10 * a1
            total2 = 10 * a2
            total3 = (total - 20) * a3
        ElseIf total <= 40 Then
            total1 = 10 * a1
            total2 = 10 * a2
            total3 = 10 * a3
            total4 = (total - 30) * a4
        End If

        txtpertama.Text = total1.ToString()
        txtkedua.Text = total2.ToString()
        txtketiga.Text = total3.ToString()
        txtselebihnya.Text = total4.ToString()

        Dim bayar As Integer = total1 + total2 + total3 + total4
        txtbayar.Text = bayar.ToString()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fillcmb1()
    End Sub

    Private Sub fillcmb1()
        Dim items As String() = {"Gol 1", "Gol 2", "Gol 3"}
        cmb1.Items.AddRange(items)
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class

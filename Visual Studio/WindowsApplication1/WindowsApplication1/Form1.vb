Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillComboBox()
    End Sub

    Private Sub FillComboBox()
        Dim items As String() = {"GOL 1", "GOL 2", "GOL 3"}
        ComboBox1.Items.AddRange(items)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtLalu As Integer = Integer.Parse(TextBox3.Text)
        Dim txtSekarang As Integer = Integer.Parse(TextBox4.Text)
        Dim total As Integer = txtSekarang - txtLalu

        TextBox5.Text = total.ToString()

        Dim a1 As Integer
        Dim a2 As Integer
        Dim a3 As Integer
        Dim a4 As Integer

        If ComboBox1.SelectedItem = "GOL 1" Then
            a1 = 1000
            a2 = 1500
            a3 = 2000
            a4 = 2500
        ElseIf ComboBox1.SelectedItem = "GOL 2" Then
            a1 = 2000
            a2 = 2500
            a3 = 3000
            a4 = 3500
        ElseIf ComboBox1.SelectedItem = "GOL 3" Then
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

        TextBox6.Text = total1.ToString()
        TextBox7.Text = total2.ToString()
        TextBox8.Text = total3.ToString()
        TextBox9.Text = total4.ToString()

        Dim totalBayar As Integer = total1 + total2 + total3 + total4
        TextBox10.Text = totalBayar.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

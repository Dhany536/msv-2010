Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nama() As String = {"Ganjil......", "Genap.....", "Prima.....", "Fibo....."}
        For Each Bil In nama
            ComboBox1.Items.Add(Bil)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strGanjil, strGenap, strPrima, strFibo As Integer
        proses(strGanjil, strGenap, strPrima, strFibo)
        ShowSum(txtbilsatu.text, txtbildua.text)
    End Sub
    Sub ShowSum(ByVal intNum1 As Integer, ByVal intNum2 As Integer)
        Dim intSum As Integer
        intSum = intNum1 + intNum2
        txthasil.text = intSum
    End Sub
    Sub Proses(ByVal strGanjil As String, ByVal strGenap As String, ByVal strPrima As String, ByVal strFibo As String)
        
    End Sub
    Sub BilGanjil()
        Dim ganjil As Integer
        bilangan.items.clear()
        ganjil = 1
        Do While ganjil <= 20
            bilangan.items.add(ganjil)
            ganjil = ganjil + 2
        Loop
    End Sub
    Sub BilGenap()
        Dim Genap As Integer
        bilangan.items.clear()
        Genap = 0
        Do While Genap <= 20
            bilangan.Items.Add(Genap)
            Genap = Genap + 2
        Loop
    End Sub
    Sub BilPrima()
        Dim Prima As Integer
        bilangan.items.clear()
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        For x = 2 To 100
            z = 0
            For y = 2 To x
                Prima = x Mod y
                If Prima = 0 Then
                    z = z + 1
                End If
            Next y
            If z <= 1 Then
                bilangan.items.add(x)
            End If
        Next x
    End Sub
    Sub bilFibo()
        bilangan.items.clear()
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim fib As Integer = 0
        'bilangan.items.add("1")
        Do
            fib = a + b
            a = b
            b = fib
            bilangan.items.add(fib.ToString)
        Loop While fib <= 100
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex.Equals(0)) Then
            BilGanjil()
        ElseIf (ComboBox1.SelectedIndex.Equals(1)) Then
            BilGenap()
        ElseIf (ComboBox1.SelectedIndex.Equals(2)) Then
            BilPrima()
        ElseIf (ComboBox1.SelectedIndex.Equals(3)) Then
            bilFibo()
        End If
    End Sub

    Private Sub txtbildua_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbildua.TextChanged
        ShowSum(txtbilsatu.Text, txtbildua.Text)
    End Sub
End Class


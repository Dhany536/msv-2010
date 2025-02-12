Public Class FormFungsi2
    Private Sub FormFungsi2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim nama() As String = {"Ganjil.....", "Genap.....", "Prima.....", "Fibo....."}
        For Each Bil In nama
            ComboBox1.Items.Add(Bil)
        Next
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneqit.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strGanjil, strGenap, strPrima, strFibo As Integer
        proses(strGanjil, strGenap, strPrima, strFibo)
        ShowSum(txtbilsatu.Text, txtbildua.Text)
    End Sub
    Sub ShowSum(ByVal intNum1 As Integer, ByVal intNum2 As Integer)
        Dim intSum As Integer
        intSum = intNum1 + intNum2
        txthasil.Text = intSum
    End Sub
    Sub proses(ByVal strGanjil As String, ByVal strGenap As String, ByVal strPrima As String, ByVal strFibo As String)
        If (ComboBox1.SelectedIndex.Equals(0)) Then
            BilGanjil()
        ElseIf (ComboBox1.SelectedIndex.Equals(1)) Then
            BilGenap()
        ElseIf (ComboBox1.SelectedIndex.Equals(2)) Then
            BilPrima()
        ElseIf (ComboBox1.SelectedIndex.Equals(3)) Then
            BilFibo()
        End If
    End Sub
    Sub BilGanjil()
        Dim ganjil As Integer
        bilangan.Items.Clear()
        ganjil = 1
        Do While ganjil <= 20
            bilangan.Items.Add(ganjil)
            ganjil = ganjil + 2
        Loop
    End Sub
    Sub BilGenap()
        Dim genap As Integer
        bilangan.Items.Clear()
        genap = 0
        Do While genap <= 20
            bilangan.Items.Add(genap)
            genap = genap + 2
        Loop
    End Sub
    Sub BilPrima()
        Dim prima As Integer
        bilangan.Item.Clear()
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        For x = 2 To 100
            z = 0
            For y = 2 To x
                prima = x Mod y
                If prima = 0 Then
                    z = z + 1
                End If
            Next y
            If z <= 1 Then
                bilangan.Items.Add(x)
            End If
        Next x
    End Sub
    Sub BilFibo()
        bilangan.Items.Clear()
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim fib As Integer = 0
        'bilangan.Items.Add("1")
        Do
            fib = a + b
            a = b
            b = fib
            bilangan.Items.Add(fib.ToString)
        Loop While fib <= 100
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bilangan.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        
    End Sub
End Class

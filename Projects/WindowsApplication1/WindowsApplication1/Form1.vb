Public Class Form1

    Private Sub btntampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntampil.Click
        Dim kata As String
        kata = "so what gitu loh "
        If chklaki.Checked = True Then
            kata = kata + " gue kan ganteng "
        End If
        If chkperempuan.Checked = True Then
            kata = kata + " gue kan cantik "
        End If
        txttampil.Text = kata

    End Sub
End Class

Public Class Form1
    Dim kesempatan As Byte 'tambah ini
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtuser.Text = "Dhany" And txtpass.Text = "miegoreng" Then
            MsgBox("Selamat Datang", MsgBoxStyle.Information, "Login Berhasil")
            Me.Hide()
            'FormMenu.Show()
        ElseIf txtuser.Text = "COC" And txtpass.Text = "barbarian" Then
            MsgBox("Selamat Datang", MsgBoxStyle.Information, "Login Success")
            Me.Hide()
            'FormMenu.Show()
        Else
            MsgBox("Maaf!, Passwordmu salah cuk!", MsgBoxStyle.Information, "Login Gagal,baleni")
            txtuser.Text = ""
            txtpass.Text = ""
            txtuser.Focus()
            kesempatan = kesempatan + 1 'tambah ini
            If kesempatan >= 3 Then
                MsgBox("Maaf!, Anda sudah" & kesempatan & "kali salah!", MsgBoxStyle.Information, "Login Gagal") ' tambah ini
                End 'tambah ini
            End If

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpass.PasswordChar = "*"
        kesempatan = 0 'tambah ini
    End Sub
End Class
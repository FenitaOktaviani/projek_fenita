Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_pass.UseSystemPasswordChar = True
        connect()
    End Sub

    Private Sub b_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_login.Click
        If tb_username.Text = "admin" And tb_pass.Text = "lupa" Then
            MsgBox("Login Berhasil", MsgBoxStyle.Information, "INFORMASI")
            Me.Hide()
            MenuUtama.Show()
        Else
            MsgBox("Maaf Masukan Username/Password Dengan Benar !!", MsgBoxStyle.Exclamation, "PERINGATAN")
            tb_username.Clear()
            tb_pass.Clear()
            tb_username.Focus()
        End If
    End Sub

   
    Private Sub cb_showpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_showpass.CheckedChanged
        If cb_showpass.Checked Then
            tb_pass.UseSystemPasswordChar = False
        Else
            tb_pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub b_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cancel.Click
        Me.Close()
    End Sub
End Class

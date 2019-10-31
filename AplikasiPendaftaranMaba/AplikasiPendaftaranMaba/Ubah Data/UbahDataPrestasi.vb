Imports MySql.Data.MySqlClient
Public Class UbahDataPrestasi

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuUbah.Show()
    End Sub

    Sub data()
        Dim query As String = "select*from tb_prestasi where No_Regristrasi='" & tb_noreg.Text & "'"
        cmd = New MySqlCommand(query, conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            tb_namaPres.Text = baca.Item("Prestasi")
            tb_thpres.Text = baca.Item("Tahun")
        End If
        baca.Close()
        
    End Sub

    Private Sub tb_noreg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_noreg.TextChanged
        connect()
        data()
    End Sub

    Sub clear()
        tb_noreg.Clear()
        tb_namaPres.Clear()
        tb_thpres.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        reg = tb_noreg.Text
        namaPres = tb_namaPres.Text
        thnPres = tb_thpres.Text

        UpdateDataPres()
        clear()
        Me.Hide()
        MenuUbah.Show()
    End Sub
End Class
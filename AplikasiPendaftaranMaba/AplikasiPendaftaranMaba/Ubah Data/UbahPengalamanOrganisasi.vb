Imports MySql.Data.MySqlClient
Public Class UbahPengalamanOrganisasi

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuUbah.Show()
    End Sub

    Sub data()
        Dim query As String = "select*from tb_organisasi where No_Regristrasi='" & tb_noreg.Text & "'"
        cmd = New MySqlCommand(query, conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            tb_namaOr.Text = baca.Item("Nama_Organisasi")
            tb_sbg.Text = baca.Item("Sebagai")
            tb_thOrg.Text = baca.Item("Tahun")
        End If
        baca.Close()
    End Sub

    Private Sub tb_noreg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_noreg.TextChanged
        connect()
        data()
    End Sub

    Sub clear()
        tb_noreg.Clear()
        tb_namaOr.Clear()
        tb_sbg.Clear()
        tb_thOrg.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        reg = tb_noreg.Text
        namaOr = tb_namaOr.Text
        sbg = tb_sbg.Text
        thnOr = tb_thOrg.Text

        UpdateDataOrg()
        clear()
        Me.Hide()
        MenuUbah.Show()
    End Sub
End Class
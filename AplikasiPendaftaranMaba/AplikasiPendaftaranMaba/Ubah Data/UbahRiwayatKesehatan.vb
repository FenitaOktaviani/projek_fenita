Imports MySql.Data.MySqlClient
Public Class UbahRiwayatKesehatan

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuUbah.Show()
    End Sub

    Sub data()
        Dim query As String = "select*from tb_kesehatan where No_Regristrasi='" & tb_noreg.Text & "'"
        cmd = New MySqlCommand(query, conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            tb_namaPeny.Text = baca.Item("Nama_Penyakit")
            tb_thPeny.Text = baca.Item("Tahun")
        End If
        baca.Close()
    End Sub


    Private Sub tb_noreg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_noreg.TextChanged
        connect()
        data()
    End Sub

    Sub clear()
        tb_noreg.Clear()
        tb_namaPeny.Clear()
        tb_thPeny.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        reg = tb_noreg.Text
        namaPen = tb_namaPeny.Text
        thnPen = tb_thPeny.Text

        UpdateDataKes()
        clear()
        Me.Hide()
        MenuUbah.Show()
    End Sub
End Class
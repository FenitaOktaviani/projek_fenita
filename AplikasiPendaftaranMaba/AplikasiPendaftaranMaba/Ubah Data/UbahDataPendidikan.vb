Imports MySql.Data.MySqlClient
Public Class UbahDataPendidikan

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuUbah.Show()
    End Sub

    Sub data()
        Dim query As String = "select*from tb_pendidikan where No_Regristrasi='" & tb_noreg.Text & "'"
        cmd = New MySqlCommand(query, conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            tb_tk.Text = baca.Item("TK")
            tb_thTk.Text = baca.Item("Tahun_Masuk_TK")
            tb_sd.Text = baca.Item("SD")
            tb_thSd.Text = baca.Item("Tahun_Masuk_SD")
            tb_smp.Text = baca.Item("SMP")
            tb_thSmp.Text = baca.Item("Tahun_Masuk_SMP")
            tb_sma.Text = baca.Item("SMA")
            tb_thSma.Text = baca.Item("Tahun_Masuk_SMA")
            tb_jur.Text = baca.Item("Jurusan")
        End If
        baca.Close()
    End Sub

    Private Sub tb_noreg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_noreg.TextChanged
        connect()
        data()
    End Sub

    Sub clear()
        tb_noreg.Clear()
        tb_tk.Clear()
        tb_thTk.Clear()
        tb_sd.Clear()
        tb_thSd.Clear()
        tb_smp.Clear()
        tb_thSmp.Clear()
        tb_sma.Clear()
        tb_thSma.Clear()
        tb_jur.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        reg = tb_noreg.Text
        tk = tb_tk.Text
        thTK = tb_thTk.Text
        sd = tb_sd.Text
        thSD = tb_thSd.Text
        smp = tb_smp.Text
        thSMP = tb_thSmp.Text
        sma = tb_sma.Text
        thSMA = tb_thSma.Text
        jur = tb_jur.Text

        UpdateDataPendidikan()
        clear()
        Me.Hide()
        MenuUbah.Show()
    End Sub
End Class
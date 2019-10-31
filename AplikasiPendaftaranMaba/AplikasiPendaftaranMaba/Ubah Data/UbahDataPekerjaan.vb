Imports MySql.Data.MySqlClient
Public Class UbahDataPekerjaan

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuUbah.Show()
    End Sub

    Sub data()
        Dim query As String = "select*from tb_pekerjaan where No_Regristrasi = '" & tb_noreg.Text & "'"
        cmd = New MySqlCommand(query, conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            tb_intansi.Text = baca.Item("Nama_Instansi")
            tb_almtIns.Text = baca.Item("Alamat_Instansi")
            tb_telp.Text = baca.Item("Telepon")
            cb_bln.Text = baca.Item("Mulai_Bekerja")
            tb_thn.Text = baca.Item("Tahun")
            tb_jab.Text = baca.Item("Jabatan")
        End If
        baca.Close()
    End Sub

    Private Sub tb_noreg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_noreg.TextChanged
        connect()
        data()
    End Sub

    Sub clear()
        tb_noreg.Clear()
        tb_intansi.Clear()
        tb_almtIns.Clear()
        tb_telp.Clear()
        cb_bln.ResetText()
        tb_thn.Clear()
        tb_jab.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        reg = tb_noreg.Text
        namaIn = tb_intansi.Text
        almtIn = tb_almtIns.Text
        telpIn = tb_telp.Text
        blnmulai = cb_bln.Text
        thnmulai = tb_thn.Text
        jabatan = tb_jab.Text

        UpdateDataPekerjaan()
        clear()
        Me.Hide()
        MenuUbah.Show()
    End Sub
End Class
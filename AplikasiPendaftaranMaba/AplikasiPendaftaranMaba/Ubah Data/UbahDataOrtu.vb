Imports MySql.Data.MySqlClient
Public Class UbahDataOrtu
    
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuUbah.Show()
    End Sub

    Sub dataAyah()
        Dim query As String = "select*from tb_ayah where No_Regristrasi='" & tb_noreg.Text & "'"
        cmd = New MySqlCommand(query, conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            tb_namaA.Text = baca.Item("Nama_Ayah")
            DateTimePicker1.Text = baca.Item("Tanggal_Lahir")
            tb_pekA.Text = baca.Item("Pekerjaan")
            tb_nohpA.Text = baca.Item("Nomer_Hp")
            tb_almtA.Text = baca.Item("Alamat")
        End If
        baca.Close()
    End Sub

    Sub dataIbu()
        Dim query As String = "select*from tb_ibu where No_Regristrasi='" & tb_noreg.Text & "'"
        cmd = New MySqlCommand(query, conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            tb_namaI.Text = baca.Item("Nama_Ibu")
            DateTimePicker2.Text = baca.Item("Tanggal_Lahir")
            tb_pekI.Text = baca.Item("Pekerjaan")
            tb_nohpI.Text = baca.Item("No_Hp")
            tb_almtI.Text = baca.Item("Alamat")
        End If
        baca.Close()
    End Sub

    Private Sub tb_noreg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_noreg.TextChanged
        connect()
        dataAyah()
        dataIbu()
    End Sub

    Sub clear()
        tb_noreg.Clear()
        tb_namaA.Clear()
        tb_pekA.Clear()
        tb_nohpA.Clear()
        tb_almtA.Clear()

        tb_namaI.Clear()
        tb_pekI.Clear()
        tb_nohpI.Clear()
        tb_almtI.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        reg = tb_noreg.Text
        namaA = tb_namaA.Text
        tglA = DateTimePicker1.Text
        pekA = tb_pekA.Text
        nohpA = tb_nohpA.Text
        almtA = tb_almtA.Text

        namaI = tb_namaI.Text
        tglI = DateTimePicker2.Text
        pekI = tb_pekI.Text
        nohpI = tb_nohpI.Text
        almtI = tb_almtI.Text

        If MsgBox("apakah anda yakin ingin mengubahnya? ", vbOK) = MsgBoxResult.Ok = True Then
            UpdateDataAyah()
            UpdateDataIbu()
            MsgBox("Data Berhasil Diubah")
            clear()
            Me.Hide()
            MenuUbah.Show()
        End If
        
    End Sub
End Class
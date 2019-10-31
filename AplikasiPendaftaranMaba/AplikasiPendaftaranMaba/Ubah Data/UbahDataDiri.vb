Imports MySql.Data.MySqlClient
Public Class UbahDataDiri

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuUbah.Show()
    End Sub

    Sub data()
        Dim kls As String
        Dim jk As String
        Dim ji As String
        Dim ss As String
        Dim query As String = "select*from tb_datadiri where No_Regristrasi='" & tb_noreg.Text & "'"
        cmd = New MySqlCommand(query, conn)
        baca = cmd.ExecuteReader
        baca.Read()
        If baca.HasRows Then
            cb_prodi.Text = baca.Item("Prodi")

            kls = baca.Item("Kelas")
            If kls = "Reguler" Then
                rb_regular.Checked = True
            Else
                rb_karyawan.Checked = True
            End If

            tb_nama.Text = baca.Item("Nama_Lengkap")
            DateTimePicker1.Text = baca.Item("Tanggal_Lahir")

            jk = baca.Item("Jenis_Kelamin")
            If jk = "Laki-laki" Then
                rb_laki.Checked = True
            Else
                rb_perem.Checked = True
            End If

            ji = baca.Item("Jenis_Identitas")
            If ji = "KTP" Then
                rb_ktp.Checked = True
            ElseIf ji = "Paspor" Then
                rb_paspor.Checked = True
            Else
                rb_sim.Checked = True
            End If

            tb_noid.Text = baca.Item("No_Identitas")
            tb_ngr.Text = baca.Item("Kewarganegaraan")
            cb_agama.Text = baca.Item("Agama")

            ss = baca.Item("Status_Sipil")
            If ss = "Menikah" Then
                rb_nkh.Checked = True
            ElseIf ss = "Belum Menikah" Then
                rb_blmnkh.Checked = True
            ElseIf ss = "Janda" Then
                rb_janda.Checked = True
            Else
                rb_duda.Checked = True
            End If

            tb_alamat.Text = baca.Item("Alamat")
        End If
        baca.Close()
    End Sub

    Private Sub UbahDataDiri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cb_prodi
            .Items.Add("S1 Manajemen")
            .Items.Add("S1 Akuntansi")
            .Items.Add("S1 Teknik Informatika")
            .Items.Add("D3 Manajemen Informatika")
            .Items.Add("S1 Bahasa Jepang")
            .Items.Add("D3 Bahasa Inggris")
            .Items.Add("S1 Psikologi")
        End With
        With cb_agama
            .Items.Add("Islam")
            .Items.Add("Khatolik")
            .Items.Add("Protestan")
            .Items.Add("Hindu")
            .Items.Add("Budha")
        End With
    End Sub

    Private Sub tb_noreg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_noreg.TextChanged
        connect()
        data()
    End Sub

    Sub clear()
        tb_noreg.Clear()
        rb_regular.Checked = False
        rb_karyawan.Checked = False
        cb_prodi.ResetText()
        tb_nama.Clear()
        rb_laki.Checked = False
        rb_perem.Checked = False
        rb_ktp.Checked = False
        rb_paspor.Checked = False
        rb_sim.Checked = False
        tb_noid.Clear()
        tb_ngr.Clear()
        cb_agama.ResetText()
        rb_nkh.Checked = False
        rb_blmnkh.Checked = False
        rb_janda.Checked = False
        rb_duda.Checked = False
        tb_alamat.Clear()
    End Sub

    Private Sub bt_ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ubah.Click
        reg = tb_noreg.Text

        If rb_regular.Checked Then
            kls = "Reguler"
        Else
            kls = "Karyawan"
        End If

        prodi = cb_prodi.Text
        namadd = tb_nama.Text
        tgl = DateTimePicker1.Text

        If rb_laki.Checked = True Then
            jk = "Laki-laki"
        Else
            jk = "Perempuan"
        End If

        If rb_ktp.Checked = True Then
            ident = "KTP"
        ElseIf rb_paspor.Checked = True Then
            ident = "PASPOR"
        Else
            ident = "SIM"
        End If

        noid = tb_noid.Text
        wrgNegara = tb_ngr.Text
        agm = cb_agama.Text

        If rb_nkh.Checked = True Then
            ss = "Menikah"
        ElseIf rb_blmnkh.Checked = True Then
            ss = "Belum Menikah"
        ElseIf rb_janda.Checked Then
            ss = "Janda"
        Else
            ss = "Duda"
        End If

        almtdd = tb_alamat.Text

        UpdateDataDiri()
        clear()
        Me.Hide()
        MenuUbah.Show()
    End Sub
End Class
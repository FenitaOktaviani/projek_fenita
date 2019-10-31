Public Class DataDiri

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        reg = tb_noreg.Text

        If rb_reguler.Checked Then
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
        agm = cb_agm.Text

        If rb_nkh.Checked = True Then
            ss = "Menikah"
        ElseIf rb_blmkwn.Checked = True Then
            ss = "Belum Menikah"
        ElseIf rb_janda.Checked Then
            ss = "Janda"
        Else
            ss = "Duda"
        End If

        almtdd = tb_almt.Text

        If (String.IsNullOrEmpty(tb_nama.Text.Trim())) Then
            MsgBox("Masukan Nama ", MsgBoxStyle.Exclamation)
        ElseIf tb_noid.MaxLength <= 16 Then
            MsgBox("masukan NIK sebanyak 16 digit", MsgBoxStyle.Exclamation)
        ElseIf (String.IsNullOrEmpty(tb_ngr.Text.Trim())) Then
            MsgBox("Masukan Kewarganegaraan ", MsgBoxStyle.Exclamation)
        ElseIf (String.IsNullOrEmpty(tb_almt.Text.Trim())) Then
            MsgBox("Masukan Alamat ", MsgBoxStyle.Exclamation)
        Else
            DataOrtu.Show()
            Me.Hide()
        End If

    End Sub

    Sub clear1()
        tb_noreg.Clear()
        rb_reguler.Checked = False
        rb_karyawan.Checked = False
        cb_prodi.ResetText()
        tb_nama.Clear()
        rb_laki.Checked = False
        rb_peremp.Checked = False
        rb_ktp.Checked = False
        rb_paspor.Checked = False
        rb_sim.Checked = False
        tb_noid.Clear()
        tb_ngr.Clear()
        cb_agm.ResetText()
        rb_nkh.Checked = False
        rb_blmkwn.Checked = False
        rb_janda.Checked = False
        rb_duda.Checked = False
        tb_almt.Clear()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuUtama.Show()
    End Sub

    Private Sub DataDiri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_noreg.Enabled = False
        rb_reguler.Checked = False
        rb_karyawan.Checked = False
        rb_laki.Checked = False
        rb_peremp.Checked = False
        rb_ktp.Checked = False
        rb_paspor.Checked = False
        rb_sim.Checked = False
        rb_blmkwn.Checked = False
        rb_nkh.Checked = False
        rb_janda.Checked = False
        rb_duda.Checked = False

        With cb_prodi
            .Items.Add("S1 Manajemen")
            .Items.Add("S1 Akuntansi")
            .Items.Add("S1 Teknik Informatika")
            .Items.Add("D3 Manajemen Informatika")
            .Items.Add("S1 Bahasa Jepang")
            .Items.Add("D3 Bahasa Inggris")
            .Items.Add("S1 Psikologi")
        End With

        With cb_agm
            .Items.Add("Islam")
            .Items.Add("Khatolik")
            .Items.Add("Protestan")
            .Items.Add("Hindu")
            .Items.Add("Budha")
        End With

        tb_noid.MaxLength = 16
    End Sub

    Private Sub tb_nama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_nama.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_noid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_noid.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_ngr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_ngr.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class
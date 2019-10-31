Public Class nextpendaftaran
   
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        DataOrtu.Show()
    End Sub

    Sub clear3()
        tb_namaIn.Clear()
        tb_almtIn.Clear()
        tb_tlpIn.Clear()
        cb_blnmulai.ResetText()
        tb_thnMulai.Clear()
        tb_jab.Clear()

        tb_tk.Clear()
        tb_thnTK.Clear()
        tb_sd.Clear()
        tb_thnSD.Clear()
        tb_smp.Clear()
        tb_thnSMP.Clear()
        tb_sma.Clear()
        tb_thnSMA.Clear()
        tb_jur.Clear()

        tb_namaPeny.Clear()
        tb_thnPeny.Clear()

        tb_namaOr.Clear()
        tb_sbg.Clear()
        tb_thnOr.Clear()

        tb_namaPres.Clear()
        tb_thnPres.Clear()
    End Sub

    Private Sub b_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_save.Click
        namaIn = tb_namaIn.Text
        almtIn = tb_almtIn.Text
        telpIn = tb_tlpIn.Text
        blnmulai = cb_blnmulai.Text
        thnmulai = tb_thnMulai.Text
        jabatan = tb_jab.Text

        tk = tb_tk.Text
        thTK = tb_thnTK.Text
        sd = tb_sd.Text
        thSD = tb_thnSD.Text
        smp = tb_smp.Text
        thSMP = tb_thnSMP.Text
        sma = tb_sma.Text
        thSMA = tb_thnSMA.Text
        jur = tb_jur.Text

        namaPen = tb_namaPeny.Text
        thnPen = tb_thnPeny.Text

        namaOr = tb_namaOr.Text
        sbg = tb_sbg.Text
        thnOr = tb_thnOr.Text

        namaPres = tb_namaPres.Text
        thnPres = tb_thnPres.Text

        connect()

        If MsgBox("Apakah Anda yakin ingin menyimpan data?", vbOKCancel, "Konfirmasi") = MsgBoxResult.Ok = True Then
            insertDataDiri()
            insertDataAyah()
            insertDataIbu()
            insertDataPekerjaan()
            insertDataPendidikan()
            insertDataKesehatan()
            insertDataOrganisasi()
            insertDataPrestasi()
            MsgBox("insert Data berhasil dan data telah Tersimpan", MsgBoxStyle.Information, "Informasi")
            DataDiri.clear1()
            DataOrtu.clear2()
            clear3()
            Me.Hide()
            MenuUtama.Show()
        ElseIf MsgBoxResult.Cancel Then
            Me.Show()
        End If

    End Sub

    Private Sub nextpendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cb_blnmulai
            .Items.Add("Januari")
            .Items.Add("Februari")
            .Items.Add("Maret")
            .Items.Add("April")
            .Items.Add("Mei")
            .Items.Add("Juni")
            .Items.Add("Juli")
            .Items.Add("Agustus")
            .Items.Add("September")
            .Items.Add("Oktober")
            .Items.Add("November")
            .Items.Add("Desember")
        End With
    End Sub

    Private Sub tb_namaIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_namaIn.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_tlpnIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_tlpIn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_thnMulai_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_thnMulai.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_thnTK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_thnTK.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_thnSD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_thnSD.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_thnSMP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_thnSMP.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_thnSMA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_thnSMA.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_jur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_jur.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_thnPeny_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_thnPeny.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_namaOr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_namaOr.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_thnOr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_thnOr.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_thnPres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_thnPres.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class
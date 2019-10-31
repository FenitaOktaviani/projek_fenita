Public Class DataOrtu
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        DataDiri.Show()
    End Sub

    Sub clear2()
        tb_namaA.Clear()
        tb_pekA.Clear()
        tb_nohpA.Clear()
        tb_almtA.Clear()

        tb_namaI.Clear()
        tb_pekI.Clear()
        tb_nohpI.Clear()
        tb_almtI.Clear()
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
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

        If (String.IsNullOrEmpty(tb_namaA.Text.Trim())) Then
            MsgBox("Masukan Nama Ayah ", MsgBoxStyle.Exclamation)
        ElseIf (String.IsNullOrEmpty(tb_namaI.Text.Trim())) Then
            MsgBox("Masukan Nama Ibu ", MsgBoxStyle.Exclamation)
        Else
            Me.Hide()
            nextpendaftaran.Show()
        End If
       
    End Sub

    Private Sub tb_namaA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_namaA.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_namaI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_namaI.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_pekA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_pekA.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_pekI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_pekI.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or e.KeyChar = " " Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_nohpA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_nohpA.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_nohpI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_nohpI.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class
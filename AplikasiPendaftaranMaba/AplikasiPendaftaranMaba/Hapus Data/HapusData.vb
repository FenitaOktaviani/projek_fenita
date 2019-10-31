Public Class HapusData

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MenuUtama.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "INFORMASI")
        Me.Hide()
        MenuUtama.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cari.TextChanged
        DataGridView1.DataSource = CariDataDiri(tb_cari.Text.Trim(), tb_cari.Text.Trim())
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As DialogResult = MsgBox("apakah yakin ingin menghapus data ini?", MsgBoxStyle.OkCancel)
        If (dr = DialogResult.OK) Then
            If (HapusDataDiri(tb_reg.Text) = True) Then
                HapusDataAyah(tb_reg.Text)
                HapusDataIbu(tb_reg.Text)
                HapusDataPek(tb_reg.Text)
                HapusDataPend(tb_reg.Text)
                HapusDataKes(tb_reg.Text)
                HapusDataOrg(tb_reg.Text)
                HapusDataPres(tb_reg.Text)
                MsgBox("Data Berhasil Dihapus")
                tb_cari.Clear()
                tb_reg.Clear()
                DataGridView1.DataSource = LihatDataDiri()
            End If
        Else
            MsgBox("Data Batal dihapus")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim tamp As DataGridViewRow = DataGridView1.CurrentRow
        tb_reg.Text = tamp.Cells(0).Value.ToString
    End Sub

    Private Sub HapusData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = LihatDataDiri()
    End Sub

End Class
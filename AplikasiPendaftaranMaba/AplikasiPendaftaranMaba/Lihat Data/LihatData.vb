Public Class LihatData
    Public lihat As String

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        MenuUtama.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lihat = "data diri"
        LihatDataDiri()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lihat = "data ayah"
        LihatDataAyah()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        lihat = "data ibu"
        LihatDataIbu()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lihat = "data pek"
        LihatDataPekerjaan()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lihat = "data pend"
        LihatDataPendidikan()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        lihat = "data kes"
        LihatDataKesehatan()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        lihat = "data pres"
        LihatDataPrestasi()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        lihat = "data org"
        LihatDataOrganisasi()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If lihat = "data diri" Then
            DataGridView1.DataSource = CariDataDiri(tb_cariData.Text.Trim(), tb_cariData.Text.Trim())
        ElseIf lihat = "data ayah" Then
            DataGridView1.DataSource = CariDataAyah(tb_cariData.Text.Trim())
        ElseIf lihat = "data ibu" Then
            DataGridView1.DataSource = CariDataIbu(tb_cariData.Text.Trim())
        ElseIf lihat = "data pek" Then
            DataGridView1.DataSource = CariDataPek(tb_cariData.Text.Trim())
        ElseIf lihat = "data pend" Then
            DataGridView1.DataSource = CariDataPend(tb_cariData.Text.Trim())
        ElseIf lihat = "data kes" Then
            DataGridView1.DataSource = CariDataKes(tb_cariData.Text.Trim())
        ElseIf lihat = "data org" Then
            DataGridView1.DataSource = CariDataOrg(tb_cariData.Text.Trim())
        ElseIf lihat = "data pres" Then
            DataGridView1.DataSource = CariDataPres(tb_cariData.Text.Trim())
        End If
        tb_cariData.Clear()
    End Sub
End Class
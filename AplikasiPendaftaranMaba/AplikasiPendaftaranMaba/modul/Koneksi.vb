Imports MySql.Data.MySqlClient
Module Koneksi
    Public connstr As String
    Public conn As MySqlConnection
    Public adp As MySqlDataAdapter
    Public cmd As MySqlCommand
    Public baca As MySqlDataReader

    'data diri
    Public reg As String
    Public kls As String
    Public prodi As String
    Public namadd As String
    Public tgl As Date
    Public jk As String
    Public ident As String
    Public noid As String
    Public wrgNegara As String
    Public agm As String
    Public ss As String
    Public almtdd As String

    'data ayah
    Public namaA As String
    Public tglA As Date
    Public pekA As String
    Public nohpA As String
    Public almtA As String

    'data ibu
    Public namaI As String
    Public tglI As Date
    Public pekI As String
    Public nohpI As String
    Public almtI As String

    'data pekerjaan
    Public namaIn As String
    Public almtIn As String
    Public telpIn As String
    Public blnmulai As String
    Public thnmulai As String
    Public jabatan As String

    'data pendidikan
    Public tk As String
    Public thTK As String
    Public sd As String
    Public thSD As String
    Public smp As String
    Public thSMP As String
    Public sma As String
    Public thSMA As String
    Public jur As String

    'data kesehatan
    Public namaPen As String
    Public thnPen As String

    'data organisasi
    Public namaOr As String
    Public sbg As String
    Public thnOr As String

    'data prestasi
    Public namaPres As String
    Public thnPres As String

    
    Sub connect()
        Try
            connstr = "server=localhost;user id=root;database=db_pasim"
            conn = New MySqlConnection(connstr)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            Else
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Error Connection in: " + ex.Message)
        End Try

    End Sub

    Sub insertDataDiri()
        Try
            Dim str As String

            str = "insert into tb_datadiri values ('" & reg & "','" & kls & "','" & prodi & "','" & namadd & "','" & tgl & "','" & jk & "','" & ident & "','" & noid & "','" & wrgNegara & "','" & agm & "','" & ss & "','" & almtdd & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in: " + ex.ToString)
        End Try
    End Sub

    Sub insertDataAyah()
        Try
            Dim str As String

            str = "insert into tb_ayah values('" & namaA & "','" & tglA & "','" & pekA & "','" & nohpA & "','" & almtA & "','" & reg & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in: " + ex.ToString)
        End Try
    End Sub

    Sub insertDataIbu()
        Try
            Dim str As String

            str = "insert into tb_ibu values('" & namaI & "','" & tglI & "','" & pekI & "','" & nohpI & "','" & almtI & "','" & reg & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in: " + ex.ToString)
        End Try
    End Sub

    Sub insertDataPekerjaan()
        Try
            Dim str As String

            str = "insert into tb_pekerjaan values('" & namaIn & "','" & almtIn & "','" & telpIn & "','" & blnmulai & "','" & thnmulai & "','" & jabatan & "','" & reg & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in: " + ex.ToString)
        End Try
    End Sub

    Sub insertDataPendidikan()
        Try
            Dim str As String

            str = "insert into tb_pendidikan values('" & tk & "','" & thTK & "','" & sd & "','" & thSD & "','" & smp & "','" & thSMP & "','" & sma & "','" & thSMA & "','" & jur & "','" & reg & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in: " + ex.ToString)
        End Try
    End Sub

    Sub insertDataKesehatan()
        Try
            Dim str As String

            str = "insert into tb_kesehatan values('" & namaPen & "','" & thnPen & "','" & reg & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in: " + ex.ToString)
        End Try
    End Sub

    Sub insertDataOrganisasi()
        Try
            Dim str As String

            str = "insert into tb_organisasi values('" & namaOr & "','" & sbg & "','" & thnOr & "','" & reg & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in: " + ex.ToString)
        End Try
    End Sub

    Sub insertDataPrestasi()
        Try
            Dim str As String

            str = "insert into tb_prestasi values('" & namaPres & "','" & thnPres & "','" & reg & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in: " + ex.ToString)
        End Try
    End Sub

    Public Function LihatDataDiri() As DataTable
        Dim hasil As New DataTable
        Dim _query As String = "SELECT*FROM tb_datadiri"
        Try
            adp = New MySqlDataAdapter(_query, conn)
            adp.Fill(hasil)
            LihatData.DataGridView1.DataSource = hasil
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Return hasil
    End Function

    Public Function LihatDataAyah() As DataTable
        Dim hasil As New DataTable
        Dim _query As String = "SELECT*FROM tb_ayah"
        Try
            adp = New MySqlDataAdapter(_query, conn)
            adp.Fill(hasil)
            LihatData.DataGridView1.DataSource = hasil
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
    End Function

    Public Function LihatDataIbu() As DataTable
        Dim hasil As New DataTable
        Dim _query As String = "SELECT*FROM tb_ibu"
        Try
            adp = New MySqlDataAdapter(_query, conn)
            adp.Fill(hasil)
            LihatData.DataGridView1.DataSource = hasil
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
    End Function

    Public Function LihatDataPekerjaan() As DataTable
        Dim hasil As New DataTable
        Dim _query As String = "SELECT*FROM tb_pekerjaan"
        Try
            adp = New MySqlDataAdapter(_query, conn)
            adp.Fill(hasil)
            LihatData.DataGridView1.DataSource = hasil
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
    End Function

    Public Function LihatDataPendidikan() As DataTable
        Dim hasil As New DataTable
        Dim _query As String = "SELECT*FROM tb_pendidikan"
        Try
            adp = New MySqlDataAdapter(_query, conn)
            adp.Fill(hasil)
            LihatData.DataGridView1.DataSource = hasil
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
    End Function

    Public Function LihatDataKesehatan() As DataTable
        Dim hasil As New DataTable
        Dim _query As String = "SELECT*FROM tb_kesehatan"
        Try
            adp = New MySqlDataAdapter(_query, conn)
            adp.Fill(hasil)
            LihatData.DataGridView1.DataSource = hasil
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
    End Function

    Public Function LihatDataOrganisasi() As DataTable
        Dim hasil As New DataTable
        Dim _query As String = "SELECT*FROM tb_organisasi"
        Try
            adp = New MySqlDataAdapter(_query, conn)
            adp.Fill(hasil)
            LihatData.DataGridView1.DataSource = hasil
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
    End Function

    Public Function LihatDataPrestasi() As DataTable
        Dim hasil As New DataTable
        Dim _query As String = "SELECT*FROM tb_prestasi"
        Try
            adp = New MySqlDataAdapter(_query, conn)
            adp.Fill(hasil)
            LihatData.DataGridView1.DataSource = hasil
        Catch ex As Exception
            MsgBox("Error:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
    End Function

    Public Function CariDataDiri(ByVal cari As String, ByVal nama As String) As DataTable
        Dim data = New DataTable()
        Dim query As String = "select*from tb_datadiri where No_Regristrasi like '%" + cari + "%' or Nama_Lengkap like '%" + nama + "%'"
        Try
            adp = New MySqlDataAdapter(query, conn)
            adp.Fill(data)
        Catch ex As Exception
            MsgBox("Error in: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return data
    End Function

    Public Function CariDataAyah(ByVal cari As String) As DataTable
        Dim data = New DataTable()
        Dim query As String = "select*from tb_ayah where No_Regristrasi like '%" + cari + "%'"
        Try
            adp = New MySqlDataAdapter(query, conn)
            adp.Fill(data)
        Catch ex As Exception
            MsgBox("Error in: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return data
    End Function

    Public Function CariDataIbu(ByVal cari As String) As DataTable
        Dim data = New DataTable()
        Dim query As String = "select*from tb_Ibu where No_Regristrasi like '%" + cari + "%'"
        Try
            adp = New MySqlDataAdapter(query, conn)
            adp.Fill(data)
        Catch ex As Exception
            MsgBox("Error in: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return data
    End Function

    Public Function CariDataPek(ByVal cari As String) As DataTable
        Dim data = New DataTable()
        Dim query As String = "select*from tb_pekerjaan where No_Regristrasi like '%" + cari + "%'"
        Try
            adp = New MySqlDataAdapter(query, conn)
            adp.Fill(data)
        Catch ex As Exception
            MsgBox("Error in: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return data
    End Function

    Public Function CariDataPend(ByVal cari As String) As DataTable
        Dim data = New DataTable()
        Dim query As String = "select*from tb_pendidikan where No_Regristrasi like '%" + cari + "%'"
        Try
            adp = New MySqlDataAdapter(query, conn)
            adp.Fill(data)
        Catch ex As Exception
            MsgBox("Error in: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return data
    End Function

    Public Function CariDataKes(ByVal cari As String) As DataTable
        Dim data = New DataTable()
        Dim query As String = "select*from tb_kesehatan where No_Regristrasi like '%" + cari + "%'"
        Try
            adp = New MySqlDataAdapter(query, conn)
            adp.Fill(data)
        Catch ex As Exception
            MsgBox("Error in: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return data
    End Function

    Public Function CariDataOrg(ByVal cari As String) As DataTable
        Dim data = New DataTable()
        Dim query As String = "select*from tb_organisasi where No_Regristrasi like '%" + cari + "%'"
        Try
            adp = New MySqlDataAdapter(query, conn)
            adp.Fill(data)
        Catch ex As Exception
            MsgBox("Error in: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return data
    End Function

    Public Function CariDataPres(ByVal cari As String) As DataTable
        Dim data = New DataTable()
        Dim query As String = "select*from tb_prestasi where No_Regristrasi like '%" + cari + "%'"
        Try
            adp = New MySqlDataAdapter(query, conn)
            adp.Fill(data)
        Catch ex As Exception
            MsgBox("Error in: " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return data
    End Function

    Public Function HapusDataDiri(ByVal noreg As String) As Integer
        Dim hapus = False
        Dim query As String = "delete from tb_datadiri where No_Regristrasi ='" & noreg & "'"
        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@No_Regristrasi", MySqlDbType.VarChar).Value = noreg
            cmd.ExecuteNonQuery()
            hapus = True
        Catch ex As Exception
            MsgBox("Error in : " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hapus
    End Function

    Public Function HapusDataAyah(ByVal noreg As String) As Integer
        Dim hapus = False
        Dim query As String = "delete from tb_ayah where No_Regristrasi ='" & noreg & "'"
        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@No_Regristrasi", MySqlDbType.VarChar).Value = noreg
            cmd.ExecuteNonQuery()
            hapus = True
        Catch ex As Exception
            MsgBox("Error in : " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hapus
    End Function

    Public Function HapusDataIbu(ByVal noreg As String) As Integer
        Dim hapus = False
        Dim query As String = "delete from tb_ibu where No_Regristrasi ='" & noreg & "'"
        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@No_Regristrasi", MySqlDbType.VarChar).Value = noreg
            cmd.ExecuteNonQuery()
            hapus = True
        Catch ex As Exception
            MsgBox("Error in : " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hapus
    End Function

    Public Function HapusDataPek(ByVal noreg As String) As Integer
        Dim hapus = False
        Dim query As String = "delete from tb_pekerjaan where No_Regristrasi ='" & noreg & "'"
        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@No_Regristrasi", MySqlDbType.VarChar).Value = noreg
            cmd.ExecuteNonQuery()
            hapus = True
        Catch ex As Exception
            MsgBox("Error in : " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hapus
    End Function

    Public Function HapusDataPend(ByVal noreg As String) As Integer
        Dim hapus = False
        Dim query As String = "delete from tb_pendidikan where No_Regristrasi ='" & noreg & "'"
        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@No_Regristrasi", MySqlDbType.VarChar).Value = noreg
            cmd.ExecuteNonQuery()
            hapus = True
        Catch ex As Exception
            MsgBox("Error in : " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hapus
    End Function

    Public Function HapusDataKes(ByVal noreg As String) As Integer
        Dim hapus = False
        Dim query As String = "delete from tb_kesehatan where No_Regristrasi ='" & noreg & "'"
        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@No_Regristrasi", MySqlDbType.VarChar).Value = noreg
            cmd.ExecuteNonQuery()
            hapus = True
        Catch ex As Exception
            MsgBox("Error in : " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hapus
    End Function

    Public Function HapusDataOrg(ByVal noreg As String) As Integer
        Dim hapus = False
        Dim query As String = "delete from tb_organisasi where No_Regristrasi ='" & noreg & "'"
        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@No_Regristrasi", MySqlDbType.VarChar).Value = noreg
            cmd.ExecuteNonQuery()
            hapus = True
        Catch ex As Exception
            MsgBox("Error in : " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hapus
    End Function

    Public Function HapusDataPres(ByVal noreg As String) As Integer
        Dim hapus = False
        Dim query As String = "delete from tb_prestasi where No_Regristrasi ='" & noreg & "'"
        Try
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add("@No_Regristrasi", MySqlDbType.VarChar).Value = noreg
            cmd.ExecuteNonQuery()
            hapus = True
        Catch ex As Exception
            MsgBox("Error in : " + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hapus
    End Function

    Sub UpdateDataDiri()
        Try
            Dim str As String

            str = "update tb_datadiri set Kelas='" & kls & "',Prodi='" & prodi & "',Nama_Lengkap='" & namadd & "',Tanggal_Lahir='" & tgl & "',Jenis_Kelamin='" & jk & "',Jenis_Identitas='" & ident & "',No_Identitas='" & noid & "',Kewarganegaraan='" & wrgNegara & "',Agama='" & agm & "',Status_Sipil='" & ss & "',Alamat='" & almtdd & "' where No_Regristrasi='" & reg & "'"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Ubah Data Diri Berhasil")
        Catch ex As Exception
            MessageBox.Show("Ubah Data Diri Gagal")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateDataAyah()
        Try
            Dim str As String

            str = "update tb_ayah set Nama_Ayah='" & namaA & "',Tanggal_Lahir='" & tglA & "',Pekerjaan='" & pekA & "',Nomer_Hp='" & nohpA & "',Alamat='" & almtA & "' where No_Regristrasi='" & reg & "'"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateDataIbu()
        Try
            Dim str As String

            str = "update tb_ibu set Nama_Ibu='" & namaI & "',Tanggal_Lahir='" & tglI & "',Pekerjaan='" & pekI & "',No_Hp='" & nohpI & "',Alamat='" & almtI & "' where No_Regristrasi='" & reg & "'"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateDataPekerjaan()
        Try
            Dim str As String

            str = "update tb_pekerjaan set Nama_Instansi='" & namaIn & "',Alamat_Instansi='" & almtIn & "',Telepon='" & telpIn & "',Mulai_Bekerja='" & blnmulai & "',Tahun='" & thnmulai & "',Jabatan='" & jabatan & "' where No_Regristrasi='" & reg & "'"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Ubah Data Pekerjaan Berhasil")
        Catch ex As Exception
            MessageBox.Show("Ubah Data Pekerjaan Gagal")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateDataPendidikan()
        Try
            Dim str As String

            str = "update tb_pendidikan set TK='" & tk & "',Tahun_Masuk_TK='" & thTK & "',SD='" & sd & "',Tahun_Masuk_SD='" & thSD & "',SMP='" & smp & "',Tahun_Masuk_SMP='" & thSMP & "',SMA='" & sma & "',Tahun_Masuk_SMA='" & thSMA & "',Jurusan='" & jur & "' where No_Regristrasi='" & reg & "'"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Ubah Data Pendidikan Berhasil")
        Catch ex As Exception
            MessageBox.Show("Ubah Data Pendidikan Gagal")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateDataKes()
        Try
            Dim str As String

            str = "update tb_kesehatan set Nama_Penyakit='" & namaPen & "',Tahun='" & thnPen & "' where No_Regristrasi='" & reg & "'"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Ubah Data Kesehatan Berhasil")
        Catch ex As Exception
            MessageBox.Show("Ubah Data Kesehatan Gagal")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateDataOrg()
        Try
            Dim str As String

            str = "update tb_organisasi set Nama_Organisasi='" & namaOr & "', Sebagai='" & sbg & "', Tahun='" & thnOr & "' where No_Regristrasi='" & reg & "'"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Ubah Data Organisasi Berhasil")
        Catch ex As Exception
            MessageBox.Show("Ubah Data Organisasi Gagal")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateDataPres()
        Try
            Dim str As String

            str = "update tb_prestasi set Prestasi='" & namaPres & "', Tahun='" & thnPres & "' where No_Regristrasi='" & reg & "'"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Ubah Data Prestasi Berhasil")
        Catch ex As Exception
            MessageBox.Show("Ubah Data Prestasi Gagal")
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module

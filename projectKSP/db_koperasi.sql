-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 31, 2018 at 12:54 PM
-- Server version: 10.1.10-MariaDB
-- PHP Version: 7.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_koperasi`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_anggota`
--

CREATE TABLE `tb_anggota` (
  `Id_anggota` char(4) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(100) NOT NULL,
  `No_telepon` char(12) NOT NULL,
  `Tanggal_lahir` date NOT NULL,
  `Tempat_lahir` varchar(100) NOT NULL,
  `Jenis_kelamin` varchar(50) NOT NULL,
  `Status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_anggota`
--

INSERT INTO `tb_anggota` (`Id_anggota`, `Nama`, `Alamat`, `No_telepon`, `Tanggal_lahir`, `Tempat_lahir`, `Jenis_kelamin`, `Status`) VALUES
('a001', 'fenita oktaviani', 'banyumas', '085727304879', '1999-10-05', 'banyumas', 'Perempuan', 'Belum Menikah');

-- --------------------------------------------------------

--
-- Table structure for table `tb_angsuran`
--

CREATE TABLE `tb_angsuran` (
  `No_angsuran` int(11) NOT NULL,
  `Id_anggota` char(4) NOT NULL,
  `Lama_pinjaman` int(11) NOT NULL,
  `Tanggal_jatuh_tempo` date NOT NULL,
  `Besar_angsuran` int(11) NOT NULL,
  `Sisa_angsuran` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_angsuran2`
--

CREATE TABLE `tb_angsuran2` (
  `No_angsuran` int(11) NOT NULL,
  `Id_anggota` char(4) NOT NULL,
  `Tanggal_pinjam` date NOT NULL,
  `Jumlah_pinjaman` int(11) NOT NULL,
  `Angsuran_ke` char(2) NOT NULL,
  `Tanggal_jatuh_tempo_perbulan` varchar(100) NOT NULL,
  `Denda` int(11) NOT NULL,
  `Jumlah_bayar` int(11) NOT NULL,
  `Keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Triggers `tb_angsuran2`
--
DELIMITER $$
CREATE TRIGGER `sisaPinjaman` AFTER INSERT ON `tb_angsuran2` FOR EACH ROW UPDATE tb_pinjaman set Total_pinjaman =Total_pinjaman-new.Jumlah_bayar where Id_anggota=new.Id_anggota
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tb_login`
--

CREATE TABLE `tb_login` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_login`
--

INSERT INTO `tb_login` (`username`, `password`) VALUES
('oktav', '999');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pinjaman`
--

CREATE TABLE `tb_pinjaman` (
  `Id_anggota` char(4) NOT NULL,
  `Tanggal_pinjam` date NOT NULL,
  `Jumlah_pinjaman` int(11) NOT NULL,
  `Lama_pinjaman` int(11) NOT NULL,
  `Tanggal_jatuh_tempo` varchar(100) NOT NULL,
  `Bunga` int(11) NOT NULL,
  `Besar_angsuran` int(11) NOT NULL,
  `Total_pinjaman` int(11) NOT NULL,
  `Total_bunga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_simpanan1`
--

CREATE TABLE `tb_simpanan1` (
  `No_simpanan` char(4) NOT NULL,
  `Id_anggota` char(4) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Total_simpanan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tb_simpanan2`
--

CREATE TABLE `tb_simpanan2` (
  `No_simpanan` char(4) NOT NULL,
  `Id_anggota` char(4) NOT NULL,
  `Tanggal_simpan` date NOT NULL,
  `Simpanan_pokok` int(11) NOT NULL,
  `Simpanan_wajib` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Triggers `tb_simpanan2`
--
DELIMITER $$
CREATE TRIGGER `total_simpanan` AFTER INSERT ON `tb_simpanan2` FOR EACH ROW UPDATE tb_simpanan1 set Total_simpanan = Total_simpanan + new.Simpanan_pokok + new.Simpanan_wajib WHERE Id_anggota = new.Id_anggota
$$
DELIMITER ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_anggota`
--
ALTER TABLE `tb_anggota`
  ADD PRIMARY KEY (`Id_anggota`);

--
-- Indexes for table `tb_angsuran`
--
ALTER TABLE `tb_angsuran`
  ADD PRIMARY KEY (`No_angsuran`),
  ADD KEY `fk_ang` (`Id_anggota`);

--
-- Indexes for table `tb_angsuran2`
--
ALTER TABLE `tb_angsuran2`
  ADD PRIMARY KEY (`No_angsuran`),
  ADD KEY `fk_no` (`Id_anggota`);

--
-- Indexes for table `tb_login`
--
ALTER TABLE `tb_login`
  ADD PRIMARY KEY (`password`);

--
-- Indexes for table `tb_pinjaman`
--
ALTER TABLE `tb_pinjaman`
  ADD PRIMARY KEY (`Id_anggota`);

--
-- Indexes for table `tb_simpanan1`
--
ALTER TABLE `tb_simpanan1`
  ADD PRIMARY KEY (`No_simpanan`);

--
-- Indexes for table `tb_simpanan2`
--
ALTER TABLE `tb_simpanan2`
  ADD KEY `fk_nosim` (`No_simpanan`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_angsuran`
--
ALTER TABLE `tb_angsuran`
  MODIFY `No_angsuran` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `tb_angsuran2`
--
ALTER TABLE `tb_angsuran2`
  MODIFY `No_angsuran` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_angsuran`
--
ALTER TABLE `tb_angsuran`
  ADD CONSTRAINT `fk_ang` FOREIGN KEY (`Id_anggota`) REFERENCES `tb_anggota` (`Id_anggota`);

--
-- Constraints for table `tb_angsuran2`
--
ALTER TABLE `tb_angsuran2`
  ADD CONSTRAINT `fk_no` FOREIGN KEY (`Id_anggota`) REFERENCES `tb_anggota` (`Id_anggota`);

--
-- Constraints for table `tb_simpanan2`
--
ALTER TABLE `tb_simpanan2`
  ADD CONSTRAINT `fk_nosim` FOREIGN KEY (`No_simpanan`) REFERENCES `tb_simpanan1` (`No_simpanan`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 28 Bulan Mei 2022 pada 10.58
-- Versi server: 10.4.22-MariaDB
-- Versi PHP: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_puskesmas`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `Id_admin` int(11) NOT NULL,
  `Nama_admin` varchar(20) NOT NULL,
  `Alamat_admin` varchar(100) NOT NULL,
  `Hp_admin` varchar(12) NOT NULL,
  `Email_admin` varchar(30) NOT NULL,
  `Tgl_lahir_admin` date NOT NULL,
  `Username` varchar(30) NOT NULL,
  `Password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`Id_admin`, `Nama_admin`, `Alamat_admin`, `Hp_admin`, `Email_admin`, `Tgl_lahir_admin`, `Username`, `Password`) VALUES
(1, 'Zikri Hanafi', 'Villa Kenali Permai Blok i 4 Nomor 1', '089652049412', 'fabbmad@gmail.com', '2002-09-21', 'Zikri', '7b27c97957de29e8943eb64cbac4f1a1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `dokter`
--

CREATE TABLE `dokter` (
  `Id_dokter` int(11) NOT NULL,
  `Nama_dokter` varchar(20) NOT NULL,
  `Alamat_dokter` varchar(100) NOT NULL,
  `Hp_dokter` varchar(12) NOT NULL,
  `Email_dokter` varchar(30) NOT NULL,
  `Tgl_lahir_dokter` date NOT NULL,
  `Jenis_kelamin_dokter` enum('Laki-laki','Perempuan','','') NOT NULL,
  `Spesialis` varchar(20) NOT NULL,
  `Jam_kerja` enum('08:00 - 16:00','16:00 - 23:00','Belum Pasti') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `dokter`
--

INSERT INTO `dokter` (`Id_dokter`, `Nama_dokter`, `Alamat_dokter`, `Hp_dokter`, `Email_dokter`, `Tgl_lahir_dokter`, `Jenis_kelamin_dokter`, `Spesialis`, `Jam_kerja`) VALUES
(10, 'Zikri Hanafi', 'Villa Kenali Permai Blok I4', '0896', 'fabbmad@gmail.com', '2002-09-21', 'Laki-laki', 'Jantung', '16:00 - 23:00'),
(12, 'Hurum Maqshura', 'Mayang Mangurai', '08965', 'maqshura@gmail.com', '2002-11-15', 'Perempuan', 'Jantung', '08:00 - 16:00');

-- --------------------------------------------------------

--
-- Struktur dari tabel `obat`
--

CREATE TABLE `obat` (
  `Id_obat` int(11) NOT NULL,
  `Nama_obat` varchar(20) NOT NULL,
  `Jenis_obat` varchar(30) NOT NULL,
  `Kandungan` varchar(200) NOT NULL,
  `Kuantitas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `obat`
--

INSERT INTO `obat` (`Id_obat`, `Nama_obat`, `Jenis_obat`, `Kandungan`, `Kuantitas`) VALUES
(2, 'Trimate-E Supplemen', 'Suplemen Neurotropik', 'Benfotiamine 25 mg, pyridoxine HCl 25 mg, hydroxocobalamin 50 mg, dl-α tocopheryl acetate 50 mg', 19),
(4, 'Trimate-C Supplemen', 'Suplemen Neurotropik', 'Benfotiamine 25 mg, pyridoxine HCl 25 mg, hydroxocobalamin 50 mg, dl-α tocopheryl acetate 50 mg', 10),
(5, 'Trimate-D Supplemen', 'Suplemen Neurotropik', 'Benfotiamine 25 mg, pyridoxine HCl 25 mg, hydroxocobalamin 50 mg, dl-α tocopheryl acetate 50 mg', 15);

-- --------------------------------------------------------

--
-- Struktur dari tabel `pasien`
--

CREATE TABLE `pasien` (
  `Id_pasien` int(11) NOT NULL,
  `Nama_pasien` varchar(20) NOT NULL,
  `Alamat_pasien` varchar(100) NOT NULL,
  `Hp_pasien` varchar(12) NOT NULL,
  `Tgl_lahir_pasien` date NOT NULL,
  `Jenis_kelamin_pasien` enum('Laki-laki','Perempuan','','') NOT NULL,
  `R_penyakit_sebelumnya` varchar(50) NOT NULL,
  `Dr_perawat` int(11) NOT NULL,
  `Obat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `pasien`
--

INSERT INTO `pasien` (`Id_pasien`, `Nama_pasien`, `Alamat_pasien`, `Hp_pasien`, `Tgl_lahir_pasien`, `Jenis_kelamin_pasien`, `R_penyakit_sebelumnya`, `Dr_perawat`, `Obat`) VALUES
(20, 'Rafli Ramadhan', 'Depan Toko Bangunan masuk Gang', '0895', '2002-03-19', 'Laki-laki', 'Batuk2', 12, 2),
(21, 'Indah Purnamasari', 'Di Kosan dekat Unja masuk gang depan dikit', '0892', '2000-04-12', 'Perempuan', 'Batuk2, Dak tau lagi habis tu', 10, 4);

-- --------------------------------------------------------

--
-- Struktur dari tabel `ruang`
--

CREATE TABLE `ruang` (
  `Id_ruang` int(11) NOT NULL,
  `No_ruangan` varchar(12) NOT NULL,
  `Pasien` int(11) NOT NULL,
  `Dokter` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `ruang`
--

INSERT INTO `ruang` (`Id_ruang`, `No_ruangan`, `Pasien`, `Dokter`) VALUES
(1, '105', 21, 10),
(2, '106', 20, 12);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`Id_admin`);

--
-- Indeks untuk tabel `dokter`
--
ALTER TABLE `dokter`
  ADD PRIMARY KEY (`Id_dokter`);

--
-- Indeks untuk tabel `obat`
--
ALTER TABLE `obat`
  ADD PRIMARY KEY (`Id_obat`);

--
-- Indeks untuk tabel `pasien`
--
ALTER TABLE `pasien`
  ADD PRIMARY KEY (`Id_pasien`),
  ADD KEY `DOKTER` (`Dr_perawat`),
  ADD KEY `OBAT` (`Obat`);

--
-- Indeks untuk tabel `ruang`
--
ALTER TABLE `ruang`
  ADD PRIMARY KEY (`Id_ruang`),
  ADD KEY `PASIEN` (`Pasien`),
  ADD KEY `DOKTER_R` (`Dokter`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `admin`
--
ALTER TABLE `admin`
  MODIFY `Id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT untuk tabel `dokter`
--
ALTER TABLE `dokter`
  MODIFY `Id_dokter` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT untuk tabel `obat`
--
ALTER TABLE `obat`
  MODIFY `Id_obat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT untuk tabel `pasien`
--
ALTER TABLE `pasien`
  MODIFY `Id_pasien` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT untuk tabel `ruang`
--
ALTER TABLE `ruang`
  MODIFY `Id_ruang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `pasien`
--
ALTER TABLE `pasien`
  ADD CONSTRAINT `DOKTER` FOREIGN KEY (`Dr_perawat`) REFERENCES `dokter` (`Id_dokter`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `OBAT` FOREIGN KEY (`Obat`) REFERENCES `obat` (`Id_obat`);

--
-- Ketidakleluasaan untuk tabel `ruang`
--
ALTER TABLE `ruang`
  ADD CONSTRAINT `DOKTER_R` FOREIGN KEY (`Dokter`) REFERENCES `dokter` (`Id_dokter`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `PASIEN` FOREIGN KEY (`Pasien`) REFERENCES `pasien` (`id_pasien`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

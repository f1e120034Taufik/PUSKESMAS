-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 13 Bulan Mei 2022 pada 06.08
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
  `Hp_dokter` int(11) NOT NULL,
  `Email_dokter` varchar(30) NOT NULL,
  `Tgl_lahir_dokter` date NOT NULL,
  `Jenis_kelamin_dokter` enum('L','P','','') NOT NULL,
  `Spesialis` varchar(20) NOT NULL,
  `Jam_kerja` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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

-- --------------------------------------------------------

--
-- Struktur dari tabel `pasien`
--

CREATE TABLE `pasien` (
  `id_pasien` int(11) NOT NULL,
  `Nama_pasien` varchar(20) NOT NULL,
  `Alamat_pasien` varchar(100) NOT NULL,
  `Hp_pasien` int(11) NOT NULL,
  `Tgl_lahir_pasien` date NOT NULL,
  `Jenis_kelamin_pasien` enum('L','P','','') NOT NULL,
  `R_penyakit_sebelumnya` varchar(50) NOT NULL,
  `Dr_perawat` int(11) NOT NULL,
  `Obat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `ruang`
--

CREATE TABLE `ruang` (
  `Id_ruang` int(11) NOT NULL,
  `Pasien` int(11) NOT NULL,
  `Dokter` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
  ADD PRIMARY KEY (`id_pasien`),
  ADD KEY `DOKTER` (`Dr_perawat`),
  ADD KEY `OBAT` (`Obat`);

--
-- Indeks untuk tabel `ruang`
--
ALTER TABLE `ruang`
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
  MODIFY `Id_dokter` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `obat`
--
ALTER TABLE `obat`
  MODIFY `Id_obat` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `pasien`
--
ALTER TABLE `pasien`
  MODIFY `id_pasien` int(11) NOT NULL AUTO_INCREMENT;

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

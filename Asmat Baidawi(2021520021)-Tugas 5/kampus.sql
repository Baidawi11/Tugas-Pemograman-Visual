-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 19 Okt 2023 pada 14.03
-- Versi server: 10.4.21-MariaDB
-- Versi PHP: 7.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kampus`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `Nama` varchar(40) NOT NULL,
  `NIM` varchar(20) NOT NULL,
  `Alamat` varchar(30) NOT NULL,
  `Jenis Kelamin` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `mahasiswa`
--

INSERT INTO `mahasiswa` (`Nama`, `NIM`, `Alamat`, `Jenis Kelamin`) VALUES
('Asmat Baidawi', '2021520021', 'Desa Mangar', 'Laki-laki'),
('Moh Riski', '2021520020', 'Desa Terrak', 'Laki-laki'),
('Syarif Hidayatullah', '2021520024', 'Desa Tlanakan', 'Laki-laki'),
('Abdul Adim Mubarok', '2021520032', 'Desa Sampang', 'Laki-laki'),
('Dawi', '2021520022', 'Desa Mangar', 'Laki-laki'),
('Agus', '2021520025', 'Desa Panglegur', 'Laki-laki'),
('Gunawan', '2021520027', 'Desa Branta', 'Laki-laki'),
('Ulfatul hasanah', '2021520028', 'Desa Lokgulok', 'Perempuan'),
('Selly', '2021520032', 'Desa Pamekasan', 'Perempuan'),
('Diah', '2021520011', 'Desa Mangar', 'Perempuan');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

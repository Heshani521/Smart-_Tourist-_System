-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 02, 2026 at 08:36 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `galle_tourism`
--

-- --------------------------------------------------------

--
-- Table structure for table `attractions`
--

CREATE TABLE `attractions` (
  `id` int(11) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `location` varchar(100) DEFAULT NULL,
  `fee` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attractions`
--

INSERT INTO `attractions` (`id`, `name`, `location`, `fee`) VALUES
(1, 'Galle Dutch Fort', 'Heritage / Historical', 'Free'),
(2, 'Jungle Beach', 'Beach / Nature', 'Free'),
(3, 'Rumassala Hill', 'Nature / Hiking', 'Free'),
(4, 'Galle National Museum', 'Museum / Historical', '500.00'),
(5, 'Unawatuna Beach', 'Beach', 'Free'),
(6, 'Japanese Peace Pagoda', 'Religious / Scenic', 'Free'),
(7, 'Yatagala Raja Maha Viharaya', 'Religious / Historical', 'Free'),
(8, 'Galle Lighthouse', 'Landmark / Historical', 'Free'),
(9, 'Kottawa Rain Forest', 'Nature / Eco-tourism', '300.00'),
(10, 'Maritime Archeology Museum', 'Museum', '600.00'),
(11, 'beach park', 'koggala', 'fee'),
(12, 'mobile phone shop', 'ahangama', '200');

-- --------------------------------------------------------

--
-- Table structure for table `service_providers`
--

CREATE TABLE `service_providers` (
  `id` int(11) NOT NULL,
  `type` varchar(50) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `contact` varchar(50) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `service_providers`
--

INSERT INTO `service_providers` (`id`, `type`, `name`, `contact`, `description`) VALUES
(1, 'Hotel', 'Amanwella Resort', '0912234567', 'Luxury beachfront hotel in Galle.'),
(2, 'Hotel', 'Jetwing Lighthouse', '0912224000', 'Elegant colonial-style hotel with ocean views.'),
(3, 'Hotel', 'The Fortress Resort', '0912284100', 'Premium stay with world-class spa facilities.'),
(4, 'Hotel', 'Amari Galle', '0912270000', 'Modern hotel near the beach with great pools.'),
(5, 'Accommodation', 'Galle Fort Guest House', '0771234567', 'Affordable and cozy stay inside the historic fort.'),
(6, 'Transport', 'Galle Cab Service', '0714445555', '24/7 taxi and airport drop service.'),
(7, 'Transport', 'Southern Rent a Car', '0779998888', 'Self-drive or with driver luxury vehicle rentals.'),
(8, 'Transport', 'Unawatuna Tuk Tuk Tours', '0751112222', 'Local city tours and beach drops.'),
(9, 'Vehicle', 'Galle Motorbike Rental', '0723334444', 'Scooters and motorbikes for daily rental.'),
(10, 'Transport', 'Galle Luxury Coaches', '0915556666', 'Bus and van rentals for large tourist groups.');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attractions`
--
ALTER TABLE `attractions`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `service_providers`
--
ALTER TABLE `service_providers`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attractions`
--
ALTER TABLE `attractions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `service_providers`
--
ALTER TABLE `service_providers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

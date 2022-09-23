-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql8.freemysqlhosting.net
-- Generation Time: Sep 23, 2022 at 03:12 PM
-- Server version: 5.5.62-0ubuntu0.14.04.1
-- PHP Version: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sql8521009`
--

-- --------------------------------------------------------

--
-- Table structure for table `calculations`
--

CREATE TABLE `calculations` (
  `id` int(11) NOT NULL,
  `work_assign_id` int(11) NOT NULL,
  `work_done_amount` text NOT NULL,
  `payable_amount` text NOT NULL,
  `work_to_be_done` text NOT NULL,
  `paid_amount` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `calculations`
--

INSERT INTO `calculations` (`id`, `work_assign_id`, `work_done_amount`, `payable_amount`, `work_to_be_done`, `paid_amount`) VALUES
(8, 16, '899', '899', '7000', '0');

-- --------------------------------------------------------

--
-- Table structure for table `calculations_data`
--

CREATE TABLE `calculations_data` (
  `id` int(11) NOT NULL,
  `work_assign_id` text NOT NULL,
  `work_done` text NOT NULL,
  `payable_amount` text NOT NULL,
  `work_to_be_done` text NOT NULL,
  `paid_amount` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `calculations_data`
--

INSERT INTO `calculations_data` (`id`, `work_assign_id`, `work_done`, `payable_amount`, `work_to_be_done`, `paid_amount`) VALUES
(1, '16', '899', '899', '7000', '899');

-- --------------------------------------------------------

--
-- Table structure for table `contractors`
--

CREATE TABLE `contractors` (
  `id` int(11) NOT NULL,
  `full_name` text NOT NULL,
  `address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contractors`
--

INSERT INTO `contractors` (`id`, `full_name`, `address`) VALUES
(2, 'Abraham Kiprotich', '3717 Eldoret'),
(3, 'Benson Kimtai', '3717 Kitale'),
(4, 'Mercy Cherotich', '3717 Nakuru');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL,
  `email` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `email`) VALUES
(1, 'Benson', '12345', 'bnkimtai@gmail.com'),
(2, 'abraham', '12345', 'abu@gmail.com'),
(4, 'Mercy', '123', 'mercy@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `works`
--

CREATE TABLE `works` (
  `id` int(11) NOT NULL,
  `title` text,
  `location` text,
  `ts_number` text,
  `ts_amount` text,
  `work_assigned` text NOT NULL,
  `type_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `works`
--

INSERT INTO `works` (`id`, `title`, `location`, `ts_number`, `ts_amount`, `work_assigned`, `type_id`) VALUES
(1, 'Test Work', 'Nairobi', 'TS001', '18000', 'Yes', 1),
(2, 'Umoja One Cabro', 'Umoja', 'TS002', '1500', 'No', 1),
(3, 'Juja farm road', 'Juja', 'TS003', '4535', 'No', 1),
(9, 'Power Installation Umoja Church', 'Ruiru', 'TS004', '679876', 'No', 4),
(10, 'Plumbing works at GPO', 'Nairobi CBD', 'TS005', '34235', 'No', 5),
(11, 'Plumbing works at I&M Towers', 'Nairobi CBD', 'TS006', '76575', 'No', 5),
(12, 'Plumbing works at Lang\'ata town Hall', 'Lang\'ata', 'TS007', '53454', 'No', 5),
(13, 'Supply of Kitchenware', 'Kahawa Wendani', 'TS007', '65645', 'Yes', 3),
(14, 'Supply of building materials', 'Ole Kasasi primary', 'TS008', '5435646', 'No', 3),
(15, 'Supply of Power Generator to Juja primary', 'Juja', 'TS009', '543553', 'No', 3),
(16, 'Supply of Stationery at DPP\'s Office', 'Nairobi', 'TS010', '534540', 'No', 3),
(17, 'Supply of Roofing materials at MMU', 'Kajiado', 'TS011', '656456', 'No', 3);

-- --------------------------------------------------------

--
-- Table structure for table `work_assigned`
--

CREATE TABLE `work_assigned` (
  `id` int(11) NOT NULL,
  `work_id` int(11) NOT NULL,
  `contractor_id` int(11) NOT NULL,
  `ca_cost` varchar(50) NOT NULL,
  `assigned_date` text NOT NULL,
  `year` varchar(50) NOT NULL,
  `is_completed` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `work_assigned`
--

INSERT INTO `work_assigned` (`id`, `work_id`, `contractor_id`, `ca_cost`, `assigned_date`, `year`, `is_completed`) VALUES
(16, 1, 2, '7899', '9/21/2022', '2022-23', 'No'),
(17, 13, 2, '8000', '9/23/2022', '2022-23', 'No');

-- --------------------------------------------------------

--
-- Table structure for table `work_types`
--

CREATE TABLE `work_types` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `work_types`
--

INSERT INTO `work_types` (`id`, `name`) VALUES
(1, 'Construction'),
(3, 'Supply of Goods'),
(4, 'Electrical Services'),
(5, 'Plumbing Services');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `calculations`
--
ALTER TABLE `calculations`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `calculations_data`
--
ALTER TABLE `calculations_data`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `contractors`
--
ALTER TABLE `contractors`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `works`
--
ALTER TABLE `works`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `work_assigned`
--
ALTER TABLE `work_assigned`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `work_types`
--
ALTER TABLE `work_types`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `calculations`
--
ALTER TABLE `calculations`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `calculations_data`
--
ALTER TABLE `calculations_data`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `contractors`
--
ALTER TABLE `contractors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `works`
--
ALTER TABLE `works`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `work_assigned`
--
ALTER TABLE `work_assigned`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `work_types`
--
ALTER TABLE `work_types`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 25, 2020 at 01:18 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mblibdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `RegisterNumber` int(11) NOT NULL,
  `BookID` int(11) NOT NULL,
  `IssueDate` datetime NOT NULL,
  `ReturnDate` datetime NOT NULL,
  `BookName` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `try`
--

CREATE TABLE `try` (
  `firstname` text NOT NULL,
  `lastname` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `try`
--

INSERT INTO `try` (`firstname`, `lastname`) VALUES
('than', ''),
('than', 'golims');

-- --------------------------------------------------------

--
-- Table structure for table `useraccs`
--

CREATE TABLE `useraccs` (
  `firstname` text NOT NULL,
  `lastname` text NOT NULL,
  `gender` text NOT NULL,
  `dept` text NOT NULL,
  `email` text NOT NULL,
  `password` text NOT NULL,
  `number of books` int(11) NOT NULL,
  `idnumber` text NOT NULL,
  `username` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `useraccs`
--

INSERT INTO `useraccs` (`firstname`, `lastname`, `gender`, `dept`, `email`, `password`, `number of books`, `idnumber`, `username`) VALUES
('jonathan', 'jonathan', '', '', '', '', 0, '0', '0'),
('Jonathan', 'GOlimlim', '', '', '', '', 0, '0', '0'),
('Jonathan', 'GOlimlim', '', '', '', '', 0, '0', '0'),
('Jonathan', 'Golimlim', 'Male', '', 'tgolims2209', '', 0, '0', '0'),
('Jonathan', 'Golimlim', 'Male', '', 'tgolims2209', '2209', 0, '0', '0'),
('Jonathan', 'Golimlim', 'Male', '', 'tgolims2209', '2209', 0, '0', '0'),
('', '', '', '', '', '', 0, '0', '0'),
('', '', 'Male', '', '', '', 0, '0', '0'),
('Jonathan', 'Golimlim', 'Male', '', '', '', 0, '0', '0'),
('Jonathan', 'Golimlim', 'Male', 'CEN', 'tgolims2209', '2209', 0, '182 0111', '0'),
('Jayrald', 'Albis', 'Male', 'CEN', '', '2209', 0, '', '0'),
('Jonathan', 'Rodel', 'Male', 'CEN', '', '2209', 0, '', '0'),
('', '', '', '', '', '', 0, '', '0'),
('', '', '', '', '', '', 0, '', '0'),
('', '', '', '', '', '', 0, '', '0'),
('Jonathan', 'Golimlim', 'Male', 'CEN', 'tgolims2209@gmail.com', '2209', 0, '182 - 0111', '0'),
('Than', 'Than', 'Male', 'CEN', 'tgolims2209', '2209', 0, '182 - 0111', '0'),
('Jonathan', 'Golimlim', 'Male', 'CEN', 'tgolims2209', '2209', 0, '182 - 0111', '0'),
('Jonathan', 'Golimlim', 'Male', 'CEN', 'tgolims2209', '2209', 0, '182 - 0111', '0'),
('Jonathan', 'Golimlim', 'Male', 'CEN', 'tgolims2209', '2209', 0, '182 - 0111', 'than'),
('', '', '', '', '', '', 0, '', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

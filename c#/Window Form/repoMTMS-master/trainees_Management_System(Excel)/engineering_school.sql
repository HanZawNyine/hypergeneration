-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 10, 2018 at 09:35 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `engineering_school`
--

-- --------------------------------------------------------

--
-- Table structure for table `auth`
--

CREATE TABLE `auth` (
  `id` int(11) NOT NULL,
  `uname` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `pass` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `auth`
--

INSERT INTO `auth` (`id`, `uname`, `pass`) VALUES
(4, 'User', '1234'),
(5, 'amk', 'fs');

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `id` int(11) NOT NULL,
  `uname` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `status` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `dateTime` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `officer_name`
--

CREATE TABLE `officer_name` (
  `officer_id` int(11) NOT NULL,
  `bc_no` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `rank` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `battalion` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='Officer information';

--
-- Dumping data for table `officer_name`
--

INSERT INTO `officer_name` (`officer_id`, `bc_no`, `rank`, `name`, `battalion`) VALUES
(7, 'ကြည်း-၆၈၂၃၇', 'ဗိုလ်ကြီး', 'ခန့်ညားကျော်', 'bt(122)'),
(8, 'ကြည်း-၆၈၁၉၉', 'ဗိုလ်ကြီး', 'အောင်မင်းခန့်', 'bt(133)'),
(9, 'ကြည်း-၆၈၁၀၃', 'ဗိုလ်ကြီး', 'စိုးဆန်းသူ', 'bt(144)'),
(10, 'ကြည်း-၆၈၁၁၁', 'ဗိုလ်ကြီး', 'အောင်ကျော်မြင့်', 'bt(182)'),
(11, 'ကြည်း-၁၂၃၄၅', 'ဗိုလ်ကြီး', 'မောင်မောင်', 'bt(123)'),
(12, 'ကြည်း-၂၃၄၅၆', 'ဗိုလ်ကြီး', 'မောင်မောင်', 'စအရ(၉၀၁)'),
(13, 'ကြည်း-၂၃၄၅၇', 'ဗိုလ်ကြီး', 'အောင်အောင်', 'စအရ(၉၀၂)'),
(14, 'ကြည်း-၂၃၄၅၈', 'ဗိုလ်ကြီး', 'ညီညီ', 'စအရ(၉၀၃)'),
(15, 'ကြည်း-၂၃၄၅၉', 'ဗိုလ်ကြီး', 'ကိုကို', 'စအရ(၉၀၄)'),
(16, 'ကြည်း-၆၆၆၆၆', 'ဗိုလ်ကြီး', 'စောငမူး', 'စအရ(၉၀၁)'),
(17, 'ကြည်း-၆၆၆၆၈', 'ဗိုလ်ကြီး', 'ခွန်ငမူး', 'စအရ(၉၀၂)'),
(18, 'ကြည်း-၉၈၇၆၅', 'ဗိုလ်ကြီး', 'အာကာမြင့်မိုလ်တောက်ပကျော်ဇော်', 'စအရ(၁၂၃)'),
(20, 'ကြည်း-၉၈၇၆၆', 'ဗိုလ်', 'ဆန်းတင့်အောင်', 'စအရ(၁၁၇)'),
(21, 'ကြည်း-၉၈၇၆၇', 'ဗိုလ်', 'ဆန်းတင့်အောင်', 'စအရ(၁၁၇)'),
(22, 'ကြည်း-၆၅၆၅၆', 'ဗိုလ်ကြီး', 'အောင်ကျော်ဇော', 'စအရ(၉၀၉)'),
(23, 'ကြည်း-၃၄၂၈', 'ဗိုလ်မှူးကြီး', 'မြင့်အောင်', 'စအရ(၉၂၃)'),
(24, 'ကြည်း-၄၇၅၆၃', 'ဗိုလ်ကြီး', 'အောင်မြင့်မောင်', 'ဆလရ(၁)');

-- --------------------------------------------------------

--
-- Table structure for table `officer_training_state`
--

CREATE TABLE `officer_training_state` (
  `id` int(11) NOT NULL,
  `officer_id` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `training_name_id` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `batch` varchar(11) COLLATE utf8_unicode_ci NOT NULL,
  `grade` varchar(11) COLLATE utf8_unicode_ci DEFAULT NULL,
  `training_info_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='Traning state for officer';

--
-- Dumping data for table `officer_training_state`
--

INSERT INTO `officer_training_state` (`id`, `officer_id`, `training_name_id`, `batch`, `grade`, `training_info_id`) VALUES
(1, '7', '1', '17', 'က', 0),
(2, '8', '1', '17', 'က', 0),
(3, '8', '9', '1', 'က', 0),
(4, '8', '10', '1', 'က', 0),
(5, '9', '10', '1', 'က', 0),
(6, '9', '1', '1', 'က', 0),
(7, '9', '12', '1', 'က', 0),
(8, '7', '2', '1', 'က', 0),
(9, '7', '8', '1', 'က', 0),
(10, '7', '10', '1', 'က', 0),
(11, '7', '10', '8', 'က', 0),
(12, '9', '9', '6', 'က', 0),
(13, '8', '2', '3', 'က', 0),
(14, '9', '2', '4', 'က', 0),
(15, '10', '1', '1', 'က', 0),
(16, '11', '1', '1', 'A', 0),
(17, '11', '2', '4', 'က', 25),
(18, '12', '8', '2', '', 17),
(19, '13', '8', '2', '', 17),
(20, '14', '8', '2', '', 17),
(21, '15', '8', '2', '', 17),
(22, '12', '11', '1', '', 10),
(23, '13', '11', '1', '', 10),
(24, '14', '11', '1', '', 10),
(25, '15', '11', '1', '', 10),
(26, '11', '11', '1', '', 10),
(27, '10', '11', '1', '', 10),
(28, '9', '11', '1', '', 10),
(29, '8', '11', '1', '', 10),
(30, '7', '11', '1', '', 10),
(39, '16', '1', '2', '', 2),
(40, '16', '2', '1', '', 3),
(41, '16', '8', '1', '', 6),
(42, '16', '10', '2', '', 19),
(43, '17', '1', '1', '', 1),
(44, '17', '2', '2', '', 26),
(45, '17', '8', '2', '', 17),
(46, '17', '10', '1', '', 9),
(47, '18', '1', '6', '', 29),
(48, '24', '1', '၁', 'က', 1),
(49, '24', '2', '1', 'က', 3),
(50, '24', '8', '၁', 'က', 6),
(51, '24', '9', '၁', 'က', 8),
(52, '24', '10', '၁', 'က', 9),
(53, '7', '9', '1', 'A', 8);

-- --------------------------------------------------------

--
-- Table structure for table `other_rank_name`
--

CREATE TABLE `other_rank_name` (
  `other_rank_id` int(11) NOT NULL,
  `service_no` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `rank` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `battalion` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `edu_level` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='Other rank information';

--
-- Dumping data for table `other_rank_name`
--

INSERT INTO `other_rank_name` (`other_rank_id`, `service_no`, `rank`, `name`, `battalion`, `edu_level`) VALUES
(1, 'တ/၁၂၃၄၅၆', 'တပ်သား', 'ကျော်ကျော်', 'တရ(၉၉)', '၁၀တန်းအောင်'),
(2, 'တ/၁၂၃၄၅၇', 'တပ်သား', 'မောင်မောင်', 'တရ(၈၈)', '၁၀တန်းအောင်'),
(4, 'တ/၁၂၃၄၅၈', 'တပ်သား', 'မောင်မြင့်', 'တရ(၈၈)', '၁၀တန်းအောင်'),
(5, 'ကပ/၅၅၆၈၃', 'ဒုအရာခံဗိုလ်', 'အေးကျော်', 'တရ(၁၁)', '၈တန်းအောင်'),
(6, 'ကပ၁၂၃၄၅၆', 'တပ်သား', 'မောင်မောင်', 'စအရ(၉၀၁)', '၈တန်းအောင်'),
(7, 'ကပ၁၂၃၄၅၇', 'တပ်သား', 'အောင်အောင်', 'စအရ(၉၀၂)', '၈တန်းအောင်'),
(8, 'ကပ၁၂၃၄၅၈', 'တပ်သား', 'ညီညီ', 'စအရ(၉၀၃)', '၈တန်းအောင်'),
(9, 'ကပ၁၂၃၄၅၉', 'တပ်သား', 'ကိုကို', 'စအရ(၉၀၃)', '၈တန်းအောင်'),
(10, 'ကပ၁၂၃၄၆၀', 'တပ်သား', 'မောင်မောင်', 'စအရ(၉၁၂)', '၈တန်းအောင်'),
(11, 'ကပ၁၂၃၄၆၁', 'တပ်သား', 'အောင်ကျော်မြင့်', 'စအရ(၉၁၂)', '၈တန်းအောင်'),
(12, 'တ-၂၃၄၅၆', 'တပ်သား', 'အုန်းသီး', 'စအရ(၉၁၂)', '၈တန်းအောင်'),
(13, 'တ-၂၃၄၅၇', 'တပ်သား', 'ပေတိုး', 'စအရ(၉၁၂)', '၈တန်းအောင်'),
(14, 'တ-၂၃၄၅၈', 'တပ်သား', 'ငြိမ်းကိုထွန်း', 'စအရ(၉၁၂)', '၈တန်းအောင်'),
(15, '၃၅၄၆၈', 'ဒုအရာခံဗိုလ်', 'စိုး၀င်း', 'တအရ', ''),
(16, 'တ-၃၅၄၆၈', 'ဒုအရာခံဗိုလ်', 'မိုးမင်း', 'တအရ', '');

-- --------------------------------------------------------

--
-- Table structure for table `other_rank_training_state`
--

CREATE TABLE `other_rank_training_state` (
  `id` int(11) NOT NULL,
  `other_rank_id` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `training_name_id` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `batch` varchar(11) COLLATE utf8_unicode_ci NOT NULL,
  `grade` varchar(11) COLLATE utf8_unicode_ci NOT NULL,
  `training_info_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='Other rank training state information';

--
-- Dumping data for table `other_rank_training_state`
--

INSERT INTO `other_rank_training_state` (`id`, `other_rank_id`, `training_name_id`, `batch`, `grade`, `training_info_id`) VALUES
(1, '1', '9', '1', 'ခ', 0),
(2, '2', '9', '1', 'ခ', 0),
(3, '4', '9', '၁', 'ခ', 0),
(4, '4', '10', '၁', 'ခ', 0),
(5, '6', '9', '1', '', 8),
(6, '7', '9', '1', '', 8),
(7, '8', '9', '1', '', 8),
(8, '9', '9', '1', '', 8),
(9, '10', '9', '1', '', 8),
(10, '11', '9', '1', '', 8),
(11, '6', '9', '1', '', 8),
(12, '7', '9', '1', '', 8),
(13, '8', '9', '1', '', 8),
(14, '9', '9', '1', '', 8),
(15, '10', '9', '1', '', 8),
(16, '11', '9', '1', '', 8),
(17, '12', '9', '1', '', 8),
(18, '13', '9', '1', '', 8),
(19, '14', '9', '1', '', 8),
(20, '6', '17', '1', '', 34),
(21, '6', '16', '2', '', 32),
(22, '6', '15', '1', '', 30),
(23, '7', '17', '1', '', 34),
(24, '7', '16', '1', '', 33),
(25, '7', '15', '2', '', 31),
(26, '12', '17', '1', '', 34),
(27, '12', '16', '2', '', 32),
(28, '12', '15', '1', '', 30),
(29, '16', '9', '1', 'က', 8),
(30, '15', '9', '1', 'က', 8);

-- --------------------------------------------------------

--
-- Table structure for table `training_info`
--

CREATE TABLE `training_info` (
  `id` int(11) NOT NULL,
  `training_name_id` int(11) NOT NULL,
  `training_name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `batch` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `start_date` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `end_date` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `trainner_quantity` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='training information';

--
-- Dumping data for table `training_info`
--

INSERT INTO `training_info` (`id`, `training_name_id`, `training_name`, `batch`, `start_date`, `end_date`, `trainner_quantity`) VALUES
(1, 1, 'အင်ဂျင်နီယာတပ်စုမှူးသင်တန်း', '1', '12/2/2009', '11/6/2009', '30'),
(2, 1, 'အင်ဂျင်နီယာတပ်စုမှူးသင်တန်း', '2', '21/6/2009', '14/12/2009', '29'),
(3, 2, 'အင်ဂျင်နီယာတပ်ခွဲမှူးသင်တန်း', '1', '15/5/2018', '9/10/2018', '25'),
(4, 1, 'အင်ဂျင်နီယာတပ်စုမှူးသင်တန်း', '3', '12/12/2012', '28/3/2013', '30'),
(5, 2, 'အင်ဂျင်နီယာတပ်ခွဲမှူးသင်တန်း', '5', '5/31/2018', '6/15/2018', '31'),
(6, 8, 'အင်ဂျင်နီယာတပ်ရင်းမှူးသင်တန်း', '1', '2/19/2018', '5/31/2018', '21'),
(7, 12, 'တံတားထိုးယာဉ်အသုံးပြုနည်းသင်တန်း', '2', '2/19/2018', '5/31/2018', '21'),
(8, 9, 'မိုင်းရှင်းယာဉ်နှင့်မိုင်းရှင်းလင်းရေးကိရိယာများအသုံးပြုနည်းသင်တန်း', '1', '2/19/2018', '5/31/2018', '21'),
(9, 10, 'မိုင်းရှင်းယာဉ်အသုံးပြုနည်းသင်တန်း', '1', '2/19/2018', '5/31/2018', '21'),
(10, 11, 'မိုင်းရှင်းလင်းရေးကိရိယာအသုံးပြုနည်းသင်တန်း', '1', '2/19/2018', '5/31/2018', '21'),
(11, 12, 'တံတားထိုးယာဉ်အသုံးပြုနည်းသင်တန်း', '1', '2/19/2018', '5/31/2018', '21'),
(12, 13, 'အင်ဂျင်နီယာအရာရှိဥမင်လိုဏ်ခေါင်းစစ်ဆင်ရေးသင်တန်း', '1', '2/19/2018', '5/31/2018', '21'),
(13, 1, 'အင်ဂျင်နီယာတပ်စုမှူးသင်တန်း', '4', '1/8/2018', '5/31/2018', '32'),
(15, 2, 'အင်ဂျင်နီယာတပ်ခွဲမှူးသင်တန်း', '3', '3/5/2018', '5/31/2018', '25'),
(17, 8, 'အင်ဂျင်နီယာတပ်ရင်းမှူးသင်တန်း', '2', '3/1/2018', '5/31/2018', '14'),
(18, 9, 'မိုင်းရှင်းယာဉ်နှင့်မိုင်းရှင်းလင်းရေးကိရိယာများအသုံးပြုနည်းသင်တန်း', '2', '5/1/2018', '5/31/2018', '30'),
(19, 10, 'မိုင်းရှင်းယာဉ်အသုံးပြုနည်းသင်တန်း', '2', '5/31/2018', '7/13/2018', '12'),
(20, 11, 'မိုင်းရှင်းလင်းရေးကိရိယာအသုံးပြုနည်းသင်တန်း', '2', '4/9/2018', '5/31/2018', '35'),
(21, 12, 'တံတားထိုးယာဉ်အသုံးပြုနည်းသင်တန်း', '3', '4/30/2018', '5/31/2018', '23'),
(23, 1, 'အင်ဂျင်နီယာတပ်စုမှူးသင်တန်း', '5', '6/5/2017', '9/8/2017', '42'),
(24, 9, 'မိုင်းရှင်းယာဉ်နှင့်မိုင်းရှင်းလင်းရေးကိရိယာများအသုံးပြုနည်းသင်တန်း', '3', '6/4/2018', '6/29/2018', '12'),
(25, 2, 'အင်ဂျင်နီယာတပ်ခွဲမှူးသင်တန်း', '4', '5/28/2018', '6/29/2018', '30'),
(26, 2, 'အင်ဂျင်နီယာတပ်ခွဲမှူးသင်တန်း', '2', '5/1/2018', '6/27/2018', '30'),
(27, 14, 'အခြေခံစစ်မြေပြင်အင်ဂျင်နီယာသင်တန်း', '1', '6/6/2018', '9/7/2018', '30'),
(28, 14, 'အခြေခံစစ်မြေပြင်အင်ဂျင်နီယာသင်တန်း', '2', '6/6/2018', '6/29/2018', '30'),
(29, 1, 'အင်ဂျင်နီယာတပ်စုမှူးသင်တန်း', '6', '6/1/2018', '6/28/2018', '30'),
(30, 15, 'အင်ဂျင်နီယာပညာသည်အတန်း(၁)', '1', '2/20/2018', '6/19/2018', '20'),
(31, 15, 'အင်ဂျင်နီယာပညာသည်အတန်း(၁)', '2', '2/20/2018', '6/19/2018', '20'),
(32, 16, 'အင်ဂျင်နီယာပညာသည်အတန်း(၂)', '2', '2/20/2018', '6/19/2018', '20'),
(33, 16, 'အင်ဂျင်နီယာပညာသည်အတန်း(၂)', '1', '2/20/2018', '6/19/2018', '20'),
(34, 17, 'အင်ဂျင်နီယာပညာသည်အတန်း(၃)', '1', '2/20/2018', '6/19/2018', '20'),
(35, 17, 'အင်ဂျင်နီယာပညာသည်အတန်း(၃)', '2', '2/20/2018', '6/19/2018', '20');

-- --------------------------------------------------------

--
-- Table structure for table `training_name`
--

CREATE TABLE `training_name` (
  `training_name_id` int(11) UNSIGNED NOT NULL,
  `training_name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `row` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='training name and short name to use ';

--
-- Dumping data for table `training_name`
--

INSERT INTO `training_name` (`training_name_id`, `training_name`, `row`) VALUES
(1, 'အင်ဂျင်နီယာတပ်စုမှူးသင်တန်း', 1),
(2, 'အင်ဂျင်နီယာတပ်ခွဲမှူးသင်တန်း', 1),
(8, 'အင်ဂျင်နီယာတပ်ရင်းမှူးသင်တန်း', 1),
(9, 'မိုင်းရှင်းယာဉ်နှင့်မိုင်းရှင်းလင်းရေးကိရိယာများအသုံးပြုနည်းသင်တန်း', 3),
(10, 'မိုင်းရှင်းယာဉ်အသုံးပြုနည်းသင်တန်း', 3),
(11, 'မိုင်းရှင်းလင်းရေးကိရိယာအသုံးပြုနည်းသင်တန်း', 3),
(12, 'တံတားထိုးယာဉ်အသုံးပြုနည်းသင်တန်း', 3),
(13, 'အင်ဂျင်နီယာအရာရှိဥမင်လိုဏ်ခေါင်းစစ်ဆင်ရေးသင်တန်း', 1),
(14, 'အခြေခံစစ်မြေပြင်အင်ဂျင်နီယာသင်တန်း', 2),
(15, 'အင်ဂျင်နီယာပညာသည်အတန်း(၁)', 2),
(16, 'အင်ဂျင်နီယာပညာသည်အတန်း(၂)', 2),
(17, 'အင်ဂျင်နီယာပညာသည်အတန်း(၃)', 2),
(18, 'အင်ဂျင်နီယာအကြပ်ငယ်သင်တန်း', 2),
(19, 'အင်ဂျင်နီယာအရာခံ/အကြပ်ကြီးသင်တန်း', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `auth`
--
ALTER TABLE `auth`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `uname` (`uname`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `officer_name`
--
ALTER TABLE `officer_name`
  ADD PRIMARY KEY (`officer_id`),
  ADD UNIQUE KEY `bc_no` (`bc_no`);

--
-- Indexes for table `officer_training_state`
--
ALTER TABLE `officer_training_state`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `other_rank_name`
--
ALTER TABLE `other_rank_name`
  ADD PRIMARY KEY (`other_rank_id`),
  ADD UNIQUE KEY `service_no` (`service_no`);

--
-- Indexes for table `other_rank_training_state`
--
ALTER TABLE `other_rank_training_state`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `training_info`
--
ALTER TABLE `training_info`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `training_name`
--
ALTER TABLE `training_name`
  ADD PRIMARY KEY (`training_name_id`),
  ADD UNIQUE KEY `training_name` (`training_name`),
  ADD UNIQUE KEY `training_name_2` (`training_name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `auth`
--
ALTER TABLE `auth`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT for table `officer_name`
--
ALTER TABLE `officer_name`
  MODIFY `officer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `officer_training_state`
--
ALTER TABLE `officer_training_state`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;
--
-- AUTO_INCREMENT for table `other_rank_name`
--
ALTER TABLE `other_rank_name`
  MODIFY `other_rank_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT for table `other_rank_training_state`
--
ALTER TABLE `other_rank_training_state`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
--
-- AUTO_INCREMENT for table `training_info`
--
ALTER TABLE `training_info`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;
--
-- AUTO_INCREMENT for table `training_name`
--
ALTER TABLE `training_name`
  MODIFY `training_name_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

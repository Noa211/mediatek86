-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(3, '2026-03-02 12:04:08', '2026-06-06 17:30:27', 1),
(4, '2026-05-06 23:24:48', '2026-06-27 18:44:26', 3),
(7, '2026-02-11 15:33:15', '2026-05-23 05:05:07', 1),
(9, '2026-05-10 14:50:02', '2026-06-28 15:24:16', 2),
(9, '2026-04-30 02:30:00', '2026-07-01 05:23:34', 3),
(4, '2026-03-04 01:52:08', '2026-06-29 20:37:04', 2),
(2, '2026-02-07 20:22:11', '2026-06-07 21:46:04', 2),
(8, '2026-01-06 03:26:18', '2026-06-23 21:01:31', 1),
(6, '2026-04-02 04:37:10', '2026-05-20 16:29:13', 2),
(4, '2026-01-12 05:37:47', '2026-06-14 12:29:41', 2),
(5, '2026-02-24 01:20:31', '2026-06-18 08:37:35', 1),
(4, '2026-01-30 13:21:56', '2026-05-27 08:55:47', 1),
(11, '2026-03-25 10:23:54', '2026-06-04 13:22:07', 4),
(12, '2026-02-17 07:27:19', '2026-06-12 04:56:42', 1),
(5, '2026-03-02 05:40:45', '2026-06-26 05:45:39', 3),
(1, '2026-03-14 05:08:56', '2026-06-11 16:42:42', 2),
(7, '2026-04-22 19:40:41', '2026-06-14 13:35:10', 2),
(1, '2026-01-22 22:40:46', '2026-06-10 03:53:47', 2),
(10, '2026-04-01 14:08:10', '2026-06-24 04:03:38', 4),
(10, '2026-05-07 04:36:51', '2026-06-05 05:59:43', 2),
(8, '2026-04-10 07:25:47', '2026-05-25 06:41:42', 3),
(2, '2026-01-19 16:38:33', '2026-06-09 15:11:15', 1),
(2, '2026-02-16 16:07:30', '2026-06-05 17:37:27', 3),
(12, '2026-05-17 19:56:36', '2026-06-11 22:19:49', 2),
(1, '2026-05-28 00:00:00', '2026-05-31 00:00:00', 1),
(3, '2026-01-25 05:17:17', '2026-05-25 07:38:12', 3),
(6, '2026-01-27 17:59:08', '2026-06-18 03:26:23', 3),
(5, '2026-04-29 12:50:27', '2026-06-17 23:03:54', 2),
(11, '2026-05-07 15:43:41', '2026-06-16 03:04:22', 3),
(5, '2026-03-23 08:11:56', '2026-06-05 20:12:25', 1),
(8, '2026-03-30 03:12:10', '2026-05-26 06:43:40', 3),
(11, '2026-01-07 05:46:26', '2026-06-08 18:21:39', 3),
(9, '2026-02-24 11:44:33', '2026-06-22 19:22:43', 2),
(3, '2026-01-25 08:41:58', '2026-06-09 00:51:20', 1),
(3, '2026-04-26 15:12:24', '2026-06-05 17:54:03', 3),
(11, '2026-01-21 02:48:48', '2026-06-03 06:11:32', 2),
(4, '2026-04-15 05:52:54', '2026-05-19 16:55:05', 1),
(6, '2026-05-14 00:50:17', '2026-06-24 23:00:38', 1),
(10, '2026-05-14 23:23:14', '2026-06-04 09:08:09', 2),
(2, '2026-02-03 07:30:56', '2026-06-08 03:31:43', 3),
(3, '2026-01-14 03:48:14', '2026-06-27 20:08:30', 3),
(2, '2026-05-17 23:41:51', '2026-06-05 17:01:59', 2),
(10, '2026-05-05 12:48:32', '2026-06-27 15:57:56', 3),
(7, '2026-05-15 03:26:49', '2026-06-22 01:23:15', 1),
(10, '2026-02-07 04:37:35', '2026-07-01 14:40:16', 3),
(7, '2026-02-20 08:11:31', '2026-05-30 23:00:33', 3),
(11, '2026-05-09 13:21:58', '2026-06-03 04:45:14', 2),
(3, '2026-04-30 02:09:59', '2026-06-28 15:28:39', 2),
(9, '2026-02-09 06:25:14', '2026-07-01 07:42:01', 1),
(4, '2026-02-21 07:32:20', '2026-05-24 03:33:50', 2),
(5, '2026-05-28 00:00:00', '2026-05-30 00:00:00', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Berger', 'Cassidy', '04 69 12 39 44', 'dui.in@protonmail.couk', 2),
(2, 'Long', 'Oliver', '02 70 33 15 53', 'neque.pellentesque@google.couk', 1),
(3, 'Workman', 'Lee', '07 57 17 70 53', 'rutrum@aol.net', 1),
(4, 'Mcneil', 'Knox', '05 31 72 65 56', 'dictum.mi.ac@protonmail.org', 2),
(5, 'Cooley', 'Rhoda', '04 62 83 21 88', 'ligula.aliquam@google.net', 2),
(6, 'Chapman', 'Yardley', '06 89 24 88 02', 'augue.eu@yahoo.com', 2),
(7, 'Barnes', 'Kirsten', '03 62 21 48 13', 'proin.ultrices.duis@yahoo.ca', 2),
(8, 'Santiago', 'Stephen', '07 48 57 84 44', 'scelerisque.scelerisque.dui@aol.com', 2),
(9, 'Sharp', 'Myles', '04 96 55 58 11', 'mauris@icloud.edu', 1),
(10, 'Wheeler', 'Magee', '03 75 44 32 85', 'nascetur.ridiculus@google.ca', 2),
(11, 'Lawson', 'Yuri', '08 07 51 88 68', 'placerat.orci@protonmail.ca', 2),
(12, 'Justice', 'Ariana', '09 67 33 63 41', 'dui.fusce@protonmail.edu', 3),
(14, 'Noel', 'Jean', '06 08 45 10 35', 'jnoel@yahoo.fr', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('mediatekres', 'd8de0f1ad881a39a0e8dd6208692e2284a4a5b78fba3772a44ee6dac54d309f5');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

--
-- Création de l'utilisateur
--

CREATE USER 'mediatekuser'@'%' IDENTIFIED BY 'mediatek86';

--
-- Privilèges de l'utilisateur
--

GRANT USAGE ON *.* TO `mediatekuser`@`%`;
GRANT SELECT, INSERT, UPDATE, DELETE ON `mediatek86`.* TO `mediatekuser`@`%`;
FLUSH PRIVILEGES;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

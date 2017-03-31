-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Ven 31 Mars 2017 à 17:10
-- Version du serveur :  10.1.21-MariaDB
-- Version de PHP :  5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `arrowfr`
--

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenirTypeAdhesion` (IN `id` INT)  READS SQL DATA
select * from TypeAdhesion where idTypeAdhesion = id$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `adherent`
--

CREATE TABLE `adherent` (
  `idAdherent` int(11) NOT NULL,
  `Nom` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Prenom` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `DateNaissance` date DEFAULT NULL,
  `Ville` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CodePostal` varchar(6) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TypeAdhesion` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Contenu de la table `adherent`
--

INSERT INTO `adherent` (`idAdherent`, `Nom`, `Prenom`, `DateNaissance`, `Ville`, `CodePostal`, `TypeAdhesion`) VALUES
(1, 'Durant', 'Jean', '1990-07-08', 'Trappes', '78190', 1),
(6, 'Wang', 'Jye', '1990-07-22', 'Paris', '75014', 2),
(7, 'Russel', 'Jack', '1998-04-13', 'LeMans', '72000', 1),
(9, 'Mouton', 'Paul', '2017-03-22', 'Caen', '14000', 1),
(14, 'Maire', 'Louise2', '1986-12-21', 'Rennes', '49000', 1),
(15, 'Durant', 'Jean', '1990-07-08', 'Trappes', '78190', 1),
(16, 'Grand', 'Alexandre', '1995-09-18', 'Toulouse', '31000', 2),
(17, 'Maire', 'Louise', '1986-12-21', 'Rennes', '49000', 3),
(21, 'Rouiller', 'Benoit', '1994-08-30', 'Alençon', '61000', 1);

-- --------------------------------------------------------

--
-- Structure de la table `typeadhesion`
--

CREATE TABLE `typeadhesion` (
  `idTypeAdhesion` int(11) NOT NULL,
  `Libelle` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Tarif` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Contenu de la table `typeadhesion`
--

INSERT INTO `typeadhesion` (`idTypeAdhesion`, `Libelle`, `Tarif`) VALUES
(1, 'Loisir', 50),
(2, 'Compétition', 80),
(3, 'Entrainement', 60);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `adherent`
--
ALTER TABLE `adherent`
  ADD PRIMARY KEY (`idAdherent`),
  ADD KEY `fk_Adherent_TypeAdhesion` (`TypeAdhesion`);

--
-- Index pour la table `typeadhesion`
--
ALTER TABLE `typeadhesion`
  ADD PRIMARY KEY (`idTypeAdhesion`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `adherent`
--
ALTER TABLE `adherent`
  MODIFY `idAdherent` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
--
-- AUTO_INCREMENT pour la table `typeadhesion`
--
ALTER TABLE `typeadhesion`
  MODIFY `idTypeAdhesion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `adherent`
--
ALTER TABLE `adherent`
  ADD CONSTRAINT `fk_Adherent_TypeAdhesion` FOREIGN KEY (`TypeAdhesion`) REFERENCES `typeadhesion` (`idTypeAdhesion`) ON DELETE SET NULL ON UPDATE SET NULL;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

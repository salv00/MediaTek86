-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 04 juin 2021 à 11:13
-- Version du serveur :  8.0.21
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : mediatek86
--
CREATE DATABASE IF NOT EXISTS mediatek86 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE mediatek86;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE absence (
  IDPERSONNEL int NOT NULL,
  DATEDEBUT datetime NOT NULL,
  IDMOTIF int NOT NULL,
  DATEFIN datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (IDPERSONNEL, DATEDEBUT, IDMOTIF, DATEFIN) VALUES
(1, '2017-09-06 08:00:00', 4, '2017-09-20 17:00:00'),
(1, '2018-09-23 08:00:00', 3, '2018-09-23 17:00:00'),
(1, '2019-03-01 08:00:00', 4, '2019-03-15 17:00:00'),
(1, '2020-06-09 08:00:00', 1, '2020-06-24 17:00:00'),
(1, '2021-03-09 09:32:00', 2, '2021-03-11 17:00:00'),
(2, '2017-09-03 08:00:00', 1, '2017-09-04 17:00:00'),
(2, '2018-05-29 08:00:00', 4, '2018-06-03 17:00:00'),
(2, '2019-02-04 08:00:00', 3, '2019-02-06 17:00:00'),
(2, '2020-09-01 08:00:00', 3, '2020-09-02 17:00:00'),
(3, '2017-02-20 08:00:00', 3, '2017-02-21 17:00:00'),
(3, '2018-12-03 08:00:00', 1, '2018-12-10 17:00:00'),
(3, '2019-04-09 08:00:00', 2, '2019-04-16 17:00:00'),
(3, '2020-07-06 08:00:00', 4, '2020-07-17 17:00:00'),
(3, '2021-02-24 08:00:00', 2, '2021-02-26 17:00:00'),
(3, '2021-03-15 08:00:00', 1, '2021-03-19 17:00:00'),
(4, '2017-04-16 08:00:00', 4, '2017-04-18 17:00:00'),
(4, '2018-05-03 08:00:00', 3, '2018-05-08 17:00:00'),
(4, '2019-04-18 08:00:00', 1, '2019-05-01 17:00:00'),
(4, '2020-10-20 08:00:00', 2, '2020-10-23 17:00:00'),
(4, '2021-02-14 08:00:00', 4, '2021-03-01 17:00:00'),
(5, '2017-03-31 08:00:00', 2, '2017-03-04 17:00:00'),
(5, '2019-05-07 08:00:00', 4, '2019-05-14 17:00:00'),
(5, '2020-11-16 08:00:00', 1, '2020-11-20 17:00:00'),
(5, '2021-01-28 08:00:00', 3, '2021-02-09 17:00:00'),
(5, '2021-04-05 08:00:00', 1, '2021-04-09 17:00:00'),
(6, '2017-02-25 08:00:00', 2, '2017-02-26 17:00:00'),
(6, '2018-06-13 08:00:00', 1, '2018-06-23 17:00:00'),
(6, '2019-06-03 08:00:00', 3, '2019-06-04 08:00:00'),
(6, '2020-08-11 08:00:00', 1, '2020-08-25 17:00:00'),
(6, '2021-01-18 08:00:00', 1, '2021-02-03 17:00:00'),
(7, '2017-01-19 08:00:00', 3, '2017-01-22 17:00:00'),
(7, '2018-04-05 08:00:00', 4, '2018-04-15 17:00:00'),
(7, '2019-07-17 08:00:00', 2, '2019-07-22 08:00:00'),
(7, '2020-12-02 08:00:00', 2, '2020-12-04 17:00:00'),
(8, '2017-02-01 08:00:00', 4, '2017-02-15 17:00:00'),
(8, '2018-07-06 08:00:00', 3, '2018-07-10 17:00:00'),
(8, '2019-10-09 08:00:00', 1, '2019-10-29 17:00:00'),
(8, '2020-05-12 08:00:00', 4, '2020-05-21 17:00:00'),
(8, '2021-01-05 08:00:00', 2, '2021-01-19 17:00:00'),
(9, '2017-07-04 08:00:00', 2, '2017-07-14 17:00:00'),
(9, '2018-08-31 08:00:00', 1, '2018-09-10 17:00:00'),
(9, '2019-06-25 08:00:00', 1, '2019-07-10 08:00:00'),
(9, '2020-10-21 08:00:00', 3, '2020-10-27 17:00:00'),
(9, '2021-04-26 08:00:00', 4, '2021-05-10 17:00:00'),
(10, '2017-02-21 08:00:00', 1, '2017-02-25 17:00:00'),
(10, '2018-12-13 08:00:00', 3, '2018-12-20 17:00:00'),
(10, '2019-11-27 08:00:00', 2, '2019-12-03 17:00:00'),
(10, '2020-10-05 08:00:00', 1, '2020-10-19 17:00:00'),
(10, '2021-04-04 12:15:00', 3, '2021-04-04 17:00:00'),
(12, '2021-06-03 00:00:00', 1, '2021-06-04 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE motif (
  IDMOTIF int NOT NULL,
  LIBELLE varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (IDMOTIF, LIBELLE) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE personnel (
  IDPERSONNEL int NOT NULL,
  IDSERVICE int NOT NULL,
  NOM varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRENOM varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  TEL varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  MAIL varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (IDPERSONNEL, IDSERVICE, NOM, PRENOM, TEL, MAIL) VALUES
(1, 3, 'Warren', 'Zephania', '07 12 89 67 35', 'odio.tristique.pharetra@aarcu.co.uk'),
(2, 2, 'Cleveland', 'Christopher', '02 80 16 12 99', 'Sed.neque@et.com'),
(3, 2, 'Lawson', 'Josephine', '03 00 78 10 94', 'montes.nascetur@utipsum.co.uk'),
(4, 2, 'Horne', 'Charles', '05 48 40 16 20', 'Suspendisse.tristique@enimcondimentum.edu'),
(5, 1, 'Benjamin', 'Kimberly', '07 84 13 39 27', 'Pellentesque@necquamCurabitur.edu'),
(6, 3, 'Lee', 'Norman', '01 48 18 31 71', 'sed.dolor.Fusce@ultrices.co.uk'),
(7, 1, 'Merrill', 'Sade', '08 33 10 17 98', 'Aenean.euismod@Integertincidunt.co.uk'),
(8, 2, 'Wilson', 'Maggie', '01 53 28 81 48', 'ac.eleifend.vitae@laciniaatiaculis.ca'),
(9, 3, 'Combs', 'Barrett', '06 85 38 98 71', 'lacus.Cras.interdum@idante.net'),
(10, 1, 'Coffey', 'Sandra', '01 81 17 84 74', 'mi.lorem.vehicula@vehicularisus.edu'),
(12, 1, 'covalea', 'salvatore', '076884****', 'covaleasalvatore20@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE responsable (
  login varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  pwd varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('admin', 'fbfdc403f3e42b7315f67644dbb78eecf765c869f951136bf3e35b673aeafca4');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE service (
  IDSERVICE int NOT NULL,
  NOM varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (IDSERVICE, NOM) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table absence
--
ALTER TABLE absence
  ADD PRIMARY KEY (IDPERSONNEL,DATEDEBUT),
  ADD KEY I_FK_ABSENCE_MOTIF (IDMOTIF),
  ADD KEY I_FK_ABSENCE_PERSONNEL (IDPERSONNEL);

--
-- Index pour la table motif
--
ALTER TABLE motif
  ADD PRIMARY KEY (IDMOTIF);

--
-- Index pour la table personnel
--
ALTER TABLE personnel
  ADD PRIMARY KEY (IDPERSONNEL),
  ADD KEY I_FK_PERSONNEL_SERVICE (IDSERVICE);

--
-- Index pour la table service
--
ALTER TABLE service
  ADD PRIMARY KEY (IDSERVICE);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table motif
--
ALTER TABLE motif
  MODIFY IDMOTIF int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table personnel
--
ALTER TABLE personnel
  MODIFY IDPERSONNEL int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT pour la table service
--
ALTER TABLE service
  MODIFY IDSERVICE int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table absence
--
ALTER TABLE absence
  ADD CONSTRAINT absence_ibfk_1 FOREIGN KEY (IDMOTIF) REFERENCES motif (IDMOTIF),
  ADD CONSTRAINT absence_ibfk_2 FOREIGN KEY (IDPERSONNEL) REFERENCES personnel (IDPERSONNEL);

--
-- Contraintes pour la table personnel
--
ALTER TABLE personnel
  ADD CONSTRAINT personnel_ibfk_1 FOREIGN KEY (IDSERVICE) REFERENCES service (IDSERVICE);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

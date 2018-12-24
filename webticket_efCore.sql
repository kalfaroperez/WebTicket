-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.13-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win32
-- HeidiSQL Versión:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para webticket
CREATE DATABASE IF NOT EXISTS `webticket` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `webticket`;

-- Volcando estructura para tabla webticket.area
CREATE TABLE IF NOT EXISTS `area` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` longtext NOT NULL,
  `Estado` int(11) NOT NULL,
  `Insert_Oper` longtext,
  `Insert_Datetime` datetime(6) NOT NULL,
  `Update_Oper` longtext,
  `Update_Datetime` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.area: ~11 rows (aproximadamente)
DELETE FROM `area`;
/*!40000 ALTER TABLE `area` DISABLE KEYS */;
INSERT INTO `area` (`Id`, `Nombre`, `Estado`, `Insert_Oper`, `Insert_Datetime`, `Update_Oper`, `Update_Datetime`) VALUES
	(1, 'MANTENIMIENTO', 1, 'aluna', '2018-01-15 08:44:40.000000', 'aluna', '2018-01-15 08:44:40.000000'),
	(2, 'ADMINISTRACION', 1, 'aluna', '2018-01-15 08:44:47.000000', 'aluna', '2018-01-15 08:44:47.000000'),
	(3, 'CONTABILIDAD', 1, 'aluna', '2018-01-15 08:44:53.000000', 'aluna', '2018-01-15 08:44:53.000000'),
	(4, 'COMERCIAL', 1, 'aluna', '2018-01-15 08:45:06.000000', 'aluna', '2018-01-15 08:45:06.000000'),
	(5, 'RRHH - SST', 1, 'aluna', '2018-01-15 08:45:13.000000', 'aluna', '2018-01-15 08:45:13.000000'),
	(6, 'PRODUCCION', 1, 'aluna', '2018-01-15 08:45:29.000000', 'aluna', '2018-01-15 08:45:29.000000'),
	(7, 'CALIDAD - I + D', 1, 'aluna', '2018-01-15 08:45:34.000000', 'aluna', '2018-01-15 08:45:34.000000'),
	(8, 'DESPACHOS', 1, 'aluna', '2018-01-15 08:45:40.000000', 'aluna', '2018-01-15 08:45:40.000000'),
	(9, 'PLANTA 4', 1, 'aluna', '2018-01-15 08:46:24.000000', 'aluna', '2018-01-15 08:46:44.000000'),
	(10, 'BOGOTA', 1, 'aluna', '2018-01-15 08:46:51.000000', 'aluna', '2018-01-15 08:46:51.000000'),
	(11, 'PRUEBA', 1, 'jmto', '2018-03-10 17:31:07.000000', 'jmto', '2018-03-10 17:31:07.000000');
/*!40000 ALTER TABLE `area` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.aspnetroleclaims
CREATE TABLE IF NOT EXISTS `aspnetroleclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.aspnetroleclaims: ~0 rows (aproximadamente)
DELETE FROM `aspnetroleclaims`;
/*!40000 ALTER TABLE `aspnetroleclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroleclaims` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.aspnetroles
CREATE TABLE IF NOT EXISTS `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext,
  `Discriminator` longtext NOT NULL,
  `Enabled` bit(1) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.aspnetroles: ~2 rows (aproximadamente)
DELETE FROM `aspnetroles`;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
INSERT INTO `aspnetroles` (`Id`, `Name`, `NormalizedName`, `ConcurrencyStamp`, `Discriminator`, `Enabled`) VALUES
	('2c6241c7-2293-4a16-bd3f-0496fcad60b6', 'Operador', 'OPERADOR', 'a7487ee9-43a1-4283-991f-f6c18b64375f', 'IdentityRole', NULL),
	('8178a544-ce36-4531-b1a0-a4d10e3ef55d', 'Administrador', 'ADMINISTRADOR', 'd6597d0b-2ff0-4292-ba31-abc0e642ce43', 'IdentityRole', NULL);
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.aspnetuserclaims
CREATE TABLE IF NOT EXISTS `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.aspnetuserclaims: ~0 rows (aproximadamente)
DELETE FROM `aspnetuserclaims`;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.aspnetuserlogins
CREATE TABLE IF NOT EXISTS `aspnetuserlogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext,
  `UserId` varchar(255) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.aspnetuserlogins: ~0 rows (aproximadamente)
DELETE FROM `aspnetuserlogins`;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.aspnetuserroles
CREATE TABLE IF NOT EXISTS `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `Discriminator` longtext NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.aspnetuserroles: ~4 rows (aproximadamente)
DELETE FROM `aspnetuserroles`;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
INSERT INTO `aspnetuserroles` (`UserId`, `RoleId`, `Discriminator`) VALUES
	('02f3eca4-a127-4733-b4de-c7a99c93e42d', '2c6241c7-2293-4a16-bd3f-0496fcad60b6', 'IdentityUserRole<string>'),
	('429cf5fd-a345-4af9-bdba-4c5c20539d9f', '2c6241c7-2293-4a16-bd3f-0496fcad60b6', 'IdentityUserRole<string>'),
	('7e87bfc1-b0cf-48fd-b198-c12b6801cc66', '2c6241c7-2293-4a16-bd3f-0496fcad60b6', 'IdentityUserRole<string>'),
	('ebd1ee24-4f60-4203-ba84-c745957e3a3e', '8178a544-ce36-4531-b1a0-a4d10e3ef55d', 'IdentityUserRole<string>');
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.aspnetusers
CREATE TABLE IF NOT EXISTS `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `ConcurrencyStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `Discriminator` longtext NOT NULL,
  `FullName` varchar(250) NOT NULL,
  `Area` int(11) NOT NULL,
  `Ubicacion` varchar(250) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `Extension` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.aspnetusers: ~4 rows (aproximadamente)
DELETE FROM `aspnetusers`;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`, `Discriminator`, `FullName`, `Area`, `Ubicacion`, `Telefono`, `Extension`) VALUES
	('02f3eca4-a127-4733-b4de-c7a99c93e42d', 'rcastrov', 'RCASTROV', 'rcastrov@gmail.com', 'RCASTROV@GMAIL.COM', b'0', 'AQAAAAEAACcQAAAAEDtiLGQkNQ99wwZO4uOPz0jTrCX9TZN+ZvY+C1i9KpLQ4p8VHkrrsTCUdfSU4w8bdQ==', 'KVQ4NEUFFOOZJU24EB6I6ED7Z2XLPUPF', '7fc8cc6a-be56-416b-bc81-f05fa7d338f7', NULL, b'0', b'0', NULL, b'1', 0, 'ApplicationUser', 'Ruth Castro', 2, 'P Cartagena', '6556', NULL),
	('429cf5fd-a345-4af9-bdba-4c5c20539d9f', 'jmto', 'JMTO', 'jmto@realsa.com', 'JMTO@REALSA.COM', b'1', 'AQAAAAEAACcQAAAAEGRMoWZ4nTIvnh5nJhE5dp+4qXB2tr1PCB8wtTr3KG+GUEPBEkhmBshSAAUHVlhQXQ==', 'FE7VDJF4IU7BGMCGF2IBYDXBLZ6WJG6F', '5cf43ff1-70bb-4c41-99b3-d7e4908235d1', NULL, b'0', b'0', NULL, b'1', 0, 'ApplicationUser', 'Marlon Torres', 1, 'Mantenimiento', '23321432', NULL),
	('7e87bfc1-b0cf-48fd-b198-c12b6801cc66', 'jbarragan', 'JBARRAGAN', 'jbarragan@realsa.com', 'JBARRAGAN@REALSA.COM', b'0', 'AQAAAAEAACcQAAAAED2q3Ux1QPaMrOEOpxtaINEPNXpVRVp1TyA6l0nivnLzCENf8/k1Mx5Yp9DGv3mMBA==', 'O7ZVUJ42AOTZ2XCD3XEYLBFOX6TVQXEP', '9ce576a5-c0c7-4814-8f5e-8936141bf218', NULL, b'0', b'0', NULL, b'1', 0, 'ApplicationUser', 'Juan Carlos Barragan Echeverria', 1, 'Mantenimiento', '321513513', NULL),
	('ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'aluna', 'ALUNA', 'aluna@realsa.com', 'ALUNA@REALSA.COM', b'1', 'AQAAAAEAACcQAAAAEPjgkaRA1tQwtx3ZLntSgy9Y00I3dAaD3cos3shcrtoVHYQzNtVW6f+4tBO7wzoHOw==', 'fe6e497f-829c-464c-9b47-179e046c9446', '3caa51db-dc5e-4974-b2d3-2e1f430da749', NULL, b'0', b'0', NULL, b'0', 0, 'ApplicationUser', 'Anibal Luna', 2, 'ADMINISTRACION', '66555', NULL);
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.aspnetusertokens
CREATE TABLE IF NOT EXISTS `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.aspnetusertokens: ~0 rows (aproximadamente)
DELETE FROM `aspnetusertokens`;
/*!40000 ALTER TABLE `aspnetusertokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusertokens` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.calificacionservicio
CREATE TABLE IF NOT EXISTS `calificacionservicio` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `FechaInsercion` datetime(6) DEFAULT NULL,
  `FechaModificacion` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.calificacionservicio: ~4 rows (aproximadamente)
DELETE FROM `calificacionservicio`;
/*!40000 ALTER TABLE `calificacionservicio` DISABLE KEYS */;
INSERT INTO `calificacionservicio` (`Id`, `Nombre`, `FechaInsercion`, `FechaModificacion`) VALUES
	(1, 'Sin Calificar', '2018-11-24 13:10:57.364574', '2018-11-24 13:10:57.364725'),
	(2, 'Rechazado', '2018-11-24 13:11:12.995505', '2018-11-24 13:11:12.995507'),
	(3, 'Aceptable', '2018-11-24 13:11:24.445168', '2018-11-24 13:11:24.445170'),
	(4, 'Aceptable con Obs', '2018-11-24 13:11:48.817439', '2018-11-24 13:11:48.817441');
/*!40000 ALTER TABLE `calificacionservicio` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.componentes
CREATE TABLE IF NOT EXISTS `componentes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` longtext,
  `Descripcion` longtext,
  `Estado` bit(1) NOT NULL,
  `Insert_Oper` longtext,
  `Insert_Datetime` datetime(6) NOT NULL,
  `Update_Oper` longtext,
  `Update_Datetime` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.componentes: ~7 rows (aproximadamente)
DELETE FROM `componentes`;
/*!40000 ALTER TABLE `componentes` DISABLE KEYS */;
INSERT INTO `componentes` (`Id`, `Nombre`, `Descripcion`, `Estado`, `Insert_Oper`, `Insert_Datetime`, `Update_Oper`, `Update_Datetime`) VALUES
	(1, 'Motorreductor ', 'Motorreductor ', b'0', 'insert', '2018-02-22 18:39:38.000000', '', '2018-02-22 18:39:39.000000'),
	(2, 'Bomba Catpumps', 'Bomba Catpumps', b'0', 'insert', '2018-02-22 18:40:03.000000', '', '2018-02-22 18:40:04.000000'),
	(3, 'Colector de polvo', 'Colector de polvo', b'0', 'insert', '2018-02-22 20:24:21.000000', '', '2018-02-22 20:24:22.000000'),
	(4, 'Blower', 'Blower', b'0', 'insert', '0000-00-00 00:00:00.000000', '', '0000-00-00 00:00:00.000000'),
	(6, 'Nuevo c1', NULL, b'0', '', '0001-01-01 00:00:00.000000', '', '0001-01-01 00:00:00.000000'),
	(7, 'Nuevo c2', '', b'1', 'insert', '2018-06-13 05:34:35.000000', '', '0000-00-00 00:00:00.000000'),
	(8, 'Nuevo c3', '', b'1', 'insert', '2018-06-13 05:34:50.000000', '', '0000-00-00 00:00:00.000000');
/*!40000 ALTER TABLE `componentes` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.emailerror
CREATE TABLE IF NOT EXISTS `emailerror` (
  `IdEmailError` bigint(20) NOT NULL AUTO_INCREMENT,
  `FromName` longtext,
  `FromEMail` longtext,
  `ToName` longtext,
  `ToEMail` longtext,
  `Subject` longtext,
  `Body` longtext,
  `ErrorMessage` longtext,
  `FechaInsercion` datetime(6) NOT NULL,
  `FechaModificacion` datetime(6) NOT NULL,
  PRIMARY KEY (`IdEmailError`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.emailerror: ~0 rows (aproximadamente)
DELETE FROM `emailerror`;
/*!40000 ALTER TABLE `emailerror` DISABLE KEYS */;
/*!40000 ALTER TABLE `emailerror` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.equipoprincipal
CREATE TABLE IF NOT EXISTS `equipoprincipal` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` longtext,
  `Descripcion` longtext,
  `Estado` bit(1) NOT NULL,
  `Insert_Oper` longtext,
  `Insert_Datetime` datetime(6) NOT NULL,
  `Update_Oper` longtext,
  `Update_Datetime` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.equipoprincipal: ~3 rows (aproximadamente)
DELETE FROM `equipoprincipal`;
/*!40000 ALTER TABLE `equipoprincipal` DISABLE KEYS */;
INSERT INTO `equipoprincipal` (`Id`, `Nombre`, `Descripcion`, `Estado`, `Insert_Oper`, `Insert_Datetime`, `Update_Oper`, `Update_Datetime`) VALUES
	(1, 'REACTOR 23', 'REACTOR 23hj', b'1', 'insert', '0000-00-00 00:00:00.000000', 'update', '2018-04-15 01:28:27.000000'),
	(2, 'CUARTO SD (1,2,4)', 'CUARTO SD (1,2,4)', b'1', 'insert', '0000-00-00 00:00:00.000000', 'update', '2018-09-07 10:42:14.000000'),
	(3, 'TSET', 'TEST', b'1', '', '2018-12-08 15:08:03.918443', 'Update', '2018-12-08 15:47:25.300928');
/*!40000 ALTER TABLE `equipoprincipal` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.equiposecundario
CREATE TABLE IF NOT EXISTS `equiposecundario` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` longtext,
  `Descripcion` longtext,
  `Estado` bit(1) NOT NULL,
  `Insert_Oper` longtext,
  `Insert_Datetime` datetime(6) NOT NULL,
  `Update_Oper` longtext,
  `Update_Datetime` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.equiposecundario: ~7 rows (aproximadamente)
DELETE FROM `equiposecundario`;
/*!40000 ALTER TABLE `equiposecundario` DISABLE KEYS */;
INSERT INTO `equiposecundario` (`Id`, `Nombre`, `Descripcion`, `Estado`, `Insert_Oper`, `Insert_Datetime`, `Update_Oper`, `Update_Datetime`) VALUES
	(1, 'Bomba de Alimentacion', 'Bomba de Alimentacion', b'0', 'insert', '2018-02-22 18:09:28.000000', '', '2018-02-22 18:09:30.000000'),
	(2, 'Colector', 'Colector', b'0', 'insert', '2018-02-22 18:09:29.000000', '', '2018-02-22 18:09:29.000000'),
	(3, 'Blower de susccion', 'Blower de susccion', b'0', 'insert', '0000-00-00 00:00:00.000000', '', '0000-00-00 00:00:00.000000'),
	(7, 'Otro componente', 'Otro componente', b'1', 'insert', '2018-04-15 02:49:23.000000', 'update', '2018-04-15 02:49:33.000000'),
	(8, 'Nuevo s 1', '', b'1', 'insert', '2018-06-13 05:33:54.000000', '', '0000-00-00 00:00:00.000000'),
	(9, 'Nuevo s 2', '', b'1', 'insert', '2018-06-13 05:34:01.000000', '', '0000-00-00 00:00:00.000000'),
	(10, 'Nuevo s3', '', b'1', 'insert', '2018-06-13 05:34:09.000000', '', '0000-00-00 00:00:00.000000');
/*!40000 ALTER TABLE `equiposecundario` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.estadoservicio
CREATE TABLE IF NOT EXISTS `estadoservicio` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` longtext,
  `FechaInsercion` datetime(6) DEFAULT NULL,
  `FechaModificacion` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.estadoservicio: ~3 rows (aproximadamente)
DELETE FROM `estadoservicio`;
/*!40000 ALTER TABLE `estadoservicio` DISABLE KEYS */;
INSERT INTO `estadoservicio` (`Id`, `Nombre`, `FechaInsercion`, `FechaModificacion`) VALUES
	(1, 'En Proceso', '2018-11-24 13:12:48.619641', '2018-11-24 13:12:48.619748'),
	(2, 'Programado', '2018-11-24 13:12:54.136516', '2018-11-24 13:12:54.136518'),
	(3, 'Terminado', '2018-11-24 13:13:05.674368', '2018-11-24 13:13:05.674370');
/*!40000 ALTER TABLE `estadoservicio` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.historialpassword
CREATE TABLE IF NOT EXISTS `historialpassword` (
  `Id_Historial_Password` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Usuario` int(11) NOT NULL,
  `Password` longtext,
  `InsertDatetime` datetime(6) NOT NULL,
  PRIMARY KEY (`Id_Historial_Password`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.historialpassword: ~0 rows (aproximadamente)
DELETE FROM `historialpassword`;
/*!40000 ALTER TABLE `historialpassword` DISABLE KEYS */;
/*!40000 ALTER TABLE `historialpassword` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.operador
CREATE TABLE IF NOT EXISTS `operador` (
  `IdOperador` int(11) NOT NULL AUTO_INCREMENT,
  `OperadorId` longtext,
  `ApeYNom` longtext,
  `SectorId` longtext,
  `EMail` longtext,
  `Contrasenia` longtext,
  `Privado` int(11) NOT NULL,
  `Nivel` tinyint(4) NOT NULL,
  `ExpiraClave` datetime(6) NOT NULL,
  `AvisarAsignado` int(11) NOT NULL,
  `AvisarSolicitud` int(11) NOT NULL,
  `InsertOper` longtext,
  `InsertDatetime` datetime(6) NOT NULL,
  `UpdateOper` longtext,
  `UpdateDatetime` datetime(6) NOT NULL,
  PRIMARY KEY (`IdOperador`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.operador: ~0 rows (aproximadamente)
DELETE FROM `operador`;
/*!40000 ALTER TABLE `operador` DISABLE KEYS */;
/*!40000 ALTER TABLE `operador` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.parametros
CREATE TABLE IF NOT EXISTS `parametros` (
  `ParametrosId` int(11) NOT NULL AUTO_INCREMENT,
  `ValidezPsw` smallint(5) unsigned NOT NULL,
  `DiasPsw` smallint(5) unsigned NOT NULL,
  `MaxLinesScreen` smallint(5) unsigned NOT NULL,
  `MaxLinesExport` int(10) unsigned NOT NULL,
  `MaxDifMin` smallint(5) unsigned NOT NULL,
  `MaxAttach` int(10) unsigned NOT NULL,
  `AssignTicket` int(11) NOT NULL,
  `FromUserRequest` longtext,
  `SubcarpetaAdjuntoTicket` longtext,
  `SubcarpetaAdjuntoFichaTec` longtext,
  `FromUserPsw` longtext,
  `ContactDefault` longtext,
  `ProcessDefault` longtext,
  `StateDefault` longtext,
  `StateAlert` longtext,
  `MainScreenState` longtext,
  `DateFormat` longtext,
  `Pen` longtext,
  `Pas` longtext,
  `Can` longtext,
  `InsertOper` longtext,
  `InsertDatetime` datetime(6) NOT NULL,
  `UpdateOper` longtext,
  `UpdateDatetime` datetime(6) NOT NULL,
  PRIMARY KEY (`ParametrosId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.parametros: ~1 rows (aproximadamente)
DELETE FROM `parametros`;
/*!40000 ALTER TABLE `parametros` DISABLE KEYS */;
INSERT INTO `parametros` (`ParametrosId`, `ValidezPsw`, `DiasPsw`, `MaxLinesScreen`, `MaxLinesExport`, `MaxDifMin`, `MaxAttach`, `AssignTicket`, `FromUserRequest`, `SubcarpetaAdjuntoTicket`, `SubcarpetaAdjuntoFichaTec`, `FromUserPsw`, `ContactDefault`, `ProcessDefault`, `StateDefault`, `StateAlert`, `MainScreenState`, `DateFormat`, `Pen`, `Pas`, `Can`, `InsertOper`, `InsertDatetime`, `UpdateOper`, `UpdateDatetime`) VALUES
	(1, 60, 90, 40, 60000, 2000, 120000, 1, 'mantenimiento@realsa.co', 'tickets', 'fichas_tecnicas', 'no-reply@realsa.co', 'Interno', 'Mto Correctivo', '', '', '', 'DMA', 'Programado', 'En Proceso', 'Terminado', 'SETUP', '2014-12-09 10:56:44.000000', 'jmto', '2018-09-03 22:13:21.000000');
/*!40000 ALTER TABLE `parametros` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.planta
CREATE TABLE IF NOT EXISTS `planta` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` longtext,
  `Descripcion` longtext,
  `Estado` bit(1) NOT NULL,
  `Insert_Oper` longtext,
  `Insert_Datetime` datetime(6) NOT NULL,
  `Update_Oper` longtext,
  `Update_Datetime` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.planta: ~3 rows (aproximadamente)
DELETE FROM `planta`;
/*!40000 ALTER TABLE `planta` DISABLE KEYS */;
INSERT INTO `planta` (`Id`, `Nombre`, `Descripcion`, `Estado`, `Insert_Oper`, `Insert_Datetime`, `Update_Oper`, `Update_Datetime`) VALUES
	(1, 'PLANTA DE SALES', 'PLANTA DE SALES', b'1', 'insert', '0001-01-01 00:00:00.000000', '', '0001-01-01 00:00:00.000000'),
	(2, 'PLANTA 4', 'PLANTA 4', b'1', 'insert', '2018-02-21 21:27:29.000000', '', '2018-02-21 21:27:31.000000'),
	(3, 'Nueva Planta', '', b'1', 'insert', '2018-06-13 05:35:18.000000', '', '0000-00-00 00:00:00.000000');
/*!40000 ALTER TABLE `planta` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.prioridad
CREATE TABLE IF NOT EXISTS `prioridad` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre_Prioridad` longtext,
  `Fecha_Insercion` datetime(6) DEFAULT NULL,
  `Fecha_Modificacion` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.prioridad: ~3 rows (aproximadamente)
DELETE FROM `prioridad`;
/*!40000 ALTER TABLE `prioridad` DISABLE KEYS */;
INSERT INTO `prioridad` (`Id`, `Nombre_Prioridad`, `Fecha_Insercion`, `Fecha_Modificacion`) VALUES
	(1, '1-Necesario', '2018-11-24 12:14:04.626403', '2018-11-24 12:14:04.643700'),
	(2, '2-Importante', '2018-11-24 12:14:56.406739', '2018-11-24 12:14:56.406741'),
	(3, '3-Urgente', '2018-11-24 12:15:03.569741', '2018-11-24 12:15:03.569743');
/*!40000 ALTER TABLE `prioridad` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.procesos
CREATE TABLE IF NOT EXISTS `procesos` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre_Proceso` longtext,
  `Fecha_Insercion` datetime(6) DEFAULT NULL,
  `Fecha_Modificacion` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.procesos: ~4 rows (aproximadamente)
DELETE FROM `procesos`;
/*!40000 ALTER TABLE `procesos` DISABLE KEYS */;
INSERT INTO `procesos` (`Id`, `Nombre_Proceso`, `Fecha_Insercion`, `Fecha_Modificacion`) VALUES
	(1, 'Mejoras', '2018-11-24 12:20:36.810395', '2018-11-24 12:20:36.810549'),
	(2, 'Mto_Preventivo', '2018-11-24 12:20:44.543252', '2018-11-24 12:20:44.543254'),
	(3, 'Mto_Correctivo', '2018-11-24 12:20:51.292304', '2018-11-24 12:20:51.292306'),
	(4, 'Mto_Predictivo', '2018-11-24 12:20:57.225200', '2018-11-24 12:20:57.225201');
/*!40000 ALTER TABLE `procesos` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.registroequipo
CREATE TABLE IF NOT EXISTS `registroequipo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `IdPlanta` int(11) NOT NULL,
  `NombrePlanta` longtext,
  `IdEquipoPrinc` int(11) NOT NULL,
  `NombreEquipoPrinc` longtext,
  `IdEquipoSec` int(11) DEFAULT NULL,
  `NombreEquipoSec` longtext,
  `IdComponente` int(11) DEFAULT NULL,
  `NombreComponente` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.registroequipo: ~7 rows (aproximadamente)
DELETE FROM `registroequipo`;
/*!40000 ALTER TABLE `registroequipo` DISABLE KEYS */;
INSERT INTO `registroequipo` (`Id`, `IdPlanta`, `NombrePlanta`, `IdEquipoPrinc`, `NombreEquipoPrinc`, `IdEquipoSec`, `NombreEquipoSec`, `IdComponente`, `NombreComponente`) VALUES
	(1, 2, 'PLANTA DE SALES', 1, ' REACTOR 23 ', 1, ' Bomba de Alimentacion ', 2, ' Bomba Catpumps '),
	(2, 2, 'PLANTA DE SALES', 1, ' REACTOR 23 ', 2, ' Colector ', 3, ' Colector de polvo '),
	(3, 2, 'PLANTA DE SALES', 1, ' REACTOR 23 ', 1, ' Bomba de Alimentacion ', 6, ' Nuevo c1 '),
	(4, 2, 'PLANTA DE SALES', 1, ' REACTOR 23 ', 1, ' Bomba de Alimentacion ', 7, ' Nuevo c2 '),
	(5, 2, 'PLANTA DE SALES', 2, ' CUARTO SD (1,2,4) ', 1, ' Bomba de Alimentacion ', 2, ' Bomba Catpumps '),
	(6, 2, 'PLANTA DE SALES', 2, ' CUARTO SD (1,2,4) ', 2, ' Colector ', 3, ' Colector de polvo '),
	(7, 2, 'PLANTA DE SALES', 2, ' CUARTO SD (1,2,4) ', 2, ' Colector ', 8, ' Nuevo c3 ');
/*!40000 ALTER TABLE `registroequipo` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.sigoticket
CREATE TABLE IF NOT EXISTS `sigoticket` (
  `SeqSigoTicketId` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `SeqTicketId` bigint(20) NOT NULL,
  `Fecha` datetime(6) NOT NULL,
  `OperadorId` longtext,
  `UsuarioId` longtext,
  `NotasTrabajo` longtext,
  `CampoCambiado` longtext,
  `ValorAnterior` longtext,
  `ValorActual` longtext,
  `Comentario` longtext,
  `Visible` int(11) NOT NULL,
  `Adjunto` longblob,
  `TipoAdjunto` longtext,
  `NombreAdjunto` longtext,
  `CambioNumero` int(11) NOT NULL,
  `InsertOper` longtext,
  `InsertUser` longtext,
  `InsertDatetime` datetime(6) NOT NULL,
  PRIMARY KEY (`SeqSigoTicketId`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.sigoticket: ~9 rows (aproximadamente)
DELETE FROM `sigoticket`;
/*!40000 ALTER TABLE `sigoticket` DISABLE KEYS */;
INSERT INTO `sigoticket` (`SeqSigoTicketId`, `SeqTicketId`, `Fecha`, `OperadorId`, `UsuarioId`, `NotasTrabajo`, `CampoCambiado`, `ValorAnterior`, `ValorActual`, `Comentario`, `Visible`, `Adjunto`, `TipoAdjunto`, `NombreAdjunto`, `CambioNumero`, `InsertOper`, `InsertUser`, `InsertDatetime`) VALUES
	(1, 1, '2018-12-21 16:42:00.032930', '02f3eca4-a127-4733-b4de-c7a99c93e42d', 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Se escala servicio al compañero Juan Carlos Barragan, para su atención.', 'NotasTrabajo', NULL, NULL, NULL, 0, NULL, NULL, NULL, 1, NULL, NULL, '2018-12-21 16:42:00.033812'),
	(2, 1, '2018-12-21 16:42:00.285088', '02f3eca4-a127-4733-b4de-c7a99c93e42d', 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', NULL, 'Asignado_A', 'Marlon Torres', 'Juan Carlos Barragan Echeverria', NULL, 0, NULL, NULL, NULL, 2, NULL, NULL, '2018-12-21 16:42:00.327567'),
	(3, 1, '2018-12-21 16:55:28.126361', '02f3eca4-a127-4733-b4de-c7a99c93e42d', 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Modificación de todos los campos en el formulario', 'NotasTrabajo', NULL, NULL, NULL, 0, NULL, NULL, NULL, 2, NULL, NULL, '2018-12-21 16:55:28.126363'),
	(4, 1, '2018-12-21 16:55:28.144876', '02f3eca4-a127-4733-b4de-c7a99c93e42d', 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', NULL, 'Prioridad', '1-Necesario', '2-Importante', NULL, 0, NULL, NULL, NULL, 2, NULL, NULL, '2018-12-21 16:55:28.176821'),
	(5, 1, '2018-12-21 16:55:28.184999', '02f3eca4-a127-4733-b4de-c7a99c93e42d', 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', NULL, 'Proceso', 'Mto_Correctivo', 'Mto_Preventivo', NULL, 0, NULL, NULL, NULL, 2, NULL, NULL, '2018-12-21 16:55:28.211121'),
	(6, 1, '2018-12-21 16:55:28.217708', '02f3eca4-a127-4733-b4de-c7a99c93e42d', 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', NULL, 'EquipoPrincipal', 'REACTOR 23', 'CUARTO SD (1,2,4)', NULL, 0, NULL, NULL, NULL, 2, NULL, NULL, '2018-12-21 16:55:28.242845'),
	(7, 1, '2018-12-21 16:55:28.251421', '02f3eca4-a127-4733-b4de-c7a99c93e42d', 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', NULL, 'EquipoSecundario', 'Blower de susccion', 'Colector', NULL, 0, NULL, NULL, NULL, 2, NULL, NULL, '2018-12-21 16:55:28.280845'),
	(8, 1, '2018-12-21 16:55:28.288970', '02f3eca4-a127-4733-b4de-c7a99c93e42d', 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', NULL, 'Componente', 'Blower', 'Nuevo c1', NULL, 0, NULL, NULL, NULL, 2, NULL, NULL, '2018-12-21 16:55:28.323579'),
	(9, 1, '2018-12-21 16:55:28.331315', '02f3eca4-a127-4733-b4de-c7a99c93e42d', 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', NULL, 'Fecha_Entrega', '10/12/2018 01:00:00 PM', '24/12/2018 01:00:00 PM', NULL, 0, NULL, NULL, NULL, 2, NULL, NULL, '2018-12-21 16:55:28.331328');
/*!40000 ALTER TABLE `sigoticket` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.ticket
CREATE TABLE IF NOT EXISTS `ticket` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Numero_Ticket` varchar(50) NOT NULL,
  `Fecha` datetime(6) NOT NULL,
  `Privado` int(11) NOT NULL,
  `Operador_Id` varchar(255) NOT NULL COMMENT 'Usuario Afectado',
  `Operador_Sector_Id` varchar(255) DEFAULT NULL,
  `Usuario_Id` varchar(255) NOT NULL COMMENT 'Creado por',
  `Nombre_completo` varchar(255) DEFAULT NULL,
  `Area_Id` int(11) DEFAULT NULL COMMENT 'Area a la que pertenece el Usuario Afectado',
  `Ubicacion` varchar(255) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `EMail` varchar(255) DEFAULT NULL,
  `Asignado_A_Sector` varchar(50) DEFAULT NULL,
  `Asignado_A` varchar(255) NOT NULL,
  `Prioridad` int(11) NOT NULL,
  `Incidente` longtext NOT NULL,
  `Comentarios` longtext NOT NULL,
  `Proceso` int(11) NOT NULL,
  `Tipo_Trabajo` int(11) NOT NULL,
  `Id_Planta` int(11) NOT NULL,
  `Id_EquipoPrinc` int(11) NOT NULL,
  `Id_EquipoSec` int(11) DEFAULT NULL,
  `Id_Componente` int(11) DEFAULT NULL,
  `Estado` int(11) NOT NULL,
  `Calificacion` varchar(50) DEFAULT NULL,
  `Fecha_Ultimo_Estado` datetime(6) NOT NULL,
  `Fecha_Entrega` datetime(6) NOT NULL,
  `Operador_Ultimo_Estado` varchar(50) DEFAULT NULL,
  `Adjunto` longblob,
  `Tipo_Adjunto` longtext,
  `Ruta_Adjunto` longtext,
  `Nombre_Adjunto` longtext,
  `Insert_Oper` varchar(50) DEFAULT NULL,
  `Insert_Datetime` datetime NOT NULL,
  `Update_Oper` varchar(50) DEFAULT NULL,
  `Update_Datetime` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.ticket: ~17 rows (aproximadamente)
DELETE FROM `ticket`;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket` (`Id`, `Numero_Ticket`, `Fecha`, `Privado`, `Operador_Id`, `Operador_Sector_Id`, `Usuario_Id`, `Nombre_completo`, `Area_Id`, `Ubicacion`, `Telefono`, `EMail`, `Asignado_A_Sector`, `Asignado_A`, `Prioridad`, `Incidente`, `Comentarios`, `Proceso`, `Tipo_Trabajo`, `Id_Planta`, `Id_EquipoPrinc`, `Id_EquipoSec`, `Id_Componente`, `Estado`, `Calificacion`, `Fecha_Ultimo_Estado`, `Fecha_Entrega`, `Operador_Ultimo_Estado`, `Adjunto`, `Tipo_Adjunto`, `Ruta_Adjunto`, `Nombre_Adjunto`, `Insert_Oper`, `Insert_Datetime`, `Update_Oper`, `Update_Datetime`) VALUES
	(1, 'REQ2018001', '2018-12-22 13:34:35.634932', 0, '02f3eca4-a127-4733-b4de-c7a99c93e42d', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Ruth Castro', 2, 'P Cartagena', NULL, 'rcastrov@gmail.com', NULL, '7e87bfc1-b0cf-48fd-b198-c12b6801cc66', 2, 'Test', 'Test', 2, 2, 2, 2, 2, 6, 1, NULL, '2018-12-22 13:34:35.634935', '2018-12-24 13:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-22 13:34:35', NULL, '2018-12-22 13:34:35'),
	(2, 'REQ2018002', '2018-12-21 10:05:54.878497', 0, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Marlon Torres', 1, 'Mantenimiento', NULL, 'jmto@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 2, 'Tet', 'TEs', 2, 2, 2, 2, 9, 4, 1, NULL, '2018-12-21 10:05:54.881269', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-21 10:05:54', NULL, '2018-12-21 10:05:54'),
	(3, 'REQ2018003', '2018-12-21 10:08:41.904825', 0, '02f3eca4-a127-4733-b4de-c7a99c93e42d', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Ruth Castro', 2, 'P Cartagena', NULL, 'rcastrov@gmail.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'vbcv', 'bvcbvcb', 1, 2, 2, 2, 7, 2, 2, NULL, '2018-12-21 10:08:41.904831', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-21 10:08:41', NULL, '2018-12-21 10:08:41'),
	(4, 'REQ2018004', '2018-12-07 19:19:03.503234', 0, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Marlon Torres', 1, 'Mantenimiento', NULL, 'jmto@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'hfghfhfghfg', 'fghfgh', 2, 1, 2, 1, 7, 4, 1, NULL, '0001-01-01 00:00:00.000000', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-07 19:19:03', NULL, '2018-12-07 19:19:03'),
	(5, 'REQ2018005', '2018-12-07 19:29:09.535972', 0, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Marlon Torres', 1, 'Mantenimiento', NULL, 'jmto@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'sdfsdf', 'sdfsdfsdf', 1, 2, 1, 1, 8, 7, 2, NULL, '0001-01-01 00:00:00.000000', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-07 19:29:09', NULL, '2018-12-07 19:29:09'),
	(6, 'REQ2018006', '2018-12-07 19:36:13.773095', 0, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Marlon Torres', 1, 'Mantenimiento', NULL, 'jmto@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'xcc', 'xcxcx', 1, 2, 2, 1, 8, 6, 1, NULL, '0001-01-01 00:00:00.000000', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-07 19:36:13', NULL, '2018-12-07 19:36:13'),
	(7, 'REQ2018007', '2018-12-07 19:46:14.181091', 0, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Marlon Torres', 1, 'Mantenimiento', NULL, 'jmto@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'Tes', 'Tes', 1, 2, 1, 1, 2, 1, 1, NULL, '0001-01-01 00:00:00.000000', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-07 19:46:14', NULL, '2018-12-07 19:46:14'),
	(8, 'REQ2018008', '2018-12-07 19:48:40.161124', 0, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Marlon Torres', 1, 'Mantenimiento', NULL, 'jmto@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'TEst', 'TEst', 1, 1, 1, 1, 8, 3, 1, NULL, '0001-01-01 00:00:00.000000', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-07 19:48:40', NULL, '2018-12-07 19:48:40'),
	(9, 'REQ2018009', '2018-12-07 19:56:23.099562', 0, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Marlon Torres', 1, 'Mantenimiento', NULL, 'jmto@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'Test', 'Test', 1, 1, 1, 1, 7, 4, 1, NULL, '0001-01-01 00:00:00.000000', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-07 19:56:23', NULL, '2018-12-07 19:56:23'),
	(10, 'REQ20180010', '2018-12-07 20:14:49.151644', 0, '7e87bfc1-b0cf-48fd-b198-c12b6801cc66', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Juan Carlos Barragan Echeverria', 1, 'Mantenimiento', NULL, 'jbarragan@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'Prueba', 'Prueba', 1, 1, 1, 1, 3, 6, 1, NULL, '0001-01-01 00:00:00.000000', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-07 20:14:49', NULL, '2018-12-07 20:14:49'),
	(11, 'REQ20180011', '2018-12-07 20:15:20.677323', 0, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Anibal Luna', 2, 'ADMINISTRACION', NULL, 'aluna@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'Test', 'Test', 1, 2, 1, 2, 9, 6, 1, NULL, '0001-01-01 00:00:00.000000', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-07 20:15:20', NULL, '2018-12-07 20:15:20'),
	(12, 'REQ20180012', '2018-12-07 20:50:05.992244', 0, '7e87bfc1-b0cf-48fd-b198-c12b6801cc66', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Juan Carlos Barragan Echeverria', 1, 'Mantenimiento', NULL, 'jbarragan@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'Test', 'Test', 1, 1, 2, 1, 7, 6, 1, NULL, '0001-01-01 00:00:00.000000', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-07 20:50:05', NULL, '2018-12-07 20:50:05'),
	(13, 'REQ20180013', '2018-12-08 10:09:18.674417', 0, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Anibal Luna', 2, 'ADMINISTRACION', NULL, 'aluna@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'Test', 'Test', 1, 2, 3, 1, 7, 7, 2, NULL, '2018-12-08 10:09:18.674421', '2018-12-07 00:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-08 10:09:18', NULL, '2018-12-08 10:09:18'),
	(14, 'REQ20180014', '2018-12-08 15:05:16.807419', 0, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Marlon Torres', 1, 'Mantenimiento', NULL, 'jmto@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'TEst', 'Test', 1, 1, 1, 1, 7, 6, 1, NULL, '2018-12-08 15:05:16.811178', '2018-12-08 14:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-08 15:05:16', NULL, '2018-12-08 15:05:16'),
	(15, 'REQ20180015', '2018-12-21 10:27:02.672826', 0, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Marlon Torres', 1, 'Mantenimiento', NULL, 'jmto@realsa.com', NULL, '7e87bfc1-b0cf-48fd-b198-c12b6801cc66', 1, 'fgfdgfdg', 'dfgfdgfdg', 3, 2, 1, 1, 3, 7, 1, NULL, '2018-12-21 10:27:02.672829', '2018-12-08 10:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-21 10:27:02', NULL, '2018-12-21 10:27:02'),
	(16, 'REQ20180016', '2018-12-21 09:35:13.500523', 0, '7e87bfc1-b0cf-48fd-b198-c12b6801cc66', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Juan Carlos Barragan Echeverria', 1, 'Mantenimiento', NULL, 'jbarragan@realsa.com', NULL, '429cf5fd-a345-4af9-bdba-4c5c20539d9f', 1, 'Test file', 'Test File', 2, 3, 2, 2, 8, 6, 1, NULL, '2018-12-21 09:35:13.500529', '2018-12-24 03:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-21 09:35:13', NULL, '2018-12-21 09:35:13'),
	(17, 'REQ20180017', '2018-12-21 07:41:47.051657', 0, '7e87bfc1-b0cf-48fd-b198-c12b6801cc66', NULL, 'ebd1ee24-4f60-4203-ba84-c745957e3a3e', 'Juan Carlos Barragan Echeverria', 1, 'Mantenimiento', NULL, 'jbarragan@realsa.com', NULL, '7e87bfc1-b0cf-48fd-b198-c12b6801cc66', 3, 'Prueba File', 'Prueba File', 2, 3, 1, 2, 8, 4, 1, NULL, '2018-12-21 07:41:47.083136', '2018-12-21 17:00:00.000000', NULL, NULL, NULL, NULL, NULL, NULL, '2018-12-21 07:41:47', NULL, '2018-12-21 07:41:47');
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.tipotrabajo
CREATE TABLE IF NOT EXISTS `tipotrabajo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(250) NOT NULL,
  `Estado` bit(1) NOT NULL,
  `Fecha_Insercion` datetime(6) NOT NULL,
  `Fecha_Modificacion` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.tipotrabajo: ~6 rows (aproximadamente)
DELETE FROM `tipotrabajo`;
/*!40000 ALTER TABLE `tipotrabajo` DISABLE KEYS */;
INSERT INTO `tipotrabajo` (`Id`, `Nombre`, `Estado`, `Fecha_Insercion`, `Fecha_Modificacion`) VALUES
	(1, 'Mecanico', b'1', '2018-11-24 12:05:44.039575', '2018-11-24 12:05:44.039680'),
	(2, 'Electromecanico', b'1', '2018-11-24 12:05:51.406392', '2018-11-24 12:05:51.406394'),
	(3, 'Plomeria', b'1', '2018-11-24 12:05:58.017968', '2018-11-24 12:05:58.017969'),
	(4, 'Obra Civil', b'1', '2018-11-24 12:06:08.922510', '2018-11-24 12:06:08.922512'),
	(5, 'Metalmecanico', b'1', '2018-11-24 12:06:15.539980', '2018-11-24 12:06:15.539982'),
	(6, 'Soldadura', b'1', '2018-11-24 12:06:24.585238', '2018-11-24 12:06:24.585239');
/*!40000 ALTER TABLE `tipotrabajo` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `IdUsuario` bigint(20) NOT NULL AUTO_INCREMENT,
  `NombreCompleto` longtext,
  `EMail` longtext,
  `Ubicacion` longtext,
  `Telefono` longtext,
  `AreaId` int(11) NOT NULL,
  `Activo` int(11) NOT NULL,
  `Username` longtext,
  `Password` longtext,
  `CambioClave` int(11) NOT NULL,
  `FechaRegistro` datetime(6) NOT NULL,
  `FechaModificacion` datetime(6) NOT NULL,
  PRIMARY KEY (`IdUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.usuarios: ~0 rows (aproximadamente)
DELETE FROM `usuarios`;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- Volcando estructura para tabla webticket.__efmigrationshistory
CREATE TABLE IF NOT EXISTS `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla webticket.__efmigrationshistory: ~3 rows (aproximadamente)
DELETE FROM `__efmigrationshistory`;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
	('20181124165054_InitialMigration', '2.1.4-rtm-31024'),
	('20181124174218_AddCalificacionServicio', '2.1.4-rtm-31024'),
	('20181124174918_AddCalificacionServicio', '2.1.4-rtm-31024');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `Area` (
    `IdArea` int NOT NULL AUTO_INCREMENT,
    `Nombre` longtext NULL,
    `Activo` int NOT NULL,
    `InsertOper` longtext NULL,
    `InsertDatetime` datetime(6) NOT NULL,
    `UpdateOper` longtext NULL,
    `UpdateDatetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_Area` PRIMARY KEY (`IdArea`)
);

CREATE TABLE `AspNetRoles` (
    `Id` varchar(255) NOT NULL,
    `Name` varchar(256) NULL,
    `NormalizedName` varchar(256) NULL,
    `ConcurrencyStamp` longtext NULL,
    `Discriminator` longtext NOT NULL,
    `Enabled` bit NULL,
    CONSTRAINT `PK_AspNetRoles` PRIMARY KEY (`Id`)
);

CREATE TABLE `AspNetUsers` (
    `Id` varchar(255) NOT NULL,
    `UserName` varchar(256) NULL,
    `NormalizedUserName` varchar(256) NULL,
    `Email` varchar(256) NULL,
    `NormalizedEmail` varchar(256) NULL,
    `EmailConfirmed` bit NOT NULL,
    `PasswordHash` longtext NULL,
    `SecurityStamp` longtext NULL,
    `ConcurrencyStamp` longtext NULL,
    `PhoneNumber` longtext NULL,
    `PhoneNumberConfirmed` bit NOT NULL,
    `TwoFactorEnabled` bit NOT NULL,
    `LockoutEnd` datetime(6) NULL,
    `LockoutEnabled` bit NOT NULL,
    `AccessFailedCount` int NOT NULL,
    `Discriminator` longtext NOT NULL,
    `FullName` longtext NULL,
    `Area` longtext NULL,
    `Ubicacion` longtext NULL,
    `Telefono` longtext NULL,
    CONSTRAINT `PK_AspNetUsers` PRIMARY KEY (`Id`)
);

CREATE TABLE `Componentes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nombre` longtext NULL,
    `Descripcion` longtext NULL,
    `Estado` bit NOT NULL,
    `Insert_Oper` longtext NULL,
    `Insert_Datetime` datetime(6) NOT NULL,
    `Update_Oper` longtext NULL,
    `Update_Datetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_Componentes` PRIMARY KEY (`Id`)
);

CREATE TABLE `EMailError` (
    `IdEmailError` bigint NOT NULL AUTO_INCREMENT,
    `FromName` longtext NULL,
    `FromEMail` longtext NULL,
    `ToName` longtext NULL,
    `ToEMail` longtext NULL,
    `Subject` longtext NULL,
    `Body` longtext NULL,
    `ErrorMessage` longtext NULL,
    `FechaInsercion` datetime(6) NOT NULL,
    `FechaModificacion` datetime(6) NOT NULL,
    CONSTRAINT `PK_EMailError` PRIMARY KEY (`IdEmailError`)
);

CREATE TABLE `EquipoPrincipal` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nombre` longtext NULL,
    `Descripcion` longtext NULL,
    `Estado` bit NOT NULL,
    `Insert_Oper` longtext NULL,
    `Insert_Datetime` datetime(6) NOT NULL,
    `Update_Oper` longtext NULL,
    `Update_Datetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_EquipoPrincipal` PRIMARY KEY (`Id`)
);

CREATE TABLE `EquipoSecundario` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nombre` longtext NULL,
    `Descripcion` longtext NULL,
    `Estado` bit NOT NULL,
    `Insert_Oper` longtext NULL,
    `Insert_Datetime` datetime(6) NOT NULL,
    `Update_Oper` longtext NULL,
    `Update_Datetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_EquipoSecundario` PRIMARY KEY (`Id`)
);

CREATE TABLE `EstadoServicio` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nombre` longtext NULL,
    `FechaInsercion` datetime(6) NULL,
    `FechaModificacion` datetime(6) NULL,
    CONSTRAINT `PK_EstadoServicio` PRIMARY KEY (`Id`)
);

CREATE TABLE `HistorialPassword` (
    `Id_Historial_Password` int NOT NULL AUTO_INCREMENT,
    `Id_Usuario` int NOT NULL,
    `Password` longtext NULL,
    `InsertDatetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_HistorialPassword` PRIMARY KEY (`Id_Historial_Password`)
);

CREATE TABLE `Operador` (
    `IdOperador` int NOT NULL AUTO_INCREMENT,
    `OperadorId` longtext NULL,
    `ApeYNom` longtext NULL,
    `SectorId` longtext NULL,
    `EMail` longtext NULL,
    `Contrasenia` longtext NULL,
    `Privado` int NOT NULL,
    `Nivel` tinyint NOT NULL,
    `ExpiraClave` datetime(6) NOT NULL,
    `AvisarAsignado` int NOT NULL,
    `AvisarSolicitud` int NOT NULL,
    `InsertOper` longtext NULL,
    `InsertDatetime` datetime(6) NOT NULL,
    `UpdateOper` longtext NULL,
    `UpdateDatetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_Operador` PRIMARY KEY (`IdOperador`)
);

CREATE TABLE `Parametros` (
    `ParametrosId` int NOT NULL AUTO_INCREMENT,
    `ValidezPsw` smallint unsigned NOT NULL,
    `DiasPsw` smallint unsigned NOT NULL,
    `MaxLinesScreen` smallint unsigned NOT NULL,
    `MaxLinesExport` int unsigned NOT NULL,
    `MaxDifMin` smallint unsigned NOT NULL,
    `MaxAttach` int unsigned NOT NULL,
    `AssignTicket` int NOT NULL,
    `FromUserRequest` longtext NULL,
    `SubcarpetaAdjuntoTicket` longtext NULL,
    `SubcarpetaAdjuntoFichaTec` longtext NULL,
    `FromUserPsw` longtext NULL,
    `ContactDefault` longtext NULL,
    `ProcessDefault` longtext NULL,
    `StateDefault` longtext NULL,
    `StateAlert` longtext NULL,
    `MainScreenState` longtext NULL,
    `DateFormat` longtext NULL,
    `Pen` longtext NULL,
    `Pas` longtext NULL,
    `Can` longtext NULL,
    `InsertOper` longtext NULL,
    `InsertDatetime` datetime(6) NOT NULL,
    `UpdateOper` longtext NULL,
    `UpdateDatetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_Parametros` PRIMARY KEY (`ParametrosId`)
);

CREATE TABLE `Planta` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nombre` longtext NULL,
    `Descripcion` longtext NULL,
    `Estado` bit NOT NULL,
    `Insert_Oper` longtext NULL,
    `Insert_Datetime` datetime(6) NOT NULL,
    `Update_Oper` longtext NULL,
    `Update_Datetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_Planta` PRIMARY KEY (`Id`)
);

CREATE TABLE `Prioridad` (
    `IdPrioridad` int NOT NULL AUTO_INCREMENT,
    `NombrePrioridad` longtext NULL,
    `FechaInsercion` datetime(6) NULL,
    `FechaModificacion` datetime(6) NULL,
    CONSTRAINT `PK_Prioridad` PRIMARY KEY (`IdPrioridad`)
);

CREATE TABLE `Procesos` (
    `IdProceso` int NOT NULL AUTO_INCREMENT,
    `NombreProceso` longtext NULL,
    `FechaInsercion` datetime(6) NULL,
    `FechaModificacion` datetime(6) NULL,
    CONSTRAINT `PK_Procesos` PRIMARY KEY (`IdProceso`)
);

CREATE TABLE `RegistroEquipo` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `IdPlanta` int NOT NULL,
    `NombrePlanta` longtext NULL,
    `IdEquipoPrinc` int NOT NULL,
    `NombreEquipoPrinc` longtext NULL,
    `IdEquipoSec` int NULL,
    `NombreEquipoSec` longtext NULL,
    `IdComponente` int NULL,
    `NombreComponente` longtext NULL,
    CONSTRAINT `PK_RegistroEquipo` PRIMARY KEY (`Id`)
);

CREATE TABLE `SigoTicket` (
    `SeqSigoTicketId` bigint unsigned NOT NULL AUTO_INCREMENT,
    `SeqTicketId` int unsigned NOT NULL,
    `Fecha` datetime(6) NOT NULL,
    `OperadorId` longtext NULL,
    `UsuarioId` longtext NULL,
    `CampoCambiado` longtext NULL,
    `ValorAnterior` longtext NULL,
    `ValorActual` longtext NULL,
    `Comentario` longtext NULL,
    `Visible` int NOT NULL,
    `Adjunto` longblob NULL,
    `TipoAdjunto` longtext NULL,
    `NombreAdjunto` longtext NULL,
    `InsertOper` longtext NULL,
    `InsertUser` longtext NULL,
    `InsertDatetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_SigoTicket` PRIMARY KEY (`SeqSigoTicketId`)
);

CREATE TABLE `Ticket` (
    `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
    `Numero_Ticket` longtext NULL,
    `Fecha` datetime(6) NOT NULL,
    `Privado` int NOT NULL,
    `Operador_Id` longtext NULL,
    `Operador_Sector_Id` longtext NULL,
    `Usuario_Id` longtext NULL,
    `Nombre_completo` longtext NULL,
    `Area_Id` longtext NULL,
    `Piso` longtext NULL,
    `Telefono` longtext NULL,
    `EMail` longtext NULL,
    `Asignado_A` longtext NULL,
    `Asignado_A_Sector` longtext NULL,
    `Prioridad` tinyint unsigned NOT NULL,
    `Incidente` longtext NULL,
    `Proceso` longtext NULL,
    `Tipo_Trabajo` longtext NULL,
    `Id_Planta` longtext NULL,
    `Id_EquipoPrinc` longtext NULL,
    `Id_EquipoSec` longtext NULL,
    `Id_Componente` longtext NULL,
    `Estado` longtext NULL,
    `Calificacion` longtext NULL,
    `Fecha_Ultimo_Estado` datetime(6) NOT NULL,
    `Fecha_Entrega` datetime(6) NULL,
    `Operador_Ultimo_Estado` longtext NULL,
    `Adjunto` longblob NULL,
    `Tipo_Adjunto` longtext NULL,
    `Ruta_Adjunto` longtext NULL,
    `Nombre_Adjunto` longtext NULL,
    `Insert_Oper` longtext NULL,
    `Insert_Datetime` datetime(6) NOT NULL,
    `Update_Oper` longtext NULL,
    `Update_Datetime` datetime(6) NOT NULL,
    CONSTRAINT `PK_Ticket` PRIMARY KEY (`Id`)
);

CREATE TABLE `TipoTrabajo` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nombre` longtext NULL,
    `FechaInsercion` datetime(6) NOT NULL,
    `FechaModificacion` datetime(6) NOT NULL,
    CONSTRAINT `PK_TipoTrabajo` PRIMARY KEY (`Id`)
);

CREATE TABLE `Usuarios` (
    `IdUsuario` bigint NOT NULL AUTO_INCREMENT,
    `NombreCompleto` longtext NULL,
    `EMail` longtext NULL,
    `Ubicacion` longtext NULL,
    `Telefono` longtext NULL,
    `AreaId` int NOT NULL,
    `Activo` int NOT NULL,
    `Username` longtext NULL,
    `Password` longtext NULL,
    `CambioClave` int NOT NULL,
    `FechaRegistro` datetime(6) NOT NULL,
    `FechaModificacion` datetime(6) NOT NULL,
    CONSTRAINT `PK_Usuarios` PRIMARY KEY (`IdUsuario`)
);

CREATE TABLE `AspNetRoleClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `RoleId` varchar(255) NOT NULL,
    `ClaimType` longtext NULL,
    `ClaimValue` longtext NULL,
    CONSTRAINT `PK_AspNetRoleClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserClaims` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `UserId` varchar(255) NOT NULL,
    `ClaimType` longtext NULL,
    `ClaimValue` longtext NULL,
    CONSTRAINT `PK_AspNetUserClaims` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserLogins` (
    `LoginProvider` varchar(255) NOT NULL,
    `ProviderKey` varchar(255) NOT NULL,
    `ProviderDisplayName` longtext NULL,
    `UserId` varchar(255) NOT NULL,
    CONSTRAINT `PK_AspNetUserLogins` PRIMARY KEY (`LoginProvider`, `ProviderKey`),
    CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserRoles` (
    `UserId` varchar(255) NOT NULL,
    `RoleId` varchar(255) NOT NULL,
    `Discriminator` longtext NOT NULL,
    CONSTRAINT `PK_AspNetUserRoles` PRIMARY KEY (`UserId`, `RoleId`),
    CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUserTokens` (
    `UserId` varchar(255) NOT NULL,
    `LoginProvider` varchar(255) NOT NULL,
    `Name` varchar(255) NOT NULL,
    `Value` longtext NULL,
    CONSTRAINT `PK_AspNetUserTokens` PRIMARY KEY (`UserId`, `LoginProvider`, `Name`),
    CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_AspNetRoleClaims_RoleId` ON `AspNetRoleClaims` (`RoleId`);

CREATE UNIQUE INDEX `RoleNameIndex` ON `AspNetRoles` (`NormalizedName`);

CREATE INDEX `IX_AspNetUserClaims_UserId` ON `AspNetUserClaims` (`UserId`);

CREATE INDEX `IX_AspNetUserLogins_UserId` ON `AspNetUserLogins` (`UserId`);

CREATE INDEX `IX_AspNetUserRoles_RoleId` ON `AspNetUserRoles` (`RoleId`);

CREATE INDEX `EmailIndex` ON `AspNetUsers` (`NormalizedEmail`);

CREATE UNIQUE INDEX `UserNameIndex` ON `AspNetUsers` (`NormalizedUserName`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20181123180851_InitialMigrated', '2.1.4-rtm-31024');


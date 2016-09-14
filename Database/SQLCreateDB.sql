/*********** BASE  LENGTHS ***********/
--RamTimings		CHAR(14)			<< FORMAT OF XX-XX-XX-XX-XT
--Brand				VARCHAR(10)			|--FirstName		VARCHAR(50)
--Model				VARCHAR(25)			|--LastName			VARCHAR(50)
--Socket			VARCHAR(25)			|--Address			VARCHAR(50)
--ProductLaneName	VARCHAR(25)			|--City				VARCHAR(50)
--BestUse			VARCHAR(50)			|--StateCode		CHAR(2)
--Price				DECIMAL(7,2)		|--Zip				VARCHAR(9)
--GpuLength			CHAR(1)				|--LocalPhone		VARCHAR(10)
--Chipset			VARCHAR(25)			|--Email			VARCHAR(100)
--FormFactor		VARCHAR(10)			|--Username			VARCHAR(50)
--Efficiency		VARCHAR(10)			|--Password			VARCHAR(50)
--StorageType		VARCHAR(5)			|--RoleName			VARCHAR(50)
--OpticalType		VARCHAR(15)			|--RoleDescription	VARCHAR(MAX)

/*************************************/
/*          CREATE DATABASE          */
/*************************************/
IF EXISTS(SELECT 1 FROM dbo.sysdatabases WHERE name = 'PCBuilder') 
BEGIN
DROP DATABASE PCBuilder;
END
GO

CREATE DATABASE PCBuilder
GO

USE PCBuilder
GO


USE master
IF EXISTS(SELECT * FROM sys.databases WHERE name='PCBuilder')
DROP DATABASE PCBuilder

CREATE DATABASE PCBuilder

USE PCBuilder
GO


/*************************************/
/*             CPU TABLE             */
/*************************************/
CREATE TABLE [dbo].[CPU](
	[CpuId]					INT IDENTITY(1000,1) 	NOT NULL,
	[Brand]					VARCHAR(10)		 		NOT NULL,
	[Model]					VARCHAR(25)				NOT NULL,
	[Cores]					INT						NOT NULL,
	[HyperThreaded]			BIT						NOT NULL,
	[ClockSpeed]			FLOAT					NOT NULL,
	[Unlocked]				BIT						NOT NULL,
	[Socket]				VARCHAR(25)				NOT NULL,
	[ProductLineName]		VARCHAR(25)				NOT NULL,
	[BenchmarkScore]		INT						NOT NULL,
	[BestUse]				VARCHAR(50)				NOT NULL,
	[PowerRequirement]		INT						NOT NULL,
	[Price]					DECIMAL(7,2)			NOT NULL,
	CONSTRAINT [PK_CpuId] PRIMARY KEY CLUSTERED ([CpuID] ASC)
) ON [PRIMARY]
GO

CREATE INDEX CpuID_Index
ON CPU ([CpuId])
GO


/*************************************/
/*             GPU TABLE             */
/*************************************/
CREATE TABLE [dbo].[GPU](
	[GpuId]					INT IDENTITY(1000,1) 	NOT NULL,
	[Brand]					VARCHAR(10)		 		NOT NULL,
	[Model]					VARCHAR(25)				NOT NULL,
	[ClockSpeed]			FLOAT					NOT NULL,
	[ProductLineName]		VARCHAR(25)				NOT NULL,
	[BenchmarkScore]		INT						NOT NULL,
	[BestUse]				VARCHAR(50)				NOT NULL,
	[GpuRamSize]			INT						NOT NULL,
	[PciPinConnector1]		INT						NOT NULL,
	[PciPinConnector2]		INT						NOT NULL,
	[PciPinConnector3]		INT						NOT NULL,
	[PowerRequirement]		INT						NOT NULL,
	[GpuLength]				CHAR(1)					NOT NULL,
	[Price]					DECIMAL(7,2)			NOT NULL,
	CONSTRAINT [PK_GpuId] PRIMARY KEY CLUSTERED ([GpuID] ASC)
) ON [PRIMARY]
GO

CREATE INDEX GpuID_Index
ON GPU ([GpuId])
GO


/*************************************/
/*         MOTHERBOARD TABLE         */
/*************************************/
CREATE TABLE [dbo].[Motherboards](
	[MotherboardId]			INT IDENTITY(1000,1) 	NOT NULL,
	[Brand]					VARCHAR(10)		 		NOT NULL,
	[Model]					VARCHAR(25)				NOT NULL,
	[Socket]				VARCHAR(25)				NOT NULL,
	[Chipset]				VARCHAR(25)				NOT NULL,
	[MaxRam]				INT						NOT NULL,
	[RamType]				INT						NOT NULL,
	[FormFactor]			VARCHAR(10)				NOT NULL,
	[SataPorts]				INT						NOT NULL,
	[M2Slots]				INT						NOT NULL,
	[PowerPhases]			INT						NOT NULL,
	[FanHeaders]			INT						NOT NULL,
	[Pcie16]				INT						NOT NULL,
	[Pcie8]					INT						NOT NULL,
	[Pcie4]					INT						NOT NULL,
	[Pcie1]					INT						NOT NULL,
	[Pci]					INT						NOT NULL,
	[Price]					DECIMAL(7,2)			NOT NULL,
	CONSTRAINT [PK_MotherboardId] PRIMARY KEY CLUSTERED ([MotherboardID] ASC)
) ON [PRIMARY]
GO

CREATE INDEX MotherboardID_Index
ON Motherboards ([MotherboardId])
GO


/*************************************/
/*             RAM TABLE             */
/*************************************/
CREATE TABLE [dbo].[RAM](
	[RamId]					INT IDENTITY(1000,1) 	NOT NULL,
	[Brand]					VARCHAR(10)		 		NOT NULL,
	[Model]					VARCHAR(25)				NOT NULL,
	[RamSize]				INT						NOT NULL,
	[RamGeneration]			INT						NOT NULL,
	[RamSpeed]				INT						NOT NULL,
	[RamTimings]			CHAR(15)				NOT NULL,
	[BestUse]				VARCHAR(50)				NOT NULL,
	[Price]					DECIMAL(7,2)			NOT NULL,
	CONSTRAINT [PK_RamId] PRIMARY KEY CLUSTERED ([RamID] ASC)
) ON [PRIMARY]
GO

CREATE INDEX RamID_Index
ON RAM ([RamId])
GO


/*************************************/
/*             PSU TABLE             */
/*************************************/
CREATE TABLE [dbo].[PSU](
	[PsuId]					INT IDENTITY(1000,1)	NOT NULL,
	[Brand]					VARCHAR(10)				NOT NULL,
	[Model]					VARCHAR(25)				NOT NULL,
	[Wattage]				INT						NOT NULL,
	[Efficiency]			VARCHAR(10)				NOT NULL,
	[Price]					DECIMAL(7,2)			NOT NULL,
	CONSTRAINT [PK_PsuId] PRIMARY KEY CLUSTERED	 ([PsuId] ASC)
)

CREATE INDEX PsuID_Index
ON PSU ([PsuId])
GO


/*************************************/
/*           STORAGE TABLE           */
/*************************************/
CREATE TABLE [dbo].[Storage](
	[StorageId]				INT IDENTITY(1000,1) 	NOT NULL,
	[Brand]					VARCHAR(10)		 		NOT NULL,
	[Model]					VARCHAR(25)				NOT NULL,
	[StorageSize]			INT						NOT NULL,
	[StorageType]			VARCHAR(5)				NOT NULL,
	[BenchmarkScore]		INT						NOT NULL,
	[StorageSequentialRead]	INT						NOT NULL,
	[StorageSequentialWrite] INT					NOT NULL,
	[StorageRandomRead]		INT						NOT NULL,
	[StorageRandomWrite] 	INT						NOT NULL,
	[BestUse]				VARCHAR(50)				NOT NULL,
	[Price]					DECIMAL(7,2)			NOT NULL,
	CONSTRAINT [PK_StorageId] PRIMARY KEY CLUSTERED ([StorageID] ASC)
) ON [PRIMARY]
GO

CREATE INDEX StorageID_Index
ON Storage ([StorageId])
GO


/*************************************/
/*           OPTICAL TABLE           */
/*************************************/
CREATE TABLE [dbo].[Optical](
	[OpticalId]				INT IDENTITY(1000,1) 	NOT NULL,
	[Brand]					VARCHAR(10)		 		NOT NULL,
	[Model]					VARCHAR(25)				NOT NULL,
	[OpticalType]			VARCHAR(15)				NOT NULL,
	[Price]					DECIMAL(7,2)			NOT NULL,
	CONSTRAINT [PK_OpticalId] PRIMARY KEY CLUSTERED ([OpticalID] ASC)
) ON [PRIMARY]
GO

CREATE INDEX OpticalID_Index
ON Optical ([OpticalId])
GO

/*************************************/
/*            ROLES TABLE            */
/*************************************/
CREATE TABLE [dbo].[Roles](
	[RoleId]				INT IDENTITY(1000,1)	NOT NULL,
	[RoleName]				VARCHAR(50) UNIQUE		NOT NULL,
	[RoleDescription]		VARCHAR(MAX)			NOT NULL,
	CONSTRAINT [PK_RoleId] PRIMARY KEY CLUSTERED ([RoleId] ASC)
) ON [PRIMARY]
GO

CREATE INDEX RoleId_Index
ON Roles ([RoleId])
GO


/*************************************/
/*            USER  TABLE            */
/*************************************/
CREATE TABLE [dbo].[Users](
	[UserId]				INT IDENTITY(1000,1) 	NOT NULL,
	[FirstName]				VARCHAR(50)		 		NOT NULL,
	[LastName]				VARCHAR(50)				NOT NULL,
	[Address]				VARCHAR(50)				NOT NULL,
	[City]					VARCHAR(50)				NOT NULL,
	[StateCode]				CHAR(2)					NOT NULL,
	[Zip]					VARCHAR(9)				NOT NULL,
	[LocalPhone]			VARCHAR(10)				NOT NULL,
	[EmailAddress]			VARCHAR(100)			NOT NULL,
	[Username]				VARCHAR(50)				NOT NULL,
	[Password]				CHAR(64)				NOT NULL,
	[RoleName]				VARCHAR(50)				NOT NULL,
	[Active]				BIT						NOT NULL 				DEFAULT 1,
	CONSTRAINT [PK_UserId] PRIMARY KEY CLUSTERED ([UserID] ASC)
) ON [PRIMARY]
GO

CREATE INDEX UserID_Index
ON Users ([UserId])
GO

ALTER TABLE [dbo].[Users] WITH NOCHECK ADD CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleName])
REFERENCES [dbo].[Roles] ([RoleName])
ON UPDATE CASCADE
GO

/*************************************/
/*   END OF CREATE DATABASE SCRIPT   */
/*************************************/
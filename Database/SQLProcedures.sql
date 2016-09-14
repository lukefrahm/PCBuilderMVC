/*************************************/
/*   BEGIN STORED PROCEDURES SCRIPT  */
/*************************************/

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
--OpticalType		VARCHAR(10)			|--RoleDescription	VARCHAR(MAX)


/*************************************/
/*          SELECT DATABASE          */
/*************************************/
USE PCBuilder
GO


/*************************************/
/*     STORED PROCEDURES FOR CPU     */
/*************************************/
/************ INSERT  CPU ************/
CREATE PROCEDURE [sp_insert_cpu]
	@Brand 				VARCHAR(10),
	@Model 				VARCHAR(25),
	@Cores 					INT,
	@HyperThreaded 			BIT,
	@ClockSpeed 			FLOAT,
	@Unlocked 				BIT,
	@Socket 				VARCHAR(25),
	@ProductLineName 		VARCHAR(25),
	@BenchmarkScore 		INT,
	@BestUse 				VARCHAR(50),
	@PowerRequirement 		INT,
	@Price 					DECIMAL(7,2)
AS
BEGIN
	INSERT INTO CPU
	VALUES(
		@Brand,
		@Model,
		@Cores,
		@HyperThreaded,
		@ClockSpeed,
		@Unlocked,
		@Socket,
		@ProductLineName,
		@BenchmarkScore,
		@BestUse,
		@PowerRequirement,
		@Price
	)
END
GO


CREATE PROCEDURE sp_get_all_cpus
AS
BEGIN
	SELECT CpuId, 
		   Brand, 
		   Model, 
		   Cores, 
		   HyperThreaded, 
		   ClockSpeed, 
		   Unlocked, 
		   Socket, 
		   ProductLineName, 
		   BenchmarkScore, 
		   BestUse, 
		   PowerRequirement, 
		   Price
    FROM CPU
    ORDER BY BenchmarkScore
END
GO

CREATE PROCEDURE sp_get_cpu_by_name
	@Model 				VARCHAR(25)
AS
BEGIN
	SELECT @Model = Model
	FROM CPU
	WHERE @Model = Model
END
GO

CREATE PROCEDURE sp_get_cpus_by_core_count
	@Cores 					INT
AS
BEGIN
	SELECT @Cores = Cores
	FROM CPU
	WHERE @Cores = Cores
END
GO


/*************************************/
/*     STORED PROCEDURES FOR GPU     */
/*************************************/
/************ INSERT  GPU ************/
CREATE PROCEDURE sp_insert_gpu
	@Brand 				VARCHAR(10),
    @Model 				VARCHAR(25),
    @ClockSpeed 			FLOAT,
    @ProductLineName 		VARCHAR(25),
    @BenchmarkScore 		INT,
	@BestUse				VARCHAR(50),
    @GpuRamSize 			INT,
	@PciPinConnector1		INT,
	@PciPinConnector2		INT,
	@PciPinConnector3		INT,
    @PowerRequirement 		INT,
	@GpuLength				CHAR(1),
    @Price 					DECIMAL(7,2)
AS
BEGIN
	INSERT INTO GPU
	VALUES(
		@Brand,
		@Model,
		@ClockSpeed,
		@ProductLineName,
		@BenchmarkScore,
		@BestUse,
		@GpuRamSize,
		@PciPinConnector1,
		@PciPinConnector2,
		@PciPinConnector3,
		@PowerRequirement,
		@GpuLength,
		@Price
	)
END
GO


CREATE PROCEDURE sp_get_all_gpus
AS
BEGIN
	SELECT GpuId,
		   Brand,
		   Model,
		   ClockSpeed,
		   ProductLineName,
		   BenchmarkScore,
		   BestUse,
		   GpuRamSize,
		   PciPinConnector1,
		   PciPinConnector2,
		   PciPinConnector3,
		   PowerRequirement,
		   GpuLength,
		   Price
	FROM GPU
	ORDER BY BenchmarkScore
END
GO

CREATE PROCEDURE sp_get_gpu_by_name
	@Model 				VARCHAR(25)
AS
BEGIN
	SELECT *
	FROM GPU
	WHERE @Model = Model
END
GO

CREATE PROCEDURE sp_get_gpus_by_ram_size
	@RamSize 				INT
AS
BEGIN
	SELECT @RamSize = GpuRamSize
	FROM GPU
	WHERE @RamSize = GpuRamSize
END
GO


/*************************************/
/* STORED PROCEDURES FOR MOTHERBOARD */
/*************************************/
/******** INSERT  MOTHERBOARD ********/
CREATE PROCEDURE sp_insert_motherboard
	@Brand 		VARCHAR(10),
    @Model 		VARCHAR(25),
    @Socket 				VARCHAR(25),
    @Chipset 				VARCHAR(25),
    @MaxRam 				INT,
    @RamType 				INT,
    @FormFactor 			VARCHAR(10),
    @SataPorts 				INT,
    @M2Slots 				INT,
    @PowerPhases 			INT,
    @FanHeaders 			INT,
    @Pcie16 				INT,
    @Pcie8 					INT,
    @Pcie4 					INT,
	@Pcie1 					INT,
    @Pci 					INT,
    @Price 					DECIMAL(7,2)
AS
BEGIN
	INSERT INTO Motherboards
	VALUES(
		@Brand,
		@Model,
		@Socket,
		@Chipset,
		@MaxRam,
		@RamType,
		@FormFactor,
		@SataPorts,
		@M2Slots,
		@PowerPhases,
		@FanHeaders,
		@Pcie16,
		@Pcie8,
		@Pcie4,
		@Pcie1,
		@Pci,
		@Price
	)
END
GO


CREATE PROCEDURE sp_get_all_motherboards
AS
BEGIN
	SELECT MotherboardId, 
		   Brand, 
		   Model, 
		   Socket,
		   Chipset, 
		   MaxRam, 
		   RamType,
		   FormFactor,
		   SataPorts, 
		   M2Slots,
		   PowerPhases, 
		   FanHeaders, 
		   Pcie16, 
		   Pcie8, 
		   Pcie4, 
		   Pcie1,
		   Pci, 
		   Price
    FROM Motherboards
    ORDER BY Socket 
END
GO

CREATE PROCEDURE sp_get_motherboard_by_name
	@Model 		VARCHAR(25)
AS
BEGIN
	SELECT @Model = Model
	FROM Motherboards
	WHERE @Model = Model
END
GO

CREATE PROCEDURE sp_get_motherboards_by_socket
	@Socket 				VARCHAR(25)
AS
BEGIN
	SELECT @Socket = Socket
	FROM Motherboards
	WHERE @Socket = Socket
END
GO


/*************************************/
/*   STORED PROCEDURES FOR OPTICAL   */
/*************************************/
/********** INSERT  OPTICAL **********/
CREATE PROCEDURE sp_insert_optical
	@Brand		 	VARCHAR(10),
    @Model 			VARCHAR(25),
    @OpticalType 			VARCHAR(15),
    @Price 					DECIMAL(7,2)
AS
BEGIN
	INSERT INTO Optical
	VALUES(
		@Brand,
		@Model,
		@OpticalType,
		@Price
	)
END
GO


CREATE PROCEDURE sp_get_optical_by_name
	@Model 			VARCHAR(25)
AS
BEGIN
	SELECT @Model = Model
	FROM Optical
	WHERE @Model = Model
END
GO

CREATE PROCEDURE sp_get_optical_by_type
	@OpticalType 			VARCHAR(15)
AS
BEGIN
	SELECT *
	FROM Optical
	WHERE @OpticalType = OpticalType
END
GO


/*************************************/
/*     STORED PROCEDURES FOR PSU     */
/*************************************/
/************ INSERT  PSU ************/
CREATE PROCEDURE sp_insert_psu
	@Brand 				VARCHAR(10),
    @Model 				VARCHAR(25),
    @Wattage 				INT,
    @Efficiency 			VARCHAR(10),
    @Price 					DECIMAL(7,2)
AS
BEGIN
	INSERT INTO PSU
	VALUES(
		@Brand,
		@Model,
		@Wattage,
		@Efficiency,
		@Price
	)
END
GO


CREATE PROCEDURE sp_get_all_psus
AS
BEGIN
	SELECT PsuId,
		   Brand,
		   Model,
		   Wattage,
		   Efficiency,
		   Price
	FROM PSU
	ORDER BY Wattage
END
GO

CREATE PROCEDURE sp_get_psu_by_name
	@Model 				VARCHAR(25)
AS
BEGIN
	SELECT @Model = Model
	FROM PSU
	WHERE @Model = Model
END
GO

CREATE PROCEDURE sp_get_psus_by_wattage
	@Wattage 				INT
AS
BEGIN
	SELECT @Wattage = Wattage
	FROM PSU
	WHERE @Wattage = Wattage
END
GO


/*************************************/
/*     STORED PROCEDURES FOR RAM     */
/*************************************/
/************ INSERT  RAM ************/
CREATE PROCEDURE sp_insert_ram
	@Brand 				VARCHAR(10),
    @Model 				VARCHAR(25),
    @RamSize 				INT,
    @RamGeneration 			INT,
    @RamSpeed 				INT,
    @RamTimings 			CHAR(14),
	@BestUse				VARCHAR(50),
    @Price 					DECIMAL(7,2)
AS
BEGIN
	INSERT INTO RAM
	VALUES(
		@Brand,
		@Model,
		@RamSize,
		@RamGeneration,
		@RamSpeed,
		@RamTimings,
		@BestUse,
		@Price
	)
END
GO


CREATE PROCEDURE sp_get_all_rams
AS
BEGIN
	SELECT RamId,
		   Brand,
		   Model,
		   RamSize,
		   RamGeneration, 
		   RamSpeed, 
		   RamTimings, 
		   BestUse, 
		   Price
	FROM RAM
	ORDER BY RamSize
END
GO

CREATE PROCEDURE sp_get_ram_by_name
	@Model 				VARCHAR(25)
AS
BEGIN
	SELECT @Model = Model
	FROM RAM
	WHERE @Model = Model
END
GO

CREATE PROCEDURE sp_get_rams_by_ram_size
	@RamSize 				INT
AS
BEGIN
	SELECT @RamSize = RamSize
	FROM RAM
	WHERE @RamSize = RamSize
END
GO


/*************************************/
/*   STORED PROCEDURES FOR STORAGE   */
/*************************************/
/********** INSERT  STORAGE **********/
CREATE PROCEDURE sp_insert_storage
	@Brand 			VARCHAR(10),
    @Model 			VARCHAR(25),
    @StorageSize 			INT,
    @StorageType 			VARCHAR(5),
    @BenchmarkScore 		INT,
    @StorageSequentialRead 	INT,
    @StorageSequentialWrite INT,
    @StorageRandomRead 		INT,
    @StorageRandomWrite 	INT,
    @BestUse 				VARCHAR(50),
    @Price 					DECIMAL(7,2)
AS
BEGIN
	INSERT INTO Storage
	VALUES(
		@Brand,
		@Model,
		@StorageSize,
		@StorageType,
		@benchmarkScore,
		@StorageSequentialRead,
		@StorageSequentialWrite,
		@StorageRandomRead,
		@StorageRandomWrite,
		@BestUse,
		@Price
	)
END
GO


CREATE PROCEDURE sp_get_all_storage
AS
BEGIN
	SELECT StorageId, 
		   Brand, 
		   Model, 
		   StorageSize,
		   StorageType, 
		   BenchmarkScore, 
		   StorageSequentialRead,
		   StorageSequentialWrite, 
		   StorageRandomRead, 
		   StorageRandomWrite,
		   BestUse, 
		   Price
    FROM Storage
    ORDER BY BenchmarkScore
END
GO

CREATE PROCEDURE sp_get_storage_by_name
	@Model 			VARCHAR(25)
AS
BEGIN
	SELECT @Model = Model
	FROM Storage
	WHERE @Model = Model
END
GO

CREATE PROCEDURE sp_get_storage_by_size
	@StorageSize 			INT
AS
BEGIN
	SELECT @StorageSize = StorageSize
	FROM Storage
	WHERE @StorageSize = StorageSize
END
GO

CREATE PROCEDURE sp_get_storage_by_type
	@StorageType 			VARCHAR(5)
AS
BEGIN
	SELECT @StorageType = StorageType
	FROM Storage
	WHERE @StorageType = StorageType
END
GO


/*************************************/
/*    STORED PROCEDURES FOR USERS    */
/*************************************/
/************ INSERT USER ************/
CREATE PROCEDURE sp_insert_user
	@FirstName 				VARCHAR(50),
    @LastName 				VARCHAR(50),
    @Address 				VARCHAR(50),
    @City 					VARCHAR(50),
    @StateCode 				CHAR(2),
    @Zip 					VARCHAR(9),
    @LocalPhone 			VARCHAR(10),
    @EmailAddress 			VARCHAR(100),
    @UserName 				VARCHAR(50),
    @Password 				VARCHAR(50),
    @RoleName				VARCHAR(50),
	@Active 				BIT
AS
BEGIN
	INSERT INTO Users
	VALUES(
		@FirstName,
		@LastName,
		@Address,
		@City,
		@StateCode,
		@Zip,
		@LocalPhone,
		@EmailAddress,
		@UserName,
		@Password,
		@RoleName,
		@Active
	)
END
GO


CREATE PROCEDURE sp_get_user_count (
	@Active					BIT
)
AS
BEGIN
	SELECT COUNT(*)
	FROM Users
	WHERE Active = @Active
END
GO

CREATE PROCEDURE sp_get_all_users(
	@Active					BIT
)
AS
BEGIN
	SELECT UserID, 
		   FirstName, 
		   LastName, 
		   Address, 
		   City, 
		   StateCode, 
		   Zip,
		   LocalPhone, 
		   EmailAddress, 
		   Active, 
		   UserName, 
		   Password
    FROM Users 
	WHERE Active = @Active
	ORDER BY LastName
END
GO

CREATE PROCEDURE sp_select_user_with_username 
	@username 				VARCHAR(50)
AS
BEGIN
	SELECT UserID, FirstName, LastName, Address, City, StateCode, Zip, LocalPhone, EmailAddress, Username, Password, RoleName, Active
	FROM [dbo].[Users]
	WHERE Username = @username
END
GO

CREATE PROCEDURE sp_validate_active_username_and_password (
	@username 				VARCHAR(50),
	@password				VARCHAR(50)
	)
AS
BEGIN
	SELECT COUNT(*)
	FROM Users
	WHERE
		Username = @username
	AND Password = @password
	AND Active = 1
END
GO

CREATE PROCEDURE sp_update_password_for_username (
	@username 				VARCHAR(50),
	@oldPassword 			VARCHAR(50),
	@newPassword 			VARCHAR(50)
	)
AS
BEGIN
	UPDATE Users
		SET Password = @newPassword
	WHERE
		UserName = @username
	AND Password = @oldPassword
	AND Active = 1
	RETURN @@rowcount
END
GO

CREATE PROCEDURE sp_select_roles_for_username (
	@username				VARCHAR(50)
)
AS
BEGIN
	SELECT RoleName
	FROM Users
	WHERE UserName = @username
END
GO


/*************************************/
/*    STORED PROCEDURES FOR ROLES    */
/*************************************/
/************ INSERT ROLE ************/
CREATE PROCEDURE sp_insert_role
	@RoleName				VARCHAR(50),
	@RoleDescription		VARCHAR(MAX)
AS
BEGIN
	INSERT INTO Role
	VALUES(
		@RoleName,
		@RoleDescription
	)
END
GO


CREATE PROCEDURE sp_select_role_by_name
	@RoleName				VARCHAR(50)
AS
BEGIN
	SELECT @RoleName = RoleName
	FROM Roles
	WHERE @RoleName = RoleName
END
GO

CREATE PROCEDURE sp_select_role_by_id
	@RoleId					INT
AS
BEGIN
	SELECT @RoleId = RoleId
	FROM Roles
	WHERE @RoleId = RoleId
END
GO

/*************************************/
/*    END STORED PROCEDURES SCRIPT   */
/*************************************/
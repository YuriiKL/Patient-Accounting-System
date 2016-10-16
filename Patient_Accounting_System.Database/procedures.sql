USE PatientAccountingSystem

CREATE PROCEDURE spAddNewPatient
    @FirstName nvarchar(50),
    @LastName nvarchar(50),
    @BirthDate datetime,
    @Sex smallint,
    @PhoneNumber nvarchar(20),
    @Email nvarchar(40),
    @Notes nvarchar(max),
	@Id int OUT
AS
	BEGIN TRAN
		BEGIN TRY

			DECLARE @Temp TABLE(ID int NOT NULL);
			INSERT INTO tblPatients
			(FirstName
            ,LastName
            ,BirthDate
            ,Sex
            ,PhoneNumber
            ,Email
            ,Notes)
			OUTPUT INSERTED.PatientId INTO @Temp
			VALUES(
			@FirstName,
			@LastName,
			@BirthDate,
			@Sex,
			@PhoneNumber,
			@Email,
			@Notes)
			SELECT @Id = ID FROM @Temp

			COMMIT TRAN
		END TRY

		BEGIN CATCH
			ROLLBACK TRAN
			SET @Id = -1
		END CATCH
GO

CREATE PROCEDURE spUpdatePatient
    @PatientID int,
    @FirstName nvarchar(50),
    @LastName nvarchar(50),
    @BirthDate datetime,
    @Sex smallint,
    @PhoneNumber nvarchar(20),
    @Email nvarchar(40),
    @Notes nvarchar(max),
	@Id int OUT
AS
	BEGIN TRAN
		BEGIN TRY
			DECLARE @Temp TABLE(ID int NOT NULL);
			UPDATE tblPatients
			SET
			FirstName = @FirstName
            ,LastName = @LastName
            ,BirthDate = @BirthDate
            ,Sex = @Sex
            ,PhoneNumber = @PhoneNumber
            ,Email = @Email
            ,Notes = @Notes
			OUTPUT inserted.PatientId INTO @Temp
			WHERE PatientId = @PatientID;
			SET @Id = -1
			SELECT @Id = ID FROM @Temp
			COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SET @Id = -1
		END CATCH
GO

CREATE PROCEDURE spAddNewProvidedService
@ExecutionDateTime datetime,
@Notes nvarchar(max),
@PatientId int,
@DoctorId int,
@ServiceId int,
@Id int OUT
AS
	BEGIN TRAN
		BEGIN TRY
		DECLARE @Temp TABLE(ID int NOT NULL);
			INSERT INTO tblProvidedServices
			(ExecutionDateTime
            ,Notes
            ,PatientId
            ,DoctorId 
            ,ServiceId)
			OUTPUT INSERTED.ProvidedServiceId INTO @Temp
			VALUES(
			@ExecutionDateTime, 
			@Notes,
			@PatientId,
			@DoctorId,
			@ServiceId)
			SELECT @Id = ID FROM @Temp
			COMMIT TRAN
		END TRY

		BEGIN CATCH
			ROLLBACK TRAN
			SET @Id = -1
		END CATCH

GO 


CREATE PROCEDURE spUpdateProvidedService
@ProvidedServiceId int,
@ExecutionDateTime datetime,
@Notes nvarchar(max),
@PatientId int,
@DoctorId int,
@ServiceId int,
@Id int OUT
AS
	BEGIN TRAN
		BEGIN TRY
		DECLARE @Temp TABLE(ID int NOT NULL);
			UPDATE tblProvidedServices
			SET
			ExecutionDateTime = @ExecutionDateTime
            ,Notes = @Notes
            ,PatientId = @PatientId
            ,DoctorId =@DoctorId
            ,ServiceId = @ServiceId
			OUTPUT INSERTED.ProvidedServiceId INTO @Temp
			WHERE ProvidedServiceId = @ProvidedServiceId;
			SET @Id = -1
			SELECT @Id = ID FROM @Temp
			COMMIT TRAN
		END TRY

		BEGIN CATCH
			ROLLBACK TRAN
			SET @Id = -1
		END CATCH

GO


CREATE PROCEDURE spDeleteProvidedService
@ProvidedServiceId int,
@Id int OUT
AS
	BEGIN TRAN
		BEGIN TRY
			DECLARE @Temp TABLE(ID int NOT NULL);

			DELETE FROM tblProvidedServices
			OUTPUT Deleted.ProvidedServiceId INTO @Temp
			WHERE ProvidedServiceId = @ProvidedServiceId
			SET @Id = -1

			SELECT @Id = ID FROM @Temp
			COMMIT TRAN
		END TRY

		BEGIN CATCH
			ROLLBACK TRAN
			SET @Id = -1
		END CATCH

GO



CREATE PROCEDURE spGetPreviouslyProvidedServices
@PatientId int,
@DoctorId int
AS
BEGIN TRAN
	BEGIN TRY
	IF @PatientId IS NOT NULL 
	BEGIN
		SELECT *
		FROM vAllProvidedServices
		WHERE 
			PatientId = @PatientId
		ORDER BY
            ProvidedServiceId DESC
	END
	ELSE
	IF @DoctorId  IS NOT NULL 
	BEGIN
		SELECT *
		FROM vAllProvidedServices
		WHERE 
			DoctorId = @DoctorId
		ORDER BY
            ProvidedServiceId DESC
	END
	ELSE
	BEGIN
		SELECT TOP(200) *
		FROM vAllProvidedServices
		ORDER BY
            ProvidedServiceId DESC
	END
		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
GO

CREATE PROCEDURE spGetTotalCost
@DateFrom datetime,
@DateTo datetime
AS
BEGIN TRAN
	BEGIN TRY
		SELECT SUM(ServicePrice) AS 'TotalCost'
		FROM vAllProvidedServices
		WHERE 
			ExecutionDateTime>=@DateFrom 
			AND ExecutionDateTime <= @DateTo
		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

GO

CREATE PROCEDURE spGetCost
@ByPatients bit,
@ByDoctors bit,
@ByServices bit,
@DateFrom datetime,
@DateTo datetime
AS
BEGIN TRAN
	BEGIN TRY
	IF @ByPatients=1
	BEGIN
		SELECT pp.PatientId, pp.FirstName AS 'PatientFirstName', pp.LastName AS 'PatientLastName', TotalCost, ServicesProvided,
		CAST((TotalCost/ServicesProvided) AS decimal(18,2)) AS 'AverageCostPerService'  
		FROM (
		SELECT PatientId, SUM(ServicePrice) AS 'TotalCost', COUNT(ServiceId) AS 'ServicesProvided'
			FROM vAllProvidedServices
		WHERE 
			ExecutionDateTime >= @DateFrom
			AND ExecutionDateTime <= @DateTo
		GROUP BY PatientId) 
		AS SUMS
		JOIN tblPatients pp ON pp.PatientId = SUMS.PatientId 
	END

	IF @ByDoctors=1
	BEGIN
		SELECT dd.DoctorId, dd.FirstName AS 'DoctorFirstName', dd.LastName AS 'DoctorLastName', 
		dd.Title AS 'DoctorTitle', TotalCost, ServicesProvided,
		CAST((TotalCost/ServicesProvided) AS decimal(18,2)) AS 'AverageCostPerService' 
		FROM (
		SELECT DoctorId, SUM(ServicePrice) AS 'TotalCost', COUNT(ServiceId) AS 'ServicesProvided'
			FROM vAllProvidedServices
		WHERE 
			ExecutionDateTime >= @DateFrom
			AND ExecutionDateTime <= @DateTo
		GROUP BY DoctorId)
		AS SUMS
		JOIN tblDoctors dd ON dd.DoctorId = SUMS.DoctorId
	END

	IF @ByServices=1
	BEGIN
		SELECT ss.ServiceId, ss.[Name] AS 'ServiceName' , ss.Price AS 'ServicePrice', TotalCost, ServicesProvided 
		FROM (
		SELECT ServiceId, SUM(ServicePrice) AS 'TotalCost', COUNT(ServiceId) AS 'ServicesProvided'
			FROM vAllProvidedServices
		WHERE 
			ExecutionDateTime >= @DateFrom
			AND ExecutionDateTime <= @DateTo
		GROUP BY ServiceId) 
		AS SUMS
		JOIN tblServices ss ON ss.ServiceId = SUMS.ServiceId
	END



		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

GO


CREATE PROCEDURE spGetUser
@Login varchar(30),
@Password varchar(100)
AS
BEGIN TRAN
	BEGIN TRY

	SELECT usr.Id,FirstName,LastName,[Login]
	FROM tblUsers usr
	WHERE usr.[Login] = @Login AND usr.[Password] = @Password

		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

GO

CREATE PROCEDURE spGetDoctor
@DoctorId int
AS
BEGIN TRAN
	BEGIN TRY

	SELECT doc.DoctorId, doc.FirstName,doc.LastName,doc.Title,doc.PhoneNumber
	FROM tblDoctors doc
	WHERE doc.DoctorId = @DoctorId

		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

GO

CREATE PROCEDURE spGetPatient
@PatientId int
AS
BEGIN TRAN
	BEGIN TRY

	SELECT pat.PatientId, pat.FirstName, pat.LastName, pat.Sex, pat.PhoneNumber, pat.BirthDate, pat.Email, pat.Notes 
	FROM tblPatients pat
	WHERE pat.PatientId = @PatientId

		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

GO

CREATE PROCEDURE spGetService
@ServiceId int
AS
BEGIN TRAN
	BEGIN TRY

	SELECT s.ServiceId, s.[Name],s.Price
	FROM tblServices s
	WHERE s.ServiceId = @ServiceId
		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

GO




CREATE PROCEDURE spSearchPatients
@SearchString nvarchar(50)
AS
BEGIN TRAN
	BEGIN TRY

	SELECT pat.PatientId, pat.FirstName, pat.LastName, pat.Sex, pat.PhoneNumber, pat.BirthDate, pat.Email, pat.Notes 
	FROM tblPatients pat
	WHERE pat.FirstName LIKE @SearchString+'%'
		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

GO

CREATE PROCEDURE spSearchDoctors
@SearchString nvarchar(50)
AS
BEGIN TRAN
	BEGIN TRY

	SELECT doc.DoctorId, doc.FirstName,doc.LastName,doc.Title,doc.PhoneNumber
	FROM tblDoctors doc
	WHERE doc.FirstName LIKE @SearchString+'%'
		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

GO


CREATE PROCEDURE spSearchServices
@SearchString nvarchar(50)
AS
BEGIN TRAN
	BEGIN TRY

	SELECT s.ServiceId, s.[Name],s.Price
	FROM tblServices s
	WHERE s.[Name] LIKE @SearchString+'%'
		COMMIT TRAN
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

GO









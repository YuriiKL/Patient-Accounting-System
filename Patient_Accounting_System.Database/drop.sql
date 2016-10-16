USE PatientAccountingSystem

DROP PROCEDURE spAddNewPatient
DROP PROCEDURE spAddNewProvidedService
DROP PROCEDURE spUpdatePatient
DROP PROCEDURE spUpdateProvidedService
DROP PROCEDURE spGetPreviouslyProvidedServices
DROP PROCEDURE spGetTotalCost
DROP PROCEDURE spGetCost
DROP PROCEDURE spGetUser
DROP PROCEDURE spGetDoctor
DROP PROCEDURE spGetPatient
DROP PROCEDURE spGetService
DROP PROCEDURE spSearchPatients
DROP PROCEDURE spSearchDoctors
DROP PROCEDURE spSearchServices
DROP PROCEDURE spDeleteProvidedService
GO

DROP TABLE tblProvidedServices
GO

DROP TABLE tblDoctors
DROP TABLE tblPatients
DROP TABLE tblServices
DROP TABLE tblUsers

GO

DROP VIEW [dbo].[vAllProvidedServices]
GO
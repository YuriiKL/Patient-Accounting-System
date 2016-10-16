CREATE DATABASE PatientAccountingSystem
GO

USE PatientAccountingSystem
GO

CREATE TABLE [tblUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Login] [varchar](30) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	CONSTRAINT [PK_tblUsers] PRIMARY KEY ([Id]),
	CONSTRAINT [UK_Login] UNIQUE NONCLUSTERED ([Login])
) 
GO

CREATE TABLE [tblDoctors](
	[DoctorId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	CONSTRAINT [PK_tblDoctors] PRIMARY KEY ([DoctorId])
)
GO

CREATE TABLE [tblPatients](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Sex] [smallint] NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](40) NULL,
	[Notes] [nvarchar](max) NULL,
	CONSTRAINT [PK_tblPatients] PRIMARY KEY ([PatientId])
) 
GO

CREATE TABLE [tblServices](
	[ServiceId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	CONSTRAINT [PK_tblServices] PRIMARY KEY ([ServiceId])
) 

GO

CREATE TABLE [tblProvidedServices](
	[ProvidedServiceId] [int] IDENTITY(1,1) NOT NULL,
	[ExecutionDateTime] [datetime] NOT NULL,
	[Notes] [nvarchar](MAX) NULL,
	[PatientId] [int] NOT NULL,
	[DoctorId] [int] NOT NULL,
	[ServiceId] [int] NOT NULL,
	CONSTRAINT [PK_tblProvidedServices] PRIMARY KEY ([ProvidedServiceId]),
	CONSTRAINT [FK_tblProvidedServices_tblDoctors] FOREIGN KEY([DoctorId]) REFERENCES [tblDoctors] ([DoctorId]),
	CONSTRAINT [FK_tblProvidedServices_tblPatients] FOREIGN KEY([PatientId]) REFERENCES [tblPatients] ([PatientId]),
	CONSTRAINT [FK_tblProvidedServices_tblServices] FOREIGN KEY([ServiceId]) REFERENCES [tblServices] ([ServiceId])
) 

GO


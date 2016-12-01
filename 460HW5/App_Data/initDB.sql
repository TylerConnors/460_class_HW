-- Create tables and populate with seed data
--    follow naming convention: "Users" table contains rows that are each "User" objects

-- ***********  Attach ***********
CREATE DATABASE [WOUWeb] ON
PRIMARY (NAME=[WOUWeb], FILENAME='$(dbdir)\WOUWeb.mdf')
LOG ON (NAME=[WOUWeb_log], FILENAME='$(dbdir)\WOUWeb_log.ldf');
--FOR ATTACH;
GO

USE [WOUWeb];
GO
-- *********** Drop Tables ***********

IF OBJECT_ID('dbo.WOUForms','U') IS NOT NULL
	DROP TABLE [dbo].[WOUForms];
GO

-- ########### WOUForm ###########
CREATE TABLE [dbo].[WOUForms] 
  (
  [ID] INT IDENTITY(1,1) NOT NULL ,
  [VNum] NVARCHAR(45) NOT NULL,
  [First_Name] NVARCHAR(45) NOT NULL,
  [Last_Name] NVARCHAR(45) NOT NULL,
  [Date] DATETIME NOT NULL,
  [Phone_Number] NVARCHAR(45) NOT NULL,
  [Catalog_Year] INT NOT NULL,
  [Email] NVARCHAR(60) NOT NULL,
  [Major] NVARCHAR(45) NOT NULL,
  [Minor] NVARCHAR(45) NOT NULL,
  [Advisor] NVARCHAR(45) NOT NULL,
  CONSTRAINT [PK_dbo.WOUForms] PRIMARY KEY CLUSTERED ([ID] ASC)
  );



BULK INSERT [dbo].[WOUForms]
	FROM '$(dbdir)\SeedData\WOUForm.csv'		-- ID,FirstName,LastName,DOB
	WITH
	(
		FIELDTERMINATOR = ',',
		ROWTERMINATOR	= '\n',
		FIRSTROW = 2
	);
GO

-- ***********  Detach ***********
USE master;
GO

ALTER DATABASE [WOUWeb] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

EXEC sp_detach_db 'WOUWeb', 'true'

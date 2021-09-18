-- Create Database
CREATE DATABASE [Minions]

USE [Minions]
GO

-- Create tables
CREATE TABLE [Minions2](
    [ID] INT NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL,
    [Age] INT NULL
 )

CREATE TABLE [Towns2](
    [ID] INT NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL
 )

ALTER TABLE [Minions2]
		ADD [TownID] INT

   ALTER TABLE [Minions2]
ADD CONSTRAINT [FK_MinionsID] FOREIGN KEY (TownId) REFERENCES [Towns2]([Id])

INSERT INTO [Towns2]([ID], [Name]) 
VALUES (1, 'Sofia'),
       (2, 'Plovdiv'),
       (3, 'Varna')

INSERT INTO [Minions2]([ID], [Name], [Age], [TownID]) 
VALUES (1, 'Kevin', 22, 1),
       (2, 'Bob', 15, 3),
       (3, 'Steward', NULL, 2)

TRUNCATE TABLE 'Minions2'
	DROP TABLE 'Minions2'


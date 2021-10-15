---Task 01: Create Database
CREATE DATABASE [Minions]

USE [Minions]
GO

---Task 02: Create tables
CREATE TABLE [Minions](
    [ID] INT NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL,
    [Age] INT NULL
 )

CREATE TABLE [Towns](
    [ID] INT NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL
 )

---Task 03: Alter Minions Table
ALTER TABLE [Minions]
		ADD [TownID] INT

   ALTER TABLE [Minions]
ADD CONSTRAINT [FK_MinionsID] FOREIGN KEY (TownId) REFERENCES [Towns]([Id])

---Task 04: Insert Records in Both Tables
INSERT INTO [Towns]([ID], [Name]) 
VALUES (1, 'Sofia'),
       (2, 'Plovdiv'),
       (3, 'Varna')

INSERT INTO [Minions]([ID], [Name], [Age], [TownID]) 
VALUES (1, 'Kevin', 22, 1),
       (2, 'Bob', 15, 3),
       (3, 'Steward', NULL, 2)

---Task 05: Truncate Table Minions
TRUNCATE TABLE 'Minions'
	DROP TABLE 'Minions'

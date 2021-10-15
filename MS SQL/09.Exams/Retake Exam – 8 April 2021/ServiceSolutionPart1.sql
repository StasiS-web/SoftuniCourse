CREATE DATABASE [Service]
GO
 
USE [Service]
GO

---Task 01: DDL
CREATE TABLE [Users] (
   [Id] INT PRIMARY KEY IDENTITY NOT NULL,
   [Username] VARCHAR(30) NOT NULL,
   [Password] VARCHAR(50) NOT NULL,
   [Name] VARCHAR(50) NOT NULL,
   [Birthdate] DATETIME2 NOT NULL,
   [Age] INT NULL CHECK([Age] BETWEEN 14 AND 110),
   [Email] VARCHAR(50) NOT NULL
)

CREATE TABLE [Departments] (
   [Id] INT PRIMARY KEY IDENTITY NOT NULL,
   [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Employees](
   [Id] INT PRIMARY KEY IDENTITY NOT NULL,
   [FirstName] VARCHAR(25) NULL,
   [LastName] VARCHAR(25) NULL,
   [Birthdate] DATETIME2 NULL,
   [Age] INT NULL CHECK([Age] BETWEEN 18 AND 110),
   [DepartmentId] INT NULL FOREIGN KEY REFERENCES [Departments]([Id])
)

CREATE TABLE [Categories](
    [Id] INT PRIMARY KEY IDENTITY NOT NULL,
    [Name] VARCHAR(50) NOT NULL,
    [DepartmentId] INT FOREIGN KEY REFERENCES [Departments]([Id]) NOT NULL
)

CREATE TABLE [Status] (
  [Id] INT PRIMARY KEY IDENTITY NOT NULL,
  [Label] VARCHAR(30) NOT NULL
)

CREATE TABLE [Reports](
   [Id] INT PRIMARY KEY IDENTITY NOT NULL,
   [CategoryId] INT FOREIGN KEY REFERENCES [Categories]([Id]) NOT NULL,
   [StatusId] INT FOREIGN KEY REFERENCES [Status] ([Id]) NOT NULL,
   [OpenDate] DATETIME2 NOT NULL,
   [CloseDate] DATETIME2 NULL,
   [Description] VARCHAR(200) NOT NULL,
   [UserId] INT FOREIGN KEY REFERENCES [Users]([Id]) NOT NULL,
   [EmployeeId] INT NULL FOREIGN KEY REFERENCES [Employees]([Id]) 
)

---Task 02: Insert
INSERT INTO [Employees]([FirstName], [LastName], [Birthdate], [DepartmentId])
     VALUES ('Marlo', 'O''Malley', '1958-9-21', 1),
            ('Niki', 'Stanaghan', '1969-11-26', 4),
            ('Ayrton', 'Senna', '1960-03-21', 9),
            ('Ronnie', 'Peterson', '1944-02-14', 9),
            ('Giovanna', 'Amati', '1959-07-20', 5)
            
INSERT INTO [Reports]([CategoryId], [StatusId], [OpenDate], [CloseDate],[Description], [UserId], [EmployeeId])
     VALUES (1, 1, '2017-04-13', NULL, 'Stuck Road on Str.133', 6, 2),
            (6, 3, '2015-09-05', '2015-12-06', 'Charity trail running', 3, 5),
            (14, 2, '2015-09-07', NULL, 'Falling bricks on Str.58', 5, 2),
            (4, 3, '2017-07-03','2017-07-06', 'Cut off streetlight on Str.11', 1, 1)
            
---Task 03: Update
UPDATE [Reports]
SET [CloseDate] = GETDATE()
WHERE [CloseDate] IS NULL 

---Task 04: Delete
DELETE [Reports]
WHERE [StatusId] = 4
         

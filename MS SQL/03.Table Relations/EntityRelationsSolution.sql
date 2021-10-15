CREATE DATABASE [EntityRelations]

USE [EntityRelations]
GO

---Task 1: One-To-One Relationship
CREATE TABLE [Passports]( 
  [PassportID] INT PRIMARY KEY NOT NULL,
  [PassportNumber] NVARCHAR(8) NOT NULL
)

CREATE TABLE [Persons](
  [PersonID] INT PRIMARY KEY IDENTITY NOT NULL,
  [FirstName] NVARCHAR(50) NOT NULL,
  [Salary] DECIMAL(9,2) NOT NULL,
  [PassportID] INT FOREIGN KEY REFERENCES [Passports]([PassportID]) UNIQUE NOT NULL
)

INSERT INTO [Passports]([PassportID], [PassportNumber])
     VALUES (101, 'N34FG21B'),
            (102, 'K65LO4R7'),
            (103, 'ZE657QP2')
  
INSERT INTO [Persons]([FirstName], [Salary], [PassportID])
     VALUES ('Roberto', 43300.00, 102),
            ('Tom', 56100.00, 103),
            ('Yana', 60200.00, 101)

---Task 2: One-To-Many Relationship
CREATE TABLE [Manufacturers](
  [ManufacturerID] INT PRIMARY KEY IDENTITY NOT NULL,
  [Name] NVARCHAR(50) NOT NULL,
  [EstablishedOn] DATETIME2 NOT NULL
 )
 
 CREATE TABLE [Models](
    [ModelID] INT PRIMARY KEY NOT NULL,
    [Name] NVARCHAR(30),
    [ManufacturerID] INT FOREIGN KEY REFERENCES [Manufacturers]([ManufacturerID]) NOT NULL
 )
 
INSERT INTO [Manufacturers]([Name], [EstablishedOn])
     VALUES
             ('BMW', '1916-03-07'),
             ('Tesla', '2003-01-01'),
             ('Lada', '1966-05-01')
             
INSERT INTO [Models]([ModelID], [Name], [ManufacturerID])
     VALUES
            (101, 'X1', 1),
            (102, 'i6', 1),
            (103, 'Model S', 2),
            (104, 'Model X', 2),
            (105, 'Model 3', 2),
            (106, 'Nova', 3)
        
SELECT * FROM [Manufacturers]
            
---Task 3: Many-To-Many Relationship
CREATE TABLE [Students](
 [StudentID]  INT PRIMARY KEY IDENTITY NOT NULL,
 [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Exams](
[ExamID] INT PRIMARY KEY IDENTITY(101,1) NOT NULL,
[Name] NVARCHAR(75) NOT NULL
)

CREATE TABLE [StudentsExams](
 [StudentID] INT FOREIGN KEY REFERENCES[Students]([StudentID]) NOT NULL,
 [ExamID] INT FOREIGN KEY REFERENCES [Exams]([ExamID]) NOT NULL,
 PRIMARY KEY([StudentID], [ExamID])
)

INSERT INTO [Students]([Name])
VALUES ('Mila'),
       ('Toni'),
       ('Ron')
       
INSERT INTO [Exams]([Name])
VALUES ('SpringMVC'),
       ('Neo4j'),
       ('Oracle 11g')
       
INSERT INTO [StudentsExams]([StudentID], [ExamID])
VALUES (1, 101), 
       (1, 102),
       (2, 101),
       (3, 103),
       (2, 102),
       (2, 103)
       
SELECT * FROM [Students]
SELECT * FROM [Exams]
 
---Task 4: Self-Referencing
CREATE TABLE [Teachers](
[TeacherID] INT PRIMARY KEY IDENTITY(101,1) NOT NULL,
[Name] VARCHAR(50) NOT NULL,
[ManagerID] INT FOREIGN KEY REFERENCES [Teachers]([TeacherID])
)

INSERT INTO [Teachers]([Name], [ManagerID])
VALUES ('John', NULL),
       ('Maya', 106),
       ('Silvia', 106),
       ('Ted', 105),
       ('Mark', 101),
       ('Greta', 101)

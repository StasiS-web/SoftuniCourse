CREATE DATABASE [SoftUni]

USE [SoftUni]
GO

CREATE TABLE [Towns] (
    [Id] INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE [Addresses] (
    [Id] INT PRIMARY KEY IDENTITY, 
    [AddressText] NVARCHAR(300), 
    [TownId] INT FOREIGN KEY REFERENCES [Towns]([Id])
 )

 CREATE TABLE [Departments] (
     [Id] INT PRIMARY KEY IDENTITY, 
     [Name] NVARCHAR(50) NOT NULL,
 )

 CREATE TABLE [Employees] (
  [Id] INT PRIMARY KEY IDENTITY, 
  [FirstName] NVARCHAR(50) NOT NULL, 
  [MiddleName] NVARCHAR(50) NOT NULL, 
  [LastName] NVARCHAR(50) NOT NULL, 
  [JobTitle] NVARCHAR(50) NOT NULL, 
  [DepartmentId] INT FOREIGN KEY REFERENCES [Departments]([Id]), 
  [HireDate] DATE NOT NULL, 
  [Salary] DECIMAL(15,2) NOT NULL, 
  [AddressId] INT FOREIGN KEY REFERENCES [Addresses]([Id])
  )
  
  INSERT INTO [Towns] ([Name])
  VALUES ('Sofia'),
  		 ('Plovdiv'),
  		 ('Varna'),
  		 ('Burgas')
  		 
  INSERT INTO [Departments] ([Name])
  VALUES ('Engineering'),
  		 ('Sales'),
  		 ('Marketing'),
  		 ('Software Development'),
  		 ('Quality Assurance')
  		 
 INSERT INTO [Addresses] ([Name], [TownId])
 VALUES ('Hristo Matov 19', 1),
        ('San Stefano 11', 2),
        ('Odrin 5', 3),
        ('Nikola Petkov 11', 4)
  		 
  INSERT INTO [Employees] ([FirstName], [MiddleName], [LastName], [JobTitle], [DepartmentId], [HireDate], [Salary], [AddressId])
  VALUES ('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00, 1),
  		 ('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00, 2),
  		 ('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25, 1),
  		 ('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00, 1),
  		 ('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88, 4)

--- Select All Fields
SELECT * FROM Towns
SELECT * FROM Departments
SELECT * FROM Employees 

--- Select All Fields and Order Them
SELECT * FROM Towns
ORDER BY [Name] 

SELECT * FROM Departments
ORDER BY [Name] 

SELECT * FROM Employees 
ORDER BY [Salary] DESC

--- Select Some Fields
SELECT [Name] FROM Towns 
ORDER BY [Name] 

SELECT [Name] FROM Departments
ORDER BY [Name]

SELECT [FirstName], [LastName], [JobTitle], [Salary] FROM Employees
ORDER BY [Salary] DESC 




USE [SoftUni]
GO

---Task 01: Find Names of All Employees by First Name
SELECT [FirstName], [LastName] FROM [Employees]
WHERE [FirstName] LIKE('Sa%')

SELECT [FirstName], [LastName] FROM [Employees]
WHERE LEFT ([FirstName], 2) = 'Sa'

---Task 02: Find Names of All Employees by Last Name 
SELECT [FirstName], [LastName] 
  FROM [Employees]
 WHERE [LastName] LIKE ('%ei%')

---Task 03: Find First Names of All Employess
SELECT [FirstName] 
  FROM [Employees]
WHERE [DepartmentID] = 3 OR [DepartmentID] = 10 AND YEAR([HireDate]) BETWEEN 1995 AND 2005

---Task 04: Find All Employees Except Engineers
SELECT [FirstName], [LastName] 
  FROM [Employees]
 WHERE [JobTitle] NOT LIKE ('%engineer%')
 
---Task 05: Find Towns with Name Length
 SELECT [Name] FROM [Towns]
 WHERE LEN([Name]) = 5 OR LEN([Name]) = 6
 ORDER BY [Name] ASC 
 
 ---Task 06: Find Towns Starting With
 SELECT [TownID], [Name] FROM [Towns]
 WHERE [Name] LIKE ('[mkbe]%')
 ORDER BY [Name]
 
 ---Task 07: Find Towns Not Starting With
 SELECT [TownID], [Name] FROM [Towns]
 WHERE [Name] NOT LIKE ('[rbd]%')
 ORDER BY [Name]
 
---Task 08: Create View Employees Hired After
 CREATE  VIEW [V_EmployeesHiredAfter2000] AS
    SELECT [FirstName], [LastName] 
      FROM [Employees]
     WHERE YEAR([HireDate]) > 2000 
     
---Task 09: Length of Last Name
SELECT [FirstName], [LastName] 
  FROM [Employees]
WHERE LEN([LastName]) = 5

---Task 10: Rank Employees by Salary
SELECT [EmployeeID] , [FirstName], [LastName], [Salary],
DENSE_RANK() OVER(partition by [Salary] ORDER BY [EmployeeID]) AS [Rank]
  FROM [Employees]
 WHERE [Salary] BETWEEN 10000 AND 50000
 ORDER BY [Salary] DESC 
 
---Task 12: Countries Holding 'A' 
USE [Geography]
GO

SELECT [CountryName], [ISOCode] 
  FROM [Countries] 
WHERE  [CountryName] LIKE ('%A%A%A%')
ORDER BY [ISOCode] 
 
---Task 14: Games From 2011 and 2012 Year 
USE [Diablo]
GO
 
SELECT TOP(50) [Name], FORMAT([Start], 'yyyy-MM-dd') AS 'Start'
  FROM [Games]
 WHERE YEAR([Start]) BETWEEN 2011 AND 2012
 ORDER BY [Start]
 
---Task 18: Orders Table
USE [Orders]
GO

SELECT [ProductName], [OrderDate], DATEADD(DAY, 3, [OrderDate]), DATEADD(MONTH, 1, [OrderDate])
 FROM [Orders]
       


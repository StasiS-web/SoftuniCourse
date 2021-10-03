USE [SoftUni]
GO

--- Task 01
SELECT [FirstName], [LastName] FROM [Employees]
WHERE [FirstName] LIKE('Sa%')

SELECT [FirstName], [LastName] FROM [Employees]
WHERE LEFT ([FirstName], 2) = 'Sa'

--- Task 02
SELECT [FirstName], [LastName] 
  FROM [Employees]
 WHERE [LastName] LIKE ('%ei%')

---Task 03
SELECT [FirstName] 
  FROM [Employees]
WHERE [DepartmentID] = 3 OR [DepartmentID] = 10 AND YEAR([HireDate]) BETWEEN 1995 AND 2005

---Task 04
SELECT [FirstName], [LastName] 
  FROM [Employees]
 WHERE [JobTitle] NOT LIKE ('%engineer%')
 
 ---Task 05
 SELECT [Name] FROM [Towns]
 WHERE LEN([Name]) = 5 OR LEN([Name]) = 6
 ORDER BY [Name] ASC 
 
 ---Task 06
 SELECT [TownID], [Name] FROM [Towns]
 WHERE [Name] LIKE ('[mkbe]%')
 ORDER BY [Name]
 
 ---Task 07
 SELECT [TownID], [Name] FROM [Towns]
 WHERE [Name] NOT LIKE ('[rbd]%')
 ORDER BY [Name]
 
 ---Task 08
 CREATE  VIEW [V_EmployeesHiredAfter2000] AS
    SELECT [FirstName], [LastName] 
      FROM [Employees]
     WHERE YEAR([HireDate]) > 2000 
     
---Task 09
SELECT [FirstName], [LastName] 
  FROM [Employees]
WHERE LEN([LastName]) = 5

---Task 10
SELECT [EmployeeID] , [FirstName], [LastName], [Salary],
DENSE_RANK() OVER(partition by [Salary] ORDER BY [EmployeeID]) AS [Rank]
  FROM [Employees]
 WHERE [Salary] BETWEEN 10000 AND 50000
 ORDER BY [Salary] DESC 
 
---Task 12
USE [Geography]
GO

SELECT [CountryName], [ISOCode] 
  FROM [Countries] 
WHERE  [CountryName] LIKE ('%A%A%A%')
ORDER BY [ISOCode] 
 
---Task 14
USE [Diablo]
GO
 
SELECT TOP(50) [Name], FORMAT([Start], 'yyyy-MM-dd') AS 'Start'
  FROM [Games]
 WHERE YEAR([Start]) BETWEEN 2011 AND 2012
 ORDER BY [Start]
 
---Task 18
USE [Orders]
GO

SELECT [ProductName], [OrderDate], DATEADD(DAY, 3, [OrderDate]), DATEADD(MONTH, 1, [OrderDate])
 FROM [Orders]
       
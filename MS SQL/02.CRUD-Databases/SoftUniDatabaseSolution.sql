USE [SoftUni]
GO

--- Task 2
SELECT * FROM [Departments]

--- Task 3
SELECT [Name] 
  FROM [Departments]

--- Task 4
SELECT [FirstName], [LastName], [Salary] 
  FROM [Employees]

  --- Task 5
  SELECT [FirstName], [MiddleName], [LastName]
    FROM [Employees]
  
  --- Task 6
  SELECT CONCAT([FirstName], '.', [LastName], '@', 'softuni', '.bg') 
      AS [FullEmailAddress]
    FROM [Employees]
  
  --- Task 7
SELECT DISTINCT [Salary] FROM [Employees]

--- Task 8
SELECT * FROM [Employees]
WHERE  [JobTitle] = 'Sales Representative'

--- Task 9
SELECT [FirstName], [LastName], [JobTitle]
  FROM [Employees]
WHERE [Salary] BETWEEN 20000 and 30000

--- Task 10
SELECT CONCAT([FirstName], ' ', [MiddleName], ' ', [LastName]) AS [FullName]
  FROM [Employees]
 WHERE [Salary] IN (25000, 14000, 12500, 23600)

--- Task 11
SELECT [FirstName], [LastName]
  FROM [Employees]
 WHERE [ManagerID] IS NULL

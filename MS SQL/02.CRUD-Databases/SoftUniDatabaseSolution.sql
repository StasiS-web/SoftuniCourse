USE [SoftUni]
GO

---Task 2: Find All Information About Departments
SELECT * FROM [Departments]

---Task 3: Find all Department Names
SELECT [Name] 
  FROM [Departments]

---Task 4: Find Salary of Each Employee
SELECT [FirstName], [LastName], [Salary] 
  FROM [Employees]

---Task 5: Find Full Name of Each Employee
  SELECT [FirstName], [MiddleName], [LastName]
    FROM [Employees]
  
---Task 6: Find Email Address of Each Employee
  SELECT CONCAT([FirstName], '.', [LastName], '@', 'softuni', '.bg') 
      AS [FullEmailAddress]
    FROM [Employees]
  
---Task 7: Find All Different Employee’s Salaries
SELECT DISTINCT [Salary] FROM [Employees]

---Task 8: Find all Information About Employees
SELECT * FROM [Employees]
WHERE  [JobTitle] = 'Sales Representative'

---Task 9: Find Names of All Employees by Salary in Range
SELECT [FirstName], [LastName], [JobTitle]
  FROM [Employees]
WHERE [Salary] BETWEEN 20000 and 30000

---Task 10: Find Names of All Employees
SELECT CONCAT([FirstName], ' ', [MiddleName], ' ', [LastName]) AS [FullName]
  FROM [Employees]
 WHERE [Salary] IN (25000, 14000, 12500, 23600)

---Task 11: Find All Employees Without Manager
SELECT [FirstName], [LastName]
  FROM [Employees]
 WHERE [ManagerID] IS NULL

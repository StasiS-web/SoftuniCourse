USE [SoftUni]
GO

---Task 01
SELECT TOP(5) e.[EmployeeID],
              e.[JobTitle],
              e.[AddressID],
              a.[AddressText]
         FROM [Employees] AS e
        INNER JOIN [Addresses] AS a 
           ON e.[AddressID] = a.[AddressID]
        ORDER BY [AddressID]

---Task 02
SELECT TOP(50) e.[FirstName], 
               e.[LastName],
               t.[Name] AS [Town],
               a.[AddressText] 
         FROM [Employees] AS e
        INNER JOIN [Addresses] AS a 
           ON e.[AddressID] = a.[AddressID]
        INNER JOIN [Towns] AS t 
           ON a.[TownID] = t.[TownID] 
        ORDER BY e.[FirstName], e.[LastName]
 
---Task 03
SELECT e.[EmployeeID],
       e.[FirstName],
       e.[LastName],
       d.[Name] AS [DepartmentName]
  FROM [Employees] AS e 
  LEFT JOIN [Departments] AS d 
    ON e.[DepartmentID] = d.[DepartmentID]
 WHERE d.[Name] = 'Sales'
 ORDER BY e.[EmployeeID]
 
---Task 04
SELECT TOP(5) e.[EmployeeID],
              e.[FirstName],
              e.[Salary],
              d.[Name] AS [DepartmentName]
         FROM [Employees] AS e 
   INNER JOIN [Departments] AS d 
           ON e.[DepartmentID] = d.[DepartmentID]
        WHERE e.[Salary] > 15000
        ORDER BY e.[DepartmentID] ASC

---Task 05
SELECT TOP(3) e.[EmployeeID],
              e.[FirstName]
         FROM [Employees] AS e
         LEFT JOIN [EmployeesProjects] AS ep 
           ON e.[EmployeeID] = ep.[EmployeeID]
        WHERE ep.[EmployeeID] IS NULL 
        ORDER BY e.[EmployeeID]
        
---Task 06
SELECT e.[FirstName],
       e.[LastName],
       e.[HireDate],
       d.[Name] AS [DeptName]
  FROM [Employees] AS e 
 INNER JOIN [Departments] AS d 
    ON e.[DepartmentID] = d.[DepartmentID]    
WHERE [HireDate] > '1999-01-01' AND (d.[Name] = 'Sales' OR d.[Name] = 'Finance')
ORDER BY e.[HireDate] ASC 
  
--- Task 09
SELECT e.[EmployeeID],
       e.[FirstName],
       e.[ManagerID],
       ee.[FirstName] AS [ManagerName]
  FROM [Employees] AS e  
  INNER JOIN [Employees] AS ee ON e.[ManagerID] = ee.[EmployeeID]
  WHERE e.[ManagerID] = 3 OR e.[ManagerID] = 7
  ORDER BY e.[EmployeeID]
  
--- Task 10
SELECT TOP(50) e.[EmployeeID],
               CONCAT(e.[FirstName], ' ', e.[LastName]) AS [EmployeeName],
               CONCAT(ee.[FirstName], ' ', ee.[LastName]) AS [ManagerName],
               d.[Name] AS [DepartmentName]
          FROM [Employees] AS e 
         INNER JOIN [Employees] AS ee ON e.[ManagerID] = ee.[EmployeeID]
         INNER JOIN [Departments] AS d ON e.[DepartmentID] = d.[DepartmentID]    
         ORDER BY e.[EmployeeID]
 
--- Task 11
SELECT TOP(1)
      AVG(e.[Salary]) AS [MinAverageSalary]
FROM [Employees] AS e 
GROUP BY e.[DepartmentID]
ORDER BY [MinAverageSalary]
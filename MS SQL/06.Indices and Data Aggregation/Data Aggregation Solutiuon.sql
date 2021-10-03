USE [Gringotts]
GO

---Task 01: Solution1
SELECT COUNT(*) AS [Count]
  FROM [WizzardDeposits]
---Solution2
SELECT COUNT([Id]) AS [Count]
  FROM [WizzardDeposits]
  
---Task 02
SELECT MAX([MagicWandSize]) AS [LongestMagicWand]
  FROM [WizzardDeposits]
  
---Task 03
  SELECT w.[DepositGroup],
         MAX(w.[MagicWandSize]) AS [LongestMagicWand]
    FROM [WizzardDeposits] w
GROUP BY w.[DepositGroup]

---Task 04
 SELECT TOP(2) w.[DepositGroup]
    FROM [WizzardDeposits] w
GROUP BY w.[DepositGroup]
ORDER BY AVG(w.[MagicWandSize]) 

---Task 05
  SELECT w.[DepositGroup],
         SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits] w
GROUP BY w.[DepositGroup]

---Task 06
  SELECT w.[DepositGroup],
         SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits] w
   WHERE [MagicWandCreator] = 'Ollivander family'
GROUP BY w.[DepositGroup]

---Task 07
  SELECT w.[DepositGroup],
         SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits] w
   WHERE [MagicWandCreator] = 'Ollivander family'
GROUP BY w.[DepositGroup]
  HAVING SUM([DepositAmount]) < 150000
ORDER BY [TotalSum] DESC 

---Task 08
    SELECT w.[DepositGroup],
           w.[MagicWandCreator],
           MIN(w.[DepositCharge]) AS [MinDepositCharge]
      FROM [WizzardDeposits] w
  GROUP BY w.[DepositGroup], w.[MagicWandCreator]
  ORDER BY w.[MagicWandCreator]
  
  ---Task 10
  SELECT DISTINCT LEFT(w.[FirstName], 1) AS [FirstLetter]
  FROM [WizzardDeposits] w
  WHERE w.[DepositGroup] = 'Troll Chest'
  GROUP BY LEFT(w.[FirstName], 1)
  ORDER BY [FirstLetter]
  
---Task 12
SELECT SUM(Guest.[DepositAmount] - wd.[DepositAmount] ) AS [SumDifference]
 FROM [WizzardDeposits] wd 
 JOIN [WizzardDeposits] Guest ON Guest.[Id] + 1 = wd.[Id]
 
---Task 13
USE [SoftUni]
GO

  SELECT [DepartmentID],
         SUM([Salary]) AS [TotalSalary]
    FROM [Employees] 
GROUP BY [DepartmentID] 
ORDER BY [DepartmentID]

---Task 16
  SELECT [DepartmentID],
         MAX([Salary]) AS [MaxSalary]
    FROM [Employees] 
GROUP BY [DepartmentID]
  HAVING MAX([Salary]) NOT BETWEEN 30000 AND 70000
  
---Task 17
  SELECT COUNT(*) AS [Count]
    FROM [Employees] 
   WHERE [ManagerID] IS NULL

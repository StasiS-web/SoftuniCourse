USE [Gringotts]
GO

---Task 01: Records’ Count
--Solution1
SELECT COUNT(*) AS [Count]
  FROM [WizzardDeposits]
---Solution2
SELECT COUNT([Id]) AS [Count]
  FROM [WizzardDeposits]
  
---Task 02: Longest Magic Wand
SELECT MAX([MagicWandSize]) AS [LongestMagicWand]
  FROM [WizzardDeposits]
  
---Task 03: Longest Magic Wand per Deposit Groups
  SELECT w.[DepositGroup],
         MAX(w.[MagicWandSize]) AS [LongestMagicWand]
    FROM [WizzardDeposits] w
GROUP BY w.[DepositGroup]

---Task 04: Smallest Deposit Group per Magic Wand Size  
 SELECT TOP(2) w.[DepositGroup]
    FROM [WizzardDeposits] w
GROUP BY w.[DepositGroup]
ORDER BY AVG(w.[MagicWandSize]) 

---Task 05: Deposits Sum
  SELECT w.[DepositGroup],
         SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits] w
GROUP BY w.[DepositGroup]

---Task 06: Deposits Sum for Ollivander Family
  SELECT w.[DepositGroup],
         SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits] w
   WHERE [MagicWandCreator] = 'Ollivander family'
GROUP BY w.[DepositGroup]

---Task 07: Deposits Filter
  SELECT w.[DepositGroup],
         SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits] w
   WHERE [MagicWandCreator] = 'Ollivander family'
GROUP BY w.[DepositGroup]
  HAVING SUM([DepositAmount]) < 150000
ORDER BY [TotalSum] DESC 

---Task 08: Deposit Charge
    SELECT w.[DepositGroup],
           w.[MagicWandCreator],
           MIN(w.[DepositCharge]) AS [MinDepositCharge]
      FROM [WizzardDeposits] w
  GROUP BY w.[DepositGroup], w.[MagicWandCreator]
  ORDER BY w.[MagicWandCreator]
  
 ---Task 09: Age Groups
 SELECT ut.[AgeGroup], COUNT(ut.[AgeGroup]) AS 'Count'
  FROM (
            SELECT 
                  CASE 
                      WHEN [Age] BETWEEN 0 AND 10 THEN '[0-10]'
                      WHEN [Age] BETWEEN 11 AND 20 THEN '[11-20]'
                      WHEN [Age] BETWEEN 21 AND 30 THEN '[21-30]'
                      WHEN [Age] BETWEEN 31 AND 40 THEN '[31-40]'
                      WHEN [Age] BETWEEN 41 AND 50 THEN '[41-50]'
                      WHEN [Age] BETWEEN 51 AND 60 THEN '[51-60]'
                      ELSE '[61+]'
                  END AS [AgeGroup]
              FROM [WizzardDeposits] w
       ) AS ut
  GROUP BY ut.[AgeGroup]
  
 ---Task 10: First Letter
  SELECT DISTINCT LEFT(w.[FirstName], 1) AS [FirstLetter]
  FROM [WizzardDeposits] w
  WHERE w.[DepositGroup] = 'Troll Chest'
  GROUP BY LEFT(w.[FirstName], 1)
  ORDER BY [FirstLetter]
  
---Task 12: Rich Wizard, Poor Wizard
SELECT SUM(Guest.[DepositAmount] - wd.[DepositAmount] ) AS [SumDifference]
 FROM [WizzardDeposits] wd 
 JOIN [WizzardDeposits] Guest ON Guest.[Id] + 1 = wd.[Id]
 
---Task 13: Departments Total Salaries
USE [SoftUni]
GO

  SELECT [DepartmentID],
         SUM([Salary]) AS [TotalSalary]
    FROM [Employees] 
GROUP BY [DepartmentID] 
ORDER BY [DepartmentID]

---Task 16: Employees Maximum Salaries
  SELECT [DepartmentID],
         MAX([Salary]) AS [MaxSalary]
    FROM [Employees] 
GROUP BY [DepartmentID]
  HAVING MAX([Salary]) NOT BETWEEN 30000 AND 70000
  
---Task 17: Employees Count Salaries
  SELECT COUNT(*) AS [Count]
    FROM [Employees] 
   WHERE [ManagerID] IS NULL

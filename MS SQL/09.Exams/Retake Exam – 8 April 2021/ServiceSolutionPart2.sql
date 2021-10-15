USE [Service]
GO

---Task 05: Unassigned Reports
   SELECT r.[Description], 
          FORMAT(r.[OpenDate], 'dd-MM-yyyy') AS [OpenDate]
     FROM [Reports] r
    WHERE r.[EmployeeId] IS NULL 
 ORDER BY r.[OpenDate], r.[Description]
 
---Task 06: Reports & Categories
    SELECT r.[Description], 
           c.[Name] AS [GategoryName]
      FROM [Reports] r
INNER JOIN [Categories] c ON r.[CategoryId] = c.[Id]
  ORDER BY r.[Description], c.[Name] 
  
---Task 07: Most Reported Category
    SELECT TOP(5) c.[Name] AS [GategoryName],
                  COUNT(c.[Id]) AS [ReportsNumber]
            FROM  [Categories] c 
      INNER JOIN [Reports] r ON c.[Id] = r.[CategoryId]
        GROUP BY c.[Name] 
        ORDER BY [ReportsNumber] DESC, [GategoryName]
        
---Task 08: Birthday Report
     SELECT u.[Username],
            c.[Name] AS [GategoryName]
       FROM [Users] u
 INNER JOIN [Reports] r ON u.[Id] = r.[UserId]
 INNER JOIN [Categories] c ON r.[CategoryId] = c.[Id]
      WHERE MONTH(u.[Birthdate]) = MONTH(r.[OpenDate]) AND 
            DAY(u.[Birthdate]) = DAY(r.[OpenDate])
   ORDER BY u.[Username], [GategoryName]
    
   ---Task 09: User per Employee
      SELECT CONCAT(e.[FirstName], ' ', e.[LastName]) AS [FullName],
             COUNT(r.[UserId]) AS [UsersCount]
        FROM [Employees] e 
   LEFT JOIN [Reports] r ON e.[Id]  = r.[EmployeeId]
    GROUP BY e.[FirstName], e.[LastName]
    ORDER BY [UsersCount] DESC, [FullName]
    
---Task 10: Full Info
SELECT 
     CASE 
          WHEN e.[FirstName] IS NULL THEN 'None'
          ELSE CONCAT(e.[FirstName], ' ', e.[LastName])
     END AS [Employees],
     
     CASE 
        WHEN d.[Name] IS NULL THEN 'None'
        ELSE D.[Name]
    END AS [Department],
    
       c.[Name] AS [Category],
       r.[Description],
       FORMAT(r.[OpenDate], 'dd.MM.yyyy') AS [OpenDate], 
       s.[Label] AS [Status],
       u.[Name] AS [User]
FROM [Reports] r 
LEFT JOIN [Employees] e ON r.[EmployeeId] = e.[Id]
LEFT JOIN [Departments] d ON e.[DepartmentId] = d.[Id]
LEFT JOIN [Categories] c ON r.[CategoryId] = c.[Id]
JOIN [Status] s ON r.[StatusId] = s.[Id]
LEFT JOIN [Users] u ON r.[UserId] = u.[Id]
ORDER BY e.[FirstName] DESC, e.[LastName] DESC, [Department], [Category], [Description], [OpenDate], [Status], [User]
   
---Task 11
CREATE FUNCTION udf_HoursToComplete(@StartDate DATETIME, @EndDate DATETIME) 
RETURNS INT
AS 
BEGIN 
     IF (@StartDate IS NULL)
       BEGIN 
           RETURN 0;
       END
       
     IF (@EndDate IS NULL) 
        BEGIN 
            RETURN 0;
        END
    RETURN DATEDIFF(HOUR, @StartDate, @EndDate)
END
GO
 

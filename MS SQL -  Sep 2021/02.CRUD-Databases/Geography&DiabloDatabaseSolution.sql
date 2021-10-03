--- Task 22
USE [Geography]
GO

SELECT [PeakName] FROM [Peaks]
ORDER BY [PeakName] ASC 

--- Task 23 
SELECT TOP(30) [CountryName], [Population] FROM [Countries]
WHERE [ContinentCode] = 'EU'
ORDER BY [Population] DESC, [CountryName]

--- Task 24
SELECT [CountryName], [CountryCode],
(
        CASE 
          WHEN [CurrensyCode] = 'EUR' THEN'Euro'
          ELSE 'Not Euro'
        END
) AS [Currency]
FROM [Countries]
ORDER BY [CountryName] ASC 

--- Task 25
USE [Diablo]
GO

SELECT [Name] FROM [Characters]
ORDER BY [Name] ASC

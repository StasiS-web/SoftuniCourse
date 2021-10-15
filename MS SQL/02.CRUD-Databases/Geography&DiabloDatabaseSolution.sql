---Task 22: All Mountain Peaks
USE [Geography]
GO

SELECT [PeakName] FROM [Peaks]
ORDER BY [PeakName] ASC 

---Task 23: Biggest Countries by Population 
SELECT TOP(30) [CountryName], [Population] FROM [Countries]
WHERE [ContinentCode] = 'EU'
ORDER BY [Population] DESC, [CountryName]

---Task 24: Countries and Currency (Euro / Not Euro) 
SELECT [CountryName], [CountryCode],
(
        CASE 
          WHEN [CurrensyCode] = 'EUR' THEN'Euro'
          ELSE 'Not Euro'
        END
) AS [Currency]
FROM [Countries]
ORDER BY [CountryName] ASC 

---Task 25: All Diablo Characters
USE [Diablo]
GO

SELECT [Name] FROM [Characters]
ORDER BY [Name] ASC

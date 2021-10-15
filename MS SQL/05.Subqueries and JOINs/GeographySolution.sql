USE [Geography]
GO

---Task 12: Highest Peaks in Bulgaria
SELECT mc.[CountryCode],
       m.[MountainRange],
       p.[PeakName],
       p.[Elevation]
  FROM [MountainsCountries] AS mc
  LEFT JOIN [Mountains] AS m ON mc.[MountainId] = m.[Id]
  LEFT JOIN [Peaks] AS p ON m.[Id] = p.[MountainId]
  WHERE mc.[CountryCode] = 'BG' AND p.[Elevation] > 2835
  ORDER BY p.[Elevation] DESC 
  
---Task 13: Count Mountain Ranges
SELECT mc.[CountryCode],
       COUNT(*) AS [MountainRanges]
 FROM [MountainsCountries] AS mc
 INNER JOIN [Mountains] AS m ON mc.[MountainId] = m.[Id]
WHERE mc.[CountryCode] = 'BG' OR mc.[CountryCode] = 'RU' OR mc.[CountryCode] = 'US'
GROUP BY  mc.[CountryCode]

---Task 14: Countries With or Without Rivers
SELECT TOP(5) c.[CountryName],
              r.[RiverName]
  FROM [Countries] AS c 
  LEFT JOIN [CountriesRivers] AS cr ON c.[CountryCode] = cr.[CountryCode]
  LEFT JOIN [Rivers] AS r ON cr.[RiverId] = r.[Id] 
  WHERE c.[ContinentCode] = 'AF'
  ORDER BY c.[CountryName] ASC 
  
---Task 16: Countries Without Any Mountains
 SELECT 
         COUNT(*) AS [CountryCode]
  FROM [Countries] AS c 
  LEFT JOIN [MountainsCountries] AS mc ON c.[CountryCode] = mc.[CountryCode]
  WHERE mc.[CountryCode] IS NULL

     
  

USE [Diablo]

GO

---Task 01: Number of Users for Email Provider
SELECT RIGHT([Email], LEN([Email]) - CHARINDEX('@', [Email])) AS [Email Provider],
       COUNT([Id]) AS [Number Of Users]
FROM [Users] 
GROUP BY RIGHT([Email], LEN([Email]) - CHARINDEX('@', [Email]))
ORDER BY [Number Of Users] DESC, [Email Provider]

---Task 02: All User in Games
    SELECT g.[Name] AS [Game],
           gt.[Name] AS [Game Type],
           u.[Username],
           ug.[Level],
           ug.[Cash],
           c.[Name] AS [Character]
      FROM [Games] g
INNER JOIN [UsersGames] ug ON g.[Id] = ug.[GameId]
INNER JOIN [GameTypes] gt ON g.[GameTypeId] = gt.[Id]
INNER JOIN [Users] u ON ug.[UserId] = u.[Id]
INNER JOIN [Characters] c ON ug.[CharacterId]  = c.[Id]
ORDER BY ug.[Level] DESC,  u.[Username], [Game]

---Task 03: Users in Games with Their Items
      SELECT u.[Username],
             g.[Name] AS [Game],
             COUNT(i.[Name]) AS [Items Count],
             ISNULL(SUM(i.[Price]), 0) AS [Items Price]
        FROM [UsersGames] ug
  INNER JOIN [Users] u ON u.[Id] = ug.[UserId]
  INNER JOIN [Games] g ON g.[Id] = ug.[GameId] 
  INNER JOIN [UserGameItems] ugi ON ugi.[UserGameId] = ug.[Id]
  INNER JOIN [Items] i ON i.[Id] = ugi.[ItemId] 
    GROUP BY u.[Username], g.[Name]
      HAVING COUNT(i.[Name]) >= 10
    ORDER BY [Items Count] DESC,  [Items Price] DESC, u.[Username]
    
---Task 06: Display All Items about Forbidden Game Type
   SELECT  i.[Name] as [Item],
           i.[Price],
           i.[MinLevel],
           gt.[Name] AS [Forbidden Game Type]
      FROM [Items] AS i 
 LEFT JOIN [GameTypeForbiddenItems] gtfi ON gtfi.[ItemId] = i.[Id]
 LEFT JOIN [GameTypes] gt ON gt.[Id] = gtfi.[GameTypeId]
  ORDER BY [Forbidden Game Type] DESC, [Item]
  
--- Task 08: Peaks and Mountains
  USE [Geography]
  GO 
  
       SELECT p.[PeakName],
              m.[MountainRange] AS [Mountain],
              p.[Elevation]
         FROM [Peaks] p
   INNER JOIN [Mountains] m ON p.[MountainId] = m.[Id]
     ORDER BY p.[Elevation] DESC, p.[PeakName]
   
---Task 09: Peaks with Mountain, Country and Continent
    SELECT p.[PeakName],
           m.[MountainRange] AS [Mountain],
           c.[CountryName],
           ct.[ContinentName]
      FROM [Peaks] p
INNER JOIN [Mountains] m ON p.[MountainId] = m.[Id]
INNER JOIN [MountainsCountries] mc ON m.[Id] = mc.[MountainId]
INNER JOIN [Countries] c ON mc.[CountryCode] = c.[CountryCode]
INNER JOIN [Continents] ct ON  c.[ContinentCode] = ct.[ContinentCode]
ORDER BY p.[PeakName],  c.[CountryName]

---Task 10: Rivers by Country
    SELECT c.[CountryName],
           ct.[ContinentName],
           ISNULL(COUNT(r.[Id]), 0) AS [RiversCount],
           ISNULL(SUM(r.[Length]), 0) AS [TotalLength]
      FROM [Countries] c
INNER JOIN [Continents] ct ON c.[ContinentCode] = ct.[ContinentCode]
 LEFT JOIN [CountriesRivers] cr ON c.[CountryCode] = cr.[CountryCode] 
 LEFT JOIN [Rivers] r ON r.[Id] = cr.[RiverId] 
  GROUP BY c.[CountryName], ct.[ContinentName]
  ORDER BY [RiversCount] DESC, [TotalLength] DESC, c.[CountryName]
  
  ---Task 11: Count of Countries by Currency
  SELECT cu.[CurrencyCode]  AS [CurrencyCode],
         cu.[Description] AS [Currency],
         COUNT(ct.[CurrencyCode]) AS [NumberOfCountries]
    FROM [Currencies] cu
 LEFT JOIN [Countries] ct ON cu.[CurrencyCode] = ct.[CurrencyCode]
 GROUP BY cu.[CurrencyCode], cu.[Description]
 ORDER BY [NumberOfCountries] DESC, cu.[Description]
 
 ---Task 12: Population and Area by Continent
     SELECT ct.[ContinentName],
            SUM(CAST((c.[AreaInSqKm]) AS BIGINT)) AS [CountriesArea],
            SUM(CAST((c.[Population]) AS BIGINT)) AS [CountriesPopulation]
       FROM [Continents] ct
  LEFT JOIN [Countries] c ON ct.[ContinentCode] = c.[ContinentCode]
   GROUP BY ct.[ContinentName]
   ORDER BY [CountriesPopulation] DESC

---Task 13: Monasteries by Country
CREATE TABLE [Monasteries] 
(
   [Id] INT PRIMARY KEY IDENTITY,
   [Name] VARCHAR(100) NOT NULL, 
   [CountryCode] CHAR(2) NOT NULL
)

INSERT INTO [Monasteries]([Name], [CountryCode]) 
VALUES ('Rila Monastery “St. Ivan of Rila”', 'BG'), 
       ('Bachkovo Monastery “Virgin Mary”', 'BG'),
       ('Troyan Monastery “Holy Mother''s Assumption”', 'BG'),
       ('Kopan Monastery', 'NP'),
       ('Thrangu Tashi Yangtse Monastery', 'NP'),
       ('Shechen Tennyi Dargyeling Monastery', 'NP'),
       ('Benchen Monastery', 'NP'),
       ('Southern Shaolin Monastery', 'CN'),
       ('Dabei Monastery', 'CN'),
       ('Wa Sau Toi', 'CN'),
       ('Lhunshigyia Monastery', 'CN'),
       ('Rakya Monastery', 'CN'),
       ('Monasteries of Meteora', 'GR'),
       ('The Holy Monastery of Stavronikita', 'GR'),
       ('Taung Kalat Monastery', 'MM'),
       ('Pa-Auk Forest Monastery', 'MM'),
       ('Taktsang Palphug Monastery', 'BT'),
       ('Sümela Monastery', 'TR')
       
ALTER TABLE [Countries]
      ADD [IsDeleted] BIT DEFAULT 0
      
UPDATE [Countries]
SET [IsDeleted] = 1
WHERE [CountryCode] IN
        (SELECT Q1.[CountryCode]
         FROM (SELECT c.[CountryCode],
                      COUNT(cr.[RiverId]) AS [Count]
                 FROM [Countries] c
                      INNER JOIN [CountriesRivers] cr ON c.[CountryCode] = cr.[CountryCode]
                GROUP BY c.[CountryCode]) AS [Q1]
         WHERE Q1.COUNT > 3)
         
SELECT m.[Name] AS [Monastery],
       c.[CountryName] AS [Country]
  FROM [Monasteries] m 
  JOIN [Countries] c ON m.[CountryCode] = c.[CountryCode]
  WHERE c.[IsDeleted] = 0
  ORDER BY [Monastery]
  
---Task 14: Monasteries by Continents and Countries
UPDATE [Countries]
SET [CountryName] = 'Burma'
WHERE [CountryName] = 'Myanmar'

INSERT INTO [Monasteries]([Name], [CountryCode])
VALUES ('Hanga Abbey', (SELECT [Countries].[CountryCode]
                          FROM [Countries]
                         WHERE [CountryName] = 'Tanzania')
                         
INSERT INTO [Monasteries]([Name], [CountryCode])
VALUES ('Myin-Tin-Daik', (SELECT [Countries].[CountryCode]
                          FROM [Countries]
                         WHERE [CountryName] = 'Myanmar')
                         
SELECT ct.[ContinentName],
        c.[CountryName],
        ISNULL(COUNT(m.[Id]), 0) AS [MonasteriesCount]
 FROM [Continents] ct 
 INNER JOIN [Countries] c ON ct.[ContinentCode] = c.[ContinentCode] AND c.[IsDeleted] = 0
 LEFT JOIN [Monasteries] m ON  c.[CountryCode] = m.[CountryCode]
 GROUP BY ct.[ContinentName], c.[CountryName]
 ORDER BY [MonasteriesCount] DESC, c.[CountryName]
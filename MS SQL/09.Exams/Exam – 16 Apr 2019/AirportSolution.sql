CREATE DATABASE [Airport]

USE [Airport]
GO

---Task 01: DDL
CREATE TABLE [Planes] (
   [Id] INT PRIMARY KEY IDENTITY,
   [Name] VARCHAR(30) NOT NULL,
   [Seats] INT NOT NULL,
   [Range] INT NOT NULL
)

CREATE TABLE [Flights] (
   [Id] INT PRIMARY KEY IDENTITY,
   [DepartureTime] DATETIME,
   [ArrivalTime] DATETIME,
   [Origin] VARCHAR(50) NOT NULL,
   [Destination] VARCHAR(50) NOT NULL,
   [PlaneId] INT NOT NULL FOREIGN KEY REFERENCES [Planes]([Id])
)

CREATE TABLE [Passengers](
   [Id] INT PRIMARY KEY IDENTITY,
   [FirstName] NVARCHAR(30) NOT NULL,
   [LastName] NVARCHAR(30) NOT NULL,
   [Age] INT NOT NULL,
   [Address] VARCHAR(30) NOT NULL,
   [PassportId] CHAR(11) NOT NULL
)

CREATE TABLE [LuggageTypes](
     [Id] INT PRIMARY KEY IDENTITY,
     [Type] VARCHAR(30) NOT NULL
)

CREATE TABLE [Luggages](
    [Id] INT PRIMARY KEY IDENTITY,
    [LuggageTypeId] INT NOT NULL FOREIGN KEY REFERENCES [LuggageTypes]([Id]),
    [PassengerId] INT NOT NULL FOREIGN KEY REFERENCES [Passengers]([Id])
)

CREATE TABLE [Tickets](
    [Id] INT PRIMARY KEY IDENTITY,
    [PassengerId] INT NOT NULL FOREIGN KEY REFERENCES [Passengers]([Id]),
    [FlightId] INT NOT NULL FOREIGN KEY REFERENCES [Flights]([Id]),
    [LuggageId] INT NOT NULL FOREIGN KEY REFERENCES [Luggages]([Id]),
    [Price] DECIMAL(15,2) NOT NULL
)

---Task 02: Insert
INSERT INTO [Planes] ([Name], [Seats], [Range])
     VALUES ('Airbus 336', 112, 5132),
            ('Airbus 330', 432, 5325),
            ('Boeing 369', 231, 2355),
            ('Stelt 297', 254, 2143),
            ('Boeing 338', 165, 5111),
            ('Airbus 558', 387, 1342),
            ('Boeing 128', 345, 5541)
            
INSERT INTO [LuggageTypes]([Type])
     VALUES ('Crossbody Bag'), 
            ('School Backpack'), 
            ('Shoulder Bag')

---Task 03: Update
UPDATE [Tickets]
SET [Price] *=  1.13
WHERE [FlightId] = (
     SELECT [Id] FROM [Flights] WHERE [Destination] = 'Carlsbad'
)

---Task 04: Delete
DELETE FROM [Tickets]
WHERE [FlightId] = (
      SELECT TOP(1) [Id] FROM [Flights] WHERE [Destination] = 'Ayn Halagim'
)

DELETE FROM [Flights]
WHERE [Destination] = 'Ayn Halagim'

---Task 05: The "Tr" Planes
SELECT * FROM [Planes]
WHERE [Name] LIKE '%tr%'
ORDER BY [Id], [Name], [Seats], [Range] 

---Task 06: Flight Profits 
SELECT [FlightId],
       SUM([Price]) AS [TotalPrice]
  FROM [Tickets] 
  GROUP BY [FlightId]
  ORDER BY [TotalPrice] DESC, [FlightId]

---Task 07: Passenger Trips
SELECT CONCAT(p.[FirstName], ' ', p.[LastName]) AS [Full Name],
       f.[Origin],
       f.[Destination]
  FROM [Tickets] t 
INNER JOIN [Passengers] p ON t.[PassengerId] = p.[Id]
INNER JOIN [Flights] f ON t.[FlightId] = f.[Id]
ORDER BY [Full Name], [Origin], [Destination]

---Task 08: Non Adventures People 
SELECT p.[FirstName],
       p.[LastName],
       p.[Age]
  FROM [Passengers] p
LEFT JOIN [Tickets] t ON t.[PassengerId] = p.[Id]
WHERE t.[Id] is NULL 
ORDER BY [Age] DESC, p.[FirstName], p.[LastName]

---Task 09: Full Info 
SELECT CONCAT(p.[FirstName], ' ', p.[LastName]) AS [Full Name],
       pl.[Name] AS [Plane Name], 
       CONCAT(f.[Origin], ' - ', f.[Destination]) AS [Trip],
       lt.[Type] AS [Luggage Type]
FROM [Tickets] t
LEFT JOIN [Passengers] p ON t.[PassengerId] = p.[Id]
LEFT JOIN [Flights] f ON t.[FlightId] = f.[Id]
LEFT JOIN [Luggages] l ON t.[LuggageId] = l.[Id]
LEFT JOIN [LuggageTypes] lt ON l.[LuggageTypeId] = lt.[Id] 
LEFT JOIN [Planes] pl ON f.[PlaneId] = pl.[Id]
ORDER BY [Full Name], [Plane Name], [Trip], [Luggage Type]

---Task 10: PSP
SELECT pl.[Name],
       pl.[Seats],
       COUNT(t.[Id]) AS [Passengers Count]
FROM [Planes] pl
LEFT JOIN [Flights] f ON f.[PlaneId] = pl.[Id]
LEFT JOIN [Tickets] t ON t.[FlightId] = f.[Id]
GROUP BY pl.[Id], pl.[Name], pl.[Seats]
ORDER BY [PassengerS Count] DESC, [Name], [Seats]

---Task 11: Vacation
CREATE FUNCTION udf_CalculateTickets(@origin VARCHAR(50), @destination VARCHAR(50), @peopleCount INT)
RETURNS VARCHAR(50)
AS 
BEGIN 
    IF (@peopleCount <= 0) RETURN 'Invalid people count!'
    IF ((SELECT TOP(1) [Id] FROM [Flights] WHERE [Origin] = @origin AND [Destination] = @destination) IS NULL)
       RETURN 'Invalid flight!'
    RETURN CONCAT('Total price ',
    (SELECT TOP(1) t.[Price] FROM [Tickets] AS t 
     JOIN [Flights] AS f ON t.[FlightId] = f.[Id]
     WHERE f.[Origin] = @origin AND f.[Destination] = @destination) * @peopleCount)
END
   
SELECT dbo.udf_CalculateTickets('Kolyshley','Rancabolang', 33)
SELECT dbo.udf_CalculateTickets('Kolyshley','Rancabolang', -1)
SELECT dbo.udf_CalculateTickets('Invalid','Rancabolang', 33)
  
---Task 12: Wrong Data
CREATE PROCEDURE usp_CancelFlights AS 
UPDATE [Flights] 
SET [DepartureTime] = NULL, [ArrivalTime] = NULL
WHERE [ArrivalTime] > [DepartureTime] 

EXEC usp_CancelFlights 


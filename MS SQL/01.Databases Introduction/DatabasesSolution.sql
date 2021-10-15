CREATE DATABASE [Databases]

---Task 14: Car Rental Database
CREATE TABLE [Categories] (
    [Id] INT PRIMARY KEY IDENTITY, 
    [CategoryName] NVARCHAR(50) NOT NULL, 
    [DailyRate] FLOAT(2), 
    [WeeklyRate] FLOAT(2), 
    [MonthlyRate] FLOAT(2), 
    [WeekendRate] FLOAT(2)
 )

 CREATE TABLE [Cars] (
     [Id] INT PRIMARY KEY IDENTITY, 
     [PlateNumber] NVARCHAR(10) NOT NULL, 
     [Manufacturer] NVARCHAR(20) NOT NULL, 
     [Model] NVARCHAR(20) NOT NULL, 
     [CarYear] INT NOT NULL, 
     [CategoryId] INT FOREIGN KEY REFERENCES [Categories](Id) NOT NULL, 
     [Doors] INT NOT NULL, 
     [Picture] VARBINARY(MAX), 
     [Condition] NVARCHAR(MAX),
     [Available] BIT
 )  

 CREATE TABLE [Employees] (
     [Id] INT PRIMARY KEY IDENTITY, 
     [FirstName] NVARCHAR(50) NOT NULL, 
     [LastName] NVARCHAR(50) NOT NULL, 
     [Title] NVARCHAR(50) NOT NULL, 
     [Notes] NVARCHAR(MAX)
 )

 CREATE TABLE [Customers] (
     [Id] INT PRIMARY KEY IDENTITY, 
     [DriverLicenceNumber] INT NOT NULL, 
     [FullName] NVARCHAR(150) NOT NULL, 
     [Address] NVARCHAR(100) NOT NULL, 
     [City] NVARCHAR(50), 
     [ZIPCode] INT NOT NULL, 
     [Notes] NVARCHAR(MAX)
 )

 CREATE TABLE [RentalOrders](
     [Id] INT PRIMARY KEY IDENTITY, 
     [EmployeeId] INT NOT NULL, 
     [CustomerId] INT NOT NULL, 
     [CarId] INT FOREIGN KEY REFERENCES [Cars](Id) NOT NULL, 
     [TankLevel] INT NOT NULL, 
     [KilometrageStart] INT NOT NULL, 
     [KilometrageEnd] INT NOT NULL, 
     [TotalKilometrage] AS [KilometrageEnd] - [KilometrageStart], 
     [StartDate] DATE NOT NULL, 
     [EndDate] DATE NOT NULL, 
     [TotalDays] AS DATEDIFF(DAY,[StartDate], [EndDate]), 
     [RateApplied] DECIMAL(9, 2), 
     [TaxRate] DECIMAL(9, 2), 
     [OrderStatus] NVARCHAR(50), 
     [Notes] NVARCHAR(MAX)

      CONSTRAINT FK_RentalOrders_Employees
     FOREIGN KEY ([EmployeeId])
      REFERENCES [Employees](Id),

      CONSTRAINT FK_RentalOrders_Customers
     FOREIGN KEY (CustomerId)
      REFERENCES [Customers](Id)
 )

INSERT INTO [Categories] ([CategoryName], [DailyRate], [WeeklyRate], [MonthlyRate], [WeekendRate])
VALUES ('Car', 30, 120.5, 500, 52.60),
       ('Bus', 230, 1200, 6000, 489.60),
       ('Van', 500, 1800, 1000, 110.90)

INSERT INTO [Cars] ([PlateNumber], [Manufacturer], [Model], [CarYear], [CategoryId], [Doors], [Picture], [Condition], [Available])
VALUES ('CA127823CD', 'Mercedes', 'GLB', 2016, 1, 5, 123456,'Perfect', 1),
       ('PF129734SD', 'Nissan', 'LEAF', 2018, 3, 2, 345534,'Perfect', 1),
       ('CP239745FA', 'BMW', 'iX3', 2017, 2, 3, 223453,'Perfect', 1)

INSERT INTO [Employees] ([FirstName], [LastName], [Title], [Notes])
VALUES ('Ivan', 'Petrov', 'Seller', 'I need to update my client list'),
       ('John', 'Smith', 'Seller', 'I need to update my client list'),
       ('Alex', 'Cooper', 'Manager', 'I need to update my client list')

INSERT INTO [Customers]([DriverLicenceNumber], [FullName], [Address], [City], [ZIPCode], [Notes])
VALUES ('123455756', 'Georgie Georgiev', '1 fhialkda dssd', 'Sofia', '1612', 'Good Driver'),
       ('123434345', 'Marko Radinov', '23 djfjfk[ njjff', 'Plovdiv', '1234', 'Bad Driver'),
       ('123413434', 'Sara Scott', '3 kdkdkdl kkck', 'Sofia', '1000', 'Good Driver')

INSERT INTO [RentalOrders] ([EmployeeId], [CustomerId], [CarId], [TankLevel], [KilometrageStart], [KilometrageEnd], [StartDate], [EndDate])
VALUES (1, 1, 1, 43, 2134, 2634, '2017-12-05', '2017-12-08'),
       (2, 2, 3, 23, 2344, 2545, '2017-12-05', '2017-12-08'),
       (3, 3, 3, 146, 2456, 2678, '2017-12-05', '2017-12-08')

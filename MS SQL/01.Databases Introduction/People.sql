-- Create Database
CREATE DATABASE [People]

USE [People]
GO

--- Task 07: Create People Table
CREATE TABLE [People](
    [ID] BIGINT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(200) NOT NULL,
    [Picture] VARBINARY(MAX) CHECK(DATALENGTH (Picture) <= 2000000),
    [Height] FLOAT(2),
    [Weight] FLOAT(2),
    [Gender] CHAR(1) CONSTRAINT letter check([Gender] in ('f', 'm') )NOT NULL,
    [Birthdate] DATE NOT NULL,
    [Biography] NVARCHAR(MAX)
)

INSERT INTO [People] ([Name], [Gender], [Birthdate], [Biography]) 
VALUES ('John Smith', 'm', GETDATE(), 'Driver'),
       ('Ivan Velchev', 'm', GETDATE(), 'Pilot'),
       ('Pesho Petrov', 'm', GETDATE(), NULL),
       ('Sue Clark','f', GETDATE(), 'Doctor'),
       ('Ann Pavlova', 'f', GETDATE(), 'Worker')

--- Create Users Table
CREATE TABLE [Users](
    [ID] BIGINT PRIMARY KEY IDENTITY,
    [Username] VARCHAR(30) UNIQUE NOT NULL,
    [Password] VARCHAR(26) NOT NULL, 
    [ProfilePicture] VARBINARY(MAX) CHECK(DATALENGTH (ProfilePicture) <= 900000),
    [LastLoginTime] DATETIME2 NOT NULL,
    [IsDeleted] BIT NOT NULL
)

INSERT INTO [Users]([Username], [Password], [LastLoginTime], [ProfilePicture], [IsDeleted])
VALUES ('John', '12243454', '2020-09-10', 35.4, 0),
       ('Sue', '14454336', '2020-09-10', 35.4, 1),
       ('Sara', '13424567', '2020-09-10', 35.4, 0),
       ('Bob', '12423456', '2020-09-10', 35.4, 2),
       ('Sam', '12334566', '2020-09-10', 35.4, 0)

    ALTER TABLE [Users]
DROP CONSTRAINT [PK_Users_3214EC274AC232D3]

   ALTER TABLE [Users]
ADD CONSTRAINT [PK_UsersCompositeIDUsername] PRIMARY KEY ([ID], [Username])

--- Create Movies Database
CREATE TABLE [Directors](
    [ID] INT PRIMARY KEY IDENTITY,
    [DirectorName] NVARCHAR(50) NOT NULL,
    [Notes] NVARCHAR (MAX) 
)

CREATE TABLE [Genres](
    [ID] INT PRIMARY KEY IDENTITY,
    [GenresName] NVARCHAR(50) NOT NULL,
    [Notes] NVARCHAR (MAX) 
)

CREATE TABLE [Categories](
    [ID] INT PRIMARY KEY IDENTITY,
    [CategoriesName] NVARCHAR(50) NOT NULL,
    [Notes] NVARCHAR (MAX) 
)

CREATE TABLE [Movies](
     [ID] INT PRIMARY KEY IDENTITY,
     [Title] NVARCHAR(50) NOT NULL,
     [DirectorId] INT FOREIGN KEY REFERENCES [Directors]([ID]),
     [CopyrightYear] DATETIME2 NOT NULL,
     [Length] TIME NOT NULL,
     [GenreId] INT FOREIGN KEY REFERENCES [Genres]([ID]),
     [CategoryId] INT FOREIGN KEY REFERENCES [Categories]([ID]),
     [Rating] TINYINT NOT NULL,
     [Notes] NVARCHAR (MAX) 
)

INSERT INTO [Directors]([DirectorName], [Notes])
VALUES  ('John', 'johnNote'),
        ('Ivan', 'ivanNote'),
        ('Simon', 'simonNote'),
        ('Peter', 'peterNote'),
        ('Susan', 'susanNote')

INSERT INTO [Genres]([GenresName], [Notes])
VALUES ('Adventure', 'johnNote'),
       ('Drama', 'peterNote'),
       ('Comedy', 'susanNote'),
       ('Fantasy', 'simonNote'),
       ('Action', 'ivanNote')

INSERT INTO [Categories]([CategoriesName], [Notes])
VALUES ('Teen', 'johnNote'),
       ('BBC', 'peterNote'),
       ('Family', 'susanNote'),
       ('Kids', 'simonNote'),
       ('Cartoon', 'ivanNote')

INSERT INTO [Movies]([Title], [DirectorId], [CopyrightYear], [Length], [GenreId], [CategoryId], [Rating], [Notes])
VALUES ('The Tomorrow War1', 1, '2005-03-01', '02:10:00', 1, 1, '5', 'Awesome'),
       ('The Tomorrow War2', 2, '2005-03-02', '02:20:00', 2, 2, '2', 'Awesome'),
       ('The Tomorrow War3', 3, '2005-03-03', '02:50:00', 5, 5, '1', 'Awesome'),
       ('The Tomorrow War4', 4, '2005-03-04', '02:40:00', 3, 3, '3', 'Awesome'),
       ('The Tomorrow War5', 5, '2005-03-05', '02:30:00', 4, 4, '2', 'Awesome')

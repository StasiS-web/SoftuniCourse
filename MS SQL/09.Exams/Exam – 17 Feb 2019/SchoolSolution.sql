CREATE DATABASE [School]

USE  [School]
GO

---Task 01: DDL
CREATE TABLE [Students]
(
  [Id] INT PRIMARY KEY IDENTITY NOT NULL,
  [FirstName] NVARCHAR(30) NOT NULL,
  [MiddleName] NVARCHAR(25),
  [LastName] NVARCHAR(30) NOT NULL,
  [Age] INT NOT NULL CHECK([Age] > 0),
  [Address] NVARCHAR(50),
  [Phone] NVARCHAR(10)
)

CREATE TABLE [Subjects]
(
  [Id] INT PRIMARY KEY IDENTITY,
  [Name] NVARCHAR(20) NOT NULL,
  [Lessons] INT NOT NULL CHECK([Lessons] > 0)
)

CREATE TABLE [StudentsSubjects]
(
  [Id] INT PRIMARY KEY IDENTITY NOT NULL,
  [StudentId] INT NOT NULL FOREIGN KEY REFERENCES [Students]([Id]),
  [SubjectId] INT NOT NULL FOREIGN KEY REFERENCES [Subjects]([Id]),
  [Grade] DECIMAL(3,2) NOT NULL CHECK([Grade] >= 2 AND [Grade] <= 6)
)

CREATE TABLE [Exams]
(
  [Id] INT PRIMARY KEY IDENTITY NOT NULL,
  [Date] DATETIME2,
  [SubjectId] INT NOT NULL FOREIGN KEY REFERENCES [Subjects]([Id])
)

CREATE TABLE [StudentsExams]
(
  [StudentId] INT NOT NULL FOREIGN KEY REFERENCES [Students]([Id]),
  [ExamId] INT NOT NULL FOREIGN KEY REFERENCES [Exams]([Id]),
  [Grade] DECIMAL(3,2) NOT NULL CHECK([Grade] >= 2 AND [Grade] <= 6),
  PRIMARY KEY ([StudentId], [ExamId])
)

CREATE TABLE [Teachers]
(
   [Id] INT PRIMARY KEY IDENTITY NOT NULL,
   [FirstName] NVARCHAR(20) NOT NULL,
   [LastName] NVARCHAR(20) NOT NULL,
   [Address] NVARCHAR(20) NOT NULL,
   [Phone] CHAR(10),
   [SubjectId] INT NOT NULL FOREIGN KEY REFERENCES [Subjects]([Id])
)

CREATE TABLE [StudentsTeachers]
(
  [StudentId] INT NOT NULL FOREIGN KEY REFERENCES [Students]([Id]),
  [TeacherId] INT NOT NULL FOREIGN KEY REFERENCES [Teachers]([Id]),
  PRIMARY KEY ([StudentId], [TeacherId])
)

---Task 02: Insert
INSERT INTO [Teachers]([FirstName], [LastName], [Address], [Phone], [SubjectId])
VALUES ('Ruthanne', 'Bamb', '84948 Mesta Junction', '3105500146', 6),
       ('Gerrard', 'Lowin', '370 Talisman Plaza', '3324874824', 2),
       ('Merrile', 'Lambdin', '81 Dahle Plaza', '4373065154', 5),
       ('Bert', 'Ivie', '2 Gateway Circle', '4409584510', 4)

INSERT INTO [Subjects]([Name], [Lessons])
VALUES ('Geometry', 12),
       ('Health', 10),
       ('Drama', 7),
       ('Sports', 9)

---Task 03: Update
UPDATE [StudentsSubjects]
   SET [Grade] = 6.00 
 WHERE [Grade] >= 5.50 AND [SubjectId] IN (1,2) 

---Task 04: DELETE 
DELETE FROM [StudentsTeachers]
   WHERE [TeacherId] IN (SELECT [Id] FROM [Teachers] WHERE [Phone] LIKE '%72%')

     DELETE [Teachers] 
      WHERE [Phone] LIKE '%72%'

---Task 05: Teen Students
   SELECT [FirstName], 
          [LastName], 
          [Age] 
     FROM [Students]
    WHERE [Age] >= 12
 ORDER BY [FirstName], [LastName]
 
---Task 06: Students Teachers
   SELECT s.[FirstName], 
          s.[LastName], 
          COUNT (st.[TeacherId]) AS [TeachersCount]
     FROM [Students] s
     JOIN [StudentsTeachers] st ON s.[Id] = st.[StudentId] 
     GROUP BY s.[FirstName], s.[LastName]
     
---Task 07: Students to Go
    SELECT CONCAT(s.[FirstName], ' ', s.[LastName]) AS [Full Name]
      FROM [Students] s
LEFT JOIN [StudentsExams] se ON s.[Id] = se.[StudentId] 
LEFT JOIN [Exams] e ON se.[ExamId] = e.[Id]
WHERE e.[Id] IS NULL
  ORDER BY [Full Name]
  
---Task 08: Top Students
  SELECT TOP(10) s.[FirstName], 
                 s.[LastName], 
                 FORMAT(AVG(se.[Grade]), 'N2')AS [Grade]
            FROM [Students] s
      INNER JOIN [StudentsExams] se ON s.[Id] = se.[StudentId]
        GROUP BY s.[FirstName], s.[LastName]
        ORDER BY [Grade] DESC, s.[FirstName], s.[LastName]
        
---Task 09: Not So In The Studying
SELECT CONCAT(s.[FirstName], ' ', s.[MiddleName], ' ', s.[LastName]) AS [Full Name]
  FROM [Students] s
LEFT JOIN [StudentsSubjects] ss ON ss.[StudentId] = s.[Id]
LEFT JOIN [Subjects] sb ON  sb.[Id] = ss.[SubjectId] 
    WHERE ss.[SubjectId] IS NULL
 ORDER BY [Full Name]

 ---Task 10: Average Grade per Subject
 SELECT sb.[Name],
        AVG(ss.[Grade]) AS [AverageGrade]
 FROM [Subjects] sb
 INNER JOIN [StudentsSubjects] ss ON sb.[Id] = ss.[SubjectId]
 GROUP BY sb.[Name], sb.[Id]
 ORDER BY sb.[Id]
 
USE [UniversityDatabase]
GO

---Task 6: University Database
 CREATE TABLE [Subjects](
  [SubjectID] INT PRIMARY KEY IDENTITY NOT NULL,
  [SubjectName] VARCHAR(50) NOT NULL
 )
 
 CREATE TABLE [Majors](
  [MajorID] INT PRIMARY KEY IDENTITY NOT NULL,
  [Name] VARCHAR(50) NOT NULL
 )
 
 CREATE TABLE [Students](
  [StudentID] INT PRIMARY KEY IDENTITY NOT NULL,
  [StudentNumber] INT UNIQUE NOT NULL,
  [StudentName] VARCHAR(50) NOT NULL,
  [MajorID] INT FOREIGN KEY REFERENCES [Majors]([MajorID])
  )
  
  CREATE TABLE [Agenda](
   [StudentID] INT FOREIGN KEY REFERENCES [Students]([StudentID]),
   [SubjectID] INT FOREIGN KEY REFERENCES [Subjects]([SubjectID])
   PRIMARY KEY([StudentID], [SubjectID])
  )
  
  CREATE TABLE [Payments](
   [PaymentID] INT PRIMARY KEY IDENTITY NOT NULL,
   [PaymentDate] DATETIME2 NOT NULL,
   [PaymnetAmount] DECIMAL(7,2) NOT NULL,
   [StudentID] INT FOREIGN KEY REFERENCES [Students]([StudentID])
  )
  
USE [Bank]
GO

---Task 01: Create Table Logs
SELECT * FROM [Accounts]
SELECT * FROM [AccountHolders]

CREATE TABLE [Logs]
(
   [LogId] INT PRIMARY KEY IDENTITY NOT NULL,
   [AccountId] INT NOT NULL FOREIGN KEY REFERENCES [Accounts]([Id]),
   [OldSum] DECIMAL (15,2),
   [NewSum] DECIMAL (15,2)
)

SELECT * FROM [Logs]
GO

CREATE TRIGGER tg_OnAccountsLogChangeOfSum 
   ON  [Accounts] 
   FOR UPDATE 
   AS 
   BEGIN 
      INSERT [Logs] ([AccountId], [OldSum], [NewSum])
      SELECT i.[Id], d.[Balance], i.[Balance]
      FROM inserted AS i
        JOIN deleted AS d ON i.[Id] = d.[Id]
     WHERE i.[Balance] != d.[Balance]
END
GO

UPDATE [Accounts]
SET [Balance] += 20
WHERE [Id] = 1

---Task 02: Create Table Emails 
CREATE TABLE [NotificationEmails](
  [Id] INT PRIMARY KEY IDENTITY NOT NULL,
  [Recipient] INT FOREIGN KEY REFERENCES [Accounts]([Id]),
  [Subject] NVARCHAR(MAX),
  [Body] NVARCHAR(MAX),
)

GO

SELECT * FROM [NotificationEmails]
GO 

CREATE TRIGGER tg_AddToNotificationEmailOnLogsUpdate 
ON [Logs] 
FOR INSERT 
AS 
  INSERT INTO [NotificationEmails]([Recipient], [Subject], [Body]) 
  SELECT i.[AccountID],
         'Balance change for account: ' +  CAST(i.[AccountID] AS NVARCHAR(20)),
          'On' + CONVERT(NVARCHAR(30), GETDATE(), 103) + ' your balance was changed from ' + CAST(i.[OLdSum] AS NVARCHAR(20)) + ' to ' + CAST(i.[NewSum] AS  NVARCHAR(20))
   FROM inserted AS i

 GO
 
 EXEC  tg_AddToNotificationEmailOnLogsUpdate  12, 15, 1000
 SELECT * FROM [Logs]
 SELECT * FROM [NotificationEmails]
 
---Task 03: Deposit Money
SELECT * FROM [AccountHolders]
SELECT * FROM [Accounts]

CREATE PROCEDURE usp_DepositMoney (@AccountId INT, @MoneyAmount DECIMAL(18, 4))
AS 
BEGIN TRANSACTION

IF NOT EXISTS (SELECT [Id] FROM [Accounts] WHERE [Id] = @AccountId)
   BEGIN 
       ROLLBACK 
       RAISERROR ('Acount is not existing', 16, 1)
     END
     
     IF @MoneyAmount < 0
     BEGIN 
         ROLLBACK 
         RAISERROR('Negative amount', 16, 1)
       END 
        
    UPDATE [Accounts] SET [Balance] += @MoneyAmount WHERE [Id] = @AccountId
    COMMIT
    GO
    
    SELECT * FROM [Accounts]
    EXEC dbo.usp_DepositMoney -1, -200.60
    
---Taskn 04: Withdraw Money Procedure
    CREATE PROCEDURE usp_WithdrawMoney (@AccountId INT, @MoneyAmount DECIMAL(18, 4))
    AS 
     IF (@MoneyAmount > 0)
    BEGIN 
        UPDATE [Accounts]
        SET [Balance] -= @MoneyAmount
        WHERE [Id] = @AccountId
    END
    
    GO 
    
    EXEC usp_WithdrawMoney 5, 25
    GO
    SELECT * FROM [Accounts]
    
---Task 05: Money Transfer
    CREATE PROCEDURE usp_TransferMoney (@senderId INT, @receiverId INT, @amount DECIMAL(18, 4))
    AS 
    IF(@amount > 0)
    BEGIN TRANSACTION
          EXEC usp_WithdrawMoney @senderId, @amount
          EXEC usp_DepositMoney @receiverId, @amount
         
          DECLARE @SenderBalance DECIMAL(18, 4) = (
                  SELECT [Balance] FROM [Accounts]
                  WHERE [Id] = @senderId
                 )
         IF (@SenderBalance < 0)
        BEGIN 
            ROLLBACK 
            RETURN 
        END
    COMMIT 
    GO 
    
    SELECT * FROM [Accounts]
    EXEC usp_TransferMoney 11, 10, 500
    EXEC usp_TransferMoney 5, 1, 5000
    
    
---Task 06: Employees by Salary Level
CREATE PROCEDURE usp_EmployeesBySalaryLevel(@salaryLevel VARCHAR(30))
AS
BEGIN
    SELECT e.[FirstName],
           e.[LastName]
      FROM [Employees] e
      WHERE dbo.ufn_GetSalaryLevel(Salary) = @salaryLevel
END

GO 

EXEC usp_EmployeesBySalaryLevel 'High'
EXEC usp_EmployeesBySalaryLevel 'Low'


---Task 09: Delete Employees
CREATE TABLE Deleted_Employees
(
  [EmployeeId] INT PRIMARY KEY IDENTITY, 
  [FirstName] VARCHAR(50),
  [LastName] VARCHAR(50),  
  [MiddleName] VARCHAR(50),   
  [JobTitle] VARCHAR(50),  
  [DepartmentId] INT, 
  [Salary] DECIMAL(15,2)
)
  
GO

CREATE TRIGGER tr_Deleted_Employees
ON Employees
FOR DELETE 
AS
INSERT INTO Deleted_Employees ([FirstName], [LastName], [MiddleName], [JobTitle], [DepartmentId], [Salary])
SELECT [FirstName], [LastName], [MiddleName], [JobTitle], [DepartmentId], [Salary] FROM deleted


---Task 10: People with Balance Higher Than 
  CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan(@value DECIMAL(15, 2))
  AS 
  BEGIN 
             SELECT [FirstName], [LastName]
               FROM [AccountHolders] AS ah
         INNER JOIN [Accounts] AS a ON ah.Id = a.[AccountHolderId] 
           GROUP BY [FirstName], [LastName]
             HAVING SUM([Balance]) > @value
           ORDER BY [FirstName], [LastName]
  END
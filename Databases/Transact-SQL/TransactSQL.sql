-- 1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and 
-- Accounts(Id(PK), PersonId(FK), Balance).
-- Insert few records for testing.
-- Write a stored procedure that selects the full names of all persons.

CREATE DATABASE BankDB
GO

USE BankDB
GO

CREATE TABLE People(
	Id int IDENTITY,
	FirstName nvarchar(30) NOT NULL,
	LastName nvarchar(30) NOT NULL,
	SSN nvarchar(11) NOT NULL,
	CONSTRAINT PK_People PRIMARY KEY (Id)
)
GO 

CREATE TABLE Accounts(
	Id int IDENTITY,
	PersonId int NOT NULL,
	Balance money NOT NULL,
	CONSTRAINT PK_Accounts PRIMARY KEY (Id),
	CONSTRAINT FK_People_Accounts FOREIGN KEY (PersonId) REFERENCES People(Id)
)
GO

INSERT INTO People(FirstName, LastName, SSN) VALUES
	('Tony', 'Phelps', '539-53-4782'),
	('Eleanore', 'Douglass', '769-22-1234'),
	('Mary', 'Dillard', '458-81-3432'),
	('Jeanette', 'McDonald', '585-24-8622'),
	('Morgan', 'Brock', '541-35-7531'),
	('Jason', 'Mullen', '328-26-4372'),
	('Katherine', 'Duncan', '195-58-4367'),
	('Allan', 'Hutchings', '652-16-4326'),
	('Marcus', 'Stewart', '250-29-8543'),
	('Eric', 'Drake', '351-02-5082')
GO

INSERT INTO Accounts(PersonId, Balance) VALUES
	(4, 86500.50),
	(2, 54200.75),
	(1, 176850.00),
	(5, 106375.00),
	(8, 74960.75),
	(6, 210630.50),
	(3, 98146.38),
	(10, 127890.82),
	(6, 39100.00),
	(9, 78932.55),
	(7, 65834.00),
	(7, 42790.75)
GO

CREATE PROC usp_SelectPeopleFullNames
AS
	SELECT FirstName + ' ' + LastName AS [Full Name]
	FROM People
GO

EXEC usp_SelectPeopleFullNames

-- 2. Create a stored procedure that accepts a number as a parameter and 
-- returns all persons who have more money in their accounts than the supplied number.

CREATE PROC usp_SelectPeopleWithMoreMoneyThan(@amount money)
AS
	SELECT p.FirstName + ' ' + p.LastName AS [Full Name], a.Balance
	FROM People p JOIN Accounts a ON p.Id = a.PersonId
	WHERE a.Balance > @amount
	ORDER BY a.Balance DESC;
GO

EXEC usp_SelectPeopleWithMoreMoneyThan 90000

-- 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
-- It should calculate and return the new sum.
-- Write a SELECT to test whether the function works as expected.

USE BankDB
GO

CREATE FUNCTION ufn_CalculateInterest(@sum money, @yearlyInterest money, @months int) 
	RETURNS money
AS
BEGIN
	RETURN @sum + (@sum * @yearlyInterest * @months)
END
GO

SELECT p.FirstName + ' ' + p.LastName AS [Full Name], a.Balance, dbo.ufn_CalculateInterest(a.Balance, 0.03, 12) AS [Balance after 12 months]
FROM People p JOIN Accounts a ON p.Id = a.PersonId

--4. Create a stored procedure that uses the function from the previous example 
-- to give an interest to a person's account for one month.
-- It should take the AccountId and the interest rate as parameters.

USE BankDB
GO

CREATE PROC usp_UpdateBalance(@accountId int, @interestRate money)
AS
	UPDATE Accounts
	SET Balance = dbo.ufn_CalculateInterest(Balance, @interestRate, 1)
	WHERE Id = @accountId
GO

EXEC usp_UpdateBalance 3, 0.02

SELECT Balance
FROM Accounts
WHERE Id = 3;

-- 5. Add two more stored procedures WithdrawMoney(AccountId, money) and 
-- DepositMoney(AccountId, money) that operate in transactions.

USE BankDB
GO

CREATE PROC usp_WithdrawMoney(@accountId int, @amount money = 0)
AS
	BEGIN TRAN

	UPDATE Accounts
	SET Balance = Balance - @amount
	WHERE Id = @accountId

	COMMIT TRAN
GO

CREATE PROC usp_DepositMoney(@accountId int, @amount money = 0)
AS
	BEGIN TRAN

	UPDATE Accounts
	SET Balance = Balance + @amount
	WHERE Id = @accountId

	COMMIT TRAN
GO

DECLARE @accountId int = 5

SELECT Id, Balance
FROM Accounts
WHERE Id = @accountId;

EXEC usp_WithdrawMoney @accountId, 150.75

EXEC usp_DepositMoney @accountId, 820.50

SELECT Id, Balance
FROM Accounts
WHERE Id = @accountId;

-- 6. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
-- Add a trigger to the Accounts table that enters a new entry 
-- into the Logs table every time the sum on an account changes.

CREATE TABLE Logs(
	LogId int IDENTITY,
	AccountId int NOT NULL,
	OldSum money NOT NULL,
	NewSum money NOT NULL,
	CONSTRAINT PK_Logs PRIMARY KEY (LogId),
	CONSTRAINT FK_Accounts_Logs FOREIGN KEY (AccountId) REFERENCES Accounts(Id)
)
GO

CREATE TRIGGER tr_AccountsUpdate ON Accounts FOR UPDATE
AS
	INSERT INTO Logs(AccountId, OldSum, NewSum)
	SELECT i.Id, d.Balance, i.Balance 
	FROM inserted i JOIN deleted d ON i.Id = d.Id
GO 

UPDATE Accounts
SET Balance = Balance - 100
WHERE Id = 10;

-- 7. Define a function in the database TelerikAcademy that returns all Employee's names 
-- (first or middle or last name) and all town's names that are comprised of given set of letters.

use TelerikAcademy
GO

CREATE FUNCTION ufn_CheckName(@nameToCheck NVARCHAR(50), @letters nvarchar(50))
RETURNS int AS
BEGIN
    DECLARE @i int = 1
	DECLARE @currentChar nvarchar(1)
    WHILE (@i <= LEN(@nameToCheck))
		BEGIN
			SET @currentChar = SUBSTRING(@nameToCheck,@i, 1)
				IF (CHARINDEX(LOWER(@currentChar),LOWER(@letters)) <= 0) 
					BEGIN  
						RETURN 0
					END
			SET @i = @i + 1
		END
    RETURN 1
END
GO

CREATE FUNCTION ufn_AllEmploeeysAndTownsBySetOfLetters(@format nvarchar(50))
RETURNS @table TABLE
	([Name] nvarchar(50) NOT NULL)
AS
BEGIN
	INSERT @table
	SELECT newTbl.LastName FROM
		(SELECT LastName FROM Employees
		UNION
		SELECT Name FROM Towns) as newTbl
		WHERE dbo.ufn_CheckName(newTbl.LastName, @format) > 0
	 RETURN
END
GO

SELECT * 
FROM dbo.ufn_AllEmploeeysAndTownsBySetOfLetters('oistmiahf');

-- 8. Using database cursor write a T-SQL script that scans 
-- all employees and their addresses and prints all pairs of employees that live in the same town.

USE TelerikAcademy
GO

DECLARE employeeCursor CURSOR READ_ONLY FOR
	SELECT e1.FirstName + ' ' + e2.LastName AS [First Employee], 
		   t1.Name AS Town, 
		   e2.FirstName + ' ' + e2.LastName AS [Second Employee]
	FROM Employees e1
	JOIN Addresses a1 ON e1.AddressID = a1.AddressID
	JOIN Towns t1 ON a1.TownID = t1.TownID,
	Employees e2
	JOIN Addresses a2 ON e2.AddressID = a2.AddressID
	JOIN Towns t2 ON a2.TownID = t2.TownID
	WHERE t1.TownID = t2.TownID AND e1.EmployeeID != e2.EmployeeID
	ORDER BY [First Employee], [Second Employee]
	
OPEN employeeCursor

DECLARE @firstEmployee nvarchar(150),
		@secondEmployee nvarchar(150),
		@townName nvarchar(50)

FETCH NEXT FROM employeeCursor
INTO @firstEmployee, @townName, @secondEmployee

WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT @firstEmployee + ' and ' + @secondEmployee + ' live in ' + @townName;

		FETCH NEXT FROM employeeCursor
		INTO @firstEmployee, @townName, @secondEmployee
	END	
	
CLOSE employeeCursor
DEALLOCATE employeeCursor

-- 9. Write a T-SQL script that shows for each town a list of all employees that live in it.

USE TelerikAcademy
GO

CREATE TABLE #EmployeesTowns(
	Id int IDENTITY PRIMARY KEY,
	FullName nvarchar(150),
	Town nvarchar(50)
)

INSERT INTO #EmployeesTowns
SELECT e.FirstName + ' ' + e.LastName AS Employee, t.Name AS Town
	FROM Employees e
	JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID = t.TownID
	GROUP BY t.Name, e.FirstName + ' ' + e.LastName

DECLARE employeeCursor CURSOR READ_ONLY FOR
	SELECT DISTINCT Town
	FROM #EmployeesTowns
	
OPEN employeeCursor

DECLARE @townName nvarchar(50)

FETCH NEXT FROM employeeCursor
INTO @townName

WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE @employees nvarchar(MAX);
		SET @employees = '';
		SELECT @employees += FullName + ', '
		FROM #EmployeesTowns
		WHERE Town = @townName

		PRINT @townName + ' -> ' + LEFT(@employees, LEN(@employees) - 1);

		FETCH NEXT FROM employeeCursor INTO @townName
	END	
	
CLOSE employeeCursor
DEALLOCATE employeeCursor

-- 10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings 
-- and return a single string that consists of the input strings separated by ','.
USE TelerikAcademy
GO

IF NOT EXISTS (
    SELECT value
    FROM sys.configurations
    WHERE name = 'clr enabled' AND value = 1
)
BEGIN
    EXEC sp_configure @configname = clr_enabled, @configvalue = 1
    RECONFIGURE
END
GO

IF OBJECT_ID('dbo.concat') IS NOT NULL DROP Aggregate concat 
GO 

IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'concat_assembly') 
       DROP assembly concat_assembly; 
GO      

CREATE Assembly concat_assembly 
   AUTHORIZATION dbo 
   FROM 'E:\Stuff\TelerikAcademy\Homeworks\Databases\Transact-SQL\SqlStringConcatenation.dll' 
   WITH PERMISSION_SET = SAFE; 
GO 

CREATE AGGREGATE dbo.concat ( 

    @Value NVARCHAR(MAX) 
  , @Delimiter NVARCHAR(4000) 

) RETURNS NVARCHAR(MAX) 
EXTERNAL Name concat_assembly.concat; 
GO  

SELECT dbo.concat(FirstName + ' ' + LastName, ', ')
FROM Employees
GO

DROP Aggregate concat; 
DROP assembly concat_assembly; 
GO
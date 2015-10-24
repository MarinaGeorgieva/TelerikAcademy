-- 1. Create a table in SQL Server with 1 000 000 log entries (date + text).
-- Search in the table by date range. Check the speed (without caching).

CREATE DATABASE LogDB
GO

USE LogDB
GO

CREATE TABLE Logs (
	LogId int NOT NULL IDENTITY,
	LogDate datetime NOT NULL,
	LogText nvarchar(250) NOT NULL,
	CONSTRAINT PK_Logs PRIMARY KEY (LogId)
)

DECLARE @Counter int = 0
WHILE (@Counter < 1000000)
BEGIN
	DECLARE @LogDate datetime = DATEADD(DAY, @Counter, GETDATE())
	DECLARE @LogText nvarchar(250) = 'Log ' + CONVERT(nvarchar(8), @Counter + 1)

	INSERT INTO Logs (LogDate, LogText)
	VALUES (@LogDate, @LogText)

	SET @Counter = @Counter + 1
END

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT *
FROM Logs
WHERE LogDate BETWEEN '2015-11-21' AND '2017-03-27';

-- 2. Add an index to speed-up the search by date.
-- Test the search speed (after cleaning the cache).

CREATE INDEX IDX_Logs_LogDate
ON Logs(LogDate);

CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT *
FROM Logs
WHERE LogDate BETWEEN '2015-11-21' AND '2017-03-27';

-- 3. Add a full text index for the text column.
-- Try to search with and without the full-text index and compare the speed.

CREATE FULLTEXT CATALOG LogTextFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Logs(LogText)
KEY INDEX PK_Logs
ON LogTextFullTextCatalog
WITH CHANGE_TRACKING AUTO

-- Searching without full-text index 
CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Logs
WHERE LogText LIKE '%37%';

-- Searching with full-text index 
CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache

SELECT * FROM Logs
WHERE CONTAINS(LogText, '37');
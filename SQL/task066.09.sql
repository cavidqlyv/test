use c

-- Get a list of tables and views in the current database
SELECT table_catalog [database], table_schema [schema], table_name name, table_type type
FROM INFORMATION_SCHEMA.TABLES
GO

SELECT *
FROM Lesson;

GO
CREATE PROCEDURE dbo.InsertLesson
    @name VARCHAR(20),
    @dp int,
    @status int
AS
INSERT INTO Lesson
VALUES
    (@name , @dp , @status);
GO

EXECUTE dbo.InsertLesson 'test' , 100,1;
GO

CREATE PROCEDURE dbo.UpdateLesson
    @id int,
    @name VARCHAR(20),
    @dp int,
    @status  int
AS
UPDATE Lesson set name = @name , default_price = @dp , [status] = @status
WHERE id = @id;
GO

EXECUTE dbo.UpdateLesson 1, 'test' , 100,1;

SELECT * FROM Groupc;

GO
CREATE PROCEDURE dbo.DeleteLesson 
@id INT
AS
UPDATE Groupc SET lesson_id = 0, [status] = 0 WHERE lesson_id = @id;
DELETE Lesson WHERE id = @id;
GO

EXECUTE dbo.DeleteLesson 1

DBCC LOGINFO

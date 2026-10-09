-- ============================================================
--  Lecture Management System - database setup
--  Run this once against a SQL Server / SQL Server LocalDB instance.
-- ============================================================

IF DB_ID('LectureDb') IS NULL
BEGIN
    CREATE DATABASE LectureDb;
END;
GO

USE LectureDb;
GO

IF OBJECT_ID('dbo.Lectures', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Lectures
    (
        Id           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Code         NVARCHAR(20)     NOT NULL,
        Title        NVARCHAR(120)    NOT NULL,
        LecturerName NVARCHAR(100)    NOT NULL,
        Department   NVARCHAR(80)     NOT NULL,
        Credits      INT              NOT NULL,
        Semester     NVARCHAR(30)     NOT NULL,
        Schedule     NVARCHAR(80)     NOT NULL DEFAULT (N'')
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Lectures)
BEGIN
    INSERT INTO dbo.Lectures (Code, Title, LecturerName, Department, Credits, Semester, Schedule)
    VALUES
        (N'CS101', N'Introduction to Programming', N'Dr. A. Mokoena',  N'Computer Science',      12, N'Semester 1', N'Mon 08:00-10:00'),
        (N'CS202', N'Data Structures',             N'Prof. L. Dlamini', N'Computer Science',      16, N'Semester 2', N'Tue 10:00-12:00'),
        (N'IT150', N'Web Development',             N'Ms. N. Khumalo',   N'Information Technology', 12, N'Semester 1', N'Wed 13:00-15:00'),
        (N'MA110', N'Discrete Mathematics',        N'Dr. S. Naidoo',    N'Mathematics',           14, N'Semester 1', N'Thu 09:00-11:00');
END;
GO

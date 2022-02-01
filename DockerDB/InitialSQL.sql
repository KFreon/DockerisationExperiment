-- Basic DB setup script for testing

-- This script runs every container start, BUT the data isn't destroyed when the container is stopped, only when it's removed.
-- As such, let's only run this initialisation when we need to.
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'Swag'
)
CREATE DATABASE Swag
GO
USE Swag
GO

IF OBJECT_ID('[dbo].[Yolo]', 'U') IS NOT NULL
DROP TABLE [dbo].[Yolo]
GO
CREATE TABLE Yolo (Id INT, DisplayName NVARCHAR(50), SwagAmount INT)
GO
INSERT INTO Yolo VALUES (1, 'me', 9001)
GO
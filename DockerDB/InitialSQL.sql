-- Basic DB setup script for testing

CREATE DATABASE Swag
GO

USE Swag
CREATE TABLE Yolo (Id INT, DisplayName NVARCHAR(50), SwagAmount INT)
GO
INSERT INTO Yolo VALUES (1, 'me', 9001)
GO
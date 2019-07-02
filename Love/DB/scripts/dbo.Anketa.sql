CREATE TABLE [dbo].[Anketa]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FIO] NVARCHAR(MAX) NOT NULL, 
    [Pol] CHAR(1) NOT NULL, 
    [UvlecheniaAnketiId] INT NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [City] INT NOT NULL
)

CREATE TABLE [dbo].[imprumut]
(
	[Id_imprumut] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Id_Carte] INT NULL, 
    [email] VARCHAR(30) NULL, 
    [data_imprumut] DATETIME NULL
)

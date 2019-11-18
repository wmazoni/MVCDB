CREATE TABLE [dbo].[Tarefa]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NCHAR(50) NOT NULL, 
    [Descricao] NCHAR(150) NOT NULL, 
    [Data] DATE NOT NULL
)

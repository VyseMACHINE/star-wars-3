CREATE TABLE [dbo].[People]
(
	[id] CHAR(20) NOT NULL PRIMARY KEY, 
    [Name] NCHAR(30) NULL, 
    [Height] INT NULL, 
    [Mass] INT NULL, 
    [HairColor] NCHAR(30) NULL, 
    [SkinColor] NCHAR(10) NULL, 
    [EyeColor] NCHAR(10) NULL, 
    [ BirthYear] INT NULL, 
    [Gender] NCHAR(10) NULL, 
    [Homeworld] NCHAR(10) NULL
)

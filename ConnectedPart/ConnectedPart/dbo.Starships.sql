CREATE TABLE [dbo].[Starships]
(
	[Id] CHAR(20) NOT NULL PRIMARY KEY, 
    [Name] NCHAR(20) NULL, 
    [Model] NCHAR(30) NULL, 
    [Manufacturer] NCHAR(20) NULL, 
    [CostInCredits] INT NULL, 
    [Length] INT NULL, 
    [MaxAtmospheringSpeed] NCHAR(30) NULL, 
    [Crew] INT NULL, 
    [Passengers] INT NULL, 
    [CargoCapacity] INT NULL, 
    [Consumables] NCHAR(20) NULL, 
    [HyperdriveRating] INT NULL, 
    [MGLT] INT NULL, 
    [StarshipClass] NCHAR(10) NULL, 
    [Pilots] NCHAR(50) NULL 
)

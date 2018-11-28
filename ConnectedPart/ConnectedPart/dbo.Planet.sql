CREATE TABLE [dbo].[Planet]
(
	[id] CHAR(15) NOT NULL PRIMARY KEY, 
    [RotationPeriod] INT NULL, 
    [OrbitalPeriod] INT NULL, 
    [Diameter] INT NULL, 
    [Climate] NCHAR(20) NULL, 
    [Gravity] NCHAR(10) NULL, 
    [Terrain] NCHAR(15) NULL, 
    [SurfaceWater] INT NULL, 
    [Population] INT NULL, 
    [Residents] NCHAR(50) NULL 
)


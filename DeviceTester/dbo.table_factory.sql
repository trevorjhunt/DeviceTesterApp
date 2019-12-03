CREATE TABLE [dbo].[Table]
(
	[FactoryId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SerialNumber] VARCHAR(50) NOT NULL, 
    [Product] VARCHAR(50) NOT NULL, 
    [Country] VARCHAR(50) NOT NULL, 
    [Frequency] VARCHAR(50) NOT NULL, 
    [Variant] VARCHAR(50) NOT NULL, 
    [TemperatureOffset] VARCHAR(50) NOT NULL, 
)
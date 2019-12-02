CREATE TABLE [dbo_table_factory].[Table]
(
	[FactoryID] INT NOT NULL PRIMARY KEY IDENTITY DEFAULT 1, 
    [Product] VARCHAR(50) NOT NULL, 
    [SerialNumber] INT NOT NULL, 
    [Country] VARCHAR(50) NOT NULL, 
    [Frequency] INT NOT NULL, 
    [Variant] INT NOT NULL,
    [TemperatureOffset] INT NOT NULL
)
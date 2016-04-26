﻿CREATE TABLE [dbo].[CarBrands](
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,

	CONSTRAINT [PkCarBrands_Id] PRIMARY KEY(Id),
	CONSTRAINT [UnCarBrands_Name] UNIQUE(Name)
)

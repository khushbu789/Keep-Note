﻿CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY DEFAULT 1 IDENTITY, 
    [Title] VARCHAR(100) NULL, 
    [Note] VARCHAR(MAX) NULL
)

CREATE TABLE [dbo].[SalesPerson] (
    [ID]      VARCHAR (50) NOT NULL,
    [Name]    VARCHAR (50) NOT NULL,
    [Contact] NUMERIC (18) NOT NULL,
    [Gender]  CHAR (10)    NOT NULL,
    [Address] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SalesPerson] PRIMARY KEY CLUSTERED ([ID] ASC)
);


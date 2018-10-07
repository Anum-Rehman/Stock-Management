CREATE TABLE [dbo].[Worker] (
    [Worker ID] INT          NOT NULL,
    [Name]      VARCHAR (50) NOT NULL,
    [Address]   VARCHAR (50) NOT NULL,
    [Contact]   INT          NOT NULL,
    [DOB]       VARCHAR (50) NOT NULL,
    [Salary]    INT          NOT NULL,
    [Gender]    NCHAR (10)   NOT NULL,
    CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED ([Worker ID] ASC)
);


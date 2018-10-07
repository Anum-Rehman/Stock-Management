CREATE TABLE [dbo].[Stock] (
    [ProductCode] INT          NOT NULL,
    [Category]    CHAR (20)    NOT NULL,
    [Brand]       VARCHAR (100) NOT NULL,
    [Price]       FLOAT (53)   NOT NULL,
    [Measurement] VARCHAR (100) NOT NULL,
    [Type]        VARCHAR (100) NOT NULL,
    [Date]        DATETIME     NOT NULL,
    CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED ([ProductCode] ASC)
);


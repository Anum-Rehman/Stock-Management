CREATE TABLE [dbo].[Table]
(
	[User Name] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Password] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([User Name])
)

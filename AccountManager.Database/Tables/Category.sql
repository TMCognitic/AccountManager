CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL IDENTITY, 
	[Name] NVARCHAR(30) NOT NULL,
	[UserId] INT NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Category_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)

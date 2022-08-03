CREATE TABLE [dbo].[Account]
(
	[Id] UNIQUEIDENTIFIER NOT NULL
		CONSTRAINT DF_Account_Id DEFAULT (NEWSEQUENTIALID()), 
	[Description] NVARCHAR(200) NOT NULL,
	[AccountNumber] NVARCHAR(16) NOT NULL,
	[UserId] INT NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY ([Id]),
	CONSTRAINT [UK_Account_AccountNumber] UNIQUE ([AccountNumber]), 
    CONSTRAINT [FK_Account_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
	
)

CREATE PROCEDURE TSP_Register
    @LastName NVARCHAR(50),
    @FirstName NVARCHAR(50),
    @Email NVARCHAR(384),
    @Passwd NVARCHAR(20)
AS
BEGIN
    INSERT INTO [User] (LastName, FirstName, Email, Passwd) VALUES (@LastName, @FirstName, @Email, HASHBYTES('SHA2_512', dbo.TSF_GetPreSalt() + @Passwd + dbo.TSF_GetPostSalt())); 
END
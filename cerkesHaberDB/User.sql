CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	userID nvarchar(100) not null foreign key references userInfo(userID),
	userName nvarchar(50) not null,
	userPassword nvarchar(50),
)

CREATE TABLE [dbo].[UserInfo]
(
	[Id] INT NOT NULL identity(1,1),
	userID nvarchar(100) primary key not null,
	Name nvarchar(50) not null,
	Surname nvarchar(50) not null,
	SecondName nvarchar(50) not null,
	Age smallint,
	UserImageUrl text,
	Village nvarchar(50),
	City nvarchar(20),
	Part nvarchar(50),
	Adress text,
	PhoneNumber nvarchar(15)
)
 
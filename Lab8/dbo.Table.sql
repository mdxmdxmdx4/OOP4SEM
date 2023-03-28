CREATE TABLE [dbo].[Owner]
(
	[FIO] NVARCHAR(35) PRIMARY KEY, 
    [birthDate] DATETIME NOT NULL, 
    [phoneNumber] NVARCHAR(12) NULL, 
    [wallet] NVARCHAR(4) NULL, 
    [passportInfo] NCHAR(10) NOT NULL
)

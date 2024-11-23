CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [AuthId] NVARCHAR(128) NULL, 
    [Archive] BIT NULL, 
    [Automation] NVARCHAR(50) NULL, 
    [NameAddressDetails] NVARCHAR(500) NULL, 
    [AccountStatus] NVARCHAR(100) NULL, 
    [DateCreated] DATETIME2 NULL, 
    [LastModified] DATETIME2 NULL
)

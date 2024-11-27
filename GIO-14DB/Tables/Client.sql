CREATE TABLE [dbo].[Client]
(
    [AuthId] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [Archive] BIT NULL, 
    [Automation] NVARCHAR(50) NULL, 
    [NameAddressDetails] NVARCHAR(500) NULL, 
    [AccountStatus] NVARCHAR(100) NULL, 
    [OptionsLogsDetails] NVARCHAR(20) NULL,
    [DateCreated] DATETIME2 NULL, 
    [LastModified] DATETIME2 NULL
)

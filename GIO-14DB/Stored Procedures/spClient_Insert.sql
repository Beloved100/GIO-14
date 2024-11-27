CREATE PROCEDURE [dbo].[spClient_Insert]
	@AuthId nvarchar(128),
	@Archive bit,
	@Automation nvarchar(50),
	@NameAddressDetails nvarchar(500),
	@AccountStatus nvarchar(100),
	@OptionsLogsDetails nvarchar(20),
	@DateCreated DateTime2(7),
	@LastModified DateTime2(7)

AS
begin
	insert into dbo.Client (AuthId, Archive, Automation, NameAddressDetails, AccountStatus, OptionsLogsDetails, DateCreated, LastModified)
	values (@AuthId, @Archive, @Automation, @NameAddressDetails, @AccountStatus, @OptionsLogsDetails, @DateCreated, @LastModified);
end
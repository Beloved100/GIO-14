CREATE PROCEDURE [dbo].[spClient_Read]
	@AuthId nvarchar(128)

AS
begin
	SELECT AuthId, Archive, Automation, NameAddressDetails, AccountStatus, OptionsLogsDetails, DateCreated, LastModified
	from dbo.Client
	where Archive = 0 and AuthId = @AuthId;
end
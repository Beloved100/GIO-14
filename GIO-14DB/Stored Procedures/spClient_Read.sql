CREATE PROCEDURE [dbo].[spClient_Read]
	@AuthId nvarchar(128)

AS
begin
	SELECT AuthId, Automation, NameAddressDetails, AccountStatus, DateCreated, LastModified
	from dbo.Client
	where Archive = 0 and AuthId = @AuthId;
end
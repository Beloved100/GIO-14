CREATE PROCEDURE [dbo].[spClient_Insert]
	@AuthId nvarchar(128),
	@Automation nvarchar(50),
	@NameAddressDetails nvarchar(500),
	@AccountStatus nvarchar(100),
	@LastModified DateTime2(7)

AS
begin
	update dbo.Client
	set Archive = '1'
	where AuthId = @AuthId and Archive = '0'

	insert into dbo.Client (AuthId, Archive, Automation, NameAddressDetails, AccountStatus, LastModified)
	values (@AuthId, '0', @Automation, @NameAddressDetails, @AccountStatus, @LastModified);
end
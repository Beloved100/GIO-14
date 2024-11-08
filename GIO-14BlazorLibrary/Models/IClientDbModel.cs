using System;

namespace GIO_14BlazorLibrary.Models
{
	public interface IClientDbModel
	{
		string? AccountStatus { get; set; }
		bool Archive { get; set; }
		string? AuthId { get; set; }
		string? Automation { get; set; }
		string? BankDetails { get; set; }
		DateTime? DateCreated { get; set; }
		DateTime? LastModified { get; set; }
		string? NameAddressDetails { get; set; }
		string? OptionsLogsDetails { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace GIO_14APILibrary.Models
{
	public class ClientDbModel
	{
        public string? AuthId { get; set; }
        public bool Archive { get; set; }
        public string? Automation { get; set; }
        public string? NameAddressDetails { get; set; }
        public string? BankDetails { get; set; }
        public string? AccountStatus { get; set; }
        public string? OptionsLogsDetails { get; set; }
		public DateTime? DateCreated { get; set; }
		public DateTime? LastModified { get; set; }
	}
}

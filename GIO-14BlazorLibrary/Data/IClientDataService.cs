using GIO_14BlazorLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GIO_14BlazorLibrary.Data
{
	public interface IClientDataService
	{
		Task AddCareAilment(IClientDbModel client);
		Task<List<IClientDbModel>> DeleteClient(IClientDbModel client, string AuthId);
		Task<List<IClientDbModel>> ReadClient(string AuthId);
		Task<List<IClientDbModel>> UpdateClient(IClientDbModel client, string AuthId);
	}
}
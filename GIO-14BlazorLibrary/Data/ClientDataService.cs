using GIO_14BlazorLibrary.DataAccess;
using GIO_14BlazorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIO_14BlazorLibrary.Data
{
	public class ClientDataService : IClientDataService
	{
		private readonly ISqlDataAccess _dataAccess;

		public ClientDataService(ISqlDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}



		public async Task AddCareAilment(IClientDbModel client)
		{
			await _dataAccess.SaveData("dbo.spClient_Insert", client, "GIO-14");
		}


		public async Task<List<IClientDbModel>> ReadClient(string AuthId)
		{
			var client = await _dataAccess.LoadData<ClientDbModel, dynamic>("dbo.spClient_Read", new { AuthId }, "GIO-14");

			return client.ToList<IClientDbModel>();
		}


		public async Task<List<IClientDbModel>> UpdateClient(IClientDbModel client, string AuthId)
		{
			await _dataAccess.SaveData("dbo.spClient_Insert", client, "GIO-14Database");

			var clientDb = await _dataAccess.LoadData<ClientDbModel, dynamic>("dbo.spClient_Read", new { AuthId }, "GIO-14");

			return clientDb.ToList<IClientDbModel>();
		}


		public async Task<List<IClientDbModel>> DeleteClient(IClientDbModel client, string AuthId)
		{
			await _dataAccess.SaveData("dbo.spClient_Insert", client, "GIO-14Database");

			var clientDb = await _dataAccess.LoadData<ClientDbModel, dynamic>("dbo.spClient_Read", new { AuthId }, "GIO-14");

			return clientDb.ToList<IClientDbModel>();
		}
	}
}

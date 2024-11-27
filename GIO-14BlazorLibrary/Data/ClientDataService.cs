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



        public async Task CreateClientAsync(ClientDbModel client)
        {
            await _dataAccess.SaveDataAsync("dbo.spClient_Insert", new { client.AuthId, client.Archive, client.Automation, client.NameAddressDetails, client.AccountStatus, client.OptionsLogsDetails, client.DateCreated, client.LastModified }, "GIO-14");
        }


        public async Task<List<ClientDbModel>> ReadClientAsync(string authId)
        {
            var client = await _dataAccess.LoadDataAsync<ClientDbModel, dynamic>("dbo.spClient_Read", new { authId }, "GIO-14");

            return client;
        }


        public async Task<List<ClientDbModel>> UpdateClientAsync(ClientDbModel client)
        {
            await _dataAccess.SaveDataAsync("dbo.spClient_Insert", client, "GIO-14");

            var clientDb = await _dataAccess.LoadDataAsync<ClientDbModel, dynamic>("dbo.spClient_Read", new { client.AuthId, client.Archive }, "GIO-14");

            return clientDb;
        }


        public async Task DeleteClientAsync(string authId)
        {
            await _dataAccess.SaveDataAsync("dbo.spClient_Delete", authId, "GIO-14");
        }
    }
}

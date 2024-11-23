using GIO_14APILibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GIO_14APILibrary.DataAccess
{
    public class ClientData : IClientData
    {
        private readonly ISqlDataAccess _sqlDataAccess;


        public ClientData(ISqlDataAccess sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }


        public async Task<List<ClientDbModel>> ClientReadAsync(string authId)
        {
            var output = await _sqlDataAccess.LoadDataAsync<ClientDbModel, dynamic>("dbo.spClient_Read", new { authId }, "GIO-14");

            return output;
        }
    }
}

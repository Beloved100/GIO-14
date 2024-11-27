using GIO_14BlazorLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GIO_14BlazorLibrary.Data
{
    public interface IClientDataService
    {
        Task CreateClientAsync(ClientDbModel client);
        Task DeleteClientAsync(string authId);
        Task<List<ClientDbModel>> ReadClientAsync(string authId);
        Task<List<ClientDbModel>> UpdateClientAsync(ClientDbModel client);
    }
}
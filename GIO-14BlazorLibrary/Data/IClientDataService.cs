using GIO_14BlazorLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GIO_14BlazorLibrary.Data
{
    public interface IClientDataService
    {
        Task CreateClient(ClientDbModel client);
        Task DeleteClient(ClientDbModel client);
        Task<List<ClientDbModel>> ReadClient(string authId);
        Task<List<ClientDbModel>> UpdateClient(ClientDbModel client);
    }
}
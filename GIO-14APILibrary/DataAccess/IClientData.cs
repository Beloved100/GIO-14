using GIO_14APILibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GIO_14APILibrary.DataAccess
{
    public interface IClientData
    {
        Task<List<ClientDbModel>> ClientReadAsync(string authId);
    }
}
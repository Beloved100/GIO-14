using GIO_14BlazorLibrary.Data;
using GIO_14BlazorLibrary.DataAccess;
using GIO_14BlazorLibrary.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GIO_14BlazorLibrary.UIAlgorithms
{
    public class UIClientAlgorithms : IUIClientAlgorithms
    {
        private readonly IClientDataService _clientDS;

        public UIClientAlgorithms(IClientDataService clientDS)
        {
            _clientDS = clientDS;
        }

        public async Task SetUpClientAsync(string authId, string emailAddress)
        {

            List<ClientDbModel> clientDb = (List<ClientDbModel>)await _clientDS.ReadClient(authId);

            return;
        }
    }
}

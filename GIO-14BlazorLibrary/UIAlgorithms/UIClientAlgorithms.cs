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
            ClientDbModel _clientModel = new ClientDbModel();

            List<ClientDbModel> clientDb = (List<ClientDbModel>)await _clientDS.ReadClientAsync(authId);

            if (clientDb.Count == 0)
            {
                _clientModel.AuthId = authId;
                _clientModel.Archive = false;
                _clientModel.Automation = "";
                _clientModel.NameAddressDetails = emailAddress.PadRight(500);
                _clientModel.AccountStatus = "";
                _clientModel.OptionsLogsDetails = "";
                _clientModel.DateCreated = DateTime.Now;
                _clientModel.LastModified = DateTime.Now;

                await _clientDS.CreateClientAsync(_clientModel);
                await _clientDS.ReadClientAsync(authId);
            }

            return;
        }
    }
}

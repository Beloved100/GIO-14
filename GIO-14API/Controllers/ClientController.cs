using GIO_14APILibrary.DataAccess;
using GIO_14BlazorApp.Data;
using GIO_14APILibrary.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Linq;

namespace GIO_14API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/")]
    [ApiController]
    [Authorize]
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<ClientController> _logger;
        private readonly IClientData _client;

        public ClientController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<ClientController> logger, IClientData client)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
            _client = client;
        }


        // GET api/client
        [HttpGet]
        [Route("client")]
        public async Task<List<ClientDbModel>> GetClientAsync()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var output = await _client.ClientReadAsync(userId);

            return output;
        }


    }
}

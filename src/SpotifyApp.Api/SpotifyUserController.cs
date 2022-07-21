using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpotifyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyUserController : ControllerBase
    {
        [HttpGet]
        public async Task<ClientCredentialsTokenResponse> GetAccessToken()
        {
            var config = SpotifyClientConfig.CreateDefault();
            //Client ID - Secret Client 
            var request = new ClientCredentialsRequest("Client ID", " Secret Client");

            var response = await new OAuthClient(config).RequestToken(request);
            return response;

        }

    }
}

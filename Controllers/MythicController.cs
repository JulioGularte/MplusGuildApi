using Application.ApiResponses.JSON;
using Application.Authorization;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MplusGuildApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MythicController : ControllerBase
    {
        private readonly IMythicKeyService _mythicKeyService;
        private readonly IAccessTokenService _accessTokenService;
        public MythicController(IMythicKeyService mythicKeyService, IAccessTokenService accessTokenService)
        {
            _mythicKeyService = mythicKeyService;
            _accessTokenService = accessTokenService;
        }
        [HttpGet("playermythicprofile")]
        public async Task <IActionResult> GetPlayerMythicProfileAsync (string character)
        {
            Token token = await _accessTokenService.RequestToken();
            return Ok(await _mythicKeyService.GetPlayerMythicProfile(character));

        }

    }
}

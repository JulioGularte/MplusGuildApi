
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MplusGuildApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuildController : ControllerBase
    {
        private readonly IGuildService _guildService;
        private readonly IMythicKeyService _mythicKeyService;
        public GuildController(IGuildService guildService, IMythicKeyService mythicKeyService)
        {
            _guildService = guildService;
            _mythicKeyService = mythicKeyService;
        }
        [HttpGet("mythicscore")]
        public async Task<IActionResult> GetGuildMythicScore (string guildName)
        {
            return Ok(await _mythicKeyService.GetGuildMythicScore(guildName));
        }
    }
}

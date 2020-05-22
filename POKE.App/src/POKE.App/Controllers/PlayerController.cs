using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using POKE.App.Config;
using POKE.App.Dtos.Player;
using POKE.App.Services.Interface;

namespace POKE.App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        private IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        [Route("{playerId:int}")]
        public BasePlayer GetPlayer(int playerId)
        {
            return _playerService.GetPlayer(playerId);
        }
    }
}
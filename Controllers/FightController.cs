using dotnet_rpg_updated.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg_updated.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }
    }
}
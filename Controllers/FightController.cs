using System.Threading.Tasks;
using dotnet_rpg_updated.Dtos.Fight;
using dotnet_rpg_updated.Models;
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

        [HttpPost("Weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }
    }
}
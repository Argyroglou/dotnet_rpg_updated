using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg_updated.Dtos.Fight;
using dotnet_rpg_updated.Models;

namespace dotnet_rpg_updated.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighScoreDto>>> GetHighScore();
    }
}
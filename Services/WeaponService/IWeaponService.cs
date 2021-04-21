using System.Threading.Tasks;
using dotnet_rpg_updated.Dtos.Character;
using dotnet_rpg_updated.Dtos.Weapon;
using dotnet_rpg_updated.Models;

namespace dotnet_rpg_updated.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
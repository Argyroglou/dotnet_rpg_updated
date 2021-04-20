using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg_updated.Dtos.Character;
using dotnet_rpg_updated.Models;

namespace dotnet_rpg_updated.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
    }
}
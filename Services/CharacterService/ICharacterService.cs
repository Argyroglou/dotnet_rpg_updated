using System.Collections.Generic;
using dotnet_rpg_updated.Models;

namespace dotnet_rpg_updated.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);
    }
}
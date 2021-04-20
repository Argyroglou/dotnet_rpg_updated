using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg_updated.Models;

namespace dotnet_rpg_updated.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceRespone = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceRespone.Data = characters;
            return serviceRespone;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceRespone = new ServiceResponse<List<Character>>();
            serviceRespone.Data = characters;
            return serviceRespone;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceRespone = new ServiceResponse<Character>();
            serviceRespone.Data = characters.FirstOrDefault(c => c.Id == id);
            return serviceRespone;
        }
    }
}
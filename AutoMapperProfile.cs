using AutoMapper;
using dotnet_rpg_updated.Dtos.Character;
using dotnet_rpg_updated.Models;

namespace dotnet_rpg_updated
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
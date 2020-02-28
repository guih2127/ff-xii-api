using AutoMapper;
using FF_XII_API.Domain.Models;
using FF_XII_API.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FF_XII_API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Character, CharacterResource>();

            CreateMap<CharacterTypeCharacter, CharacterTypeCharacterResource>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CharacterType.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CharacterType.Name));
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FF_XII_API.Domain.Models;
using FF_XII_API.Domain.Services;
using FF_XII_API.Resources;
using Microsoft.AspNetCore.Mvc;

namespace FF_XII_API.Controllers
{
    [Route("/api/[controller]")]
    public class CharactersController : Controller
    {
        private readonly ICharacterService _characterService;
        private readonly IMapper _mapper;

        public CharactersController(ICharacterService characterService, IMapper mapper)
        {
            _characterService = characterService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CharacterResource>> GetAllAsync()
        {
            var characters = await _characterService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Character>, IEnumerable<CharacterResource>>(characters);

            return resources;
        }
    }
}
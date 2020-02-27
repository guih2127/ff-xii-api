using System.Collections.Generic;
using System.Threading.Tasks;
using FF_XII_API.Domain.Models;
using FF_XII_API.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace FF_XII_API.Controllers
{
    [Route("/api/[controller]")]
    public class CharactersController : Controller
    {
        private readonly ICharacterService _characterService;

        public CharactersController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<IEnumerable<Character>> GetAllAsync()
        {
            var characters = await _characterService.ListAsync();
            return characters;
        }
    }
}
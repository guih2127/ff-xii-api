using FF_XII_API.Domain.Models;
using FF_XII_API.Domain.Repository;
using FF_XII_API.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FF_XII_API.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;

        public CharacterService(ICharacterRepository characterRepository)
        {
            this._characterRepository = characterRepository;
        }

        public async Task<IEnumerable<Character>> ListAsync()
        {
            return await _characterRepository.ListAsync();
        }
    }
}

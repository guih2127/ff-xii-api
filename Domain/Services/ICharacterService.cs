using FF_XII_API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FF_XII_API.Domain.Services
{
    public interface ICharacterService
    {
        Task<IEnumerable<Character>> ListAsync();
    }
}
using FF_XII_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FF_XII_API.Domain.Repository
{
    public interface ICharacterRepository
    {
        Task<IEnumerable<Character>> ListAsync();
    }
}

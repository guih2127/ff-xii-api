using FF_XII_API.Domain.Models;
using FF_XII_API.Domain.Repository;
using FF_XII_API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FF_XII_API.Repositories
{
    public class CharacterRepository : BaseRepository, ICharacterRepository
    {
        public CharacterRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Character>> ListAsync()
        {
            return await _context.Characters.ToListAsync();
        }
    }
}

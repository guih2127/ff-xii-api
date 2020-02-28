using FF_XII_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FF_XII_API.Resources
{
    public class CharacterResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<CharacterTypeCharacterResource> CharacterTypes { get; set; } = new List<CharacterTypeCharacterResource>();
    }
}

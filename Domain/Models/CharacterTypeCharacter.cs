using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FF_XII_API.Domain.Models
{
    public class CharacterTypeCharacter
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public int CharacterTypeId { get; set; }
        public CharacterType CharacterType { get; set; }
    }
}

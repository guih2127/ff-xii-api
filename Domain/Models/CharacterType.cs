using System.Collections.Generic;

namespace FF_XII_API.Domain.Models
{
    public class CharacterType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<CharacterTypeCharacter> Characters { get; set; } = new List<CharacterTypeCharacter>();
    }
}

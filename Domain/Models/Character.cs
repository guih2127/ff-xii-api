using System.Collections.Generic;

namespace FF_XII_API.Domain.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public int? Age { get; set; }
        public int? Level { get; set; }
        public int? XP { get; set; }
        public int? LP { get; set; }
        public int? AP { get; set; }
        public int? Money { get; set; }

        public IList<CharacterTypeCharacter> CharacterTypes { get; set; } = new List<CharacterTypeCharacter>();

        public int GenderId { get; set; }
        public CharacterGender Gender { get; set; }
    }
}

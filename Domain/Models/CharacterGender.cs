using System.Collections.Generic;

namespace FF_XII_API.Domain.Models
{
    public class CharacterGender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Character> Characters { get; set; } = new List<Character>();
    }
}

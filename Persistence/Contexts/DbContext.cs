using FF_XII_API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FF_XII_API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterType> CharacterTypes { get; set; }
        public DbSet<CharacterGender> Genders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Character>().ToTable("Character");
            builder.Entity<Character>().HasKey(c => c.Id);
            builder.Entity<Character>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Character>().Property(c => c.Name).IsRequired().HasMaxLength(100);

            builder.Entity<CharacterType>().ToTable("CharacterType");
            builder.Entity<CharacterType>().HasKey(c => c.Id);
            builder.Entity<CharacterType>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<CharacterType>().Property(c => c.Name).IsRequired().HasMaxLength(100);

            builder.Entity<CharacterGender>().ToTable("CharacterGender");
            builder.Entity<CharacterGender>().HasKey(c => c.Id);
            builder.Entity<CharacterGender>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<CharacterGender>().Property(c => c.Name).IsRequired().HasMaxLength(100);


            // many-to-many relationship
            builder.Entity<CharacterTypeCharacter>()
                .HasKey(ctc => new { ctc.CharacterId, ctc.CharacterTypeId});
            builder.Entity<CharacterTypeCharacter>()
                .HasOne(ct => ct.Character)
                .WithMany(c => c.CharacterTypes)
                .HasForeignKey(ctc => ctc.CharacterId);
            builder.Entity<CharacterTypeCharacter>()
                .HasOne(ctc => ctc.CharacterType)
                .WithMany(t => t.Characters)
                .HasForeignKey(ctc => ctc.CharacterTypeId);

            builder.Entity<CharacterGender>().HasData
            (
                new CharacterGender { Id = 1, Name = "Gênero 1" },
                new CharacterGender { Id = 2, Name = "Gênero 2" }
            );

            builder.Entity<CharacterType>().HasData
            (
                new CharacterGender { Id = 1, Name = "Tipo 1" },
                new CharacterGender { Id = 2, Name = "Tipo 2" }
            );

            builder.Entity<CharacterTypeCharacter>().HasData
            (
                new CharacterTypeCharacter { CharacterId = 1, CharacterTypeId = 1 },
                new CharacterTypeCharacter { CharacterId = 1, CharacterTypeId = 2 },
                new CharacterTypeCharacter { CharacterId = 2, CharacterTypeId = 1 }
            );

            builder.Entity<Character>().HasData
            (
              new Character { Id = 1, Name = "Personagem 1", GenderId = 1 },
              new Character { Id = 2, Name = "Personagem 2", GenderId = 2 }
            );
        }
    }
}

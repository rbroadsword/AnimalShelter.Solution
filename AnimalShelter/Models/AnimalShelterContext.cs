using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
            .HasData(
                new Animal {AnimalId = 1, Name = "Jojo", Species = "Dog", Age = 4, Bio = "Great with kids!" },
                new Animal {AnimalId = 2, Name = "Lady Camden", Species = "Cat", Age = 8, Bio = "Old gal!" },
                new Animal {AnimalId = 3, Name = "Monet", Species = "Cat", Age = 6, Bio = "She's a loner" },
                new Animal {AnimalId = 4, Name = "Miss Fierce", Species = "Dog", Age = 2, Bio = "Gives good face!" },
                new Animal {AnimalId = 5, Name = "Gorgeous", Species = "Dog", Age = 1, Bio = "Active and spunky" }
            );
        }
    }
}
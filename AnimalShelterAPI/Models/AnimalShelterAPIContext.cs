using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Doug", Description = "Lovely", Gender = "Male", Age = 4 },
          new Cat { CatId = 2, Name = "Bruce", Description = "Lovely", Gender = "Male", Age = 2 },
          new Cat { CatId = 3, Name = "Steve", Description = "Lovely", Gender = "Male", Age = 5 },
          new Cat { CatId = 4, Name = "Carla", Description = "Lovely", Gender = "Female", Age = 9 },
          new Cat { CatId = 5, Name = "Betty", Description = "Lovely", Gender = "Female", Age = 18 }
        );
      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Mike", Description = "Lovely", Gender = "Male", Age = 4 },
          new Dog { DogId = 2, Name = "Dave", Description = "Lovely", Gender = "Male", Age = 2 },
          new Dog { DogId = 3, Name = "Buster", Description = "Lovely", Gender = "Male", Age = 5 },
          new Dog { DogId = 4, Name = "Penelope", Description = "Lovely", Gender = "Female", Age = 9 },
          new Dog { DogId = 5, Name = "Emma", Description = "Lovely", Gender = "Female", Age = 18 }
        );

    }

    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }
  }
}

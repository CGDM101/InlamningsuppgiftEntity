using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningsuppgiftEntity.Database
{
    /// <summary>
    /// DbContext för detta projekt
    /// </summary>
    public class GenealogiContext : DbContext
    {
        private const string DatabaseName = "CGGenealogi"; // står i klassen?
        public DbSet<GenealogiCRUD> MyRelatives { get; set; }
        public DbSet<Person> MyPeople { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True");
        }

        // Seeded data:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
            new Person { Id = 1, Name = "Dave", LastName = "Gahan", Mor = 2, Far = 3, BirthYear = 1962 },
            new Person { Id = 2, Name = "Sylvia", LastName = "Gahan", Mor = 0, Far = 0 },
            new Person { Id = 3, Name = "Len", LastName = "Gahan", Mor = 0, Far = 0 },
            new Person { Id = 4, Name = "Sue", LastName = "Gahan", Mor = 2, Far = 3 },
            new Person { Id = 5, Name = "Peter", LastName = "Gahan", Mor = 2, Far = 7 },
            new Person { Id = 6, Name = "Phil", LastName = "Gahan", Mor = 2, Far = 7 },
            new Person { Id = 7, Name = "Jack", LastName = "Gahan", Mor = 0, Far = 0 }, 
            new Person { Id = 8, Name = "Jack", LastName = "Gahan", Mor = 9, Far = 1 },
            new Person { Id = 9, Name = "Joanne", LastName = "Fox", Mor = 0, Far = 0 },
            new Person { Id = 10, Name = "Stella Rose", LastName = "Gahan", Mor = 11, Far = 1, BirthYear = 1999 },
            new Person { Id = 11, Name = "Jennifer", LastName = "Sklias-Gahan", Mor = 12, Far = 0, BirthYear = 1962 },
            new Person { Id = 12, Name = "Stella", LastName = "Sklias", Mor = 0, Far = 0 }, 
            new Person { Id = 13, Name = "Jimmy", LastName = "Rogers-Gahan", Mor = 11, Far = 0 });


            // ?
            List<Person> listOfAllPersons = new List<Person>();
            // lägg till dem


      
            // modelBuilder.Seed();

        }
    }
}

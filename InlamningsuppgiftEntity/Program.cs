using Microsoft.EntityFrameworkCore; // För att kunna använda DbContext
using System;
using System.Data;
using System.Data.SqlClient;

namespace InlamningsuppgiftEntity
{
    /// <summary>
    /// DbContext för detta  projekt
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
            modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Dave", LastName = "Gahan", Mor = 2, Far = 3 }, new Person { Id = 2, Name = "Sylvia", LastName = "Gahan", Mor = 0, Far = 0 }, new Person { Id = 3, Name = "Len", LastName = "Gahan", Mor = 0, Far = 0 }, new Person { Id = 4, Name = "Sue", LastName = "Gahan", Mor = 2, Far = 3 }, new Person { Id = 5, Name = "Peter", LastName = "Gahan", Mor = 2, Far = 7 }, new Person { Id = 6, Name = "Phil", LastName = "Gahan", Mor = 2, Far = 7 }, new Person { Id = 7, Name = "Jack", LastName = "Gahan", Mor = 0, Far = 0 }, new Person { Id = 8, Name = "Jack", LastName = "Gahan", Mor = 9, Far = 1 }, new Person { Id = 9, Name = "Joanne", LastName = "Fox", Mor = 0, Far = 0 }, new Person { Id = 10, Name = "Stella Rose", LastName = "Gahan", Mor = 11, Far = 1 }, new Person { Id = 11, Name = "Jennifer", LastName = "Sklias-Gahan", Mor = 12, Far = 0 }, new Person { Id = 12, Name = "Stella", LastName = "Sklias", Mor = 0, Far = 0 }, new Person { Id = 13, Name = "Jimmy", LastName = "Rogers-Gahan", Mor = 11, Far = 0 });



            // modelBuilder.Seed();
        }

    }
    /*
    
      DATABAS:
      a. En databas som du skapar från C#
      b. En eller flera tabeller som du skapar från C#
      c. Databasens namn ska vara dina intitaler + Genealogi (CGGenealogi)
      PROGRAM:
      a. All databaskommunikation ska ske genom Entity.
      b. Skapa databas
      c. Fyll i information
      d. Visa information om
      FUNKTIONALITET:
      Skapa en person
      b. Ange personens föräldrar
           i. Sök i databasen först, annars skapa dem.
           ii. Om personen finns redan, visa och föreslå att den ska användas.
      c. Editera person
      d. Radera person
      e. Lista alla personer
           i. Som börjar på en viss bokstav
           ii. Födda ett visst år
      f. Visa mor-/farföräldrar till en person
      g. Visa syskon till en person
     
     */

    /*
     Informationen som ska sparas är följande:
        Namn
        Efternamn
        Födelsedatum (år räcker)
        Dödsdatum (år räcker)
        Mor (enbart ID till en annan person)
        Far (enbart ID till en annan person)
        Vill du lägga till fler detaljer är det OK
     */
    class Program
    {
        public static object DatabaseName { get; private set; } = "CGGenealogi";

        static void Main(string[] args)
        {
            // Main-klassen ska bara instantiera och starta familjeträdet, inget annat.
            GenealogiCRUD myTree = new GenealogiCRUD();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Nu skapar vi en databas!");

            // Create person:
            // r
            // u
            // d

        }
    }
}

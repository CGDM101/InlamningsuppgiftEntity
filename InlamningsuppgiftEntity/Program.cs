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

        // OmMoelCreeating?
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            //CreateMyDatabase();
        }

        #region trams
        private static void CreateMyDatabase()
        {
            string str;
            SqlConnection myConn = new SqlConnection($@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True");

            str = "CREATE DATABASE MyDatabase ON PRIMARY " +
 "(NAME = MyDatabase_Data, " +
 "FILENAME = 'C:\\MyDatabaseData.mdf', " +
 "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
 "LOG ON (NAME = MyDatabase_Log, " +
 "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
 "SIZE = 1MB, " +
 "MAXSIZE = 5MB, " +
 "FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand(str, myConn);

            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                Console.WriteLine("Databas skapad");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("något gick fel: " + ex.ToString());
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        #endregion
    }
}

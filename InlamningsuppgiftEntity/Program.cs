using Microsoft.EntityFrameworkCore; // För att kunna använda DbContext
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace InlamningsuppgiftEntity
{
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
        public static object DatabaseName { get; private set; } = "CGGenealogi"; // ?

        static void Main(string[] args)
        {
            // Main-klassen ska bara instantiera och starta familjeträdet, inget annat.
            GenealogiCRUD myTree = new GenealogiCRUD();





            // Detta funkar:
            //Console.WriteLine("Lista alla personer (förnamn):");
            //using (var context = new Database.GenealogiContext())
            //{
            //    var allPeopleInDatabase = context.MyPeople.ToList();
            //    Console.WriteLine("varsågo:");
            //    foreach (var item in allPeopleInDatabase)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}

        }
    }
}

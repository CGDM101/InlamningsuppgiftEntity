using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace InlamningsuppgiftEntity.Database
{
    [Keyless] // Denna klass måste vara KeyLess enligt kompilatorn...
    public class GenealogiCRUD
    {
        //[Key] // Måste finnas en key?
        //public string DatabaseName { get; set; } = "CGGenealogi";
        public int MaxRows { get; set; } = 10; // Max rows to return when searching
        public string OrderBy { get; set; } = "lastName";
        public void Create(Person person) { /* Massor med kod */ }
        public void Delete(Person person) { /* Massor med kod */ }
        public void DoesPersonExist(string name) { /* Massor med kod */ }
        public void DoesPersonExist(int Id) { /* Massor med kod */ }
        public void GetFather(Person person) { /* Massor med kod */ }
        public void GetMother(Person person) { /* Massor med kod */ }
        //public List<Person> List(string filter = "firstName", string paramValue) { /* Massor med kod */ }
        //public Person Read(string name) { /* Massor med kod */ }
        public void Update(Person person) { /* Massor med kod */ }





        internal void ShowGrandParents()
        {
            throw new NotImplementedException();
        }

        internal void ShowChildrenOfPerson()
        {
            throw new NotImplementedException();
        }

        internal void UpdatePerson()
        {
            throw new NotImplementedException();
        }

        public void ReadAll() // Fungerar.
        {
            using (var context = new Database.GenealogiContext())
            {
                var allPeopleInDatabase = context.MyPeople.ToList();
                Console.WriteLine("Här är alla personer i databasen (enligt förnamn):");
                foreach (var item in allPeopleInDatabase)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

        internal void FindFatherOfPerson()
        {
            throw new NotImplementedException();
        }

        internal void FindMotherOfPerson()
        {
            throw new NotImplementedException();
        }

        public void AddPerson()
        {
            Console.Write("Id på den du vill lägga till: ");
            int inputId = int.Parse(Console.ReadLine());
            Console.Write("Förnamn på den du vill lägga till: ");
            string inputName = Console.ReadLine().Trim();
            Console.Write("Efternamn på den du vill lägga till: ");
            string inputLastname = Console.ReadLine().Trim();
            Console.Write("Mors Id på den du vill lägga till: ");
            int inputMotherId = int.Parse(Console.ReadLine());
            Console.Write("Fars Id på den du vill lägga till: ");
            int inputFatherId = int.Parse(Console.ReadLine());

            Person addedPerson = new Person { Id = inputId, Name = inputName, LastName = inputLastname, Mor = inputMotherId, Far = inputFatherId };
            using (var context = new GenealogiContext())
            {
                var newPerson = addedPerson;
                context.MyPeople.Add(newPerson);
                try
                {
                    context.SaveChanges();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Det funkade inte att lägga till personen... Felmeddelandet säger:");
                    Console.WriteLine(e.Message);
                    
                }
            }
            //Console.WriteLine("Person är tillagd."); // Nope, stämmer inte.
        }

        public void SearchForPersonByFirstName() // efternamn, id, mor, etc
        {
            Console.Write("Förnamn på den du vill söka efter: ");
            string input = Console.ReadLine().Trim().ToLower();

            bool doesExist = false;

            using (var context = new Database.GenealogiContext())
            {
                var all = context.MyPeople.ToList();
                for (int i = 0; i < all.Count; i++)
                {
                    if (all[i].Name.ToLower() == input)
                    {
                        doesExist = true;
                    }
                    else
                    {
                        doesExist = false;
                    }
                }
                if (doesExist == true)
                {
                    Console.WriteLine("Det finns en person med namnet " + input + " i listan!"); // Funkar inte trots att personen finns.
                }
                else
                {
                    Console.WriteLine("Det finns ingen med namnet " + input);
                }
                
            }
        }
    }
}

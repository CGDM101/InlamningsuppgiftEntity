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
            Console.WriteLine("Vems barn vill du visa?");
            Console.WriteLine("1. Daves och Jennifers barn.");
            Console.WriteLine("2. Daves barn.");
            Console.WriteLine("3. Jennifers barn.");
            Console.WriteLine("4. Sylvias barn.");
            Console.WriteLine("101. Avsluta");

            using (var context = new GenealogiContext())
            {
                var all = context.MyPeople.ToList(); // tab ort?

                var daveAndJenniferChildren = context.MyPeople.Where(a => a.Far == 1 && a.Mor == 11);
                var daveChildren = context.MyPeople.Where(c => c.Far == 1);
                var jenniferChildren = context.MyPeople.Where(c => c.Mor == 1); // Hon får inga??
                var sylviaChildren = context.MyPeople.Where(c => c.Mor == 2);


                int personToShowChildrenFrom = int.Parse(Console.ReadLine());

                switch (personToShowChildrenFrom)
                {
                    case 1:
                        foreach (var item in daveAndJenniferChildren)
                        {
                            Console.WriteLine(item.Name);
                        }
                        break;
                    case 2:
                        foreach (var item in daveChildren)
                        {
                            Console.WriteLine(item.Name);
                        }
                        break;
                    case 3:
                        foreach (var item in jenniferChildren)
                        {
                            Console.WriteLine(item.Name);
                        }
                        break;
                    case 4:
                        foreach (var item in sylviaChildren)
                        {
                            Console.WriteLine(item.Name);
                        }
                        break;
                    case 101:
                        break;
                    default:
                        Console.WriteLine("Du valde något ogiltigt.");
                        break;
                }
            }
        }

        internal void UpdatePerson()
        {
            throw new NotImplementedException();
        }

        public void ReadAll() // Fungerar.
        {
            using (var context = new GenealogiContext())
            {
                var allPeopleInDatabase = context.MyPeople.ToList();
                Console.WriteLine("Här är alla personer i databasen:");
                foreach (var item in allPeopleInDatabase)
                {
                    Console.WriteLine(item.Name + " " + item.LastName);
                }
            }            
        }

        internal void SearchPersonByBirthYear() // Fungerar.
        {
            Console.Write("Födelseår du vill hitta folk från: ");
            int input = int.Parse(Console.ReadLine().Trim());
            using (var context = new GenealogiContext())
            {
                var all = context.MyPeople.ToList();
                var find = context.MyPeople.Where(x => x.BirthYear == input);
                if (find == null) // Alternativ till try catch som inte fungerar...?!
                {
                    Console.WriteLine("Fanns ingen född det året.");
                }
                else
                {
                    Console.WriteLine("Denna/dessa personer är födda " + input);
                    foreach (var item in find)
                    {
                        Console.WriteLine(item.Name + " " + item.LastName);
                    }
                }
                //try
                //{
                //    Console.WriteLine(find.Name + " " + find.LastName);

                //}
                //catch (NullReferenceException e)
                //{
                //    Console.WriteLine("Fanns ingen född det året.");
                //    Console.WriteLine("Felmeddelandet säger: " + e);
                //}
            }
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

        public void SearchForPersonByFirstLetter()
        {
            Console.Write("Begynnelsebokstav du vill söka efter: ");
            string input = Console.ReadLine().Trim().ToLower();

            bool doesExist = false;

            using (var context = new GenealogiContext())
            {
                var all = context.MyPeople.ToList();
                var find = context.MyPeople.Where(z => z.Name.ToLower().Substring(0, 1) == input);
                // Where returnerar en array (även om den inte hittar något)
                // FirstOrDefault returnerar null om den inte hittar något

                // doesExist = find != null; 
                if (find != null) { doesExist = true; } // fixa dessa. DiesExist bkur akdrug false.
                if (find == null) { doesExist = false; }

                if (doesExist == true)
                {
                    Console.WriteLine("Det finns personer som börjar på " + input + "!");
                    Console.WriteLine("De är:");
                    foreach (var item in find)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
                else if (doesExist == false)
                {
                    Console.WriteLine("Det finns ingen med begynnelsebokstaven \'" + input + "\'");
                }
            }
        }
        
        internal void RemovePerson() { throw new NotImplementedException(); }

        internal void FindFatherOfPerson()
        {
            throw new NotImplementedException();
        }

        internal void FindMotherOfPerson()
        {
            throw new NotImplementedException();
        }
    }
}

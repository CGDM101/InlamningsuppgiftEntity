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
        public void GetFather(Person person) 
        {
            Person personToFindFatherFrom = new Person(); // p från menu
        
            /* Massor med kod */
        }
        public void GetMother(Person person) { /* Massor med kod */ }
        //public List<Person> List(string filter = "firstName", string paramValue) { /* Massor med kod */ }
        //public Person Read(string name) { /* Massor med kod */ }
        public void Update(Person person) { /* Massor med kod */ }




        internal void SearchPersonByBirthYear()
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

        internal void ShowGrandParents() { throw new NotImplementedException(); }

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

        internal void UpdatePerson() // WIP
        {
            ReadAll();
            Console.Write("Vem av dessa vill du ändra på? ");
            int input = int.Parse(Console.ReadLine());
            using (var context = new GenealogiContext())
            {
                var personToChange = context.MyPeople.Where(x => x.Id == input);
                Console.WriteLine("Vilken egenskap vill du ändra på?");
                foreach (var item in personToChange)
                {
                    Console.WriteLine("1. Förnamn (" + item.Name + ")");
                    Console.WriteLine("2. Efternamn (" + item.LastName + ")");
                    Console.WriteLine("3. Födelseår (" + item.BirthYear + ")");
                    Console.WriteLine("4. Mor (" + item.Mor + ")");
                    Console.WriteLine("5. Far (" + item.Far + ")");

                    int input2 = int.Parse(Console.ReadLine().Trim());
                    switch (input2)
                    {
                        case 1:
                            Console.Write("Vilket förnamn ska den ha istället? ");
                            string newName = Console.ReadLine().Trim();
                            item.Name = newName;
                            break;
                        case 2:
                            Console.Write("Vilket efternamn ska den ha istället? ");
                            string newLastName = Console.ReadLine().Trim();
                            item.LastName = newLastName;
                            break;
                        case 3:
                            Console.Write("Vilket födelseår ska den ha istället? ");
                            string newBirthYear = Console.ReadLine().Trim();
                            item.BirthYear = int.Parse(newBirthYear);
                            break;
                        case 4:
                            Console.Write("Vilken mor ska den ha istället? Välj nummer i listan ovan: ");
                            string newMotherId = Console.ReadLine().Trim();
                            item.Mor = int.Parse(newMotherId);
                            break;
                        case 5:
                            Console.Write("Vilken far ska den ha istället? Välj nummer i listan ovan: ");
                            string newFatherId = Console.ReadLine().Trim();
                            item.Far = int.Parse(newFatherId);
                            break;

                        default:
                            Console.WriteLine("nåt gick fel");
                            break;
                    }

                    try
                    {
                        context.SaveChanges(); // kraschar
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("felmeddelandet säger: " + e);
                    }


                    var find = context.MyPeople.Where(x => x.Id == input);
                    Console.WriteLine("Här är personens nya egenskaper:"); // Här har det uppdaterats dock!
                    Console.WriteLine(item.Id); // samma som förut
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.LastName);
                    Console.WriteLine(item.BirthYear);
                    Console.WriteLine(item.Mor);
                    Console.WriteLine(item.Far);
                }
            }
        }

        public void ReadAll()
        {
            using (var context = new GenealogiContext())
            {
                var allPeopleInDatabase = context.MyPeople.ToList();
                Console.WriteLine();
                Console.WriteLine("Här är alla personer i databasen:");
                int counter = 0;
                foreach (var item in allPeopleInDatabase)
                {
                    counter++;
                    Console.WriteLine(counter + ". " + item.Name + " " + item.LastName);
                }
            }
        }

        public void AddPerson()
        {
            Console.Write("Id på den du vill lägga till: "); // TODO kontrollera att den inte finns
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
        
        internal void RemovePerson() // WIP
        {
            ReadAll();
            Console.Write("Vem av dessa vill du ta bort från databasen? ");
            int input = int.Parse(Console.ReadLine());
            using (var context = new GenealogiContext())
            {
                IQueryable<Person> personToBeDeleted = context.MyPeople.Where(x => x.Id == input); // var
                foreach (var item in personToBeDeleted)
                {
                    Console.WriteLine("Ok, vi tar bort " + item.Name + " " + item.LastName);
                    try
                    {
                        context.Remove(personToBeDeleted); // FUNKAR INTE.
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Något gick fel, så här säger meddelandet: ");
                        Console.WriteLine(e);
                    }
                    
                    Console.WriteLine("Så här ser listan ut nu:"); // Personen har ej tagits bort.
                    ReadAll();
                }
            }
        }

        internal void FindFatherOfPerson()
        {
            ReadAll();
            Console.Write("Vems person vill du hitta fadern till? ");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine().Trim());
            }
            catch (Exception)
            {
                Console.WriteLine("Välj en siffra!");
            }

            using (var context = new GenealogiContext())
            {
                switch (input)
                {
                    case 1: // dave
                        var find = context.MyPeople.Where(x => x.Far == 3);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 2: // sylvia
                        var find2 = context.MyPeople.Where(x => x.Far == 0);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find2)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 3: // len
                        var find3 = context.MyPeople.Where(x => x.Far == 0);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find3)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 4: // sue
                        var find4 = context.MyPeople.Where(x => x.Far == 3);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find4)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 5: // peter
                        var find5 = context.MyPeople.Where(x => x.Far == 7);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find5)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 6: // phil
                        var find6 = context.MyPeople.Where(x => x.Far == 7);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find6)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 7: //jack far
                        var find7 = context.MyPeople.Where(x => x.Far == 0);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find7)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 8: // jack son
                        var find8 = context.MyPeople.Where(x => x.Far == 1);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find8)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 9: // joanne
                        var find9 = context.MyPeople.Where(x => x.Far == 0);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find9)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 10: //stella rose
                        var find10 = context.MyPeople.Where(x => x.Far == 1);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find10)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 11: // jennifer
                        var find11 = context.MyPeople.Where(x => x.Far == 0);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find11)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 12: // stella mor
                        var find12 = context.MyPeople.Where(x => x.Far == 0);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find12)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 13: // jimmy
                        var find13 = context.MyPeople.Where(x => x.Far == 1);
                        Console.WriteLine("Person/-er med denna far är:");
                        foreach (var item in find13)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        internal void FindMotherOfPerson()
        {
            ReadAll();
            Console.Write("Vems person vill du hitta modern till? ");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine().Trim());
            }
            catch (Exception)
            {
                Console.WriteLine("Välj en siffra!");
            }

            using (var context = new GenealogiContext())
            {
                switch (input)
                {
                    case 1: // dave
                        var find = context.MyPeople.Where(x => x.Mor == 2);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 2: // sylvia
                        var find2 = context.MyPeople.Where(x => x.Mor == 0);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find2)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 3: // len
                        var find3 = context.MyPeople.Where(x => x.Mor == 0);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find3)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 4: // sue
                        var find4 = context.MyPeople.Where(x => x.Mor == 2);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find4)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 5: // peter
                        var find5 = context.MyPeople.Where(x => x.Mor == 2);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find5)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 6: // phil
                        var find6 = context.MyPeople.Where(x => x.Mor == 2);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find6)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 7: //jack far
                        var find7 = context.MyPeople.Where(x => x.Mor == 0);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find7)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 8: // jack son
                        var find8 = context.MyPeople.Where(x => x.Mor == 9);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find8)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 9: // joanne
                        var find9 = context.MyPeople.Where(x => x.Mor == 0);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find9)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 10: //stella rose
                        var find10 = context.MyPeople.Where(x => x.Mor == 11);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find10)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 11: // jennifer
                        var find11 = context.MyPeople.Where(x => x.Mor == 12);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find11)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 12: // stella mor
                        var find12 = context.MyPeople.Where(x => x.Mor == 11);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find12)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    case 13: // jimmy
                        var find13 = context.MyPeople.Where(x => x.Mor == 11);
                        Console.WriteLine("Person/-er med denna mor är:");
                        foreach (var item in find13)
                        {
                            Console.WriteLine(item.Name + " " + item.LastName);
                        }
                        break;
                    //default:
                    //    Console.WriteLine("När kommer detta upp?");
                    //    break;
                }
            }
        }
    }
}

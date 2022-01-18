using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace InlamningsuppgiftEntity.Database
{
    [Keyless]
    public class GenealogiCRUD
    {
        internal void SearchPersonByBirthYear()
        {
            Console.Write("Födelseår du vill hitta folk från: ");
            int input = int.Parse(Console.ReadLine().Trim());
            using (var context = new GenealogiContext())
            {
                var all = context.MyPeople.ToList();
                var find = context.MyPeople.Where(x => x.BirthYear == input);
                if (find.Count() == 0)
                {
                    Console.WriteLine("Fanns ingen född det året.");
                }
                else if (find != null)
                {
                    Console.WriteLine("Denna/dessa personer är födda " + input);
                    foreach (var item in find)
                    {
                        Console.WriteLine(item.Name + " " + item.LastName);
                    }
                }
            }
        }

        internal void ShowGrandParents() 
        {
            using (var context = new GenealogiContext())
            {
                ReadAll();
                Console.Write("Vems mor- och farföräldrar vill du hitta? ");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: // dave
                        var theMother = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        var theFather = context.MyPeople.FirstOrDefault(X => X.Far == 3);
                        var theMothersMother = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother.Name + " " + theMothersMother.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather.Name + " " + theMothersFather.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother.Name + " " + theFathersMother.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather.Name + " " + theFathersFather.LastName);
                        break;

                    case 2: // sylvia
                        var theMother2 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFather2 = context.MyPeople.FirstOrDefault(X => X.Far == 0);
                        var theMothersMother2 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather2 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother2 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather2 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother2.Name + " " + theMothersMother2.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather2.Name + " " + theMothersFather2.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother2.Name + " " + theFathersMother2.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather2.Name + " " + theFathersFather2.LastName);
                        break;

                    case 3: // len
                        var theMother3 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFather3 = context.MyPeople.FirstOrDefault(X => X.Far == 0);
                        var theMothersMother3 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather3 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother3 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather3 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother3.Name + " " + theMothersMother3.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather3.Name + " " + theMothersFather3.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother3.Name + " " + theFathersMother3.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather3.Name + " " + theFathersFather3.LastName);
                        break;

                    case 4: // sue
                        var theMother4 = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        var theFather4 = context.MyPeople.FirstOrDefault(X => X.Far == 3);
                        var theMothersMother4 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather4 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother4 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather4 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother4.Name + " " + theMothersMother4.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather4.Name + " " + theMothersFather4.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother4.Name + " " + theFathersMother4.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather4.Name + " " + theFathersFather4.LastName);
                        break;

                    case 5: // peter
                        var theMother5 = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        var theFather5 = context.MyPeople.FirstOrDefault(X => X.Far == 7);
                        var theMothersMother5 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather5 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother5 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather5 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother5.Name + " " + theMothersMother5.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather5.Name + " " + theMothersFather5.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother5.Name + " " + theFathersMother5.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather5.Name + " " + theFathersFather5.LastName);
                        break;

                    case 6: // phil
                        var theMother6 = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        var theFather6 = context.MyPeople.FirstOrDefault(X => X.Far == 7);
                        var theMothersMother6 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather6 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother6 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather6 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother6.Name + " " + theMothersMother6.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather6.Name + " " + theMothersFather6.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother6.Name + " " + theFathersMother6.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather6.Name + " " + theFathersFather6.LastName);
                        break;

                    case 7: // jack son
                        var theMother7 = context.MyPeople.FirstOrDefault(x => x.Mor == 11);
                        var theFather7 = context.MyPeople.FirstOrDefault(X => X.Far == 1);
                        var theMothersMother7 = context.MyPeople.FirstOrDefault(x => x.Mor == 12);
                        var theMothersFather7 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother7 = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        var theFathersFather7 = context.MyPeople.FirstOrDefault(x => x.Far == 3);
                        Console.WriteLine("Mormor: " + theMothersMother7.Name + " " + theMothersMother7.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather7.Name + " " + theMothersFather7.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother7.Name + " " + theFathersMother7.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather7.Name + " " + theFathersFather7.LastName);
                        break;

                    case 8: // jack far
                        var theMother8 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFather8 = context.MyPeople.FirstOrDefault(X => X.Far == 0);
                        var theMothersMother8 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather8 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother8 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather8 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother8.Name + " " + theMothersMother8.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather8.Name + " " + theMothersFather8.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother8.Name + " " + theFathersMother8.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather8.Name + " " + theFathersFather8.LastName);
                        break;

                    case 9: // joanne
                        var theMother9 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFather9 = context.MyPeople.FirstOrDefault(X => X.Far == 0);
                        var theMothersMother9 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather9 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother9 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather9 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother9.Name + " " + theMothersMother9.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather9.Name + " " + theMothersFather9.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother9.Name + " " + theFathersMother9.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather9.Name + " " + theFathersFather9.LastName);
                        break;

                    case 10: // stella rose
                        var theMother10 = context.MyPeople.FirstOrDefault(x => x.Mor == 11);
                        var theFather10 = context.MyPeople.FirstOrDefault(X => X.Far == 1);
                        var theMothersMother10 = context.MyPeople.FirstOrDefault(x => x.Mor == 12);
                        var theMothersFather10 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother10 = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        var theFathersFather10 = context.MyPeople.FirstOrDefault(x => x.Far == 3);
                        Console.WriteLine("Mormor: " + theMothersMother10.Name + " " + theMothersMother10.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather10.Name + " " + theMothersFather10.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother10.Name + " " + theFathersMother10.LastName); 
                        Console.WriteLine("Farfar: " + theFathersFather10.Name + " " + theFathersFather10.LastName);
                        break;

                    case 11: // jennifer
                        var theMother11 = context.MyPeople.FirstOrDefault(x => x.Mor == 12);
                        var theFather11 = context.MyPeople.FirstOrDefault(X => X.Far == 0);
                        var theMothersMother11 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather11 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother11 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather11 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother11.Name + " " + theMothersMother11.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather11.Name + " " + theMothersFather11.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother11.Name + " " + theFathersMother11.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather11.Name + " " + theFathersFather11.LastName);
                        break;

                    case 12: // stella
                        var theMother12 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFather12 = context.MyPeople.FirstOrDefault(X => X.Far == 0);
                        var theMothersMother12 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theMothersFather12 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother12 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather12 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother12.Name + " " + theMothersMother12.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather12.Name + " " + theMothersFather12.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother12.Name + " " + theFathersMother12.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather12.Name + " " + theFathersFather12.LastName);
                        break;

                    case 13: // jimmy
                        var theMother13 = context.MyPeople.FirstOrDefault(x => x.Mor == 11);
                        var theFather13 = context.MyPeople.FirstOrDefault(X => X.Far == 0);
                        var theMothersMother13 = context.MyPeople.FirstOrDefault(x => x.Mor == 12);
                        var theMothersFather13 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        var theFathersMother13 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        var theFathersFather13 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Mormor: " + theMothersMother13.Name + " " + theMothersMother13.LastName);
                        Console.WriteLine("Morfar: " + theMothersFather13.Name + " " + theMothersFather13.LastName);
                        Console.WriteLine("Farmor: " + theFathersMother13.Name + " " + theFathersMother13.LastName);
                        Console.WriteLine("Farfar: " + theFathersFather13.Name + " " + theFathersFather13.LastName);
                        break;

                    default:
                        break;
                }
            }
        }

        internal void ShowChildrenOfPerson()
        {
            ReadAll();
            Console.WriteLine("Vems barn vill du visa, av personerna ovan?");

            using (var context = new GenealogiContext())
            {
                var onesChildren = context.MyPeople.Where(x => x.Far == 1);
                var twosChildren = context.MyPeople.Where(x => x.Mor == 2);
                var threesChildren = context.MyPeople.Where(x => x.Far == 3);
                var fourthsChildren = context.MyPeople.Where(x => x.Mor == 4);
                var fifthsChildren = context.MyPeople.Where(x => x.Far == 5);
                var sixthsChildren = context.MyPeople.Where(x => x.Far == 6);
                var seventhsChildren = context.MyPeople.Where(x => x.Far == 7);
                var eightsChildren = context.MyPeople.Where(x => x.Far == 8);
                var ninthsChildren = context.MyPeople.Where(x => x.Mor == 9);
                var tenthsChildren = context.MyPeople.Where(x => x.Mor == 10);
                var eleventhsChildren = context.MyPeople.Where(x => x.Mor == 11);
                var twelwthsChildren = context.MyPeople.Where(x => x.Mor == 12);
                var thirteenthsChildren = context.MyPeople.Where(x => x.Far == 13);

                string personToShowChildrenFrom = Console.ReadLine().Trim();

                switch (personToShowChildrenFrom)
                {
                    case "1":
                        Console.WriteLine("Denna persons barn:");
                        if (onesChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in onesChildren) Console.WriteLine(item.Name);
                        break;
                    case "2":
                        Console.WriteLine("Denna persons barn:");
                        if (twosChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in twosChildren) Console.WriteLine(item.Name);
                        break;
                    case "3":
                        Console.WriteLine("Denna persons barn:");
                        if (threesChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in threesChildren) Console.WriteLine(item.Name);
                        break;
                    case "4":
                        Console.WriteLine("Denna persons barn:");
                        if (fourthsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in fourthsChildren) Console.WriteLine(item.Name);
                        break;
                    case "5":
                        Console.WriteLine("Denna persons barn:");
                        if (fifthsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in fifthsChildren) Console.WriteLine(item.Name);
                        break;
                    case "6":
                        Console.WriteLine("Denna persons barn:");
                        if (sixthsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in sixthsChildren) Console.WriteLine(item.Name);
                        break;
                    case "7":
                        Console.WriteLine("Denna persons barn:");
                        if (seventhsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in seventhsChildren) Console.WriteLine(item.Name);
                        break;
                    case "8":
                        Console.WriteLine("Denna persons barn:");
                        if (eightsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in eightsChildren) Console.WriteLine(item.Name);
                        break;
                    case "9":
                        Console.WriteLine("Denna persons barn:");
                        if (ninthsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in ninthsChildren) Console.WriteLine(item.Name);
                        break;
                    case "10":
                        Console.WriteLine("Denna persons barn:");
                        if (tenthsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in tenthsChildren) Console.WriteLine(item.Name);
                        break;
                    case "11":
                        Console.WriteLine("Denna persons barn:");
                        if (eleventhsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in eleventhsChildren) Console.WriteLine(item.Name);
                        break;
                    case "12":
                        Console.WriteLine("Denna persons barn:");
                        if (twelwthsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in twelwthsChildren) Console.WriteLine(item.Name);
                        break;
                    case "13":
                        Console.WriteLine("Denna persons barn:");
                        if (thirteenthsChildren.Count() == 0) Console.WriteLine("Har inga barn");
                        foreach (var item in thirteenthsChildren) Console.WriteLine(item.Name);
                        break;

                    default:
                        Console.WriteLine("Du valde en siffra på en person som inte finns med i databasen eller så valde du inte en siffra, utan en bokstav eller ett specialtecken.");
                        break;
                }
            }
        }
        
        internal void UpdatePerson()
        {
            ReadAll();
            Console.Write("Vem av dessa vill du ändra på? ");
            int input = int.Parse(Console.ReadLine());
            using (var context = new GenealogiContext())
            {
                var personToChange = context.MyPeople.FirstOrDefault(x => x.Id == input);
                Console.WriteLine("Vilken egenskap vill du ändra på?");

                Console.WriteLine("1. Förnamn (" + personToChange.Name + ")");
                Console.WriteLine("2. Efternamn (" + personToChange.LastName + ")");
                Console.WriteLine("3. Födelseår (" + personToChange.BirthYear + ")");
                Console.WriteLine("4. Mor (" + personToChange.Mor + ")");
                Console.WriteLine("5. Far (" + personToChange.Far + ")");

                int input2 = int.Parse(Console.ReadLine().Trim());
                switch (input2)
                {
                    case 1:
                        Console.Write("Vilket förnamn ska den ha istället? ");
                        string newName = Console.ReadLine().Trim();
                        personToChange.Name = newName;
                        break;
                    case 2:
                        Console.Write("Vilket efternamn ska den ha istället? ");
                        string newLastName = Console.ReadLine().Trim();
                        personToChange.LastName = newLastName;
                        break;
                    case 3:
                        Console.Write("Vilket födelseår ska den ha istället? ");
                        string newBirthYear = Console.ReadLine().Trim();
                        personToChange.BirthYear = int.Parse(newBirthYear);
                        break;
                    case 4:
                        Console.Write("Vilken mor ska den ha istället? Välj nummer i listan ovan: ");
                        string newMotherId = Console.ReadLine().Trim();
                        personToChange.Mor = int.Parse(newMotherId);
                        break;
                    case 5:
                        Console.Write("Vilken far ska den ha istället? Välj nummer i listan ovan: ");
                        string newFatherId = Console.ReadLine().Trim();
                        personToChange.Far = int.Parse(newFatherId);
                        break;

                    default:
                        Console.WriteLine("nåt gick fel");
                        break;
                }

                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine("felmeddelandet säger: " + e);
                }

                var find = context.MyPeople.Where(x => x.Id == input);
                Console.WriteLine("Här är personens nya egenskaper:");
                Console.WriteLine(personToChange.Id);
                Console.WriteLine(personToChange.Name);
                Console.WriteLine(personToChange.LastName);
                Console.WriteLine(personToChange.BirthYear);
                Console.WriteLine(personToChange.Mor);
                Console.WriteLine(personToChange.Far);
            }
        }

        public void ReadAll()
        {
            using (var context = new GenealogiContext())
            {
                var allPeopleInDatabase = context.MyPeople.ToList();
                Console.WriteLine();
                Console.WriteLine("Här är alla personer i databasen:");
                foreach (var item in allPeopleInDatabase)
                {
                    
                    Console.WriteLine(item.Id + ". " + item.Name + " " + item.LastName);
                }
            }
        }

        public void AddPerson()
        {
            Console.Write("Förnamn på den du vill lägga till: ");
            string inputName = Console.ReadLine().Trim();
            Console.Write("Efternamn på den du vill lägga till: ");
            string inputLastname = Console.ReadLine().Trim();
            Console.Write("Mors Id på den du vill lägga till: ");
            int inputMotherId = int.Parse(Console.ReadLine());
            Console.Write("Fars Id på den du vill lägga till: ");
            int inputFatherId = int.Parse(Console.ReadLine());

            Person addedPerson = new Person { Name = inputName, LastName = inputLastname, Mor = inputMotherId, Far = inputFatherId };
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
            Console.WriteLine("Person är tillagd.");
        }

        public void SearchForPersonByFirstLetter()
        {
            Console.Write("Begynnelsebokstav du vill söka efter: ");
            string input = Console.ReadLine().Trim().ToLower();

            bool doesExist = false;

            // ett alternativ man hade kunnat använda istället:
            //string myString = "abcdefghijklmnopqrstuvxyz";
            //if (myString.Contains(input)) ;
            if (input == "a" || input == "b" || input == "c" || input == "d" || input == "e" || input == "f" || input == "g" || input == "h" || input == "i" || input == "j" || input == "k" || input == "l" || input == "m" || input == "n" || input == "o" || input == "p" || input == "q" || input == "r" || input == "s" || input == "t" || input == "u" || input == "v" || input == "x" || input == "y" || input == "z")
            {
                using (var context = new GenealogiContext())
                {
                    var all = context.MyPeople.ToList();
                    var find = context.MyPeople.Where(z => z.Name.ToLower().Substring(0, 1) == input);

                    if (find.Count() != 0) { doesExist = true; }
                    if (find.Count() == 0) { doesExist = false; }

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
            else
            {
                Console.WriteLine("Skriv in giltig bokstav!");
                Console.WriteLine(input + " är inte en giltig bokstav");
            }
        }

        internal void RemovePerson()
        {
            ReadAll();
            Console.Write("Vem av dessa vill du ta bort från databasen? ");
            int input = int.Parse(Console.ReadLine());
            using (var context = new GenealogiContext())
            {
                Person personToBeDeleted = context.MyPeople.FirstOrDefault(x => x.Id == input); // var
                context.Remove(personToBeDeleted);
                context.SaveChanges();

                Console.WriteLine("Så här ser listan ut nu:");
                ReadAll();
            }
        }

        internal void FindFatherOfPerson()
        {
            ReadAll();
            Console.WriteLine();
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
                        var theFather = context.MyPeople.FirstOrDefault(x => x.Far == 3);
                        Console.WriteLine("Denna persons far: " + theFather.Name + " " + theFather.LastName);
                        break;
                    case 2: // sylvia
                        var theFather2 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Denna person har ingen fader.");
                        Console.WriteLine("Lägg till fader:");
                        AddPerson();
                        break;
                    case 3: // len
                        var theFather3 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Denna person har ingen fader.");
                        Console.WriteLine("Lägg till fader:");
                        AddPerson();
                       break;
                    case 4: // sue
                        var theFather4 = context.MyPeople.FirstOrDefault(x => x.Far == 3);
                        Console.WriteLine("Denna persons far: " + theFather4.Name + " " + theFather4.LastName);
                        break;
                    case 5: // peter
                        var theFather5 = context.MyPeople.FirstOrDefault(x => x.Far == 7);
                        Console.WriteLine("Denna persons far: " + theFather5.Name + " " + theFather5.LastName);
                        break;
                    case 6: // phil
                        var theFather6 = context.MyPeople.FirstOrDefault(x => x.Far == 7);
                        Console.WriteLine("Denna persons far: " + theFather6.Name + " " + theFather6.LastName);
                        break;
                    case 7: //jack far
                        var theFather7 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Denna person har ingen fader.");
                        Console.WriteLine("Lägg till fader:");
                        AddPerson();
                        break;
                    case 8: // jack son
                        var theFather8 = context.MyPeople.FirstOrDefault(x => x.Far == 1);
                        Console.WriteLine("Denna persons far: " + theFather8.Name + " " + theFather8.LastName);
                        break;
                    case 9: // joanne
                        var theFather9 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Denna person har ingen fader.");
                        Console.WriteLine("Lägg till fader:");
                        AddPerson();
                        break;
                    case 10: //stella rose
                        var theFather10 = context.MyPeople.FirstOrDefault(x => x.Far == 1);
                        Console.WriteLine("Denna persons far: " + theFather10.Name + " " + theFather10.LastName);
                        break;
                    case 11: // jennifer
                        var theFather11 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Denna person har ingen fader.");
                        Console.WriteLine("Lägg till fader:");
                        AddPerson();
                        break;
                    case 12: // stella mor
                        var theFather12 = context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Denna person har ingen fader.");
                        Console.WriteLine("Lägg till fader:");
                        AddPerson();
                        break;
                    case 13: // jimmy
                        var theFather13= context.MyPeople.FirstOrDefault(x => x.Far == 0);
                        Console.WriteLine("Denna person har ingen fader.");
                        Console.WriteLine("Lägg till fader:");
                        AddPerson();
                        break;
                    default:
                        break;
                }
            }
        }

        internal void FindMotherOfPerson()
        {
            ReadAll();
            Console.WriteLine();
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
                        var theMother = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        Console.WriteLine("Denna persons mor: " + theMother.Name + " " + theMother.LastName);
                        break;
                    case 2: // sylvia
                        var theMother2 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        Console.WriteLine("Denna person har ingen moder.");
                        Console.WriteLine("Lägg till moder:");
                        AddPerson();
                        break;
                    case 3: // len
                        var theMother3 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        Console.WriteLine("Denna person har ingen moder.");
                        Console.WriteLine("Lägg till moder:");
                        AddPerson();
                        break;
                    case 4: // sue
                        var theMother4 = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        Console.WriteLine("Denna persons mor: " + theMother4.Name + " " + theMother4.LastName);
                        break;
                    case 5: // peter
                        var theMother5 = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        Console.WriteLine("Denna persons mor: " + theMother5.Name + " " + theMother5.LastName);
                        break;
                    case 6: // phil
                        var theMother6 = context.MyPeople.FirstOrDefault(x => x.Mor == 2);
                        Console.WriteLine("Denna persons mor: " + theMother6.Name + " " + theMother6.LastName);
                        break;
                    case 7: //jack far
                        var theMother7 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        Console.WriteLine("Denna person har ingen moder.");
                        Console.WriteLine("Lägg till moder:");
                        AddPerson();
                        break;
                    case 8: // jack son
                        var theMother8 = context.MyPeople.FirstOrDefault(x => x.Mor == 9);
                        Console.WriteLine("Denna persons mor: " + theMother8.Name + " " + theMother8.LastName);
                        break;
                    case 9: // joanne
                        var theMother9 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        Console.WriteLine("Denna person har ingen moder.");
                        Console.WriteLine("Lägg till moder:");
                        AddPerson();
                        break;
                    case 10: //stella rose
                        var theMother10 = context.MyPeople.FirstOrDefault(x => x.Mor == 11);
                        Console.WriteLine("Denna persons mor: " + theMother10.Name + " " + theMother10.LastName);
                        break;
                    case 11: // jennifer
                        var theMother11 = context.MyPeople.FirstOrDefault(x => x.Mor == 12);
                        Console.WriteLine("Denna persons mor: " + theMother11.Name + " " + theMother11.LastName);
                        break;
                    case 12: // stella mor
                        var theMother12 = context.MyPeople.FirstOrDefault(x => x.Mor == 0);
                        Console.WriteLine("Denna person har ingen moder.");
                        Console.WriteLine("Lägg till moder:");
                        AddPerson();
                        break;
                    case 13: // jimmy
                        var theMother13 = context.MyPeople.FirstOrDefault(x => x.Mor == 11);
                        Console.WriteLine("Denna persons mor: " + theMother13.Name + " " + theMother13.LastName);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
        
    

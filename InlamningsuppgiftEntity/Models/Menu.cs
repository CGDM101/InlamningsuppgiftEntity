using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlamningsuppgiftEntity.Database;

namespace InlamningsuppgiftEntity.Models
{
    public class Menu
    {
        public void MenuShow(GenealogiCRUD myTree)
        {
            string input = "";
            while (input != "q") // Programmet fortsätter tills de trycker q.
            {
                Console.WriteLine();
                Console.WriteLine("Välj vad du vill göra!");
                Console.WriteLine("1. Se alla personer från listan."); // FUNKAR.
                Console.WriteLine("2. Lägga till person."); // FUNKAR INTE se felmedd!
                Console.WriteLine("3. Söka efter person som börjar på viss bokstav. "); // FUNKAR delvis, fixa null-grejen.
                Console.WriteLine("4. Söka efter person född visst år. "); // FUNKAR.
                Console.WriteLine("5. Visa mor- och farföräldrar för en person. ");
                Console.WriteLine("6. Visa lista på någons barn. "); // FUNKAR delvis, utom Jennifer. 
                Console.WriteLine("7. Ändra på person. ");
                Console.WriteLine("8. Visa persons mor. "); // söka först om den finns, annars skapa.
                Console.WriteLine("9. Visa persons far. "); // söka först
                Console.WriteLine("10. Radera person från databas.");
                Console.WriteLine("Q. Avsluta");

                input = Console.ReadLine().Trim().ToLower();
                switch (input)
                {
                    case "test":
                        Console.WriteLine("vem:");
                        string answer = Console.ReadLine();
                        Person p = new Person();
                        myTree.GetFather(p);
                        break;

                    case "1":
                        myTree.ReadAll();
                        break;
                    case "2":
                        myTree.AddPerson();
                        break;
                    case "3":
                        myTree.SearchForPersonByFirstLetter();
                        break;
                    case "4":
                        myTree.SearchPersonByBirthYear();
                        break;
                    case "5":
                        myTree.ShowGrandParents();
                        break;
                    case "6":
                        myTree.ShowChildrenOfPerson();
                        break;
                    case "7":
                        myTree.UpdatePerson();
                        break;
                    case "8":
                        myTree.FindMotherOfPerson(); // ej korr okänd mor
                        break;
                    case "9":
                        myTree.FindFatherOfPerson(); // ej korrekt för folk med okänd far.
                        break;
                    case "10":
                        myTree.RemovePerson();
                        break;
                    case "q":
                        Console.WriteLine("Hejdå, programmet avslutas.");
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;

                }
            }
        }
    }
}

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
            Console.WriteLine("Välj vad du vill göra!");
            Console.WriteLine("1. Se alla personer från listan.");
            Console.WriteLine("2. Lägga till person.");
            Console.WriteLine("3. Söka efter person enligt förnamn. "); // + andra saker
            Console.WriteLine("4. Visa mor- och farföräldrar för en person. ");
            Console.WriteLine("5. Visa lista på någons barn. ");
            Console.WriteLine("6. Ändra på person. ");
            Console.WriteLine("7. Visa persons mor. ");
            Console.WriteLine("8. Visa persons far. ");
            Console.WriteLine("9. Radera person från databas.");
            Console.WriteLine("Q. Avsluta");

            string input = Console.ReadLine().Trim().ToLower();
            switch (input)
            {
                case "1":
                    myTree.ReadAll();
                    break;
                case "2":
                    myTree.AddPerson();
                    break;
                case "3":
                    myTree.SearchForPersonByFirstName();
                    break;
                case "4":
                    myTree.ShowGrandParents();
                    break;
                case "5":
                    myTree.ShowChildrenOfPerson();
                    break;
                case "6":
                    myTree.UpdatePerson();
                    break;
                case "7":
                    myTree.FindMotherOfPerson();
                    break;
                case "8":
                    myTree.FindFatherOfPerson();
                    break;
                case "9":
                    myTree.RemovePerson();
                    break;
                case "q":
                    Console.WriteLine("Hejdå, programmet avslutas.");
                    break;
                default:
                    Console.WriteLine("Ogiltig val.");
                    break;

            }
        }
    }
}

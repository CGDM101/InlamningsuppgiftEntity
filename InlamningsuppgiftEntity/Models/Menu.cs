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
            Console.WriteLine("3. Söka efter person enligt förnamn. ");
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

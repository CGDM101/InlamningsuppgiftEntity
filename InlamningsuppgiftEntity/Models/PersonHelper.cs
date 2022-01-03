using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlamningsuppgiftEntity.Database;
using InlamningsuppgiftEntity.Models;

namespace InlamningsuppgiftEntity.Models
{
    class PersonHelper
    {
        public Person FindPerson(Person person) 
        {
            Console.Write("Förnamn på den du vill hitta: ");
            string firstNameToBeRemoved = Console.ReadLine().Trim();
            Console.Write("Efternamn på den du vill ta bort: ");
            string lastNameToBeRemoved = Console.ReadLine().Trim();
            // för varje person i listan
            // om listpersonen == inputpersonen
            // list.removeatindex
            return person;
        }

        public Person FindPersonOverloaded(string firstName) 
        {
            Console.Write("Förnamn: ");
            string input = Console.ReadLine().Trim().ToLower();
            Person firstNamePerson = new Person { };
            using (var context = new GenealogiContext())
            {
                var all = context.MyPeople.ToList();
                for (int i = 0; i < all.Count; i++)
                {
                    if (all[i].Name.ToLower() == input)
                    {
                        firstNamePerson = all[i];
                    }
                    else
                    {
                        firstNamePerson = null;
                        Console.WriteLine("Fanns ingen med det förnamnet.");
                    }
                }
            }
            return firstNamePerson;

        }
        //public Person FindPersonOverloaded(string lastName) { }
        //public Person FindPersonOverloaded(int id) { }
        //public Person FindPersonOverloaded(string motherId) { }
        //public Person FindPersonOverloaded(string fatherId) { }
    }
}

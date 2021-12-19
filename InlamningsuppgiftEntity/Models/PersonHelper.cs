using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlamningsuppgiftEntity.Database;

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

        public Person FindPersonOverloaded(string firstName) { }
        public Person FindPersonOverloaded(string lastName) { }
        public Person FindPersonOverloaded(int id) { }
        public Person FindPersonOverloaded(string motherId) { }
        public Person FindPersonOverloaded(string fatherId) { }
    }
}

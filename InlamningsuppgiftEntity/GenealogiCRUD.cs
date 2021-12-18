using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InlamningsuppgiftEntity
{
    public class GenealogiCRUD
    {
        [Key] // Måste finnas en key?
        public string DatabaseName { get; set; } = "CGGenealogi";
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
    }
}

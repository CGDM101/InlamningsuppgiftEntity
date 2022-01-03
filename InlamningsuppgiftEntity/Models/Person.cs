using System.ComponentModel.DataAnnotations; // [Key]

namespace InlamningsuppgiftEntity
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Mor { get; set; }
        public int Far { get; set; }
        public int BirthYear { get; set; }
    }
}

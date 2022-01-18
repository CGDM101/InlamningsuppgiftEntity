using InlamningsuppgiftEntity.Database;
using InlamningsuppgiftEntity.Models; // För att kunna använda Menuklassen.

namespace InlamningsuppgiftEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Main-klassen ska bara instantiera och starta familjeträdet, inget annat."
            GenealogiCRUD myTree = new GenealogiCRUD();

            Menu m = new Menu();
            m.MenuShow(myTree);
        }
    }
}

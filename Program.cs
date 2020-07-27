using System;

namespace ApresentacaoUmEstagioB
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new Bar();

            Console.WriteLine("Printing menus ordered by name in upper case\n-------------");
            bar.ShowMenusOrderedByNameUpperCase();
            Console.WriteLine("Printing items ordered by name in lower case\n-------------");
            bar.ShowItemsOrderByNameLowerCase();
            Console.WriteLine("Printing everything ordered by description\n-------------");
            bar.ShowAllOrderedByDescription();
        }
    }
}
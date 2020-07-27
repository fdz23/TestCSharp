using System;
using System.Collections.Generic;
using System.Text;

namespace ApresentacaoUmEstagioB
{
    class Menu : MenuAbstract
    {
        public Menu(string name, string description) : base(name, description)
        {

        }

        public void PrintUpper()
        {
            Console.WriteLine($"{Nome.ToUpper()}\n{Descricao.ToUpper()}");
        }

        public override void Print()
        {
            Console.WriteLine("I'm a menu");
            base.Print();
        }
    }
}
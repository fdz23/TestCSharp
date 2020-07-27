using System;
using System.Collections.Generic;
using System.Text;

namespace ApresentacaoUmEstagioB
{
    class SubMenu : Menu
    {
        public SubMenu(string name, string description) : base(name, description)
        {

        }

        public void PrintSubMenu()
        {
            Console.WriteLine($"I'm a SubMenu now\n{Name}\n{Description}");
        }

        public override void Print()
        {
            Console.WriteLine("I'm a SubMenu");
            base.Print();
        }
    }
}
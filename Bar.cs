using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ApresentacaoUmEstagioB
{
    class Bar
    {
        private List<MenuAbstract> menus = new List<MenuAbstract>();
        public Bar()
        {
            menus.Add(new Menu("Menu de bebidas", "Tem todas as bebidas do bar"));
            menus.Add(new MenuItem("51", "Cachaça com 50% de álcool", 7.00));
            menus.Add(new MenuItem("Ypioca", "Cachaça com 50% de álcool", 20.00));
            menus.Add(new MenuItem("Vodka", "Smirnoff com 45% de álcool", 40.00));
            menus.Add(new Menu("Menu de comidas", "Tem os lanches do bar"));
            menus.Add(new MenuItem("Coxinha", "Salgado de frango", 3.50));
            menus.Add(new MenuItem("Empada", "Salgado de carne", 4.50));
            menus.Add(new SubMenu("Submenu de sobremesas", "Tem as sobramesas do bar"));
            menus.Add(new MenuItem("Pudim", "Doce feito com doce de leite", 6.00));
            menus.Add(new MenuItem("Paçoca", "Doce feito de amendoim", 1.50));
        }

        public void ShowMenusOrderedByNameUpperCase()
        {
            var items = menus
                .Where(x => x is Menu)
                .OrderBy(x => x.Nome);

            foreach (Menu item in items)
            {
                item.MostrarNaTelaUpper();
                Console.WriteLine("-------------");
            }
        }

        public void ShowItemsOrderByNameLowerCase()
        {
            var items = menus
                .Where(x => x is MenuItem)
                .OrderBy(x => x.Nome);

            foreach (MenuItem item in items)
            {
                item.MostrarNaTelaLower();
                Console.WriteLine("-------------");
            }
        }

        public void ShowAllOrderedByDescription()
        {
            var items = menus
                .OrderBy(x => x.Descricao);

            foreach (MenuAbstract item in items)
            {
                item.MostrarNaTela();
                Console.WriteLine("-------------");
            }
        }
    }
}
using System.Globalization;

namespace ApresentacaoUmEstagioB
{
    class MenuItem : MenuAbstract
    {
        public double Price { get; set; }
        public MenuItem(string name, string description, double price) : base(name, description)
        {
            Price = price;
        }
        public void PrintLower()
        {
            string price = Price.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            System.Console.WriteLine($"{Name.ToLower()}\n{Description.ToLower()}\n{price}");
            System.Console.WriteLine("-------------");
        }

        public override void Print()
        {
            System.Console.WriteLine("I'm a MenuItem");
            base.Print();
        }
    }
}
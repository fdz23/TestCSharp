namespace ApresentacaoUmEstagioB
{
    abstract class MenuAbstract
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public MenuAbstract(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public virtual void Print()
        {
            System.Console.WriteLine("I'm a MenuAbstract");
            System.Console.WriteLine($"{Name}\n{Description}");
            System.Console.WriteLine("-------------");
        }
    }
}
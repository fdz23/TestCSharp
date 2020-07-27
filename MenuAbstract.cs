namespace ApresentacaoUmEstagioB
{
    abstract class MenuAbstract
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public MenuAbstract(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
        public virtual void MostrarNaTela()
        {
            System.Console.WriteLine($"{Nome}\n{Descricao}");
        }
    }
}
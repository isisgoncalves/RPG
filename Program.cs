class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();

        string raca = Console.ReadLine();

        string classe = Console.ReadLine();

        Personagem personagem = new Personagem(nome, raca, classe);

        personagem.ExibirStatus();
    }
}

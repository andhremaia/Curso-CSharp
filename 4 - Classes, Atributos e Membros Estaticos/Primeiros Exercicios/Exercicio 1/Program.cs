namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Console.WriteLine("Pessoa 1: ");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine()!;
            Console.Write("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine()!);

            Pessoa pessoa2 = new Pessoa();
            Console.WriteLine("Pessoa 2: ");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine()!;
            Console.Write("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine()!);

            if (pessoa1.idade > pessoa2.idade)
                Console.WriteLine("{0} é mais velha que {1} ", pessoa1.nome, pessoa2.nome);
            else
                Console.WriteLine("{0} é mais velha que {1} ", pessoa2.nome, pessoa1.nome);


        }
    }
}
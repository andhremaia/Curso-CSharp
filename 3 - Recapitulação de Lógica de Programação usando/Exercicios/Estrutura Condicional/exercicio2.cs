namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int a = int.Parse(Console.ReadLine()!);

            if (a == 0 || a % 2 == 0)
                Console.WriteLine("Par");
            else if (a % 2 == 0)
                Console.WriteLine("Impar");
        }
    }
}
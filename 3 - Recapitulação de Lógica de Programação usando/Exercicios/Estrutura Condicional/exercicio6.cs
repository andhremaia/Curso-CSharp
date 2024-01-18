namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            double n = double.Parse(Console.ReadLine()!);

            if (n < 0 || n > 100)
                Console.WriteLine("Fora do intervalo");
            else if (n <= 25)
                Console.WriteLine("Está no intervalo (0, 25]");
            else if (n <= 50)
                Console.WriteLine("Esta no intervalo (25, 50]");
            else if (n <= 75)
                Console.WriteLine("Esta no intervalo (50, 75]");
            else if (n <= 100)
                Console.WriteLine("Esta no intervalo (75, 100]");
        }
    }
}
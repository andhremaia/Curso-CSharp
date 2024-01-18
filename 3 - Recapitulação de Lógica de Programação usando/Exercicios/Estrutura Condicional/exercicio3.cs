namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois número inteiros: ");
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);

            if (a % b == 0 || (b % a) * 10 == 0)
                Console.WriteLine("São multiplos");
            else 
                Console.WriteLine("Não são múltiplos");
        }
    }
}
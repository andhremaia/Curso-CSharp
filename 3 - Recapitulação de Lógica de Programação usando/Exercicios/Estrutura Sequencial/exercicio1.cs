namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros: ");
            int x = int.Parse(Console.ReadLine()!);
            int y = int.Parse(Console.ReadLine()!);
            Console.WriteLine("SOMA = {0}", x + y);
        }
    }
}
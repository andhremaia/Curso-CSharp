namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero maior que 0 e menor ou igual a 1000: ");
            int x = int.Parse(Console.ReadLine()!);

            if (x < 0 || x > 1000) 
            {
                Console.WriteLine("Fora do intervalo");
            }
            else 
            {                
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
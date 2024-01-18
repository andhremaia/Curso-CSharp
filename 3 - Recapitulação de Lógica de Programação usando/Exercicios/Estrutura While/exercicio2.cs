namespace Exercicio_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a coordenada (x, y): ");
            string[] cor = Console.ReadLine()!.Split(' ')!;
            double x = double.Parse(cor[0]);
            double y = double.Parse(cor[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Quarto");

                cor = Console.ReadLine()!.Split(' ')!;
                x = double.Parse(cor[0]);
                y = double.Parse(cor[1]);
            }
        }
    }
}
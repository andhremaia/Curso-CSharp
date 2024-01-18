namespace ConsoleApp1
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int a = int.Parse(Console.ReadLine()!);

            if (a > 0)
                Console.WriteLine("Positivo");            
            else
                Console.WriteLine("Não negativo");
        }
    }
}
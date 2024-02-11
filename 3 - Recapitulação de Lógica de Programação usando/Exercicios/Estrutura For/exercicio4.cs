using System.Globalization;

namespace Exercicio_Estrutura_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de testes: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++) {
                Console.Write("Numerador: ");
                double num = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                Console.Write("Denomindador: ");
                double den = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                if (den == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }else
                {
                    double result = num / den;
                    Console.Write("{0} / {1} = {2}", num, den, result.ToString("f2"));
                }
            }
        }
    }
}
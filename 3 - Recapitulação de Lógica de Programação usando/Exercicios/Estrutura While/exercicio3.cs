namespace Exercicio_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Combustivel: ");
            int comb = int.Parse(Console.ReadLine()!);
            int alc = 0;
            int gas = 0;
            int dis = 0;

            while (comb != 4) {
                if (comb == 1) alc += 1;
                else if (comb == 2) gas += 1;
                else if (comb == 3) dis += 1;

                Console.Write("Combustivel: ");
                comb = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: {0} \nGasolina: {1} \nDiesel: {2}", alc, gas, dis);
        }
    }
}
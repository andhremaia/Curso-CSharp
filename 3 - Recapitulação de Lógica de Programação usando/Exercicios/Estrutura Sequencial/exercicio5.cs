
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCICIO 4" +
                "\r\nFazer um programa para ler o código de uma peça 1, " +
                "\r\no número de peças 1, o valor unitário de cada peça 1, o código " +
                "\r\nde uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. " +
                "\r\nCalcule e mostre o valor a ser pago.");

            Console.WriteLine("PEÇA 1: ");
            Console.WriteLine("Codigo: ");
            int cod = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Valor unitario: ");
            double vlr = double.Parse(Console.ReadLine()!);
            double sub = qtd * vlr;
            Console.WriteLine("SUBTOTAL  " + sub);

            Console.WriteLine("PEÇA 2: ");
            Console.WriteLine("Codigo: ");
            int cod2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Quantidade: ");
            int qtd2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Valor unitario: ");
            double vlr2 = double.Parse(Console.ReadLine()!);
            double sub2 = qtd2 * vlr2;
            Console.WriteLine("SUBTOTAL 2 " + sub2);

            double total = sub + sub2;
            Console.WriteLine(total);

            Console.WriteLine("Valor a pagar: R$ {0}", total.ToString("f2"));
        }
    }
}
using System.Globalization;


namespace Aula_60_Exercicio_de_Fixação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine()!);
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine()!;
            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine()!;

            Cliente cliente = new Cliente();

            cliente.Numero = numero;
            cliente.Nome = nome;

            if (resposta == "s")
            {
                Console.Write("Entre com o valor do depósito: ");
                double valor = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                cliente.Deposito(valor);
            }

            Console.WriteLine(cliente.Saldo);

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(cliente.ToString());

            Console.WriteLine("");

            Console.WriteLine("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine()!);
            cliente.Deposito(deposito);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(cliente.ToString());

            Console.Write("\nEntre com o valor para saque: ");
            double saque = double.Parse(Console.ReadLine()!);
            cliente.Saque(saque);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(cliente.ToString());
        }
    }
}
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario;

            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Salario: ");
            double salarioBruto = double.Parse(Console.ReadLine()!,  CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            funcionario = new Funcionario(nome, salarioBruto, imposto);

            funcionario.toString();

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");

            double aumento = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(aumento);

            Console.WriteLine("Dados atualizados: ");
            funcionario.toString();
        }
    }
}
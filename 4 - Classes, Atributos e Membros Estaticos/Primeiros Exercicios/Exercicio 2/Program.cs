namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();            
            Console.Write("Funcionario 1\nNome: ");
            funcionario1.nome = Console.ReadLine()!;
            Console.Write("Salario: ");
            funcionario1.salario = double.Parse(Console.ReadLine()!);

            Funcionario funcionario2 = new Funcionario();
            Console.Write("Funcionario 2\nNome: ");
            funcionario2.nome = Console.ReadLine()!;
            Console.Write("Salario: ");
            funcionario2.salario = double.Parse(Console.ReadLine()!);

            double salario = (funcionario2.salario + funcionario1.salario) / 2;

            Console.WriteLine("Media dos salários: {0}", salario);

        }
    }
}
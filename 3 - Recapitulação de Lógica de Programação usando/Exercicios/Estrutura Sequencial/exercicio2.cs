namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos.
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159
            */
            Console.WriteLine("Digite o valor do raio: ");
            double r = double.Parse(Console.ReadLine()!);
            double area = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("Area do circulo = {0}", area.ToString("f4"));
        }
    }
}
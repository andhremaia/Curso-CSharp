using System.Globalization;

namespace Exercicio_de_Fixação_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            retangulo.largura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + retangulo.Area().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + retangulo.Perimetro().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("f2", CultureInfo.InvariantCulture));

            /*
            double area = retangulo.Area();
            double perimetro = retangulo.Perimetro();
            double diagonal = retangulo.Diagonal();

            Console.WriteLine("Area: " + area.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + perimetro.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + diagonal.ToString("f2", CultureInfo.InvariantCulture));
            */
        }
    }
}   
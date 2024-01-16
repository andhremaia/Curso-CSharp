
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. " +
                "\r\nEm seguida, calcule e nmostre" +"\r\n" +
                "\r\na) a área do triângulo retângulo que tem A por base e C por altura." +
                "\r\nb) a área do círculo de raio C. (pi = 3.14159)" +
                "\r\nc) a área do trapézio que tem A e B por bases e C por altura." +
                "\r\nd) a área do quadrado que tem lado B." +
                "\r\ne) a área do retângulo que tem lados A e B.");

            Console.WriteLine("Digite tres numeros decimais: ");
            double a = double.Parse(Console.ReadLine()!);
            double b = double.Parse(Console.ReadLine()!);
            double c = double.Parse(Console.ReadLine()!);

            double tri = ((a * c) / 2);
            double cir = Math.PI * Math.Pow(c, 2);
            double tra = ((a + b) * c) / 2;
            double qua = Math.Pow(b, 2);
            double ret = a * b;

            Console.WriteLine("TRIANGULO: {0}", tri.ToString("f3"));
            Console.WriteLine("CIRCULO : {0}", cir.ToString("f3"));
            Console.WriteLine("TRAPEZIO : {0}", tra.ToString("f3"));
            Console.WriteLine("QUADRADO : {0}", qua.ToString("f3"));
            Console.WriteLine("RETANGULO : {0}", ret.ToString("f3"));



        }
    }
}
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Fazer um programa para ler quatro valores inteiros A, B, C e D. \r\n" +
                "A seguir, calcule e mostre a diferença do produto\r\nde A e B pelo " +
                "produto de C e D segundo a fórmula: \r\nDIFERENCA = (A * B - C * D).");

            Console.WriteLine("Digite quatro numeros: ");
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!); 
            int c = int.Parse(Console.ReadLine()!); 
            int d = int.Parse(Console.ReadLine()!);

            int axb = a * b;
            int bxc = c * d;

            Console.WriteLine("(A x B) - (C x D) = {0}", axb - bxc);
        }
    }
}
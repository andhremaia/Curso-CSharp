namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de numeros: ");
            int n = int.Parse(Console.ReadLine()!);
            int x;
            int dentro = 0;
            int fora = 0;

            for (int i = 1;  i <= n; i++) {
                x = int.Parse(Console.ReadLine()!);
                if (x >= 10 && x <= 20)
                    dentro += 1;
                else
                    fora += 1;
            }
            Console.WriteLine("{0} in \n{1} out", dentro, fora);
        }
    }
}
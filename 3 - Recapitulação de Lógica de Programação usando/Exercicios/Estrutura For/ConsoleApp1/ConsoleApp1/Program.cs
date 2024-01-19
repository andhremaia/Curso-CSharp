namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero de casos: ");
            double caso = double.Parse(Console.ReadLine()!);
            string[] vlr;
            double media = 0;
            
            for (int i = 1; i <= caso; i++) 
            {
                Console.WriteLine("Caso {0}", i);
                vlr = Console.ReadLine()!.Split(' ');
                media = ((double.Parse(vlr[0]) * 2) + (double.Parse(vlr[1]) * 3) + (double.Parse(vlr[2]) * 5)) / (2 + 3 + 5);
                Console.WriteLine(media);
            }

            /**
             * Resolução do professor
             * 
             * int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
            }

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
             */
        }
    }
}
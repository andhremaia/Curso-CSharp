namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 4:" +
                "\r\nLeia a hora inicial e a hora final de um jogo. " +
                "\r\nA seguir calcule a duração do jogo, sabendo que o mesmo pode" +
                "\r\ncomeçar em um dia e terminar em outro, tendo uma duração " +
                "\r\nmínima de 1 hora e máxima de 24 horas.");

            Console.WriteLine("Digite a hora inicial: ");
            int ini = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite a hora final: ");
            int fin = int.Parse(Console.ReadLine()!);

            if (ini == fin) 
            {
                Console.WriteLine("O jogo durou 24 horas.");
            }
                
            else if (ini > fin) 
            {
                Console.WriteLine("O jogo durou {0}", (24 - ini) + fin);
            }
            else if(ini < fin) 

            {
                Console.WriteLine("O jogo durou {0}", fin - ini);
            }
        }
    }
}
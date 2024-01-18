namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5" +
                "\r\nCom base na tabela abaixo, escreva um programa " +
                "\r\n\tque leia o código de um item e a quantidade deste item. " +
                "\r\nA seguir, calcule e mostre o valor da conta a pagar.");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("CÓDIGO \tPRODUTO \t\tPREÇO");            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1 \tCachorro quente \tR$4.00");
            Console.WriteLine("2 \tX-Salada        \tR$4.50");
            Console.WriteLine("3 \tRefrigerante    \tR$5.00");
            Console.WriteLine("4 \tX-Bacon         \tR$2.00");
            Console.WriteLine("5 \tTorrada Simples \tR$1.50");

            double total;

            Console.Write("Código: ");
            int cod = int.Parse(Console.ReadLine()!);

            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine()!);

            Console.Clear();            
             
            if (cod == 0 || cod < 0 || cod > 5) 
            {
                Console.WriteLine("Produto não cadastrado");
            }
            else if (cod == 1) 
            {
                Console.WriteLine("Total R$ {0}", total);
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("CÓDIGO\tPRODUTO\t\tQUANTIDADE\t\tPREÇO\t\tTOTAL");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("{0}\tCachorro quente\t\t{1}\t\tR$4.0\t\tR$ {2}", cod, qtd, total);
            }
            else if (cod == 2)
            {
                Console.WriteLine("Total R$ {0}", total);
                Console.WriteLine("Total R$ {0}", total);
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("CÓDIGO\tPRODUTO\t\tQUANTIDADE\t\tPREÇO\t\tTOTAL");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("{0}\tX-Salada\t\t{1}\t\tR$4.5\t\tR$ {2}", cod, qtd, total);
            }
            else if (cod == 3 )
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("CÓDIGO\tPRODUTO\t\tQUANTIDADE\t\tPREÇO\t\tTOTAL");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("{0}\tX-Bacon\t\t{1}\t\tR$5.0\t\tR$ {2}", cod, qtd, total);
            }
            else if (cod == 4)
            {
                Console.WriteLine("Total R$ {0}", total);
                Console.WriteLine("Total R$ {0}", total);
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("CÓDIGO\tPRODUTO\t\tQUANTIDADE\t\tPREÇO\t\tTOTAL");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("{0}\tTorrada Simples\t\t{1}\t\tR$2.0\t\tR$ {2}", cod, qtd, total);
            }
            else if (cod == 5)
            {
                Console.WriteLine("5 Total R$ {0}", total);
                Console.WriteLine("Total R$ {0}", total);
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("CÓDIGO\tPRODUTO\t\tQUANTIDADE\t\tPREÇO\t\tTOTAL");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("{0}\tRefrigerante\t\t{1}\t\tR$4.0\t\tR$ {2}", cod, qtd, total);
            }
            Thread.Sleep(5000);
        }
    }
}
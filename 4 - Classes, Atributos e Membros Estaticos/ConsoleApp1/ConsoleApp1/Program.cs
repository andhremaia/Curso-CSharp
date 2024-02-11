namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine()!);
            Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine()!);

            Produto produto = new Produto(nome, preco, qtd);

            Console.WriteLine("Dados do Produto:" + produto.ToString() );

            Console.Write("Digite o numero de produtos a serem adicionados ao estoque:");
            qtd = int.Parse(Console.ReadLine()!);
            produto.AdicionarProduto(qtd);
            Console.WriteLine("Dados atualizados\n" + produto.ToString());

            Console.Write("Digite o numero de produtos a serem removidos ao estoque:");
            qtd = int.Parse(Console.ReadLine()!);
            produto.RemoverProduto(qtd);
            Console.WriteLine("Dados atualizados" + produto);

        }
    }
}
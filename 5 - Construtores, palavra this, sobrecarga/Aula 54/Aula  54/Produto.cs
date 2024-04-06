using System.Globalization;
namespace Aula_54
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }

        /*
         * Palavra this fazendo referencia ao construtor padrão
         */

         public Produto(string nome, double preco): this()
                
        {
            Nome = nome;
            Preco = preco;
           // Quantidade = 10;//Essa linha é desnecessária pois está sendo referenciada do construtor padrão pela palavra this
        }

        //Mais umva vez a palavra this referenciando outro construtor 
        public Produto (string nome, double preco, int quantidade): this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
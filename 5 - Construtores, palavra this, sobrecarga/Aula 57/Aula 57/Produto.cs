using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Aula_57
{
    class Produto
    {
        //Nome tem uma lógica própria. Não será será implementado como uma autopropertie
        private string _nome;

        //AUTO PROPERTIE - modificador de acesso é publico
        public double Preco { get; private set; }

        //AUTOPROPERTIE - modificador de acesso é publico
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {            
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //PROPERTIE
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

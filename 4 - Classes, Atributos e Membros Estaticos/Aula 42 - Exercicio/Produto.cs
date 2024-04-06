using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverProduto(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return Nome
                + ", R$ "
                + Preco
                + ", "
                + Quantidade
                + " Unidades"
                + " Total"
                + ValorTotalEmEstoque();
        }
    }
}

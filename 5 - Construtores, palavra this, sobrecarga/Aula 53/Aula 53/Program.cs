﻿using System;
using System.Globalization;
namespace Aula_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Produto p2 = new Produto();

            //Trecho de codigo da aula
            Produto p3 = new Produto()
            {
                Nome = nome,
                Preco = preco,
                Quantidade = 20
            };


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine()!);
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine()!);
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
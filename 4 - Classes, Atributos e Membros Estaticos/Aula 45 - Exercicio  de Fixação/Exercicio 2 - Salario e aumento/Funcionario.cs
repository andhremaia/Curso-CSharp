using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Funcionario
    {
        private string nome;
        private double salarioBruto;
        private double imposto;

        public void Funcionaio() { }

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto = (salarioBruto * (porcentagem/100)) + salarioBruto; 
        }

        public void toString()
        {
            Console.WriteLine("Nome: " + nome + 
                "\nSalário Líquido: R$ " + SalarioLiquido());
        }
    }
}
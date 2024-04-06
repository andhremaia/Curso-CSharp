using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_Fixação_1
{
    class Retangulo
    {
        public double altura;
        public double largura;

        public double Area()
        {
            return (largura * altura);
        }

        public double Perimetro()
        {
            return 2 * (altura + largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));
        }
    } 
}

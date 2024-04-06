using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno_e_Notas
{
    class Aluno
    {
        string nome;
        double n1;
        double n2;
        double n3;
        double notaFinal;

        public Aluno(string nome, double n1, double n2, double n3)
        {

            this.nome = nome;
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;

        }

        public double NotaFinal()
        {
            this.notaFinal = (n1 + n2 + n3);
            return this.notaFinal;
        }
    }
}

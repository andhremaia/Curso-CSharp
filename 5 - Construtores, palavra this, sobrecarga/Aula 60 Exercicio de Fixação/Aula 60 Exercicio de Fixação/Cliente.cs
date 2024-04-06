using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_60_Exercicio_de_Fixação
{
    internal class Cliente
    {
        private int _numero;
        public string Nome { get; set; }//AUTOPROPERTIE
        private double _saldo;

        public int Numero
        {
            get { return _numero; }
            set
            {
                if (_numero == 0)
                {
                    _numero = value;
                }
            }
        }
       
        public double Saldo  //PROPERTIE
        {
            get { return _saldo; }           
        }

        public void Deposito(double valor)
        {
            _saldo += valor;
        }

        public double Saque(double valor)
        {
            _saldo -= (valor + 5);
            return 0;
        }

        public override string ToString()
        {
            return
                "Conta "
                + Numero
                + " Titular: "
                + Nome
                + " Saldo R$ {0.2} "
                + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}

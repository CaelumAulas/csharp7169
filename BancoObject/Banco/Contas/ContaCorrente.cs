using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaCorrente : Conta, ITributavel
    {
        private static int contador;

        public static int Total {
            get
            {
                return contador;
            }
        }

        public ContaCorrente()
        {
            contador++;
        }

        public override void Deposita(double valor)
        {
            Saldo = Saldo + (valor - 0.1);
        }

        public override void Saca(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor negativo");
            }

            double valorSaque = valor + 0.05;

            if (valorSaque > Saldo)
            {
                throw new SaldoInsuficienteException();
            }

            Saldo = Saldo - valorSaque;
        }

        public double CalculaImposto()
        {
            return Saldo * 0.05;
        }
    }
}

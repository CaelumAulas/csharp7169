using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta
    {

        public override void Saca(double valor)
        {
            Saldo -= (valor + 0.1);
        }

        public override void Deposita(double valor)
        {
            Saldo += (valor - 0.1);
        }
    }
}

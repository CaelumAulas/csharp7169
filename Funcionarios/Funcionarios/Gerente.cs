using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Gerente : Funcionario
    {
        public string Senha { get; set; }

        public bool Autentica(string senhaExterna)
        {
            if(Senha == senhaExterna)
            {
                return true;
            }

            return false;
        }

        public override double Bonus()
        {
            return base.Bonus() + 5000;
        }
    }
}

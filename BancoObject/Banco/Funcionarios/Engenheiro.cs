using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Funcionarios
{
    public class Engenheiro : Funcionario
    {
        public string Registro { get; set; }

        public override double Bonificacao()
        {
            return 1000;
        }
    }
}

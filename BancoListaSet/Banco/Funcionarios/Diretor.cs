﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Funcionarios
{
    class Diretor : Funcionario, IAutenticavel
    {
        public int Senha { get; set; }

        public bool Autentica(int senha)
        {
            if(senha == Senha)
            {
                return true;
            }

            return false;
        }

        public override double Bonificacao()
        {
            return 98979;
        }
    }
}

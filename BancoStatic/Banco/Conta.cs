using System;

namespace Banco
{
    public abstract class Conta
    {
        public static int Total { get; private set; }

        public Conta()
        {
            Total++;
        }

        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; private set; }

        public virtual void Deposita(double valor)
        {
            // Saldo = Saldo + valor;
            Saldo += valor;
        }

        public virtual void Saca(double valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;

            }
        }
    }
}
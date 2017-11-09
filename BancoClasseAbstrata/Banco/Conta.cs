using System;

namespace Banco
{
    public abstract class Conta
    {
        public Conta()
        {
        }

        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public abstract void Deposita(double valor);

        public abstract void Saca(double valor);
    }
}
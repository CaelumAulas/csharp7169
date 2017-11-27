using Banco.Clientes;

namespace Banco.Contas
{
    public abstract class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public abstract void Deposita(double valor);

        public abstract void Saca(double valor);

        public override string ToString()
        {
            return $"Titular: {Titular.Nome}, Numero: {Numero}";
        }

        public override bool Equals(object obj)
        {
            if(this == obj) return true;

            if(!(obj is Conta))
            {
                return false;
            }

            Conta outraConta = (Conta) obj;

            if(this.Numero != outraConta.Numero)
            {
                return false;
            }

            if(this.Titular.Nome != outraConta.Titular.Nome)
            {
                return false;
            }

            return true;
        }
    }
}
namespace Funcionarios
{
    class ControleDeBonificacao
    {
        
        public double Total { get; private set; }

        public void Add(Funcionario func)
        {
            Total = Total + func.Bonus();
        }
    }
}
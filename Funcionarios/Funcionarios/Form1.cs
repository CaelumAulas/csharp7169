using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario zeca = new Funcionario();
            zeca.Nome = "Zeca";
            zeca.Salario = 2000;
            MessageBox.Show(
                $"{zeca.Nome} - Bonus: {zeca.Bonus()}");

            
            Gerente joao = new Gerente();
            joao.Nome = "Joao";
            joao.Salario = 20000;       
            joao.Senha = "123";
            joao.Autentica("678");
            MessageBox.Show($"{joao.Nome} - Bonus: {joao.Bonus()}");

            Atendente jose = new Atendente();
            jose.Nome = "Jose";
            jose.Salario = 3000;
            jose.Telefone = "123-456";

            ControleDeBonificacao cb = new ControleDeBonificacao();
            cb.Add(zeca);
            cb.Add(joao);
            cb.Add(jose);
            MessageBox.Show($"Total de bonificacoes: {cb.Total}");
        }
    }
}

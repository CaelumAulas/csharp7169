using Banco.Clientes;
using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastro : Form
    {
        private Form1 formContas;

        public FormCadastro(Form1 formContas)
        {
            InitializeComponent();
            this.formContas = formContas;
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            string campoTitular = textoTitular.Text;
            Cliente titular = new Cliente(campoTitular);
            Conta c1 = new ContaCorrente();
            c1.Numero = Convert.ToInt32(textoNumero.Text);
            c1.Titular = titular;

            formContas.AdicionaConta(c1);

            this.Close();
        }
    }
}

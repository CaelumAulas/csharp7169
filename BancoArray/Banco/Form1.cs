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
    public partial class Form1 : Form
    {
        private Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];

            contas[0] = new Conta();
            contas[0].Titular = new Cliente("victor");
            contas[0].Numero = 1;

            contas[1] = new ContaPoupanca();
            contas[1].Titular = new Cliente("mauricio");
            contas[1].Numero = 2;

            contas[2] = new ContaCorrente();
            contas[2].Titular = new Cliente("osni");
            contas[2].Numero = 3;
            
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);

            textoSaldo.Text = selecionada.Saldo.ToString();
            MessageBox.Show("Sucesso");
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);

            textoSaldo.Text = selecionada.Saldo.ToString();
            MessageBox.Show("Sucesso");
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);
            Conta selecionada =  this.contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = Convert.ToString(selecionada.Titular);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
    }
}

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
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[10];

            Conta contaVictor = new ContaCorrente();
            contaVictor.Titular = new Cliente("victor");
            contaVictor.Numero = 1;
            AdicionaConta(contaVictor);

            Conta contaMauricio = new ContaPoupanca();
            contaMauricio.Titular = new Cliente("mauricio");
            contaMauricio.Numero = 2;
            AdicionaConta(contaMauricio);

            Conta contaOsni = new ContaCorrente();
            contaOsni.Titular = new Cliente("osni");
            contaOsni.Numero = 3;
            AdicionaConta(contaOsni);
        }

        public void AdicionaConta(Conta novaConta)
        {
            contas[numeroDeContas] = novaConta;
            comboContas.Items.Add(novaConta.Titular.Nome);
            numeroDeContas++;
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);

            textoSaldo.Text = selecionada.Saldo.ToString();
            MessageBox.Show("Sucesso");
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);

            textoSaldo.Text = selecionada.Saldo.ToString();
            MessageBox.Show("Sucesso");
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = Convert.ToString(selecionada.Titular.Nome);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(this);
            formCadastro.Show();
        }
    }
}

using System;
using System.Windows.Forms;

using Banco.Clientes;
using Banco.Contas;
using Banco.Funcionarios;

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

            Cliente victor = new Cliente("Victor");
            Conta conta0 = new ContaCorrente();
            conta0.Titular = victor;
            conta0.Numero = 123;
            AdicionaConta(conta0);

            Cliente ana = new Cliente("Ana");
            Conta conta1 = new ContaCorrente();
            conta1.Titular = ana;
            conta1.Numero = 345;
            AdicionaConta(conta1);

            Cliente osni = new Cliente("Osni");
            Conta conta2 = new ContaCorrente();
            conta2.Titular = osni;
            conta2.Numero = 890;
            AdicionaConta(conta2);

            Conta conta3 = new ContaCorrente();
            conta3.Titular = osni;
            conta3.Numero = 890;
            
            if(conta2.Equals(conta3))
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }
        }

        public void AdicionaConta(Conta novaConta)
        {
            contas[numeroDeContas] = novaConta;
            numeroDeContas++;
            comboContas.Items.Add(novaConta);
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

            string valorDigitado = textoValor.Text;
            var valor = Convert.ToDouble(valorDigitado);
            selecionada.Deposita(valor);

            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Sucesso!");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);

            try
            {
                selecionada.Saca(valor);
                MessageBox.Show("Emitindo as notas");
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Saque realizado com sucesso");
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Valor negativo");
            }

            MessageBox.Show("Até o proximo saque!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(this);
            formCadastro.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Valor absoluto: " + Math.Pow(2, 3));
        }
    }
}

using System;
using System.Windows.Forms;

using Banco.Clientes;
using Banco.Contas;
using System.Collections.Generic;

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
            contas = new Conta[4];

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
        }

        public void AdicionaConta(Conta novaConta)
        {
            if(numeroDeContas == contas.Length)
            {
                Conta[] novoArray = new Conta[numeroDeContas * 2];
                for(int i = 0; i < contas.Length; i++)
                {
                    novoArray[i] = contas[i];
                }

                this.contas = novoArray;
            }

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

        private void button1_Click_2(object sender, EventArgs e)
        {
            Cliente victor = new Cliente("Victor");
            Conta conta1 = new ContaCorrente();
            conta1.Titular = victor;
            conta1.Numero = 123;

            Cliente ana = new Cliente("Ana");
            Conta conta2 = new ContaCorrente();
            conta2.Titular = ana;
            conta2.Numero = 345;

            Cliente osni = new Cliente("Osni");
            Conta conta3 = new ContaCorrente();
            conta3.Titular = osni;
            conta3.Numero = 890;
            
            List<Conta> contas = new List<Conta>();
            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);

            // contas.Remove(conta4);

            // MessageBox.Show("Contem? " + contas.Contains(conta4));

            // Conta contaOsni = contas[2];

            foreach(var conta in contas)
            {
                MessageBox.Show("Conta: " + conta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente victor = new Cliente("Victor");
            Conta conta1 = new ContaCorrente();
            conta1.Titular = victor;
            conta1.Numero = 123;

            Cliente ana = new Cliente("Ana");
            Conta conta2 = new ContaCorrente();
            conta2.Titular = ana;
            conta2.Numero = 345;

            Cliente osni = new Cliente("Osni");
            Conta conta3 = new ContaCorrente();
            conta3.Titular = osni;
            conta3.Numero = 890;

            Dictionary<string, Conta> titularConta = new Dictionary<string, Conta>();
            titularConta.Add(conta1.Titular.Nome, conta1);
            titularConta.Add(conta2.Titular.Nome, conta2);
            titularConta.Add(conta3.Titular.Nome, conta3);

            Conta contaAna = titularConta["Ana"];

            foreach (KeyValuePair<string, Conta> par in titularConta)
            {
                MessageBox.Show("Chave: " + par.Key + ", Valor: " + par.Value);
            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream entrada = 
                File.Open("entrada.txt", FileMode.Open);
            
            StreamReader leitor = new StreamReader(entrada);

            string linha = leitor.ReadLine();
            while(linha != null)
            {
                MessageBox.Show(linha);
                linha = leitor.ReadLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream saida = File.Open("entrada.txt", FileMode.Append);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.WriteLine("Escrevendo no arquivo");
            escritor.Close();
            saida.Close();
        }
    }
}

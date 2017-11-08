using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] idades = new int[10];
            idades[0] = 18;
            idades[1] = 35;
            idades[2] = 40;
            idades[3] = 25;
            idades[4] = 29;
            idades[5] = 50;
            idades[6] = 55;
            idades[7] = 36;
            idades[8] = 27;
            idades[9] = 50;

            double soma = 0;
            for(int i = 0; i < idades.Length; i++)
            {
                soma = soma + idades[i];
            }

            double media = soma / idades.Length;

            MessageBox.Show($"Media: {media}");
        }
    }
}

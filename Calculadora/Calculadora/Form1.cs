using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soma_Click(object sender, EventArgs e)
        {
            float N1 = Int32.Parse(Num1.Text);
            float N2 = Int32.Parse(Num2.Text);

            float soma = N1 + N2;

            resultado.Text = soma.ToString();
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            float N1 = Int32.Parse(Num1.Text);
            float N2 = Int32.Parse(Num2.Text);

            float sub = N1 - N2;

            resultado.Text = sub.ToString();
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            float N1 = Int32.Parse(Num1.Text);
            float N2 = Int32.Parse(Num2.Text);

            float div = N1 / N2;

            resultado.Text = div.ToString();
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            float N1 = Int32.Parse(Num1.Text);
            float N2 = Int32.Parse(Num2.Text);

            float mult = N1 * N2;

            resultado.Text = mult.ToString();
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            float N1 = Int32.Parse(Num1.Text);
            float N2 = Int32.Parse(Num2.Text);

            int i = 0;
            float expo = N1;

            for (i = 1; i < N2; i++)
            {
                expo = expo * N1;
            }

            resultado.Text = expo.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

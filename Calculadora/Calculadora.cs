using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        // Numeros
        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        // Operadores
        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            lbOperacao.Text = "SOMA";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUBTRAIR";
            lbOperacao.Text = "SUBTRAIR";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIVIDIR";
            lbOperacao.Text = "DIVIDIR";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULTIPLICAR";
            lbOperacao.Text = "MULTIPLICAR";
        }

        // Limpar 
        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lbOperacao.Text = "";
            operacao = "";
            valor2 = 0;
            valor1 = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lbOperacao.Text = "";
        }

        // Igual
        private void button18_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "DIVIDIR")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            } else if (operacao == "SUBTRAIR")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            } else if (operacao == "MULTIPLICAR")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
        }

    }
}

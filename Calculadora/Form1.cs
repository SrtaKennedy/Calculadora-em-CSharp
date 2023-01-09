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

        private void button6_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "6";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                Txt_Resultado.Text = Convert.ToString(valor1 + valor2);
            } 
            else if (operacao == "SUB")
            {
                Txt_Resultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                Txt_Resultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                Txt_Resultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Txt_Resultado.Text != "")
            {
                valor1 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);
                Txt_Resultado.Text = "";
                operacao = "SUB";
                Lbl_Operacoes.Text = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Txt_Resultado.Text != "")
            {
                valor1 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);
                Txt_Resultado.Text = "";
                operacao = "MULT";
                Lbl_Operacoes.Text = "*";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Txt_Resultado.Text != "")
            {
                valor1 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);
                Txt_Resultado.Text = "";
                operacao = "DIV";
                Lbl_Operacoes.Text = "/";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = "";
            Lbl_Operacoes.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            Lbl_Operacoes.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Txt_Resultado.Text != "")
            {
                valor1 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);
                Txt_Resultado.Text = "";
                operacao = "SOMA";
                Lbl_Operacoes.Text = "+";
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        decimal vLocal1 = 0, vLocal2 = 0;
        Operacoes opc = new Operacoes();

        public Form1()
        {
            InitializeComponent();
        }

        //Botão 0
        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        //Botão 1
        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        //Botão 2
        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        //Botão 3
        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        //Botão 5
        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        //Botão 5
        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        //Botão 6
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        //Botão 7
        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        //Botão 8
        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        //Botão 9
        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        //Botão PONTO
        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        
        //Botão IGUAL
        private void button11_Click(object sender, EventArgs e)
        {
            vLocal2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            opc.valor1 = vLocal1;
            opc.valor2 = vLocal2;

            txtResultado.Text = Convert.ToString(opc.result());
        }

        //Botão SUBTRAÇÃO
        private void button7_Click(object sender, EventArgs e)
        {
            vLocal1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            opc.operacao = "SUB";
            lblOperacao.Text = "-";
        }

        //Botão MULTIPLICAÇÃO
        private void button12_Click(object sender, EventArgs e)
        {
            vLocal1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            opc.operacao = "MULT";
            lblOperacao.Text = "x";
        }

        //Botão DIVISÃO
        private void button17_Click(object sender, EventArgs e)
        {
            vLocal1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            opc.operacao = "DIV";
            lblOperacao.Text = "/";
        }
            
        //Botão CE
        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        //Botão C
        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            opc.valor1 = 0;
            opc.valor2 = 0;
            lblOperacao.Text = "";
        }

        //Botão SOMA
        private void button4_Click(object sender, EventArgs e)
        {
            vLocal1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            opc.operacao = "SOMA";
            lblOperacao.Text = "+";
        }

    }
}

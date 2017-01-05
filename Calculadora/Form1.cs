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

        double total;
        double ultimoNumero;
        string operador;
        string aux = "0";

        public Form1()
        {
            InitializeComponent();
            limparValores();
            txtResult.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            limparValores();
            txtResult.Text = "0";
        }

        private void limparValores()
        {
            total = 0;
            ultimoNumero = 0;
            operador = "+";
        }

        private void mostrarVisor(object sender, EventArgs e)
        {
            if (txtResult.Text.Equals("0"))
            {
                txtResult.Text = (sender as Button).Text;
            }
            else
            {
                txtResult.Text += (sender as Button).Text;
            }

            aux += (sender as Button).Text;
        }

        private void operadores(object sender, EventArgs e)
        {

            calcular();

            if((sender as Button).Text.Equals("x"))
            {
                txtResult.Text += " " + "*" + " ";
            }
            else
            {
                txtResult.Text += " " + (sender as Button).Text + " ";
            }

            operador = (sender as Button).Text;
        }

        private void calcular()
        {
            ultimoNumero = Convert.ToDouble(aux);

            switch (operador)
            {
                case "+": total += ultimoNumero;
                    break;
                case "-": total -= ultimoNumero;
                    break;
                case "x": total *= ultimoNumero;
                    break;
                case "/": total /= ultimoNumero;
                    break;
            }

            aux = "0";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            calcular();
            txtResult.Text = total.ToString();
        }
    }
}

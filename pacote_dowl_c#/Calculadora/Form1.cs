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

        string operador;
        int a = 0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btn_adic_Click_1(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtValor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = txtValor.Text + btn_adic.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txtValor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = txtValor.Text + btn_sub.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtValor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = txtValor.Text + btn_mult.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = txtValor.Text + btn_div.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if(operador == "+")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a + Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "-")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a - Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "*")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a * Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "/")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a / Convert.ToInt32(txtValor.Text));
            }
        }
    }
}

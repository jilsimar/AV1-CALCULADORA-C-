using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculadora
{
    public partial class Form1 : Form
    {
        Double valor;
        string operador;
        bool check;

        public Form1()
        {
            InitializeComponent();
        }
            
            
            private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void btnNumerador(object sender, EventArgs e)
        {
            if ((operador == "+") || (operador == "-") || (operador == "*") || (operador == "/"))
            {
                if (check)
                {
                    check = false;
                    txtResultado.Text = "0";
                }
            }
            Button b = sender as Button;
            if (txtResultado.Text == "0")
                txtResultado.Text = b.Text;
            else txtResultado.Text += b.Text;
        }

        private void btnOperador(object sender, EventArgs e)
        {
            
                Button b = sender as Button;
                valor = Double.Parse(txtResultado.Text);
                operador = b.Text;
                txtResultado.Text += b.Text;
                check = true;
            

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            valor = 0;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operador)
                {
                    case "+":
                        txtResultado.Text = (valor + Double.Parse(txtResultado.Text)).ToString();
                        break;
                    case "-":
                        txtResultado.Text = (valor - Double.Parse(txtResultado.Text)).ToString();
                        break;
                    case "*":
                        txtResultado.Text = (valor * Double.Parse(txtResultado.Text)).ToString();
                        break;
                    case "/":
                        txtResultado.Text = (valor / Double.Parse(txtResultado.Text)).ToString();
                        break;

                }
             }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }
}



using System;
using System.Windows.Forms;

namespace calculadorabasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double obtenerNumero(TextBox txt)
        {
            double num;
            if (double.TryParse(txt.Text, out num))
                return num;
            else
            {
                MessageBox.Show("Ingresa un número válido");
                return 0;
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (obtenerNumero(txtNum1) + obtenerNumero(txtNum2)).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (obtenerNumero(txtNum1) - obtenerNumero(txtNum2)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (obtenerNumero(txtNum1) * obtenerNumero(txtNum2)).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double divisor = obtenerNumero(txtNum2);
            if (divisor == 0)
            {
                MessageBox.Show("No se puede dividir entre 0");
                return;
            }
            txtResultado.Text = (obtenerNumero(txtNum1) / divisor).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlturaDoTriângulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            // Declarando váriaveis e dando valor a elas:
            double n1 = double.Parse(txbN1.Value.ToString());
            
            double n2 = double.Parse(txbN2.Value.ToString());

            // TextBoxResultado recebe o resultado da conta:
            MessageBox.Show("Triângulo: " + (n1 * n2) / 2, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information) ;

            //Fim.

        }
    }
}

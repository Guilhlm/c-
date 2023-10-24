using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula1_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1 = TXBNUMERO1.Text;
            string numero2 = TXBNUMERO2.Text;
            

            int total = int.Parse(numero1) + int.Parse(numero2);

            LBRESULTADO.Text = total.ToString();




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTNMENOS_Click(object sender, EventArgs e)
        {
            string numero1 = TXBNUMERO1.Text;
            string numero2 = TXBNUMERO2.Text;

            int totalmenos = int.Parse(numero1) -  int.Parse(numero2);

            LBRESULTADO.Text = totalmenos.ToString();
        }

        private void BTNDIVIDIR_Click(object sender, EventArgs e)
        {
            string numero1 = TXBNUMERO1.Text;
            string numero2 = TXBNUMERO2.Text;

            float totaldividir = float.Parse(numero1) / float.Parse(numero2);

            LBRESULTADO.Text = totaldividir.ToString();
        }

        private void BTNMULTIPLICAR_Click(object sender, EventArgs e)
        {
            string numero1 = TXBNUMERO1.Text;
            string numero2 = TXBNUMERO2.Text;

            float totalvezes = float.Parse(numero1) * float.Parse(numero2);

            LBRESULTADO.Text = totalvezes.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BXTMAIOR_Click(object sender, EventArgs e)
        {
            int numerodigitado = int.Parse(TXBNUMERO3.Text);

            if (numerodigitado > 0)
            {
                TXBNUMERO3.Text = "seu numero eh maior q zero";
            }
            else
            {
                TXBNUMERO3.Text = "seu numero eh menor q zero";
            }
        }

        private void BTNPARIMPAR_Click(object sender, EventArgs e)
        {
            int numerodigitado = int.Parse(TXBNUMERO3.Text);
            

            if (numerodigitado % 2 == 0)
            {
                TXBNUMERO3.Text = "seu numero eh PAR";
            }
            else
            {
                TXBNUMERO3.Text = "seu numero eh IMPAR";
            }
        }
    }
}

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
    public partial class CalculaWorld : Form
    {
        private double resultado;
        private double valor1;
        private double valor2;

        private int operation;

        public CalculaWorld()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // C borrar todo
            Screen.Text = "";
            resultado = 0;
            valor1 = 0;
            valor2 = 0;
            operation = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            // numero 0
            Screen.Text = Screen.Text + "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // numero 1
            Screen.Text = Screen.Text +  "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // numero 2
            Screen.Text = Screen.Text +  "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // numero 3
            Screen.Text = Screen.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // numero 4
            Screen.Text = Screen.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // numero 5
            Screen.Text = Screen.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // numero 6
            Screen.Text = Screen.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // numero 7
            Screen.Text = Screen.Text +  "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // numero 8
            Screen.Text = Screen.Text +  "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // numero 9
            Screen.Text = Screen.Text + "9";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            // punto
            Screen.Text = Screen.Text + ".";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            // suma
            operation = 1;
            valor1 = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            // resta
            operation = 2;
            valor1 = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            // multiplicación
            operation = 3;
            valor1 = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            //divición
            operation = 4;
            valor1 = Convert.ToDouble(Screen.Text);
            Screen.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //borrar pantalla pero mantiene numeros almacenados
            Screen.Text = "";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            //boton igual, Agregar validaciones para que no escriban numeros
            valor2 = Convert.ToDouble(Screen.Text);

            switch (operation)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
                default:
                    break;
            }

            Screen.Text = resultado.ToString();


        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

        private void btnCE1_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }
    }
}

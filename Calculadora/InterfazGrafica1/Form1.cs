using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica1
{
    public partial class Form1: Form
    {
        private double valor1 = 0;
        private double valor2 = 0;
        private double resultado = 0;
        private int operacion = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Numero 6
            textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Numero 4
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //resta
            operacion = 2;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Numero 5
            textBox1.Text = textBox1.Text + "5";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //numero 0
            if (textBox1.Text != "0")
                textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Numero 7
            textBox1.Text = textBox1.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Numero 1
            textBox1.Text = textBox1.Text + "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Numero 2
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Numero 3
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Numero 8
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Numero 9
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
            textBox1.Text= textBox1.Text + ".";   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //suma 
            operacion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";


        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            //Boton de borrar
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Boton de resultado
            valor2 = Convert.ToDouble(textBox1.Text);
            switch (operacion)
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
                   if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        textBox1.Text = "";
                    }
                    resultado = valor1 / valor2;
                    break;
                default:
                    break;
            }
            textBox1.Text = Convert.ToString(resultado);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //multiplicacion
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //division
            operacion = 4;  
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
    }
}

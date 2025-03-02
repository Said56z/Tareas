using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularioyasi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 0 || comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox2.Text.Length < 10 || textBox3.Text != "3" || textBox4.Text == "")
            { 
                if (numericUpDown1.Value < 0)
            {
                MessageBox.Show("Te falla, no?\n" + "No pongas numeros negativozzz");
                numericUpDown1.Value = 0;
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("No existes?\n" +
                    "Pon tu genero");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Buenas tardes señor _________.\n" +
                    "Pon tu nombre >:L");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("No te vamos a cobrar\n" +
                    "Pon tu telefono");
            }
            else if (textBox2.Text.Length < 10)
            {
                MessageBox.Show("No te vamos a cobrar\n" +
                    "Pon tu telefono");
            }
            if (textBox3.Text != "6")
            {
                MessageBox.Show("?????????\n" +
                    "cuanto es 3+3?");
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("No te sabes tu matricula?\n" +
                    "Vamos pon tu matricula");
            }
        }
            else
            {
                MessageBox.Show("Gracias por registrarte" +
                    "Tu nombre es: " + textBox1.Text + "\n" +
                    "Tu genero es: " + comboBox1.Text + "\n" +
                    "Tu numero fav es: " + numericUpDown1.Value + "\n" +
                    "Tu telefono es: " + textBox2.Text + "\n" +
                    "Tu matricula es: " + textBox4.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "  ^ [0-9]"))
            {
                textBox2.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

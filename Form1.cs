using System;
using System.Windows.Forms;

namespace Proyecto_Unidad_1
{


    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        public void SetNombre1(string nombre)
        {
            NombreUL.Text = nombre;
        }

        public void SetCorreo(string correo)
        {
            CorreoUL.Text = correo;
        }

        public void SetFechaNac(string fecha)
        {
            FechaNacUL.Text = fecha;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void NombreUL_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TipoUL_Click(object sender, EventArgs e)
        {
            
        }
    }
}

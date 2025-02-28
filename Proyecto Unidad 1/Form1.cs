using System;
using System.Media;
using System.Windows.Forms;


namespace Proyecto_Unidad_1
{


    public partial class Inicio : Form
    {
        String ruta = "C:/Users/saidj/source/repos/Proyecto Unidad 1/Proyecto Unidad 1/Resources/Familia-P.Luche.wav";
        public Inicio()
        {
            InitializeComponent();
            SonidoAmbiente();
        }

        public void SonidoAmbiente()
        {
            SoundPlayer sonidoPeluche = new SoundPlayer();
            sonidoPeluche.SoundLocation = ruta;

            sonidoPeluche.PlayLooping();

        }

        public void cambiarcolor()
        {
            String CO = ElegirColor.Text;
            NombreUL.ForeColor = System.Drawing.Color.FromName(CO);
            CorreoUL.ForeColor = System.Drawing.Color.FromName(CO);
            FechaNacUL.ForeColor = System.Drawing.Color.FromName(CO);
            TipoUS.ForeColor = System.Drawing.Color.FromName(CO);
            label1.ForeColor = System.Drawing.Color.FromName(CO);
        }

        public void SetNombre1(string nombre)
        {
            NombreUL.Text = nombre;
        }

        public void SetCorreo(string correo)
        {
            CorreoUL.Text = "Correo: " + correo;
        }

        public void SetFechaNac(string fecha)
        {
            FechaNacUL.Text = "Fecha de nacimiento: \n"+ fecha;
        }

        public void SetTipo(string tipo)
        {
            TipoUS.Text = "Tipo de cuenta: \n" + tipo;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoUS.Text == "ADMINISTRADOR")
            {
                cambiarcolor();
            }
        }

        private void InicioSes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NombreUL.Text = "";
            CorreoUL.Text = "";
            FechaNacUL.Text = "";
            TipoUS.Text = "";
        }
    }
    }

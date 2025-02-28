using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Unidad_1
{
    public partial class Form2: Form
    {
        String CorreoV;
        String ContraseñaV;
        String nombreV;
        String fechaV;
        String tipoV;
        public Form2()
        {
            InitializeComponent();
        }

        public void SetCorreo(String correo)
        {
            CorreoV = correo;
        }

        public void SetContrasena(String contrasena)
        {
            ContraseñaV = contrasena;
        }


        public void SetNombre(String nombre)
        {
            nombreV = nombre;
        }

        public void SetFecha(String fecha)
        {
            fechaV = fecha;
        }

        public void SetTipo(String tipo)
        {
            tipoV = tipo;                  
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            ValidarDatos.Enabled = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CorreoU.Text == CorreoV && ContraseñaU.Text == ContraseñaV)
            {
                Inicio Form1 = new Inicio();
                Form1.SetNombre1(nombreV);
                Form1.SetCorreo(CorreoV);
                Form1.SetFechaNac(fechaV);
                Form1.SetTipo(tipoV);
                Form1.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos");
            }



        }

        private void ControlBoton()
        {
            if (CorreoU.Text.Trim() != "" && ContraseñaU.Text.Trim() != "")
            {
                ValidarDatos.Enabled = true;
                errorProvider1.SetError(CorreoU, "");
            }
            else
            {
                if (CorreoU.Text.Trim() == "")
                {
                    errorProvider1.SetError(CorreoU, "Ingrese su correo");
                }
                else if (ContraseñaU.Text.Trim() == "")
                {
                    errorProvider1.SetError(CorreoU, "Ingrese su Contraseña");
                }
                else
                {
                    errorProvider1.SetError(CorreoU, "Ingrese un correo y una contraseña");

                    ValidarDatos.Enabled = false;
                   
                }

            }
        }
      

        private void CorreoU_TextChanged(object sender, EventArgs e)
        {
            ControlBoton();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Inicio Form1 = new Inicio();
            Form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }

        private void ContraseñaU_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }
    }
}

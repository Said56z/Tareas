using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Unidad_1.Inicio;

namespace Proyecto_Unidad_1
{
    public partial class Form3: Form
    {
        String usuario = "";
        String contrasena = "";
        String FechaNac = "";
        String correo = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CorreoU_TextChanged(object sender, EventArgs e)
        {
            usuario = NombreU.Text;
            
        }

        private void ContraU_TextChanged(object sender, EventArgs e)
        {
            contrasena = ContraU.Text; 
        }

        private void FechaNacU_TextChanged(object sender, EventArgs e)
        {
            FechaNac = FechaNacU.Text;
        }

        private void CorreoU_TextChanged_1(object sender, EventArgs e)
        {
            correo = CorreoU.Text;
        }

        private void ValidarDatos_Click(object sender, EventArgs e)
        {
            if (NombreU.Text.Trim() == "" || ContraU.Text.Trim() == "" || FechaNacU.Text.Trim() == "" || CorreoU.Text.Trim() == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }

            else
            {
                Form2 form2 = new Form2();
                form2.SetCorreo(correo);
                form2.SetContrasena(contrasena);
                form2.SetNombre(usuario);
                form2.SetFecha(FechaNac);
                form2.Show();
                this.Hide();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

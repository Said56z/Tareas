using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4
{
    public partial class Form3: Form
    {
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Categoria { get; set; }
        public string Cantidad { get; set; }
        public string NumdeRegistro { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void MostarInformacion(string nombre, string precio, string categoria, string cantidad, string NumRegistro)
        {
            label6.Text = nombre;
            label7.Text = precio;
            label8.Text = categoria;
            label9.Text = cantidad;
            label10.Text = NumRegistro;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

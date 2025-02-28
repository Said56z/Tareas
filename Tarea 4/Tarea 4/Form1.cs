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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(DGVProductos);
            form2.Show();
        }

        private void DGVProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGVProductos.Rows[e.RowIndex];

                string nombre = fila.Cells["Nom"].Value.ToString();
                string precio = fila.Cells["Pre"].Value.ToString();
                string categoria = fila.Cells["Cat"].Value.ToString();
                string Existencia = fila.Cells["Ex"].Value.ToString();
                string NumRegistro = fila.Cells["Num"].Value.ToString();
                Form3 form3 = new Form3();

                form3.MostarInformacion(nombre, precio, categoria, Existencia, NumRegistro);
                form3.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

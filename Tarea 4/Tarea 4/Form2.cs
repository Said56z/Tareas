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
    public partial class Form2 : Form
    {
        private DataGridView _dgvProductoForm1;
        private DataGridView DGVProducto;

        public Form2(DataGridView dgvProductoForm1)
        {
            InitializeComponent();
            _dgvProductoForm1 = dgvProductoForm1;
            DGVProducto = new DataGridView();
            DGVProducto.ColumnCount = 5;
            DGVProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            textBox2.KeyPress += TextBox_KeyPress;
            textBox4.KeyPress += TextBox_KeyPress;
            textBox5.KeyPress += TextBox_KeyPress;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    if (NumeroRepetido(textBox5.Text))
                    {
                        MessageBox.Show("El número de registro ya existe. Por favor, ingrese uno diferente.");
                        return;
                    }
                    var producto = new string[]
                    {
                            textBox1.Text,
                            textBox2.Text,
                            textBox3.Text,
                            textBox4.Text,
                            textBox5.Text
                    };

                    DGVProducto.Rows.Add(producto);
                    _dgvProductoForm1.Rows.Add(producto);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    MessageBox.Show("Producto agregado correctamente");

                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error" + ex.Message);
            }
        }
        private bool NumeroRepetido(string numero)
        {
            foreach (DataGridViewRow row in DGVProducto.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() == numero)
                {
                    return true;
                }
            }
            return false;
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ProductoEventArgs : EventArgs
    {
        public string[] Producto { get; }

        public ProductoEventArgs(string[] producto)
        {
            Producto = producto;
        }
    }
}

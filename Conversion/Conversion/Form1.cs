using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Convertidor: Form
    {
        double x=0;
        
        public Convertidor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Dato1.Text, out double x))
            {

                if (TipoUnidad.Text == "Longitud")
                {
                    if (Unidad1.Text == "Metros")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x);

                        }
                        if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x / 1000);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 100);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 3.28084);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 39.3701);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x * 1.09361);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x * 0.000621371);
                        }
                    }
                    else if (Unidad1.Text == "Kilometros")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x * 1000);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 100000);
                        }
                        else if (Unidad2.Text == "Milimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 1000000);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 3280.84);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 39370.1);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x * 1093.61);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x * 0.621371);
                        }
                    }
                    else if (Unidad1.Text == "Centrimetros")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 100);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Kilometro")
                        {
                            Dato2.Text = Convert.ToString(x / 100000);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x / 30.48);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x / 2.54);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x / 91.44);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 160900);
                        }
                    }
                    else if (Unidad1.Text == "Pies")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 3.281);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x / 30.48);
                        }
                        else if (Unidad2.Text == "Kilometro")
                        {
                            Dato2.Text = Convert.ToString(x / 3281);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 12);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x / 3);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 5280);
                        }
                    }
                    else if (Unidad1.Text == "Millas")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x * 1609);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 160900);
                        }
                        else if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x * 1.609);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 5280);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 63360);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x * 1760);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                    }
                    else if (Unidad1.Text == "Pulgadas")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 39.37);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 2.54);
                        }
                        else if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x / 39370);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x / 12);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x / 36);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 63360);
                        }
                    }
                    else if (Unidad1.Text == "Yardas")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 1.094);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 91.44);
                        }
                        else if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x / 1094);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 3);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 36);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 1760);
                        }
                    }
                }
                else if (TipoUnidad.Text == "Temperatura")
                {
                    if (Unidad1.Text == "Celsius")
                    {
                        if (Unidad2.Text == "Celsius")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Fahrenheit")
                        {
                            Dato2.Text = Convert.ToString(x * 9 / 5 + 32);
                        }
                        else if (Unidad2.Text == "Kelvin")
                        {
                            Dato2.Text = Convert.ToString(x + 273.15);
                        }
                    }
                    else if (Unidad1.Text == "Fahrenheit")
                    {
                        if (Unidad2.Text == "Celsius")
                        {
                            Dato2.Text = Convert.ToString((x - 32) * 5 / 9);
                        }
                        else if (Unidad2.Text == "Fahrenheit")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Kelvin")
                        {
                            Dato2.Text = Convert.ToString((x - 32) * 5 / 9 + 273.15);
                        }
                    }
                    else if (Unidad1.Text == "Kelvin")
                    {
                        if (Unidad2.Text == "Celsius")
                        {
                            Dato2.Text = Convert.ToString(x - 273.15);
                        }
                        else if (Unidad2.Text == "Fahrenheit")
                        {
                            Dato2.Text = Convert.ToString((x - 273.15) * 9 / 5 + 32);
                        }
                        else if (Unidad2.Text == "Kelvin")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido");
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Unidad1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Dato1.Text, out double x))
            {

                if (TipoUnidad.Text == "Longitud")
                {
                    if (Unidad1.Text == "Metros")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x);

                        }
                        if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x / 1000);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 100);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 3.28084);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 39.3701);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x * 1.09361);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x * 0.000621371);
                        }
                    }
                    else if (Unidad1.Text == "Kilometros")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x * 1000);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 100000);
                        }
                        else if (Unidad2.Text == "Milimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 1000000);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 3280.84);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 39370.1);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x * 1093.61);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x * 0.621371);
                        }
                    }
                    else if (Unidad1.Text == "Centrimetros")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 100);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Kilometro")
                        {
                            Dato2.Text = Convert.ToString(x / 100000);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x / 30.48);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x / 2.54);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x / 91.44);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 160900);
                        }
                    }
                    else if (Unidad1.Text == "Pies")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 3.281);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x / 30.48);
                        }
                        else if (Unidad2.Text == "Kilometro")
                        {
                            Dato2.Text = Convert.ToString(x / 3281);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 12);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x / 3);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 5280);
                        }
                    }
                    else if (Unidad1.Text == "Millas")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x * 1609);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 160900);
                        }
                        else if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x * 1.609);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 5280);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 63360);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x * 1760);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                    }
                    else if (Unidad1.Text == "Pulgadas")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 39.37);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 2.54);
                        }
                        else if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x / 39370);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x / 12);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x / 36);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 63360);
                        }
                    }
                    else if (Unidad1.Text == "Yardas")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 1.094);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 91.44);
                        }
                        else if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x / 1094);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 3);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 36);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 1760);
                        }
                    }
                }
                else if (TipoUnidad.Text == "Temperatura")
                {
                    if (Unidad1.Text == "Celsius")
                    {
                        if (Unidad2.Text == "Celsius")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Fahrenheit")
                        {
                            Dato2.Text = Convert.ToString(x * 9 / 5 + 32);
                        }
                        else if (Unidad2.Text == "Kelvin")
                        {
                            Dato2.Text = Convert.ToString(x + 273.15);
                        }
                    }
                    else if (Unidad1.Text == "Fahrenheit")
                    {
                        if (Unidad2.Text == "Celsius")
                        {
                            Dato2.Text = Convert.ToString((x - 32) * 5 / 9);
                        }
                        else if (Unidad2.Text == "Fahrenheit")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Kelvin")
                        {
                            Dato2.Text = Convert.ToString((x - 32) * 5 / 9 + 273.15);
                        }
                    }
                    else if (Unidad1.Text == "Kelvin")
                    {
                        if (Unidad2.Text == "Celsius")
                        {
                            Dato2.Text = Convert.ToString(x - 273.15);
                        }
                        else if (Unidad2.Text == "Fahrenheit")
                        {
                            Dato2.Text = Convert.ToString((x - 273.15) * 9 / 5 + 32);
                        }
                        else if (Unidad2.Text == "Kelvin")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido");
            }
        }

        private void TipoUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoUnidad.Text == "Longitud")
            {
                Unidad1.Items.Clear();
                Unidad1.Items.Add("Metros");
                Unidad1.Items.Add("Kilometros");
                Unidad1.Items.Add("Centimetros");
                Unidad1.Items.Add("Pies");
                Unidad1.Items.Add("Pulgadas");
                Unidad1.Items.Add("Yardas");
                Unidad1.Items.Add("Millas");
                Unidad2.Items.Clear();
                Unidad2.Items.Add("Metros");
                Unidad2.Items.Add("Kilometros");
                Unidad2.Items.Add("Centimetros");
                Unidad2.Items.Add("Pies");
                Unidad2.Items.Add("Pulgadas");
                Unidad2.Items.Add("Yardas");
                Unidad2.Items.Add("Millas");
            }
            /*
            else if (TipoUnidad.Text == "Masa")
            {
                Unidad1.Items.Clear();
                Unidad1.Items.Add("Kilogramos");
                Unidad1.Items.Add("Gramos");
                Unidad1.Items.Add("Miligramos");
                Unidad1.Items.Add("Toneladas");
                Unidad1.Items.Add("Libras");
                Unidad1.Items.Add("Onzas");
                Unidad2.Items.Clear();
                Unidad2.Items.Add("Kilogramos");
                Unidad2.Items.Add("Gramos");
                Unidad2.Items.Add("Miligramos");
                Unidad2.Items.Add("Toneladas");
                Unidad2.Items.Add("Libras");
                Unidad2.Items.Add("Onzas");
            }
            */
            else if (TipoUnidad.Text == "Temperatura")
            {
                Unidad1.Items.Clear();
                Unidad1.Items.Add("Celsius");
                Unidad1.Items.Add("Fahrenheit");
                Unidad1.Items.Add("Kelvin");
                Unidad2.Items.Clear();
                Unidad2.Items.Add("Celsius");
                Unidad2.Items.Add("Fahrenheit");
                Unidad2.Items.Add("Kelvin");
            }
            /*
            else if (TipoUnidad.Text == "Datos")
            {
                Unidad1.Items.Clear();
                Unidad1.Items.Add("Bits");
                Unidad1.Items.Add("Bytes");
                Unidad1.Items.Add("Kilobytes");
                Unidad1.Items.Add("Megabytes");
                Unidad1.Items.Add("Gigabytes");
                Unidad1.Items.Add("Terabytes");
                Unidad2.Items.Clear();
                Unidad2.Items.Add("Bits");
                Unidad2.Items.Add("Bytes");
                Unidad2.Items.Add("Kilobytes");
                Unidad2.Items.Add("Megabytes");
                Unidad2.Items.Add("Gigabytes");
                Unidad2.Items.Add("Terabytes");

            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Unidad2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Dato1.Text, out double x))
            {

                if (TipoUnidad.Text == "Longitud")
                {
                    if (Unidad1.Text == "Metros")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x);

                        }
                        if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x / 1000);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 100);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 3.28084);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 39.3701);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x * 1.09361);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x * 0.000621371);
                        }
                    }
                    else if (Unidad1.Text == "Kilometros")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x * 1000);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 100000);
                        }
                        else if (Unidad2.Text == "Milimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 1000000);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 3280.84);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 39370.1);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x * 1093.61);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x * 0.621371);
                        }
                    }
                    else if (Unidad1.Text == "Centrimetros")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 100);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Kilometro")
                        {
                            Dato2.Text = Convert.ToString(x / 100000);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x / 30.48);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x / 2.54);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x / 91.44);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 160900);
                        }
                    }
                    else if (Unidad1.Text == "Pies")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 3.281);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x / 30.48);
                        }
                        else if (Unidad2.Text == "Kilometro")
                        {
                            Dato2.Text = Convert.ToString(x / 3281);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 12);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x / 3);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 5280);
                        }
                    }
                    else if (Unidad1.Text == "Millas")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x * 1609);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 160900);
                        }
                        else if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x * 1.609);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 5280);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 63360);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x * 1760);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                    }
                    else if (Unidad1.Text == "Pulgadas")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 39.37);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 2.54);
                        }
                        else if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x / 39370);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x / 12);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x / 36);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 63360);
                        }
                    }
                    else if (Unidad1.Text == "Yardas")
                    {
                        if (Unidad2.Text == "Metros")
                        {
                            Dato2.Text = Convert.ToString(x / 1.094);
                        }
                        else if (Unidad2.Text == "Centimetros")
                        {
                            Dato2.Text = Convert.ToString(x * 91.44);
                        }
                        else if (Unidad2.Text == "Kilometros")
                        {
                            Dato2.Text = Convert.ToString(x / 1094);
                        }
                        else if (Unidad2.Text == "Pies")
                        {
                            Dato2.Text = Convert.ToString(x * 3);
                        }
                        else if (Unidad2.Text == "Pulgadas")
                        {
                            Dato2.Text = Convert.ToString(x * 36);
                        }
                        else if (Unidad2.Text == "Yardas")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Millas")
                        {
                            Dato2.Text = Convert.ToString(x / 1760);
                        }
                    }
                }
                else if (TipoUnidad.Text == "Temperatura")
                {
                    if (Unidad1.Text == "Celsius")
                    {
                        if (Unidad2.Text == "Celsius")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Fahrenheit")
                        {
                            Dato2.Text = Convert.ToString(x * 9 / 5 + 32);
                        }
                        else if (Unidad2.Text == "Kelvin")
                        {
                            Dato2.Text = Convert.ToString(x + 273.15);
                        }
                    }
                    else if (Unidad1.Text == "Fahrenheit")
                    {
                        if (Unidad2.Text == "Celsius")
                        {
                            Dato2.Text = Convert.ToString((x - 32) * 5 / 9);
                        }
                        else if (Unidad2.Text == "Fahrenheit")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                        else if (Unidad2.Text == "Kelvin")
                        {
                            Dato2.Text = Convert.ToString((x - 32) * 5 / 9 + 273.15);
                        }
                    }
                    else if (Unidad1.Text == "Kelvin")
                    {
                        if (Unidad2.Text == "Celsius")
                        {
                            Dato2.Text = Convert.ToString(x - 273.15);
                        }
                        else if (Unidad2.Text == "Fahrenheit")
                        {
                            Dato2.Text = Convert.ToString((x - 273.15) * 9 / 5 + 32);
                        }
                        else if (Unidad2.Text == "Kelvin")
                        {
                            Dato2.Text = Convert.ToString(x);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido");
            }
        }
    }
}

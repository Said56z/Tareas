namespace Conversion
{
    partial class Convertidor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TipoUnidad = new System.Windows.Forms.ComboBox();
            this.Unidad1 = new System.Windows.Forms.ComboBox();
            this.Dato1 = new System.Windows.Forms.TextBox();
            this.Dato2 = new System.Windows.Forms.TextBox();
            this.Unidad2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(475, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TipoUnidad
            // 
            this.TipoUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.TipoUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoUnidad.ForeColor = System.Drawing.Color.White;
            this.TipoUnidad.FormattingEnabled = true;
            this.TipoUnidad.Items.AddRange(new object[] {
            "Longitud",
            "Masa",
            "Temperatura",
            "Datos"});
            this.TipoUnidad.Location = new System.Drawing.Point(26, 16);
            this.TipoUnidad.Name = "TipoUnidad";
            this.TipoUnidad.Size = new System.Drawing.Size(368, 21);
            this.TipoUnidad.TabIndex = 1;
            this.TipoUnidad.SelectedIndexChanged += new System.EventHandler(this.TipoUnidad_SelectedIndexChanged);
            // 
            // Unidad1
            // 
            this.Unidad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.Unidad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unidad1.ForeColor = System.Drawing.Color.White;
            this.Unidad1.FormattingEnabled = true;
            this.Unidad1.Items.AddRange(new object[] {
            "Longitud",
            "Kilometros",
            "Metros",
            "Centrimetros",
            "Millas",
            "Yardas",
            "Pies ",
            "Pulgadas",
            "",
            "Masa",
            "Toneladas",
            "Kilogramos",
            "Gramos",
            "Libra",
            "Onza",
            "",
            "",
            "Temperatura",
            "Kelvins",
            "Centigrados",
            "Fahrenheit",
            "",
            "Datos",
            "Bit",
            "Byte",
            "Kilobyte",
            "Megabyte",
            "Gigabyte",
            "Terabyte",
            ""});
            this.Unidad1.Location = new System.Drawing.Point(108, 178);
            this.Unidad1.Name = "Unidad1";
            this.Unidad1.Size = new System.Drawing.Size(134, 21);
            this.Unidad1.TabIndex = 2;
            this.Unidad1.SelectedIndexChanged += new System.EventHandler(this.Unidad1_SelectedIndexChanged);
            // 
            // Dato1
            // 
            this.Dato1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.Dato1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dato1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dato1.ForeColor = System.Drawing.Color.White;
            this.Dato1.Location = new System.Drawing.Point(108, 132);
            this.Dato1.Name = "Dato1";
            this.Dato1.Size = new System.Drawing.Size(134, 44);
            this.Dato1.TabIndex = 3;
            this.Dato1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Dato2
            // 
            this.Dato2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.Dato2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dato2.ForeColor = System.Drawing.Color.White;
            this.Dato2.Location = new System.Drawing.Point(304, 132);
            this.Dato2.Name = "Dato2";
            this.Dato2.Size = new System.Drawing.Size(134, 44);
            this.Dato2.TabIndex = 5;
            this.Dato2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Unidad2
            // 
            this.Unidad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.Unidad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unidad2.ForeColor = System.Drawing.Color.White;
            this.Unidad2.FormattingEnabled = true;
            this.Unidad2.Items.AddRange(new object[] {
            "Longitud",
            "Masa",
            "Temperatura",
            "Datos"});
            this.Unidad2.Location = new System.Drawing.Point(304, 178);
            this.Unidad2.Name = "Unidad2";
            this.Unidad2.Size = new System.Drawing.Size(134, 21);
            this.Unidad2.TabIndex = 4;
            this.Unidad2.SelectedIndexChanged += new System.EventHandler(this.Unidad2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(255, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(23, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Formula";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(77, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Convertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(530, 289);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dato2);
            this.Controls.Add(this.Unidad2);
            this.Controls.Add(this.Dato1);
            this.Controls.Add(this.Unidad1);
            this.Controls.Add(this.TipoUnidad);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Convertidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TipoUnidad;
        private System.Windows.Forms.ComboBox Unidad1;
        private System.Windows.Forms.TextBox Dato1;
        private System.Windows.Forms.TextBox Dato2;
        private System.Windows.Forms.ComboBox Unidad2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


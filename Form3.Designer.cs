namespace Proyecto_Unidad_1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreU = new System.Windows.Forms.TextBox();
            this.CorreoU = new System.Windows.Forms.TextBox();
            this.FechaNacU = new System.Windows.Forms.TextBox();
            this.ContraU = new System.Windows.Forms.TextBox();
            this.botonsalir = new System.Windows.Forms.Button();
            this.ValidarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(208, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(32)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(270, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(32)))), ((int)(((byte)(152)))));
            this.label3.Location = new System.Drawing.Point(340, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(32)))), ((int)(((byte)(152)))));
            this.label4.Location = new System.Drawing.Point(351, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contaseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(32)))), ((int)(((byte)(152)))));
            this.label5.Location = new System.Drawing.Point(340, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Nac.:";
            // 
            // NombreU
            // 
            this.NombreU.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreU.Location = new System.Drawing.Point(266, 170);
            this.NombreU.Name = "NombreU";
            this.NombreU.Size = new System.Drawing.Size(223, 27);
            this.NombreU.TabIndex = 6;
            this.NombreU.TextChanged += new System.EventHandler(this.CorreoU_TextChanged);
            // 
            // CorreoU
            // 
            this.CorreoU.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoU.Location = new System.Drawing.Point(323, 229);
            this.CorreoU.Name = "CorreoU";
            this.CorreoU.Size = new System.Drawing.Size(166, 27);
            this.CorreoU.TabIndex = 7;
            this.CorreoU.TextChanged += new System.EventHandler(this.CorreoU_TextChanged_1);
            // 
            // FechaNacU
            // 
            this.FechaNacU.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaNacU.Location = new System.Drawing.Point(332, 290);
            this.FechaNacU.Name = "FechaNacU";
            this.FechaNacU.Size = new System.Drawing.Size(157, 27);
            this.FechaNacU.TabIndex = 8;
            this.FechaNacU.TextChanged += new System.EventHandler(this.FechaNacU_TextChanged);
            // 
            // ContraU
            // 
            this.ContraU.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraU.Location = new System.Drawing.Point(344, 345);
            this.ContraU.Name = "ContraU";
            this.ContraU.Size = new System.Drawing.Size(145, 27);
            this.ContraU.TabIndex = 9;
            this.ContraU.TextChanged += new System.EventHandler(this.ContraU_TextChanged);
            // 
            // botonsalir
            // 
            this.botonsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonsalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonsalir.ForeColor = System.Drawing.Color.Red;
            this.botonsalir.Location = new System.Drawing.Point(400, 453);
            this.botonsalir.Name = "botonsalir";
            this.botonsalir.Size = new System.Drawing.Size(89, 34);
            this.botonsalir.TabIndex = 11;
            this.botonsalir.Text = "Salir";
            this.botonsalir.UseVisualStyleBackColor = false;
            this.botonsalir.Click += new System.EventHandler(this.botonsalir_Click);
            // 
            // ValidarDatos
            // 
            this.ValidarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(32)))), ((int)(((byte)(153)))));
            this.ValidarDatos.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(75)))));
            this.ValidarDatos.Location = new System.Drawing.Point(333, 391);
            this.ValidarDatos.Name = "ValidarDatos";
            this.ValidarDatos.Size = new System.Drawing.Size(156, 37);
            this.ValidarDatos.TabIndex = 12;
            this.ValidarDatos.Text = "Registrarse";
            this.ValidarDatos.UseVisualStyleBackColor = false;
            this.ValidarDatos.Click += new System.EventHandler(this.ValidarDatos_Click);
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 499);
            this.ControlBox = false;
            this.Controls.Add(this.ValidarDatos);
            this.Controls.Add(this.botonsalir);
            this.Controls.Add(this.ContraU);
            this.Controls.Add(this.FechaNacU);
            this.Controls.Add(this.CorreoU);
            this.Controls.Add(this.NombreU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreU;
        private System.Windows.Forms.TextBox CorreoU;
        private System.Windows.Forms.TextBox FechaNacU;
        private System.Windows.Forms.TextBox ContraU;
        private System.Windows.Forms.Button botonsalir;
        private System.Windows.Forms.Button ValidarDatos;
    }
}
namespace Proyecto_Unidad_1
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botonsalir = new System.Windows.Forms.Button();
            this.NombreUL = new System.Windows.Forms.Label();
            this.CorreoUL = new System.Windows.Forms.Label();
            this.FechaNacUL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(315, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(32)))), ((int)(((byte)(152)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(75)))));
            this.button1.Location = new System.Drawing.Point(464, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonsalir
            // 
            this.botonsalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonsalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonsalir.ForeColor = System.Drawing.Color.Red;
            this.botonsalir.Location = new System.Drawing.Point(12, 545);
            this.botonsalir.Name = "botonsalir";
            this.botonsalir.Size = new System.Drawing.Size(89, 34);
            this.botonsalir.TabIndex = 2;
            this.botonsalir.Text = "Salir";
            this.botonsalir.UseVisualStyleBackColor = false;
            this.botonsalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // NombreUL
            // 
            this.NombreUL.AutoSize = true;
            this.NombreUL.BackColor = System.Drawing.Color.Transparent;
            this.NombreUL.Cursor = System.Windows.Forms.Cursors.Default;
            this.NombreUL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NombreUL.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(75)))));
            this.NombreUL.Location = new System.Drawing.Point(566, 31);
            this.NombreUL.Name = "NombreUL";
            this.NombreUL.Size = new System.Drawing.Size(0, 48);
            this.NombreUL.TabIndex = 3;
            this.NombreUL.Click += new System.EventHandler(this.NombreUL_Click);
            // 
            // CorreoUL
            // 
            this.CorreoUL.AutoSize = true;
            this.CorreoUL.BackColor = System.Drawing.Color.Transparent;
            this.CorreoUL.Cursor = System.Windows.Forms.Cursors.Default;
            this.CorreoUL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CorreoUL.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoUL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(75)))));
            this.CorreoUL.Location = new System.Drawing.Point(815, 9);
            this.CorreoUL.Name = "CorreoUL";
            this.CorreoUL.Size = new System.Drawing.Size(0, 19);
            this.CorreoUL.TabIndex = 4;
            this.CorreoUL.Click += new System.EventHandler(this.label2_Click);
            // 
            // FechaNacUL
            // 
            this.FechaNacUL.AutoSize = true;
            this.FechaNacUL.BackColor = System.Drawing.Color.Transparent;
            this.FechaNacUL.Cursor = System.Windows.Forms.Cursors.Default;
            this.FechaNacUL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FechaNacUL.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaNacUL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(75)))));
            this.FechaNacUL.Location = new System.Drawing.Point(12, 9);
            this.FechaNacUL.Name = "FechaNacUL";
            this.FechaNacUL.Size = new System.Drawing.Size(0, 19);
            this.FechaNacUL.TabIndex = 6;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1098, 588);
            this.ControlBox = false;
            this.Controls.Add(this.FechaNacUL);
            this.Controls.Add(this.CorreoUL);
            this.Controls.Add(this.NombreUL);
            this.Controls.Add(this.botonsalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonsalir;
        private System.Windows.Forms.Label NombreUL;
        private System.Windows.Forms.Label CorreoUL;
        private System.Windows.Forms.Label FechaNacUL;
    }
}


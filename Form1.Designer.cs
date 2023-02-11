namespace SistemaColegio
{
    partial class RegistroAspirante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAspirante));
            this.label1 = new System.Windows.Forms.Label();
            this.NombreAspirante = new System.Windows.Forms.TextBox();
            this.DireccionAspirantes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TelefonoAspirante = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdentificacionLBL = new System.Windows.Forms.Label();
            this.Identificacion = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(75, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // NombreAspirante
            // 
            this.NombreAspirante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreAspirante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreAspirante.Location = new System.Drawing.Point(160, 79);
            this.NombreAspirante.Name = "NombreAspirante";
            this.NombreAspirante.Size = new System.Drawing.Size(154, 25);
            this.NombreAspirante.TabIndex = 1;
            // 
            // DireccionAspirantes
            // 
            this.DireccionAspirantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DireccionAspirantes.Location = new System.Drawing.Point(160, 163);
            this.DireccionAspirantes.Name = "DireccionAspirantes";
            this.DireccionAspirantes.Size = new System.Drawing.Size(154, 25);
            this.DireccionAspirantes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(58, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(68, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono:";
            // 
            // TelefonoAspirante
            // 
            this.TelefonoAspirante.BackColor = System.Drawing.Color.White;
            this.TelefonoAspirante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelefonoAspirante.Location = new System.Drawing.Point(160, 218);
            this.TelefonoAspirante.Name = "TelefonoAspirante";
            this.TelefonoAspirante.Size = new System.Drawing.Size(154, 25);
            this.TelefonoAspirante.TabIndex = 6;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(430, 423);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(106, 44);
            this.Limpiar.TabIndex = 7;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(297, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registro de usuarios";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(735, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(56, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // IdentificacionLBL
            // 
            this.IdentificacionLBL.AutoSize = true;
            this.IdentificacionLBL.BackColor = System.Drawing.Color.Transparent;
            this.IdentificacionLBL.Location = new System.Drawing.Point(23, 120);
            this.IdentificacionLBL.Name = "IdentificacionLBL";
            this.IdentificacionLBL.Size = new System.Drawing.Size(140, 24);
            this.IdentificacionLBL.TabIndex = 12;
            this.IdentificacionLBL.Text = "Identificacion:";
            // 
            // Identificacion
            // 
            this.Identificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Identificacion.Location = new System.Drawing.Point(160, 120);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(154, 25);
            this.Identificacion.TabIndex = 13;
            // 
            // RegistroAspirante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::SistemaColegio.Properties.Resources.FondoA;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.Identificacion);
            this.Controls.Add(this.IdentificacionLBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.TelefonoAspirante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DireccionAspirantes);
            this.Controls.Add(this.NombreAspirante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegistroAspirante";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Registro Estudiante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreAspirante;
        private System.Windows.Forms.TextBox DireccionAspirantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelefonoAspirante;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.Label IdentificacionLBL;
        private System.Windows.Forms.TextBox Identificacion;
    }
}


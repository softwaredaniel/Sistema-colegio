namespace SistemaColegio
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Identificacion = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Grado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RegistrarEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Nombre
            // 
            this.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(202, 66);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(154, 19);
            this.Nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identificacion:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Identificacion
            // 
            this.Identificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Identificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identificacion.Location = new System.Drawing.Point(202, 209);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(154, 19);
            this.Identificacion.TabIndex = 4;
            // 
            // Apellidos
            // 
            this.Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellidos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos.Location = new System.Drawing.Point(202, 135);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(154, 19);
            this.Apellidos.TabIndex = 6;
            this.Apellidos.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Grado
            // 
            this.Grado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grado.Location = new System.Drawing.Point(202, 276);
            this.Grado.Name = "Grado";
            this.Grado.Size = new System.Drawing.Size(154, 19);
            this.Grado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grado:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // RegistrarEstudiante
            // 
            this.RegistrarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.RegistrarEstudiante.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarEstudiante.Location = new System.Drawing.Point(316, 358);
            this.RegistrarEstudiante.Name = "RegistrarEstudiante";
            this.RegistrarEstudiante.Size = new System.Drawing.Size(127, 47);
            this.RegistrarEstudiante.TabIndex = 9;
            this.RegistrarEstudiante.Text = "Registrar";
            this.RegistrarEstudiante.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::SistemaColegio.Properties.Resources.FondoE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistrarEstudiante);
            this.Controls.Add(this.Grado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Identificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Identificacion;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Grado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegistrarEstudiante;
    }
}

namespace SistemaColegio
{
    partial class Form6
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
            this.UsuarioCoordinador = new System.Windows.Forms.Label();
            this.ContraseñaCoordinador = new System.Windows.Forms.Label();
            this.CoordinadorUsuario = new System.Windows.Forms.TextBox();
            this.CoordinadorContraseña = new System.Windows.Forms.TextBox();
            this.IngresarCoordinador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsuarioCoordinador
            // 
            this.UsuarioCoordinador.BackColor = System.Drawing.Color.Transparent;
            this.UsuarioCoordinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioCoordinador.Location = new System.Drawing.Point(332, 75);
            this.UsuarioCoordinador.Name = "UsuarioCoordinador";
            this.UsuarioCoordinador.Size = new System.Drawing.Size(117, 39);
            this.UsuarioCoordinador.TabIndex = 0;
            this.UsuarioCoordinador.Text = "Usuario";
            // 
            // ContraseñaCoordinador
            // 
            this.ContraseñaCoordinador.BackColor = System.Drawing.Color.Transparent;
            this.ContraseñaCoordinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaCoordinador.Location = new System.Drawing.Point(304, 177);
            this.ContraseñaCoordinador.Name = "ContraseñaCoordinador";
            this.ContraseñaCoordinador.Size = new System.Drawing.Size(166, 39);
            this.ContraseñaCoordinador.TabIndex = 1;
            this.ContraseñaCoordinador.Text = "Contraseña";
            // 
            // CoordinadorUsuario
            // 
            this.CoordinadorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordinadorUsuario.Location = new System.Drawing.Point(257, 117);
            this.CoordinadorUsuario.Name = "CoordinadorUsuario";
            this.CoordinadorUsuario.Size = new System.Drawing.Size(255, 35);
            this.CoordinadorUsuario.TabIndex = 2;
            // 
            // CoordinadorContraseña
            // 
            this.CoordinadorContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoordinadorContraseña.Location = new System.Drawing.Point(257, 219);
            this.CoordinadorContraseña.Name = "CoordinadorContraseña";
            this.CoordinadorContraseña.PasswordChar = '*';
            this.CoordinadorContraseña.Size = new System.Drawing.Size(255, 35);
            this.CoordinadorContraseña.TabIndex = 3;
            // 
            // IngresarCoordinador
            // 
            this.IngresarCoordinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarCoordinador.Location = new System.Drawing.Point(310, 309);
            this.IngresarCoordinador.Name = "IngresarCoordinador";
            this.IngresarCoordinador.Size = new System.Drawing.Size(160, 33);
            this.IngresarCoordinador.TabIndex = 4;
            this.IngresarCoordinador.Text = "INGRESAR";
            this.IngresarCoordinador.UseVisualStyleBackColor = true;
            this.IngresarCoordinador.Click += new System.EventHandler(this.IngresarCoordinador_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaColegio.Properties.Resources.FondoA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IngresarCoordinador);
            this.Controls.Add(this.CoordinadorContraseña);
            this.Controls.Add(this.CoordinadorUsuario);
            this.Controls.Add(this.ContraseñaCoordinador);
            this.Controls.Add(this.UsuarioCoordinador);
            this.Name = "Form6";
            this.Text = "COORDINADOR";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioCoordinador;
        private System.Windows.Forms.Label ContraseñaCoordinador;
        private System.Windows.Forms.TextBox CoordinadorUsuario;
        private System.Windows.Forms.TextBox CoordinadorContraseña;
        private System.Windows.Forms.Button IngresarCoordinador;
    }
}
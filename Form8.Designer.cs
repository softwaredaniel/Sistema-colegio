﻿
namespace SistemaColegio
{
    partial class VistaProfesor
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
            this.curso = new System.Windows.Forms.ComboBox();
            this.SelectCurso = new System.Windows.Forms.Label();
            this.ConsultaProfesor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // curso
            // 
            this.curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curso.FormattingEnabled = true;
            this.curso.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3"});
            this.curso.Location = new System.Drawing.Point(263, 54);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(203, 33);
            this.curso.TabIndex = 0;
            // 
            // SelectCurso
            // 
            this.SelectCurso.AutoSize = true;
            this.SelectCurso.BackColor = System.Drawing.Color.Transparent;
            this.SelectCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCurso.Location = new System.Drawing.Point(53, 57);
            this.SelectCurso.Name = "SelectCurso";
            this.SelectCurso.Size = new System.Drawing.Size(187, 25);
            this.SelectCurso.TabIndex = 1;
            this.SelectCurso.Text = "Seleccione Curso:";
            // 
            // ConsultaProfesor
            // 
            this.ConsultaProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaProfesor.Location = new System.Drawing.Point(560, 54);
            this.ConsultaProfesor.Name = "ConsultaProfesor";
            this.ConsultaProfesor.Size = new System.Drawing.Size(126, 33);
            this.ConsultaProfesor.TabIndex = 2;
            this.ConsultaProfesor.Text = "Consultar";
            this.ConsultaProfesor.UseVisualStyleBackColor = true;
            this.ConsultaProfesor.Click += new System.EventHandler(this.ConsultaProfesor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 256);
            this.dataGridView1.TabIndex = 3;
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
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // VistaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaColegio.Properties.Resources.FondoA;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ConsultaProfesor);
            this.Controls.Add(this.SelectCurso);
            this.Controls.Add(this.curso);
            this.Name = "VistaProfesor";
            this.Text = "Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox curso;
        private System.Windows.Forms.Label SelectCurso;
        private System.Windows.Forms.Button ConsultaProfesor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
    }
}
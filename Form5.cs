using System;

using System.Windows.Forms;

namespace SistemaColegio
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Estudiantes();
            formulario.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistroAspirante();
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new VistaProfesor();
            formulario.Show();
        }
    }
}

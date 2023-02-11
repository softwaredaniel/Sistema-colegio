using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace SistemaColegio
{
    public partial class VistaProfesor : Form
    {
        OracleConnection Ora = new OracleConnection("DATA SOURCE=XE;PASSWORD=administrador; User id=ADMINISTRADOR;");
        public VistaProfesor()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Inicio();
            formulario.Show();
        }

        private void ConsultaProfesor_Click(object sender, EventArgs e)
        {
            Ora.Open();
            OracleCommand comando = new OracleCommand("SELECT E.NOMBRE,E.IDENTIFICACION,C.NombreCurso From ESTUDIANTES E,CURSO C where NombreCurso Like ('%" + curso.Text + "%')", Ora);




            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            Ora.Close();
        }
    }
}

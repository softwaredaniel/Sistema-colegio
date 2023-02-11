using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace SistemaColegio
{
    public partial class Estudiantes : Form
    {
        OracleConnection Ora = new OracleConnection("DATA SOURCE=XE;PASSWORD=administrador; User id=ADMINISTRADOR;");
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Inicio();
            formulario.Show();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Ora.Open();
            OracleCommand comando = new OracleCommand("SELECT E.NOMBRE,E.IDENTIFICACION,C.NombreCurso From ESTUDIANTES E,CURSO C where identificacion Like ('%"+Identificacion.Text+"%')", Ora);
            
            
            
           
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            ver.DataSource = tabla;
            Ora.Close();
          

        }
    }
}

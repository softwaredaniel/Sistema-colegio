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
    public partial class RegistroAspirante : Form
    {
        OracleConnection Ora = new OracleConnection("DATA SOURCE=XE;PASSWORD=administrador; User id=ADMINISTRADOR;");
        public RegistroAspirante()
        {
            InitializeComponent();
            
            
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Ora.Open();
            OracleCommand comando = new OracleCommand("GUARDAR", Ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("nom", OracleType.VarChar).Value = NombreAspirante.Text;
            comando.Parameters.Add("iden", OracleType.VarChar).Value = Identificacion.Text;
            comando.Parameters.Add("dire", OracleType.VarChar).Value = DireccionAspirantes.Text;
            comando.Parameters.Add("tel", OracleType.VarChar).Value = TelefonoAspirante.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Estudiante registrado con exito");
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            NombreAspirante.Text = "";
            Identificacion.Text = "";
            DireccionAspirantes.Text = "";
            TelefonoAspirante.Text = "";
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Inicio();
            formulario.Show();
            
        }
    }
}

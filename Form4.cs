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
    public partial class VistaEstudiante : Form
    {
        OracleConnection Ora = new OracleConnection("DATA SOURCE=XE;PASSWORD=administrador; User id=ADMINISTRADOR;");
        public VistaEstudiante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            Ora.Open();
            OracleCommand comando = new OracleCommand("seleccionarEstudiantes", Ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros",OracleType.Cursor).Direction=ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvestudiante.DataSource=tabla;
            Ora.Close();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Ora.Open();
            OracleCommand comando = new OracleCommand("Actualizar", Ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idE", OracleType.Number).Value = Convert.ToInt32(txtid.Text);
            comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
            comando.Parameters.Add("IDEN", OracleType.VarChar).Value = txtIdentificacion.Text;
            comando.Parameters.Add("DIRE", OracleType.VarChar).Value = txtDire.Text;
            comando.Parameters.Add("TELEFONO", OracleType.VarChar).Value = txtTelf.Text;
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha actualizado el estudiante");
            Ora.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AsignarCurso_Click(object sender, EventArgs e)
        {
            Ora.Open();
            OracleCommand comando = new OracleCommand("ActualizarCurso", Ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("iden", OracleType.VarChar).Value = txtIdentificacion.Text;
            comando.ExecuteNonQuery();
           
            Ora.Close();

        }
    }
}

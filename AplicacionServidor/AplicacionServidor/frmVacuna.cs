using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionServidor
{
    public partial class frmVacuna : Form
    {
        public frmVacuna()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "INSERT INTO Vacunas VALUES(@Id_Vacuna, @Descripcion);";

                conx.Open();//Se establece la conexion con la base de datos
                SqlCommand comando = new SqlCommand(query, conx);

                comando.Parameters.AddWithValue("@Id_Vacuna", int.Parse(txtCodigo.Text));
                comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                comando.ExecuteNonQuery();

                MessageBox.Show("Vacuna Registrada!");
                limpiar();

                conx.Close();//Se cierra la conexion
            }
            catch (SqlException)
            {
                MessageBox.Show("Error! Al insertar datos");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Debe llenar todos los campos");
            }
        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

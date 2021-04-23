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
    public partial class frmFinca : Form
    {
        public frmFinca()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia la clase SqlConnection
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);

                string query = "INSERT INTO Finca VALUES(@Id_Finca,@Nombre,@Tamanno,@Direccion,@Telefono);";
                conx.Open(); //Se abre la conexion

                SqlCommand comando = new SqlCommand(query, conx);
                comando.Parameters.AddWithValue("@Id_Finca", int.Parse(txtNum.Text));
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Tamanno", int.Parse(txtTamanno.Text));
                comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                comando.Parameters.AddWithValue("@Telefono", int.Parse(txtTelefono.Text));
                comando.ExecuteNonQuery();

                MessageBox.Show("Finca Registrada");
                limpiar();

                conx.Close(); //Se cierra la conexion 
            }
            catch(SqlException error)
            {
                MessageBox.Show("Error! error");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Debe ingresar todos los datos");
            }
            
        }

        private void limpiar()
        {
            txtNum.Text = "";
            txtNombre.Text = "";
            txtTamanno.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e); //Solo permite ingresar numeros
        }

        private void txtTamanno_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e); //Solo permite ingresar numeros
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e); //Solo permite ingresar numeros
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "INSERT INTO Empleado VALUES(@Identificacion, @Nombre, @Primer_Apellido, @Segundo_Apellido, @Salario, @Usuario, @Contrasena, @Estado)";

                conx.Open();//Se abre la conexion

                SqlCommand comando = new SqlCommand(query, conx);

                comando.Parameters.AddWithValue("@Identificacion", int.Parse(txtId.Text));
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Primer_Apellido", txtPrimer.Text);
                comando.Parameters.AddWithValue("@Segundo_Apellido", txtSegundo.Text);
                comando.Parameters.AddWithValue("@Salario", double.Parse(txtSalario.Text));
                comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@Contrasena", txtContrasenna.Text);
                comando.Parameters.AddWithValue("@Estado", 1);
                comando.ExecuteNonQuery();

                MessageBox.Show("Empleado Registrado");
                limpiar();

                conx.Close(); //Se cierra la conexion 

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
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrimer.Text = "";
            txtSegundo.Text = "";
            txtSalario.Text = "";
            txtUsuario.Text = "";
            txtContrasenna.Text = "";
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.numerosDecimales(e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

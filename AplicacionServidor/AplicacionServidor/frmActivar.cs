using Libreria;
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
    public partial class frmActivar : Form
    {
        private List<Empleado> empleados = new List<Empleado>();
        public frmActivar()
        {
            InitializeComponent();
        }

        private void frmActivar_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarEmpleados()
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "SELECT * FROM Empleado;";

                conx.Open();

                SqlCommand comando = new SqlCommand(query, conx);
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Empleado empleado = new Empleado(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), (double)dr.GetDecimal(4), dr.GetString(5), dr.GetString(6), dr.GetInt32(7));
                        empleados.Add(empleado);
                    }
                }
                dvgEmpleados.DataSource = empleados;
                conx.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error! al cargar datos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "UPDATE Empleado SET Estado = @Estado WHERE Identificacion = @Identificacion;";

                conx.Open(); //Se abre la conexion con la base de datos

                SqlCommand comando = new SqlCommand(query, conx);
                comando.Parameters.AddWithValue("@Estado", 1);
                comando.Parameters.AddWithValue("@Identificacion", int.Parse(txtId.Text));
                comando.ExecuteNonQuery();

                MessageBox.Show("Empleado Activado!");

                conx.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al Actualizar Estado!");
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "UPDATE Empleado SET Estado = @Estado WHERE Identificacion = @Identificacion;";

                conx.Open(); //Se abre la conexion con la base de datos

                SqlCommand comando = new SqlCommand(query, conx);
                comando.Parameters.AddWithValue("@Estado", 0);
                comando.Parameters.AddWithValue("@Identificacion", int.Parse(txtId.Text));
                comando.ExecuteNonQuery();

                MessageBox.Show("Empleado Desactivado!");
                
                conx.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al Actualizar Estado!");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarEmpleados();

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e);
        }
    }
}

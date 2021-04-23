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
    public partial class frmDueno : Form
    {
        private List<Finca> fincas = new List<Finca>();
        public frmDueno()
        {
            InitializeComponent();
        }

        private void frmDueno_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "SELECT * FROM Finca;";

                conx.Open();

                SqlCommand comando = new SqlCommand(query, conx);
                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Finca finca = new Finca(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetString(3), dr.GetInt32(4));
                        fincas.Add(finca);
                    }
                }
                llenarCombo();
                conx.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error! al cargar datos");
            }
        }

        private void llenarCombo()
        {
            cbxFinca.DataSource = fincas;
            cbxFinca.DisplayMember = "numFinca";
            cbxFinca.ValueMember = "nomFinca";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia la clase SqlConnection
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "INSERT INTO Duenno VALUES(@Identificacion, @Nombre, @Primer_Apellido, @Segundo_Apellido, @Correo_Electronico, @Telefono_Celular, @Id_Finca);";

                conx.Open();// Se abre la conexion

                SqlCommand comando = new SqlCommand(query, conx);
                comando.Parameters.AddWithValue("@Identificacion", int.Parse(txtId.Text));
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Primer_Apellido", txtPrimer.Text);
                comando.Parameters.AddWithValue("@Segundo_Apellido", txtSegundo.Text);
                comando.Parameters.AddWithValue("@Correo_Electronico", txtCorreo.Text);
                comando.Parameters.AddWithValue("@Telefono_Celular", int.Parse(txtTelefono.Text));
                comando.Parameters.AddWithValue("@Id_Finca", obtenerId());
                comando.ExecuteNonQuery();

                MessageBox.Show("Dueño Registrado");
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
        //Se obtiene el id de la finca
        private int obtenerId()
        {
            Finca finca = (Finca)cbxFinca.SelectedItem;
            int idFinca = finca.NumFinca;
            return idFinca;
        }

        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrimer.Text = "";
            txtSegundo.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e);
        }

    }
}

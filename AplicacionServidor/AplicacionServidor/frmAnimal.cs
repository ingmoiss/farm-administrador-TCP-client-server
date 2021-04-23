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
    public partial class frmAnimal : Form
    {
        private List<Finca> fincas = new List<Finca>();
        private List<Raza> razas = new List<Raza>();
        int? madre;

        public frmAnimal()
        {
            InitializeComponent();
        }

        private void frmAnimal_Load(object sender, EventArgs e)
        {
            cargarFincas();
            cargarRazas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "INSERT INTO Animales VALUES(@Id_animal, @Nombre, @Id_Finca, @Id_Raza, @Fecha_Nacimiento, @Sexo, @Id_Madre, @Id_Padre);";

                conx.Open(); //Se abre conexion con la base de datos
                SqlCommand comando = new SqlCommand(query, conx);

                comando.Parameters.AddWithValue("@Id_animal", int.Parse(txtIdAnimal.Text));
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Id_Finca", obtenerIdF());
                comando.Parameters.AddWithValue("@Id_Raza", obtenerIdR());
                comando.Parameters.AddWithValue("@Fecha_Nacimiento", dtpNacimiento.Value);
                comando.Parameters.AddWithValue("@Sexo", obtenerSexo());
                comando.Parameters.AddWithValue("@Id_Madre", DBNull.Value);
                comando.Parameters.AddWithValue("@Id_Padre", DBNull.Value);
                comando.ExecuteNonQuery();

                MessageBox.Show("Animal Registrado!");
                limpiar();

                conx.Close();//Se cierra la conexion con la base de datos

            }
            catch (SqlException error)
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
            txtIdAnimal.Text = "";
            txtNombre.Text = "";
            txtMadre.Text = "";
            txtPadre.Text = "";
        }

        private int obtenerIdF()
        {
            Finca finca = (Finca)cbxFincas.SelectedItem;
            int idFinca = finca.NumFinca;
            return idFinca;
        }

        private int obtenerIdR()
        {
            Raza raza = (Raza)cbxRazas.SelectedItem;
            int idRaza = raza.Codigo;
            return idRaza;
        }

        private int obtenerSexo()
        {
            if (cbxSexo.SelectedItem.Equals("Hembra"))
            {
            return 1;
            }
            else
            {
            return 2;
            }
        }

        private int? obtenerMadre()
        {
            if (txtMadre.Text.Equals(""))
            {
                return null;
            }
            else
            {
                return int.Parse(txtMadre.Text); //int.Parse(txtMadre.Text)
            }
        }

        private int? obtenerPadre()
        {
            if (txtPadre.Text.Equals(""))
            {
                return null;
            }
            else
            {
                return int.Parse(txtPadre.Text);
            }
        }

        private void cargarFincas()
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "SELECT * FROM Finca;";

                conx.Open();

                SqlCommand comando = new SqlCommand(query, conx);
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Finca finca = new Finca(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetString(3), dr.GetInt32(4));
                        fincas.Add(finca);
                    }
                }
                llenarComboFincas();
                conx.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error! al cargar datos");
            }
        }

        private void cargarRazas()
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "SELECT * FROM Raza;";

                conx.Open();

                SqlCommand comando = new SqlCommand(query, conx);
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Raza raza = new Raza(dr.GetInt32(0), dr.GetString(1));
                        razas.Add(raza);
                    }
                }
                llenarComboRazas();
                conx.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error! al cargar datos");
            }
        }
        private void llenarComboFincas()
        {
            cbxFincas.DataSource = fincas;
            cbxFincas.DisplayMember = "numFinca";
            cbxFincas.ValueMember = "nomFinca";
        }

        private void llenarComboRazas()
        {
            cbxRazas.DataSource = razas;
            cbxRazas.DisplayMember = "codigo";
            cbxRazas.ValueMember = "descripcion";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e);
        }

        private void txtPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e);
        }

        private void txtMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.soloNumeros(e);
        }
    }
}

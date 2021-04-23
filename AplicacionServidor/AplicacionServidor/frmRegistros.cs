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
    public partial class frmRegistros : Form
    {
        private List<Finca> fincas = new List<Finca>();
        private List<Raza> razas = new List<Raza>();
        private List<Dueno> duenos = new List<Dueno>();
        private List<Empleado> empleados = new List<Empleado>();
        private List<Animal> animales = new List<Animal>();
        private List<Vacuna> vacunas = new List<Vacuna>();

        public frmRegistros()
        {
            InitializeComponent();
        }
        private void frmRegistros_Load(object sender, EventArgs e)
        {
            cargarFincas();
            cargarRazas();
            cargarEmpleados();
            cargarVacunas();
            cargarDuenos();
            cargarAnimales();
        }

        private void btnFincas_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = fincas;
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
                conx.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error! al cargar datos");
            }
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

                conx.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error! al cargar datos");
            }
        }

        private void cargarDuenos()
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "SELECT * FROM Duenno join Finca on Duenno.Id_Finca = Finca.Id_Finca;";

                conx.Open();

                SqlCommand comando = new SqlCommand(query, conx);
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Finca finca = new Finca(dr.GetInt32(7), dr.GetString(8), dr.GetInt32(9), dr.GetString(10), dr.GetInt32(11));
                        Dueno dueno = new Dueno(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5), finca);
                        duenos.Add(dueno);
                    }
                }

                conx.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error! al cargar datos");
            }
        }

        private void cargarAnimales()
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "SELECT * FROM Animales join Raza on Animales.Id_Raza = Raza.Id_Raza join Finca on Animales.Id_Finca = Finca.Id_Finca;";

                conx.Open();

                SqlCommand comando = new SqlCommand(query, conx);
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Raza raza = new Raza(dr.GetInt32(8), dr.GetString(9));
                        Finca finca = new Finca(dr.GetInt32(10), dr.GetString(11), dr.GetInt32(12), dr.GetString(13), dr.GetInt32(14));
                        Animal animal = new Animal(dr.GetInt32(0), dr.GetString(1), finca, raza, dr.GetInt32(5), null, null, dr.GetDateTime(4));
                        animales.Add(animal);
                    }
                }

                conx.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error! al cargar datos");
            }
        }

        private void cargarVacunas()
        {
            try
            {
                SqlConnection conx = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString);
                string query = "SELECT * FROM Vacunas;";

                conx.Open();

                SqlCommand comando = new SqlCommand(query, conx);
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Vacuna vacuna = new Vacuna(dr.GetInt32(0), dr.GetString(1));
                        vacunas.Add(vacuna);
                    }
                }
                conx.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show("Error! al cargar datos");
            }
        }

        private void btnRazas_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = razas;
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = vacunas;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = empleados;
        }

        private void btnDuennos_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = duenos;
        }
        private void btnAnimales_Click(object sender, EventArgs e)
        {
            dgvRegistros.DataSource = animales;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

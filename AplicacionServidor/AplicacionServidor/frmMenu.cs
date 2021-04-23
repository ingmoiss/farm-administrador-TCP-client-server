using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria; //Se incluye la libreria con las clases

namespace AplicacionServidor
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDueno_Click(object sender, EventArgs e)
        {
            frmDueno dueno = new frmDueno();
            dueno.Show();
        }

        private void btnFinca_Click(object sender, EventArgs e)
        {
            frmFinca finca = new frmFinca();
            finca.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.Show();
        }

        private void btnRaza_Click(object sender, EventArgs e)
        {
            frmRaza raza = new frmRaza();
            raza.Show();
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            frmAnimal animal = new frmAnimal();
            animal.Show();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            frmRegistros registros = new frmRegistros();
            registros.Show();
        }

        private void btnVacuna_Click(object sender, EventArgs e)
        {
            frmVacuna vacuna = new frmVacuna();
            vacuna.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmActivar activar = new frmActivar();
            activar.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

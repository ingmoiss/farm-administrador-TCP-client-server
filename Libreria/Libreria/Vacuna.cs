using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Vacuna
    {
        private int idVacuna;
        private string descripcion;

        public Vacuna(int idVacuna, string descripcion)
        {
            this.idVacuna = idVacuna;
            this.descripcion = descripcion;
        }

        public int Vacunas
        {
            get { return this.idVacuna; }
            set { this.idVacuna = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
    }
}

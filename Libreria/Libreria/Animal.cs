using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Animal
    {
        private int id;
        private string nombre;
        private Finca finca;
        private Raza raza;
        private int sexo;
        private string madre;
        private string padre;
        private DateTime fechaNacimiento;

        public Animal(int id, string nombre, Finca finca, Raza raza, int sexo, string madre, string padre, DateTime fechaNacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.finca = finca;
            this.raza = raza;
            this.sexo = sexo;
            this.madre = madre;
            this.padre = padre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Finca Finca
        {
            get { return this.finca; }
            set { this.finca = value; }
        }

        public Raza Raza
        {
            get { return this.raza; }
            set { this.raza = value; }
        }

        public int Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }

        public string Madre
        {
            get { return this.madre; }
            set { this.madre = value; }
        }

        public string Padre
        {
            get { return this.padre; }
            set { this.padre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        public override string ToString()
        {
            return ("Id: " + this.id + "\nNombre: " + this.nombre + "\nRaza:" + this.raza.Codigo + "\nSexo: " + this.sexo +
                "\nPadre: " + this.padre + "\nMadre: " + this.madre);
        }
    }
}

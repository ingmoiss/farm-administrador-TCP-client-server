using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Empleado : Persona
    {
        private double salario;
        private string usuario;
        private string contrasena;
        private int estado;

        public Empleado(int id, string nombre, string primerApe, string segundoApe, double salario, string usuario, string contrasena, int estado)
            : base(id, nombre, primerApe, segundoApe)
        {
            this.salario = salario;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.estado = estado;
        }

        public double Salario
        {
            get { return this.salario; }
            set { this.salario = value; }
        }

        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public string Contresena
        {
            set { this.contrasena = value; }
        }

        public int Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalario  : " + this.salario;
        }
    }
}

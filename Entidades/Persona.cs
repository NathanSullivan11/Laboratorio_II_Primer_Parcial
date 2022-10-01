using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;

        public string Nombre { get => nombre;  }
        public string Apellido { get => apellido;  }
        public int Edad { get => edad; }
        public int Dni { get => dni; }

        protected Persona(string nombre, string apellido, int dni) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        protected Persona(string nombre, string apellido, int dni, int edad) : this(nombre, apellido, dni)
        { 
            this.edad = edad;
        }

        public override int GetHashCode()
        {
            return this.dni;
        }
    }
}

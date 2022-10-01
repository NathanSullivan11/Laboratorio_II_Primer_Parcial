using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaporte
    {
        private string numero;
        private string nacionalidad;
        private string sexo;
        private DateTime fechaDeCaducidad;

        public Pasaporte(string numero, string nacionalidad, string sexo, DateTime fechaDeCaducidad)
        {
            this.numero = numero;
            this.nacionalidad = nacionalidad;
            this.sexo = sexo;
            this.fechaDeCaducidad = fechaDeCaducidad;
        }

        public string Numero { get => numero; }
        public string Nacionalidad { get => nacionalidad; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string FechaDeCaducidad { get => fechaDeCaducidad.ToShortDateString(); }
    }
}

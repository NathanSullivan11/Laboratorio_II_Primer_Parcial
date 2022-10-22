using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero 
    {
        private Cliente cliente;
        private bool esPremium;
        private Pasaporte pasaporte;
        private Equipaje equipaje;

        public Pasajero(Cliente cliente, Pasaporte pasaporte, bool esPremium, Equipaje equipaje)
        {
            this.cliente = cliente;
            this.esPremium = esPremium;
            this.equipaje = equipaje;
            this.pasaporte = pasaporte;
        }
     
        public string Nombre { get => this.cliente.Nombre; }
        public string Apellido { get => this.cliente.Apellido; }
        public bool EsPremium { get => esPremium; set => esPremium = value; }
        public bool EquipajeDeMano { get => this.equipaje.EquipajeDeMano; }
        public int PesoEquipaje { get => this.equipaje.PesoEnKg; }

        public string NumeroPasaporte { get => this.pasaporte.Numero; }
        public string Nacionalidad { get => this.pasaporte.Nacionalidad; }
        public string Sexo { get => this.pasaporte.Sexo; }
        public string CaducidadPasaporte { get => this.pasaporte.FechaDeCaducidad.ToString(); }

        public int Edad { get => this.cliente.Edad; }

        public Equipaje ObtenerEquipaje()
        {
            return this.equipaje;
        }

        public Cliente ObtenerCliente()
        {
            return this.cliente;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");

            sb.Append($"{this.Nombre} {this.Apellido} -");

            if(this.esPremium)
            {
                sb.Append(" Premium");
            }
            else
            {
                sb.Append(" Turista");
            }

            return sb.ToString();
        }

    }
}

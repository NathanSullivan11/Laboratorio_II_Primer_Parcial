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
        public int CantidadMaletas { get => this.equipaje.CantidadMaletas; }

        public string PasaporteNumero { get => this.pasaporte.Numero; }
        public string PasaporteNacionalidad { get => this.pasaporte.Nacionalidad; }
        public string PasaporteSexo { get => this.pasaporte.Sexo; }
        public string PasaporteCaducidad { get => this.pasaporte.FechaDeCaducidad.ToString(); }

        public Equipaje ObtenerEquipaje()
        {
            return this.equipaje;
        }

    }
}

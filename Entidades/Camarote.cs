using System.Collections.Generic;

namespace Entidades
{
    public class Camarote
    {
        private List<Pasajero> pasajeros;

        public Camarote()
        {
            this.pasajeros = new List<Pasajero>();
        }

        public Camarote(List<Pasajero> pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public Camarote(Pasajero pasajero):this()
        {
            this.pasajeros.Add(pasajero);
        }

        public int CantidadPasajeros { get => this.pasajeros.Count; }
        //public bool EstaLibre { get => this.pasajeros.Count == 0; }
    }
}
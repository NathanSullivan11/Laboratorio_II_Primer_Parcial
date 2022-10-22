﻿using System.Collections.Generic;

namespace Entidades
{
    public class Camarote
    {
        private List<Pasajero> pasajeros;

        public Camarote()
        {
            this.pasajeros = new List<Pasajero>();
        }

        public Camarote(List<Pasajero> pasajeros)  // Unicamente para el hardcodeo
        {
            this.pasajeros = pasajeros;
        }

        public Camarote(Pasajero pasajero):this()
        {
            this.pasajeros.Add(pasajero);
        }

        public int CantidadPasajeros { get => this.pasajeros.Count; }

        public override string ToString()
        {
            return $"Cantidad de camarotes ocupados: {this.CantidadPasajeros}";
        }
    }
}
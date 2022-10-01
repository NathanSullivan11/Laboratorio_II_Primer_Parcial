using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {
        private bool equipajeDeMano;
        private int pesoEnKg;
        private int cantidadMaletas;

        public Equipaje(bool equipajeDeMano, int pesoEnKg, int cantidadMaletas)
        {
            this.equipajeDeMano = equipajeDeMano;
            this.pesoEnKg = pesoEnKg;
            this.cantidadMaletas = cantidadMaletas;
        }

        public bool EquipajeDeMano { get => equipajeDeMano; set => equipajeDeMano = value; }
        public int PesoEnKg { get => pesoEnKg; set => pesoEnKg = value; }
        public int CantidadMaletas { get => cantidadMaletas; set => cantidadMaletas = value; }

        public static implicit operator int(Equipaje equipaje)
        {
            return equipaje.PesoEnKg;
        }
        public override string ToString()
        {
            
            return $"Equipaje de mano: {this.equipajeDeMano}\nCantidad maleta: {this.cantidadMaletas}\nPeso (kg): {this.pesoEnKg}";
        }
    }
}

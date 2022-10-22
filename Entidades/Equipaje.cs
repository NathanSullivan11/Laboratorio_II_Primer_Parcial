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

        public Equipaje(bool equipajeDeMano, int pesoEnKg)
        {
            this.equipajeDeMano = equipajeDeMano;
            this.pesoEnKg = pesoEnKg;
        }

        public bool EquipajeDeMano { get => equipajeDeMano; set => equipajeDeMano = value; }
        public int PesoEnKg { get => pesoEnKg; set => pesoEnKg = value; }

        public static implicit operator int(Equipaje equipaje)
        {
            return equipaje.PesoEnKg;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Peso: {this.pesoEnKg}kg");
            sb.Append(" - Equipaje de mano:");
            if (this.equipajeDeMano)
            {
                sb.Append(" SI");
            }
            else
            {
                sb.Append(" NO");
            }
                      
            return sb.ToString();
        }
    }
}

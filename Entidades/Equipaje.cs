using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {
        #region Atributos
        private bool equipajeDeMano;
        private int pesoEnKg;
        #endregion

        #region Constructor
        public Equipaje(bool equipajeDeMano, int pesoEnKg)
        {
            this.equipajeDeMano = equipajeDeMano;
            this.pesoEnKg = pesoEnKg;
        }
        #endregion

        #region Propiedades
        public bool EquipajeDeMano { get => equipajeDeMano; set => equipajeDeMano = value; }
        public int PesoEnKg { get => pesoEnKg; set => pesoEnKg = value; }
        /// <summary>
        /// Convierte implicitamente un objeto Equipaje a su equivalente en peso (int)
        /// </summary>
        /// <param name="equipaje"></param>
        public static implicit operator int(Equipaje equipaje)
        {
            return equipaje.PesoEnKg;
        }
        #endregion

        #region Métodos
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
        #endregion
    }
}

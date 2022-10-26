using System.Collections.Generic;

namespace Entidades
{
    public class Camarote
    {
        #region Atributos
        private List<Pasajero> pasajeros;
        #endregion

        #region Constructores
        public Camarote()
        {
            this.pasajeros = new List<Pasajero>();
        }     
        /// <summary>
        /// Constructor para asignar un grupo familiar a un camarote
        /// </summary>
        /// <param name="grupoFamiliar"></param>
        public Camarote(List<Pasajero> grupoFamiliar)
        {
            this.pasajeros = grupoFamiliar;
        }
        /// <summary>
        /// Constructur para asignar un pasajero a un camarote
        /// </summary>
        /// <param name="pasajero"></param>
        public Camarote(Pasajero pasajero) : this()
        {
            this.pasajeros.Add(pasajero);
        }
        #endregion

        #region Propiedades
        public int CantidadPasajeros { get => this.pasajeros.Count; }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"Cantidad de camarotes ocupados: {this.CantidadPasajeros}";
        }
        #endregion
    }
}
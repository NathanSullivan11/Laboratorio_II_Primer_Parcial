namespace Entidades
{
    public class Cliente : Persona
    {
        #region Atributos
        private int id;
        private int cantidadViajes;
        #endregion

        #region Constructor
        public Cliente(string nombre, string apellido, int dni, int edad, int id) : base(nombre, apellido, dni, edad)
        {
            this.id = id;
            this.cantidadViajes = 0;
        }
        #endregion

        #region Propiedades
        public int Id { get => this.id; }
        public int CantidadViajes { get => this.cantidadViajes; }
        #endregion

        #region Métodos
        /// <summary>
        /// Le suma un viaje al cliente
        /// </summary>
        /// <param name="cliente"></param>
        public static void SumarleUnViajeACliente(Cliente cliente)
        {
            cliente.cantidadViajes++;
        }

        public override bool Equals(object obj)
        {
            if (obj is Cliente auxCliente)
            {
                return this.id == auxCliente.id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nApellido: {this.Apellido}\nEdad;{this.Edad}\nId: {this.id}";
        }
        #endregion
    }
}

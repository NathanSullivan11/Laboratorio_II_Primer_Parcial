namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        #endregion

        #region Constructores
        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        protected Persona(string nombre, string apellido, int dni, int edad) : this(nombre, apellido, dni)
        {
            this.edad = edad;
        }
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int Edad { get => edad; }
        public int Dni { get => dni; }
        #endregion

        #region Métodos
        public override int GetHashCode()
        {
            return this.dni;
        }
        #endregion
    }
}

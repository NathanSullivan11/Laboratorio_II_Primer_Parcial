namespace Entidades
{
    public class Usuario : Persona
    {
        #region Atributos
        private string nombreUsuario;
        private string password;
        private string mail;
        #endregion

        #region Constructor
        public Usuario(string nombreUsuario, string password, string mail, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.mail = mail;
        }
        #endregion

        #region Propiedades
        public string NombreUsuario { get => this.nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => this.password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
        #endregion
       
        public bool CheckearPassword(string password)
        {
            return this.Password == password;
        }    

        #region Métodos override
        /// <summary>
        /// GetHashCode()
        /// </summary>
        /// <returns> Devuelve el dni, que esta en la clase padre (Persona) </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Nombre completo:{this.Nombre} {this.Apellido}\n Nombre de Usuario: {this.nombreUsuario} \n Mail: {this.mail}";
        }
        #endregion
    }
}
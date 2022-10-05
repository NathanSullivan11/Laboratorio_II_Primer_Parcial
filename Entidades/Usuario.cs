namespace Entidades
{
    public class Usuario : Persona
    {
        private string nombreUsuario;
        private string password;
        private string mail;

        public Usuario(string nombreUsuario, string password, string mail, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.mail = mail;
        }

        public string NombreUsuario { get => this.nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => this.password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }

        public bool CheckearPassword(string password)
        {
            return this.Password == password;
        }
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

    }
}
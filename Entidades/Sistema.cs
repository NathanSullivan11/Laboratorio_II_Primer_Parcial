using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public static class Sistema
    {
        static List<Usuario> usuariosRegistrados;
        static Sistema()
        {
            usuariosRegistrados = new List<Usuario>();
            CargarVendedores();
        }
        public static List<Usuario> UsuariosRegistrados
        {
            get => usuariosRegistrados;
        }

        private static void CargarVendedores()
        {
            usuariosRegistrados.Add(new Usuario("usermartin", "1234", "martin@gmail.com", "Martin", "Perez", 111435478));
            usuariosRegistrados.Add(new Usuario("usercarla", "1234", "carla@gmail.com", "Carla", "Diaz", 32278934));
            usuariosRegistrados.Add(new Usuario("userdiego", "1234", "diego@gmail.com", "Diego", "Alvarez", 34546891));
            usuariosRegistrados.Add(new Usuario("usernathan", "1234", "nathan@gmail.com", "Nathan", "Sullivan", 44554659));
        }

        public static bool ViajeExisteEnBaseDeDatos(Viaje viaje)
        {
            bool existe = false;
            foreach(Viaje auxViaje in BaseDeDatos.ListaViajesActivos)
            {
                if(auxViaje == viaje)
                {
                    existe = true;
                }
            }
            return existe;
        }

        private static bool ClienteExisteEnBaseDeDatos(Cliente cliente)
        {
            bool existe = false;
            foreach (Cliente auxCliente in BaseDeDatos.ListaClientes)
            {
                if (auxCliente.Equals(cliente))
                {
                    existe = true;
                }
            }
            return existe;
        }

        public static List<Crucero> ObtenerCrucerosDisponibles()
        {
            List<Crucero> listaAux = new List<Crucero>();
            foreach(Crucero auxCrucero in BaseDeDatos.ListaCruceros)
            {
                if(!auxCrucero.EstaEnUso)
                {
                    listaAux.Add(auxCrucero);
                }
            }
            return listaAux;
        }

        #region Metodos Login
        public static Usuario LoguearUsuario(string user, string password)
        {
            Usuario usuarioLogueado = null;

            if(ValidarCamposLogin(user, password))
            {
                foreach(Usuario auxUsuario in Sistema.UsuariosRegistrados)
                {
                    if(auxUsuario.NombreUsuario == user && auxUsuario.CheckearPassword(password))
                    {
                        usuarioLogueado = auxUsuario;
                    }
                }
            }

            return usuarioLogueado;
        }

        private static bool ValidarCamposLogin(string usuario, string password)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }

        public static Cliente AgregarCliente(Cliente cliente)
        {
            Cliente clienteAgregado = null;
            if(!Sistema.ClienteExisteEnBaseDeDatos(cliente))
            {
                BaseDeDatos.ListaClientes.Add(cliente);
                clienteAgregado = cliente;
            }

            return clienteAgregado;

        }

        public static Usuario ObtenerUsuario()
        {
            Random indiceRandom = new Random();
            int indice = indiceRandom.Next(0, Sistema.UsuariosRegistrados.Count);

            Usuario usuarioRandom = Sistema.UsuariosRegistrados.ElementAt(indice);

            return usuarioRandom;

        }

        public static bool ModificarUsuario(Usuario user, string nombreUsuario, string pass, string mail)
        {
            bool seModifico = false;

            if(!Validador.EsValidaPasswordNumerica(user.Password))
            {
                return false;
            }
            else
            {
                user.NombreUsuario = nombreUsuario;
                user.Password = pass;
                user.Mail = mail;
                seModifico = true;
            }
            return seModifico;
            
        }

        #endregion


    }
}


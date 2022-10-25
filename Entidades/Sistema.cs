﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public static class Sistema
    {
        static Sistema()
        {

        }

        public static Dictionary<string, float> OrdenarDiccionarioDestinosFacturacion(int orden)
        {
            List<KeyValuePair<string,float>> listaDiccionarioDestinosFacturacion = Sistema.ObtenerDiccionarioDestinosFacturacion().ToList();

            if(orden == 0)
            {
                listaDiccionarioDestinosFacturacion.Sort(CompararFacturacionDestinosAscendente);
            }
            else
            {
                listaDiccionarioDestinosFacturacion.Sort(CompararFacturacionDestinosDescendente);
            }
            
            Dictionary<string, float> diccionarioOrdenado = new Dictionary<string, float>();

            foreach(KeyValuePair<string, float> keyValue in listaDiccionarioDestinosFacturacion)
            {
                diccionarioOrdenado.Add(keyValue.Key, keyValue.Value);
            }
            return diccionarioOrdenado;
        }

        public static int CompararFacturacionDestinosAscendente(KeyValuePair<string, float> keyValue1, KeyValuePair<string, float> keyValue2)
        {
            int comparacion = 0;

            if(keyValue1.Value > keyValue2.Value)
            {
                comparacion = 1;
            }
            else if (keyValue1.Value < keyValue2.Value)
            {
                comparacion = -1;
            }
            return comparacion;
        }

        public static int CompararFacturacionDestinosDescendente(KeyValuePair<string, float> keyValue1, KeyValuePair<string, float> keyValue2)
        {
            int comparacion = 0;

            if (keyValue1.Value > keyValue2.Value)
            {
                comparacion = -1;
            }
            else if (keyValue1.Value < keyValue2.Value)
            {
                comparacion = 1;
            }
            return comparacion;
        }

        public static Dictionary<string, int> OrdenarDiccionarioDestinosCantidadViajes(int orden)
        {
            List<KeyValuePair<string, int>> listaDiccionarioDestinosCantidadViajes = Sistema.ObtenerDiccionarioDestinosCantidadViajes().ToList();

            if (orden == 0)
            {
                listaDiccionarioDestinosCantidadViajes.Sort(CompararCantidadViajesDestinosAscendente);
            }
            else
            {
                listaDiccionarioDestinosCantidadViajes.Sort(CompararCantidadViajesDestinosDescendente);
            }

            Dictionary<string, int> diccionarioOrdenado = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> keyValue in listaDiccionarioDestinosCantidadViajes)
            {
                diccionarioOrdenado.Add(keyValue.Key, keyValue.Value);
            }
            return diccionarioOrdenado;
        }

        public static int CompararCantidadViajesDestinosAscendente(KeyValuePair<string, int> keyValue1, KeyValuePair<string, int> keyValue2)
        {
            int comparacion = 0;

            if (keyValue1.Value > keyValue2.Value)
            {
                comparacion = 1;
            }
            else if (keyValue1.Value < keyValue2.Value)
            {
                comparacion = -1;
            }
            return comparacion;
        }

        public static int CompararCantidadViajesDestinosDescendente(KeyValuePair<string, int> keyValue1, KeyValuePair<string, int> keyValue2)
        {
            int comparacion = 0;

            if (keyValue1.Value > keyValue2.Value)
            {
                comparacion = -1;
            }
            else if (keyValue1.Value < keyValue2.Value)
            {
                comparacion = 1;
            }
            return comparacion;
        }

        public static Dictionary<string, float> ObtenerDiccionarioDestinosFacturacion()
        {
            //BaseDeDatos.CalculaFacturacionPorDestino();
            return BaseDeDatos.DiccionarioDestinosFacturacion;
        }

        public static Dictionary<string, int> ObtenerDiccionarioDestinosCantidadViajes()
        {
            //BaseDeDatos.CalcularCantidadViajesPorDestino();
            return BaseDeDatos.DiccionarioDestinosCantidadViajes;
        }
        public static List<Viaje> ObtenerListaCompletaDeViajes()
        {
            BaseDeDatos.ListaTodosLosViajes = new List<Viaje>(BaseDeDatos.ListaViajesFinalizados.Concat(BaseDeDatos.ListaViajesActivos));
            return BaseDeDatos.ListaTodosLosViajes;
        
        }

        public static List<Viaje> ObtenerListaCompletaViajesRegionales()
        {
            List<Viaje> listaViajesRegionales = new List<Viaje>();

            foreach(Viaje auxViaje in Sistema.ObtenerListaCompletaDeViajes())
            {
                if(Sistema.EsViajeRegional(auxViaje))
                {
                    listaViajesRegionales.Add(auxViaje);
                }
            }

            return listaViajesRegionales;
        }

        public static List<Viaje> ObtenerListaCompletaViajesExtraRegionales()
        {
            List<Viaje> listaViajesExtraRegionales = new List<Viaje>();

            foreach (Viaje auxViaje in Sistema.ObtenerListaCompletaDeViajes())
            {
                if (Sistema.EsViajeExtraRegional(auxViaje))
                {
                    listaViajesExtraRegionales.Add(auxViaje);
                }
            }

            return listaViajesExtraRegionales;
        }

        public static bool ViajeExisteEnBaseDeDatos(Viaje viaje)
        {
            bool existe = false;
            foreach (Viaje auxViaje in BaseDeDatos.ListaViajesActivos)
            {
                if (auxViaje.Equals(viaje))
                {
                    existe = true;
                }
            }
            return existe;
        }

       
        public static bool DarDeBajaUnViaje(Viaje viajeADarDeBaja)
        {
            foreach(Viaje auxViaje in BaseDeDatos.ListaViajesActivos)
            {
                if(auxViaje.Equals(viajeADarDeBaja))
                {
                    auxViaje.ObtenerCrucero().EstaEnUso = false;
                    BaseDeDatos.ListaViajesActivos.Remove(auxViaje);
                    return true;
                }
            }
            return false;
        }

        public static bool EsGrupoFamiliarPremium(List<Pasajero> grupoFamiliar)
        {
            return grupoFamiliar[0].EsPremium;
        }

        public static void AgregarClientesNuevosABaseDeDatos(List<Pasajero> listaPasajeros)
        {
            foreach (Pasajero auxPasajero in listaPasajeros)
            {
                Sistema.AgregarCliente(auxPasajero.ObtenerCliente());
            }
        }

        /// <summary>
        /// Verifica que un crucero este disponible en determinada fecha
        /// </summary>
        /// <param name="crucero"></param>
        /// <param name="fechaDelViajeAAgregar"></param>
        /// <returns></returns>
        public static bool CruceroDisponibleEnEsasFechas(Crucero cruceroDelViajeAgregar, DateTime fechaDelViajeAgregar) 
        {          
            bool estaDisponible = false;

            foreach (Viaje auxViaje in BaseDeDatos.ListaViajesActivos)
            {
                if(auxViaje.ObtenerCrucero().Equals(cruceroDelViajeAgregar))
                {     
                    DateTime fechaSalida = auxViaje.ObtenerFechaSalida();
                    DateTime fechaInicio; 
                    DateTime fechaFinal;

                    fechaFinal = fechaSalida.AddDays(int.Parse(auxViaje.Duracion) / 24);
                    fechaInicio = fechaSalida.AddDays(-int.Parse(auxViaje.Duracion) / 24);  

                    if (!(fechaDelViajeAgregar > fechaInicio && fechaDelViajeAgregar < fechaFinal))
                    {
                        estaDisponible = true;
                        break;
                    }
                }
            }

            return estaDisponible;

        }

        private static bool CruceroEstaEnUso(Viaje auxViaje)
        {
            return auxViaje.ObtenerCrucero().CruceroEstaEnUso();
        }


        public static List<Cliente> FiltrarClientesPorDni(string numero)
        {
            List<Cliente> auxLista = new List<Cliente>();

            foreach (Cliente auxCliente in BaseDeDatos.ListaClientes)
            {
                if (auxCliente.Dni.ToString().StartsWith(numero))
                {
                    auxLista.Add(auxCliente);

                }
            }
            return auxLista;
        }

        #region Filtrado pasajeros

        public static List<Pasajero> FiltrarPasajerosPorNombre(Viaje esteViaje, string nombre, bool soloPremium)
        {
            List<Pasajero> auxLista = new List<Pasajero>();

            for (int i = 0; i < esteViaje.ObtenerListaPasajeros().Count; i++)
            {
                if (esteViaje[i].Nombre.Trim().ToLower().StartsWith(nombre.Trim().ToLower()))
                {
                    if (!soloPremium)
                    {
                        auxLista.Add(esteViaje[i]);
                    }
                    else if (soloPremium && esteViaje[i].EsPremium)
                    {
                        auxLista.Add(esteViaje[i]);
                    }
                }
            }

            return auxLista;
        }

        public static List<Pasajero> FiltrarPasajerosPorApellido(Viaje esteViaje, string apellido, bool soloPremium)
        {
            List<Pasajero> auxLista = new List<Pasajero>();

            for (int i = 0; i < esteViaje.ObtenerListaPasajeros().Count; i++)
            {
                if (esteViaje[i].Apellido.Trim().ToLower().StartsWith(apellido.Trim().ToLower()))
                {
                    if (!soloPremium)
                    {
                        auxLista.Add(esteViaje[i]);
                    }
                    else if (soloPremium && esteViaje[i].EsPremium)
                    {
                        auxLista.Add(esteViaje[i]);
                    }
                }
            }

            return auxLista;
        }
 
        public static List<Pasajero> FiltrarPasajerosPorPasaporte(Viaje esteViaje, string nroPasaporte, bool soloPremium)
        {
            List<Pasajero> auxLista = new List<Pasajero>();

            for (int i = 0; i < esteViaje.ObtenerListaPasajeros().Count; i++)
            {
                if (esteViaje[i].NumeroPasaporte.Trim().ToUpper().StartsWith(nroPasaporte.Trim().ToUpper()))
                {
                    if (!soloPremium)
                    {
                        auxLista.Add(esteViaje[i]);
                    }
                    else if (soloPremium && esteViaje[i].EsPremium)
                    {
                        auxLista.Add(esteViaje[i]);
                    }
                }
            }

            return auxLista;
        }

        public static List<Pasajero> FiltrarPasajerosPorEdad(Viaje esteViaje, string edad, bool soloPremium)
        {
            List<Pasajero> auxLista = new List<Pasajero>();

            for (int i = 0; i < esteViaje.ObtenerListaPasajeros().Count; i++)
            {
                if (esteViaje[i].ObtenerCliente().Edad.ToString().StartsWith(edad))
                {
                    if (!soloPremium)
                    {
                        auxLista.Add(esteViaje[i]);
                    }
                    else if (soloPremium && esteViaje[i].EsPremium)
                    {
                        auxLista.Add(esteViaje[i]);
                    }
                }
            }

            return auxLista;
        }
        public static List<Pasajero> FiltrarPasajerosPremium(Viaje esteViaje)
        {
            List<Pasajero> auxLista = new List<Pasajero>();

            for (int i = 0; i < esteViaje.ObtenerListaPasajeros().Count; i++)
            {
                if (esteViaje[i].EsPremium)
                {
                    auxLista.Add(esteViaje[i]);
                }
            }

            return auxLista;
        }
        #endregion

        #region Metodos para ordenar clientes

        public static void OrdenarClientes(List<Cliente> cliente, string criterio)
        {
           if(!string.IsNullOrEmpty(criterio))
           {
                switch (criterio)
                {
                    case "Id":
                        cliente.Sort(CompararIdCliente);
                        break;
                    case "Cantidad de viajes":
                        cliente.Sort(CompararCantidadViajesCliente);
                        break;
                    case "Dni":
                        cliente.Sort(CompararDniCliente);
                        break;
                }
           }                  
        }

        public static int CompararIdCliente(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.Id - cliente2.Id;
        }

        public static int CompararCantidadViajesCliente(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.CantidadViajes - cliente2.CantidadViajes;
        }

        public static int CompararDniCliente(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.Dni - cliente2.Dni;
        }

        #endregion

        public static Cliente ClienteExisteEnBaseDeDatos(int dni)
        {
            Cliente clienteExistente = null;
            foreach (Cliente auxCliente in BaseDeDatos.ListaClientes)
            {
                if (dni == auxCliente.Dni)
                {
                    clienteExistente = auxCliente;
                    break;
                }
            }
            return clienteExistente;
        }

        public static List<Crucero> ObtenerCrucerosDisponibles()
        {
            List<Crucero> listaAux = new List<Crucero>();
            foreach(Crucero auxCrucero in BaseDeDatos.ListaCruceros)
            {
                if(!auxCrucero.CruceroEstaEnUso())
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
                foreach(Usuario auxUsuario in BaseDeDatos.UsuariosRegistrados)
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

        public static bool AgregarCliente(Cliente cliente)
        {
            bool seAgrego = false;
            if(Sistema.ClienteExisteEnBaseDeDatos(cliente.Dni) == null)
            {
                seAgrego = true;
                BaseDeDatos.ListaClientes.Add(cliente);  
            }

            return seAgrego;

        }

        public static Usuario ObtenerUsuario()
        {
            Random indiceRandom = new Random();
            int indice = indiceRandom.Next(0, BaseDeDatos.UsuariosRegistrados.Count);

            Usuario usuarioRandom = BaseDeDatos.UsuariosRegistrados.ElementAt(indice);

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

        public static bool PasaporteEstaRepetido(Pasaporte pasaporte, Viaje esteViaje)
        {
            bool estaRepetido = false;

            for(int i = 0; i < esteViaje.ObtenerListaPasajeros().Count; i++)
            {
                if (esteViaje[i].NumeroPasaporte == pasaporte.Numero)
                {
                    estaRepetido = true;
                    break; 
                }
            }

            return estaRepetido;
        }

        public static bool ViajeEstaDisponible(Viaje viaje)
        {
            return viaje.Estado == EEstadoViaje.Disponible.ToString();
        }

        public static bool EsViajeRegional(Viaje viaje)
        {
            bool esViajeRegional = false;

            List<string> listaDestinosRegionales = new List<string>();

            foreach (var item in Enum.GetValues(typeof(EDestinoRegional)))
            {
                listaDestinosRegionales.Add(item.ToString());
            }

            if (listaDestinosRegionales.Contains(viaje.Destino))
            {
                esViajeRegional = true;

            }
            return esViajeRegional;
        }

        public static bool EsViajeExtraRegional(Viaje viaje)
        {
            bool esViajeExtraRegional = false;
            List<string> listaDestinosExtraRegionales = new List<string>();

            foreach (var item in Enum.GetValues(typeof(EDestinoExtraRegional)))
            {
                listaDestinosExtraRegionales.Add(item.ToString());
            }

            if (listaDestinosExtraRegionales.Contains(viaje.Destino))
            {
                esViajeExtraRegional = true;

            }
            return esViajeExtraRegional;
        }

        #region Metodos recaudaciones

        public static float CalcularRecaudacionTotalViajes()
        {
            float acumulador = 0;
            foreach(Viaje auxViaje in BaseDeDatos.ListaTodosLosViajes)
            {
                acumulador += auxViaje.GananciasRecaudadas;
            }
            return acumulador;
        }

        public static object CalcularRecaudacionTotalViajesRegionales()
        {
            float acumulador = 0;
            foreach (Viaje auxViaje in Sistema.ObtenerListaCompletaViajesRegionales())
            {
                acumulador += auxViaje.GananciasRecaudadas;             
            }
            return acumulador;

        }

        public static object CalcularRecaudacionTotalViajesExtraRegionales()
        {
            float acumulador = 0;
            foreach (Viaje auxViaje in Sistema.ObtenerListaCompletaViajesExtraRegionales())
            {
                acumulador += auxViaje.GananciasRecaudadas;
            }
            return acumulador;
        }

        #endregion
    }
}


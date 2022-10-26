﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{   
    public class Viaje
    {
        #region Atributos
        private List<Pasajero> listaPasajeros;
        private List<Camarote> camarotesTurista;
        private List<Camarote> camarotesPremium;
        private string codigoDeViaje;
        private Crucero crucero;
        private EOrigen origen;
        private DateTime fechaSalida;
        private EEstadoViaje estado;
        private bool esRegional;
        private int duracionEnHoras;
        private string destino;
        private float costoBase;
        private float costoPremium;
        private float gananciasRecaudadas;
        private int kgActualesEnBodega;
        #endregion

        #region Propiedades
        public string Crucero { get => this.crucero.Matricula; }
        public string CodigoDeViaje { get => this.codigoDeViaje;  }
        public string Estado { get => estado.ToString(); }
        public string Origen { get => this.origen.ToString(); }       
        public string Destino { get => this.destino; }
        public string FechaSalida { get => this.fechaSalida.ToString(); }
        public string Duracion { get => this.duracionEnHoras.ToString(); }       
        public string KgBodega { get => $"{this.kgActualesEnBodega}/{this.crucero.CapacidadMaximaBodega} kg"; }
        public string CamarotesEnUso { get => $"{this.ObtenerListaCamarotesPremium().Count + this.ObtenerListaCamarotesTurista().Count}/{this.crucero.CantidadCamarotesPremium + this.crucero.CantidadCamarotesTurista}"; }
        public float CostoBase { get => this.costoBase;  }
        public float CostoPremium { get => this.costoPremium;  }
        public float GananciasRecaudadas { get => this.gananciasRecaudadas; }
        public bool TieneComedor { get => this.crucero.TieneComedor; }
        public bool TieneGimnasio { get => this.crucero.TieneGimnasio; }
        public bool TienePileta { get => this.crucero.TienePileta; }
        public bool TieneBar { get => this.crucero.TieneBar; }
        #endregion

        #region Constructores
        private Viaje(Crucero crucero, EOrigen origen, DateTime fechaSalida, bool esRegional, EEstadoViaje estado)
        {
            this.crucero = crucero;
            
            if (estado != EEstadoViaje.Finalizado)
            {
                this.crucero.EstaEnUso = true;
            }
            else
            {
                this.crucero.EstaEnUso = false;
            }
            
            this.fechaSalida = fechaSalida;
            this.listaPasajeros = new List<Pasajero>();
            this.origen = origen;
            this.estado = estado;
            this.camarotesPremium = new List<Camarote>();
            this.camarotesTurista = new List<Camarote>();
            this.kgActualesEnBodega = 0;
            this.esRegional = esRegional;
            this.duracionEnHoras = this.CalcularDuracion();
            this.costoBase = this.CalcularCostoBase();
            this.costoPremium = this.costoBase * 1.20f;
            this.gananciasRecaudadas = 0;
            this.codigoDeViaje = Sistema.GenerarCodigoDeViajeAleatorio();
            Sistema.AgregarABaseDeDatos(this);
        }
        
        public Viaje(Crucero crucero, EOrigen origen, DateTime fechaSalida, bool esRegional, EEstadoViaje estado, EDestinoRegional destinoRegional) : this(crucero, origen, fechaSalida, esRegional, estado)
        {
            this.destino = destinoRegional.ToString();
        }

        public Viaje(Crucero crucero, EOrigen origen, DateTime fechaSalida, bool esRegional, EEstadoViaje estado, EDestinoExtraRegional destinoExtraRegional) :this(crucero, origen, fechaSalida, esRegional, estado)
        {
            this.destino = destinoExtraRegional.ToString();
        }

        #endregion

        #region Indexador
        /// <summary>
        /// Indexá por la lista de pasajeros del viaje
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Pasajero this[int index]
        {
            get 
            { 
                if(index < this.listaPasajeros.Count)
                {
                    return this.listaPasajeros[index];
                }
                return null;
            }
        }
        #endregion

        #region Métodos getters
        public List<Pasajero> ObtenerListaPasajeros()
        {
            return this.listaPasajeros;
        }

        public Crucero ObtenerCrucero()
        {
            return this.crucero;
        }

        public DateTime ObtenerFechaSalida()
        {
            return this.fechaSalida;
        }

        public int ObtenerCantidadCamarotesLibreTurista()
        {
            return this.crucero.CantidadCamarotesTurista - this.camarotesTurista.Count;
        }

        public int ObtenerCantidadCamarotesLibrePremium()
        {
            return this.crucero.CantidadCamarotesPremium- this.camarotesPremium.Count;
        }

        public List<Camarote> ObtenerListaCamarotesPremium()
        {
            return this.camarotesPremium;
        }

        public List<Camarote> ObtenerListaCamarotesTurista()
        {
            return this.camarotesTurista;
        }

        public string ObtenerDatosBasicosCrucero()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {this.crucero.Matricula}");
            sb.AppendLine($"Bodega: {this.kgActualesEnBodega}");
            sb.AppendLine($"Camarotes turista: {this.camarotesTurista.Count}/{this.crucero.CantidadCamarotesTurista}");
            sb.AppendLine($"Camarotes premium:{this.camarotesPremium.Count}/{this.crucero.CantidadCamarotesPremium}");
            sb.AppendLine($"Cantidad de casinos: {this.crucero.CantidadCasinos}");
            sb.AppendLine($"Salones: {this.crucero.ObtenerListaSalones()}");

            return sb.ToString();
        }
        #endregion

        #region Métodos para asignar pasajeros a camarotes
        /// <summary>
        /// Le asigna un camarote a un pasajero, dependiendo si es premium o turista
        /// </summary>
        /// <param name="pasajero"></param>
        /// <returns></returns>
        private bool AsignarCamaroteAPasajero(Pasajero pasajero)
        {
            bool seAgregoAlCamarote = false;

            if (pasajero.EsPremium)
            {
                if (this.AgregarPasajeroACamarotePremiumDisponible(pasajero))
                {
                    seAgregoAlCamarote = true;
                }
            }
            else
            {
                if (this.AgregarPasajeroACamaroteTuristaDisponible(pasajero))
                {
                    seAgregoAlCamarote = true;
                }
            }
            return seAgregoAlCamarote;
        }
        /// <summary>
        /// Le asigna un camarote a un pasajero, dependiendo si son premiums o turistas
        /// </summary>
        /// <param name="grupoPasajeros"></param>
        /// <param name="sonPremium"></param>
        /// <returns></returns>
        private bool AsignarCamaroteAGrupoFamiliar(List<Pasajero> grupoPasajeros, bool sonPremium)
        {
            bool seAgregaronAlCamarote = false;

            if (sonPremium)
            {
                if (this.AgregarGrupoPasajerosACamarotePremiumDisponible(grupoPasajeros))
                {
                    seAgregaronAlCamarote = true;
                }
            }
            else
            {
                if (this.AgregarGrupoPasajerosACamaroteTuristaDisponible(grupoPasajeros))
                {
                    seAgregaronAlCamarote = true;
                }
            }
            return seAgregaronAlCamarote;
        }

        /// <summary>
        /// Asigna un camarote a un pasajero premium, si esta disponible,
        /// </summary>
        /// <param name="pasajero"></param>
        /// <returns>true o false, si se agrego o no</returns>
        public bool AgregarPasajeroACamarotePremiumDisponible(Pasajero pasajero)
        {
            bool seAgrego = false;
            if (this.ObtenerCantidadCamarotesLibrePremium() > 0)
            {
                this.camarotesPremium.Add(new Camarote(pasajero));
                seAgrego = true;
            }
            return seAgrego;
        }
        /// <summary>
        /// Asigna un camarote a un pasajero turista, si esta disponible,
        /// </summary>
        /// <param name="pasajero"></param>
        /// <returns>true o false, si se agrego o no</returns>
        public bool AgregarPasajeroACamaroteTuristaDisponible(Pasajero pasajero)
        {
            bool seAgrego = false;
            if (this.ObtenerCantidadCamarotesLibreTurista() > 0)
            {
                this.camarotesTurista.Add(new Camarote(pasajero));
                seAgrego = true;
            }
            return seAgrego;
        }
        /// <summary>
        /// Asigna un camarote a un grupo familiar turista, si esta disponible
        /// </summary>
        /// <param name="grupoPasajeros"></param>
        /// <returns> true o false, si se agrego o no</returns>
        public bool AgregarGrupoPasajerosACamarotePremiumDisponible(List<Pasajero> grupoPasajeros)
        {
            bool seAgrego = false;
            if (this.ObtenerCantidadCamarotesLibrePremium() >= grupoPasajeros.Count)
            {
                this.camarotesPremium.Add(new Camarote(grupoPasajeros));
                seAgrego = true;
            }
            return seAgrego;
        }
        /// <summary>
        /// Asigna un camarote a un grupo familiar turista, si esta disponible
        /// </summary>
        /// <param name="grupoPasajeros"></param>
        /// <returns>true o false, si se agrego o no</returns>
        public bool AgregarGrupoPasajerosACamaroteTuristaDisponible(List<Pasajero> grupoPasajeros)
        {
            bool seAgrego = false;
            if (this.ObtenerCantidadCamarotesLibreTurista() >= grupoPasajeros.Count)
            {
                this.camarotesTurista.Add(new Camarote(grupoPasajeros));
                seAgrego = true;
            }
            return seAgrego;
        }
        #endregion

        #region Métodos para agregar pasajeros al viaje
        /// <summary>
        /// Agregá un pasajero al viaje, siempre y cuando haya un camarote del tipo de servicio requerido disponible, y que haya capacidad en bodega para el equipaje
        /// </summary>
        /// <param name="pasajero"></param>
        /// <returns></returns>
        public bool AgregarPasajero(Pasajero pasajero)
        {
            bool seAgrego = false;

            if (this.AsignarCamaroteAPasajero(pasajero) && this.AgregarEquipaje(pasajero.ObtenerEquipaje()))
            {
                seAgrego = true;
                this.listaPasajeros.Add(pasajero);
                Cliente.SumarleUnViajeACliente(pasajero.ObtenerCliente());
                this.AcumularGananciaDeUnaVenta(pasajero);
            }

            return seAgrego;
        }
        /// <summary>
        /// Agregá un grupo familiar al viaje, siempre y cuando haya un camarote del tipo de servicio requerido disponible, y que haya capacidad en bodega para el equipaje
        /// </summary>
        /// <param name="pasajeros"></param>
        /// <param name="sonPremium"></param>
        /// <returns></returns>
        public bool AgregarGrupoFamiliar(List<Pasajero> pasajeros, bool sonPremium)
        {
            bool seAgregaron = false;
            int totalPeso = 0;

            foreach (Pasajero auxP in pasajeros)
            {
                totalPeso += auxP.ObtenerEquipaje();
            }

            if (this.AsignarCamaroteAGrupoFamiliar(pasajeros, sonPremium) && this.AgregarEquipaje(totalPeso))
            {
                seAgregaron = true;
                foreach (Pasajero auxPasajero in pasajeros)
                {
                    this.listaPasajeros.Add(auxPasajero);
                    Cliente.SumarleUnViajeACliente(auxPasajero.ObtenerCliente());
                }
                this.AcumularGananciasDeVentaMultiple(pasajeros);
            }

            return seAgregaron;
        }
        #endregion

        #region Método para agregar equipaje
        /// <summary>
        /// Agregá el equipaje a bodega, siempre y cuando no exceda el límite del crucero
        /// </summary>
        /// <param name="pesoEquipaje"></param>
        /// <returns></returns>
        public bool AgregarEquipaje(int pesoEquipaje)
        {
            if (this.HayCapacidadEnBodega(pesoEquipaje))
            {
                this.kgActualesEnBodega += pesoEquipaje;
                return true;
            }
            return false;
        }
        #endregion

        #region Métodos para calcular ganancias
        /// <summary>
        /// Acumula lo facturado de un grupo familiar, al total de lo recaudado del viaje
        /// </summary>
        /// <param name="listaPasajeros"></param>
        public void AcumularGananciasDeVentaMultiple(List<Pasajero> listaPasajeros)
        {
            foreach (Pasajero AuxPasajero in listaPasajeros)
            {
                this.AcumularGananciaDeUnaVenta(AuxPasajero);
            }
        }
        /// <summary>
        /// Acumula lo facturado de una sola venta individual, al total de lo recaudado del viaje
        /// </summary>
        /// <param name="listaPasajeros"></param>
        public void AcumularGananciaDeUnaVenta(Pasajero pasajero)
        {
            if(pasajero.EsPremium)
            {
                this.gananciasRecaudadas += this.costoPremium * 1.21f;
            }
            else
            {
                this.gananciasRecaudadas += this.costoBase * 1.21f;
            }     
        }
        #endregion

        public void CargarListaPasajerosHardcodeados(List<Pasajero> listaPasajeros)
        {
            //this.listaPasajeros = listaPasajeros;
            foreach(Pasajero auxPasajero in listaPasajeros)
            {
                this.AgregarPasajero(auxPasajero);
            }
        }    

        /// <summary>
        /// Calcula la duración random del viaje, si es regional (entre 72 y 360) o si extra regional (entre 480 y 720)
        /// </summary>
        /// <returns></returns>
        private int CalcularDuracion()
        {
            Random duracionRandom = new Random();
            int duracion;
            if (esRegional)
            {
                duracion = duracionRandom.Next(72, 360);
            }
            else
            {
                duracion = duracionRandom.Next(480, 720);
            }
            return duracion;
        }
        /// <summary>
        /// Calcula el costo base del pasaje dependiendo de la duración y del destino (regional o extraregional)
        /// </summary>
        /// <returns></returns>
        private float CalcularCostoBase()
        {
            float costoBase;
            if (esRegional)
            {
                costoBase = this.duracionEnHoras * 57;
            }
            else
            {
               costoBase = this.duracionEnHoras * 120;
            }
            return costoBase;
        }

        public bool HayCapacidadEnBodega(int pesoEquipaje)
        {
            int valor = this.kgActualesEnBodega;
            return (valor + pesoEquipaje) <= this.crucero.CapacidadMaximaBodega;
        }

        #region Métodos override
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Viaje auxViaje)
            {
                return this.codigoDeViaje == auxViaje.codigoDeViaje;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Crucero: {this.crucero}\nOrigen: {this.origen} Destino;{this.destino}\nesRegional: {this.esRegional}\nDuracion: {this.duracionEnHoras}";
        }
        #endregion


    }
}

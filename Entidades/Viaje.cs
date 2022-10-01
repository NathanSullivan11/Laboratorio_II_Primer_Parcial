using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{   
    public class Viaje
    {
        private List<Pasajero> listaPasajeros;

        private Crucero crucero;
        private EOrigen origen;
        private DateTime fechaSalida;
        private EEstadoViaje estado;
        private bool esRegional;
        private int duracionEnHoras;
        private string destino;
        private float costoBase;
        private float costoPremium;

        #region propiedades
        public string Crucero { get => this.crucero.ToString(); }
        public string Origen { get => this.origen.ToString(); }
        public string FechaSalida { get => this.fechaSalida.ToString(); }
        public string Destino { get => this.destino; }
        public string Duracion { get => $"{this.duracionEnHoras}hs"; }
        public string Estado { get => estado.ToString(); }
        public string KgBodega { get => $"{this.crucero.KgActualesEnBodega}kg/{this.crucero.CapacidadMaximaBodega}kg"; }
        public string CamarotesEnUso { get => $"{this.crucero.ObtenerListaCamarotesPremium().Count + this.crucero.ObtenerListaCamarotesTurista().Count}/{this.crucero.CantidadCamarotesPremium + this.crucero.CantidadCamarotesTurista}"; }
        public float CostoBase { get => this.costoBase;  }
        public float CostoPremium { get => this.costoPremium;  }
        public bool TieneComedor { get => this.crucero.TieneComedor; }
        public bool TieneGimnasio { get => this.crucero.TieneGimnasio; }
        public bool TienePileta { get => this.crucero.TienePileta; }
        public bool TieneBar { get => this.crucero.TieneBar; }
        #endregion

        private Viaje(Crucero crucero, EOrigen origen, DateTime fechaSalida,bool esRegional, EEstadoViaje estado)
        {
            this.crucero = crucero;
            this.crucero.EstaEnUso = true;
            this.fechaSalida = fechaSalida;
            this.listaPasajeros = new List<Pasajero>();
            this.origen = origen;
            this.estado = estado;
            this.esRegional = esRegional;
            this.duracionEnHoras = this.CalcularDuracion();
            this.costoBase = this.CalcularCostoBase();
            this.costoPremium = this.costoBase * 1.20f;
            this.AgregarABaseDeDatos();
        }

        public Viaje(Crucero crucero, EOrigen origen, DateTime fechaSalida, bool esRegional, EEstadoViaje estado, EDestinoRegional destinoRegional) : this(crucero, origen, fechaSalida, esRegional, estado)
        {
            this.destino = destinoRegional.ToString();
        }

        public Viaje(Crucero crucero, EOrigen origen, DateTime fechaSalida, bool esRegional, EEstadoViaje estado, EDestinoExtraRegional destinoExtraRegional) :this(crucero, origen, fechaSalida, esRegional, estado)
        {
            this.destino = destinoExtraRegional.ToString();
        }

        private void AgregarABaseDeDatos()
        {
            if(Sistema.ViajeExisteEnBaseDeDatos(this))
            {
                BaseDeDatos.ListaViajesActivos.Add(this);
            }
        }

        
        public void CargarListaPasajeros(List<Pasajero> listaPasajeros)
        {
            //this.listaPasajeros = listaPasajeros;
            foreach(Pasajero auxPasajero in listaPasajeros)
            {
                this.AgregarPasajero(auxPasajero);
            }
        }

        public List<Pasajero> ObtenerListaPasajeros()
        {
            return this.listaPasajeros;
        }

        public Crucero ObtenerCrucero()
        {
            return this.crucero;
        }

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

        public bool AgregarPasajero(Pasajero pasajero)
        {
            bool seAgrego = false;
           
            if(this.AsignarCamaroteAPasajero(pasajero) && this.crucero.AgregarEquipaje(pasajero.ObtenerEquipaje()))
            {
                seAgrego = true;
                this.listaPasajeros.Add(pasajero);
            }                             
            
            return seAgrego;
        }

        public bool AgregarGrupoFamiliar(List<Pasajero> pasajeros, bool sonPremium)
        {
            bool seAgregaron = false;
            int totalPeso = 0;

            foreach(Pasajero auxP in pasajeros)
            {
                totalPeso += auxP.ObtenerEquipaje();
            }
   
            if (this.crucero.HayCapacidadEnBodega(totalPeso))
            {
                if (this.AsignarCamaroteAGrupoFamiliar(pasajeros, sonPremium))
                {
                    seAgregaron = true;
                }
            }
            return seAgregaron;
        }

        

        private bool AsignarCamaroteAPasajero(Pasajero pasajero)
        {
            bool seAgregoAlCamarote = false;
 
            if (pasajero.EsPremium)
            {                
                if(this.crucero.AgregarPasajeroACamarotePremiumDisponible(pasajero))
                {
                    seAgregoAlCamarote = true;
                }
            }
            else
            {
                if (this.crucero.AgregarPasajeroACamaroteTuristaDisponible(pasajero))
                {
                    seAgregoAlCamarote = true;
                }
            }
            return seAgregoAlCamarote;
        }

        private bool AsignarCamaroteAGrupoFamiliar(List<Pasajero> grupoPasajeros, bool sonPremium)
        {
            bool seAgregaronAlCamarote = false;

            if (sonPremium)
            {
                if (this.crucero.AgregarGrupoPasajerosACamarotePremiumDisponible(grupoPasajeros))
                {
                    this.crucero.ObtenerListaCamarotesTurista().Add(new Camarote(grupoPasajeros));
                    seAgregaronAlCamarote = true;
                }
            }
            else
            {
                if (this.crucero.AgregarGrupoPasajerosACamaroteTuristaDisponible(grupoPasajeros))
                {
                    this.crucero.ObtenerListaCamarotesPremium().Add(new Camarote(grupoPasajeros));
                    seAgregaronAlCamarote = false;
                }
            }
            return seAgregaronAlCamarote;
        }

        public override string ToString()
        {
            return $"Crucero: {this.crucero}\nOrigen: {this.origen} Destino;{this.destino}\nesRegional: {this.esRegional}\nDuracion: {this.duracionEnHoras}";
        }

        public static bool operator ==(Viaje viaje1, Viaje viaje2)
        {
            return viaje1.crucero == viaje2.crucero;
        }

        public static bool operator !=(Viaje viaje1, Viaje viaje2)
        {
            return !(viaje1 == viaje2);
        }
    }
}

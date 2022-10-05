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

        #region propiedades
        public string Crucero { get => this.crucero.Matricula; }
        public string CodigoDeViaje { get => this.codigoDeViaje;  }
        public string Estado { get => estado.ToString(); }
        public string Origen { get => this.origen.ToString(); }       
        public string Destino { get => this.destino; }
        public string FechaSalida { get => this.fechaSalida.ToString(); }
        public string Duracion { get => this.duracionEnHoras.ToString(); }       
        public string KgBodega { get => $"{this.kgActualesEnBodega}kg/{this.crucero.CapacidadMaximaBodega}kg"; }
        public string CamarotesEnUso { get => $"{this.ObtenerListaCamarotesPremium().Count + this.ObtenerListaCamarotesTurista().Count}/{this.crucero.CantidadCamarotesPremium + this.crucero.CantidadCamarotesTurista}"; }
        public float CostoBase { get => this.costoBase;  }
        public float CostoPremium { get => this.costoPremium;  }
        public float GananciasRecaudadas { get => this.gananciasRecaudadas; }
        public bool TieneComedor { get => this.crucero.TieneComedor; }
        public bool TieneGimnasio { get => this.crucero.TieneGimnasio; }
        public bool TienePileta { get => this.crucero.TienePileta; }
        public bool TieneBar { get => this.crucero.TieneBar; }
        #endregion

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
            this.codigoDeViaje = this.GenerarCodigoDeViajeAleatorio();
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


        public bool HayCapacidadEnBodega(int pesoEquipaje)
        {
            int valor = this.kgActualesEnBodega;
            return (valor + pesoEquipaje) <= this.crucero.CapacidadMaximaBodega;
        }

        public bool AgregarEquipaje(int pesoEquipaje)
        {
            if (this.HayCapacidadEnBodega(pesoEquipaje))
            {
                this.kgActualesEnBodega += pesoEquipaje;
                return true;
            }
            return false;
        }

        private void AgregarABaseDeDatos()
        {
            if(Sistema.ViajeExisteEnBaseDeDatos(this))
            {
                BaseDeDatos.ListaViajesActivos.Add(this);
            }
        }

        public void AcumularGananciasDeVentaMultiple(List<Pasajero> listaPasajeros)
        {
            foreach (Pasajero AuxPasajero in listaPasajeros)
            {
                this.AcumularGananciaDeUnaVenta(AuxPasajero);
            }
        }

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
        
        public void CargarListaPasajerosHardcodeados(List<Pasajero> listaPasajeros)
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
           
            if(this.AsignarCamaroteAPasajero(pasajero) && this.AgregarEquipaje(pasajero.ObtenerEquipaje()))
            {
                seAgrego = true;
                this.listaPasajeros.Add(pasajero);
                Cliente.SumarleUnViajeACliente(pasajero.ObtenerCliente());
                this.AcumularGananciaDeUnaVenta(pasajero);
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

            if (this.AsignarCamaroteAGrupoFamiliar(pasajeros, sonPremium) && this.AgregarEquipaje(totalPeso))
            {
                seAgregaron = true;
                foreach(Pasajero auxPasajero in pasajeros)
                {
                    this.listaPasajeros.Add(auxPasajero);
                    Cliente.SumarleUnViajeACliente(auxPasajero.ObtenerCliente());
                }
                this.AcumularGananciasDeVentaMultiple(pasajeros);
            }
            
            return seAgregaron;
        }

        

        private bool AsignarCamaroteAPasajero(Pasajero pasajero)
        {
            bool seAgregoAlCamarote = false;
 
            if (pasajero.EsPremium)
            {                
                if(this.AgregarPasajeroACamarotePremiumDisponible(pasajero))
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

        private bool AsignarCamaroteAGrupoFamiliar(List<Pasajero> grupoPasajeros, bool sonPremium)
        {
            bool seAgregaronAlCamarote = false;

            if (sonPremium)
            {
                if (this.AgregarGrupoPasajerosACamarotePremiumDisponible(grupoPasajeros))
                {
                    //this.crucero.ObtenerListaCamarotesPremium().Add(new Camarote(grupoPasajeros));
                    seAgregaronAlCamarote = true;
                }
            }
            else
            {
                if (this.AgregarGrupoPasajerosACamaroteTuristaDisponible(grupoPasajeros))
                {
                    //this.crucero.ObtenerListaCamarotesTurista().Add(new Camarote(grupoPasajeros));
                    seAgregaronAlCamarote = true;
                }
            }
            return seAgregaronAlCamarote;
        }

        public override bool Equals(object obj)
        {
            if(obj is Viaje auxViaje)
            {
                return this.codigoDeViaje == auxViaje.codigoDeViaje;
            }
            return false;
        }

        public string ObtenerDatosCrucero()
        {
            return $"Matricula: {this.crucero.Matricula}\nBodega: {this.kgActualesEnBodega}/{this.crucero.CapacidadMaximaBodega}\nCamarotes turista: {this.camarotesTurista.Count}/{this.crucero.CantidadCamarotesTurista}\nCamarotes premium:{this.camarotesPremium.Count}/{this.crucero.CantidadCamarotesPremium}";
        }
        /*
        public override string ToString()
        {
            return $"Crucero: {this.crucero}\nOrigen: {this.origen} Destino;{this.destino}\nesRegional: {this.esRegional}\nDuracion: {this.duracionEnHoras}";
        }*/

        public string GenerarCodigoDeViajeAleatorio()
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', };
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();

            string codigo = "";
            codigo += letras[random.Next(0, letras.Length)];
            codigo += letras[random.Next(0, letras.Length)];
            codigo += letras[random.Next(0, letras.Length)];
            codigo += letras[random.Next(0, letras.Length)];
            codigo += numeros[random.Next(0, numeros.Length)];
            codigo += numeros[random.Next(0, numeros.Length)];

            return codigo;

        }
    }
}

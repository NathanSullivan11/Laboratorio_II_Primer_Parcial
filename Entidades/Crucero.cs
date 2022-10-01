using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Crucero
    {
        private string matricula;
        private string nombre;
        private int cantidadCamarotes;
        private List<Camarote> camarotesTurista;
        private List<Camarote> camarotesPremium;
        private int maximoCamarotesTurista;
        private int maximoCamarotesPremium;
        private int capacidadMaximaBodega;
        private int kgActualesEnBodega;
        private bool estaEnUso;
        private bool tieneComedor;
        private bool tieneGimnasio;
        private bool tienePileta;
        private bool tieneBar;
        private int cantidadCasinos;

        public Crucero(string matricula, string nombre, int cantidadCamarotes, int capacidadMaximaBodega, bool tieneComedor, bool tieneGimnasio, bool tienePileta, bool tieneBar, int cantidadCasinos)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.cantidadCamarotes = cantidadCamarotes;
            this.camarotesPremium = new List<Camarote>();
            this.maximoCamarotesPremium = (int)(this.cantidadCamarotes * 0.35);
            this.camarotesTurista = new List<Camarote>();
            this.maximoCamarotesTurista = this.cantidadCamarotes - this.maximoCamarotesPremium;
            this.tieneComedor = tieneComedor ;
            this.tieneGimnasio = tieneGimnasio;
            this.tienePileta = tienePileta;
            this.tieneBar = tieneBar;
            this.cantidadCasinos = cantidadCasinos;
            this.capacidadMaximaBodega = capacidadMaximaBodega;
            this.kgActualesEnBodega = 0;
        }

        public string Nombre { get => this.nombre; }
        public int CantidadCamarotes { get => this.cantidadCamarotes; }
        public string ListaSalones { get => this.FormatearSalones(); }     
        public bool TieneCasino { get => this.cantidadCasinos > 0; }
        public int CantidadCasinos { get => this.cantidadCasinos; }
        public int CapacidadMaximaBodega { get => this.capacidadMaximaBodega; }
        public bool EstaEnUso { get => this.estaEnUso; set => estaEnUso = value; }
        public int KgActualesEnBodega { get => this.kgActualesEnBodega; }
        public int CantidadCamarotesPremium { get => this.maximoCamarotesPremium; }
        public int CantidadCamarotesTurista{ get => this.maximoCamarotesTurista; }
        public bool TieneComedor { get => tieneComedor;  }
        public bool TieneGimnasio { get => tieneGimnasio;  }
        public bool TienePileta { get => tienePileta; }
        public bool TieneBar { get => tieneBar;  }

        

        public bool HayCapacidadEnBodega(int pesoEquipaje)
        {
            int valor = this.kgActualesEnBodega;
            return (valor + pesoEquipaje) <= this.CapacidadMaximaBodega;
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

        public List<Camarote> ObtenerListaCamarotesPremium()
        {
            return this.camarotesPremium;
        }

        public List<Camarote> ObtenerListaCamarotesTurista()
        {
            return this.camarotesTurista;
        }

        private bool hayCamarotesTuristaDisponibles()
        {
            bool hayDisponibles = false;

            if (this.camarotesTurista.Count < this.maximoCamarotesTurista)
            {
                hayDisponibles = true;
            }

            return hayDisponibles;
        }

        private bool hayCamarotesPremiumDisponibles()
        {
            bool hayDisponibles = false;

            if (this.camarotesPremium.Count < this.maximoCamarotesPremium)
            {
                hayDisponibles = true;
            }

            return hayDisponibles;
        }
        public bool AgregarPasajeroACamarotePremiumDisponible(Pasajero pasajero)
        {
            bool seAgrego = false;
            if (this.hayCamarotesPremiumDisponibles())
            {
                this.camarotesPremium.Add(new Camarote(pasajero));
                seAgrego = true;
            }
            return seAgrego;
        }

        public bool AgregarPasajeroACamaroteTuristaDisponible(Pasajero pasajero)
        {
            bool seAgrego = false;
            if (this.hayCamarotesTuristaDisponibles())
            {
                this.camarotesTurista.Add(new Camarote(pasajero));
                seAgrego = true;
            }
            return seAgrego;
        }

        public bool AgregarGrupoPasajerosACamarotePremiumDisponible(List<Pasajero> grupoPasajeros)
        {
            bool seAgrego = false;
            if (this.hayCamarotesPremiumDisponibles())
            {
                this.camarotesPremium.Add(new Camarote(grupoPasajeros));
                seAgrego = true;
            }
            return seAgrego;
        }

        public bool AgregarGrupoPasajerosACamaroteTuristaDisponible(List<Pasajero> grupoPasajeros)
        {
            bool seAgrego = false;
            if (this.hayCamarotesPremiumDisponibles())
            {
                this.camarotesTurista.Add(new Camarote(grupoPasajeros));
                seAgrego = true;
            }
            return seAgrego;
        }

        private string FormatearSalones()
        {
            StringBuilder sb = new StringBuilder("");
            if (this.tieneComedor)
            {
                sb.AppendLine("Comedor");
            }
           if (this.tieneGimnasio)
            {
                sb.AppendLine("Gimnasio");
            }
            if (this.tienePileta)
            {
                sb.AppendLine("Pileta");
            }
            if (this.tieneBar)
            {
                sb.AppendLine("Bar");
            }

            return sb.ToString();
        }


        public override string ToString()
        {
            return this.matricula;
        }

    }
}

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

        private int maximoCamarotesTurista;
        private int maximoCamarotesPremium;
        private int capacidadMaximaBodega;
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
          
            this.maximoCamarotesPremium = (int)(this.cantidadCamarotes * 0.35);
            
            this.maximoCamarotesTurista = this.cantidadCamarotes - this.maximoCamarotesPremium;
            this.tieneComedor = tieneComedor ;
            this.tieneGimnasio = tieneGimnasio;
            this.tienePileta = tienePileta;
            this.tieneBar = tieneBar;
            this.cantidadCasinos = cantidadCasinos;
            this.capacidadMaximaBodega = capacidadMaximaBodega;
            
        }

        public string Nombre { get => this.nombre; }
        public string Matricula { get => this.matricula; }
        public int CantidadCamarotes { get => this.cantidadCamarotes; }
        public string ListaSalones { get => this.FormatearSalones(); }     
        public bool TieneCasino { get => this.cantidadCasinos > 0; }
        public int CantidadCasinos { get => this.cantidadCasinos; }
        public int CapacidadMaximaBodega { get => this.capacidadMaximaBodega; }
        public bool EstaEnUso { get => this.estaEnUso; set => estaEnUso = value; }

        public int CantidadCamarotesPremium { get => this.maximoCamarotesPremium; }
        public int CantidadCamarotesTurista{ get => this.maximoCamarotesTurista; }
        public bool TieneComedor { get => tieneComedor;  }
        public bool TieneGimnasio { get => tieneGimnasio;  }
        public bool TienePileta { get => tienePileta; }
        public bool TieneBar { get => tieneBar;  }
  
        


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

        /*
         * 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {this.matricula}\nBodega: {this.kgActualesEnBodega}/{this.capacidadMaximaBodega}\nCamarotes turista: {this.camarotesTurista.Count}/{this.maximoCamarotesTurista}\nCamarotes premium:{this.camarotesPremium.Count}/{this.maximoCamarotesPremium}");

            return sb.ToString();
        }*/

        public override bool Equals(object obj)
        {
            if(obj is Crucero auxCrucero)
            {
                if(this.matricula == auxCrucero.matricula)
                {
                    return true;
                }
            }
            return false;
        }

    }
}

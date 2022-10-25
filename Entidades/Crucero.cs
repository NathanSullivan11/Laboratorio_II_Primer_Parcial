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
        private string listaSalones;
        private int cantidadSalones;
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
            this.listaSalones = this.FormatearSalones();


        }

        public string Nombre { get => this.nombre; }
        public string Matricula { get => this.matricula; }
        public int CantidadCamarotes { get => this.cantidadCamarotes; }
        public int CapacidadMaximaBodega { get => this.capacidadMaximaBodega; }
        public int CantidadSalones { get => this.cantidadSalones;  }   
        public int CantidadCasinos { get => this.cantidadCasinos; }
        public int CantidadCamarotesPremium { get => this.maximoCamarotesPremium; }
        public int CantidadCamarotesTurista { get => this.maximoCamarotesTurista; }
        public bool TieneComedor { get => tieneComedor;  }
        public bool TieneGimnasio { get => tieneGimnasio;  }
        public bool TienePileta { get => tienePileta; }
        public bool TieneBar { get => tieneBar;  }
        public bool EstaEnUso { set => estaEnUso = value; }

        public bool CruceroEstaEnUso()
        {
            return this.estaEnUso;
        }


        public string ObtenerListaSalones()
        {
            return this.listaSalones;
        }

        private string FormatearSalones()
        {
            this.cantidadSalones = 0;
            StringBuilder sb = new StringBuilder("");
            if (this.tieneComedor)
            {
                sb.AppendLine("Comedor");
                this.cantidadSalones++;
            }
            if (this.tieneGimnasio)
            {
                sb.AppendLine("Gimnasio");
                this.cantidadSalones++;
            }
            if (this.tienePileta)
            {
                sb.AppendLine("Pileta");
                this.cantidadSalones++;
            }
            if (this.tieneBar)
            {
                sb.AppendLine("Bar");
                this.cantidadSalones++;
            }

            return sb.ToString();
        }

        
         
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Matricula: {this.matricula}\nCapacidad bodega: {this.capacidadMaximaBodega}\nCamarotes turista: {this.maximoCamarotesTurista}\nCamarotes premium:{this.maximoCamarotesPremium}");

            return sb.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

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

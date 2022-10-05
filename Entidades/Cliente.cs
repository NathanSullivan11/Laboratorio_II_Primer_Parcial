using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int id;
        private int cantidadViajes;

        public Cliente(string nombre, string apellido, int dni, int edad,int id) : base(nombre, apellido, dni, edad)
        {
            this.id = id;
            this.cantidadViajes = 0;
        }

        public int Id { get => this.id; }

        public int CantidadViajes { get => this.cantidadViajes; }

        public override bool Equals(object obj)
        {
            if(obj is Cliente auxCliente)
            {
                return this.id == auxCliente.id;
            }
            return false;           
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nApellido: {this.Apellido}\nEdad;{this.Edad}\nId: {this.id}";
        }

        

        public static void SumarleUnViajeACliente(Cliente cliente)
        {
            cliente.cantidadViajes++;
        }
    }
}

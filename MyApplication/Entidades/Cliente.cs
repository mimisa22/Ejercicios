using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Entidades
{
    internal class Cliente : Persona
    {

        public Guid ClienteId { get; set; }
       
        public string Direccion { get; set; }


        public Cliente(string nombre, string apellido, string telefono, string direccion, int edad): 
            base(nombre, apellido, edad, telefono)
        {
            ClienteId = Guid.NewGuid();
           
            Direccion = direccion;
        }

        public override string ToString()
        {
            return $"{Nombre}, {Apellido}, {Telefono}, {Direccion}, {Edad}";
        }


    }
}

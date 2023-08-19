using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Entidades
{
    internal abstract class Persona : Entity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }

        internal Persona(string nombre, string apellido, int edad, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad < 0 ? throw new ArgumentException() : edad;
            Telefono = telefono;
        }

    }
}

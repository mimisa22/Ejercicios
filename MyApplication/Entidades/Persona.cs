using MyApplication.Guards;
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
            Nombre = Guard.Length(nombre,nameof(nombre), 4, 50);
            Apellido = Guard.Length(apellido, nameof(apellido), 4, 50);
            Edad =  Guard.MinValue(edad,nameof(edad), 10);
            Telefono = Guard.Length(telefono,nameof(telefono),10,10).IsNumeric();
        }

    }
}

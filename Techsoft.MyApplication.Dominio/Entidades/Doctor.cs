using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Entidades
{
    public class Doctor : Persona
    {
        public Guid DoctorId { get; set; }
 
       
        public string Cedula { get; set; }


        public Doctor(string nombre, string apellido, string telefono, string cedula, int edad): base(nombre, apellido, edad, telefono)
        {
            DoctorId = Guid.NewGuid();
            Cedula = cedula;
        }

        public override string ToString()
        {
            return $"{Nombre}, {Apellido}, {Telefono}, {Cedula}, {Edad}";
        }
    }
}

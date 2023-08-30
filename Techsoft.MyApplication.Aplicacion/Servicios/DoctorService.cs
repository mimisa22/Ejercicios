using MyApplication.Contratos;
using MyApplication.Entidades;
using MyApplication.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Techsoft.MyApplication.Aplicacion.Servicios
{
    public class DoctorService
    {
        private readonly IRepositorio<Doctor> _repo;

        public DoctorService()
        {
            _repo = RepositorioFabrik.CrearRepositorio<Doctor>
                (RepositorioFabrik.DBOptions.SQLServer);
        }


        public void Guardar(string nombre, string apellido, string telefono, string cedula, int edad)
        {
            var doctor = new Doctor(nombre, apellido, telefono, cedula, edad);

            //Aseguramos que el cliente no se repita
            DoctorNotExists(doctor);

            _repo.Guardar(doctor);
        }

        //Guarda
        private void DoctorNotExists(Doctor doctor)
        {
            if (ConsultarTodos().Where(c => c.Nombre == doctor.Nombre
             && c.Apellido == doctor.Apellido).Count() > 0)
                throw new InvalidOperationException($"El doctor {doctor.Nombre} {doctor.Apellido} ya existe en la base de datos");
        }


        public List<Doctor> ConsultarTodos()
        {
            return _repo.ConsultarTodos();
        }
    }
}

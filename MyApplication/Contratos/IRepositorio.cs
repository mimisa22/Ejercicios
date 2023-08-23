using MyApplication.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Contratos
{
    internal interface IRepositorio
    {
        void Guardar<T>(T entidad) where T: Entity;

        Cliente Consultar<T>(T entidad) where T : Entity;
    }
}

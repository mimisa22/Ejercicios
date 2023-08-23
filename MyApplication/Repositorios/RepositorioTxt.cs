using MyApplication.Contratos;
using MyApplication.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Repositorios
{
    internal class RepositorioTxt : IRepositorio
    {
        public Cliente Consultar<T>(T entidad) where T : Entity
        {
            throw new NotImplementedException();
        }

        public void Guardar<TEntity>(TEntity entity) where TEntity : Entity
        {
            var type = entity.GetType();

            using (StreamWriter? db = new(@$"C:\Users\ivanh\Documents\DataBase\{type}.txt", true))
            {
                db.WriteLine(entity.ToString());
            }
        }
    }
}

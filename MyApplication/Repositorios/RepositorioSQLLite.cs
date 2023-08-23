using Microsoft.EntityFrameworkCore;
using MyApplication.Contexto;
using MyApplication.Contratos;
using MyApplication.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Repositorios
{
    internal class RepositorioSQLLite : IRepositorio
    {
        public Cliente Consultar<T>(T entidad) where T : Entity
        {
            throw new NotImplementedException();
        }

        public void Guardar<T>(T entidad) where T : Entity
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            var options = optionsBuilder
                .UseSqlite(@"Data Source=C:\Users\ivanh\Documents\DataBase\myapp.db")
                .Options
               ;
            var context = new Context(options);

            context.Set<T>().Add(entidad);
            context.SaveChanges();
        }

      
    }
}

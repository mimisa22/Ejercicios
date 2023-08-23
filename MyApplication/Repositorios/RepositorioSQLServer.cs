using Microsoft.EntityFrameworkCore;
using MyApplication.Contexto;
using MyApplication.Contratos;
using MyApplication.Entidades;

namespace MyApplication.Repositorios
{
    internal class RepositorioSQLServer : IRepositorio
    {
        public Cliente Consultar<T>(T entidad) where T : Entity
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            var options = optionsBuilder
                .UseSqlServer(@"server=.;Initial Catalog=MyApplication;Integrated Security=True; Encrypt=false")
                .Options
               ;

            var context = new Context(options);

            var result = context.Set<T>().FirstOrDefault();

            return result as Cliente;
        }

        public void Guardar<TEntity>(TEntity entity) where TEntity : Entity
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            var options = optionsBuilder
                .UseSqlServer(@"server=.;Initial Catalog=MyApplication;Integrated Security=True; Encrypt=false")
                .Options
               ;

            var context = new Context(options);

            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }


    }
}

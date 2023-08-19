using Microsoft.EntityFrameworkCore;
using MyApplication.Contexto;
using MyApplication.Contratos;
using MyApplication.Entidades;

namespace MyApplication.Repositorios
{
    internal class RepositorioSQLServer : IRepositorio
    {
        public void Guardar<TEntity>(TEntity entity) where TEntity : Entity
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            var options = optionsBuilder
                .UseSqlServer(@"server=.; initial catalog=Pruebas125; Trusted_Connection = true; Encrypt=false")
                .Options
               ;

            var context = new Context(options);

            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }
    }
}

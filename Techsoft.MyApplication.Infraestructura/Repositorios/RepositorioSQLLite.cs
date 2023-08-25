using Microsoft.EntityFrameworkCore;
using MyApplication.Contexto;
using MyApplication.Contratos;
using MyApplication.Entidades;

namespace MyApplication.Repositorios;

public class RepositorioSQLLite<T> : IRepositorio<T> where T : Entity
{
    public T Consultar(T entidad) 
    {
        throw new NotImplementedException();
    }

    public List<T> ConsultarTodos()
    {
        throw new NotImplementedException();
    }

    public void Guardar(T entidad) 
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

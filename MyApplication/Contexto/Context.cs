using Microsoft.EntityFrameworkCore;
using MyApplication.Entidades;

namespace MyApplication.Contexto
{
    public class Context: DbContext
    {

        internal DbSet<Cliente> Clientes { get; set; }
        internal DbSet<Doctor> Doctores { get; set; }


        public Context(DbContextOptions options):base(options){}

        //public Context()
        //{
            
        //}

        //protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;Initial Catalog=MyApplication;Integrated Security=True; Encrypt=false");
        //}

       
    }
}

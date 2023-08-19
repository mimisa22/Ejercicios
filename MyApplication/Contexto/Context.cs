using Microsoft.EntityFrameworkCore;
using MyApplication.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Contexto
{
    public class Context: DbContext
    {

        internal DbSet<Cliente> Clientes { get; set; }
        internal DbSet<Doctor> Doctores { get; set; }


        public Context(DbContextOptions options):base(options){}

      

       
    }
}

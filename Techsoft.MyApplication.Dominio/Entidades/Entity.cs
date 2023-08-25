using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Entidades
{


    public class Entity
    {
        public DateTime FechaCreacion { get; set; }

        public Entity()
        {
            FechaCreacion = DateTime.Now;
        }
    }
}

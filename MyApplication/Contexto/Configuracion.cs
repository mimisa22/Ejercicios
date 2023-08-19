using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyApplication.Fabricas.RepositorioFabrik;

namespace MyApplication.Contexto
{
    internal class Configuracion
    {
        //crear patron singleton
        private static Configuracion _instancia;

        public DBOptions DbOption { get; private set; }

        //El contructor debe ser privado
        private Configuracion(DBOptions options)
        {
            DbOption = options;
        }

        internal static Configuracion Instancia( DBOptions options)
        {
          
                if (_instancia == null)
                {
                    _instancia = new Configuracion(options);
                }
                return _instancia;
           
        }
    }
}

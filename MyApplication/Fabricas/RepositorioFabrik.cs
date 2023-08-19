using MyApplication.Contratos;
using MyApplication.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Fabricas
{
    internal static class RepositorioFabrik
    {
        internal  enum DBOptions
        {
            SQLServer,
            SQLLite,
            Txt
        }

        internal static IRepositorio CrearRepositorio(DBOptions dbOptions)
        {
            switch (dbOptions)
            {
                case  DBOptions.SQLServer:
                    return new RepositorioSQLServer();
                case DBOptions.SQLLite:
                    return new RepositorioSQLLite();
                case DBOptions.Txt:
                    return new RepositorioTxt();
                default:
                    return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
  public  class N_Clientes
    {
        readonly D_Clientes objClientes = new D_Clientes();


        public static DataTable MostrarRegistrosC()
        {
            return new D_Clientes().MostrarRegistrosC();

        }

        public static DataTable BuscarRegistrosC(string textobuscarc)
        {
            return new D_Clientes().BuscarRegistrosC(textobuscarc);

        }

        public void InsertarRegistro(E_Clientes clientes)
        {
            objClientes.InsertarRegistro(clientes);
        }

        public void EditarRegistros(E_Clientes clientes)
        {
            objClientes.EditarRegistros(clientes);
        }

        public void EliminarRegistro(E_Clientes clientes)
        {
            objClientes.EliminarRegistro(clientes);
        }
    }
}

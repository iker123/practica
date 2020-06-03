using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class N_Usuarios
    {
        readonly D_Usuarios objusuarios = new D_Usuarios();

        /*   public List<E_Usuarios> ListarRegistros()
           {
               return objusuarios.MostrarRegistrosUSUARIOS();
           }*/
        public static DataTable MostrarRegistrosU()
        {
            return new D_Usuarios().MostrarRegistrosUSUARIOS();

        }

        public void InsertarRegistro(E_Usuarios usuarios)
        {
            objusuarios.InsertarRegistro(usuarios);
        }

        public void EditarRegistros(E_Usuarios usuarios)
        {
            objusuarios.EditarRegistros(usuarios);
        }

        public void EliminarRegistro(E_Usuarios usuarios)
        {
            objusuarios.EliminarRegistro(usuarios);
        }


    }
}

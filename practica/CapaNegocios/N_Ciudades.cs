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
    public class N_Ciudades
    {
        readonly D_Ciudades objCiudades = new D_Ciudades();


        public static DataTable mostrarRegistros()
        {
            return new D_Ciudades().MostrarRegistror();

        }

        public void InsertarRegistro(E_Ciudades ciudades)
        {
            objCiudades.InsertarRegistro(ciudades);
        }

        public void EditarRegistros(E_Ciudades ciudades)
        {
            objCiudades.EditarRegistros(ciudades);
        }

        public void EliminarRegistro(E_Ciudades ciudades)
        {
            objCiudades.EliminarRegistro(ciudades);
        }
    }
}

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
   public  class N_Profesionales
    {
        readonly D_Profesionales objProfesionales = new D_Profesionales();


        public static DataTable mostrarRegistros()
        {
            return new D_Profesionales().MostrarRegistros();

        }

        public static DataTable BuscarRegistros(string textobuscar)
        {
            return new D_Profesionales().BuscarRegistros(textobuscar);

        }

        public void InsertarRegistro(E_Profesionales profesionales)
        {
            objProfesionales.InsertarRegistro(profesionales);
        }

        public void EditarRegistros(E_Profesionales profesionales)
        {
            objProfesionales.EditarRegistros(profesionales);
        }

        public void EliminarRegistro(E_Profesionales profesionales)
        {
            objProfesionales.EliminarRegistro(profesionales);
        }
    }
}

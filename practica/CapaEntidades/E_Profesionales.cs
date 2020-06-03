using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Profesionales
    {
        /* REALIZA EL ENCAPSULAMIENTO DE TODA LA TABLA PROFESIONALES*/
        public int IdProfesionales { get; set; }
        public string CiProfesionales { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int IdCiudades { get; set; }

        public static implicit operator E_Profesionales(E_Ciudades v)
        {
            throw new NotImplementedException();
        }
    }
}

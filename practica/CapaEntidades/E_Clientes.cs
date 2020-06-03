using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class E_Clientes
    {
        #region Encaosulamiento De los atributos de mi tabla Clientes
        public int IdClientes { get; set; }
        public string CIORUC { get; set; }
        public string Razonsocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int IdProfesionales { get; set; }
        public int IdCiudades { get; set; }
        #endregion
    }
}

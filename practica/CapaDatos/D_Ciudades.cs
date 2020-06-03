using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Ciudades
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        public DataTable MostrarRegistror()
        {
            DataTable Dtresultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("spmostrar_ciudades", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(Dtresultado);

            return Dtresultado;
        }

        public void InsertarRegistro(E_Ciudades ciudades)
        {
            SqlCommand sqlcmd = new SqlCommand("spinsertar_ciudades",conectar)
            {
                CommandType=CommandType.StoredProcedure
            };
            conectar.Open();
            sqlcmd.Parameters.AddWithValue("@descripcion", ciudades.Descripcion);
            sqlcmd.ExecuteNonQuery();

            conectar.Close();

        }
        public void EditarRegistros(E_Ciudades ciudades)
        {
            SqlCommand sqlcmd = new SqlCommand("speditar_ciudades", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();
            sqlcmd.Parameters.AddWithValue("@idciudades", ciudades.IdCiudades);
            sqlcmd.Parameters.AddWithValue("@descripcion", ciudades.Descripcion);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Ciudades ciudades)
        {
            SqlCommand sqlcmd = new SqlCommand("speliminar_ciudades", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            sqlcmd.Parameters.AddWithValue("@idciudades", ciudades.IdCiudades);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}

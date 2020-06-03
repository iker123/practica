using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Profesionales
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        public DataTable MostrarRegistros()
        {
            DataTable Dtresultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("spmostrar_profesionales", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(Dtresultado);

            return Dtresultado;
        }

        public DataTable BuscarRegistros(string textobuscar)
        {
            DataTable Dtresultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("spbuscar_profesionales", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscar", textobuscar);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(Dtresultado);

            return Dtresultado;
        }



        public void InsertarRegistro(E_Profesionales profesionales)
        {
            SqlCommand sqlcmd = new SqlCommand("spinsertar_profesionales", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();

            sqlcmd.Parameters.AddWithValue("@ciprofesional", profesionales.CiProfesionales);
            sqlcmd.Parameters.AddWithValue("@nombres", profesionales.Nombres);
            sqlcmd.Parameters.AddWithValue("@apellidos", profesionales.Apellidos);
            sqlcmd.Parameters.AddWithValue("@direccion", profesionales.Direccion);
            sqlcmd.Parameters.AddWithValue("@telefono", profesionales.Telefono);
            sqlcmd.Parameters.AddWithValue("@correo", profesionales.Correo);
            sqlcmd.Parameters.AddWithValue("@idciudades", profesionales.IdCiudades);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();

        }
        public void EditarRegistros(E_Profesionales profesionales)
        {
            SqlCommand sqlcmd = new SqlCommand("speditar_profesionales", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();

            sqlcmd.Parameters.AddWithValue("@idprofesionales", profesionales.IdProfesionales);
            sqlcmd.Parameters.AddWithValue("@ciprofesional", profesionales.CiProfesionales);
            sqlcmd.Parameters.AddWithValue("@nombres", profesionales.Nombres);
            sqlcmd.Parameters.AddWithValue("@apellidos", profesionales.Apellidos);
            sqlcmd.Parameters.AddWithValue("@direccion", profesionales.Direccion);
            sqlcmd.Parameters.AddWithValue("@telefono", profesionales.Telefono);
            sqlcmd.Parameters.AddWithValue("@correo", profesionales.Correo);
            sqlcmd.Parameters.AddWithValue("@idciudades", profesionales.IdCiudades);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();
        }

        public void EliminarRegistro(E_Profesionales profesionales)
        {
            SqlCommand sqlcmd = new SqlCommand("speliminar_profesionales", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            sqlcmd.Parameters.AddWithValue("@idprofesionales", profesionales.IdProfesionales);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();
        }
    }
}

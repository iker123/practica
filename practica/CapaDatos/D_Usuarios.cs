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
   public class D_Usuarios
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

      /*  public List<E_Usuarios> ListarRegistros()
        {
            SqlDataReader LeerFilas;

            SqlCommand cmd = new SqlCommand("sp_mostarusuarios", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();

            LeerFilas = cmd.ExecuteReader();

            List<E_Usuarios> Listar = new List<E_Usuarios>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Usuarios
                {
                    IdUsuarios = LeerFilas.GetInt32(0),
                    Usuarios = LeerFilas.GetString(1),
                    Contrasena = LeerFilas.GetString(2),
                    Acceso = LeerFilas.GetString(3),
                   
                    IdProfesionales = LeerFilas.GetInt32(4),
                    Profesional = LeerFilas.GetString(5)

                });
             }

            conectar.Close();
            LeerFilas.Close();
            return Listar;
        }*/

        public DataTable MostrarRegistrosUSUARIOS()
        {
            DataTable Dtresultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("sp_mostarusuarios", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(Dtresultado);

            return Dtresultado;
        }



        #region METODO DE spINSERTAR_USUARIOS
        public void InsertarRegistro(E_Usuarios usuarios)
        {
            SqlCommand sqlcmd = new SqlCommand("spinsertar_usuarios", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();

            sqlcmd.Parameters.AddWithValue("@usuario", usuarios.Usuarios);
            sqlcmd.Parameters.AddWithValue("@contrasena", usuarios.Contrasena);
            sqlcmd.Parameters.AddWithValue("@acceso", usuarios.Acceso);
            sqlcmd.Parameters.AddWithValue("@idprofesionales", usuarios.IdProfesionales);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();

        }
        #endregion

        #region METODO DE sp_EDITAR_USUARIOS
        public void EditarRegistros(E_Usuarios usuarios)
        {
            SqlCommand sqlcmd = new SqlCommand("speditar_usuario", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();

            sqlcmd.Parameters.AddWithValue("@idusuarios", usuarios.IdUsuarios);
            sqlcmd.Parameters.AddWithValue("@usuario", usuarios.Usuarios);
            sqlcmd.Parameters.AddWithValue("@contrasena", usuarios.Contrasena);
            sqlcmd.Parameters.AddWithValue("@acceso", usuarios.Acceso);
            sqlcmd.Parameters.AddWithValue("@idprofesionales", usuarios.IdProfesionales);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();
        }
        #endregion

        #region METODO DE spELIMINAR_Usuarios
        public void EliminarRegistro(E_Usuarios usuarios)
        {
            SqlCommand sqlcmd = new SqlCommand("speliminar_usuario", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            sqlcmd.Parameters.AddWithValue("@idusuarios", usuarios.IdUsuarios);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();
        }
        #endregion
    }
}

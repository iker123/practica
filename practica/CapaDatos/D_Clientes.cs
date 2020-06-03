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
  public  class D_Clientes
    {
        readonly SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        #region METODO DE spMOSTRAR_REGISTROS
        public DataTable MostrarRegistrosC()
        {
            DataTable Dtresultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("spmostrar_clientes", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(Dtresultado);

            return Dtresultado;
        }
        #endregion

        #region METODO DE spBuscar_REGISTROS
        public DataTable BuscarRegistrosC(string textobuscarc)
        {
            DataTable Dtresultado = new DataTable();
            SqlCommand SqlCmd = new SqlCommand("spbuscar_cliente", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCmd.Parameters.AddWithValue("@textobuscarc", textobuscarc);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(Dtresultado);

            return Dtresultado;
        }
        #endregion

        #region METODO DE spINSERTAR_REGISTROS
        public void InsertarRegistro(E_Clientes clientes)
        {
            SqlCommand sqlcmd = new SqlCommand("spinsertar_clientes", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();

            sqlcmd.Parameters.AddWithValue("@ciorud", clientes.CIORUC);
            sqlcmd.Parameters.AddWithValue("@razonsocial", clientes.Razonsocial);
            sqlcmd.Parameters.AddWithValue("@direccion", clientes.Direccion);
            sqlcmd.Parameters.AddWithValue("@telefono", clientes.Telefono);
            sqlcmd.Parameters.AddWithValue("@correo", clientes.Correo);
            sqlcmd.Parameters.AddWithValue("@idprofesionales", clientes.IdProfesionales);
            sqlcmd.Parameters.AddWithValue("@idciudades", clientes.IdCiudades);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();

        }
        #endregion

        #region METODO DE sp_EDITAR_REGISTROS
        public void EditarRegistros(E_Clientes clientes)
        {
            SqlCommand sqlcmd = new SqlCommand("speditar_clientes", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            conectar.Open();

            sqlcmd.Parameters.AddWithValue("@idclientes", clientes.IdClientes);
            sqlcmd.Parameters.AddWithValue("@ciorud", clientes.CIORUC);
            sqlcmd.Parameters.AddWithValue("@razonsocial", clientes.Razonsocial);
            sqlcmd.Parameters.AddWithValue("@direccion", clientes.Direccion);
            sqlcmd.Parameters.AddWithValue("@telefono", clientes.Telefono);
            sqlcmd.Parameters.AddWithValue("@correo", clientes.Correo);
            sqlcmd.Parameters.AddWithValue("@idprofesionales", clientes.IdProfesionales);
            sqlcmd.Parameters.AddWithValue("@idciudades", clientes.IdCiudades);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();
        }
        #endregion

        #region METODO DE spELIMINAR_REGISTROS
        public void EliminarRegistro(E_Clientes clientes)
        {
            SqlCommand sqlcmd = new SqlCommand("speliminar_clientes", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            conectar.Open();
            sqlcmd.Parameters.AddWithValue("@idclientes", clientes.IdClientes);

            sqlcmd.ExecuteNonQuery();

            conectar.Close();
        }
        #endregion

    }
}

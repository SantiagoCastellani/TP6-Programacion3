using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP6_GRUPO_5.Conexion
{
    public class Conexion
    {
        /// PROPERTIES
        //static string servidor = "localhost";
        static string servidor = "AXEL";
        string urlBD = @"Data Source="+servidor+@"\sqlexpress;Initial Catalog = Neptuno; Integrated Security = True";

        public Conexion()
        {
        }

        /// METODOS
        public SqlConnection ObtenerConexion()
        {
            SqlConnection sqlConnection = new SqlConnection(urlBD);
            try
            {
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
        public SqlDataAdapter ObtenerAdaptador(string consultaSql)
        {
            SqlDataAdapter sqlDataAdapter;
            try
            {
                sqlDataAdapter = new SqlDataAdapter(consultaSql, ObtenerConexion());
                return sqlDataAdapter;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public int EjecutarSP(SqlCommand comandoSQL, string nombreProcedimientoAlmacenado)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand = comandoSQL;
            sqlCommand.Connection = Conexion;
            sqlCommand.CommandType = CommandType.StoredProcedure;  
            sqlCommand.CommandText = nombreProcedimientoAlmacenado; 
            FilasCambiadas = sqlCommand.ExecuteNonQuery();          
            Conexion.Close();
            return FilasCambiadas;
        }
    }
}
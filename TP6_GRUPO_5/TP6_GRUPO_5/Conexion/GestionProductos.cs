using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP6_GRUPO_5.Conexion
{
    public class GestionProductos
    {
        public GestionProductos()
        {
        }

        /// METODOS
        private DataTable ObtenerTabla(string nombreTabla, string consultaSQL)
        {
            DataSet dataSet = new DataSet();
            Conexion conexion = new Conexion();
            SqlDataAdapter sqlDataAdapter = conexion.ObtenerAdaptador(consultaSQL);
            sqlDataAdapter.Fill(dataSet, nombreTabla);
            return dataSet.Tables[nombreTabla];
        }

        public DataTable ObtenerProductos()
        {
            return ObtenerTabla("Productos", "SELECT IdProducto,NombreProducto,CantidadPorUnidad,PrecioUnidad FROM Productos");
        }

        public bool EliminarProducto(int idProducto)
        {
            string consultaSQL = "DELETE FROM Productos WHERE IdProducto = @IdProducto";
            Conexion conexion = new Conexion();
            SqlConnection sqlConnection = conexion.ObtenerConexion();
            SqlCommand sqlCommand = new SqlCommand(consultaSQL, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@IdProducto", idProducto);
            try
            {
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //private void ArmarParametrosProductos(ref SqlCommand comando,Producto producto)
        //{
        //    SqlParameter sqlParametros = new SqlParameter();
        //    sqlParametros = comando.Parameters.Add("@IdProducto", SqlDbType.Int);
        //    sqlParametros.Value = producto.IdProducto;
        //    sqlParametros = comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar,50);
        //    sqlParametros.Value = producto.NombreProducto;
        //    sqlParametros = comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 20);
        //    sqlParametros.Value = producto.CantidadPorUnidad;
        //    sqlParametros = comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
        //    sqlParametros.Value = producto.Precio;
        //}
        public bool ModificarProducto(int idProd,string nombProd,string cantxUn,decimal precio)
        {
            string consultaSQL = "UPDATE Productos SET NombreProducto = @NombreProducto, CantidadPorUnidad = @CantidadPorUnidad, PrecioUnidad = @PrecioUnidad WHERE IdProducto = @IdProducto";
            Conexion conexion = new Conexion();
            SqlConnection sqlConnection = conexion.ObtenerConexion();
            SqlCommand sqlCommand = new SqlCommand(consultaSQL, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@IdProducto", idProd);
            sqlCommand.Parameters.AddWithValue("@NombreProducto", nombProd);
            sqlCommand.Parameters.AddWithValue("@CantidadPorUnidad", cantxUn);
            sqlCommand.Parameters.AddWithValue("@PrecioUnidad", precio);

            try
            {
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch 
            { 
                return false;
            }
        }
    }
}
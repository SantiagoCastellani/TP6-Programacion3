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
    }
}
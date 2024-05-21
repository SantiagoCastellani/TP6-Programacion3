using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_5.Conexion
{
    public class Producto
    {
        private int _IdProducto;
        private string _NombreProducto;
        private string _CantidadPorUnidad;
        private decimal _PrecioUnidad;

        public Producto()
        {

        }
        public Producto(int idProducto,string nombreProd, string cantXUnidad, decimal precio)
        {
            _IdProducto = idProducto;
            _NombreProducto = nombreProd;
            _CantidadPorUnidad = cantXUnidad;
            _PrecioUnidad = precio;
        }

        public int IdProducto
        {
            get
            {
                return _IdProducto;
            }
            set
            {
                _IdProducto = value;
            }
        }
        public string NombreProducto
        {
            get
            {
                return _NombreProducto;
            }
            set
            {
                _NombreProducto = value;
            }
        }
        public string CantidadPorUnidad
        {
            get
            {
                return _CantidadPorUnidad;
            }
            set
            {
                _CantidadPorUnidad = value;
            }
        }
        public decimal Precio
        {
            get
            {
                return _PrecioUnidad;
            }
            set
            {
                _PrecioUnidad = value;
            }
        }
    }
}
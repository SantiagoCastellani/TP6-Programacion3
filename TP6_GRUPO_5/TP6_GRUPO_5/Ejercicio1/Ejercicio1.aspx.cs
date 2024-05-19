using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_5.Conexion;

namespace TP6_GRUPO_5
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                CargarGrillaDeProdutos();
            }
        }

        // CARGAR GRIDVIEW
        private void CargarGrillaDeProdutos()
        {
            GestionProductos productos = new GestionProductos();
            gvProductos.DataSource = productos.ObtenerProductos(); 
            gvProductos.DataBind();
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            CargarGrillaDeProdutos();
        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idProducto = Convert.ToInt32(gvProductos.DataKeys[e.RowIndex].Value);

            //eliminar producto
            GestionProductos gestionProductos = new GestionProductos();
            gestionProductos.EliminarProducto(idProducto);

            CargarGrillaDeProdutos();
        }
    }
}
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
            if (!IsPostBack)
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
        protected void gvProductos_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            CargarGrillaDeProdutos();
        }

        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            CargarGrillaDeProdutos();
        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string IdProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_Eit_IdProducto")).Text;
            string NombreProducto = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_Eit_NombreProducto")).Text;
            string CantidadPorUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_Eit_CantidadPorUnidad")).Text;
            string PrecioUnidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_Eit_PecioUnidad")).Text;

            GestionProductos gestionProductos = new GestionProductos();
            gestionProductos.ModificarProducto(Convert.ToInt32(IdProducto), NombreProducto, CantidadPorUnidad, Convert.ToDecimal(PrecioUnidad));
            gvProductos.EditIndex = -1;
            CargarGrillaDeProdutos();
        }


    }
}
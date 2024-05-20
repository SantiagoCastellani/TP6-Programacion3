using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_5.Conexion;


namespace TP6_GRUPO_5.Ejercicio2
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarProductos();
            }
        }

        //cargar Grid View
        private void cargarProductos()
        {
            GestionProductos gestionProductos = new GestionProductos();
            gv_Productos.DataSource = gestionProductos.ObtenerProductos();
            gv_Productos.DataBind();
        }

        protected void gv_Productos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //obtener el indice
            int index = e.NewSelectedIndex;


            //verificar si selecciono una fila valida
            if(index >= 0 && index < gv_Productos.Rows.Count)
            {
                //obtener el nombre del producto seleccionado
                GridViewRow row = gv_Productos.Rows[index];
                string nombreProducto = row.Cells[2].Text;

                //mostrar el nombre del producto 
                Label1.Text = "Producto agregado: " + nombreProducto;
            }
        }
    }
}
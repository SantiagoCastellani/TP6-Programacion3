using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_5.Conexion;
using System.Data;


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
                int idProducto = int.Parse(row.Cells[1].Text);
                string nombreProducto = row.Cells[2].Text;
                string cantidad = row.Cells[3].Text;
                float precio = float.Parse(row.Cells[4].Text);

                //mostrar el nombre del producto 
                Label1.Text = "Producto agregado: " + nombreProducto;

                if (Session["tabla"] == null)
                {
                    Session["tabla"] = CrearTabla();
                }
                
                cargarSeleccionado((DataTable)Session["tabla"],idProducto,nombreProducto,cantidad,precio);
                
            }
            
        }

        // Cargar el Seleccionado a la tabla
        private DataTable cargarSeleccionado(DataTable dataTable, int idProducto,string nombreProducto,string cantidad,float precio)
        {
            DataRow dataRow = dataTable.NewRow();

            dataRow["IdProducto"] = idProducto;
            dataRow["NombreProducto"] = nombreProducto;
            dataRow["Cantidad"] = cantidad;
            dataRow["PrecioUnidad"] = precio;
            dataTable.Rows.Add(dataRow);

            return dataTable;
        }

        // Crea la Tabla para guardar en la sesión
        private DataTable CrearTabla()
        {
            DataTable dataTable = new DataTable();
            
            DataColumn dataColumn = new DataColumn("IdProducto", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Cantidad", System.Type.GetType("System.String"));
            dataTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("PrecioUnidad", System.Type.GetType("System.Decimal"));
            dataTable.Columns.Add(dataColumn);      

            return dataTable;
        }

        protected void gv_Productos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv_Productos.PageIndex = e.NewPageIndex;
            cargarProductos();
        }

        protected void LbtnVolverInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2.aspx");
        }
    }
}
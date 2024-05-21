using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP6_GRUPO_5.Ejercicio2
{
    public partial class MostrarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tabla"] != null)
            {
                gvSeleccionados.DataSource = (DataTable)Session["tabla"];
                gvSeleccionados.DataBind();
            }
        }

        protected void btnDeleteSession_Click(object sender, EventArgs e)
        {
            Session["tabla"] = null;
            gvSeleccionados.DataSource = null;
            gvSeleccionados.DataBind();
        }
    }
}
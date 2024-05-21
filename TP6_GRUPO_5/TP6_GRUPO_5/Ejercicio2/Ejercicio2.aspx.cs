using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_5.Ejercicio2
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lb_EliminarSeleccionados_Click(object sender, EventArgs e)
        {
            Session["tabla"] = null;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertScript", "alert('Los productos que estaba seleccionados, fueron eliminados.');", true);
        }
    }
}
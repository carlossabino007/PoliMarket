using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageAccesoNoPermitido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label13.Text = "Lo siento, "+cls_UsuarioLogueado.UsuarioLogueado + "!. Su usuario no está autorizado para este Módulo!.";
    }
}
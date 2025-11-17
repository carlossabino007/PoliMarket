using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paraprueba : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Valor = Request.QueryString["f1"];
        Label1.Text = Valor.ToString();
    }
}
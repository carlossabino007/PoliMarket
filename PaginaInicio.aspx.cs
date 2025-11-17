using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;

public partial class PruebaConMaster3 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblRolLogueado.Text = "";
            lblIDCodUsuarioLogueado.Text = "";
            lblCodUsuarioLogueado.Text = "";
            ObtenerIP();
        //    Desloguearse();
         //   Desloguearse();
         //   Desloguearse();
         //   Desloguearse();
           // ObtenerIP();
            TextBox1.Focus();

        }
            
    }

    //public void Desloguearse()
    //{
    //    DateTime fecha1 = DateTime.Now;
    //    DateTime fecha2 = DateTime.Now;
    //    cls_CreacionDeUsuarios xx1 = new cls_CreacionDeUsuarios(0, 0, 0, 0, "", "", "", "", "", "", "", "", 0, fecha1, fecha2, "",0);

    //     if (xx1.existePorIP(lblIPDeUsuarioLogueado.Text))
    //    {
    //        xx1.Usuario_estadoDeConexion = 0;
    //        xx1.Usuario_IPDeConexion = "";
    //        xx1.Usuario_SalidaCorrecta = 0;

             
    //         //lblRolLogueado.Text = "";
    //         //lblIDCodUsuarioLogueado.Text = "";
    //         //lblCodUsuarioLogueado.Text = "";
    //         //lblIPDeUsuarioLogueado.Text = "";
    //         xx1.actualizarPorIPLoguedo(lblIPDeUsuarioLogueado.Text);
    //    }

    //}

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        //DateTime fecha1 = DateTime.Now;
        //DateTime fecha2 = DateTime.Now;
        //cls_CreacionDeUsuarios xx1 = new cls_CreacionDeUsuarios(0, 0, 0, 0, "", "", "", "", "", "", "", "", 0, fecha1, fecha2, "",0);
        //if (xx1.existe(TextBox1.Text.ToUpper()))
        //{
        //    if (xx1.Usuario_contrasena.Equals(TextBox2.Text))
        //    {
        //        int elDiEs = xx1.IdCodUsuario;
        //        //Label9.Text = "Si existe toy aca" + lblIPDeUsuarioLogueado.Text+" "+elDiEs.ToString();
        //        lblmensaje1.ForeColor = System.Drawing.Color.Green;
        //        TextBox1.Enabled = false;
        //        TextBox2.Enabled = false;
        //        ImageButton1.Enabled = false;
        //        lblRolLogueado.Text = xx1.Usuario_RolEnLaEmpresa.ToString();
        //        lblIDCodUsuarioLogueado.Text = xx1.IdCodUsuario.ToString();
        //        lblCodUsuarioLogueado.Text = TextBox1.Text;
        //        string xIP = lblIPDeUsuarioLogueado.Text;
        //        xx1.Usuario_estadoDeConexion = 1;
        //        xx1.Usuario_SalidaCorrecta = 1;
        //        xx1.Usuario_FechaHoraDeConexion = Convert.ToDateTime(String.Format("{0:yyyy/M/d HH:mm:ss}", DateTime.Now.ToString()));
        //        xx1.Usuario_FechaDeConexion = Convert.ToDateTime(String.Format("{0:yyyy/M/d}", DateTime.Now.ToString()));
        //        xx1.Usuario_IPDeConexion=xIP;
        //        xx1.ActualizarNeoUsuarioLogueado(elDiEs);
                lblmensaje1.ForeColor = System.Drawing.Color.Green;
                lblmensaje1.Text = "Usuario y Contraseña Correctos. Bienvenido a Polimarket Ver 1.0";
                Button1.Visible = true;
                Button1.Focus();
        //    }
        //    else
        //    {
        //        TextBox1.Focus();
        //    }
        //}
        //else
        //{
        //    lblmensaje1.ForeColor = System.Drawing.Color.Red;
        //lblmensaje1.Text = "El usuario no existe o no está registrado. Favor intente de nuevo ";
        //    TextBox1.Focus();
       //}
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Button1.Visible = true;
        Response.Redirect("~/pagePrincipal.aspx");
    }

    private void ObtenerIP() 
    {
        string IPaddr = string.Empty;
        if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDER_FOR"] != null)
        {
            IPaddr = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDER_FOR"].ToString();
        }
        else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
        {
            IPaddr = HttpContext.Current.Request.UserHostAddress;
        }
        lblIPDeUsuarioLogueado.Text = IPaddr;
    }
}
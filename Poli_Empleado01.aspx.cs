using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Poli_Empleado01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox5.Focus();
        lblmensaje.Text = "";
        Label21.Visible = false;
        Ocultar01();
        Desbloquear();
        Button1.Enabled = true;
        lblmensaje.ForeColor = System.Drawing.Color.Black;  
     
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        lblmensaje.Text = "";
        if (!RevisoParaColocarLosMensajesDeRequerido())
        {
            return;
        }
        ///----------

        DateTime fecha1 = DateTime.Now;
        cls_Poli_Usuario01 xusu = new cls_Poli_Usuario01(0, "", "", "", "", "", "", fecha1, false);
        if (xusu.existeUsuario(TextBox5.Text))
        {
            lblmensaje.ForeColor = System.Drawing.Color.Red;  
            lblmensaje.Text = "Lo siento. El Empleado ya estaba registrado. Favor revise e intente de nuevo!!.";
            return;
        }
        xusu.Nombre = TextBox1.Text;
        xusu.Cargo = "Ventas";  //DropDownList1.SelectedValue;
        xusu.Email = TextBox2.Text;
        xusu.Telefono = TextBox3.Text;
       // xusu.Fecha_contratacion = Convert.ToDateTime(String.Format("{0:yyyy/M/d}", DateTime.Now.ToString()));
        xusu.Fecha_contratacion = Convert.ToDateTime(String.Format("{0:yyyy/M/d}", TextBox4.Text));
       // xusu.Fecha_contratacion = Convert.ToDateTime(TextBox4.Text);
        xusu.Usuario = TextBox5.Text;
        xusu.Password = TextBox6.Text;
        xusu.Activo = true;
        xusu.agregar();

        ///------------

        lblmensaje.Text="Registro satsfactorio!!";
        Label21.Visible = true;
        bloquear();
        Button1.Enabled = false;
        TextBox5.Focus();

        
    }


    private void blanquear()
    {
        TextBox1.Text = "";
        DropDownList1.SelectedValue = "0";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    }


    private void bloquear()
    {
        TextBox1.Enabled = false;
        DropDownList1.Enabled = false;
        TextBox2.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;
        TextBox6.Enabled = false;
    }

    private void Desbloquear()
    {
        TextBox1.Enabled = true;
        DropDownList1.Enabled = true;
        TextBox2.Enabled = true;
        TextBox3.Enabled = true;
        TextBox4.Enabled = true;
        TextBox5.Enabled = true;
        TextBox6.Enabled = true;
    }


    private bool RevisoParaColocarLosMensajesDeRequerido()
    {
        Ocultar01();
        bool sip = true;
        if (TextBox1.Text.Equals(""))  //Nombre
        {
            lblreqNombre.Visible = true;
            sip = false;
        }

        if (DropDownList1.SelectedValue.Equals("0"))  //Rol
        {
            lblreqRol.Visible = true;
            sip = false;
        }
        if (TextBox4.Text.Equals(""))   //Fecha contratación
        {
            lblreqFechaContrat.Visible = true;
            sip = false;
        }
        if (TextBox5.Text.Equals(""))  // Usuario CSABINO
        {
            lblreqUsuario.Visible = true;
            sip = false;
        }

        if (TextBox6.Text.Equals(""))   //password
        {
            lblreqPassw.Visible = true;
            sip = false;
        }

        return sip;
    }

    private void Ocultar01() 
    {
        lblreqNombre.Visible = false;
        lblreqRol.Visible = false;
        lblreqFechaContrat.Visible = false;
        lblreqUsuario.Visible = false;
        lblreqPassw.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        blanquear();
        Ocultar01();
        TextBox5.Focus();
        Label21.Visible = false;
        Desbloquear();
        Button1.Enabled = true;
        lblmensaje.ForeColor = System.Drawing.Color.Black;  
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        blanquear();
        TextBox5.Focus();
        Ocultar01();
        Label21.Visible = false;
        Desbloquear();
        Button1.Enabled = true;
        lblmensaje.ForeColor = System.Drawing.Color.Black;  
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void ImageButton_Click(object sender, ImageClickEventArgs e)
    {

    }
}
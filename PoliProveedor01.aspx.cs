using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PoliProveedor01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox6.Focus();
        Ocultar01();
        Button1.Enabled = true;
        Button3.Enabled = true;

    }

    private void Ocultar01()
    {
        Label21.Visible = false;
        Label22.Visible = false;
        Label24.Visible = false;
        Label25.Visible = false;
        Label26.Visible = false;
        Label28.Visible = false;
    }

    private void blanquear()
    {
        TextBox6.Text = "";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }


    private void bloquear()
    {
        TextBox6.Enabled = false;
        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;
    }

    private void Desbloquear()
    {
        TextBox6.Enabled = true;
        TextBox1.Enabled = true;
        TextBox2.Enabled = true;
        TextBox3.Enabled = true;
        TextBox4.Enabled = true;
        TextBox5.Enabled = true;
    }
    


    private bool RevisoParaColocarLosMensajesDeRequerido()
    {
       Ocultar01();
        bool sip = true;
        if (TextBox6.Text.Equals(""))  //Nombre
        {
            Label28.Visible = true;
            sip = false;
        }

        if (TextBox1.Text.Equals(""))   //Fecha contratación
        {
            Label21.Visible = true;
            sip = false;
        }
        if (TextBox2.Text.Equals(""))  // Usuario CSABINO
        {
            Label22.Visible = true;
            sip = false;
        }

        if (TextBox3.Text.Equals(""))   //password
        {
            Label24.Visible = true;
            sip = false;
        }

        if (TextBox4.Text.Equals(""))   //password
        {
            Label25.Visible = true;
            sip = false;
        }

        if (TextBox5.Text.Equals(""))   //password
        {
            Label26.Visible = true;
            sip = false;
        }

        return sip;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!RevisoParaColocarLosMensajesDeRequerido())
        {
            TextBox6.Focus();
            return;
        }

        //----

        DateTime fecha1 = DateTime.Now;
        cls_Poli_Proveedor01 xusu = new cls_Poli_Proveedor01("", "", "", "", "", "", false);
        if (xusu.existeUsuario(TextBox6.Text))
        {
            lblmensaje.ForeColor = System.Drawing.Color.Red;
            lblmensaje.Text = "Lo siento. El Proveedor ya estaba registrado. Favor revise e intente de nuevo!!.";
            return;
        }
        xusu.Nit = TextBox6.Text;
        xusu.Nombre = TextBox1.Text;
        xusu.Contacto = TextBox2.Text;
        xusu.Telefono = TextBox3.Text;
        xusu.Email = TextBox4.Text;
        // xusu.Fecha_contratacion = Convert.ToDateTime(TextBox4.Text);
        xusu.Direccion = TextBox5.Text;
        xusu.Activo = true;
        xusu.agregar();
        //---


        lblmensaje.Text = "Registro satsfactorio!!";
        bloquear();
        Button1.Enabled = false;
        
        TextBox6.Focus();


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        blanquear();
        Desbloquear();
        TextBox6.Focus();
        lblmensaje.ForeColor = System.Drawing.Color.Black;
        lblmensaje.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        blanquear();
        Desbloquear();
        TextBox6.Focus();
        lblmensaje.ForeColor = System.Drawing.Color.Black;
        lblmensaje.Text = "";
    }
}
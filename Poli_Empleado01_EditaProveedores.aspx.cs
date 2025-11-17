using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Poli_Empleado01_EditaProveedores : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataBind();            
            MultiView1.ActiveViewIndex = 0;  //para la nueva
            //MultiView1.ActiveViewIndex = 0;  //para la nueva
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        lblId.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;
        lblmiNit.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[2].Text;
        txtNombre0.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[3].Text;
        txtcontact0.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[4].Text;
        txttelefono0.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[5].Text;
        txtemail00.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[6].Text;
        txtdirec.Text=GridView1.Rows[GridView1.SelectedIndex].Cells[7].Text;
        txtNombre0.Focus();
        
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
       
        
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        cls_Poli_Proveedor01 xusu = new cls_Poli_Proveedor01("", "", "", "", "", "", false);
        if (xusu.existeUsuario(lblmiNit.Text))
        {
            xusu.Nombre = txtNombre0.Text;
            xusu.Contacto = txtcontact0.Text;
            xusu.Telefono = txttelefono0.Text;
            xusu.Email = txtemail00.Text;
            xusu.Direccion = txtdirec.Text;
            xusu.ActualizarDatos(lblmiNit.Text);
            GridView1.DataBind();
        }
        MultiView1.ActiveViewIndex = 0;

    }
}
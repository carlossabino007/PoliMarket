using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Poli_Empleado01_EditaEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.ActiveViewIndex = 0;  //para la nueva
            //MultiView1.ActiveViewIndex = 0;  //para la nueva
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        lblId.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;
        lblelUsu.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[2].Text;
        txtNombre0.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[3].Text;
        lblcargo.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[4].Text;

        txtemail0.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[5].Text;
        txttelefono0.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[6].Text;
        txtfechacontrat.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[7].Text;
        txtNombre0.Focus();
        
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
       
        
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        DateTime fecha1 = DateTime.Now;
        cls_Poli_Usuario01 xusu = new cls_Poli_Usuario01(0, "", "", "", "", "", "", fecha1, false);
        if (xusu.existeUsuario(lblelUsu.Text))
        {
            xusu.Nombre = txtNombre0.Text;
            xusu.Email = txtemail0.Text;
            xusu.Telefono = txttelefono0.Text;
            xusu.Fecha_contratacion = Convert.ToDateTime(String.Format("{0:yyyy/M/d}", txtfechacontrat.Text));
            xusu.ActualizarDatos(lblelUsu.Text);
            GridView1.DataBind();
        }
        MultiView1.ActiveViewIndex = 0;
    }
}
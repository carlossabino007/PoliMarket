using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Poli_ProductosMain01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //MultiView1.ActiveViewIndex = 0;
            MultiView1.ActiveViewIndex = 0;
            //LimpiarInicial();
            //ObtenerIPNeo();
            //BuscarDatosdelUsuarioLogueadoNeo();
            //txtAsunto.Text = string.Empty;
            
            
        }

      //  lblFechaDelSistema.Text = DateTime.Now.ToString("yyyy-MM-dd");
      //  lblHoraDelSistema.Text = DateTime.Now.ToShortTimeString();
        ///TextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd");
    }


//    private void LimpiarInicial()
//    {
//        txtNumeroID.Text = "";
//        //TextBox8.Text = "";
//        DropDownList2.SelectedIndex = 0;
//        txtGuia.Text = "";
//        TextBox1.Text = "";
//        txtGuia.Focus();


//    }

//    private void ObtenerIPNeo()
//    {
//        string IPaddr = string.Empty;
//        if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDER_FOR"] != null)
//        {
//            IPaddr = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDER_FOR"].ToString();
//        }
//        else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
//        {
//            IPaddr = HttpContext.Current.Request.UserHostAddress;
//        }
//        lblIPDeUsuarioLogueado.Text = IPaddr;
//    }




//    public void BuscarDatosdelUsuarioLogueadoNeo()
//    {
//        DateTime fecha1 = DateTime.Now;
//        DateTime fecha2 = DateTime.Now;
//        cls_CreacionDeUsuarios xx1 = new cls_CreacionDeUsuarios(0, 0, 0, 0, "", "", "", "", "", "", "", "", 0, fecha1, fecha2, "", 0);
//        if (xx1.existePorIP(lblIPDeUsuarioLogueado.Text))
//        {
//            if (xx1.Usuario_estadoDeConexion == 1)
//            {
//                lblusulog.Text = xx1.Usuario_nombre1 + " - " + xx1.Usuario_nombre2 + " " + xx1.Usuario_Apellido1 + " " +

//xx1.Usuario_Apellido2 + "- (" + xx1.Usuario_codigo + ")" + " -  IP de Conexión: " + lblIPDeUsuarioLogueado.Text;
//                lbldocusulogueado.Text = xx1.Usuario_codigo;
//                lblGuardaUsuario.Text = lbldocusulogueado.Text;
//                lblUsuarioaProcesar.Text = lbldocusulogueado.Text;
//                lblrol.Text = xx1.Usuario_RolEnLaEmpresa.ToString();
//                lblParaSeguridadPaciente.Text = lblUsuarioaProcesar.Text;
//            }
//            else
//            {
//                Response.Redirect("~/PaginaInicio.aspx");
//                //lblusulog.Text = "No está esta IP Logueda " + lblIPDeUsuarioLogueado.Text + " . Rev.011";
//                //lblUsuarioaProcesar.Text = "";
//            }
//        }
//        else
//        {
//            Response.Redirect("~/PaginaInicio.aspx");
//            //lblusulog.Text = "No está esta IP Logueda " + lblIPDeUsuarioLogueado.Text + " . Rev.010";
//            //lblUsuarioaProcesar.Text = "";
//        }

//    }



 
 
//    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
//    {
//        string llevarcodigo = GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;  // oficio
//        string llevardescri = GridView1.Rows[GridView1.SelectedIndex].Cells[2].Text;  // usuario
//        string llevarfec = GridView1.Rows[GridView1.SelectedIndex].Cells[3].Text;  // usuario
//        Label59.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[5].Text; // item
//        txtInformacionCliente.Text = llevardescri;
//        Label56.Text = llevarcodigo;
//        Label57.Text = "Archivo creado por: " + llevardescri + " El día (año/mes/dia): " + llevarfec;
        
//        lbltextofiltro.Text = "";
//        lblcodClienteEscogido.Text = llevarcodigo;

//        MultiView1.ActiveViewIndex = 3;

//        //Label25.ForeColor = System.Drawing.Color.Green;
//        //DropDownList1.SelectedValue = llevar;
//        //TextBox7.Text = "";
//        //Activar_CapturasIniciales();
//        DateTime fecha1 = DateTime.Now;
//        DateTime fecha2 = DateTime.Now;
//        cls_tblOficios xy1 = new cls_tblOficios(0, 0, "", "", "", "", "", "", "", fecha1, fecha2, 0,"");
//        string busq = Label56.Text.Trim();
//        if (xy1.existe(busq)) { lblEstad.Text = ""; }
//        else { lblEstad.Text = "!!"; return; }
//        TextBox8.Text = string.Empty;
//        TextBox9.Text = string.Empty;
//        TextBox10.Text = string.Empty;
//        TextBox8.Text = xy1.Encabezado;
//        TextBox9.Text = xy1.Referencia;
//        TextBox10.Text = xy1.Cuerpo;
//        // No estoy teniendo en cuenta el texto la firma en este momento
//        TextBox8Ini.Text = xy1.Encabezado;  //Inicial
//        TextBox9Ini.Text = xy1.Referencia;  //Inicial
//        TextBox10Ini.Text = xy1.Cuerpo;     //Inicial

//        lblMensajeErrorOficio.Text="";
//        // falta trareme la firna
//        // habilito botones
//        TextBox8.Enabled = true;
//        TextBox9.Enabled = true;
//        TextBox10.Enabled = true;
//        ImageButton25.Visible = true;
//        ImageButton23.Visible = true;
//        ImageButton24.Visible = true;
//        Label52.ForeColor = System.Drawing.Color.Black;
//        Label53.ForeColor = System.Drawing.Color.Black;
//        Label54.ForeColor = System.Drawing.Color.Black;


//    }
    
//    protected void Button4_Click(object sender, EventArgs e)
//    {
//        //MultiView1.ActiveViewIndex = 1;
       
//    }

//    protected void Button4_Click2(object sender, EventArgs e)
//    {

//        MultiView1.ActiveViewIndex = 1;
//    }
//    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
//    {
//        DropDownList4.DataBind();
//    }

//    private void ProcesaIni() 
//    {
//        // Los 2 dígitos para el año
//        string year = DateTime.Now.ToString("yy");  //22.23.24,25...

//        // La letra del Oficio
//        string Laletra;
//        if (year.Equals("22")) { Laletra = "G"; }
//        else if (year.Equals("23")) { Laletra = "H"; }
//        else if (year.Equals("24")) { Laletra = "I"; }
//        else if (year.Equals("25")) { Laletra = "J"; }
//        else if (year.Equals("26")) { Laletra = "K"; }
//        else if (year.Equals("27")) { Laletra = "L"; }
//        else if (year.Equals("28")) { Laletra = "M"; }
//        else if (year.Equals("29")) { Laletra = "N"; }
//        else if (year.Equals("30")) { Laletra = "O"; }
//        else if (year.Equals("31")) { Laletra = "P"; }
//        else if (year.Equals("32")) { Laletra = "Q"; }
//        else if (year.Equals("33")) { Laletra = "R"; }
//        else if (year.Equals("34")) { Laletra = "S"; }
//        else if (year.Equals("35")) { Laletra = "T"; }
//        else if (year.Equals("36")) { Laletra = "U"; }
//        else if (year.Equals("37")) { Laletra = "V"; }
//        else if (year.Equals("38")) { Laletra = "W"; }
//        else if (year.Equals("39")) { Laletra = "X"; }
//        else if (year.Equals("40")) { Laletra = "Y"; }
//        else if (year.Equals("41")) { Laletra = "Z"; }

//        else
//        {
//            lblYear.Text = "Lo sentimos. No se puede crear oficio para el año: " + DateTime.Now.ToString("yy") + ". Favor, Contacte al servicio Técnico!.";
//            return;
//        }

//        clsContadoresFormatos xconta = new clsContadoresFormatos(0, 0, 0, 0, 0, 0, 0,0);
//        xconta.LeerContadoresPDF();
//        xconta.Con_Oficios++;
//        int NuevoN = xconta.Con_Oficios;  //Nuevo numero para los Oficios
//        xconta.Con_Actualizar_Con_Oficios();
//        string NuevoNumero = String.Format("{0:000}", NuevoN);
//        string DestinoFinal = (Laletra + '-' + NuevoNumero + '-' + year);
//        lblYear.Text = DestinoFinal;

//        DateTime fecha1 = DateTime.Now;
//        DateTime fecha2 = DateTime.Now;
//        cls_tblOficios xofic = new cls_tblOficios(0, 0, "", "", "", "", "", "", "", fecha1, fecha2, 0, "");
//        xofic.Consecutivo = DestinoFinal;
//        xofic.UsuarioQueCrea = lbldocusulogueado.Text;
//        xofic.IPdondeCrea = lblIPDeUsuarioLogueado.Text;
//        xofic.FechaYHora = Convert.ToDateTime(String.Format("{0:yyyy/M/d HH:mm:ss}", DateTime.Now.ToString()));
//        xofic.Fecha = Convert.ToDateTime(String.Format("{0:yyyy/M/d}", DateTime.Now.ToString()));
//        xofic.Encabezado = "";
//        xofic.Referencia = "";
//        xofic.Cuerpo = "";
//        xofic.Firma = "";
//        xofic.Asunto = txtAsunto.Text;
//        xofic.Estado = 1;  // Activo
//        xofic.EstadoDelOficio = 1;
//        xofic.agregar();  // Agrega El oficio
//        txtAsunto.Text = "";//"Vale...(" + txtAsunto.Text+")";
//        GridView1.DataBind();


//        //MultiView1.ActiveViewIndex = 0;

//    }

//    protected void ProcesaIniValida()
//    {
//        lbltextooltip.Text = "Disponible cuando haya digitado el Asunto del nuevo Oficio a crear!.";
//        GridView1.ToolTip = lbltextooltip.Text;
//        ImageButton14.ToolTip = lbltextooltip.Text;
//        LinkButton4.ToolTip = lbltextooltip.Text;
//        ImageButton15.ToolTip = lbltextooltip.Text;
//        LinkButton5.ToolTip = lbltextooltip.Text;
//        ImageButton19.ToolTip = lbltextooltip.Text;


//        ImageButton14.Enabled = false;
//        ImageButton15.Enabled = false;
//        GridView1.Enabled = false;
//        LinkButton4.Enabled = false;
//        LinkButton5.Enabled = false;

//        Label60.Visible = true;
//        txtAsunto.Visible = true;
//        btnOK.Visible = true;
//        btnCancel.Visible = true;
//        txtAsunto.Focus();



    


//    }


//    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
//    {
//        //ProcesaIni();

//        txtAsunto.Text = "";
//        ProcesaIniValida();
//        if (Label61.Text.Equals("Bad")) { return; }
        
        
//    }
//    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
//    {

//        MetodoOpcion2();
//    }
//    protected void LinkButton4_Click(object sender, EventArgs e)
//    {
//        ////txtAsunto.Text = "";
//        ////ProcesaIniValida();
//        ////if (Label61.Text.Equals("Bad")) { return; }

//        //ProcesaIni();
//        //MultiView1.ActiveViewIndex = 0;
//    }
//    protected void LinkButton5_Click(object sender, EventArgs e)
//    {
//        MetodoOpcion2();
//    }

//    private void MetodoOpcion2()
//    {
//        TextBox17.Enabled = false;
//        TextBox13.Enabled = false;
//        //TextBox14.Enabled = false;
//        //TextBox15.Enabled = false;
//        //TextBox16.Enabled = false;
//        DropDownList5.Enabled = false;
//        DropDownList6.Enabled = false;
//        DropDownList7.Enabled = false;

//        Button7.Visible = false;
//        Button8.Visible = false;
//        TextBox17.Text = "";

//        MultiView1.ActiveViewIndex = 2;
//        ImageButton40.Visible = false;
//        Label65.Text = "";
//        ocultarBotones();
//        lblOpcionSeleccionada.Text = "";
//    }

//    protected void Button5_Click(object sender, EventArgs e)
//    {
//        MultiView1.ActiveViewIndex = 1;
//    }
//    protected void LinkButton8_Click(object sender, EventArgs e)
//    {

//    }
//    protected void ImageButton27_Click(object sender, ImageClickEventArgs e)
//    {
//        Label52.ForeColor = System.Drawing.Color.Black;
//        Label53.ForeColor = System.Drawing.Color.Black;
//        Label54.ForeColor = System.Drawing.Color.Black;

//        int error = 0;
//        if (!TextBox8.Text.Equals(TextBox8Ini.Text)) 
//        {
//            Label52.ForeColor = System.Drawing.Color.Red;
//            error = 1;
//        }
//        if (!TextBox9.Text.Equals(TextBox9Ini.Text))
//        {
//            Label53.ForeColor = System.Drawing.Color.Red;
//            error = 1;
//        }
//        if (!TextBox10.Text.Equals(TextBox10Ini.Text))
//        {
//            Label54.ForeColor = System.Drawing.Color.Red;
//            error = 1;
//        }

//        if (error > 0) { return; }

//        MultiView1.ActiveViewIndex = 1;
//        GridView1.DataBind();
//        ImageButton25.Visible = true;
//        ImageButton23.Visible = true;
//        ImageButton24.Visible = true;
//        txtAsunto.Text = "";
//    }
//    protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
//    {
//        DateTime fecha1 = DateTime.Now;
//        DateTime fecha2 = DateTime.Now;
//        cls_tblOficios xy = new cls_tblOficios(0, 0, "", "", "", "", "", "", "", fecha1, fecha2, 0,"");
//        string busq = Label56.Text.Trim();
//        if (xy.existe(busq)) { lblEstad.Text = ""; }
//        else { lblEstad.Text = "!!"; return; }
//        xy.Encabezado = TextBox8.Text;
//        xy.Referencia = TextBox9.Text;
//        xy.Cuerpo = TextBox10.Text;
//        xy.Firma = "";
//        xy.EstadoDelOficio = 1; // 1 borrador -  2 grabado y cerrado
//        xy.actualizaTodo(busq);

//        Label52.ForeColor = System.Drawing.Color.Black;
//        Label53.ForeColor = System.Drawing.Color.Black;
//        Label54.ForeColor = System.Drawing.Color.Black;

//        TextBox8Ini.Text= TextBox8.Text;
//        TextBox9Ini.Text = TextBox9.Text;
//        TextBox10Ini.Text = TextBox10.Text;
     

//    }
//    protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
//    {


//        TextBox8.Enabled = true;
//        TextBox9.Enabled = true;
//        TextBox10.Enabled = true;

//        lblMensajeErrorOficio.Text="";
//        int error = 0;
//        Label52.ForeColor = System.Drawing.Color.Black;
//        Label53.ForeColor = System.Drawing.Color.Black;
//        Label54.ForeColor = System.Drawing.Color.Black;
//        if (TextBox8.Text == string.Empty)  {Label52.ForeColor = System.Drawing.Color.Red;error = 1; }
//        if (TextBox9.Text == string.Empty) { Label53.ForeColor = System.Drawing.Color.Red; error = 2; }
//        if (TextBox10.Text == string.Empty) { Label54.ForeColor = System.Drawing.Color.Red; error = 3; }
//        if (error == 1 || error == 2 || error == 3) { return; }

//        DateTime fecha1 = DateTime.Now;
//        DateTime fecha2 = DateTime.Now;
//        cls_tblOficios xy = new cls_tblOficios(0, 0, "", "", "", "", "", "", "", fecha1, fecha2, 0,"");
//        string busq = Label56.Text.Trim();
//        if (xy.existe(busq)) { lblEstad.Text = ""; }
//        else { lblEstad.Text = "!!"; return; }
//        xy.Encabezado = TextBox8.Text;
//        xy.Referencia = TextBox9.Text;
//        xy.Cuerpo = TextBox10.Text;
//        xy.Firma = "";
//        xy.EstadoDelOficio = 2; // 1 borrador -  2 grabado y cerrado
//        xy.actualizaTodo(busq);
//        lblMensajeErrorOficio.Text = "Oficio Grabado y Cerrado con Exito!";

//        TextBox8.Enabled = false;
//        TextBox9.Enabled = false;
//        TextBox10.Enabled = false;
//        ImageButton25.Visible = false;
//        ImageButton23.Visible = false;
//        ImageButton24.Visible = false;
//        GridView1.DataBind();
//        TextBox8Ini.Text = TextBox8.Text;
//        TextBox9Ini.Text = TextBox9.Text;
//        TextBox10Ini.Text = TextBox10.Text;


//    }
//    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
//    {
//        GridView1.DataBind(); 
//    }

//    protected void Unifica() 
//    {
//        TextBox8Ini.Text = TextBox8.Text;
//        TextBox9Ini.Text = TextBox9.Text;
//        TextBox10Ini.Text = TextBox10.Text;

//    }
//    protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
//    {
        
//        Unifica();
//        DateTime fecha1 = DateTime.Now;
//        DateTime fecha2 = DateTime.Now;
//        cls_tblOficios xy = new cls_tblOficios(0, 0, "", "", "", "", "", "", "", fecha1, fecha2, 0,"");
//        string busq = Label56.Text.Trim();
//        if (xy.existe(busq)) { lblEstad.Text = ""; }
//        else { lblEstad.Text = "!!"; return; }
//        xy.Encabezado = TextBox8.Text;
//        xy.Referencia = TextBox9.Text;
//        xy.Cuerpo = TextBox10.Text;
//        xy.Firma = "";
//        //xy.EstadoDelOficio = 1; // 1 borrador -  2 grabado y cerrado
//        xy.actualizaTodoSinEstadoDelOficio(busq);



        
//        BuscarDatosdelUsuarioLogueadoNeo();
//        string f1 = Label56.Text;
//        Response.Redirect("~/pageOficiosmain_ImpresoraPDFCerrado.aspx?f1=" + f1);
//        lblmoduloSeleccionado.Text = " Oficio- ";
//        lblAccionRealizada.Text = "CrearOficio";

//        BuscarDatosdelUsuarioLogueadoNeo();
//        GrabarElEvento();
//        //lblNombreDelArchivo.Text = "~/Formatos_de_laboratorio.PDF/Inmunogenetica/R-HLA-007_Resultado_de_cuantificacion_de_ADN_y_calculos_para_la_concentracion_decuada.pdf";
//        //TomaArchivo();

//    }


//    private void GrabarElEvento()
//    {
//        DateTime cad1 = DateTime.Now;
//        DateTime cad2 = DateTime.Now;
//        cls_AuditoriaFormatosPDF xx1 = new cls_AuditoriaFormatosPDF(0, "", "", "", cad1, cad2, "", "");
//        try
//        {
//            //xx1.UsuLogueado_IP = cls_UsuarioLogueado.IPDeUsuarioLogueado;

//            xx1.UsuLogueado_CodigoUsuario = lbldocusulogueado.Text;
//            xx1.UsuLogueado_IP = lblIPDeUsuarioLogueado.Text;
//            xx1.UsuLogueado_FormatoSeleccionado = lblmoduloSeleccionado.Text;
//            xx1.UsuLogueado_FechayHora = Convert.ToDateTime(String.Format("{0:yyyy/M/d HH:mm:ss}", DateTime.Now.ToString()));
//            xx1.UsuLogueado_FechaSolamente = Convert.ToDateTime(String.Format("{0:yyyy/M/d}", DateTime.Now.ToString()));

//            xx1.UsuLogueado_FechaSolamente = Convert.ToDateTime(String.Format("{0:yyyy/M/d}", DateTime.Now.ToString()));
//            xx1.UsuLogueado_FechaenString = DateTime.Now.ToString("yyyy-MM-dd");
//            xx1.UsuLogueado_AccionRealizada = lblAccionRealizada.Text;
//            xx1.agregar();
//        }
//        catch
//        {
//            lblUsuarioaProcesar.Text = "Err02 al regitrar El Evento";
//        }

//    }
//    protected void ImageButton29_Click(object sender, ImageClickEventArgs e)
//    {
//        MultiView1.ActiveViewIndex = 1;
//        ImageButton25.Visible = true;
//        ImageButton23.Visible = true;
//        ImageButton24.Visible = true;
//        txtAsunto.Text = "";
//        GridView1.DataBind();
//    }
//    protected void txtAsunto_TextChanged(object sender, EventArgs e)
//    {
        
//    }
//    protected void btnCancel_Click(object sender, EventArgs e)
//    {

//        lbltextooltip.Text = "";
//        GridView1.ToolTip = lbltextooltip.Text;
//        ImageButton14.ToolTip = lbltextooltip.Text;
//        LinkButton4.ToolTip = lbltextooltip.Text;
//        ImageButton15.ToolTip = lbltextooltip.Text;
//        LinkButton5.ToolTip = lbltextooltip.Text;
//        ImageButton19.ToolTip = lbltextooltip.Text;

//        ImageButton14.Enabled = true;
//        ImageButton15.Enabled = true;
//        GridView1.Enabled = true;
//        LinkButton4.Enabled = true;
//        LinkButton5.Enabled = true;

//        Label60.Visible = false;
//        txtAsunto.Visible = false;
//        btnOK.Visible = false;
//        btnCancel.Visible = false;
//        txtAsunto.Text = "";
//    }
//    protected void btnOK_Click(object sender, EventArgs e)
//    {
        
//        if (txtAsunto.Text.Trim().Equals(""))
//        {
//            Label62.Text = "aca1";
//            Label63.Text = txtAsunto.Text;
//            Label61.Text = "Bad";
//            txtAsunto.Focus();
//            return;
//        }
//        else
//        {

//            Label62.Text = "aca2" + "Asunto vale en este momento: "+ txtAsunto.Text;
//            Label61.Text = "Good";
//            lbltextooltip.Text = "";
//            GridView1.ToolTip = lbltextooltip.Text;
//            ImageButton14.ToolTip = lbltextooltip.Text;
//            LinkButton4.ToolTip = lbltextooltip.Text;
//            ImageButton15.ToolTip = lbltextooltip.Text;
//            LinkButton5.ToolTip = lbltextooltip.Text;
//            ImageButton19.ToolTip = lbltextooltip.Text;
//            Label61.Text = Label61.Text.Trim();

//            txtAsunto.Visible = true;
            
//            ProcesaIni();
            
//            Label60.Visible = false;
//            txtAsunto.Visible = false;
//            btnOK.Visible = false;
//            btnCancel.Visible = false;
//            ImageButton14.Enabled = true;
//            ImageButton15.Enabled = true;
//            GridView1.Enabled = true;
//            LinkButton4.Enabled = true;
//            LinkButton5.Enabled = true;
//            Label61.Text = "Bad";
//            txtAsunto.Text = "";
//            Response.Redirect("pageOficiosmain.aspx");
//            ///MultiView1.ActiveViewIndex = 3;

//        }



//    }
//    protected void ImageButton36_Click(object sender, ImageClickEventArgs e)
//    {

//    }
//    protected void LinkButton11_Click(object sender, EventArgs e)
//    {

//        //Label64.Text = "Digite el Código del Oficio a Consultar:";
//        DesactivarCajas();
//        ocultarBotones();
//        TextBox13.Enabled = true;
//        TextBox13.Text = "";
//        TextBox13.Focus();
        
//        lblOpcionSeleccionada.Text = "1";
//    }
//    protected void LinkButton12_Click(object sender, EventArgs e)
//    {
//        DesactivarCajas();
//        Label64.Text = "Digite texto a buscar en la Cabecera:";
//        TextBox11.Enabled = true;
//        TextBox11.Text = "";
//        TextBox11.Focus();
//        lblOpcionSeleccionada.Text = "2";
        
//        TextBox18.Text = "";
//        TextBox18.Enabled = true;
//        TextBox18.Focus();

//    }
//    protected void LinkButton19_Click(object sender, EventArgs e)
//    {
//        DesactivarCajas();
//        Label64.Text = "Digite texto a buscar en la Referencia:";
//        TextBox11.Enabled = true;
//        TextBox11.Text = "";
//        TextBox11.Focus();
//        lblOpcionSeleccionada.Text = "3";
//        TextBox19.Text = "";
//        TextBox19.Enabled = true;
//        TextBox19.Focus();
//    }
//    protected void LinkButton20_Click(object sender, EventArgs e)
//    {
//        DesactivarCajas();
//        Label64.Text = "Digite texto a buscar en el Cuerpo del Oficio:";
//        TextBox11.Enabled = true;
//        TextBox11.Text = "";
//        TextBox11.Focus();
//        lblOpcionSeleccionada.Text = "4";
//        TextBox20.Text = "";
//        TextBox20.Enabled = true;
//        TextBox20.Focus();
//    }
//    protected void TextBox11_TextChanged(object sender, EventArgs e)
//    {

//    }
//    protected void LinkButton21_Click(object sender, EventArgs e)
//    {
//        TextBox11.Enabled = false;
//        TextBox11.Text = "";
//        MultiView1.ActiveViewIndex = 1;
//    }
//    protected void LinkButton18_Click(object sender, EventArgs e)
//    {
////        Label64.Text = "Digite el Código del Oficio que desea Abrir:";
//        //TextBox11.Enabled = true;
//        //TextBox11.Text = "";
//        //TextBox11.Focus();
//        TextBox17.Enabled = true;
//        TextBox17.Focus();
//    }

//    protected void DesactivasControles()
//    {
//        Button7.Visible = true;
//        Button8.Visible = true;
//        TextBox17.Enabled = true;
//        TextBox17.Focus();
//    }


//    protected void Button7_Click(object sender, EventArgs e)
//    {
//        Mirarx();
//        //TextBox17ParaFiltrar.Text = TextBox17.Text;
//        //ImageButton40.Visible = true;
//        //Label65.Text = "";
//    }
//    protected void TextBox17_TextChanged(object sender, EventArgs e)
//    {
//        TextBox17ParaFiltrar.Text = TextBox17.Text;
//    }
//    protected void LinkButton22_Click(object sender, EventArgs e)
//    {
//        DesactivarCajas();
//        ocultarBotones();
//        Label65.Text = "";
//        Button7.Visible = true;
//        Button8.Visible = true;
//        TextBox17.Enabled = true;
//        TextBox17.Focus();
//        lblOpcionSeleccionada.Text = "7";
        
//    }
//    protected void TextBox17_TextChanged1(object sender, EventArgs e)
//    {
//        Mirarx();
//    }

//    protected void Mirarx()
//    {
        
//        ImageButton40.Visible = false;
//        Label65.Text = "";
//        DateTime fecha1 = DateTime.Now;
//        DateTime fecha2 = DateTime.Now;
//        cls_tblOficios xy1 = new cls_tblOficios(0, 0, "", "", "", "", "", "", "", fecha1, fecha2, 0, "");
//        string busq = TextBox17.Text.Trim();
//        Label65.Visible = true;

//        if (xy1.existe(busq))
//        {
//            if (xy1.EstadoDelOficio == 1) { Label65.Text = "El Oficio " + TextBox17.Text + " Actualmente está activo y se puede editar!"; return; }
//            else { ImageButton40.Visible = true; }
//        }
//        else
//        {
//            Label65.Text = "El Oficio " + TextBox17.Text + " que está consultando, no aparece registrado en el sistema!!"; return;
//        }

//    }
//    protected void Button8_Click(object sender, EventArgs e)
//    {
//        TextBox17ParaFiltrar.Text = TextBox17.Text;
//        ImageButton40.Visible = false;
//        Button7.Visible = false;
//        Button8.Visible = false;
//        TextBox17.Enabled = false;
//        TextBox17.Text="";
//        TextBox17ParaFiltrar.Text = "";
//        Label65.Text = "";

//        //TextBox17.Focus();


//    }
//    protected void ImageButton40_Click(object sender, ImageClickEventArgs e)
//    {
//        Label65.Visible = false;
//        ImageButton40.Visible = false;
//        Label65.Text = "";
//        DateTime fecha1 = DateTime.Now;
//        DateTime fecha2 = DateTime.Now;
//        cls_tblOficios xy1 = new cls_tblOficios(0, 0, "", "", "", "", "", "", "", fecha1, fecha2, 0, "");
//        string busq = TextBox17.Text.Trim();
//        Label65.Visible = false;
//        if (!xy1.existe(busq))
//        {
//            Label65.Text = "El Oficio " + TextBox17.Text + " que está consultando, no aparece registrado en el sistema!!"; return; 
//        }
//        xy1.EstadoDelOficio = 1;
//        xy1.actualizarEstadoDelOficio(TextBox17.Text);
//        Label65.Visible = true;
//        ImageButton40.Visible = false;
//        Button8.Visible = false;
//        Button7.Visible = false;
//        TextBox17.Enabled = false;
//        Label65.Text = "A partir de este momento, El Oficio No." + TextBox17.Text + " Actualmente está activo y se puede editar!";
//        TextBox17.Text = "";
//        GridView1.DataBind();
//    }

//    protected void DesactivarCajas()
//    {
//        TextBox13.Text = "";
//        TextBox13.Enabled = false;
//        ImageButton41.Visible = false;
//        TextBox18.Text = "";
//        TextBox18.Enabled = false;
//        TextBox19.Enabled = false;
//        TextBox19.Enabled = false;
//        TextBox20.Enabled = false;
//        TextBox20.Enabled = false;
//        DropDownList5.Enabled = false;
//        DropDownList5.SelectedValue = "0";
//        DropDownList5.SelectedValue = "0";
//        DropDownList6.Enabled = false;
//        DropDownList6.SelectedValue = "0";
//        DropDownList7.Enabled = false;
//        DropDownList7.SelectedValue = "0";
//        TextBox17.Enabled = false;
//        TextBox17.Enabled = false;
//        TextBox17.Text = "";
//        Label65.Text = ""; // MENSAJES
//        Button7.Visible = false;
//        Button8.Visible = false;
//        ImageButton40.Visible = false;





//    }

//    protected void ocultarBotones()
//    {
//        Label65.Text = "";
//        //Reabrir Oficio
//        TextBox17.Text = "";
//        TextBox17.Enabled = false;
//        ImageButton40.Visible = false;
//        Button8.Visible = false;
//        Button7.Visible = false;

//        // Consultar por el Código del Oficio
//        TextBox13.Enabled = false;
//        TextBox13.Text = "";
//        ImageButton41.Visible = false;


//    }

//    protected void TextBox13_TextChanged(object sender, EventArgs e)
//    {
//        ImageButton41.Visible = true;
        
//        MirarOpcion1();
//    }

//    protected void MirarOpcion1()  //Consultar por el Código del Oficio
//    {
//        ImageButton40.Visible = false;
//        Label65.Text = "";
//        DateTime fecha1 = DateTime.Now;
//        DateTime fecha2 = DateTime.Now;
//        cls_tblOficios xy1 = new cls_tblOficios(0, 0, "", "", "", "", "", "", "", fecha1, fecha2, 0, "");
//        string busq = TextBox13.Text.Trim();
//        Label65.Visible = true;

//        if (xy1.existe(busq))
//        {
//            if (xy1.EstadoDelOficio == 1) { ImageButton41.Visible = false; Label65.Text = "El Oficio " + TextBox13.Text + " Actualmente se encuentra para editar!. Sólo se pueden consultar por esta opción Los Oficios que estén ya cerrados!. Para ver el Preliminar de este Oficio diríjase a donde están los oficios que se encuentran en edición!."; TextBox13.Focus(); return; }
//else
//{
//    ImageButton41.Visible = true;

//}
//        }
//        else { Label65.Text = "El Oficio " + TextBox13.Text + " que está consultando, no aparece registrado en el sistema!!"; ImageButton41.Visible = false; TextBox13.Focus(); return; }

//    }
//    //protected void ImageButton41_Click(object sender, ImageClickEventArgs e)
//    //{
//    //    DateTime fecha1 = DateTime.Now;
//    //    DateTime fecha2 = DateTime.Now;
//    //    cls_tblOficios xy = new cls_tblOficios(0, 0, "", "", "", "", "", "", "", fecha1, fecha2, 0, "");
//    //    string busq = TextBox13.Text.Trim();
//    //    if (!xy.existe(busq)) { ImageButton41.Visible = false; return; }
//    //    BuscarDatosdelUsuarioLogueadoNeo();
//    //    string f1 = TextBox13.Text;
//    //    Response.Redirect("~/pageOficiosmain_ImpresoraPDFCerrado.aspx?f1=" + f1);
//    //    lblmoduloSeleccionado.Text = " Oficio- ";
//    //    lblAccionRealizada.Text = "ConsultOfic";

//    //    BuscarDatosdelUsuarioLogueadoNeo();
//    //    GrabarElEvento();
//    //    //lblNombreDelArchivo.Text = "~/Formatos_de_laboratorio.PDF/Inmunogenetica/R-HLA-007_Resultado_de_cuantificacion_de_ADN_y_calculos_para_la_concentracion_decuada.pdf";
//    //    //TomaArchivo();

//    //}
//    protected void LinkButton16_Click(object sender, EventArgs e)
//    {
//        DesactivarCajas();
//        DropDownList5.Enabled = true;
//        lblOpcionSeleccionada.Text = "5";
//    }
//    protected void LinkButton13_Click(object sender, EventArgs e)
//    {
//        DesactivarCajas();
//        DropDownList6.Enabled = true;
//        DropDownList7.Enabled = true;
//        lblOpcionSeleccionada.Text = "6";
//    }
//    protected void LinkButton14_Click(object sender, EventArgs e)
//    {
//        DesactivarCajas();
//        lblOpcionSeleccionada.Text = "7";
//    }
//    protected void LinkButton15_Click(object sender, EventArgs e)
//    {
//        DesactivarCajas();
//        lblOpcionSeleccionada.Text = "8";
//    }


    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        GridView1.DataBind();
    }
    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {

    }
    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        TextBox2.Focus();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de cls_V_CapturaDatosSolicitudCotizacion
/// </summary>
public class cls_V_CapturaDatosSolicitudCotizacion: clsconexion
{
    string tabla = "tbl_V_CapturaDatosSolicitudCotizacion";

    protected int id_Cotizacion;
    protected int id_NumCotizacionSegun_ContadorFormatosFK;
    protected int cotiz_CodClienteCotizanteFK;
    protected DateTime cotiz_FechayHora_RegistroEnElSistema;
    protected DateTime cotiz_Fecha_RegistroEnElSistema;
    protected string cotiz_FechaEnString_RegistroEnElSistema;
    protected int cotiz_CorreoAlCualSolicitaLaCotizacionFK;
    protected string cotiz_CorreoDesdeDondeenviaronLaSolicitud;
    protected int cotiz_Correo_Texto_DctoReceptorClienteFK;
    protected int cotiz_Correo_Texto_FormaDePagoFK;
    protected int cotiz_Correo_Texto_ValidaPorNDiasFK;
    protected string cotiz_Correo_UsuarioQueRegistra;
    protected string cotiz_Correo_IP;
    protected DateTime cotiz_Correo_FechaSolamente_DelSolicitante;
    protected DateTime cotiz_Correo_FechaYHora_DelSolicitante;
    protected string cotiz_Correo_FechaEnString_DelSolicitante;
    protected int cotiz_Correo_Estado;
    protected string cotiz_CorreoAsunto;

    protected string cotiz_Correo_UsuarioQueAnula;
    protected DateTime cotiz_Correo_UsuarioQueAnula_FechaSolamente;
    protected DateTime cotiz_Correo_UsuarioQueAnula_FechaYHora;
    protected string cotiz_Correo_UsuarioQueAnula_FechaString;
    protected string cotiz_Correo_UsuarioQueAnula_Razon;
    protected string cotiz_Correo_UsuarioQueAnula_IP;

    protected string cotiz_Correo_Observacion;

    // Constructor
	public cls_V_CapturaDatosSolicitudCotizacion
    (
    int id_Cotizacion, int id_NumCotizacionSegun_ContadorFormatosFK, int cotiz_CodClienteCotizanteFK, DateTime cotiz_FechayHora_RegistroEnElSistema, DateTime cotiz_Fecha_RegistroEnElSistema, string cotiz_FechaEnString_RegistroEnElSistema,
    int cotiz_CorreoAlCualSolicitaLaCotizacionFK, string cotiz_CorreoDesdeDondeenviaronLaSolicitud, int cotiz_Correo_Texto_DctoReceptorClienteFK, int cotiz_Correo_Texto_FormaDePagoFK, int cotiz_Correo_Texto_ValidaPorNDiasFK, string cotiz_Correo_UsuarioQueRegistra,
    string cotiz_Correo_IP, DateTime cotiz_Correo_FechaSolamente_DelSolicitante, DateTime cotiz_Correo_FechaYHora_DelSolicitante, string cotiz_Correo_FechaEnString_DelSolicitante, int cotiz_Correo_Estado, string cotiz_CorreoAsunto,
    string cotiz_Correo_UsuarioQueAnula, DateTime cotiz_Correo_UsuarioQueAnula_FechaSolamente, DateTime cotiz_Correo_UsuarioQueAnula_FechaYHora, string cotiz_Correo_UsuarioQueAnula_FechaString, string cotiz_Correo_UsuarioQueAnula_Razon, string cotiz_Correo_UsuarioQueAnula_IP, string cotiz_Correo_Observacion)
	{
    this.id_Cotizacion = id_Cotizacion;
    this.id_NumCotizacionSegun_ContadorFormatosFK = id_NumCotizacionSegun_ContadorFormatosFK;
    this.cotiz_CodClienteCotizanteFK = cotiz_CodClienteCotizanteFK;
    this.cotiz_FechayHora_RegistroEnElSistema = cotiz_FechayHora_RegistroEnElSistema;
    this.cotiz_Fecha_RegistroEnElSistema = cotiz_Fecha_RegistroEnElSistema;
    this.cotiz_FechaEnString_RegistroEnElSistema = cotiz_FechaEnString_RegistroEnElSistema;
    this.cotiz_CorreoAlCualSolicitaLaCotizacionFK = cotiz_CorreoAlCualSolicitaLaCotizacionFK;
    this.cotiz_CorreoDesdeDondeenviaronLaSolicitud = cotiz_CorreoDesdeDondeenviaronLaSolicitud;
    this.cotiz_Correo_Texto_DctoReceptorClienteFK = cotiz_Correo_Texto_DctoReceptorClienteFK;
    this.cotiz_Correo_Texto_FormaDePagoFK = cotiz_Correo_Texto_FormaDePagoFK;
    this.cotiz_Correo_Texto_ValidaPorNDiasFK = cotiz_Correo_Texto_ValidaPorNDiasFK;
    this.cotiz_Correo_UsuarioQueRegistra = cotiz_Correo_UsuarioQueRegistra;
    this.cotiz_Correo_IP = cotiz_Correo_IP;
    this.cotiz_Correo_FechaSolamente_DelSolicitante = cotiz_Correo_FechaSolamente_DelSolicitante;
    this.cotiz_Correo_FechaYHora_DelSolicitante = cotiz_Correo_FechaYHora_DelSolicitante;
    this.cotiz_Correo_FechaEnString_DelSolicitante = cotiz_Correo_FechaEnString_DelSolicitante;
    this.cotiz_Correo_Estado = cotiz_Correo_Estado;
    this.cotiz_CorreoAsunto = cotiz_CorreoAsunto;
    

    this.cotiz_Correo_UsuarioQueAnula = cotiz_Correo_UsuarioQueAnula;
    this.cotiz_Correo_UsuarioQueAnula_FechaSolamente = cotiz_Correo_UsuarioQueAnula_FechaSolamente;
    this.cotiz_Correo_UsuarioQueAnula_FechaYHora = cotiz_Correo_UsuarioQueAnula_FechaYHora;
    this.cotiz_Correo_UsuarioQueAnula_FechaString = cotiz_Correo_UsuarioQueAnula_FechaString;
    this.cotiz_Correo_UsuarioQueAnula_Razon = cotiz_Correo_UsuarioQueAnula_Razon;
    this.cotiz_Correo_UsuarioQueAnula_IP = cotiz_Correo_UsuarioQueAnula_IP;

    this.cotiz_Correo_Observacion = cotiz_Correo_Observacion;
	}


    public int Id_Cotizacion
    {
        set { id_Cotizacion = value; }
        get { return id_Cotizacion; }
    }

    public int Id_NumCotizacionSegun_ContadorFormatosFK
    {
        set { id_NumCotizacionSegun_ContadorFormatosFK = value; }
        get { return id_NumCotizacionSegun_ContadorFormatosFK; }
    }

        
    public int Cotiz_CodClienteCotizanteFK
    {
        set { cotiz_CodClienteCotizanteFK = value; }
        get { return cotiz_CodClienteCotizanteFK; }
    }

    public DateTime Cotiz_FechayHora_RegistroEnElSistema
    {
        set { cotiz_FechayHora_RegistroEnElSistema = value; }
        get { return cotiz_FechayHora_RegistroEnElSistema; }
    }

    public DateTime Cotiz_Fecha_RegistroEnElSistema
    {
        set { cotiz_Fecha_RegistroEnElSistema = value; }
        get { return cotiz_Fecha_RegistroEnElSistema; }
    }

    public string Cotiz_FechaEnString_RegistroEnElSistema
    {
        set { cotiz_FechaEnString_RegistroEnElSistema = value; }
        get { return cotiz_FechaEnString_RegistroEnElSistema; }
    }

    public int Cotiz_CorreoAlCualSolicitaLaCotizacionFK
    {
        set { cotiz_CorreoAlCualSolicitaLaCotizacionFK = value; }
        get { return cotiz_CorreoAlCualSolicitaLaCotizacionFK; }
    }

    public string Cotiz_CorreoDesdeDondeenviaronLaSolicitud
    {
        set { cotiz_CorreoDesdeDondeenviaronLaSolicitud = value; }
        get { return cotiz_CorreoDesdeDondeenviaronLaSolicitud; }
    }

    public int Cotiz_Correo_Texto_DctoReceptorClienteFK
    {
        set { cotiz_Correo_Texto_DctoReceptorClienteFK = value; }
        get { return cotiz_Correo_Texto_DctoReceptorClienteFK; }
    }

    public int Cotiz_Correo_Texto_FormaDePagoFK
    {
        set { cotiz_Correo_Texto_FormaDePagoFK = value; }
        get { return cotiz_Correo_Texto_FormaDePagoFK; }
    }

    public int Cotiz_Correo_Texto_ValidaPorNDiasFK
    {
        set { cotiz_Correo_Texto_ValidaPorNDiasFK = value; }
        get { return cotiz_Correo_Texto_ValidaPorNDiasFK; }
    }

    public string Cotiz_Correo_UsuarioQueRegistra
    {
        set { cotiz_Correo_UsuarioQueRegistra = value; }
        get { return cotiz_Correo_UsuarioQueRegistra; }
    }

    public string Cotiz_Correo_IP
    {
        set { cotiz_Correo_IP = value; }
        get { return cotiz_Correo_IP; }
    }

    public DateTime Cotiz_Correo_FechaSolamente_DelSolicitante
    {
        set { cotiz_Correo_FechaSolamente_DelSolicitante = value; }
        get { return cotiz_Correo_FechaSolamente_DelSolicitante; }
    }

    public DateTime Cotiz_Correo_FechaYHora_DelSolicitante
    {
        set { cotiz_Correo_FechaYHora_DelSolicitante = value; }
        get { return cotiz_Correo_FechaYHora_DelSolicitante; }
    }


    public string Cotiz_Correo_FechaEnString_DelSolicitante
    {
        set { cotiz_Correo_FechaEnString_DelSolicitante = value; }
        get { return cotiz_Correo_FechaEnString_DelSolicitante; }
    }

    public int Cotiz_Correo_Estado
    {
        set { cotiz_Correo_Estado = value; }
        get { return cotiz_Correo_Estado; }
    }

    public string Cotiz_CorreoAsunto
    {
        set { cotiz_CorreoAsunto = value; }
        get { return cotiz_CorreoAsunto; }
    }


    public string Cotiz_Correo_UsuarioQueAnula
    {
        set { cotiz_Correo_UsuarioQueAnula = value; }
        get { return cotiz_Correo_UsuarioQueAnula; }
    }


        public DateTime Cotiz_Correo_UsuarioQueAnula_FechaSolamente
    {
        set { cotiz_Correo_UsuarioQueAnula_FechaSolamente = value; }
        get { return cotiz_Correo_UsuarioQueAnula_FechaSolamente; }
    }

         public DateTime Cotiz_Correo_UsuarioQueAnula_FechaYHora
    {
        set { cotiz_Correo_UsuarioQueAnula_FechaYHora = value; }
        get { return cotiz_Correo_UsuarioQueAnula_FechaYHora; }
    }

    public string Cotiz_Correo_UsuarioQueAnula_FechaString
    {
        set { cotiz_Correo_UsuarioQueAnula_FechaString = value; }
        get { return cotiz_Correo_UsuarioQueAnula_FechaString; }
    }


    public string Cotiz_Correo_UsuarioQueAnula_Razon
    {
      set { cotiz_Correo_UsuarioQueAnula_Razon = value; }
      get { return cotiz_Correo_UsuarioQueAnula_Razon; }
    }

    public string Cotiz_Correo_UsuarioQueAnula_IP
    {
        set { cotiz_Correo_UsuarioQueAnula_IP = value; }
        get { return cotiz_Correo_UsuarioQueAnula_IP; }
    }

    public string Cotiz_Correo_Observacion
    {
        set { cotiz_Correo_Observacion = value; }
        get { return cotiz_Correo_Observacion; }
    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["id_NumCotizacionSegun_ContadorFormatosFK"].ToString()) == valor)
            {
                Id_Cotizacion = int.Parse(fila["id_Cotizacion"].ToString());
                Id_NumCotizacionSegun_ContadorFormatosFK = int.Parse(fila["id_NumCotizacionSegun_ContadorFormatosFK"].ToString());
                Cotiz_CodClienteCotizanteFK = int.Parse(fila["cotiz_CodClienteCotizanteFK"].ToString());
                Cotiz_FechayHora_RegistroEnElSistema = DateTime.Parse(fila[("cotiz_FechayHora_RegistroEnElSistema")].ToString());
                Cotiz_Fecha_RegistroEnElSistema = DateTime.Parse(fila[("cotiz_Fecha_RegistroEnElSistema")].ToString());
                Cotiz_FechaEnString_RegistroEnElSistema = fila["cotiz_FechaEnString_RegistroEnElSistema"].ToString();
                Cotiz_CorreoAlCualSolicitaLaCotizacionFK = int.Parse(fila["cotiz_CorreoAlCualSolicitaLaCotizacionFK"].ToString());
                Cotiz_CorreoDesdeDondeenviaronLaSolicitud = fila["cotiz_CorreoDesdeDondeenviaronLaSolicitud"].ToString();
                Cotiz_Correo_Texto_DctoReceptorClienteFK = int.Parse(fila["cotiz_Correo_Texto_DctoReceptorClienteFK"].ToString());
                Cotiz_Correo_Texto_FormaDePagoFK = int.Parse(fila["cotiz_Correo_Texto_FormaDePagoFK"].ToString());
                Cotiz_Correo_Texto_ValidaPorNDiasFK = int.Parse(fila["cotiz_Correo_Texto_ValidaPorNDiasFK"].ToString());
                Cotiz_Correo_UsuarioQueRegistra = fila["cotiz_Correo_UsuarioQueRegistra"].ToString();
                Cotiz_Correo_IP = fila["cotiz_Correo_IP"].ToString();
                Cotiz_Correo_FechaSolamente_DelSolicitante = DateTime.Parse(fila[("cotiz_Correo_FechaSolamente_DelSolicitante")].ToString());
                Cotiz_Correo_FechaYHora_DelSolicitante = DateTime.Parse(fila[("cotiz_Correo_FechaYHora_DelSolicitante")].ToString());
                Cotiz_Correo_FechaEnString_DelSolicitante = fila["cotiz_Correo_FechaEnString_DelSolicitante"].ToString();
                Cotiz_Correo_Estado = int.Parse(fila["cotiz_Correo_Estado"].ToString());
                Cotiz_CorreoAsunto = fila["cotiz_CorreoAsunto"].ToString();

                Cotiz_Correo_UsuarioQueAnula = fila["cotiz_Correo_UsuarioQueAnula"].ToString();

                
                    //Cotiz_Correo_UsuarioQueAnula_FechaSolamente = DateTime.Parse(fila[("cotiz_Correo_UsuarioQueAnula_FechaSolamente")].ToString());
                    //Cotiz_Correo_UsuarioQueAnula_FechaYHora = DateTime.Parse(fila[("cotiz_Correo_UsuarioQueAnula_FechaYHora")].ToString());
                    Cotiz_Correo_UsuarioQueAnula_FechaString = fila["cotiz_Correo_UsuarioQueAnula_FechaString"].ToString();
                Cotiz_Correo_UsuarioQueAnula_Razon = fila["cotiz_Correo_UsuarioQueAnula_Razon"].ToString();
                Cotiz_Correo_UsuarioQueAnula_IP = fila["cotiz_Correo_UsuarioQueAnula_IP"].ToString();
                Cotiz_Correo_Observacion = fila["cotiz_Correo_Observacion"].ToString();
                return true;
            }
        } return false;
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();

        fila["id_NumCotizacionSegun_ContadorFormatosFK"] = int.Parse(Id_NumCotizacionSegun_ContadorFormatosFK.ToString());
        fila["cotiz_CodClienteCotizanteFK"] = int.Parse(Cotiz_CodClienteCotizanteFK.ToString());
        fila["cotiz_FechayHora_RegistroEnElSistema"] = Cotiz_FechayHora_RegistroEnElSistema;
        fila["cotiz_Fecha_RegistroEnElSistema"] = Cotiz_Fecha_RegistroEnElSistema;
        fila["cotiz_FechaEnString_RegistroEnElSistema"] = Cotiz_FechaEnString_RegistroEnElSistema;
        fila["cotiz_CorreoAlCualSolicitaLaCotizacionFK"] = int.Parse(Cotiz_CorreoAlCualSolicitaLaCotizacionFK.ToString());
        fila["cotiz_CorreoDesdeDondeenviaronLaSolicitud"] = Cotiz_CorreoDesdeDondeenviaronLaSolicitud;
        fila["cotiz_Correo_Texto_DctoReceptorClienteFK"] = int.Parse(Cotiz_Correo_Texto_DctoReceptorClienteFK.ToString());
        fila["cotiz_Correo_Texto_FormaDePagoFK"] = int.Parse(Cotiz_Correo_Texto_FormaDePagoFK.ToString());
        fila["cotiz_Correo_Texto_ValidaPorNDiasFK"] = int.Parse(Cotiz_Correo_Texto_ValidaPorNDiasFK.ToString());
        fila["cotiz_Correo_UsuarioQueRegistra"] = Cotiz_Correo_UsuarioQueRegistra;
        fila["cotiz_Correo_IP"] = Cotiz_Correo_IP;
        fila["cotiz_Correo_FechaSolamente_DelSolicitante"] = Cotiz_Correo_FechaSolamente_DelSolicitante;
        fila["cotiz_Correo_FechaYHora_DelSolicitante"] = Cotiz_Correo_FechaYHora_DelSolicitante;
        fila["cotiz_Correo_FechaEnString_DelSolicitante"] = Cotiz_Correo_FechaEnString_DelSolicitante;
        fila["cotiz_Correo_Estado"] = int.Parse(Cotiz_Correo_Estado.ToString());
        fila["cotiz_CorreoAsunto"] = Cotiz_CorreoAsunto.ToString();
        fila["cotiz_Correo_Observacion"] = Cotiz_Correo_Observacion.ToString();
        fila["cotiz_Correo_Observacion"] = Cotiz_Correo_Observacion.ToString();
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool actualizarEstado(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["id_NumCotizacionSegun_ContadorFormatosFK"].ToString()) == valor)
            {
                fila["cotiz_Correo_UsuarioQueAnula"] = Cotiz_Correo_UsuarioQueAnula;
                fila["cotiz_Correo_UsuarioQueAnula_FechaSolamente"] = Cotiz_Correo_UsuarioQueAnula_FechaSolamente;
                fila["cotiz_Correo_UsuarioQueAnula_FechaYHora"] = Cotiz_Correo_UsuarioQueAnula_FechaYHora;
                fila["cotiz_Correo_UsuarioQueAnula_FechaString"] = Cotiz_Correo_UsuarioQueAnula_FechaString;
                fila["cotiz_Correo_UsuarioQueAnula_Razon"] = Cotiz_Correo_UsuarioQueAnula_Razon.ToString();
                fila["cotiz_Correo_UsuarioQueAnula_IP"] = Cotiz_Correo_UsuarioQueAnula_IP.ToString();
                fila["cotiz_Correo_Estado"] = Cotiz_Correo_Estado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }



}
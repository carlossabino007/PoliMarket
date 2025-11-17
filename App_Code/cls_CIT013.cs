using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Para formato R-CIT-013 identificacion de la Muestra
/// </summary>
public class cls_CIT013 : clsconexion
{
    string tabla = "tblRCIT013_IdentificacionDeMuestra";
    protected int idCodigoMuestra;
    protected int codigoMuestra;
    protected int idTipoMuestra;
    protected string comentarios;
    protected string rutaArchivoAdjunto;
    protected DateTime fechaYHora;
    protected DateTime fecha;
    protected string usuarioQueIngresa;
    protected string iPdondeIngresa;
    protected string observaciones;
    protected int estado;


    public cls_CIT013(int idCodigoMuestra, int codigoMuestra, int idTipoMuestra, string comentarios,
        string rutaArchivoAdjunto, DateTime fechaYHora, DateTime fecha, string usuarioQueIngresa,
        string iPdondeIngresa, int estado,string observaciones)
    {
        this.idCodigoMuestra = idCodigoMuestra;
        this.codigoMuestra = codigoMuestra;
        this.idTipoMuestra = idTipoMuestra;
        this.comentarios = comentarios;
        this.rutaArchivoAdjunto = rutaArchivoAdjunto;
        this.fechaYHora = fechaYHora;
        this.fecha = fecha;
        this.usuarioQueIngresa = usuarioQueIngresa;
        this.iPdondeIngresa = iPdondeIngresa;
        this.estado = estado;
        this.observaciones=observaciones;
    }

    public int IdCodigoMuestra
    {
        get { return idCodigoMuestra; }
        set { idCodigoMuestra = value; }
    }

    public int CodigoMuestra
    {
        get { return codigoMuestra; }
        set { codigoMuestra = value; }
    }

    public int IdTipoMuestra
    {
        get { return idTipoMuestra; }
        set { idTipoMuestra = value; }
    }

    public string Comentarios
    {
        get { return comentarios; }
        set { comentarios = value; }
    }

    public string RutaArchivoAdjunto
    {
        get { return rutaArchivoAdjunto; }
        set { rutaArchivoAdjunto = value; }
    }

    public DateTime FechaYHora
    {
        get { return fechaYHora; }
        set { fechaYHora = value; }
    }
    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }


    public string UsuarioQueIngresa
    {
        get { return usuarioQueIngresa; }
        set { usuarioQueIngresa = value; }
    }

    public string IPdondeIngresa
    {
        get { return iPdondeIngresa; }
        set { iPdondeIngresa = value; }
    }

    public int Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public string Observaciones
    {
        get { return observaciones; }
        set { observaciones = value; }
    }



    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["codigoMuestra"].ToString()) == valor)
            {
                //int
                idCodigoMuestra = int.Parse(fila["IdCodigoMuestra"].ToString()); ;
                codigoMuestra = int.Parse(fila["CodigoMuestra"].ToString()); ;
                idTipoMuestra = idTipoMuestra = int.Parse(fila["idTipoMuestra"].ToString()); ;
                estado = int.Parse(fila["Estado"].ToString()); 
                //string
                comentarios = fila["Comentarios"].ToString(); ;
                rutaArchivoAdjunto = fila["RutaArchivoAdjunto"].ToString();
                usuarioQueIngresa = fila["UsuarioQueIngresa"].ToString();
                iPdondeIngresa = fila["IPdondeIngresa"].ToString();
                observaciones = fila["Observaciones"].ToString(); ;
                
                //Datetime
                fechaYHora = DateTime.Parse(fila[("FechaYHora")].ToString()); ;
                fecha = DateTime.Parse(fila[("Fecha")].ToString()); ;
                return true;
            }
        } return false;
    }

    public bool existePorIp(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idCodigoMuestra"].ToString()) == valor)
            {
                //int
                idCodigoMuestra = int.Parse(fila["IdCodigoMuestra"].ToString()); ;
                codigoMuestra = int.Parse(fila["CodigoMuestra"].ToString()); ;
                idTipoMuestra = idTipoMuestra = int.Parse(fila["idTipoMuestra"].ToString()); ;
                estado = int.Parse(fila["Estado"].ToString());
                //string
                comentarios = fila["Comentarios"].ToString(); ;
                rutaArchivoAdjunto = fila["RutaArchivoAdjunto"].ToString();
                usuarioQueIngresa = fila["UsuarioQueIngresa"].ToString();
                iPdondeIngresa = fila["IPdondeIngresa"].ToString();
                observaciones = fila["Observaciones"].ToString(); ;

                //Datetime
                fechaYHora = DateTime.Parse(fila[("FechaYHora")].ToString()); ;
                fecha = DateTime.Parse(fila[("Fecha")].ToString()); ;
                return true;
            }
        } return false;
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["CodigoMuestra"] = int.Parse(codigoMuestra.ToString());
        fila["IdTipoMuestra"] = int.Parse(idTipoMuestra.ToString());
        fila["Estado"] = int.Parse(estado.ToString());
        fila["Comentarios"] = comentarios;
        fila["RutaArchivoAdjunto"] = rutaArchivoAdjunto;
        fila["UsuarioQueIngresa"] = usuarioQueIngresa;
        fila["IPdondeIngresa"] = iPdondeIngresa;
        fila["FechaYHora"] = fechaYHora;
        fila["Fecha"] = fecha;
        fila["Observaciones"] = observaciones;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }

    public bool actualizar(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["codigoMuestra"].ToString()) == valor)
            {
                fila["idTipoMuestra"] = IdTipoMuestra;
                fila["comentarios"] = Comentarios;
                fila["rutaArchivoAdjunto"] = RutaArchivoAdjunto;
                fila["fechaYHora"] = FechaYHora;
                fila["fecha"] = Fecha;
                fila["rutaArchivoAdjunto"] = RutaArchivoAdjunto;
                fila["fechaYHora"] = FechaYHora;
                fila["fecha"] = Fecha;
                fila["observaciones"] = Observaciones;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool actualizarPorId(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idCodigoMuestra"].ToString()) == valor)
            {
                fila["idTipoMuestra"] = IdTipoMuestra;
                fila["comentarios"] = Comentarios;
                fila["rutaArchivoAdjunto"] = RutaArchivoAdjunto;
                fila["fechaYHora"] = FechaYHora;
                fila["fecha"] = Fecha;
                fila["rutaArchivoAdjunto"] = RutaArchivoAdjunto;
                fila["fechaYHora"] = FechaYHora;
                fila["fecha"] = Fecha;
                fila["observaciones"] = Observaciones;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }








}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Comentarios que se agregan al reporte de Cotizaciones a los que solicitan al correo electrónico
/// Documentación requerida, forma de pago, Tiempo de la cotización
/// </summary>
public class cls_ComentariosCodificados: clsconexion
{
    string tabla = "tblComentariosCodificados";
    protected int idComentariosCodificados;
    protected string coment_Cotizacion_DocumentRequerida;
    protected string coment_Cotizacion_FormaDepago;
    protected int coment_Cotizacion_DiasdeCotizacion;

    public cls_ComentariosCodificados(int idComentariosCodificados, string coment_Cotizacion_DocumentRequerida, string coment_Cotizacion_FormaDepago, int coment_Cotizacion_DiasdeCotizacion)
	{
        this.idComentariosCodificados = idComentariosCodificados;
        this.coment_Cotizacion_DocumentRequerida = coment_Cotizacion_DocumentRequerida;
        this.coment_Cotizacion_FormaDepago = coment_Cotizacion_FormaDepago;
        this.coment_Cotizacion_DiasdeCotizacion = coment_Cotizacion_DiasdeCotizacion;
	}

    public int IdComentariosCodificados
    {
        set { idComentariosCodificados = value; }
        get { return idComentariosCodificados; }
    }

    public int Coment_Cotizacion_DiasdeCotizacion
    {
        set { coment_Cotizacion_DiasdeCotizacion = value; }
        get { return coment_Cotizacion_DiasdeCotizacion; }
    }
    

    public string Coment_Cotizacion_DocumentRequerida
    {
        set { coment_Cotizacion_DocumentRequerida = value; }
        get { return coment_Cotizacion_DocumentRequerida; }
    }

    public string Coment_Cotizacion_FormaDepago
    {
        set { coment_Cotizacion_FormaDepago = value; }
        get { return coment_Cotizacion_FormaDepago; }
    }


    public bool Existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["coment_Cotizacion_Codigo"].ToString()) == valor)  
            {
                IdComentariosCodificados = int.Parse(fila["idComentariosCodificados"].ToString());
                Coment_Cotizacion_DocumentRequerida = fila["coment_Cotizacion_DocumentRequerida"].ToString();
                Coment_Cotizacion_FormaDepago = fila["coment_Cotizacion_FormaDepago"].ToString();
                Coment_Cotizacion_DiasdeCotizacion = int.Parse(fila["coment_Cotizacion_DiasdeCotizacion"].ToString());
            }
        }
        return true;
    }


    public bool actualizar(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["coment_Cotizacion_Codigo"].ToString()) == valor)
            {
                //fila["proCodigoCorto"] = ProCodigoCorto;
                fila["coment_Cotizacion_DocumentRequerida"] = Coment_Cotizacion_DocumentRequerida;
                //fila["areEstado"] = AreEstado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool actualizarFormaDePago(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["coment_Cotizacion_Codigo"].ToString()) == valor)
            {
                //fila["proCodigoCorto"] = ProCodigoCorto;
                fila["coment_Cotizacion_FormaDepago"] = Coment_Cotizacion_FormaDepago;
                //fila["areEstado"] = AreEstado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool actualizarDiasDePago(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["coment_Cotizacion_Codigo"].ToString()) == valor)
            {
                //fila["proCodigoCorto"] = ProCodigoCorto;
                fila["coment_Cotizacion_DiasdeCotizacion"] = Coment_Cotizacion_DiasdeCotizacion;
                //fila["areEstado"] = AreEstado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }




}

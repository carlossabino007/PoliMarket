using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de V_CapturaDatosSolicitudCotizacion_Detalle
/// </summary>
public class cls_V_CapturaDatosSolicitudCotizacion_Detalle: clsconexion
{
    string tabla = "tbl_V_CapturaDatosSolicitudCotizacionDETALLE";
    protected int id_CotizacionDetalle;
    protected int cotizDet_CodigoDeCotizacionEnElHead;
    protected int cotizDetalle_CodigoDeEstudio;
    protected int cotizDetalle_Cantidad;
    protected int cotizDetalle_ValorMuestra;
    protected int cotizDetalle_ValeItem;
    protected string cotizDetalle_TiempoEmision;
    protected int cotizDetalle_Estado;
    

	public cls_V_CapturaDatosSolicitudCotizacion_Detalle(int id_CotizacionDetalle,int CotizDet_CodigoDeCotizacionEnElHead,int cotizDetalle_CodigoDeEstudio, int cotizDetalle_Cantidad,
            int cotizDetalle_ValorMuestra, int cotizDetalle_ValeItem, string cotizDetalle_TiempoEmision, int cotizDetalle_Estado)
	{
        this.id_CotizacionDetalle = id_CotizacionDetalle;
        this.cotizDet_CodigoDeCotizacionEnElHead = CotizDet_CodigoDeCotizacionEnElHead;
        this.cotizDetalle_CodigoDeEstudio = cotizDetalle_CodigoDeEstudio;
        this.cotizDetalle_ValorMuestra = cotizDetalle_ValorMuestra;
        this.cotizDetalle_ValeItem = cotizDetalle_ValeItem;
        this.cotizDetalle_TiempoEmision = cotizDetalle_TiempoEmision;
        this.cotizDetalle_Estado = cotizDetalle_Estado;
        this.cotizDetalle_Cantidad=cotizDetalle_Cantidad;
	}

    public int Id_CotizacionDetalle
    {
        set { id_CotizacionDetalle = value; }
        get { return id_CotizacionDetalle; }
    }

    public int CotizDet_CodigoDeCotizacionEnElHead
    {
        set {  cotizDet_CodigoDeCotizacionEnElHead = value; }
        get { return cotizDet_CodigoDeCotizacionEnElHead; }
    }

    public int CotizDetalle_CodigoDeEstudio
    {
        set { cotizDetalle_CodigoDeEstudio = value; }
        get { return cotizDetalle_CodigoDeEstudio; }
    }

    public int CotizDetalle_Cantidad
    {
        set { cotizDetalle_Cantidad = value; }
        get { return cotizDetalle_Cantidad; }
    }


    public int CotizDetalle_ValorMuestra
    {
        set { cotizDetalle_ValorMuestra = value; }
        get { return cotizDetalle_ValorMuestra; }
    }

    public int CotizDetalle_ValeItem
    {
        set { cotizDetalle_ValeItem = value; }
        get { return cotizDetalle_ValeItem; }
    }

    public string CotizDetalle_TiempoEmision
    {
        set { cotizDetalle_TiempoEmision = value; }
        get { return cotizDetalle_TiempoEmision; }
    }

    public int CotizDetalle_Estado
    {
        set { cotizDetalle_Estado = value; }
        get { return cotizDetalle_Estado; }
    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["CotizDet_CodigoDeCotizacionEnElHead"].ToString()) == valor)
            {
                Id_CotizacionDetalle = int.Parse(fila["id_CotizacionDetalle"].ToString());
                CotizDet_CodigoDeCotizacionEnElHead = int.Parse(fila["cotizDet_CodigoDeCotizacionEnElHead"].ToString());
                CotizDetalle_CodigoDeEstudio = int.Parse(fila["cotizDetalle_CodigoDeEstudio"].ToString());
                CotizDetalle_Cantidad=int.Parse(fila["cotizDetalle_Cantidad"].ToString());
                CotizDetalle_ValorMuestra = int.Parse(fila["cotizDetalle_ValorMuestra"].ToString());
                CotizDetalle_ValeItem = int.Parse(fila["cotizDetalle_ValeItem"].ToString());
                CotizDetalle_TiempoEmision = fila["cotizDetalle_TiempoEmision"].ToString();
                CotizDetalle_Estado = int.Parse(fila["cotizDetalle_Estado"].ToString());
                return true;
            }
        } return false;
    }


    public void agregarDetallaDeLaCotizacion()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();

        fila["cotizDet_CodigoDeCotizacionEnElHead"] = int.Parse(CotizDet_CodigoDeCotizacionEnElHead.ToString());
        fila["cotizDetalle_CodigoDeEstudio"] = int.Parse(CotizDetalle_CodigoDeEstudio.ToString());
        fila["cotizDetalle_Cantidad"] = int.Parse(CotizDetalle_Cantidad.ToString());
        fila["cotizDetalle_ValorMuestra"] = int.Parse(CotizDetalle_ValorMuestra.ToString());
        fila["cotizDetalle_ValeItem"] = int.Parse(CotizDetalle_ValeItem.ToString());
        fila["cotizDetalle_TiempoEmision"] = CotizDetalle_TiempoEmision;
        fila["cotizDetalle_Estado"] = int.Parse(CotizDetalle_Estado.ToString());
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }




}
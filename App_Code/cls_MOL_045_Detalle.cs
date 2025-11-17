using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_MOL_045_Detalle : clsconexion
{
    string tabla = "tblR_MOL_045_Detalle";
    protected int idCodigoenDetalle;
    protected int codigoGeneradoEnHead;
    protected int codigoCaso;
    protected int estadoEnDetalle;
    protected int ordenDelItem;
    protected string codigoCasoAnexo;

    public cls_MOL_045_Detalle(int idCodigoenDetalle, int codigoGeneradoEnHead,
        int codigoCaso, int estadoEnDetalle, int ordenDelItem, string codigoCasoAnexo)
	{
        this.idCodigoenDetalle = idCodigoenDetalle;
        this.codigoGeneradoEnHead = codigoGeneradoEnHead;
        this.codigoCaso = codigoCaso;
        this.estadoEnDetalle = estadoEnDetalle;
        this.ordenDelItem=ordenDelItem;
        this.codigoCasoAnexo = codigoCasoAnexo;
  }

    public int IdCodigoenDetalle
    {
        set { idCodigoenDetalle = value; }
        get { return idCodigoenDetalle; }
    }

    public int CodigoGeneradoEnHead
    {
        set { codigoGeneradoEnHead = value; }
        get { return codigoGeneradoEnHead; }
    }

    public int CodigoCaso
    {
        set { codigoCaso = value; }
        get { return codigoCaso; }
    }


    public int EstadoEnDetalle
    {
        set { estadoEnDetalle = value; }
        get { return estadoEnDetalle; }
    }

    public int OrdenDelItem
    {
        set { ordenDelItem = value; }
        get { return ordenDelItem; }
    }

    public string CodigoCasoAnexo
    {
        set { codigoCasoAnexo = value; }
        get { return codigoCasoAnexo; }
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["CodigoGeneradoEnHead"] = int.Parse(codigoGeneradoEnHead.ToString());
        fila["CodigoCaso"] = int.Parse(codigoCaso.ToString());
        fila["EstadoEnDetalle"] = int.Parse(estadoEnDetalle.ToString());
        fila["OrdenDelItem"] = int.Parse(ordenDelItem.ToString());
        fila["CodigoCasoAnexo"] = codigoCasoAnexo;

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }

    public bool ExistePorElID(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idCodigoenDetalle"].ToString()) == valor)
            {
                CodigoGeneradoEnHead = int.Parse(fila["codigoGeneradoEnHead"].ToString());
                CodigoCaso = int.Parse(fila["codigoCaso"].ToString());
                EstadoEnDetalle = int.Parse(fila["estadoEnDetalle"].ToString());
                OrdenDelItem = int.Parse(fila["ordenDelItem"].ToString());
                CodigoCasoAnexo = fila["codigoCasoAnexo"].ToString();
                return true;
            }
        } return false;
    }


    public bool ExistePorElCodigoDelCaso(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["codigoCaso"].ToString()) == valor)
            //if (int.Parse(fila["idCodigoenDetalle"].ToString()) == valor)
            {
                CodigoGeneradoEnHead = int.Parse(fila["codigoGeneradoEnHead"].ToString());
                //CodigoCaso = int.Parse(fila["codigoCaso"].ToString());
                //EstadoEnDetalle = int.Parse(fila["estadoEnDetalle"].ToString());
                //OrdenDelItem = int.Parse(fila["ordenDelItem"].ToString());
                //CodigoCasoAnexo = fila["codigoCasoAnexo"].ToString();
                return true;
            }
        } return false;
    }


    public bool ExistePorElCodigoGeneradoEnElHead(String valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["codigoGeneradoEnHead"].ToString().Equals(valor))
            {
                IdCodigoenDetalle = int.Parse(fila["idCodigoenDetalle"].ToString());
                CodigoCaso = int.Parse(fila["codigoCaso"].ToString());
                EstadoEnDetalle = int.Parse(fila["estadoEnDetalle"].ToString());
                OrdenDelItem = int.Parse(fila["ordenDelItem"].ToString());
                CodigoCasoAnexo = fila["codigoCasoAnexo"].ToString();
                return true;
            }
        } return false;
    }




}
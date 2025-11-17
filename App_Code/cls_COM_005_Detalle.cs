using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_COM_005_Detalle: clsconexion
{
    string tabla = "tblR_COM_005_Detalle";
    protected int id_COM_005EnDetalle;
    protected int cOM_005_RegistroSeguntblContadorFormatosCodGenerado;
    protected string cOM_005EnDetalle_CodigoGenerado;
    protected int cOM_005EnDetalle_Item;
    protected string cOM_005EnDetalle_Articulo;
    protected string cOM_005EnDetalle_Marca;
    protected string cOM_005EnDetalle_NumCatalogo;
    protected string cOM_005EnDetalle_Presentacion;
    protected int cOM_005EnDetalle_Cantidad;

    public cls_COM_005_Detalle(int id_COM_005EnDetalle, string cOM_005EnDetalle_CodigoGenerado,
    int cOM_005EnDetalle_Item, string cOM_005EnDetalle_Articulo, string cOM_005EnDetalle_Marca,
    string cOM_005EnDetalle_NumCatalogo, string cOM_005EnDetalle_Presentacion,
    int cOM_005EnDetalle_Cantidad, int cOM_005_RegistroSeguntblContadorFormatosCodGenerado)
	{

    this.cOM_005EnDetalle_CodigoGenerado = cOM_005EnDetalle_CodigoGenerado;
    this.cOM_005EnDetalle_Item = cOM_005EnDetalle_Item;
    this.cOM_005EnDetalle_Articulo = cOM_005EnDetalle_Articulo;
    this.cOM_005EnDetalle_Marca = cOM_005EnDetalle_Marca;
    this.cOM_005EnDetalle_NumCatalogo = cOM_005EnDetalle_NumCatalogo;
    this.cOM_005EnDetalle_Presentacion = cOM_005EnDetalle_Presentacion;
    this.cOM_005EnDetalle_Cantidad = cOM_005EnDetalle_Cantidad;
    this.cOM_005_RegistroSeguntblContadorFormatosCodGenerado = cOM_005_RegistroSeguntblContadorFormatosCodGenerado;

	}

    public string COM_005EnDetalle_CodigoGenerado
    {
        set { cOM_005EnDetalle_CodigoGenerado = value; }
        get { return cOM_005EnDetalle_CodigoGenerado; }
    }


    public int COM_005_RegistroSeguntblContadorFormatosCodGenerado
    {
        set { cOM_005_RegistroSeguntblContadorFormatosCodGenerado = value; }
        get { return cOM_005_RegistroSeguntblContadorFormatosCodGenerado; }
    }


    public int COM_005EnDetalle_Item
    {
        set { cOM_005EnDetalle_Item = value; }
        get { return cOM_005EnDetalle_Item; }
    }

    public string COM_005EnDetalle_Articulo
    {
        set { cOM_005EnDetalle_Articulo = value; }
        get { return cOM_005EnDetalle_Articulo; }
    }

    public string COM_005EnDetalle_Marca
    {
        set { cOM_005EnDetalle_Marca = value; }
        get { return cOM_005EnDetalle_Marca; }
    }

    public string COM_005EnDetalle_NumCatalogo
    {
        set { cOM_005EnDetalle_NumCatalogo = value; }
        get { return cOM_005EnDetalle_NumCatalogo; }
    }

    public string COM_005EnDetalle_Presentacion
    {
        set { cOM_005EnDetalle_Presentacion = value; }
        get { return cOM_005EnDetalle_Presentacion; }
    }

    public int COM_005EnDetalle_Cantidad
    {
        set { cOM_005EnDetalle_Cantidad = value; }
        get { return cOM_005EnDetalle_Cantidad; }
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["COM_005EnDetalle_CodigoGenerado"] = cOM_005EnDetalle_CodigoGenerado.ToString();
        fila["COM_005EnDetalle_Item"] = int.Parse(cOM_005EnDetalle_Item.ToString());
        fila["COM_005_RegistroSeguntblContadorFormatosCodGenerado"] = int.Parse(cOM_005_RegistroSeguntblContadorFormatosCodGenerado.ToString());
        fila["COM_005EnDetalle_Articulo"] = cOM_005EnDetalle_Articulo;
        fila["COM_005EnDetalle_Marca"] = cOM_005EnDetalle_Marca;
        fila["COM_005EnDetalle_NumCatalogo"] = cOM_005EnDetalle_NumCatalogo;
        fila["COM_005EnDetalle_Presentacion"] = cOM_005EnDetalle_Presentacion;
        fila["COM_005EnDetalle_Cantidad"] = cOM_005EnDetalle_Cantidad;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }
    
    
    public bool ExistePorElCodigoAlHeadQuePertenece(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
             
            if((fila["cOM_005EnDetalle_PertenedaAlHeadCon"].ToString()).Equals("valor"))
            {
                COM_005EnDetalle_Item = int.Parse(fila["cOM_005EnDetalle_Item"].ToString());
                COM_005_RegistroSeguntblContadorFormatosCodGenerado = int.Parse(fila["cOM_005_RegistroSeguntblContadorFormatosCodGenerado"].ToString());
                COM_005EnDetalle_Articulo = fila["cOM_005EnDetalle_Articulo"].ToString();
                COM_005EnDetalle_Marca = fila["cOM_005EnDetalle_Marca"].ToString();
                COM_005EnDetalle_NumCatalogo = fila["cOM_005EnDetalle_NumCatalogo"].ToString();
                COM_005EnDetalle_Presentacion = fila["cOM_005EnDetalle_Presentacion"].ToString();
                COM_005EnDetalle_Cantidad = int.Parse(fila["COM_005EnDetalle_Cantidad"].ToString());
                return true;
            }
        } return false;
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_Presentacion: clsconexion
{
    string tabla = "tblPresentacion";
    protected int presCodPresentacion, preEstado;
    protected string preDescripcion, preFechaCreacionString;

	public cls_Presentacion( int  presCodPresentacion, int preEstado,
        string  preDescripcion, string preFechaCreacionString)
	{
        this.presCodPresentacion = presCodPresentacion;
        this.preEstado = preEstado;
        this.preDescripcion = preDescripcion;
        this.preFechaCreacionString = preFechaCreacionString;
	}

    public int PresCodPresentacion 
    {
        set { presCodPresentacion = value; }
        get { return presCodPresentacion; }
    }
    public int PreEstado
    {
        set { preEstado = value; }
        get { return preEstado; }
    }

    public string PreDescripcion
    {
        set { preDescripcion = value; }
        get { return preDescripcion; }
    }

    public string PreFechaCreacionString
    {
        set { preFechaCreacionString = value; }
        get { return preFechaCreacionString; }
    }

    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["presCodPresentacion"].ToString()) == valor)
            {
                PresCodPresentacion = int.Parse(fila["presCodPresentacion"].ToString());
                PreDescripcion= fila["preDescripcion"].ToString();
                PreEstado = int.Parse(fila["preEstado"].ToString());
                PreFechaCreacionString = fila["preFechaCreacionString"].ToString();
                return true;
            }
        } return false;
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["presCodPresentacion"] = int.Parse(PresCodPresentacion.ToString());
        fila["preDescripcion"] = PreDescripcion;
        fila["preEstado"] = int.Parse(PreEstado.ToString());
        fila["preFechaCreacionString"] = PreFechaCreacionString;
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
            if (int.Parse(fila["presCodPresentacion"].ToString()) == valor)
            {
                fila["preDescripcion"] = PreDescripcion;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }








}
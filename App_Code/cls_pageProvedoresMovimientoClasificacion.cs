using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_pageProvedoresMovimientoClasificacion: clsconexion
{

    string tabla = "tblClasificacion";
    protected int clasCodigo, clasEstado;
    protected string clasDescripcion, clasFechaCreacionClasificacionString;

	public cls_pageProvedoresMovimientoClasificacion(int clasCodigo, int clasEstado, 
        string clasDescripcion, string clasFechaCreacionClasificacionString)
	{
        this.clasCodigo = clasCodigo;
        this.clasEstado = clasEstado;
        this.clasDescripcion = clasDescripcion;
        this.clasFechaCreacionClasificacionString = clasFechaCreacionClasificacionString;

	}

    public int ClasCodigo
    {
        set { clasCodigo = value; }
        get { return clasCodigo; }
    }


    public int ClasEstado
    {
        set { clasEstado = value; }
        get { return clasEstado; }
    }

    public string ClasDescripcion
    {
        set { clasDescripcion = value; }
        get { return clasDescripcion; }
    }

    public string ClasFechaCreacionClasificacionString
    {
        set { clasFechaCreacionClasificacionString = value; }
        get { return clasFechaCreacionClasificacionString; }
    }

    
    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["clasCodigo"] = int.Parse(ClasCodigo.ToString());
        fila["clasEstado"] = int.Parse(clasEstado.ToString()); 
        fila["clasDescripcion"] = ClasDescripcion;
        fila["clasFechaCreacionClasificacionString"] = ClasFechaCreacionClasificacionString;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["clasCodigo"].ToString()) == valor)
            {
                ClasCodigo = int.Parse(fila["clasCodigo"].ToString());
                ClasEstado = int.Parse(fila["clasEstado"].ToString());
                ClasDescripcion = fila["clasDescripcion"].ToString();
                ClasFechaCreacionClasificacionString = fila["clasFechaCreacionClasificacionString"].ToString();

                return true;
            }
        } return false;
    }



    public bool actualizar(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["clasCodigo"].ToString()) == valor)
            {
                //fila["areCodigo"] = AreCodigo;
                fila["clasEstado"] = ClasEstado;
                fila["clasDescripcion"] = ClasDescripcion;
                fila["clasFechaCreacionClasificacionString"] = ClasFechaCreacionClasificacionString;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool devuelveDescripcionDeLaClasificacion(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["clasCodigo"].ToString()) == valor)
            {
                ClasDescripcion = fila["clasDescripcion"].ToString();
                return true;
            }
        } return false;
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public class cls_CondicionDeAlmacenamiento: clsconexion
{
    string tabla = "tblCondicionDeAlmacenamiento";
    protected int condAlmacenCodigo, condAlmacenEstado;
    protected string condAlmacenDescripcion, condAlmacenFechaCreacionString;


	public cls_CondicionDeAlmacenamiento(int condAlmacenCodigo, int condAlmacenEstado,
        string condAlmacenDescripcion, string condAlmacenFechaCreacionString)
	{
        this.condAlmacenCodigo=condAlmacenCodigo;
        this.condAlmacenEstado = condAlmacenEstado;
        this.condAlmacenDescripcion = condAlmacenDescripcion;
        this.condAlmacenFechaCreacionString = condAlmacenFechaCreacionString;
	}

    public int CondAlmacenCodigo
    {
        set { condAlmacenCodigo = value; }
        get { return condAlmacenCodigo; }
    }


    public int CondAlmacenEstado
    {
        set { condAlmacenEstado = value; }
        get { return condAlmacenEstado; }
    }

    public string CondAlmacenDescripcion
    {
        set { condAlmacenDescripcion = value; }
        get { return condAlmacenDescripcion; }
    }

    public string CondAlmacenFechaCreacionString
    {
        set { condAlmacenFechaCreacionString = value; }
        get { return condAlmacenFechaCreacionString; }
    }



    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["condAlmacenCodigo"].ToString()) == valor)
            {
                CondAlmacenDescripcion = fila["CondAlmacenDescripcion"].ToString();
                return true;
            }
        } return false;
    }






    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["condAlmacenCodigo"] = int.Parse(CondAlmacenCodigo.ToString());
        fila["condAlmacenDescripcion"] = CondAlmacenDescripcion;
        fila["condAlmacenEstado"] = int.Parse(CondAlmacenEstado.ToString());
        fila["condAlmacenFechaCreacionString"] = CondAlmacenFechaCreacionString;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


}
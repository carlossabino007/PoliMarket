using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_Configuraciones_Marcas : clsconexion
{
    string tabla = "tblMarca";
    protected int marCodigo, marEstado;
    protected string marDescripcion, marFechaCreacionString;

	public cls_Configuraciones_Marcas(int marCodigo, int marEstado,
        string marDescripcion, string marFechaCreacionString)
	{
        this.marCodigo = marCodigo;
        this.marEstado = marEstado;
        this.marDescripcion = marDescripcion;
        this.marFechaCreacionString = marFechaCreacionString;
	}

    public int MarCodigo
    {
        set { marCodigo = value; }
        get { return marCodigo; }
    }
    public int MarEstado
    {
        set { marEstado = value; }
        get { return marEstado; }
    }

    public string MarDescripcion
    {
        set { marDescripcion = value; }
        get { return marDescripcion; }
    }

    public string MarFechaCreacionString
    {
        set { marFechaCreacionString = value; }
        get { return marFechaCreacionString; }
    }

    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["marCodigo"].ToString()) == valor)
            {
                MarCodigo = int.Parse(fila["marCodigo"].ToString());
                MarDescripcion = fila["marDescripcion"].ToString();
                MarEstado = int.Parse(fila["marEstado"].ToString());
                MarFechaCreacionString = fila["marFechaCreacionString"].ToString();

                return true;
            }
        } return false;
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["marCodigo"] = int.Parse(MarCodigo.ToString());
        fila["marDescripcion"] = MarDescripcion;
        fila["marEstado"] = int.Parse(MarEstado.ToString());
        fila["marFechaCreacionString"] = MarFechaCreacionString;

        
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
            if (int.Parse(fila["marCodigo"].ToString()) == valor)
            {
                //fila["proCodigoCorto"] = ProCodigoCorto;
                fila["marDescripcion"] = MarDescripcion;
                //fila["areEstado"] = AreEstado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }




}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_GruposDeLasAreasDeTrabajo: clsconexion
{
    string tabla = "tblGruposDePruebas";
    protected int gruCodigo, gruEstado;
    protected string gruDescripcion, gruFechaCreacionString;
    protected int gruAreaAlAQuePertenece;

	public cls_GruposDeLasAreasDeTrabajo(int gruCodigo, int gruEstado,
        string gruDescripcion, string gruFechaCreacionString, int gruAreaAlAQuePertenece)
	{
        this.gruCodigo = gruCodigo;
        this.gruDescripcion = gruDescripcion;
        this.gruEstado = gruEstado;
        this.gruFechaCreacionString = gruFechaCreacionString;
        this.gruAreaAlAQuePertenece = gruAreaAlAQuePertenece;
	}

    public int GruCodigo
    {
        set { gruCodigo = value; }
        get { return gruCodigo; }
    }
    public string GruDescripcion
    {
        set { gruDescripcion = value; }
        get { return gruDescripcion; }
    }
    public int GruEstado
    {
        set { gruEstado = value; }
        get { return gruEstado; }
    }
    public string GruFechaCreacionString
    {
        set { gruFechaCreacionString = value; }
        get { return gruFechaCreacionString; }
    }

    public int GruAreaAlAQuePertenece
    {
        set { gruAreaAlAQuePertenece = value; }
        get { return gruAreaAlAQuePertenece; }
    }

    


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["gruCodigo"].ToString()) == valor)
            {
                GruCodigo = int.Parse(fila["gruCodigo"].ToString());
                GruDescripcion = fila["gruDescripcion"].ToString();
                GruEstado = int.Parse(fila["gruEstado"].ToString());
                GruFechaCreacionString = fila["gruFechaCreacionString"].ToString();
                GruAreaAlAQuePertenece = int.Parse(fila["gruAreaAlAQuePertenece"].ToString());
                return true;
            }
        } return false;
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["gruCodigo"] = int.Parse(GruCodigo.ToString());
        fila["gruDescripcion"] = GruDescripcion;
        fila["gruEstado"] = int.Parse(GruEstado.ToString());
        fila["gruFechaCreacionString"] = GruFechaCreacionString;
        fila["gruAreaAlAQuePertenece"] = int.Parse(GruAreaAlAQuePertenece.ToString());
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
            if (int.Parse(fila["gruCodigo"].ToString()) == valor)
            {
                fila["gruDescripcion"] = GruDescripcion;
                fila["gruAreaAlAQuePertenece"] = GruAreaAlAQuePertenece;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


}
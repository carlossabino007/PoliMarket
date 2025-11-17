using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_COM_002_Metodo : clsconexion
{
    string tabla = "tbl_R_HLA_002_Metodo";
    protected int idCodMetodo;
    protected string descripcionMetodo;
    protected int estadoMetodo;

	public cls_COM_002_Metodo(int idCodMetodo,string descripcionMetodo,int estadoMetodo)
	{
        this.idCodMetodo=idCodMetodo;
        this.descripcionMetodo=descripcionMetodo;
        this.estadoMetodo=estadoMetodo;
	}

    public int IdCodMetodo
    {
        set { idCodMetodo = value; }
        get { return idCodMetodo; }
    }

    public string DescripcionMetodo
    {
        set { descripcionMetodo = value; }
        get { return descripcionMetodo; }
    }

    public int EstadoMetodo
    {
        set { estadoMetodo = value; }
        get { return estadoMetodo; }
    }



    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["DescripcionMetodo"] = descripcionMetodo;
        fila["EstadoMetodo"] = int.Parse(estadoMetodo.ToString());
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
            if (int.Parse(fila["idCodMetodo"].ToString()) == valor)
            {
                DescripcionMetodo = fila["descripcionMetodo"].ToString();
                EstadoMetodo = int.Parse(fila["estadoMetodo"].ToString());
                return true;
            }
        } return false;
    }




}
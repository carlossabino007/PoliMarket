using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_Configuraciones_AreasDeTrabajo : clsconexion
{
    string tabla = "tblAreasdeTrabajo";
    protected int areCodAreaTrabajo, areEstado;
    protected string areDescripcionAreaTrabajo;

	public cls_Configuraciones_AreasDeTrabajo(int areCodAreaTrabajo, int areEstado,
                                              string areDescripcionAreaTrabajo)
	{
        this.areCodAreaTrabajo = areCodAreaTrabajo;
        this.areEstado = areEstado;
        this.areDescripcionAreaTrabajo = areDescripcionAreaTrabajo;
	}

    public int AreCodAreaTrabajo
    {
        set { areCodAreaTrabajo = value; }
        get { return areCodAreaTrabajo; }
    }

    public int AreEstado 
    {
        set { areEstado = value; }
        get { return areEstado; }
    }

    public string AreDescripcionAreaTrabajo
    {
        set { areDescripcionAreaTrabajo = value; }
        get { return areDescripcionAreaTrabajo; }
    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["areCodAreaTrabajo"].ToString()) == valor)
            {
                AreCodAreaTrabajo = int.Parse(fila["areCodAreaTrabajo"].ToString());
                AreDescripcionAreaTrabajo = fila["areDescripcionAreaTrabajo"].ToString();
                AreEstado = int.Parse(fila["areEstado"].ToString());
                return true;
            }
        } return false;
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["areCodAreaTrabajo"] = int.Parse(AreCodAreaTrabajo.ToString());
        fila["areDescripcionAreaTrabajo"] = AreDescripcionAreaTrabajo;
        fila["areEstado"] = AreEstado;
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
            if (int.Parse(fila["areCodAreaTrabajo"].ToString()) == valor)
            {
                //fila["proCodigoCorto"] = ProCodigoCorto;
                fila["areDescripcionAreaTrabajo"] = AreDescripcionAreaTrabajo;
                //fila["areEstado"] = AreEstado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool ExistePorElID(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["areCodAreaTrabajo"].ToString()) == valor)
            {
                AreDescripcionAreaTrabajo = fila["areDescripcionAreaTrabajo"].ToString();
                return true;
            }
        } return false;
    }

}

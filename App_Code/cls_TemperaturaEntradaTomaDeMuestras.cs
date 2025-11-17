using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de cls_TemperaturaEntradaTomaDeMuestras
/// </summary>
public class cls_TemperaturaEntradaTomaDeMuestras: clsconexion
{

    string tabla = "tblTemperaturaEntradaTomaDeMuestras";

    protected int idTemperaturaEntrada, temperaturaEstado;
    protected string temperaturaDescripcion;

	public cls_TemperaturaEntradaTomaDeMuestras(int idTemperaturaEntrada, int temperaturaEstado,
        string temperaturaDescripcion)
	{
        this.idTemperaturaEntrada = idTemperaturaEntrada;
        this.temperaturaEstado = temperaturaEstado;
        this.temperaturaDescripcion = temperaturaDescripcion;
	}


    public int IdTemperaturaEntrada
    {
        set { idTemperaturaEntrada = value; }
        get { return idTemperaturaEntrada; }
    }

    public int TemperaturaEstado
    {
        set { temperaturaEstado = value; }
        get { return temperaturaEstado; }
    }

    public string TemperaturaDescripcion
    {
        set { temperaturaDescripcion = value; }
        get { return temperaturaDescripcion; }
    }


    public void agregar()
    {

        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["temperaturaEstado"] = int.Parse(TemperaturaEstado.ToString());
        fila["temperaturaDescripcion"] = (TemperaturaDescripcion.ToString());
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


}
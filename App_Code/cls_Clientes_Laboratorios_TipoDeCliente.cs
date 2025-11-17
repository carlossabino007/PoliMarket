using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Descripción breve de cls_Clientes_Laboratorios_TipoDeCliente
/// </summary>
public class cls_Clientes_Laboratorios_TipoDeCliente: clsconexion
{
    string tabla = "tblTipoDestino";
    protected int idtipoDestino, tipDestEstado;
    protected string tipDestDescripcion;


	public cls_Clientes_Laboratorios_TipoDeCliente(int idtipoDestino, int tipDestEstado, string tipDestDescripcion)
	{
        this.idtipoDestino = idtipoDestino;
        this.tipDestEstado = tipDestEstado;
        this.tipDestDescripcion = tipDestDescripcion;
	}

    public int IdtipoDestino
    {
        set { idtipoDestino = value; }
        get { return idtipoDestino; }
    }

    public int TipDestEstado
    {
        set { tipDestEstado = value; }
        get { return tipDestEstado; }
    }

    public string TipDestDescripcion
    {
        set { tipDestDescripcion = value; }
        get { return tipDestDescripcion; }
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["TipDestEstado"] = int.Parse(tipDestEstado.ToString());
        fila["TipDestDescripcion"] = tipDestDescripcion.ToString();
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


}
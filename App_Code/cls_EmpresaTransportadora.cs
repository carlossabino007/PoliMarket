using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Descripción breve de cls_EmpresaTransportadora
/// </summary>
public class cls_EmpresaTransportadora: clsconexion
{

    string tabla = "tblEmpresaTransportadora";

    protected int idEmpresaTransportadora, empresaTransportadora_Estado;
    protected string empresaTransportadora_Descripcion;

	public cls_EmpresaTransportadora(int idEmpresaTransportadora, int empresaTransportadora_Estado,
        string empresaTransportadora_Descripcion)
	{
        this.idEmpresaTransportadora=idEmpresaTransportadora;
        this.empresaTransportadora_Estado = empresaTransportadora_Estado;
        this.empresaTransportadora_Descripcion = empresaTransportadora_Descripcion;
	}

    public int IdEmpresaTransportadora
    {
        set { idEmpresaTransportadora = value; }
        get { return idEmpresaTransportadora; }
    }

    public int EmpresaTransportadora_Estado
    {
        set { empresaTransportadora_Estado = value; }
        get { return empresaTransportadora_Estado; }
    }

    public string EmpresaTransportadora_Descripcion
    {
        set { empresaTransportadora_Descripcion = value; }
        get { return empresaTransportadora_Descripcion; }
    }


    public void agregar()
    {

        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["empresaTransportadora_Estado"] = int.Parse(EmpresaTransportadora_Estado.ToString());
        fila["empresaTransportadora_Descripcion"] = (EmpresaTransportadora_Descripcion.ToString());
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool BustrarEmpresaTransportora(string valor1)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["lotCodigoLoteCatalogoMasLote"].ToString().Equals(valor1))  // Si no es el mismo, si es diferente
            {
                // int
                EmpresaTransportadora_Estado = int.Parse(fila["empresaTransportadora_Estado"].ToString());
                
                //string
                EmpresaTransportadora_Descripcion = fila["empresaTransportadora_Descripcion"].ToString();
                return true;
            }
        } return false;
    }



    public bool buscarYObtenerElNombreEmpresaTransportadora(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idEmpresaTransportadora"].ToString()) == valor)
            {
                EmpresaTransportadora_Descripcion = fila["empresaTransportadora_Descripcion"].ToString();
                EmpresaTransportadora_Estado = int.Parse(fila["empresaTransportadora_Estado"].ToString());
                return true;
            }
        } return false;
    }





}
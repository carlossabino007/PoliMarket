using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_Medidas: clsconexion
{
	
    string tabla = "tblMedidas";
    protected int medCodigoMedida, medEstado;
    protected string medDescripcion, medFechaCreacionStringmed, medAbreviatura;

    public cls_Medidas(int medCodigoMedida, int medEstado,
        string medDescripcion, string medFechaCreacionStringmed, string medAbreviatura)
	{
        this.medCodigoMedida = medCodigoMedida;
        this.medEstado = medEstado;
        this.medDescripcion = medDescripcion;
        this.medFechaCreacionStringmed = medFechaCreacionStringmed;
        this.medAbreviatura = medAbreviatura;
	}

    public int MedCodigoMedida
    {
        set { medCodigoMedida = value; }
        get { return medCodigoMedida; }
    }
    public int MedEstado
    {
        set { medEstado = value; }
        get { return medEstado; }
    }

    public string MedDescripcion
    {
        set { medDescripcion = value; }
        get { return medDescripcion; }
    }

    public string MedFechaCreacionStringmed
    {
        set { medFechaCreacionStringmed = value; }
        get { return medFechaCreacionStringmed; }
    }

    public string MedAbreviatura
    {
        set { medAbreviatura = value; }
        get { return medAbreviatura; }
    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["medCodigoMedida"].ToString()) == valor)
            {
                MedCodigoMedida = int.Parse(fila["medCodigoMedida"].ToString());
                MedDescripcion=fila["medDescripcion"].ToString();
                MedEstado = int.Parse(fila["medEstado"].ToString());
                MedFechaCreacionStringmed = fila["medFechaCreacionStringmed"].ToString();
                MedAbreviatura = fila["medAbreviatura"].ToString();
                return true;
            }
        } return false;
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["medCodigoMedida"] = int.Parse(MedCodigoMedida.ToString());
        fila["medDescripcion"] = MedDescripcion;
        fila["medEstado"] = int.Parse(MedEstado.ToString());
        fila["medFechaCreacionStringmed"] = MedFechaCreacionStringmed;
        fila["medAbreviatura"] = MedAbreviatura;
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
            if (int.Parse(fila["medCodigoMedida"].ToString()) == valor)
            {
                fila["medDescripcion"] = MedDescripcion;
                fila["medAbreviatura"] = MedAbreviatura;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }










}
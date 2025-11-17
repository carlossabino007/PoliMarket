using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Controla cuando se agregan una formula a un estudio
/// 
/// </summary>
public class cls_AsignarFormulasAEstudios: clsconexion
{
    string tabla = "tblFormulaAsignacion";
    protected int idFormulasAsignadaPorArea, forasig_AreaAQuePerteneceFK, forasig_IDProducto_EstudioFK, forasig_estado, forasig_Usuario;
    protected string forasig_CodigoFormula, forasig_Observaciones, forasig_FechaCreacionString, forasig_IP, forasig_PC, forasig_HoraCreacionString;

	public cls_AsignarFormulasAEstudios(int idFormulasAsignadaPorArea, int forasig_AreaAQuePerteneceFK, int forasig_IDProducto_EstudioFK, int forasig_estado, int forasig_Usuario,
      string forasig_CodigoFormula, string forasig_Observaciones, string forasig_FechaCreacionString, string forasig_IP, string forasig_PC, string forasig_HoraCreacionString )
	{
        //int
        this.idFormulasAsignadaPorArea = idFormulasAsignadaPorArea;
        this.forasig_AreaAQuePerteneceFK = forasig_AreaAQuePerteneceFK;
        this.forasig_IDProducto_EstudioFK = forasig_IDProducto_EstudioFK;
        this.forasig_estado = forasig_estado;
        this.forasig_Usuario = forasig_Usuario;

        //string
        this.forasig_CodigoFormula = forasig_CodigoFormula;
        this.forasig_Observaciones = forasig_Observaciones;
        this.forasig_FechaCreacionString = forasig_FechaCreacionString;
        this.forasig_IP = forasig_IP;
        this.forasig_PC = forasig_PC;
        this.forasig_HoraCreacionString = forasig_HoraCreacionString;
	}

    public int IdFormulasAsignadaPorArea
    {
        set { idFormulasAsignadaPorArea = value; }
        get { return idFormulasAsignadaPorArea; }
    }

    public int Forasig_AreaAQuePerteneceFK
    {
        set { forasig_AreaAQuePerteneceFK = value; }
        get { return forasig_AreaAQuePerteneceFK; }
    }

    public int Forasig_IDProducto_EstudioFK
    {
        set { forasig_IDProducto_EstudioFK = value; }
        get { return forasig_IDProducto_EstudioFK; }
    }

    public int Forasig_estado
    {
        set { forasig_estado = value; }
        get { return forasig_estado; }
    }

    public int Forasig_Usuario
    {
        set { forasig_Usuario = value; }
        get { return forasig_Usuario; }
    }

    public string Forasig_CodigoFormula
    {
        set { forasig_CodigoFormula = value; }
        get { return forasig_CodigoFormula; }
    }
    
    public string Forasig_Observaciones
    {
        set { forasig_Observaciones = value; }
        get { return forasig_Observaciones; }
    }

    
    public string Forasig_FechaCreacionString
    {
        set { forasig_FechaCreacionString = value; }
        get { return forasig_FechaCreacionString; }
    }

   
    public string Forasig_IP
    {
        set { forasig_IP = value; }
        get { return forasig_IP; }
    }

    public string Forasig_PC
    {
        set { forasig_PC = value; }
        get { return forasig_PC; }
    }
    
    public string Forasig_HoraCreacionString
    {
        set { forasig_HoraCreacionString = value; }
        get { return forasig_HoraCreacionString; }
    }


    public bool existe_SoloBuscaSiExiste(string xFormula, int xEstudio)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["forasig_CodigoFormula"].ToString() == xFormula)
            {
                if (int.Parse(fila["forasig_IDProducto_EstudioFK"].ToString()) == xEstudio)
                {
                    return true;  // Ya está
                }
            }
        }
       return false;
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        //int
        fila["forasig_AreaAQuePerteneceFK"] = int.Parse(Forasig_AreaAQuePerteneceFK.ToString());
        fila["forasig_IDProducto_EstudioFK"] = int.Parse(Forasig_IDProducto_EstudioFK.ToString());
        fila["forasig_estado"] = int.Parse(Forasig_estado.ToString());
        fila["forasig_Usuario"] = int.Parse(Forasig_Usuario.ToString());
        //string
        fila["forasig_CodigoFormula"] = Forasig_CodigoFormula;
        fila["forasig_Observaciones"] = Forasig_Observaciones;
        fila["forasig_FechaCreacionString"] = Forasig_FechaCreacionString;
        fila["forasig_IP"] = Forasig_IP;
        fila["forasig_PC"] = Forasig_PC;
        fila["forasig_HoraCreacionString"] = Forasig_HoraCreacionString;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    



}
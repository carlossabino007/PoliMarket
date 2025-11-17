using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de cls_Procesarhead
/// </summary>
public class cls_Procesarhead : clsconexion
{
    string tabla = "tblProcesaHead";
    protected int idProcesaHead;
    protected int procesa_NumeroDeProcesadoAsignadoEnContadorFormatos;
    protected int procesa_Area;
    protected string procesa_usuario;
    protected string procesa_IP;
    protected string procesa_fechaString;
    protected DateTime procesa_fechaSolamente;
    protected DateTime procesa_fechaYHora;
    protected int procesa_cantidadQueProcesa;
    protected int procesa_CodigoEstudioSeleccionado;
    protected string procesa_NormalORepeticion;
    protected int procesa_Estado;


	public cls_Procesarhead
        (int idProcesaHead, int procesa_NumeroDeProcesadoAsignadoEnContadorFormatos, int procesa_Area,
        string procesa_usuario, string procesa_IP, string procesa_fechaString, DateTime procesa_fechaSolamente,
        DateTime procesa_fechaYHora, int procesa_cantidadQueProcesa, int procesa_CodigoEstudioSeleccionado,
        string procesa_NormalORepeticion, int procesa_Estado)
	{
        this.idProcesaHead = idProcesaHead;
        this.procesa_NumeroDeProcesadoAsignadoEnContadorFormatos=procesa_NumeroDeProcesadoAsignadoEnContadorFormatos;
        this.procesa_Area = procesa_Area;
        this.procesa_usuario = procesa_usuario;
        this.procesa_IP = procesa_IP;
        this.procesa_fechaString = procesa_fechaString;
        this.procesa_fechaSolamente = procesa_fechaSolamente;
        this.procesa_fechaYHora=procesa_fechaYHora;
        this.procesa_cantidadQueProcesa = procesa_cantidadQueProcesa;
        this.procesa_CodigoEstudioSeleccionado = procesa_CodigoEstudioSeleccionado;
        this.procesa_NormalORepeticion = procesa_NormalORepeticion;
        this.procesa_Estado = procesa_Estado;
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    public int IdProcesaHead 
    {
        set { idProcesaHead = value; }
        get { return idProcesaHead; }
    }

    public int Procesa_NumeroDeProcesadoAsignadoEnContadorFormatos
    {
        set { procesa_NumeroDeProcesadoAsignadoEnContadorFormatos = value; }
        get { return procesa_NumeroDeProcesadoAsignadoEnContadorFormatos; }
    }

    public int Procesa_Area
    {
        set { procesa_Area  = value; }
        get { return procesa_Area; }
    }

    public string Procesa_usuario
    {
        set { procesa_usuario  = value; }
        get { return procesa_usuario; }
    }

    public string Procesa_IP
    {
        set { procesa_IP  = value; }
        get { return procesa_IP; }
    }

        public string Procesa_fechaString
    {
        set { procesa_fechaString  = value; }
        get { return procesa_fechaString; }
    }

        public DateTime Procesa_fechaSolamente
    {
        set { procesa_fechaSolamente  = value; }
        get { return procesa_fechaSolamente; }
    }

        public DateTime Procesa_fechaYHora
    {
        set { procesa_fechaYHora  = value; }
        get { return procesa_fechaYHora; }
     }
   
    public int Procesa_cantidadQueProcesa
    {
        set { procesa_cantidadQueProcesa  = value; }
        get { return procesa_cantidadQueProcesa; }
    }

    public int Procesa_CodigoEstudioSeleccionado
    {
        set { procesa_CodigoEstudioSeleccionado  = value; }
        get { return procesa_CodigoEstudioSeleccionado; }
    }

        public string Procesa_NormalORepeticion
    {
        set { procesa_NormalORepeticion  = value; }
        get { return procesa_NormalORepeticion; }
    }

    public int Procesa_Estado
    {
        set { procesa_Estado  = value; }
        get { return procesa_Estado; }
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["Procesa_NumeroDeProcesadoAsignadoEnContadorFormatos"] = int.Parse(procesa_NumeroDeProcesadoAsignadoEnContadorFormatos.ToString());
        fila["Procesa_Area"] = int.Parse(procesa_Area.ToString());
        fila["Procesa_usuario"] = procesa_usuario;
        fila["Procesa_IP"] = procesa_IP;
        fila["Procesa_fechaString"] = procesa_fechaString;
        fila["Procesa_fechaSolamente"] = procesa_fechaSolamente;
        fila["Procesa_fechaYHora"] = procesa_fechaYHora;
        fila["Procesa_cantidadQueProcesa"] = int.Parse(procesa_cantidadQueProcesa.ToString());
        fila["Procesa_CodigoEstudioSeleccionado"] = int.Parse(procesa_CodigoEstudioSeleccionado.ToString());
        fila["Procesa_NormalORepeticion"] = procesa_NormalORepeticion.ToString();
        fila["Procesa_Estado"] = int.Parse(procesa_Estado.ToString());
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);

    }


    public bool ExistePorElCodigoGeneradoEnContadorFormatos(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["procesa_NumeroDeProcesadoAsignadoEnContadorFormatos"].ToString().Equals(valor))
            {

                IdProcesaHead = int.Parse(fila["idProcesaHead"].ToString());
                Procesa_NumeroDeProcesadoAsignadoEnContadorFormatos = int.Parse(fila["procesa_NumeroDeProcesadoAsignadoEnContadorFormatos"].ToString());
                Procesa_Area = int.Parse(fila["procesa_Area"].ToString());
                Procesa_usuario = fila["procesa_usuario"].ToString();
                Procesa_IP = fila["procesa_IP"].ToString();
                Procesa_fechaString = fila["procesa_fechaString"].ToString();
                Procesa_fechaSolamente = DateTime.Parse(fila[("procesa_fechaSolamente")].ToString());
                Procesa_fechaYHora = DateTime.Parse(fila[("procesa_fechaYHora")].ToString());
                Procesa_cantidadQueProcesa = int.Parse(fila["procesa_cantidadQueProcesa"].ToString());
                Procesa_CodigoEstudioSeleccionado = int.Parse(fila["procesa_CodigoEstudioSeleccionado"].ToString());
                Procesa_NormalORepeticion = fila["procesa_NormalORepeticion"].ToString();
                Procesa_Estado = int.Parse(fila["procesa_Estado"].ToString());
                return true;
            }
        }

        return false;
    }


    public bool ExistePorElIDGenerado(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["idProcesaHead"].ToString().Equals(valor))
            {
                Procesa_NumeroDeProcesadoAsignadoEnContadorFormatos = int.Parse(fila["procesa_NumeroDeProcesadoAsignadoEnContadorFormatos"].ToString());
                Procesa_Area = int.Parse(fila["procesa_Area"].ToString());
                Procesa_usuario = fila["procesa_usuario"].ToString();
                Procesa_IP = fila["procesa_IP"].ToString();
                Procesa_fechaString = fila["procesa_fechaString"].ToString();
                Procesa_fechaSolamente = DateTime.Parse(fila[("procesa_fechaSolamente")].ToString());
                Procesa_fechaYHora = DateTime.Parse(fila[("procesa_fechaYHora")].ToString());
                Procesa_cantidadQueProcesa = int.Parse(fila["procesa_cantidadQueProcesa"].ToString());
                Procesa_CodigoEstudioSeleccionado = int.Parse(fila["procesa_CodigoEstudioSeleccionado"].ToString());
                Procesa_NormalORepeticion = fila["procesa_NormalORepeticion"].ToString();
                Procesa_Estado = int.Parse(fila["procesa_Estado"].ToString());
                return true;
            }
        }

        return false;
    }



}
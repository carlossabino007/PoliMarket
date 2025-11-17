using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;


public class cls_PaginaControlPlanillasMain: clsconexion
{

    string tabla = "tblHistorias";
    protected int idPlanilla;
    protected string planilla_codigoPlanillaHistoria;
    protected DateTime planilla_Fecha;
    protected DateTime planilla_FechayHora;
    protected string planilla_IPDondeRegistra;
    protected string planilla_UsuarioQueRegistra;
    protected int idPlanilla_AreadeLasPlanillas;
    protected bool planilla_RecibeArchivo;
    protected DateTime planilla_RecibeArchivo_Fecha;
    protected DateTime planilla_RecibeArchivo_FechaYHora;
    protected string planilla_UsuarioArchivoQueRecibe;
    protected string planilla_IPDondeRecibeArhivo;
    protected int planilla_EstadoPlanilla;
    protected string planilla_Observaciones;
    protected int planilla_PlantillaQuesUsaParaImprimir;


	public cls_PaginaControlPlanillasMain(int idPlanilla, string planilla_codigoPlanillaHistoria, DateTime planilla_Fecha,DateTime planilla_FechayHora,string planilla_IPDondeRegistra,string planilla_UsuarioQueRegistra, int idPlanilla_AreadeLasPlanillas, bool planilla_RecibeArchivo,
        DateTime planilla_RecibeArchivo_Fecha, DateTime planilla_RecibeArchivo_FechaYHora, string planilla_UsuarioArchivoQueRecibe, string planilla_IPDondeRecibeArhivo, int planilla_EstadoPlanilla, string planilla_Observaciones,
        int planilla_PlantillaQuesUsaParaImprimir)
	{
    this.idPlanilla=idPlanilla;
    this.planilla_codigoPlanillaHistoria = planilla_codigoPlanillaHistoria;
    this.planilla_Fecha = planilla_Fecha;
    this.planilla_FechayHora=planilla_FechayHora;
    this.planilla_IPDondeRegistra=planilla_IPDondeRegistra;
    this.planilla_UsuarioQueRegistra=planilla_UsuarioQueRegistra;
    this.idPlanilla_AreadeLasPlanillas=idPlanilla_AreadeLasPlanillas;
    this.planilla_RecibeArchivo=planilla_RecibeArchivo;
    this.planilla_RecibeArchivo_Fecha=planilla_RecibeArchivo_Fecha;
    this.planilla_RecibeArchivo_FechaYHora=planilla_RecibeArchivo_FechaYHora;
    this.planilla_UsuarioArchivoQueRecibe=planilla_UsuarioArchivoQueRecibe;
    this.planilla_IPDondeRecibeArhivo=planilla_IPDondeRecibeArhivo;
    this.planilla_EstadoPlanilla=planilla_EstadoPlanilla;
    this.planilla_Observaciones=planilla_Observaciones;
    this.planilla_PlantillaQuesUsaParaImprimir = planilla_PlantillaQuesUsaParaImprimir;
	}


    public int IdPlanilla
    {
        set { idPlanilla = value; }
        get { return idPlanilla; }
    }


    public string Planilla_codigoPlanillaHistoria
    {
        set { planilla_codigoPlanillaHistoria = value; }
        get { return planilla_codigoPlanillaHistoria; }
    }



    public DateTime Planilla_Fecha
    {
        set { planilla_Fecha = value; }
        get { return planilla_Fecha; }
    }


    public DateTime Planilla_FechayHora
    {
        set { planilla_FechayHora = value; }
        get { return planilla_FechayHora; }
    }

    public string Planilla_IPDondeRegistra
    {
        set { planilla_IPDondeRegistra = value; }
        get { return planilla_IPDondeRegistra; }
    }

    public string Planilla_UsuarioQueRegistra
    {
        set { planilla_UsuarioQueRegistra = value; }
        get { return planilla_UsuarioQueRegistra; }
    }

    public int IdPlanilla_AreadeLasPlanillas
    {
        set { idPlanilla_AreadeLasPlanillas = value; }
        get { return idPlanilla_AreadeLasPlanillas; }
    }

    public bool Planilla_RecibeArchivo
    {
        set { planilla_RecibeArchivo = value; }
        get { return planilla_RecibeArchivo; }
    }

    public DateTime Planilla_RecibeArchivo_Fecha
    {
        set { planilla_RecibeArchivo_Fecha = value; }
        get { return planilla_RecibeArchivo_Fecha; }
    }

    public DateTime Planilla_RecibeArchivo_FechaYHora
    {
        set { planilla_RecibeArchivo_FechaYHora = value; }
        get { return planilla_RecibeArchivo_FechaYHora; }
    }

    public string Planilla_UsuarioArchivoQueRecibe
    {
        set { planilla_UsuarioArchivoQueRecibe = value; }
        get { return planilla_UsuarioArchivoQueRecibe; }
    }

    public string Planilla_IPDondeRecibeArhivo
    {
        set { planilla_IPDondeRecibeArhivo = value; }
        get { return planilla_IPDondeRecibeArhivo; }
    }

    public int Planilla_EstadoPlanilla
    {
        set { planilla_EstadoPlanilla = value; }
        get { return planilla_EstadoPlanilla; }
    }

    public string Planilla_Observaciones
    {
        set { planilla_Observaciones = value; }
        get { return planilla_Observaciones; }
    }


    public int Planilla_PlantillaQuesUsaParaImprimir
    {
        set { planilla_PlantillaQuesUsaParaImprimir = value; }
        get { return planilla_PlantillaQuesUsaParaImprimir; }
    }




    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();

        fila["idPlanilla"] = int.Parse(IdPlanilla.ToString());
        fila["planilla_codigoPlanillaHistoria"] = Planilla_codigoPlanillaHistoria;
        fila["planilla_Fecha"] =Planilla_Fecha;
        fila["planilla_FechayHora"] =Planilla_FechayHora;
        fila["planilla_IPDondeRegistra"] = Planilla_IPDondeRegistra;
        fila["Planilla_UsuarioQueRegistra"] = Planilla_UsuarioQueRegistra;
        fila["idPlanilla_AreadeLasPlanillas"] = int.Parse(IdPlanilla_AreadeLasPlanillas.ToString());
        fila["planilla_RecibeArchivo"] = bool.Parse(Planilla_RecibeArchivo.ToString());
        fila["planilla_RecibeArchivo_Fecha"] = Planilla_RecibeArchivo_Fecha;
        fila["planilla_RecibeArchivo_FechaYHora"] = Planilla_RecibeArchivo_FechaYHora;
        fila["planilla_UsuarioArchivoQueRecibe"] = Planilla_UsuarioArchivoQueRecibe;
        fila["planilla_IPDondeRecibeArhivo"] = Planilla_IPDondeRecibeArhivo;
        fila["planilla_EstadoPlanilla"] = int.Parse(Planilla_EstadoPlanilla.ToString());
        fila["planilla_Observaciones"] = Planilla_Observaciones;
        fila["planilla_PlantillaQuesUsaParaImprimir"] = int.Parse(Planilla_PlantillaQuesUsaParaImprimir.ToString());

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }








    public bool existe(string valor)  // por historia
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (fila["planilla_codigoPlanillaHistoria"].ToString() == valor)
                {

                    IdPlanilla= int.Parse(fila["IdPlanilla"].ToString());
                    Planilla_codigoPlanillaHistoria = fila["Planilla_codigoPlanillaHistoria"].ToString();
                    Planilla_Fecha=DateTime.Parse(fila[("Planilla_Fecha")].ToString());
                    Planilla_FechayHora=DateTime.Parse(fila[("planilla_FechayHora")].ToString());
                    Planilla_IPDondeRegistra=fila["planilla_IPDondeRegistra"].ToString();
                    Planilla_UsuarioQueRegistra=fila["planilla_UsuarioQueRegistra"].ToString();
                    IdPlanilla_AreadeLasPlanillas= int.Parse(fila["idplanilla_AreadeLasPlanillas"].ToString());
                    Planilla_RecibeArchivo=bool.Parse(fila["planilla_RecibeArchivo"].ToString());
                    Planilla_RecibeArchivo_Fecha=DateTime.Parse(fila[("planilla_RecibeArchivo_Fecha")].ToString());
                    Planilla_RecibeArchivo_FechaYHora=DateTime.Parse(fila[("planilla_RecibeArchivo_FechaYHora")].ToString());
                    Planilla_UsuarioArchivoQueRecibe=fila["planilla_UsuarioArchivoQueRecibe"].ToString();
                    Planilla_IPDondeRecibeArhivo=fila["planilla_IPDondeRecibeArhivo"].ToString();
                    Planilla_EstadoPlanilla= int.Parse(fila["planilla_EstadoPlanilla"].ToString());
                    Planilla_Observaciones=fila["planilla_Observaciones"].ToString();
                    Planilla_PlantillaQuesUsaParaImprimir= int.Parse(fila["planilla_PlantillaQuesUsaParaImprimir"].ToString());
                return true;
                }
        } return false;
    }


    public bool existePorId(int valor)  // por id
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (int.Parse(fila["IdPlanilla"].ToString()) == valor)
            {

                Planilla_codigoPlanillaHistoria = fila["Planilla_codigoPlanillaHistoria"].ToString();
                Planilla_Fecha = DateTime.Parse(fila[("Planilla_Fecha")].ToString());
                Planilla_FechayHora = DateTime.Parse(fila[("planilla_FechayHora")].ToString());
                Planilla_IPDondeRegistra = fila["planilla_IPDondeRegistra"].ToString();
                Planilla_UsuarioQueRegistra = fila["planilla_UsuarioQueRegistra"].ToString();
                IdPlanilla_AreadeLasPlanillas = int.Parse(fila["idplanilla_AreadeLasPlanillas"].ToString());
                Planilla_RecibeArchivo = bool.Parse(fila["planilla_RecibeArchivo"].ToString());
                Planilla_RecibeArchivo_Fecha = DateTime.Parse(fila[("planilla_RecibeArchivo_Fecha")].ToString());
                Planilla_RecibeArchivo_FechaYHora = DateTime.Parse(fila[("planilla_RecibeArchivo_FechaYHora")].ToString());
                Planilla_UsuarioArchivoQueRecibe = fila["planilla_UsuarioArchivoQueRecibe"].ToString();
                Planilla_IPDondeRecibeArhivo = fila["planilla_IPDondeRecibeArhivo"].ToString();
                Planilla_EstadoPlanilla = int.Parse(fila["planilla_EstadoPlanilla"].ToString());
                Planilla_Observaciones = fila["planilla_Observaciones"].ToString();
                Planilla_PlantillaQuesUsaParaImprimir = int.Parse(fila["planilla_PlantillaQuesUsaParaImprimir"].ToString());
                return true;
            }
        } return false;
    }


    public bool existePorCodigodeHistoria(string valor)  // por id
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];


            if ((fila["Planilla_codigoPlanillaHistoria"].ToString()) == valor)
                //if (int.Parse(fila["IdPlanilla"].ToString()) == valor)
            {

                IdPlanilla = int.Parse(fila["idPlanilla"].ToString());
                Planilla_Fecha = DateTime.Parse(fila[("Planilla_Fecha")].ToString());
                Planilla_FechayHora = DateTime.Parse(fila[("planilla_FechayHora")].ToString());
                Planilla_IPDondeRegistra = fila["planilla_IPDondeRegistra"].ToString();
                Planilla_UsuarioQueRegistra = fila["planilla_UsuarioQueRegistra"].ToString();
                IdPlanilla_AreadeLasPlanillas = int.Parse(fila["idplanilla_AreadeLasPlanillas"].ToString());
                Planilla_RecibeArchivo = bool.Parse(fila["planilla_RecibeArchivo"].ToString());
                Planilla_RecibeArchivo_Fecha = DateTime.Parse(fila[("planilla_RecibeArchivo_Fecha")].ToString());
                Planilla_RecibeArchivo_FechaYHora = DateTime.Parse(fila[("planilla_RecibeArchivo_FechaYHora")].ToString());
                Planilla_UsuarioArchivoQueRecibe = fila["planilla_UsuarioArchivoQueRecibe"].ToString();
                Planilla_IPDondeRecibeArhivo = fila["planilla_IPDondeRecibeArhivo"].ToString();
                Planilla_EstadoPlanilla = int.Parse(fila["planilla_EstadoPlanilla"].ToString());
                Planilla_Observaciones = fila["planilla_Observaciones"].ToString();
                Planilla_PlantillaQuesUsaParaImprimir = int.Parse(fila["planilla_PlantillaQuesUsaParaImprimir"].ToString());
                return true;
            }
        } return false;
    }





    public bool actualizar(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["IdPlanilla"].ToString()) == valor)
            {
                fila["planilla_RecibeArchivo"] = Planilla_RecibeArchivo;
                fila["planilla_UsuarioArchivoQueRecibe"] = Planilla_UsuarioArchivoQueRecibe;
                fila["planilla_IPDondeRecibeArhivo"] = Planilla_IPDondeRecibeArhivo;
                fila["planilla_RecibeArchivo_Fecha"] = Planilla_RecibeArchivo_Fecha;
                fila["planilla_RecibeArchivo_FechaYHora"] = Planilla_RecibeArchivo_FechaYHora;

                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarEnEdicionCODIGO(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["IdPlanilla"].ToString()) == valor)
            {
                fila["planilla_codigoPlanillaHistoria"] = Planilla_codigoPlanillaHistoria;
                fila["planilla_Fecha"] = Planilla_Fecha;
                fila["planilla_FechayHora"] = Planilla_FechayHora;
                fila["planilla_IPDondeRegistra"] = Planilla_IPDondeRegistra;
                fila["planilla_UsuarioQueRegistra"] = Planilla_UsuarioQueRegistra;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool actualizarEnEdicionAREAS(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["IdPlanilla"].ToString()) == valor)
            {
                fila["idPlanilla_AreadeLasPlanillas"] = IdPlanilla_AreadeLasPlanillas;
                fila["planilla_Fecha"] = Planilla_Fecha;
                fila["planilla_FechayHora"] = Planilla_FechayHora;
                fila["planilla_IPDondeRegistra"] = Planilla_IPDondeRegistra;
                fila["planilla_UsuarioQueRegistra"] = Planilla_UsuarioQueRegistra;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }



}

















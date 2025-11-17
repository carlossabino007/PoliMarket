using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_PermidosParaDescargarPDFCalidad: clsconexion
{
    string tabla = "tblPermisosPorRolParaDescargaPDFCalidad";
    protected int idGridPermisosPorRol, permisoCodRol;
    protected string c01_AtencionAlCliente;
    protected string c02_Compras;
    protected string c03_ListadosMaestros;
    protected string c04_MntoDeEquipos;
    protected string c05_MejoraContinua;
    protected string c06_Paternidades_MaternidadesADN;
    protected string c07_PlaneacionEstrategica;
    protected string c08_RecursoHumano;
    protected string c09_RegistroRecepcion;
    protected string c10_SistemasArchivo;
    protected string c11_UsoComun;
    protected string c12_AreaCitogenetica;
    protected string c13_AreaInmunogenetica;
    protected string c14_AreaDiagnistocoMolecular;
    protected string c15_AreaMicroarreglos;
    protected string c16_SaludYSeguridadEnEntrabajo;
    protected string c17_DiagnosticoMolecular;
    protected string c21_AuxLaboratorio;



    public cls_PermidosParaDescargarPDFCalidad(int idGridPermisosPorRol,int permisoCodRol, string c01_AtencionAlCliente, string c02_Compras,
    string c03_ListadosMaestros, string c04_MntoDeEquipos, string c05_MejoraContinua, string c06_Paternidades_MaternidadesADN,
    string c07_PlaneacionEstrategica, string c08_RecursoHumano, string c09_RegistroRecepcion, string c10_SistemasArchivo,
    string c11_UsoComun, string c12_AreaCitogenetica, string c13_AreaInmunogenetica, string c14_AreaDiagnistocoMolecular,
    string c15_AreaMicroarreglos, string c16_SaludYSeguridadEnEntrabajo, string c17_DiagnosticoMolecular, string c21_AuxLaboratorio)
    {
        this.idGridPermisosPorRol = idGridPermisosPorRol;
        this.permisoCodRol = permisoCodRol;
        this.c01_AtencionAlCliente = c01_AtencionAlCliente;
        this.c02_Compras = c02_Compras;
        this.c03_ListadosMaestros = c03_ListadosMaestros;
        this.c04_MntoDeEquipos = c04_MntoDeEquipos;
        this.c05_MejoraContinua = c05_MejoraContinua;
        this.c06_Paternidades_MaternidadesADN = c06_Paternidades_MaternidadesADN;
        this.c07_PlaneacionEstrategica = c07_PlaneacionEstrategica;
        this.c08_RecursoHumano = c08_RecursoHumano;
        this.c09_RegistroRecepcion = c09_RegistroRecepcion;
        this.c10_SistemasArchivo = c10_SistemasArchivo;
        this.c11_UsoComun = c11_UsoComun;
        this.c12_AreaCitogenetica = c12_AreaCitogenetica;
        this.c13_AreaInmunogenetica = c13_AreaInmunogenetica;
        this.c14_AreaDiagnistocoMolecular = c14_AreaDiagnistocoMolecular;
        this.c15_AreaMicroarreglos = c15_AreaMicroarreglos;
        this.c16_SaludYSeguridadEnEntrabajo = c16_SaludYSeguridadEnEntrabajo;
        this.c17_DiagnosticoMolecular = c17_DiagnosticoMolecular;
        this.c21_AuxLaboratorio=c21_AuxLaboratorio;
    }

    public int PermisoCodRol
    {
        get { return permisoCodRol; }
        set { permisoCodRol = value; }
    }
    public string C01_AtencionAlCliente
    {
        get { return c01_AtencionAlCliente; }
        set { c01_AtencionAlCliente = value; }
    }
    public string C02_Compras
    {
        get { return c02_Compras; }
        set { c02_Compras = value; }
    }
    public string C03_ListadosMaestros
    {
        get { return c03_ListadosMaestros; }
        set { c03_ListadosMaestros = value; }
    }
    public string C04_MntoDeEquipos
    {
        get { return c04_MntoDeEquipos; }
        set { c04_MntoDeEquipos = value; }
    }
    public string C05_MejoraContinua
    {
        get { return c05_MejoraContinua; }
        set { c05_MejoraContinua = value; }
    }
    public string C06_Paternidades_MaternidadesADN
    {
        get { return c06_Paternidades_MaternidadesADN; }
        set { c06_Paternidades_MaternidadesADN = value; }
    }
    public string C07_PlaneacionEstrategica
    {
        get { return c07_PlaneacionEstrategica; }
        set { c07_PlaneacionEstrategica = value; }
    }
    public string C08_RecursoHumano
    {
        get { return c08_RecursoHumano; }
        set { c08_RecursoHumano = value; }
    }
    public string C09_RegistroRecepcion
    {
        get { return c09_RegistroRecepcion; }
        set { c09_RegistroRecepcion = value; }
    }
    public string C10_SistemasArchivo
    {
        get { return c10_SistemasArchivo; }
        set { c10_SistemasArchivo = value; }
    }
    public string C11_UsoComun
    {
        get { return c11_UsoComun; }
        set { c11_UsoComun = value; }
    }
    public string C12_AreaCitogenetica
    {
        get { return c12_AreaCitogenetica; }
        set { c12_AreaCitogenetica = value; }
    }
    public string C13_AreaInmunogenetica
    {
        get { return c13_AreaInmunogenetica; }
        set { c13_AreaInmunogenetica = value; }
    }
    public string C14_AreaDiagnistocoMolecular
    {
        get { return c14_AreaDiagnistocoMolecular; }
        set { c14_AreaDiagnistocoMolecular = value; }
    }
    public string C15_AreaMicroarreglos
    {
        get { return c15_AreaMicroarreglos; }
        set { c15_AreaMicroarreglos = value; }
    }

    public string C16_SaludYSeguridadEnEntrabajo
    {
        get { return c16_SaludYSeguridadEnEntrabajo; }
        set { c16_SaludYSeguridadEnEntrabajo = value; }
    }

    public string C17_DiagnosticoMolecular
    {
        get { return c17_DiagnosticoMolecular; }
        set { c17_DiagnosticoMolecular = value; }
    }

    public string C21_AuxLaboratorio
    {
        get { return c21_AuxLaboratorio; }
        set { c21_AuxLaboratorio = value; }
    }


    public bool ExisteGrupo(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["permisoCodRol"].ToString()) == valor)
            {
                C01_AtencionAlCliente = fila["c01_AtencionAlCliente"].ToString();
                C02_Compras=fila["c02_Compras"].ToString();
                C03_ListadosMaestros = fila["c03_ListadosMaestros"].ToString();
                C04_MntoDeEquipos = fila["c04_MntoDeEquipos"].ToString();
                C05_MejoraContinua = fila["c05_MejoraContinua"].ToString();
                C06_Paternidades_MaternidadesADN = fila["c06_Paternidades_MaternidadesADN"].ToString();
                C07_PlaneacionEstrategica = fila["c07_PlaneacionEstrategica"].ToString();
                C08_RecursoHumano = fila["c08_RecursoHumano"].ToString();
                C09_RegistroRecepcion = fila["c09_RegistroRecepcion"].ToString();
                C10_SistemasArchivo = fila["c10_SistemasArchivo"].ToString();
                C11_UsoComun = fila["c11_UsoComun"].ToString();
                C12_AreaCitogenetica = fila["c12_AreaCitogenetica"].ToString();
                C13_AreaInmunogenetica = fila["c13_AreaInmunogenetica"].ToString();
                C14_AreaDiagnistocoMolecular = fila["c14_AreaDiagnistocoMolecular"].ToString();
                C15_AreaMicroarreglos = fila["c15_AreaMicroarreglos"].ToString();
                C16_SaludYSeguridadEnEntrabajo = fila["c16_SaludYSeguridadEnEntrabajo"].ToString();
                C17_DiagnosticoMolecular = fila["c17_DiagnosticoMolecular"].ToString();
                C21_AuxLaboratorio = fila["c21_AuxLaboratorio"].ToString();
                return true;

            }
        } return false;
    }


    public bool ActualizarCliente(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["permisoCodRol"].ToString()) == valor)
            {
                fila["c01_AtencionAlCliente"] = C01_AtencionAlCliente;
                fila["c02_Compras"] = C02_Compras;
                fila["c03_ListadosMaestros"] = C03_ListadosMaestros;
                fila["c04_MntoDeEquipos"] = C04_MntoDeEquipos;
                fila["c05_MejoraContinua"] = C05_MejoraContinua;
                fila["c06_Paternidades_MaternidadesADN"] = C06_Paternidades_MaternidadesADN;
                fila["c07_PlaneacionEstrategica"] = C07_PlaneacionEstrategica;
                fila["c08_RecursoHumano"] = C08_RecursoHumano;
                fila["c09_RegistroRecepcion"] = C09_RegistroRecepcion;
                fila["c10_SistemasArchivo"] = C10_SistemasArchivo;
                fila["c11_UsoComun"] = C11_UsoComun;
                fila["c12_AreaCitogenetica"] = C12_AreaCitogenetica;
                fila["c13_AreaInmunogenetica"] = C13_AreaInmunogenetica;
                fila["c14_AreaDiagnistocoMolecular"] = C14_AreaDiagnistocoMolecular;
                fila["c15_AreaMicroarreglos"] = C15_AreaMicroarreglos;
                fila["C16_SaludYSeguridadEnEntrabajo"] = c16_SaludYSeguridadEnEntrabajo;
                fila["C17_DiagnosticoMolecular"] = c17_DiagnosticoMolecular;
                fila["C21_AuxLaboratorio"] = c21_AuxLaboratorio;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }




}
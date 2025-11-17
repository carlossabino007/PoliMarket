using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de cls_CreacionDeUsuarios
/// </summary>
public class cls_CreacionDeUsuarios: clsconexion
{

    string tabla = "tblUsuario";
    protected int idCodUsuario, usuario_AreaDeTrabajo, usuario_RolEnLaEmpresa, usuario_estado;
    protected string usuario_codigo, usuario_Apellido1, usuario_Apellido2, usuario_nombre1, usuario_nombre2, usuario_contrasena, usuario_Observaciones, usuario_CorreoElectronico;
    protected int usuario_estadoDeConexion;
    protected DateTime usuario_FechaHoraDeConexion, usuario_FechaDeConexion;
    protected string usuario_IPDeConexion;
    protected int usuario_SalidaCorrecta;
   

    //public static int RolLogueado;
    //public static string UsuarioLogueado;
    //public static int CodUsuarioLogueado;
   

	public cls_CreacionDeUsuarios(int idCodUsuario, int usuario_AreaDeTrabajo, int usuario_RolEnLaEmpresa,int usuario_estado,
        string usuario_codigo, string usuario_Apellido1, string usuario_Apellido2, string usuario_nombre1, string usuario_nombre2, string usuario_contrasena, string usuario_Observaciones, string usuario_CorreoElectronico,
        int usuario_estadoDeConexion, DateTime usuario_FechaHoraDeConexion, DateTime usuario_FechaDeConexion, string usuario_IPDeConexion, int usuario_SalidaCorrecta)
	{
        //int
        this.idCodUsuario = idCodUsuario;
        this.usuario_AreaDeTrabajo=usuario_AreaDeTrabajo;
        this.usuario_RolEnLaEmpresa=usuario_RolEnLaEmpresa;
        this.usuario_estado = usuario_estado;

        // string
        this.usuario_codigo = usuario_codigo;
        this.usuario_Apellido1 = usuario_Apellido1;
        this.usuario_Apellido2 = usuario_Apellido2;
        this.usuario_nombre1 = usuario_nombre1;
        this.usuario_nombre2 = usuario_nombre2;
        this.usuario_contrasena = usuario_contrasena;
        this.usuario_Observaciones = usuario_Observaciones;
        this.usuario_CorreoElectronico = usuario_CorreoElectronico;

        this.usuario_estadoDeConexion = usuario_estadoDeConexion;
        this.usuario_FechaHoraDeConexion = usuario_FechaHoraDeConexion;
        this.usuario_IPDeConexion=usuario_IPDeConexion;

        this.usuario_SalidaCorrecta = usuario_SalidaCorrecta;


	}

    //int
    public cls_CreacionDeUsuarios()
    {
    }

    public int IdCodUsuario 
    {
        set { idCodUsuario = value; }
        get { return idCodUsuario; }
    }

    public int Usuario_AreaDeTrabajo
    {
        set { usuario_AreaDeTrabajo = value; }
        get { return usuario_AreaDeTrabajo; }
    }

    public int Usuario_RolEnLaEmpresa
    {
        set { usuario_RolEnLaEmpresa = value; }
        get { return usuario_RolEnLaEmpresa; }
    }

    public int Usuario_estado
    {
        set { usuario_estado = value; }
        get { return usuario_estado; }
    }

    // string

    public string Usuario_codigo
    {
        set { usuario_codigo = value; }
        get { return usuario_codigo; }
    }

    public string Usuario_Apellido1
    {
        set { usuario_Apellido1 = value; }
        get { return usuario_Apellido1; }
    }

    public string Usuario_Apellido2
    {
        set { usuario_Apellido2 = value; }
        get { return usuario_Apellido2; }
    }

    public string Usuario_nombre1
    {
        set { usuario_nombre1 = value; }
        get { return usuario_nombre1; }
    }

    public string Usuario_nombre2
    {
        set { usuario_nombre2 = value; }
        get { return usuario_nombre2; }
    }
        
    public string Usuario_contrasena
    {
        set { usuario_contrasena = value; }
        get { return usuario_contrasena; }
    }

    public string Usuario_Observaciones
    {
        set { usuario_Observaciones = value; }
        get { return usuario_Observaciones; }
    }



    public string Usuario_CorreoElectronico
    {
        set { usuario_CorreoElectronico = value; }
        get { return usuario_CorreoElectronico; }
    }


    public int Usuario_estadoDeConexion
    {
        set { usuario_estadoDeConexion = value; }
        get { return usuario_estadoDeConexion; }
    }

    public DateTime Usuario_FechaHoraDeConexion
    {
        set { usuario_FechaHoraDeConexion = value; }
        get { return usuario_FechaHoraDeConexion; }
    }

    public DateTime Usuario_FechaDeConexion
    {
        set { usuario_FechaDeConexion = value; }
        get { return usuario_FechaDeConexion; }
    }


    public string Usuario_IPDeConexion
    {
        set { usuario_IPDeConexion = value; }
        get { return usuario_IPDeConexion; }
    }

    public int Usuario_SalidaCorrecta
    {
        set { usuario_SalidaCorrecta = value; }
        get { return usuario_SalidaCorrecta; }
    }


    



    public bool existe(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["usuario_codigo"].ToString() == valor)
            {
                IdCodUsuario  = int.Parse(fila["idCodUsuario"].ToString());
                Usuario_AreaDeTrabajo = int.Parse(fila["usuario_AreaDeTrabajo"].ToString());
                Usuario_RolEnLaEmpresa= int.Parse(fila["usuario_RolEnLaEmpresa"].ToString());
                Usuario_estado = int.Parse(fila["usuario_estado"].ToString());
                Usuario_estadoDeConexion = int.Parse(fila["usuario_estadoDeConexion"].ToString());

                Usuario_codigo = fila["usuario_codigo"].ToString();
                Usuario_Apellido1 = fila["usuario_Apellido1"].ToString();
                Usuario_Apellido2 = fila["usuario_Apellido2"].ToString();
                Usuario_nombre1 = fila["usuario_nombre1"].ToString();
                Usuario_nombre2 = fila["usuario_nombre2"].ToString();
                Usuario_nombre2 = fila["usuario_nombre2"].ToString();
                Usuario_contrasena = fila["usuario_contrasena"].ToString();
                Usuario_Observaciones = fila["usuario_Observaciones"].ToString();
                Usuario_CorreoElectronico = fila["usuario_CorreoElectronico"].ToString();
                Usuario_estadoDeConexion = int.Parse(fila["usuario_estadoDeConexion"].ToString());
                Usuario_IPDeConexion = fila["usuario_IPDeConexion"].ToString();
                Usuario_SalidaCorrecta = int.Parse(fila["usuario_SalidaCorrecta"].ToString());

                return true;

            }
        } return false;
    }



    public bool existePorId(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idCodUsuario"].ToString()) == valor)
            {
                Usuario_AreaDeTrabajo = int.Parse(fila["usuario_AreaDeTrabajo"].ToString());
                Usuario_RolEnLaEmpresa = int.Parse(fila["usuario_RolEnLaEmpresa"].ToString());
                Usuario_estado = int.Parse(fila["usuario_estado"].ToString());
                Usuario_codigo = fila["usuario_codigo"].ToString();
                Usuario_Apellido1 = fila["usuario_Apellido1"].ToString();
                Usuario_Apellido2 = fila["usuario_Apellido2"].ToString();
                Usuario_nombre1 = fila["usuario_nombre1"].ToString();
                Usuario_nombre2 = fila["usuario_nombre2"].ToString();
                Usuario_nombre2 = fila["usuario_nombre2"].ToString();
                Usuario_contrasena = fila["usuario_contrasena"].ToString();
                Usuario_Observaciones = fila["usuario_Observaciones"].ToString();
                Usuario_CorreoElectronico = fila["usuario_CorreoElectronico"].ToString();
                Usuario_estadoDeConexion = int.Parse(fila["usuario_estadoDeConexion"].ToString());
                Usuario_IPDeConexion = fila["usuario_IPDeConexion"].ToString();
                Usuario_SalidaCorrecta = int.Parse(fila["usuario_SalidaCorrecta"].ToString());
                return true;

            }
        } return false;
    }



    public bool existePorIP(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["usuario_IPDeConexion"].ToString() == valor)
            {
                Usuario_AreaDeTrabajo = int.Parse(fila["usuario_AreaDeTrabajo"].ToString());
                Usuario_RolEnLaEmpresa = int.Parse(fila["usuario_RolEnLaEmpresa"].ToString());
                IdCodUsuario = int.Parse(fila["idCodUsuario"].ToString());
                Usuario_codigo = fila["usuario_codigo"].ToString();
                Usuario_Apellido1 = fila["usuario_Apellido1"].ToString();
                Usuario_Apellido2 = fila["usuario_Apellido2"].ToString();
                Usuario_nombre1 = fila["usuario_nombre1"].ToString();
                Usuario_nombre2 = fila["usuario_nombre2"].ToString();
                Usuario_nombre2 = fila["usuario_nombre2"].ToString();
                Usuario_contrasena = fila["usuario_contrasena"].ToString();
                Usuario_Observaciones = fila["usuario_Observaciones"].ToString();
                Usuario_CorreoElectronico = fila["usuario_CorreoElectronico"].ToString();
                Usuario_estadoDeConexion = int.Parse(fila["usuario_estadoDeConexion"].ToString());
                Usuario_IPDeConexion = fila["usuario_IPDeConexion"].ToString();
                Usuario_SalidaCorrecta = int.Parse(fila["usuario_SalidaCorrecta"].ToString());
                return true;
             }
        } return false;
    }




    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["Usuario_AreaDeTrabajo"] = int.Parse(usuario_AreaDeTrabajo.ToString());
        fila["Usuario_RolEnLaEmpresa"] = int.Parse(usuario_RolEnLaEmpresa.ToString());
        fila["Usuario_estado"] = int.Parse(usuario_estado.ToString());
        fila["Usuario_estadoDeConexion"] = int.Parse(usuario_estadoDeConexion.ToString());

        fila["Usuario_codigo"] = usuario_codigo;
        fila["Usuario_Apellido1"] = usuario_Apellido1;
        fila["Usuario_Apellido2"] = usuario_Apellido2;
        fila["Usuario_nombre1"] = usuario_nombre1;
        fila["Usuario_nombre2"]= usuario_nombre2;
        fila["Usuario_contrasena"] = usuario_contrasena;
        fila["Usuario_Observaciones"] = usuario_Observaciones;
        fila["Usuario_CorreoElectronico"] = usuario_CorreoElectronico;

        fila["Usuario_SalidaCorrecta"] = int.Parse(usuario_SalidaCorrecta.ToString());
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);

        
        // Hago publico el nuevo código de Formula ID
        //IdFormula = int.Parse(fila["idFormula"].ToString());

    }


    public bool actualizarPorId(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data .Tables[tabla].Rows[i];
            if (int.Parse(fila["idCodUsuario"].ToString()) == valor)
            {
                fila["usuario_contrasena"] = Usuario_contrasena;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }




    public bool actualizarPorIPLoguedo(string valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["usuario_IPDeConexion"].ToString() == valor)
            {
                fila["usuario_estadoDeConexion"] = Usuario_estadoDeConexion;
                fila["usuario_IPDeConexion"] = Usuario_IPDeConexion;
                fila["usuario_SalidaCorrecta"] = int.Parse(Usuario_SalidaCorrecta.ToString()); 
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarPorIdElRol(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idCodUsuario"].ToString()) == valor)
            {
                fila["usuario_RolEnLaEmpresa"] = Usuario_RolEnLaEmpresa;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }



    public bool ActualizarNeoUsuarioLogueado(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idCodUsuario"].ToString()) == valor)
            {
                fila["usuario_estadoDeConexion"] = Usuario_estadoDeConexion;
                fila["usuario_FechaHoraDeConexion"] = Usuario_FechaHoraDeConexion;
                fila["usuario_FechaDeConexion"] = Usuario_FechaDeConexion;
                fila["usuario_IPDeConexion"] = Usuario_IPDeConexion;
                fila["usuario_SalidaCorrecta"] = usuario_SalidaCorrecta;

                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }





}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de cls_tblCorreo_Movimiento_Head
/// </summary>
public class cls_tblCorreo_Movimiento_Head: clsconexion
{
    string tabla = "tblCorreo_Movimiento_Head";

    #region "Atributos Privados";
    protected int idMovimCorreo, movCorreo_Entidad, movCorreo_Usuario, movCorreo_Estado, modCorreo_CodAsignadoSegunclsContador;
    protected string movCorreo_Observaciones, movCorreo_IP, movCorreo_PC;
    protected DateTime movCorreo_FechaHora, movCorreo_Fecha;
    protected string movCorreo_NumeroDeGuia;
    protected int movCorreo_EmpresaTransportadora;
    protected DateTime movCorreo_FechaGuiaDateCorto;
    protected string movCorreo_FechaGuiaDateCortoString;
    protected string movCorreoQuiienRegistra;

   
    #endregion

    #region "Constructor con parametros";
    public cls_tblCorreo_Movimiento_Head(int idMovimCorreo, int movCorreo_Entidad, int movCorreo_Usuario, int movCorreo_Estado,
        string movCorreo_Observaciones, string movCorreo_IP, string movCorreo_PC,
        DateTime movCorreo_FechaHora, DateTime movCorreo_Fecha, int modCorreo_CodAsignadoSegunclsContador,string movCorreo_NumeroDeGuia,
        int movCorreo_EmpresaTransportadora, DateTime movCorreo_FechaGuiaDateCorto, string movCorreo_FechaGuiaDateCortoString, string movCorreoQuiienRegistra)
	{
		this.idMovimCorreo=idMovimCorreo;
        this.movCorreo_Entidad = movCorreo_Entidad;
        this.movCorreo_Usuario = movCorreo_Usuario;
        this.movCorreo_Observaciones = movCorreo_Observaciones;
        this.movCorreo_IP = movCorreo_IP;
        this.movCorreo_PC = movCorreo_PC;
        this.movCorreo_FechaHora = movCorreo_FechaHora;
        this.movCorreo_Fecha = movCorreo_Fecha;

        this.modCorreo_CodAsignadoSegunclsContador = modCorreo_CodAsignadoSegunclsContador;
        this.movCorreo_NumeroDeGuia = movCorreo_NumeroDeGuia;
        this.movCorreo_EmpresaTransportadora = movCorreo_EmpresaTransportadora;
        this.movCorreo_FechaGuiaDateCorto = movCorreo_FechaGuiaDateCorto;
        this.movCorreo_FechaGuiaDateCortoString = movCorreo_FechaGuiaDateCortoString;
        this.movCorreoQuiienRegistra = movCorreoQuiienRegistra;
       

	}

    public cls_tblCorreo_Movimiento_Head(int idMovimCorreo, string movCorreo_NumeroDeGuia, DateTime movCorreo_FechaGuiaDateCorto, string movCorreo_FechaGuiaDateCortoString, string movCorreoQuiienRegistra)
    {
        this.idMovimCorreo = idMovimCorreo;
        this.movCorreo_NumeroDeGuia = movCorreo_NumeroDeGuia;
        this.movCorreo_FechaGuiaDateCorto = movCorreo_FechaGuiaDateCorto;
        this.movCorreo_FechaGuiaDateCortoString = movCorreo_FechaGuiaDateCortoString;
        this.movCorreoQuiienRegistra = movCorreoQuiienRegistra;
    }


    #endregion

    #region "Propiedades";
    public int IdMovimCorreo
    {
        get { return idMovimCorreo; }
        set { idMovimCorreo = value; }
    }

    public int MovCorreo_Usuario
    {
        get { return movCorreo_Usuario; }
        set { movCorreo_Usuario = value; }
    }

    public int MovCorreo_Estado
    {
        get { return movCorreo_Estado; }
        set { movCorreo_Estado = value; }
    }

    public int MovCorreo_Entidad
    {
        get { return movCorreo_Entidad; }
        set { movCorreo_Entidad = value; }
    }


    public string MovCorreo_PC
    {
        get { return movCorreo_PC; }
        set { movCorreo_PC = value; }
    }

    public string MovCorreo_IP
    {
        get { return movCorreo_IP; }
        set { movCorreo_IP = value; }
    }

    public string MovCorreo_Observaciones
    {
        get { return movCorreo_Observaciones; }
        set { movCorreo_Observaciones = value; }
    }


    public DateTime MovCorreo_Fecha
    {
        get { return movCorreo_Fecha; }
        set { movCorreo_Fecha = value; }
    }

    public DateTime MovCorreo_FechaHora
    {
        get { return movCorreo_FechaHora; }
        set { movCorreo_FechaHora = value; }
    }

    public int ModCorreo_CodAsignadoSegunclsContador
    {
        get { return modCorreo_CodAsignadoSegunclsContador; }
        set { modCorreo_CodAsignadoSegunclsContador = value; }
    }

    public string MovCorreo_NumeroDeGuia
    {
        get { return movCorreo_NumeroDeGuia; }
        set { movCorreo_NumeroDeGuia = value; }
    }

    public int MovCorreo_EmpresaTransportadora
    {
        get { return movCorreo_EmpresaTransportadora; }
        set { movCorreo_EmpresaTransportadora = value; }
    }

    public DateTime MovCorreo_FechaGuiaDateCorto
    {
        get { return movCorreo_FechaGuiaDateCorto; }
        set { movCorreo_FechaGuiaDateCorto = value; }
    }

    public string MovCorreo_FechaGuiaDateCortoString
    {
        get { return movCorreo_FechaGuiaDateCortoString; }
        set { movCorreo_FechaGuiaDateCortoString = value; }
    }

        public string MovCorreoQuiienRegistra
    {
        get { return movCorreoQuiienRegistra; }
        set { movCorreoQuiienRegistra = value; }
    }



    #endregion

    #region "Métodos"
    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        //int
        fila["movCorreo_Entidad"] = int.Parse(MovCorreo_Entidad.ToString());
        fila["movCorreo_Usuario"] = int.Parse(MovCorreo_Usuario.ToString());
        fila["movCorreo_Estado"] = int.Parse(movCorreo_Estado.ToString());
        fila["modCorreo_CodAsignadoSegunclsContador"] = int.Parse(ModCorreo_CodAsignadoSegunclsContador.ToString());
        //string
        fila["movCorreo_Observaciones"] = MovCorreo_Observaciones;
        fila["movCorreo_IP"] = MovCorreo_IP;
        fila["movCorreo_PC"] = MovCorreo_PC;
        //Date Y DateTime
        fila["movCorreo_FechaHora"] = MovCorreo_FechaHora;
        fila["movCorreo_Fecha"] = MovCorreo_Fecha;
        fila["movCorreo_NumeroDeGuia"] = MovCorreo_NumeroDeGuia;
        fila["movCorreo_EmpresaTransportadora"] = int.Parse(MovCorreo_EmpresaTransportadora.ToString()); 
        fila["movCorreo_FechaGuiaDateCorto"] = MovCorreo_FechaGuiaDateCorto;
        fila["movCorreo_FechaGuiaDateCortoString"] = MovCorreo_FechaGuiaDateCortoString;
        fila["movCorreoQuiienRegistra"] = MovCorreoQuiienRegistra;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }

    public bool buscarYObtenerElNumerodeGuia(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["modCorreo_CodAsignadoSegunclsContador"].ToString()) == valor)
            {
                MovCorreo_NumeroDeGuia = fila["movCorreo_NumeroDeGuia"].ToString();
                MovCorreo_Observaciones = fila["movCorreo_Observaciones"].ToString();
                MovCorreo_EmpresaTransportadora = int.Parse(fila["movCorreo_EmpresaTransportadora"].ToString());
                MovCorreo_FechaGuiaDateCortoString = fila["movCorreo_FechaGuiaDateCortoString"].ToString();
                MovCorreo_FechaGuiaDateCortoString = fila["movCorreo_FechaGuiaDateCortoString"].ToString();
                MovCorreoQuiienRegistra = fila["movCorreoQuiienRegistra"].ToString();
                return true;
            }
        } return false;
    }


    public bool actualizarLaGuia(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["modCorreo_CodAsignadoSegunclsContador"].ToString()) == valor)
            {
                fila["movCorreo_NumeroDeGuia"] = MovCorreo_NumeroDeGuia;
                fila["movCorreo_FechaGuiaDateCortoString"] = MovCorreo_FechaGuiaDateCortoString;
                fila["movCorreo_FechaGuiaDateCorto"] = MovCorreo_FechaGuiaDateCorto;
                fila["movCorreoQuiienRegistra"] = MovCorreoQuiienRegistra;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    #endregion


}
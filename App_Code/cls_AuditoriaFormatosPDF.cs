using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Descripción breve de cls_AuditoriaFormatosPDF
/// </summary>
public class cls_AuditoriaFormatosPDF: clsconexion
{

    string tabla = "tbtAuditoriaFormatosPDF";
    protected int idIpUsuarioLogueado;
    protected string usuLogueado_CodigoUsuario;
    protected string usuLogueado_IP;
    protected string usuLogueado_FormatoSeleccionado;
    protected DateTime usuLogueado_FechaSolamente;
    protected DateTime usuLogueado_FechayHora;
    protected string usuLogueado_FechaenString;
    protected string usuLogueado_AccionRealizada;
    
         
	public cls_AuditoriaFormatosPDF(int idIpUsuarioLogueado,string usuLogueado_CodigoUsuario,
    string usuLogueado_IP,string usuLogueado_FormatoSeleccionado,DateTime usuLogueado_FechaSolamente,
    DateTime usuLogueado_FechayHora, string usuLogueado_FechaenString, string usuLogueado_AccionRealizada)
	{
        this.idIpUsuarioLogueado = idIpUsuarioLogueado;
        this.usuLogueado_CodigoUsuario = usuLogueado_CodigoUsuario;
        this.usuLogueado_IP = usuLogueado_IP;
        this.usuLogueado_FormatoSeleccionado = usuLogueado_FormatoSeleccionado;
        this.usuLogueado_FechaSolamente=usuLogueado_FechaSolamente;
        this.usuLogueado_FechayHora = usuLogueado_FechayHora;
        this.usuLogueado_FechaenString = usuLogueado_FechaenString;

        this.usuLogueado_AccionRealizada = usuLogueado_AccionRealizada;
	}


    public int IdIpUsuarioLogueado
    {
        get { return idIpUsuarioLogueado; }
        set { idIpUsuarioLogueado = value; }
    }

    public string UsuLogueado_CodigoUsuario
    {
        get { return usuLogueado_CodigoUsuario; }
        set { usuLogueado_CodigoUsuario = value; }
    }

    public string UsuLogueado_IP
    {
        get { return usuLogueado_IP; }
        set { usuLogueado_IP = value; }
    }

    public string UsuLogueado_FormatoSeleccionado
    {
        get { return usuLogueado_FormatoSeleccionado; }
        set { usuLogueado_FormatoSeleccionado = value; }
    }

    public DateTime UsuLogueado_FechaSolamente
    {
        get { return usuLogueado_FechaSolamente; }
        set { usuLogueado_FechaSolamente = value; }
    }

    public DateTime UsuLogueado_FechayHora
    {
        get { return usuLogueado_FechayHora; }
        set { usuLogueado_FechayHora = value; }
    }

    public string UsuLogueado_FechaenString
    {
        get { return usuLogueado_FechaenString; }
        set { usuLogueado_FechaenString = value; }
    }

        public string UsuLogueado_AccionRealizada
    {
        get { return usuLogueado_AccionRealizada; }
        set { usuLogueado_AccionRealizada = value; }
    }


    public bool existe(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["codigoMuestra"].ToString() == valor)
            {
                UsuLogueado_CodigoUsuario = fila["usuLogueado_CodigoUsuario"].ToString();
                UsuLogueado_IP = fila["usuLogueado_IP"].ToString();
                UsuLogueado_FormatoSeleccionado = fila["usuLogueado_FormatoSeleccionado"].ToString();
                UsuLogueado_FechaSolamente = DateTime.Parse(fila[("usuLogueado_FechaSolamente")].ToString());
                UsuLogueado_FechayHora = DateTime.Parse(fila[("usuLogueado_FechayHora")].ToString());
                UsuLogueado_FechaenString = fila["usuLogueado_FechaenString"].ToString();
                UsuLogueado_AccionRealizada = fila["usuLogueado_AccionRealizada"].ToString();
                return true;
            }
        } return false;
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        //string
        fila["usuLogueado_CodigoUsuario"] = UsuLogueado_CodigoUsuario;
        fila["usuLogueado_IP"] = usuLogueado_IP;
        fila["usuLogueado_FormatoSeleccionado"] = UsuLogueado_FormatoSeleccionado;
        //datetime
        fila["usuLogueado_FechaSolamente"] = UsuLogueado_FechaSolamente;
        fila["usuLogueado_FechayHora"] = UsuLogueado_FechayHora;
        fila["usuLogueado_FechaenString"] = UsuLogueado_FechaenString;
        fila["usuLogueado_AccionRealizada"] = UsuLogueado_AccionRealizada;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }
}
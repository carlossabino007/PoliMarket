using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Descripción breve de cls_tblCITO_IngSegHead
/// </summary>
public class cls_tblCITO_IngSegHead: clsconexion
{
    string tabla = "tblCITO_IngSegHead";
    protected int iditem, planilla,estado;
    protected string usuarioResponsableQuerecibe, ipCreacion, quienEntregaenTX, observacionPlanilla;
    protected DateTime fechaCreacion;


	public cls_tblCITO_IngSegHead(int iditem, int planilla,int estado, string usuarioResponsableQuerecibe,
        string ipCreacion, string quienEntregaenTX, string observacionPlanilla, DateTime fechaCreacion)
	{

        this.iditem=iditem;
        this.planilla=planilla;
        this.estado=estado;
        this.usuarioResponsableQuerecibe=usuarioResponsableQuerecibe;
        this.ipCreacion=ipCreacion;
        this.quienEntregaenTX = quienEntregaenTX;
        this.observacionPlanilla=observacionPlanilla;
        this.fechaCreacion = fechaCreacion;

	}

    public int Iditem
    {
        set { iditem = value; }
        get { return iditem; }
    }

    public int Planilla
    {
        set { planilla = value; }
        get { return planilla; }
    }

    public int Estado
    {
        set { estado = value; }
        get { return estado; }
    }

    public string UsuarioResponsableQuerecibe
    {
        set { usuarioResponsableQuerecibe = value; }
        get { return usuarioResponsableQuerecibe; }
    }

    public string IpCreacion
    {
        set { ipCreacion = value; }
        get { return ipCreacion; }
    }

    public string QuienEntregaenTX
    {
        set { quienEntregaenTX = value; }
        get { return quienEntregaenTX; }
    }


        public string ObservacionPlanilla
    {
        set { observacionPlanilla = value; }
        get { return observacionPlanilla; }
    }

    public DateTime FechaCreacion
    {
        set { fechaCreacion = value; }
        get { return fechaCreacion; }
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["Iditem"] = int.Parse(iditem.ToString());
        fila["Planilla"] = int.Parse(planilla.ToString());
        fila["Estado"] = int.Parse(estado.ToString());
        fila["UsuarioResponsableQuerecibe"] = usuarioResponsableQuerecibe;
        fila["IpCreacion"] = ipCreacion;
        fila["QuienEntregaenTX"] = quienEntregaenTX;
        fila["ObservacionPlanilla"] = observacionPlanilla;
        fila["FechaCreacion"] = fechaCreacion;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);

    }


    public bool ExistePorElCodigoGenerado(string valor, int valorParte3)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
     
                if (int.Parse(fila["planilla"].ToString()) == valorParte3)
                {
                    Iditem = int.Parse(fila["iditem"].ToString());
                    UsuarioResponsableQuerecibe = fila["UsuarioResponsableQuerecibe"].ToString();
                    FechaCreacion = DateTime.Parse(fila[("fechaCreacion")].ToString());
                    IpCreacion = fila["ipCreacion"].ToString();
                    QuienEntregaenTX = fila["quienEntregaenTX"].ToString();
                    ObservacionPlanilla = fila["observacionPlanilla"].ToString();
                    Estado = int.Parse(fila["estado"].ToString());
                    return true;
                }
        
        }
        return false;
    }


    public bool ExistePorPlanilla(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (int.Parse(fila["planilla"].ToString()) == valor)
            {
                Iditem = int.Parse(fila["iditem"].ToString());
                UsuarioResponsableQuerecibe = fila["UsuarioResponsableQuerecibe"].ToString();
                FechaCreacion = DateTime.Parse(fila[("fechaCreacion")].ToString());
                IpCreacion = fila["ipCreacion"].ToString();
                QuienEntregaenTX = fila["quienEntregaenTX"].ToString();
                ObservacionPlanilla = fila["observacionPlanilla"].ToString();
                Estado = int.Parse(fila["estado"].ToString());
                return true;
            }

        }
        return false;
    }


    public bool ActualizaObservacionEnPlanilla(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["planilla"].ToString()) == valor)
            {
                fila["observacionPlanilla"] = ObservacionPlanilla;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    
    }
}
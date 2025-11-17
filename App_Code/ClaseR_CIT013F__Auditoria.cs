using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de ClaseR_CIT013F__Auditoria
/// </summary>
public class ClaseR_CIT013F__Auditoria : clsconexion
{
    string tabla = "tblCITO_RCIT013_Auditoria";


    protected int idAuditoria;
    protected int audCodigoCaso;
    protected string audDescribeProceso;
    protected string audResponsable;
    protected string audIP;
    protected DateTime audFechayHora;
    protected int audEstado;
    protected string audTextoQueColoca;
    protected string audTextoQueHabia;




    public ClaseR_CIT013F__Auditoria(int idAuditoria, int audCodigoCaso, string audDescribeProceso, string audResponsable, string audIP, DateTime audFechayHora, int audEstado, string audTextoQueColoca, string audTextoQueHabia)
    {
        this.idAuditoria=idAuditoria;
        this.audCodigoCaso=audCodigoCaso;
        this.audDescribeProceso=audDescribeProceso;
        this.audResponsable=audResponsable;
        this.audIP=audIP;
        this.audFechayHora=audFechayHora;
        this.audEstado = audEstado;
        this.audTextoQueColoca = audTextoQueColoca;
        this.audTextoQueHabia = audTextoQueHabia;
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}


    public int IdAuditoria
    {
        set { idAuditoria = value; }
        get { return idAuditoria; }
    }

    public int AudCodigoCaso
    {
        set { audCodigoCaso = value; }
        get { return audCodigoCaso; }
    }

    public string AudDescribeProceso
    {
        set { audDescribeProceso = value; }
        get { return audDescribeProceso; }
    }

    public string AudResponsable
    {
        set { audResponsable = value; }
        get { return audResponsable; }
    }

    public string AudIP
    {
        set { audIP = value; }
        get { return audIP; }
    }

    public DateTime AudFechayHora
    {
        set { audFechayHora = value; }
        get { return audFechayHora; }
    }

    public int AudEstado
    {
        set { audEstado = value; }
        get { return audEstado; }
    }

    public string AudTextoQueColoca
    {
        set { audTextoQueColoca = value; }
        get { return audTextoQueColoca; }
    }

    public string AudTextoQueHabia
    {
        set { audTextoQueHabia = value; }
        get { return audTextoQueHabia; }
    }


    

    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        //
        fila["AudCodigoCaso"] = int.Parse(audCodigoCaso.ToString());
        fila["AudDescribeProceso"] = audDescribeProceso;
        fila["AudResponsable"] = audResponsable;
        fila["AudIP"] = audIP;
        fila["AudFechayHora"] = audFechayHora;
        fila["AudEstado"] = int.Parse(audEstado.ToString());
        fila["AudTextoQueHabia"] = audTextoQueHabia;
        fila["AudTextoQueColoca"] = audTextoQueColoca;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }
}

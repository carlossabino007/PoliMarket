using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de tblCITO_IngSegAuditoria
/// </summary>
public class tblCITO_IngSegAuditoria : clsconexion
{

    string tabla = "tblCITO_IngSegAuditoria";
    protected int id, planillaAAuditar, estado;
    protected string usuario, tipoMvtoCrearEditarDescactivar, comentario, ipdondeEdita;
    protected DateTime fechaMovimiento;

	public tblCITO_IngSegAuditoria(int idItemPlanillaEnElHead,int planillaAAuditar, int estado, string usuario, string ipdondeEdita, string tipoMvtoCrearEditarDescactivar, string comentario,DateTime fechaMovimiento, int id)
    {
    this.planillaAAuditar=planillaAAuditar;
    this.estado=estado;
    this.ipdondeEdita=ipdondeEdita;
    this.tipoMvtoCrearEditarDescactivar=tipoMvtoCrearEditarDescactivar;
    this.comentario=comentario;
    this.fechaMovimiento = fechaMovimiento;		//
    this.id = id;
	}


    public int Id
    {
        set { id = value; }
        get { return id; }
    }

    public int PlanillaAAuditar
    {
        set { planillaAAuditar = value; }
        get { return planillaAAuditar; }
    }

    public int Estado
    {
        set { estado = value; }
        get { return estado; }
    }

    public string IpdondeEdita
    {
        set { ipdondeEdita = value; }
        get { return ipdondeEdita; }
    }

    public string Usuario
    {
        set { usuario = value; }
        get { return usuario; }
    }

        public string TipoMvtoCrearEditarDescactivar
    {
        set { tipoMvtoCrearEditarDescactivar = value; }
        get { return tipoMvtoCrearEditarDescactivar; }
    }


        public string Comentario
    {
        set { Comentario = value; }
        get { return Comentario; }
    }

        public DateTime FechaMovimiento
        {
            set { fechaMovimiento = value; }
            get { return fechaMovimiento; }
        }


        public void agregar()
        {

            conectar(tabla);
            DataRow fila;
            fila = Data.Tables[tabla].NewRow();
            //fila["Id"] = int.Parse(id.ToString());
            fila["PlanillaAAuditar"] = int.Parse(planillaAAuditar.ToString());
            fila["Estado"] = int.Parse(estado.ToString());
            fila["IpdondeEdita"] = ipdondeEdita;
            fila["Usuario"] = usuario;
            fila["TipoMvtoCrearEditarDescactivar"] = tipoMvtoCrearEditarDescactivar;
            fila["Comentario"] = comentario;
            fila["FechaMovimiento"] = fechaMovimiento;
            Data.Tables[tabla].Rows.Add(fila);
            AdaptadorDatos.Update(Data, tabla);

        }
}
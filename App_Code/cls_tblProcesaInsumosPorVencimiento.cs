using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

public class cls_tblProcesaInsumosPorVencimiento: clsconexion
{

    string tabla = "tblProcesaInsumosPorVencimiento";   //  Es como una especie de auditoria para descargue de productos insumos 
    protected int idProcesaPorVencimiento;
    protected int procesaPV_Area;
    protected string procesaPV_usuario;
    protected int procesa_CODDelInsumo;
    protected string procesaPV_IP;
    protected string procesaPV_fechaString;
    protected DateTime procesaPV_fechaSolamente;
    protected DateTime procesaPV_fechaYHora;
    protected int procesaPV_IDDelInsumo;
    protected decimal procesaPV_Descontaria;
    protected decimal procesaPV_Quedando;
    protected int procesaPV_Estado;
    protected string procesaPV_Observaciones;
    protected string procesoPV_Lote;
    protected string procesoPV_ProcedimientoRealizado;
    protected string procesaPV_Medida;


	public cls_tblProcesaInsumosPorVencimiento(int idProcesaPorVencimiento, int procesaPV_Area, string procesaPV_usuario,
        int procesa_CODDelInsumo, string procesaPV_IP, string procesaPV_fechaString, DateTime procesaPV_fechaSolamente,
        DateTime procesaPV_fechaYHora, int procesaPV_IDDelInsumo, decimal procesaPV_Descontaria, decimal procesaPV_Quedando,
        int procesaPV_Estado, string procesaPV_Observaciones, string procesoPV_Lote, string procesoPV_ProcedimientoRealizado,
        string procesaPV_Medida)
	{
    this.idProcesaPorVencimiento=idProcesaPorVencimiento;
    this.procesaPV_Area = procesaPV_Area;
    this.procesaPV_usuario=procesaPV_usuario;
    this.procesa_CODDelInsumo=procesa_CODDelInsumo;
    this.procesaPV_IP=procesaPV_IP;
    this.procesaPV_fechaString=procesaPV_fechaString;
    this.procesaPV_fechaSolamente=procesaPV_fechaSolamente;
    this.procesaPV_fechaYHora=procesaPV_fechaYHora;
    this.procesaPV_IDDelInsumo=procesaPV_IDDelInsumo;
    this.procesaPV_Descontaria=procesaPV_Descontaria;
    this.procesaPV_Quedando=procesaPV_Quedando;
    this.procesaPV_Estado=procesaPV_Estado;
    this.procesaPV_Observaciones = procesaPV_Observaciones;
    this.procesoPV_Lote = procesoPV_Lote;
    this.procesoPV_ProcedimientoRealizado = procesoPV_ProcedimientoRealizado;
    this.procesaPV_Medida = procesaPV_Medida;

	}


    public int IdProcesaPorVencimiento
    {
        get { return idProcesaPorVencimiento; }
        set { idProcesaPorVencimiento = value; }
    }

    public int ProcesaPV_Area
    {
        get { return procesaPV_Area; }
        set { procesaPV_Area = value; }
    }

    public string ProcesaPV_usuario
    {
        get { return procesaPV_usuario; }
        set { procesaPV_usuario = value; }
    }

    public int Procesa_CODDelInsumo
    {
        get { return procesa_CODDelInsumo; }
        set { procesa_CODDelInsumo = value; }
    }

    public string ProcesaPV_IP
    {
        get { return procesaPV_IP; }
        set { procesaPV_IP = value; }
    }

    public string ProcesaPV_fechaString
    {
        get { return procesaPV_fechaString; }
        set { procesaPV_fechaString = value; }
    }

    public DateTime ProcesaPV_fechaSolamente
    {
        get { return procesaPV_fechaSolamente; }
        set { procesaPV_fechaSolamente = value; }
    }

    public DateTime ProcesaPV_fechaYHora
    {
        get { return procesaPV_fechaYHora; }
        set { procesaPV_fechaYHora = value; }
    }

    public int ProcesaPV_IDDelInsumo
    {
        get { return procesaPV_IDDelInsumo; }
        set { procesaPV_IDDelInsumo = value; }
    }

    public decimal ProcesaPV_Descontaria
    {
        get { return procesaPV_Descontaria; }
        set { procesaPV_Descontaria = value; }
    }

    public decimal ProcesaPV_Quedando
    {
        get { return procesaPV_Quedando; }
        set { procesaPV_Quedando = value; }
    }

    public int ProcesaPV_Estado
    {
        get { return procesaPV_Estado; }
        set { procesaPV_Estado = value; }
    }

    public string ProcesaPV_Observaciones
    {
        get { return procesaPV_Observaciones; }
        set { procesaPV_Observaciones = value; }
    }

    public string ProcesoPV_Lote
    {
        get { return procesoPV_Lote; }
        set { procesoPV_Lote = value; }
    }

    public string ProcesoPV_ProcedimientoRealizado
    {
        get { return procesoPV_ProcedimientoRealizado; }
        set { procesoPV_ProcedimientoRealizado = value; }
    }


    public string ProcesaPV_Medida
    {
        get { return procesaPV_Medida; }
        set { procesaPV_Medida = value; }
    }




    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();

        fila["procesaPV_Area"] = int.Parse(ProcesaPV_Area.ToString());
        fila["procesaPV_usuario"] = ProcesaPV_usuario;
        fila["procesa_CODDelInsumo"] = int.Parse(Procesa_CODDelInsumo.ToString());
        fila["procesaPV_IP"] = ProcesaPV_IP;
        fila["procesaPV_fechaString"] = ProcesaPV_fechaString;
        fila["procesaPV_fechaSolamente"] = ProcesaPV_fechaSolamente;
        fila["procesaPV_fechaYHora"] = ProcesaPV_fechaYHora;
        fila["procesaPV_IDDelInsumo"] = int.Parse(ProcesaPV_IDDelInsumo.ToString());
        fila["procesaPV_Descontaria"] = System.Convert.ToDecimal(ProcesaPV_Descontaria);
        fila["procesaPV_Quedando"] = System.Convert.ToDecimal(ProcesaPV_Quedando);
        fila["procesaPV_Estado"] = int.Parse(ProcesaPV_Estado.ToString());
        fila["procesaPV_Observaciones"] = ProcesaPV_Observaciones;
        fila["procesoPV_Lote"] = ProcesoPV_Lote;
        fila["ProcesoPV_ProcedimientoRealizado"] = ProcesoPV_ProcedimientoRealizado;
        fila["ProcesaPV_Medida"] = procesaPV_Medida;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }





    public bool existe(string usuario)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["procesaPV_usuario"].ToString() == usuario)
            {
                IdProcesaPorVencimiento = int.Parse(fila["idProcesaPorVencimiento"].ToString());
                ProcesaPV_Area = int.Parse(fila["procesaPV_Area"].ToString());
                Procesa_CODDelInsumo = int.Parse(fila["procesa_CODDelInsumo"].ToString());
                ProcesaPV_IP = fila["procesaPV_IP"].ToString();
                ProcesaPV_fechaString = fila["procesaPV_fechaString"].ToString();
                ProcesaPV_fechaSolamente = DateTime.Parse(fila[("procesaPV_fechaSolamente")].ToString());
                ProcesaPV_fechaYHora = DateTime.Parse(fila[("procesaPV_fechaYHora")].ToString());
                ProcesaPV_IDDelInsumo = int.Parse(fila["procesaPV_IDDelInsumo"].ToString());
                ProcesaPV_Descontaria = System.Convert.ToDecimal(fila["procesaPV_Descontaria"].ToString());
                ProcesaPV_Quedando = System.Convert.ToDecimal(fila["procesaPV_Quedando"].ToString());
                ProcesaPV_Estado = int.Parse(fila["procesaPV_Estado"].ToString());
                ProcesaPV_Observaciones = fila["procesaPV_Observaciones"].ToString();
                ProcesoPV_Lote = fila["procesoPV_Lote"].ToString();
                ProcesoPV_ProcedimientoRealizado = fila["procesoPV_ProcedimientoRealizado"].ToString();
                ProcesaPV_Medida = fila["procesaPV_Medida"].ToString();
                return true;
            }
        } return false;
    }


    public bool existe(int area, string usuario)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["procesaPV_usuario"].ToString() == usuario)
            {
                if (int.Parse(fila["procesaPV_Area"].ToString()) == area)
                {
                    IdProcesaPorVencimiento = int.Parse(fila["idProcesaPorVencimiento"].ToString());
                    Procesa_CODDelInsumo = int.Parse(fila["procesa_CODDelInsumo"].ToString());
                    ProcesaPV_IP = fila["procesaPV_IP"].ToString();
                    ProcesaPV_fechaString = fila["procesaPV_fechaString"].ToString();
                    ProcesaPV_fechaSolamente = DateTime.Parse(fila[("procesaPV_fechaSolamente")].ToString());
                    ProcesaPV_fechaYHora = DateTime.Parse(fila[("procesaPV_fechaYHora")].ToString());
                    ProcesaPV_IDDelInsumo = int.Parse(fila["procesaPV_IDDelInsumo"].ToString());
                    ProcesaPV_Descontaria = System.Convert.ToDecimal(fila["procesaPV_Descontaria"].ToString());
                    ProcesaPV_Quedando = System.Convert.ToDecimal(fila["procesaPV_Quedando"].ToString());
                    ProcesaPV_Estado = int.Parse(fila["procesaPV_Estado"].ToString());
                    ProcesaPV_Observaciones = fila["procesaPV_Observaciones"].ToString();
                    ProcesoPV_Lote = fila["procesoPV_Lote"].ToString();
                    ProcesoPV_ProcedimientoRealizado = fila["procesoPV_ProcedimientoRealizado"].ToString();
                    ProcesaPV_Medida = fila["procesaPV_Medida"].ToString();
                    return true;
                }
            }
        } return false;
    }




}
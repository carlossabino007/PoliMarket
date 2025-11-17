using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Descripción breve de cls_procesaDetalle
/// </summary>
public class cls_procesaDetalle : clsconexion
{
    string tabla = "tblProcesaDetalle";
    protected int idProcesaDetalle;
    protected int procDet_IDEnELHEad;
    protected string procDet_CodFormula;
    protected int prodDet_IDDelInsumo;
    protected int procDet_Cantidad;
    protected decimal procDet_TengoEnEsteLote;
    protected decimal procDet_ConsumoEnUnaMuestra;
    protected decimal procDet_Descontaria;
    protected decimal procDet_Quedando;
    protected int prodDet_Estado;
    protected decimal procDet_TengoEnGeneral;
    protected int prodDet_CODDelInsumo;
    protected decimal procDet_QuedandoEnGeneral;


	public cls_procesaDetalle(int idProcesaDetalle, int procDet_IDEnELHEad, string procDet_CodFormula,int prodDet_IDDelInsumo,
        int procDet_Cantidad, decimal procDet_TengoEnEsteLote, decimal procDet_ConsumoEnUnaMuestra, decimal procDet_Descontaria,
        decimal procDet_Quedando, int prodDet_Estado, decimal procDet_TengoEnGeneral, int prodDet_CODDelInsumo, decimal procDet_QuedandoEnGeneral)
	{
        this.idProcesaDetalle=idProcesaDetalle;
        this.procDet_IDEnELHEad=procDet_IDEnELHEad;
        this.procDet_CodFormula=procDet_CodFormula;
        this.prodDet_IDDelInsumo=prodDet_IDDelInsumo;
        this.procDet_Cantidad=procDet_Cantidad;
        this.procDet_TengoEnEsteLote=procDet_TengoEnEsteLote;
        this.procDet_ConsumoEnUnaMuestra=procDet_ConsumoEnUnaMuestra;
        this.procDet_Descontaria=procDet_Descontaria;
        this.procDet_Quedando=procDet_Quedando;
        this.prodDet_Estado = prodDet_Estado;
        this.procDet_TengoEnGeneral = procDet_TengoEnGeneral;
        this.prodDet_CODDelInsumo = prodDet_CODDelInsumo;
        this.procDet_QuedandoEnGeneral = procDet_QuedandoEnGeneral;

	}

    public int IdProcesaDetalle
    {
        set { idProcesaDetalle = value; }
        get { return idProcesaDetalle; }
    }

    public int ProcDet_IDEnELHEad
    {
        set { procDet_IDEnELHEad = value; }
        get { return procDet_IDEnELHEad; }
    }

    public string ProcDet_CodFormula
    {
        set { procDet_CodFormula = value; }
        get { return procDet_CodFormula; }
    }

    public int ProdDet_IDDelInsumo
    {
        set { prodDet_IDDelInsumo = value; }
        get { return prodDet_IDDelInsumo; }
    }

    public int ProcDet_Cantidad
    {
        set { procDet_Cantidad = value; }
        get { return procDet_Cantidad; }
    }

    public decimal ProcDet_TengoEnEsteLote
    {
        set { procDet_TengoEnEsteLote = value; }
        get { return procDet_TengoEnEsteLote; }
    }

    public decimal ProcDet_ConsumoEnUnaMuestra
    {
        set { procDet_ConsumoEnUnaMuestra = value; }
        get { return procDet_ConsumoEnUnaMuestra; }
    }

    public decimal ProcDet_Descontaria
    {
        set { procDet_Descontaria = value; }
        get { return procDet_Descontaria; }
    }

    public decimal ProcDet_Quedando
    {
        set { procDet_Quedando = value; }
        get { return procDet_Quedando; }
    }

    public int ProdDet_Estado
    {
        set { prodDet_Estado = value; }
        get { return prodDet_Estado; }
    }

    public decimal ProcDet_TengoEnGeneral
    {
        set { procDet_TengoEnGeneral = value; }
        get { return procDet_TengoEnGeneral; }
    }

    public int ProdDet_CODDelInsumo
    {
        set { prodDet_CODDelInsumo = value; }
        get { return prodDet_CODDelInsumo; }
    }

    public decimal ProcDet_QuedandoEnGeneral
    {
        set { procDet_QuedandoEnGeneral = value; }
        get { return procDet_QuedandoEnGeneral; }
    }



    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["ProcDet_IDEnELHEad"] = int.Parse(procDet_IDEnELHEad.ToString());
        fila["ProcDet_CodFormula"] = procDet_CodFormula;
        fila["ProdDet_IDDelInsumo"] = int.Parse(prodDet_IDDelInsumo.ToString());
        fila["ProcDet_Cantidad"] = int.Parse(procDet_Cantidad.ToString());
        fila["ProcDet_TengoEnEsteLote"] = System.Convert.ToDecimal(procDet_TengoEnEsteLote);
        fila["ProcDet_TengoEnGeneral"] = System.Convert.ToDecimal(procDet_TengoEnGeneral);
        fila["ProcDet_ConsumoEnUnaMuestra"] = System.Convert.ToDecimal(procDet_ConsumoEnUnaMuestra);
        fila["ProcDet_Descontaria"] = System.Convert.ToDecimal(procDet_Descontaria);
        fila["ProcDet_Quedando"] = System.Convert.ToDecimal(procDet_Quedando);
        fila["ProdDet_Estado"] = int.Parse(prodDet_Estado.ToString());
        fila["ProdDet_CODDelInsumo"] = int.Parse(prodDet_CODDelInsumo.ToString());
        fila["ProcDet_QuedandoEnGeneral"] = System.Convert.ToDecimal(procDet_QuedandoEnGeneral);
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    public bool ExistePorElIDGeneradoDesdeElHEad(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["procDet_IDEnELHEad"].ToString().Equals(valor))
            {
                ProcDet_CodFormula = fila["procDet_CodFormula"].ToString();
                ProdDet_IDDelInsumo = int.Parse(fila["prodDet_IDDelInsumo"].ToString());
                ProcDet_Cantidad = int.Parse(fila["procDet_Cantidad"].ToString());
                ProcDet_TengoEnEsteLote = decimal.Parse(fila["procDet_TengoEnEsteLote"].ToString());
                ProcDet_TengoEnGeneral = decimal.Parse(fila["procDet_TengoEnGeneral"].ToString());
                ProcDet_ConsumoEnUnaMuestra = decimal.Parse(fila["procDet_ConsumoEnUnaMuestra"].ToString());
                ProcDet_Descontaria = decimal.Parse(fila["procDet_Descontaria"].ToString());
                ProcDet_Quedando = decimal.Parse(fila["procDet_Quedando"].ToString());
                ProdDet_Estado = int.Parse(fila["prodDet_Estado"].ToString());
                ProdDet_CODDelInsumo = int.Parse(fila["ProdDet_CODDelInsumo"].ToString());
                ProcDet_QuedandoEnGeneral = decimal.Parse(fila["procDet_QuedandoEnGeneral"].ToString());
                return true;
            }
        }

        return false;
    }


















}
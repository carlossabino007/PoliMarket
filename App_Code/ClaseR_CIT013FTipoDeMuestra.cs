using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de ClaseR_CIT013FTipoDeEstudio
/// </summary>
public class ClaseR_CIT013FTipoDeEstudio: clsconexion
{

    string tabla = "tblCITO_TipoDeMuestra";
    protected int idTipodeMuestra;
    protected string describeTipoMuestra;
    protected int estadoTipoMuestra;
    protected string abreviaTipoMuestra;

	public ClaseR_CIT013FTipoDeEstudio(int idTipodeMuestra, string describeTipoMuestra, int estadoTipoMuestra, string abreviaTipoMuestra)
	{
        this.idTipodeMuestra = idTipodeMuestra;
        this.describeTipoMuestra = describeTipoMuestra;
        this.estadoTipoMuestra = estadoTipoMuestra;
        this.abreviaTipoMuestra = abreviaTipoMuestra;
		
	}

    public int IdTipodeMuestra
    {
        set { idTipodeMuestra = value; }
        get { return idTipodeMuestra; }
    }

    public string DescribeTipoMuestra
    {
        set { describeTipoMuestra = value; }
        get { return describeTipoMuestra; }
    }
    public int EstadoTipoMuestra
    {
        set { estadoTipoMuestra = value; }
        get { return estadoTipoMuestra; }
    }

    public string AbreviaTipoMuestra
    {
        set { abreviaTipoMuestra = value; }
        get { return abreviaTipoMuestra; }
    }



    public bool Existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idTipodeMuestra"].ToString()) == valor)
            {
                IdTipodeMuestra = int.Parse(fila["idTipodeMuestra"].ToString());
                DescribeTipoMuestra = fila["describeTipoMuestra"].ToString();
                EstadoTipoMuestra = int.Parse(fila["estadoTipoMuestra"].ToString());
                AbreviaTipoMuestra = fila["AbreviaTipoMuestra"].ToString();
            }
        }
        return false;
    }




}
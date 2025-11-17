using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de cls_tblCITO_IngSegDetalle
/// </summary>
public class cls_tblCITO_IngSegDetalle: clsconexion
{
    string tabla = "tblCITO_IngSegDetalle";
    protected int iditemDetalle, planillaEnElHead, idTipoMuestra, idCodigoEstudioCodInterno, codigoCaso, estado;
    protected string observacion;
    protected int athenea;
    

	public cls_tblCITO_IngSegDetalle(int iditemDetalle, int planillaEnElHead,
         int idTipoMuestra, int idCodigoEstudioCodInterno, int codigoCaso, int estado, string observacion,int athenea)
	{
        this.iditemDetalle=iditemDetalle;
        this.planillaEnElHead=planillaEnElHead;
        this.idTipoMuestra=idTipoMuestra;
        this.idCodigoEstudioCodInterno=idCodigoEstudioCodInterno;
        this.codigoCaso=codigoCaso;
        this.estado = estado;
        this.observacion = observacion;
        this.athenea = athenea;
	}

    public int IditemDetalle
    {
        set { iditemDetalle = value; }
        get { return iditemDetalle; }
    }

    public int PlanillaEnElHead
    {
        set { planillaEnElHead = value; }
        get { return planillaEnElHead; }
    }

    public int IdTipoMuestra
    {
        set { idTipoMuestra = value; }
        get { return idTipoMuestra; }
    }

    public int IdCodigoEstudioCodInterno
    {
        set { idCodigoEstudioCodInterno = value; }
        get { return idCodigoEstudioCodInterno; }
    }

    public int CodigoCaso
    {
        set { codigoCaso = value; }
        get { return codigoCaso; }
    }

    public int Estado
    {
        set { estado = value; }
        get { return estado; }
    }

    public String Observacion
    {
        set { observacion = value; }
        get { return observacion; }
    }

    public int Athenea
    {
        set { athenea = value; }
        get { return athenea; }
    }


    public void agregar()
    {

        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["IditemDetalle"] = int.Parse(iditemDetalle.ToString());
        fila["PlanillaEnElHead"] = int.Parse(planillaEnElHead.ToString());
        fila["IdTipoMuestra"] = int.Parse(idTipoMuestra.ToString());
        fila["IdCodigoEstudioCodInterno"] = int.Parse(idCodigoEstudioCodInterno.ToString());
        fila["CodigoCaso"] = int.Parse(codigoCaso.ToString());
        fila["Estado"] = int.Parse(estado.ToString());
        fila["Observacion"] = observacion;
        fila["Athenea"] = int.Parse(athenea.ToString());
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

            if (int.Parse(fila["PlanillaEnElHead"].ToString()) == valorParte3)
            {
                IditemDetalle = int.Parse(fila["iditemDetalle"].ToString());
                IdTipoMuestra = int.Parse(fila["idTipoMuestra"].ToString());
                IdCodigoEstudioCodInterno = int.Parse(fila["idCodigoEstudioCodInterno"].ToString());
                CodigoCaso = int.Parse(fila["codigoCaso"].ToString());
                Estado = int.Parse(fila["estado"].ToString());
                Athenea = int.Parse(fila["athenea"].ToString());

                Observacion = observacion;
                return true;
            }

        }
        return false;
    }


    public bool ExisteElCasode7digitos(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (int.Parse(fila["CodigoCaso"].ToString()) == valor)
            {
                IditemDetalle = int.Parse(fila["iditemDetalle"].ToString());
                PlanillaEnElHead = int.Parse(fila["planillaEnElHead"].ToString());
                IdTipoMuestra = int.Parse(fila["idTipoMuestra"].ToString());
                IdCodigoEstudioCodInterno = int.Parse(fila["idCodigoEstudioCodInterno"].ToString());
                CodigoCaso = int.Parse(fila["codigoCaso"].ToString());
                Estado = int.Parse(fila["estado"].ToString());
                Observacion = observacion;
                Athenea = int.Parse(fila["athenea"].ToString());
                return true;
            }

        }
        return false;
    }


  

   public bool ExisteYaSehabraUsadoAthenea( int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];

            if (int.Parse(fila["Athenea"].ToString()) == valor)
            {
                return true;
            }

        }
        return false;
    }


}
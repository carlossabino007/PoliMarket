using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class clsContadoresFormatos : clsconexion
{
    string tabla = "tblContadorFormatos";

    protected int con_COM_005;  //   ORDEN DE COMPRA
    protected int con_Cotizacion;
    protected int con_Numero_Para_tblProcesaHead;
    protected int con_R_HLA_002;
    protected int con_R_MOL_045;
    protected int con_CitIngSeguim;


    public clsContadoresFormatos(int con_COM_005, int con_Cotizacion, int con_Numero_Para_tblProcesaHead,
        int con_R_HLA_002, int con_R_MOL_045, int con_CitIngSeguim)
    {
        this.con_COM_005 = con_COM_005;
        this.con_Cotizacion = con_Cotizacion;
        this.con_Numero_Para_tblProcesaHead = con_Numero_Para_tblProcesaHead;
        this.con_R_HLA_002 = con_R_HLA_002;
        this.con_R_MOL_045 = con_R_MOL_045;
        this.con_CitIngSeguim=con_CitIngSeguim;
    }


    public int Con_COM_005
    {
        set { con_COM_005 = value; }
        get { return con_COM_005; }
    }

    public int Con_Cotizacion
    {
        set { con_Cotizacion = value; }
        get { return con_Cotizacion; }
    }

    public int Con_Numero_Para_tblProcesaHead
    {
        set { con_Numero_Para_tblProcesaHead = value; }
        get { return con_Numero_Para_tblProcesaHead; }
    }

    public int Con_R_HLA_002
    {
        set { con_R_HLA_002 = value; }
        get { return con_R_HLA_002; }
    }

    public int Con_R_MOL_045
    {
        set { con_R_MOL_045 = value; }
        get { return con_R_MOL_045; }
    }

        public int Con_CitIngSeguim
    {
        set { con_CitIngSeguim = value; }
        get { return con_CitIngSeguim; }
    }


    public bool LeerContadoresPDF()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            Con_COM_005 = int.Parse(fila["con_COM_005"].ToString());
            Con_Cotizacion = int.Parse(fila["con_Cotizacion"].ToString());
            Con_Numero_Para_tblProcesaHead = int.Parse(fila["con_Numero_Para_tblProcesaHead"].ToString());
            Con_R_HLA_002 = int.Parse(fila["con_R_HLA_002"].ToString());
            Con_R_MOL_045 = int.Parse(fila["con_R_MOL_045"].ToString());
            Con_CitIngSeguim = int.Parse(fila["con_CitIngSeguim"].ToString());  // Citogenetica
        }
        return true;
    }


    public bool Con_COM_005A_Actualizar()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["con_COM_005"] = Con_COM_005;
            AdaptadorDatos.Update(Data, tabla);
        } return true;
    }


    public bool Con_ActualizarContadorCotizacion()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["con_Cotizacion"] = Con_Cotizacion;
            AdaptadorDatos.Update(Data, tabla);
        } return true;
    }


    public bool Con_ActualizarContador_con_Numero_Para_tblProcesaHead()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["con_Numero_Para_tblProcesaHead"] = Con_Numero_Para_tblProcesaHead;
            AdaptadorDatos.Update(Data, tabla);
        } return true;
    }


    public bool Con_Actualizar_Formato_Con_R_HLA_002()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["con_R_HLA_002"] = Con_R_HLA_002;
            AdaptadorDatos.Update(Data, tabla);
        } return true;
    }

    public bool Con_Actualizar_Formato_Con_R_MOL_045()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["con_R_MOL_045"] = Con_R_MOL_045;
            AdaptadorDatos.Update(Data, tabla);
        } return true;
    }


      public bool Con_Actualizar_Con_CitIngSeguim()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            fila["con_CitIngSeguim"] = Con_CitIngSeguim;
            AdaptadorDatos.Update(Data, tabla);
        } return true;
    }




}
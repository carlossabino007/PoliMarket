using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class cls_FormulaDetalle : clsconexion
{
    string tabla = "tblFormulaDetalle";
    protected int idFormulaDetalle, fordetal_CodigoProductoFK;
    protected string fordetal_form_CodigoFK;
    protected decimal fordetal_CantidadDeConsumo;
    protected int fordetal_Estado;

    public cls_FormulaDetalle(int idFormulaDetalle, int fordetal_CodigoProductoFK,
              decimal fordetal_CantidadDeConsumo, string fordetal_form_CodigoFK, int fordetal_Estado)
	{
        // int
        this.idFormulaDetalle = idFormulaDetalle;
        this.fordetal_CodigoProductoFK = fordetal_CodigoProductoFK;
        // decimal
        this.fordetal_CantidadDeConsumo = fordetal_CantidadDeConsumo;

        this.fordetal_form_CodigoFK = fordetal_form_CodigoFK;
        this.fordetal_Estado = fordetal_Estado;
	}


    public int IdFormulaDetalle
    {
        set { idFormulaDetalle = value; }
        get { return idFormulaDetalle; }
    }

    public int Fordetal_CodigoProductoFK
    {
        set { fordetal_CodigoProductoFK = value; }
        get { return fordetal_CodigoProductoFK; }
    }


    public decimal Fordetal_CantidadDeConsumo
    {
        set { fordetal_CantidadDeConsumo = value; }
        get { return fordetal_CantidadDeConsumo; }
    }

    public string Fordetal_form_CodigoFK
    {
        set { fordetal_form_CodigoFK = value; }
        get { return fordetal_form_CodigoFK; }
    }



    public int Fordetal_Estado
    {
        set { fordetal_Estado = value; }
        get { return fordetal_Estado; }
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["idFormulaDetalle"] = int.Parse(IdFormulaDetalle.ToString());
        fila["fordetal_CodigoProductoFK"] = int.Parse(Fordetal_CodigoProductoFK.ToString());
        fila["fordetal_CantidadDeConsumo"] = System.Convert.ToDecimal(Fordetal_CantidadDeConsumo);
        fila["fordetal_form_CodigoFK"] = Fordetal_form_CodigoFK;
        fila["fordetal_Estado"] = int.Parse(Fordetal_Estado.ToString());
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);

    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idFormulaDetalle"].ToString()) == valor)
            {
                Fordetal_CodigoProductoFK = int.Parse(fila["fordetal_CodigoProductoFK"].ToString());
                Fordetal_CantidadDeConsumo = System.Convert.ToDecimal(fila["fordetal_CantidadDeConsumo"].ToString());
                Fordetal_form_CodigoFK = fila["fordetal_form_CodigoFK"].ToString();
                Fordetal_Estado = int.Parse(fila["fordetal_Estado"].ToString());
                return true;
            }
        } return false;
    }


    public int existePorFormulaYCodigoDeproducto(string formu,int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if ((fila["fordetal_form_CodigoFK"].ToString().Equals(formu)))

               if (int.Parse(fila["fordetal_CodigoProductoFK"].ToString()) == valor)
                 {
                    return 1;
                 }
        } 
        return 0;
    }



    public bool actualizar(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idFormulaDetalle"].ToString()) == valor)
            {
                fila["fordetal_CantidadDeConsumo"] = Fordetal_CantidadDeConsumo;
                fila["fordetal_Estado"] = Fordetal_Estado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }
    

}
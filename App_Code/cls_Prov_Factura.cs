using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_Prov_Factura: clsconexion
{
    string tabla = "tblProv_Factura";
    protected int idProd_Factura,  prod_Factura_Estado,prod_Factura_CodProveedor;
    protected string prod_Factura_FacturaNumero, prod_Factura_FacturaFechaString, prod_Factura_Moneda;
    protected decimal prod_Factura_ValorFactura;
    protected DateTime prod_FacturaDateTime;

    public cls_Prov_Factura(int idProd_Factura, int prod_Factura_Estado, string prod_Factura_FacturaNumero, string prod_Factura_FacturaFechaString, int prod_Factura_CodProveedor, decimal prod_Factura_ValorFactura, string prod_Factura_Moneda, DateTime prod_FacturaDateTime)
	{
        this.idProd_Factura = idProd_Factura;
        this.prod_Factura_CodProveedor = prod_Factura_CodProveedor;
        this.prod_Factura_Estado = prod_Factura_Estado;
        this.prod_Factura_FacturaNumero = prod_Factura_FacturaNumero;
        this.prod_Factura_FacturaFechaString = prod_Factura_FacturaFechaString;
        this.prod_Factura_ValorFactura = prod_Factura_ValorFactura;
        this.prod_Factura_Moneda = prod_Factura_Moneda;
        this.prod_FacturaDateTime = prod_FacturaDateTime;
	}

    public int IdProd_Factura
    {
        set { idProd_Factura = value; }
        get { return idProd_Factura; }
    }

    public int Prod_Factura_CodProveedor
    {
        set { prod_Factura_CodProveedor = value; }
        get { return prod_Factura_CodProveedor; }
    }

    public int Prod_Factura_Estado
    {
        set { prod_Factura_Estado = value; }
        get { return prod_Factura_Estado; }
    }

    public string Prod_Factura_FacturaNumero
    {
        set { prod_Factura_FacturaNumero = value; }
        get { return prod_Factura_FacturaNumero; }
    }

    
    public string Prod_Factura_FacturaFechaString
    {
        set { prod_Factura_FacturaFechaString = value; }
        get { return prod_Factura_FacturaFechaString; }
    }


    public decimal Prod_Factura_ValorFactura
    {
        set { prod_Factura_ValorFactura = value; }
        get { return prod_Factura_ValorFactura; }
    }

    public string Prod_Factura_Moneda
    {
        set { prod_Factura_Moneda = value; }
        get { return prod_Factura_Moneda; }
    }

    public DateTime Prod_FacturaDateTime
    {
        set { prod_FacturaDateTime = value; }
        get { return prod_FacturaDateTime; }
    }



    public bool existe(int valor, string factura)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["prod_Factura_CodProveedor"].ToString()) == valor)
            {
                if ((fila["prod_Factura_FacturaNumero"].ToString().Equals(factura)))
                {
                    Prod_Factura_CodProveedor = int.Parse(fila["prod_Factura_CodProveedor"].ToString());
                    Prod_Factura_FacturaNumero = fila["prod_Factura_FacturaNumero"].ToString();
                    Prod_Factura_Estado = int.Parse(fila["prod_Factura_Estado"].ToString());
                    Prod_Factura_ValorFactura = decimal.Parse(fila["prod_Factura_ValorFactura"].ToString());
                    Prod_Factura_FacturaFechaString = fila["prod_Factura_FacturaFechaString"].ToString();
                    Prod_Factura_Moneda = fila["prod_Factura_Moneda"].ToString();
                    IdProd_Factura = int.Parse(fila["idProd_Factura"].ToString());
                    Prod_FacturaDateTime = DateTime.Parse(fila[("prod_FacturaDateTime")].ToString());
                    return true;
                }
            }
        } 
        return false;
    }

    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["prod_Factura_CodProveedor"] = int.Parse(Prod_Factura_CodProveedor.ToString());
        fila["prod_Factura_FacturaNumero"] = Prod_Factura_FacturaNumero;
        fila["prod_Factura_FacturaFechaString"] = Prod_Factura_FacturaFechaString;
        fila["prod_Factura_Estado"] = int.Parse(Prod_Factura_Estado.ToString());
        fila["prod_Factura_ValorFactura"] =System.Convert.ToDecimal(Prod_Factura_ValorFactura);
        fila["prod_Factura_Moneda"] = Prod_Factura_Moneda;
        fila["prod_FacturaDateTime"] = Prod_FacturaDateTime;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }

    public void DevuelvesoloLaFactura(int xidProd_Factura)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProd_Factura"].ToString()) == xidProd_Factura)
            {
                Prod_Factura_Moneda=  fila["prod_Factura_Moneda"].ToString();
            }
        }
        
    }

    public string DevuelveNmeroDeFactura(int xidProd_Factura)
    {
        string sale = "";
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProd_Factura"].ToString()) == xidProd_Factura)
            {
                Prod_Factura_FacturaNumero = fila["prod_Factura_FacturaNumero"].ToString();
                sale = Prod_Factura_FacturaNumero;
                return sale;
            }
        }
        return sale;

    }



}
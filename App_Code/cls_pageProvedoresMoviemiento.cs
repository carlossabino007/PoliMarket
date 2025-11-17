using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_pageProvedoresMovimiento : clsconexion
{
    string tabla = "tblProveedores";

    protected int provCodProveedor;
    protected string provNit, provRazonSocial, provDireccion, provTelefono1, provTelefono2;
    protected string provPersonaContacto, provCelularContacto, provEstado, provCiudadProveedor;
    protected string provObservaciones, proFechaCreacionString;

    public cls_pageProvedoresMovimiento(int provCodProveedor, string provNit, string provRazonSocial, string provDireccion, string provTelefono1, string provTelefono2,
        string provPersonaContacto, string provCelularContacto, string provEstado, string provCiudadProveedor,
        string provObservaciones, string proFechaCreacionString)
    {
        this.provCodProveedor = provCodProveedor;
        this.provNit = provNit;
        this.provRazonSocial = provRazonSocial;
        this.provDireccion = provDireccion;
        this.provTelefono1 = provTelefono1;
        this.provTelefono2 = provTelefono2;
        this.provPersonaContacto = provPersonaContacto;
        this.provCelularContacto = provCelularContacto;
        this.provEstado = provEstado;
        this.provCiudadProveedor = provCiudadProveedor;
        this.provObservaciones = provObservaciones;
        this.proFechaCreacionString = proFechaCreacionString;
    }


    public int ProvCodProveedor
    {
        set { provCodProveedor = value; }
        get { return provCodProveedor; }
    }

    public string ProvNit
    {
        set { provNit = value; }
        get { return provNit; }
    }

    public string ProvDireccion
    {
        set { provDireccion = value; }
        get { return provDireccion; }
    }

    public string ProvRazonSocial
    {
        set { provRazonSocial = value; }
        get { return provRazonSocial; }
    }

    public string ProvTelefono1
    {
        set { provTelefono1 = value; }
        get { return provTelefono1; }
    }
    public string ProvTelefono2
    {
        set { provTelefono2 = value; }
        get { return provTelefono2; }
    }
    public string ProvPersonaContacto
    {
        set { provPersonaContacto = value; }
        get { return provPersonaContacto; }
    }
    public string ProvCelularContacto
    {
        set { provCelularContacto = value; }
        get { return provCelularContacto; }
    }
    public string ProvEstado
    {
        set { provEstado = value; }
        get { return provEstado; }
    }
    public string ProvCiudadProveedor
    {
        set { provCiudadProveedor = value; }
        get { return provCiudadProveedor; }
    }
    public string ProvObservaciones
    {
        set { provObservaciones = value; }
        get { return provObservaciones; }
    }

    public string ProFechaCreacionString
    {
        set { proFechaCreacionString = value; }
        get { return proFechaCreacionString; }
    }


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["provCodProveedor"] = int.Parse(ProvCodProveedor.ToString());
        fila["provNit"] = ProvNit.ToString();
        fila["provDireccion"] = ProvDireccion;
        fila["provRazonSocial"] = ProvRazonSocial;
        fila["provTelefono1"] = ProvTelefono1;
        fila["provTelefono2"] = ProvTelefono2;
        fila["provPersonaContacto"] = ProvPersonaContacto;
        fila["provCelularContacto"] = ProvCelularContacto;
        fila["provEstado"] = ProvEstado;
        fila["provCiudadProveedor"] = ProvCiudadProveedor;
        fila["provObservaciones"] = ProvObservaciones;
        fila["proFechaCreacionString"] = ProFechaCreacionString;
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
            if (int.Parse(fila["provCodProveedor"].ToString()) == valor)
            {
                ProvCodProveedor = int.Parse(fila["provCodProveedor"].ToString());
                ProvNit = fila["provNit"].ToString();
                ProvDireccion = fila["provDireccion"].ToString();
                ProvTelefono1 = fila["provTelefono1"].ToString();
                ProvRazonSocial = fila["provRazonSocial"].ToString();
                ProvTelefono2 = fila["provTelefono2"].ToString();
                ProvPersonaContacto = fila["provPersonaContacto"].ToString();
                ProvCelularContacto = fila["provCelularContacto"].ToString();
                ProvEstado = fila["provEstado"].ToString();
                ProvCiudadProveedor = fila["provCiudadProveedor"].ToString();
                ProvObservaciones = fila["provObservaciones"].ToString();
                ProFechaCreacionString = fila["proFechaCreacionString"].ToString();

                return true;
            }
        } return false;
    }


    public bool actualizar(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["provCodProveedor"].ToString()) == valor)
            {
                //fila["areCodigo"] = AreCodigo;
                fila["provNit"] = ProvNit;
                fila["provDireccion"] = ProvDireccion;
                fila["provTelefono1"] = ProvTelefono1;
                fila["provTelefono2"] = ProvTelefono2;
                fila["provRazonSocial"] = ProvRazonSocial;
                fila["provPersonaContacto"] = ProvPersonaContacto;
                fila["provCelularContacto"] = ProvCelularContacto;
                fila["provEstado"] = ProvEstado;
                fila["provCiudadProveedor"] = ProvCiudadProveedor;
                fila["provObservaciones"] = ProvObservaciones;
                fila["proFechaCreacionString"] = ProFechaCreacionString;

                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool devuelveDescripcionDelProveedor(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["provCodProveedor"].ToString()) == valor)
            {
                ProvRazonSocial = fila["provRazonSocial"].ToString();
                return true;
            }
        } return false;
    }

    public void devuelveDescripcionDelProveedorString(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["provCodProveedor"].ToString()) == valor)
            {
                ProvRazonSocial = fila["provRazonSocial"].ToString();
                
            }
        } 
    }

}
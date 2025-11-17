using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class cls_COM_005_Head: clsconexion
{
    string tabla = "tblR_COM_005_Head";
    protected int idR_COM_005_Autoincrementable;
    protected int r_COM_005_RegistroSeguntblContadorFormatos;
    protected string r_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO;
    protected string r_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString;
    protected int r_COM_005_Provedor;
    protected string r_COM_005_Direccion;
    protected string r_COM_005_Telefono;
    protected string r_COM_005_Cotizacion;
    protected string r_COM_005_CotizacionFecha;
    protected int r_COM_005_OrdenDeCompra;
    protected int r_COM_005_Ciudad;

    protected string r_COM_005_IP;
    protected string r_COM_005_UsuarioQueRegistra;
    protected DateTime r_COM_005_FechaSolamente;
    protected DateTime r_COM_005_FechaYHora;
    protected string r_COM_005_FechaEnString;

    protected DateTime r_COM_005_FechaPedidoSoloFecha;
    protected string r_COM_005_UsuarioSolicitaOrden;



	public cls_COM_005_Head(int idR_COM_005_Autoincrementable, int r_COM_005_RegistroSeguntblContadorFormatos,
       string r_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO, string r_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString,
       int r_COM_005_Provedor, string r_COM_005_Direccion,string r_COM_005_Telefono, string r_COM_005_Cotizacion,
       string r_COM_005_CotizacionFecha, int r_COM_005_OrdenDeCompra, int r_COM_005_Ciudad,
        string r_COM_005_IP, string r_COM_005_UsuarioQueRegistra, DateTime r_COM_005_FechaSolamente, DateTime r_COM_005_FechaYHora,
        string r_COM_005_FechaEnString, DateTime r_COM_005_FechaPedidoSoloFecha, string r_COM_005_UsuarioSolicitaOrden)
	{
        this.idR_COM_005_Autoincrementable = idR_COM_005_Autoincrementable;
        this.r_COM_005_RegistroSeguntblContadorFormatos = r_COM_005_RegistroSeguntblContadorFormatos;
        this.r_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO = r_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO;
        this.r_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString = r_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString;
        this.r_COM_005_Provedor = r_COM_005_Provedor;
        this.r_COM_005_Direccion = r_COM_005_Direccion;
        this.r_COM_005_Telefono = r_COM_005_Telefono;
        this.r_COM_005_Cotizacion = r_COM_005_Cotizacion;
        this.r_COM_005_CotizacionFecha = r_COM_005_CotizacionFecha;
        this.r_COM_005_OrdenDeCompra = r_COM_005_OrdenDeCompra;
        this.r_COM_005_Ciudad = r_COM_005_Ciudad;

        this.r_COM_005_IP=r_COM_005_IP;
        this.r_COM_005_UsuarioQueRegistra=r_COM_005_UsuarioQueRegistra;
        this.r_COM_005_FechaSolamente=r_COM_005_FechaSolamente;
        this.r_COM_005_FechaYHora=r_COM_005_FechaYHora;
        this.r_COM_005_FechaEnString=r_COM_005_FechaEnString;

        this.r_COM_005_FechaPedidoSoloFecha = r_COM_005_FechaPedidoSoloFecha;
        this.r_COM_005_UsuarioSolicitaOrden = r_COM_005_UsuarioSolicitaOrden;
	
	}



    public int IdR_COM_005_Autoincrementable
    {
        set { idR_COM_005_Autoincrementable = value; }
        get { return idR_COM_005_Autoincrementable; }
    }

    public int R_COM_005_RegistroSeguntblContadorFormatos
    {
        set { r_COM_005_RegistroSeguntblContadorFormatos = value; }
        get { return r_COM_005_RegistroSeguntblContadorFormatos; }
    }

    public string R_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO
    {
        set { r_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO = value; }
        get { return r_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO; }
    }
    
    public string R_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString
    {
        set { r_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString = value; }
        get { return r_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString; }
    }

    public int R_COM_005_Provedor
    {
        set { r_COM_005_Provedor = value; }
        get { return r_COM_005_Provedor; }
    }

    public string R_COM_005_Direccion
    {
        set { r_COM_005_Direccion = value; }
        get { return r_COM_005_Direccion; }
    }

    public string R_COM_005_Telefono
    {
        set { r_COM_005_Telefono = value; }
        get { return r_COM_005_Telefono; }
    }


    public string R_COM_005_Cotizacion
    {
        set { r_COM_005_Cotizacion = value; }
        get { return r_COM_005_Cotizacion; }
    }

    public string R_COM_005_CotizacionFecha
    {
        set { r_COM_005_CotizacionFecha = value; }
        get { return r_COM_005_CotizacionFecha; }
    }

    public int R_COM_005_OrdenDeCompra
    {
        set { r_COM_005_OrdenDeCompra = value; }
        get { return r_COM_005_OrdenDeCompra; }
    }

    public int R_COM_005_Ciudad
    {
        set { r_COM_005_Ciudad = value; }
        get { return r_COM_005_Ciudad; }
    }



    public string R_COM_005_IP
    {
        get { return r_COM_005_IP; }
        set { r_COM_005_IP = value; }
    }

    public string R_COM_005_UsuarioQueRegistra
    {
        get { return r_COM_005_UsuarioQueRegistra; }
        set { r_COM_005_UsuarioQueRegistra = value; }
    }

    public DateTime R_COM_005_FechaSolamente
    {
        get { return r_COM_005_FechaSolamente; }
        set { r_COM_005_FechaSolamente = value; }
    }


    public DateTime R_COM_005_FechaYHora
    {
        get { return r_COM_005_FechaYHora; }
        set { r_COM_005_FechaYHora = value; }
    }

    public string R_COM_005_FechaEnString
    {
        get { return r_COM_005_FechaEnString; }
        set { r_COM_005_FechaEnString = value; }
    }


    public DateTime R_COM_005_FechaPedidoSoloFecha
    {
        get { return r_COM_005_FechaPedidoSoloFecha; }
        set { r_COM_005_FechaPedidoSoloFecha = value; }
    }


        public string R_COM_005_UsuarioSolicitaOrden
    {
        get { return r_COM_005_UsuarioSolicitaOrden; }
        set { r_COM_005_UsuarioSolicitaOrden = value; }
    }

    


    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["R_COM_005_RegistroSeguntblContadorFormatos"] = int.Parse(r_COM_005_RegistroSeguntblContadorFormatos.ToString());
        fila["R_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO"] = r_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO;
        fila["R_COM_005_OrdenDeCompra"] = int.Parse(r_COM_005_OrdenDeCompra.ToString());
        fila["R_COM_005_Provedor"] = int.Parse(r_COM_005_Provedor.ToString());
        fila["R_COM_005_Ciudad"] = int.Parse(r_COM_005_Ciudad.ToString()); 
        fila["R_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString"] = r_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString;
        fila["R_COM_005_Direccion"] = r_COM_005_Direccion;
        fila["R_COM_005_Telefono"] = r_COM_005_Telefono;
        fila["R_COM_005_Cotizacion"] = r_COM_005_Cotizacion;
        fila["R_COM_005_CotizacionFecha"] = r_COM_005_CotizacionFecha;

        fila["R_COM_005_IP"] = r_COM_005_IP;
        fila["R_COM_005_UsuarioQueRegistra"] = r_COM_005_UsuarioQueRegistra;
        fila["R_COM_005_FechaEnString"] = r_COM_005_FechaEnString;

        fila["R_COM_005_FechaSolamente"] = r_COM_005_FechaSolamente;
        fila["R_COM_005_FechaYHora"] = r_COM_005_FechaYHora;

        fila["R_COM_005_FechaPedidoSoloFecha"] = r_COM_005_FechaPedidoSoloFecha;
        fila["R_COM_005_UsuarioSolicitaOrden"] = r_COM_005_UsuarioSolicitaOrden;

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);

    }


    public bool ExistePorElCodigoGenerado(string valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["r_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO"].ToString().Equals(valor))
            {
                R_COM_005_RegistroSeguntblContadorFormatos = int.Parse(fila["r_COM_005_RegistroSeguntblContadorFormatos"].ToString());
                R_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO = fila["r_COM_005_RegistroSeguntblContadorFormatosCODIGOGENERADO"].ToString();
                R_COM_005_OrdenDeCompra = int.Parse(fila["r_COM_005_OrdenDeCompra"].ToString());
                R_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString = fila["r_COM_005_FechaPedidoSoloFechaEnStringSoloFechaEnString"].ToString();
                R_COM_005_Provedor = int.Parse(fila["r_COM_005_Provedor"].ToString()); 
                R_COM_005_Ciudad = int.Parse(fila["r_COM_005_Ciudad"].ToString()); 
                R_COM_005_Direccion = fila["r_COM_005_Direccion"].ToString();
                R_COM_005_Telefono = fila["r_COM_005_Telefono"].ToString();
                R_COM_005_Cotizacion = fila["r_COM_005_Cotizacion"].ToString();
                R_COM_005_CotizacionFecha = fila["r_COM_005_CotizacionFecha"].ToString();

                R_COM_005_IP = fila["R_COM_005_IP"].ToString();
                R_COM_005_UsuarioQueRegistra = fila["r_COM_005_UsuarioQueRegistra"].ToString();
                R_COM_005_FechaSolamente = DateTime.Parse(fila[("r_COM_005_FechaSolamente")].ToString());
                R_COM_005_FechaYHora = DateTime.Parse(fila[("r_COM_005_FechaYHora")].ToString());

                R_COM_005_FechaPedidoSoloFecha = DateTime.Parse(fila[("r_COM_005_FechaPedidoSoloFecha")].ToString());
                R_COM_005_UsuarioSolicitaOrden = fila["r_COM_005_UsuarioSolicitaOrden"].ToString();
                return true;


            }
        } return false;
    }









}
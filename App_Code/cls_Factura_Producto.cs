using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Donde Se registran todos productos que se le asignan a una factura de un respectivo proveedor al momento de la creacion del producto
/// </summary>
public class cls_Factura_Producto: clsconexion
{
    string tabla = "tblFactura_Producto";

    protected int idFactura_Produc, factura_Produc_CodProductoFK, factura_Produc_Estado, factura_Produc_Usuario, factura_Product_CodProveedorFK, factura_Product_IDNumfacturaFK;
    protected string factura_Produc_FechaCreacionString,factura_Produc_IP,factura_Produc_PC,factura_Produc_producto_HoraCreacionString;
    protected string factura_UsuarioString;

    
	public cls_Factura_Producto(int idFactura_Produc, int factura_Produc_CodProductoFK, int factura_Produc_Estado, int factura_Produc_Usuario, int factura_Product_IDNumfacturaFK,
        string factura_Produc_NumFacturaFK, string factura_Produc_FechaCreacionString, string factura_Produc_IP, string factura_Produc_PC, string factura_Produc_producto_HoraCreacionString, int factura_Product_CodProveedorFK,
        string factura_UsuarioString)
	{
        // int
        this.idFactura_Produc = idFactura_Produc;
        this.factura_Produc_CodProductoFK = factura_Produc_CodProductoFK;
        this.factura_Produc_Estado = factura_Produc_Estado;
        this.factura_Produc_Usuario = factura_Produc_Usuario;
        // string
        this.factura_Product_IDNumfacturaFK = factura_Product_IDNumfacturaFK;
        this.factura_Produc_FechaCreacionString = factura_Produc_FechaCreacionString;
        this.factura_Produc_IP = factura_Produc_IP;
        this.factura_Produc_PC = factura_Produc_PC;
        this.factura_Produc_producto_HoraCreacionString = factura_Produc_producto_HoraCreacionString;
        this.factura_Product_CodProveedorFK = factura_Product_CodProveedorFK;
        this.factura_UsuarioString = factura_UsuarioString;
		
	}

    public int IdFactura_Produc
    {
        set { idFactura_Produc = value; }
        get { return idFactura_Produc; }
    }

    public int Factura_Produc_CodProductoFK
    {
        set { factura_Produc_CodProductoFK = value; }
        get { return factura_Produc_CodProductoFK; }
    }

    public int Factura_Produc_Estado
    {
        set { factura_Produc_Estado = value; }
        get { return factura_Produc_Estado; }
    }

    public int Factura_Produc_Usuario
    {
        set { factura_Produc_Usuario = value; }
        get { return factura_Produc_Usuario; }
    }

    public int Factura_Product_IDNumfacturaFK
    {
        set { factura_Product_IDNumfacturaFK = value; }
        get { return factura_Product_IDNumfacturaFK; }
    }

    public string Factura_Produc_FechaCreacionString
    {
        set { factura_Produc_FechaCreacionString = value; }
        get { return factura_Produc_FechaCreacionString; }
    }

    public string Factura_Produc_IP
    {
        set { factura_Produc_IP = value; }
        get { return factura_Produc_IP; }
    }

    public string Factura_Produc_PC
    {
        set { factura_Produc_PC = value; }
        get { return factura_Produc_PC; }
    }

    public string Factura_Produc_producto_HoraCreacionString
    {
        set { factura_Produc_producto_HoraCreacionString = value; }
        get { return factura_Produc_producto_HoraCreacionString; }
    }

    public int Factura_Product_CodProveedorFK
    {
        set { factura_Product_CodProveedorFK = value; }
        get { return factura_Product_CodProveedorFK; }
    }

    public string Factura_UsuarioString
    {
        set { factura_UsuarioString = value; }
        get { return factura_UsuarioString; }
    }

    
    

    public bool existe(int xproov, int xrpdrod, string xfact )  // Aun no le estoy usando. no esta completamente hecho
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if ( int.Parse(fila["factura_Product_CodProveedorFK"].ToString()) == xproov) 
                {
                    if (int.Parse(fila["factura_Produc_CodProductoFK"].ToString()) == xproov)
                    {
                        if (fila["factura_Produc_NumFacturaFK"].Equals(xfact))    
                        {
                            //int
                            IdFactura_Produc = int.Parse(fila["idFactura_Produc"].ToString());
                            Factura_Produc_CodProductoFK = int.Parse(fila["factura_Produc_CodProductoFK"].ToString());
                            Factura_Produc_Estado = int.Parse(fila["factura_Produc_Estado"].ToString());
                            Factura_Produc_Usuario = int.Parse(fila["factura_Produc_Usuario"].ToString());
                            Factura_Product_IDNumfacturaFK = int.Parse(fila["factura_Product_IDNumfacturaFK"].ToString());
                            Factura_Produc_FechaCreacionString = fila["factura_Produc_FechaCreacionString"].ToString();
                            Factura_Produc_IP = fila["factura_Produc_IP"].ToString();
                            Factura_Produc_PC = fila["factura_Produc_PC"].ToString();

                            Factura_Product_CodProveedorFK = int.Parse(fila["factura_Product_CodProveedorFK"].ToString());
                            Factura_UsuarioString = fila["factura_UsuarioString"].ToString();
                            // String
                            //Prod_PerteneceAlEstudio = int.Parse(fila["prod_PerteneceAlEstudio"].ToString());
                            //Prod_ConsumoPorPrueba = decimal.Parse(fila["prod_ConsumoPorPrueba"].ToString());
                            return true;
                        }
                    }
            }
        } return false;
    }


    public bool existeProovedorYProducto(int xproov, int xrpdrod)  
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["factura_Product_CodProveedorFK"].ToString()) == xproov)
            {
                    if (int.Parse(fila["factura_Produc_CodProductoFK"].ToString()) == xrpdrod)
                    {
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
        fila["factura_Product_IDNumfacturaFK"] = int.Parse(Factura_Product_IDNumfacturaFK.ToString());
        fila["factura_Produc_CodProductoFK"] = int.Parse(Factura_Produc_CodProductoFK.ToString());
        fila["factura_Produc_Estado"] = int.Parse(Factura_Produc_Estado.ToString());
        fila["factura_Produc_Usuario"] = int.Parse(Factura_Produc_Usuario.ToString());
        fila["factura_Produc_FechaCreacionString"] = Factura_Produc_FechaCreacionString;
        fila["factura_Produc_producto_HoraCreacionString"] = Factura_Produc_producto_HoraCreacionString;
        fila["factura_Produc_IP"] = Factura_Produc_IP;
        fila["factura_Produc_PC"] = Factura_Produc_PC;
        fila["factura_Product_CodProveedorFK"] = int.Parse(Factura_Product_CodProveedorFK.ToString());
        fila["factura_UsuarioString"] = Factura_UsuarioString;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    

}

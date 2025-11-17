using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public class cls_Productos: clsconexion
{

    string tabla = "tblProductos";

    protected int prod_Codigo, prod_Proveedor, prod_Marca, prod_Clasificacion, prod_LoteID_EnTblLotes, prod_Estado, prod_AreaALaQuePertenece, prod_Usuario;
    protected string prod_Descripcion, prod_FacturaNumero, prod_FacturaFechaString, prod_Observaciones, prod_FechaCreacionString, prod_HoraCreacionString,prod_IP, prod_PC;

    
	public cls_Productos(int prod_Codigo, int prod_Proveedor, int prod_Marca, int prod_Clasificacion, int prod_LoteID_EnTblLotes, int  prod_Estado, int prod_AreaALaQuePertenece, int prod_Usuario, string prod_IP, string prod_PC,
        string prod_Descripcion, string prod_FacturaNumero, string prod_FacturaFechaString, string prod_Observaciones, string prod_FechaCreacionString, string prod_HoraCreacionString)
	{
        // Int
        this.prod_Codigo = prod_Codigo;
        this.prod_Proveedor = prod_Proveedor;
        this.prod_Marca = prod_Marca;
        this.prod_Clasificacion = prod_Clasificacion;
        this.prod_LoteID_EnTblLotes = prod_LoteID_EnTblLotes;
        this.prod_Estado = prod_Estado;
        this.prod_AreaALaQuePertenece = prod_AreaALaQuePertenece;
        this.prod_Usuario = prod_Usuario;
        
        // string
        this.prod_IP = prod_IP;
        this.prod_PC = prod_PC;
        this.prod_Descripcion = prod_Descripcion;
        this.prod_FacturaNumero = prod_FacturaNumero;
        this.prod_FacturaFechaString = prod_FacturaFechaString;
        this.prod_Observaciones = prod_Observaciones;
        this.prod_FechaCreacionString=prod_FechaCreacionString;
        this.prod_HoraCreacionString=prod_HoraCreacionString;
	}

    // int
    public int Prod_Codigo
    {
        set { prod_Codigo = value; }
        get { return prod_Codigo; }
    }

    public int Prod_Proveedor
    {
        set { prod_Proveedor = value; }
        get { return prod_Proveedor; }
    }

    public int Prod_Marca
    {
        set { prod_Marca = value; }
        get { return prod_Marca; }
    }

    public int Prod_Clasificacion
    {
        set { prod_Clasificacion = value; }
        get { return prod_Clasificacion; }
    }


    public int Prod_LoteID_EnTblLotes
    {
        set { prod_LoteID_EnTblLotes = value; }
        get { return prod_LoteID_EnTblLotes; }
    }

    public int Prod_Estado
    {
        set { prod_Estado = value; }
        get { return prod_Estado; }
    }

    public int Prod_AreaALaQuePertenece
    {
        set { prod_AreaALaQuePertenece = value; }
        get { return prod_AreaALaQuePertenece; }
    }

    public int Prod_Usuario
    {
        set { prod_Usuario = value; }
        get { return prod_Usuario; }
    }

    public string Prod_IP
    {
        set { prod_IP = value; }
        get { return prod_IP; }
    }

        public string Prod_PC
    {
        set { prod_PC = value; }
        get { return prod_PC; }
    }


    public string Prod_Descripcion
    {
        set { prod_Descripcion = value; }
        get { return prod_Descripcion; }
    }

    public string Prod_FacturaNumero
    {
        set { prod_FacturaNumero = value; }
        get { return prod_FacturaNumero; }
    }

    public string Prod_FacturaFechaString 
    {
        set { prod_FacturaFechaString = value; }
        get { return prod_FacturaFechaString; }
    }

    public string Prod_Observaciones
    {
        set { prod_Observaciones = value; }
        get { return prod_Observaciones; }
    }

    public string Prod_FechaCreacionString
    {
        set { prod_FechaCreacionString = value; }
        get { return prod_FechaCreacionString; }
    }

    public string Prod_HoraCreacionString
    {
        set { prod_HoraCreacionString = value; }
        get { return prod_HoraCreacionString; }
    }


    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["prod_Codigo"].ToString()) == valor)
            {
                Prod_Codigo = int.Parse(fila["prod_Codigo"].ToString());
                Prod_Proveedor = int.Parse(fila["prod_Proveedor"].ToString());
                Prod_Marca = int.Parse(fila["prod_Marca"].ToString());
                Prod_Clasificacion = int.Parse(fila["prod_Clasificacion"].ToString());
                Prod_LoteID_EnTblLotes = int.Parse(fila["prod_LoteID_EnTblLotes"].ToString());
                Prod_Estado = int.Parse(fila["prod_Estado"].ToString());
                Prod_AreaALaQuePertenece = int.Parse(fila["prod_AreaALaQuePertenece"].ToString());
                Prod_Usuario = int.Parse(fila["prod_Usuario"].ToString());
                Prod_IP = fila["prod_IP"].ToString();
                Prod_PC = fila["prod_PC"].ToString();
                Prod_Descripcion = fila["prod_Descripcion"].ToString();
                Prod_FacturaNumero = fila["prod_FacturaNumero"].ToString();
                Prod_FacturaFechaString = fila["Prod_FacturaFechaString"].ToString();
                Prod_Observaciones = fila["prod_Observaciones"].ToString();
                Prod_FechaCreacionString= fila["prod_FechaCreacionString"].ToString();
                Prod_HoraCreacionString= fila["prod_HoraCreacionString"].ToString();

                //Prod_PerteneceAlEstudio = int.Parse(fila["prod_PerteneceAlEstudio"].ToString());
                //Prod_ConsumoPorPrueba = decimal.Parse(fila["prod_ConsumoPorPrueba"].ToString());
                return true;
            }
        } return false;
    }




    public void agregar()
    {

        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["prod_Codigo"] = int.Parse(Prod_Codigo.ToString());
        fila["prod_Proveedor"] = int.Parse(Prod_Proveedor.ToString());
        fila["Prod_Marca"] = int.Parse(Prod_Marca.ToString());
        fila["prod_Clasificacion"] = int.Parse(Prod_Clasificacion.ToString());
        fila["prod_LoteID_EnTblLotes"] = int.Parse(Prod_LoteID_EnTblLotes.ToString());
        fila["prod_Estado"] = int.Parse(Prod_Estado.ToString());
        fila["prod_AreaALaQuePertenece"] = int.Parse(Prod_AreaALaQuePertenece.ToString());
        fila["prod_Usuario"] = int.Parse(Prod_Usuario.ToString());

        fila["prod_IP"] = Prod_IP;
        fila["prod_PC"] = Prod_PC;
        fila["prod_Descripcion"] = Prod_Descripcion;
        fila["prod_FacturaNumero"] = Prod_FacturaNumero;
        fila["prod_FacturaFechaString"] = Prod_FacturaFechaString;
        fila["prod_Observaciones"] = Prod_Observaciones;
        fila["prod_FechaCreacionString"] = Prod_FechaCreacionString;
        fila["prod_HoraCreacionString"] = Prod_HoraCreacionString;

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }




    public bool devuelveDescripcionDelProducto(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["prod_Codigo"].ToString()) == valor)
            {
                Prod_Descripcion = fila["prod_Descripcion"].ToString();
                return true;
            }
        } return false;
    }


    //public void agregar()
    //{
    //    conectar(tabla);
    //    DataRow fila;
    //    fila = Data.Tables[tabla].NewRow();
    //    fila["prod_Codigo"] = int.Parse(Prod_Codigo.ToString());
    //    fila["prod_Descripcion"] = Prod_Descripcion;
    //    fila["prod_Abrevia"] = Prod_Abrevia;
    //    fila["prod_Proveedor"] = int.Parse(Prod_Proveedor.ToString());
    //    fila["prod_Marca"] = int.Parse(prod_Marca.ToString());
    //    fila["prod_Clasificacion"] = int.Parse(prod_Clasificacion.ToString());
    //    fila["prod_CatalogoString"] = Prod_CatalogoString;
    //    fila["prod_LoteString"] = Prod_LoteString;
    //    //fila["prod_ValorUnitario"] = decimal.Parse("Prod_ValorUnitario".ToString());
    //    // Decimal
    //    fila["prod_ValorUnitario"] = System.Convert.ToDecimal(Prod_ValorUnitario);
    //    // Decimal
    //    fila["prod_Por"] = System.Convert.ToDecimal(Prod_Por);
    //    //fila["prod_Por"] = decimal.Parse("Prod_Por".ToString());
    //    // Decimal
    //    fila["prod_MinimoEnExistencia"] = System.Convert.ToDecimal(Prod_MinimoEnExistencia);
    //    //fila["prod_MinimoEnExistencia"] = decimal.Parse("Prod_MinimoEnExistencia".ToString());
    //    // Decimal
    //    fila["prod_ConsumoPorPrueba"] = System.Convert.ToDecimal(Prod_ConsumoPorPrueba);
    //    //fila["prod_ConsumoPorPrueba"] = decimal.Parse("prod_ConsumoPorPrueba".ToString());
    //    // Entero del DrownList
    //    //fila["prod_Presentacion"] = System.Convert.ToInt32(Prod_Presentacion);
    //    fila["prod_Presentacion"] = int.Parse(Prod_Presentacion.ToString());
    //    fila["prod_UnidadDeMedida"] = int.Parse(Prod_UnidadDeMedida.ToString());
    //    fila["prod_FechaVencimientoString"] = Prod_FechaVencimientoString;
    //    fila["prod_PerteneceAlEstudio"] = System.Convert.ToDecimal(Prod_PerteneceAlEstudio);
    //    fila["prod_Observaciones"] = Prod_Observaciones;
    //    fila["prod_Estado"] = System.Convert.ToDecimal(prod_Estado);
    //    //fila["prod_Estado"] = int.Parse("Prod_Estado".ToString());
    //    //fila["prod_FechaCreacionString"] =  Prod_FechaCreacionString;
    //    Data.Tables[tabla].Rows.Add(fila);
    //    AdaptadorDatos.Update(Data, tabla);
    //}


    //public bool MiraSiYaExisteLote(string valor)
    //{
    //    conectar(tabla);
    //    DataRow fila;
    //    int x = Data.Tables[tabla].Rows.Count - 1;
    //    for (int i = 0; i <= x; i++)
    //    {
    //        fila = Data.Tables[tabla].Rows[i];
    //        if (fila["prod_LoteString"].Equals(valor))
    //        {
    //            return true;
    //        }
    //    } return false;
    //}


}
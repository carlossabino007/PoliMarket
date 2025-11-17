using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Grabo el Catalogo y el lote al crear el producto con el proveedor y la factura
/// </summary>
public class cls_paso3_SegrabaElCatalogoLote: clsconexion
{

    string tabla = "tblProductoCatalogoLote";

    protected int idProduct_CatalLote, catalogLote_ProveedorFK, catalogLote_ProductoFK,catalogLote_IDNumFacturaFK, catalogLote_Usuario, catalogoLote_TipoDePresentacionFK, catalogLote_Estado, catalogLote_UnidadDeMedidaFK, catalogLote_AreaUltimoConsumoFK;
    protected string catalogLote_Catalogo, catalogLote_Lote, catalogLote_FechaCreacionString, catalogLote_IP, catalogLote_PC, catalogLote_producto_HoraCreacionString, catalogLote_FechaVencimiento, catalogLote_FechaProyectadaDeVencimiento, catalogLote_FechaUltimoConsumo;
    protected decimal catalogLote_CantidadEnPresentacion, catalogLote_ValorUnitario, catalogLote_ValorUnidadDeMedida, catalogLote_Stock;
    protected string catalogoLote_Predeterminado;
    protected string catalogo_Lote_Abierto;
    protected string catalogo_Lote_Cerrado_Observacion;

    protected DateTime catalogLote_FechaVencimientoFechaYHora;
    protected DateTime catalogLote_FechaVencimientoFechaSolamente;

    protected DateTime catalogLote_FechaProyectadaDeVencimientoFechaYHora;
    protected DateTime catalogLote_FechaProyectadaDeVencimientoFechaSolamente;

    protected Decimal catalogLote_StockConQueInicializa;

    protected int catalogo_Lote_AreaDondePertenece;

    protected DateTime catalogLote_FechaYHora;
    protected DateTime catalogLote_FechaSolamente;

    protected string catalogLote_UsuarioString;





	public cls_paso3_SegrabaElCatalogoLote(
        int idProduct_CatalLote, int catalogLote_ProveedorFK, int catalogLote_ProductoFK, int catalogLote_IDNumFacturaFK, int catalogLote_Usuario, int catalogoLote_TipoDePresentacionFK, int catalogLote_Estado, int catalogLote_UnidadDeMedidaFK, int catalogLote_AreaUltimoConsumoFK,
        string catalogLote_Catalogo, string catalogLote_Lote, string catalogLote_FechaCreacionString, string catalogLote_IP, string catalogLote_PC, string catalogLote_producto_HoraCreacionString, string catalogLote_FechaVencimiento, string catalogLote_FechaProyectadaDeVencimiento, string catalogLote_FechaUltimoConsumo,
        decimal catalogLote_CantidadEnPresentacion, decimal catalogLote_ValorUnitario, decimal catalogLote_ValorUnidadDeMedida, decimal catalogLote_Stock,
        string catalogoLote_Predeterminado, string catalogo_Lote_Abierto, string catalogo_Lote_Cerrado_Observacion,
         DateTime catalogLote_FechaVencimientoFechaYHora,
         DateTime catalogLote_FechaVencimientoFechaSolamente,
         DateTime catalogLote_FechaProyectadaDeVencimientoFechaYHora,
         DateTime catalogLote_FechaProyectadaDeVencimientoFechaSolamente,
        decimal catalogLote_StockConQueInicializa, int catalogo_Lote_AreaDondePertenece,
        DateTime catalogLote_FechaYHora, DateTime catalogLote_FechaSolamente, string catalogLote_UsuarioString)
	{
        //int
        this.idProduct_CatalLote = idProduct_CatalLote;
        this.catalogLote_ProveedorFK = catalogLote_ProveedorFK;
        this.catalogLote_ProductoFK=catalogLote_ProductoFK;
        this.catalogLote_IDNumFacturaFK = catalogLote_IDNumFacturaFK;
        this.catalogLote_Usuario = catalogLote_Usuario;
        this.catalogoLote_TipoDePresentacionFK = catalogoLote_TipoDePresentacionFK;
        this.catalogLote_Estado=catalogLote_Estado;
        this.catalogLote_UnidadDeMedidaFK=catalogLote_UnidadDeMedidaFK;

        this.catalogo_Lote_Abierto = catalogo_Lote_Abierto;

        // string
        this.catalogLote_Catalogo=catalogLote_Catalogo;
        this.catalogLote_Lote=catalogLote_Lote;
        this.catalogLote_FechaCreacionString=catalogLote_FechaCreacionString;
        this.catalogLote_IP=catalogLote_IP;
        this.catalogLote_PC=catalogLote_PC;
        this.catalogLote_producto_HoraCreacionString=catalogLote_producto_HoraCreacionString;
        this.catalogLote_FechaVencimiento=catalogLote_FechaVencimiento;
        this.catalogLote_FechaProyectadaDeVencimiento=catalogLote_FechaProyectadaDeVencimiento;
        this.catalogLote_FechaUltimoConsumo = catalogLote_FechaUltimoConsumo;
        this.catalogLote_AreaUltimoConsumoFK=catalogLote_AreaUltimoConsumoFK;

        this.catalogoLote_Predeterminado = catalogoLote_Predeterminado;
        this.catalogo_Lote_Cerrado_Observacion = catalogo_Lote_Cerrado_Observacion;

        // decimal
        this.catalogLote_CantidadEnPresentacion=catalogLote_CantidadEnPresentacion;
        this.catalogLote_ValorUnitario=catalogLote_ValorUnitario;
        this.catalogLote_ValorUnidadDeMedida=catalogLote_ValorUnidadDeMedida;
        this.catalogLote_Stock = catalogLote_Stock;

        //fecha
        this.catalogLote_FechaVencimientoFechaYHora = catalogLote_FechaVencimientoFechaYHora;
        this.catalogLote_FechaVencimientoFechaSolamente = catalogLote_FechaVencimientoFechaSolamente;
        this.catalogLote_FechaProyectadaDeVencimientoFechaYHora = catalogLote_FechaProyectadaDeVencimientoFechaYHora;
        this.catalogLote_FechaProyectadaDeVencimientoFechaSolamente = catalogLote_FechaProyectadaDeVencimientoFechaSolamente;

        this.catalogLote_StockConQueInicializa = catalogLote_StockConQueInicializa;
        this.catalogo_Lote_AreaDondePertenece = catalogo_Lote_AreaDondePertenece;

        this.catalogo_Lote_AreaDondePertenece = catalogo_Lote_AreaDondePertenece;

        this.catalogLote_FechaYHora = catalogLote_FechaYHora;
        this.catalogLote_FechaSolamente = catalogLote_FechaSolamente;

        this.catalogLote_UsuarioString = catalogLote_UsuarioString;
		
	}


      public int IdProduct_CatalLote
    {
        set { idProduct_CatalLote = value; }
        get { return idProduct_CatalLote; }
    }

      public int CatalogLote_ProveedorFK
    {
        set { catalogLote_ProveedorFK = value; }
        get { return catalogLote_ProveedorFK; }
    }

      public int CatalogLote_ProductoFK
    {
        set { catalogLote_ProductoFK = value; }
        get { return catalogLote_ProductoFK; }
    }

      public int CatalogLote_IDNumFacturaFK
    {
        set { catalogLote_IDNumFacturaFK = value; }
        get { return catalogLote_IDNumFacturaFK; }
    }

      public int CatalogLote_Usuario
    {
        set { catalogLote_Usuario = value; }
        get { return catalogLote_Usuario; }
    }

      public int CatalogoLote_TipoDePresentacionFK
    {
        set { catalogoLote_TipoDePresentacionFK = value; }
        get { return catalogoLote_TipoDePresentacionFK; }
    }

      public int CatalogLote_Estado
    {
        set { catalogLote_Estado = value; }
        get { return catalogLote_Estado; }
    }

    public int CatalogLote_UnidadDeMedidaFK
    {
        set { catalogLote_UnidadDeMedidaFK = value; }
        get { return catalogLote_UnidadDeMedidaFK; }
    }

    public int CatalogLote_AreaUltimoConsumoFK
    {
        set { catalogLote_AreaUltimoConsumoFK = value; }
        get { return catalogLote_AreaUltimoConsumoFK; }
    }

        
        // string

    public string CatalogLote_Catalogo
    {
        set { catalogLote_Catalogo = value; }
        get { return catalogLote_Catalogo; }
    }

    public string CatalogLote_Lote
    {
        set { catalogLote_Lote = value; }
        get { return catalogLote_Lote; }
    }

     public string CatalogLote_FechaCreacionString
    {
        set { catalogLote_FechaCreacionString = value; }
        get { return catalogLote_FechaCreacionString; }
    }

     public string CatalogLote_IP
    {
        set { catalogLote_IP = value; }
        get { return catalogLote_IP; }
    }

    public string CatalogLote_PC
    {
        set { catalogLote_PC = value; }
        get { return catalogLote_PC; }
    }

    public string CatalogLote_producto_HoraCreacionString
    {
        set { catalogLote_producto_HoraCreacionString = value; }
        get { return catalogLote_producto_HoraCreacionString; }
    }


     public string CatalogLote_FechaVencimiento
    {
        set { catalogLote_FechaVencimiento = value; }
        get { return catalogLote_FechaVencimiento; }
    }

      public string CatalogLote_FechaProyectadaDeVencimiento
    {
        set { catalogLote_FechaProyectadaDeVencimiento = value; }
        get { return catalogLote_FechaProyectadaDeVencimiento; }
    }

      public string CatalogLote_FechaUltimoConsumo
    {
        set { catalogLote_FechaUltimoConsumo = value; }
        get { return catalogLote_FechaUltimoConsumo; }
    }

          public string CatalogoLote_Predeterminado
    {
        set { catalogoLote_Predeterminado = value; }
        get { return catalogoLote_Predeterminado; }
    }

    public string Catalogo_Lote_Abierto
    {
        set { catalogo_Lote_Abierto = value; }
        get { return catalogo_Lote_Abierto; }
    }

        public string Catalogo_Lote_Cerrado_Observacion
    {
        set { catalogo_Lote_Cerrado_Observacion = value; }
        get { return catalogo_Lote_Cerrado_Observacion; }
    }


    

        // decimal

     public decimal CatalogLote_CantidadEnPresentacion
    {
        set { catalogLote_CantidadEnPresentacion = value; }
        get { return catalogLote_CantidadEnPresentacion; }
    }
  
     public decimal CatalogLote_ValorUnitario
    {
        set { catalogLote_ValorUnitario = value; }
        get { return catalogLote_ValorUnitario; }
    }


    public decimal CatalogLote_ValorUnidadDeMedida
    {
        set { catalogLote_ValorUnidadDeMedida = value; }
        get { return catalogLote_ValorUnidadDeMedida; }
    }

    public decimal CatalogLote_Stock
    {
        set { catalogLote_Stock = value; }
        get { return catalogLote_Stock; }
    }

       

    public DateTime CatalogLote_FechaVencimientoFechaYHora
    {
        set { catalogLote_FechaVencimientoFechaYHora = value; }
        get { return catalogLote_FechaVencimientoFechaYHora; }
    }
    public DateTime CatalogLote_FechaVencimientoFechaSolamente
    {
        set { catalogLote_FechaVencimientoFechaSolamente = value; }
        get { return catalogLote_FechaVencimientoFechaSolamente; }
    }
    public DateTime CatalogLote_FechaProyectadaDeVencimientoFechaYHora
    {
        set { catalogLote_FechaProyectadaDeVencimientoFechaYHora = value; }
        get { return catalogLote_FechaProyectadaDeVencimientoFechaYHora; }
    }
    public DateTime CatalogLote_FechaProyectadaDeVencimientoFechaSolamente
    {
        set { catalogLote_FechaProyectadaDeVencimientoFechaSolamente = value; }
        get { return catalogLote_FechaProyectadaDeVencimientoFechaSolamente; }
    }

    public decimal CatalogLote_StockConQueInicializa
    {
        set { catalogLote_StockConQueInicializa = value; }
        get { return catalogLote_StockConQueInicializa; }
    }

    public int Catalogo_Lote_AreaDondePertenece
    {
        set { catalogo_Lote_AreaDondePertenece = value; }
        get { return catalogo_Lote_AreaDondePertenece; }
    }

    //   public DateTime CatalogLote_FechaVencimientoFechaYHora
    //{
    //    set { catalogLote_FechaVencimientoFechaYHora = value; }
    //    get { return catalogLote_FechaVencimientoFechaYHora; }
    //}
    

    public DateTime CatalogLote_FechaYHora
    {
        set { catalogLote_FechaYHora = value; }
        get { return catalogLote_FechaYHora; }
    }

    public DateTime CatalogLote_FechaSolamente
    {
        set { catalogLote_FechaSolamente = value; }
        get { return catalogLote_FechaSolamente; }
    }

    public string CatalogLote_UsuarioString
    {
        set { catalogLote_UsuarioString = value; }
        get { return catalogLote_UsuarioString; }
    }


    

    

    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();

        //  Se crea un ID automatica que lo uso para enlazar con la tabla productos y lo g
        //int
        // int
        fila["catalogLote_ProveedorFK"] = int.Parse(CatalogLote_ProveedorFK.ToString());
        fila["catalogLote_ProductoFK"] = int.Parse(CatalogLote_ProductoFK.ToString());
        fila["catalogLote_IDNumFacturaFK"] = int.Parse(CatalogLote_IDNumFacturaFK.ToString());
        fila["catalogLote_Usuario"] = int.Parse(CatalogLote_Usuario.ToString());
        fila["catalogoLote_TipoDePresentacionFK"] = int.Parse(CatalogoLote_TipoDePresentacionFK.ToString());
        fila["catalogLote_Estado"] = int.Parse(CatalogLote_Estado.ToString());
        fila["catalogLote_UnidadDeMedidaFK"] = int.Parse(CatalogLote_UnidadDeMedidaFK.ToString());
        fila["catalogo_Lote_AreaDondePertenece"] = int.Parse(Catalogo_Lote_AreaDondePertenece.ToString());


        //decimal
        fila["catalogLote_CantidadEnPresentacion"] = System.Convert.ToDecimal(CatalogLote_CantidadEnPresentacion);
        fila["catalogLote_ValorUnitario"] = System.Convert.ToDecimal(CatalogLote_ValorUnitario);
        fila["catalogLote_ValorUnidadDeMedida"] = System.Convert.ToDecimal(CatalogLote_ValorUnidadDeMedida);
        fila["catalogLote_Stock"] = System.Convert.ToDecimal(CatalogLote_Stock);

        // string
        fila["catalogLote_Catalogo"] = CatalogLote_Catalogo;
        fila["catalogLote_Lote"] = CatalogLote_Lote;
        fila["catalogLote_FechaCreacionString"] = CatalogLote_FechaCreacionString;
        fila["catalogLote_IP"] = CatalogLote_IP;
        fila["catalogLote_PC"] = CatalogLote_PC;
        fila["catalogLote_producto_HoraCreacionString"] = CatalogLote_producto_HoraCreacionString;
        fila["catalogLote_FechaVencimiento"] = CatalogLote_FechaVencimiento;
        fila["catalogLote_FechaProyectadaDeVencimiento"] = CatalogLote_FechaProyectadaDeVencimiento;
        fila["catalogLote_FechaUltimoConsumo"] = CatalogLote_FechaUltimoConsumo;
        fila["catalogLote_AreaUltimoConsumoFK"] = CatalogLote_AreaUltimoConsumoFK;
        fila["catalogo_Lote_Cerrado_Observacion"] = Catalogo_Lote_Cerrado_Observacion;
        

        fila["catalogoLote_Predeterminado"] = CatalogoLote_Predeterminado;
        fila["catalogo_Lote_Abierto"] = Catalogo_Lote_Abierto;

        //Fecha
        //CatalogLote_FechaVencimientoFechaYHora = DateTime.Parse(fila[("catalogLote_FechaVencimientoFechaYHora")].ToString());
        fila["catalogLote_FechaVencimientoFechaSolamente"] = CatalogLote_FechaVencimientoFechaSolamente;
        //CatalogLote_FechaProyectadaDeVencimientoFechaYHora = DateTime.Parse(fila[("catalogLote_FechaProyectadaDeVencimientoFechaYHora")].ToString());
        //CatalogLote_FechaProyectadaDeVencimientoFechaSolamente = DateTime.Parse(fila[("catalogLote_FechaProyectadaDeVencimientoFechaSolamente")].ToString());

        fila["catalogLote_StockConQueInicializa"] = System.Convert.ToDecimal(CatalogLote_StockConQueInicializa);

        fila["catalogLote_FechaYHora"] = CatalogLote_FechaYHora;
        fila["catalogLote_FechaSolamente"] = CatalogLote_FechaSolamente;

        fila["CatalogLote_UsuarioString"] = catalogLote_UsuarioString;
        

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }


    //public bool existenciaDeDatosAlgunos(int proo, int prod, int idfac)
    //{
    //    conectar(tabla);
    //    DataRow fila;
    //    int x = Data.Tables[tabla].Rows.Count - 1;
    //    for (int i = 0; i <= x; i++)
    //    {
    //        fila = Data.Tables[tabla].Rows[i];
           
    //                if (int.Parse(fila["catalogLote_ProveedorFK"].ToString()) == proo)
    //                {
    //                    if (int.Parse(fila["catalogLote_ProductoFK"].ToString()) == prod)
    //                    {
    //                        if (int.Parse(fila["catalogLote_IDNumFacturaFK"].ToString()) == idfac)
    //                        {
    //                            CatalogLote_Catalogo = fila["catalogLote_Catalogo"].ToString();
    //                            CatalogLote_Lote = fila["catalogLote_Lote"].ToString();
    //                            return true;
    //                        }
    //                    }
    //        }
    //    }
    //    return false;
    //}

    public int existenciaDeDatosTodos(int proo, int prod, int idfac, string cat, string lot)
    {
        int ultimoValor = 0;
        int vale = 0;
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["catalogLote_ProveedorFK"].ToString()) == proo)
            {
                vale = 1;
                if (int.Parse(fila["catalogLote_IDNumFacturaFK"].ToString()) == idfac)
                {
                    vale = 2;
                    if (int.Parse(fila["catalogLote_ProductoFK"].ToString()) == prod)
                    {
                        vale = 3;
                        if ((fila["catalogLote_Catalogo"].ToString().Equals(cat)))
                        {
                            vale = 4;
                            if ((fila["catalogLote_Lote"].ToString().Equals(lot)))
                            {
                                vale = 5;
                                ultimoValor=5;
                                return ultimoValor;
                            }
                        }
                    }
                }
            }
                if (vale > ultimoValor)
                   {
                      ultimoValor = vale;
                   } 
        }  // Fin del ciclo for
        return ultimoValor;
    }



    public bool existePorID(int valor)
    {
        // Para el módulo actualizar catalogo y lote donde puedo modidicar la cantidad, el catalago, el lote y el estado actual
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {

                CatalogLote_ProveedorFK = int.Parse(fila["catalogLote_ProveedorFK"].ToString());
                CatalogLote_ProductoFK = int.Parse(fila["catalogLote_ProductoFK"].ToString());
                CatalogLote_IDNumFacturaFK = int.Parse(fila["catalogLote_IDNumFacturaFK"].ToString());
                CatalogLote_Usuario = int.Parse(fila["catalogLote_Usuario"].ToString());
                CatalogoLote_TipoDePresentacionFK = int.Parse(fila["catalogoLote_TipoDePresentacionFK"].ToString());
                CatalogLote_Estado = int.Parse(fila["catalogLote_Estado"].ToString());
                CatalogLote_UnidadDeMedidaFK = int.Parse(fila["catalogLote_UnidadDeMedidaFK"].ToString());
                CatalogLote_AreaUltimoConsumoFK = int.Parse(fila["catalogLote_AreaUltimoConsumoFK"].ToString());
                Catalogo_Lote_AreaDondePertenece = int.Parse(fila["catalogo_Lote_AreaDondePertenece"].ToString());
                

                // string

                CatalogLote_Lote = fila["catalogLote_Lote"].ToString();
                CatalogLote_Catalogo = fila["catalogLote_Catalogo"].ToString();
                CatalogLote_FechaCreacionString = fila["catalogLote_FechaCreacionString"].ToString();
                CatalogLote_IP = fila["catalogLote_IP"].ToString();
                CatalogLote_PC = fila["catalogLote_PC"].ToString();
                CatalogLote_producto_HoraCreacionString = fila["catalogLote_producto_HoraCreacionString"].ToString();
                CatalogLote_FechaVencimiento = fila["catalogLote_FechaVencimiento"].ToString();
                CatalogLote_FechaProyectadaDeVencimiento = fila["catalogLote_FechaProyectadaDeVencimiento"].ToString();
                CatalogLote_FechaUltimoConsumo = fila["catalogLote_FechaUltimoConsumo"].ToString();

                CatalogoLote_Predeterminado = fila["catalogoLote_Predeterminado"].ToString();
                Catalogo_Lote_Abierto = fila["catalogo_Lote_Abierto"].ToString();
                Catalogo_Lote_Cerrado_Observacion = fila["catalogo_Lote_Cerrado_Observacion"].ToString();
                

                // decimal
                CatalogLote_CantidadEnPresentacion = decimal.Parse(fila["catalogLote_CantidadEnPresentacion"].ToString());
                CatalogLote_ValorUnitario = decimal.Parse(fila["catalogLote_ValorUnitario"].ToString());
                CatalogLote_ValorUnidadDeMedida = decimal.Parse(fila["catalogLote_ValorUnidadDeMedida"].ToString());
                CatalogLote_Stock = decimal.Parse(fila["catalogLote_Stock"].ToString());

                CatalogLote_FechaYHora = DateTime.Parse(fila[("catalogLote_FechaYHora")].ToString());
                CatalogLote_FechaSolamente = DateTime.Parse(fila[("catalogLote_FechaSolamente")].ToString());

                CatalogLote_UsuarioString = fila["catalogLote_UsuarioString"].ToString();


                return true;
            }
        }
        return false;
    }


    public bool actualizarPorIDCatalYLoteEstado(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_Stock"] = CatalogLote_Stock;
                fila["catalogLote_Catalogo"] = CatalogLote_Catalogo;
                fila["catalogLote_Lote"] = CatalogLote_Lote;
                fila["catalogLote_Estado"] = CatalogLote_Estado;
                fila["catalogo_Lote_AreaDondePertenece"] = Catalogo_Lote_AreaDondePertenece;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarPredeterminado(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogoLote_Predeterminado"] = CatalogoLote_Predeterminado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarStock(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_Stock"] = CatalogLote_Stock;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarCatalogo(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_Catalogo"] = CatalogLote_Catalogo;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarLote(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_Lote"] = CatalogLote_Lote;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool actualizarDesactivarLote_Estado(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_Estado"] = CatalogLote_Estado;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }

    public bool Actualizar_CerrarLote(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogo_Lote_Abierto"] = Catalogo_Lote_Abierto;
                fila["catalogo_Lote_Cerrado_Observacion"] = Catalogo_Lote_Cerrado_Observacion;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool Actualizar_Proveedor(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_ProveedorFK"] = CatalogLote_ProveedorFK;
                fila["catalogLote_IDNumFacturaFK"] = CatalogLote_IDNumFacturaFK;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool Actualizar_FechaVencimientor(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_FechaVencimientoFechaSolamente"] = CatalogLote_FechaVencimientoFechaSolamente;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool actualizarLotealProcesar(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_Stock"] = CatalogLote_Stock;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool existePorIDMinimos(int valor)
    {
        // Para el módulo actualizar catalogo y lote donde puedo modidicar la cantidad, el catalago, el lote y el estado actual
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                CatalogLote_UnidadDeMedidaFK = int.Parse(fila["catalogLote_UnidadDeMedidaFK"].ToString());
                CatalogoLote_TipoDePresentacionFK = int.Parse(fila["catalogoLote_TipoDePresentacionFK"].ToString());
                CatalogLote_StockConQueInicializa = decimal.Parse(fila["catalogLote_StockConQueInicializa"].ToString());
                CatalogLote_FechaCreacionString = fila["catalogLote_FechaCreacionString"].ToString();
                CatalogLote_FechaYHora = DateTime.Parse(fila[("catalogLote_FechaYHora")].ToString());
                CatalogLote_FechaSolamente = DateTime.Parse(fila[("catalogLote_FechaSolamente")].ToString());
                CatalogLote_producto_HoraCreacionString = fila["catalogLote_producto_HoraCreacionString"].ToString();
                CatalogLote_FechaVencimientoFechaSolamente = DateTime.Parse(fila[("catalogLote_FechaVencimientoFechaSolamente")].ToString());
                CatalogLote_ProveedorFK = int.Parse(fila["catalogLote_ProveedorFK"].ToString());

                return true;
            }
        }
        return false;
    }

    public bool actualizarUnidadDeMedida(int valor)  //ejemplo ml
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_UnidadDeMedidaFK"] = CatalogLote_UnidadDeMedidaFK;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool actualizarPresentacion(int valor)  // Botellas
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogoLote_TipoDePresentacionFK"] = CatalogoLote_TipoDePresentacionFK;
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


    public bool actualizarSaldoInicial(int valor)
    {
        conectar(tabla);
        DataRow fila;   // es un nuevo  registro Fila de datos
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idProduct_CatalLote"].ToString()) == valor)
            {
                fila["catalogLote_StockConQueInicializa"] = CatalogLote_StockConQueInicializa;
                fila["catalogLote_FechaCreacionString"] = CatalogLote_FechaCreacionString;
                fila["catalogLote_FechaYHora"] = CatalogLote_FechaYHora;
                fila["catalogLote_FechaSolamente"] = CatalogLote_FechaSolamente;
                //fila["catalogLote_producto_HoraCreacionString"] = CatalogLote_producto_HoraCreacionString;              
                AdaptadorDatos.Update(Data, tabla);
                return true;
            }
        } return false;
    }


}